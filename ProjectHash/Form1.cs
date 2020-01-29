using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Concurrent;
using static ProjectHash.Worker;

namespace ProjectHash
{
    public partial class Form1 : Form
    {
        DataTable table;
        ConcurrentBag<FileProjectInfo> r = new ConcurrentBag<FileProjectInfo>();
        public Form1()
        {
            InitializeComponent();
        }
        private void b(Task<FileProjectInfo> t)        
        {
            t.Wait();
            var fpi = t.Result;
            this.r.Add(fpi);
            if (this.InvokeRequired)
            {
                SimpleAction sa = new SimpleAction(AddProgress);
                this.Invoke(sa);
            }
            else
            {
                pb_complete.Value++;
            }           
            Worker w = new Worker();
          
        }


        private delegate void SimpleAction();
        private void AddProgress()
        {
            this.pb_complete.Value++;
            if(pb_complete.Maximum == pb_complete.Value)
            {
                export();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Worker w = new Worker();
            this.pb_complete.Maximum = this.cb_files.CheckedItems.Count;
            this.bt_folderSelect.Enabled = false;
            this.cb_files.Enabled = false;           
            
            foreach(var file in this.cb_files.CheckedItems)
            {
                var g = w.AddFile((file as System.IO.FileInfo).FullName);
                var g2 = g.ContinueWith(b);
                g.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = false;
            ofd.CheckPathExists = true;
            ofd.ValidateNames = false;
            ofd.Multiselect = false;
            ofd.FileName = "Выберите директорию";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tb_folderName.Text = System.IO.Path.GetDirectoryName(ofd.FileName);
            }

        }

        private void export()
        {
            Worker w = new Worker();
            foreach (var item in r)
            {
                //table = w.ImportIntoTable(table, item);
            }
            WordExporter we = new WordExporter();
            try
            {
                we.ExportToFile(this.r.ToList<FileProjectInfo>(), System.IO.Path.Combine(Application.StartupPath, "template.docx"));
            }
            catch(Exception exc)
            {
                MessageBox.Show("Ошибка: " + exc.Message,"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.pb_complete.Value = 0;
            this.pb_complete.Maximum = 1;
            this.cb_files.Items.Clear();
            this.bt_Create.Enabled = true;
            this.bt_folderSelect.Enabled = true;
            this.tb_folderName.Text = "";
            MessageBox.Show("Готово", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void Tb_folderName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.IO.Directory.Exists(tb_folderName.Text))
                {
                    this.cb_files.Items.Clear();
                    var fileList = System.IO.Directory.GetFiles(tb_folderName.Text);
                    foreach (string file in fileList)
                    {
                        cb_files.Items.Add(new System.IO.FileInfo(file), true);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ошибка: " + exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cb_files_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = (e.ListItem as System.IO.FileInfo).Name;
        }
    }
}
