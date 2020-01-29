namespace ProjectHash
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bt_Create = new System.Windows.Forms.Button();
            this.bt_folderSelect = new System.Windows.Forms.Button();
            this.tb_folderName = new System.Windows.Forms.TextBox();
            this.cb_files = new System.Windows.Forms.CheckedListBox();
            this.pb_complete = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Create
            // 
            this.bt_Create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Create.Location = new System.Drawing.Point(408, 248);
            this.bt_Create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Create.Name = "bt_Create";
            this.bt_Create.Size = new System.Drawing.Size(92, 53);
            this.bt_Create.TabIndex = 0;
            this.bt_Create.Text = "Создать реестр";
            this.bt_Create.UseVisualStyleBackColor = true;
            this.bt_Create.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_folderSelect
            // 
            this.bt_folderSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_folderSelect.Location = new System.Drawing.Point(425, 7);
            this.bt_folderSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_folderSelect.Name = "bt_folderSelect";
            this.bt_folderSelect.Size = new System.Drawing.Size(75, 25);
            this.bt_folderSelect.TabIndex = 1;
            this.bt_folderSelect.Text = "...";
            this.bt_folderSelect.UseVisualStyleBackColor = true;
            this.bt_folderSelect.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_folderName
            // 
            this.tb_folderName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_folderName.Location = new System.Drawing.Point(79, 8);
            this.tb_folderName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_folderName.Name = "tb_folderName";
            this.tb_folderName.Size = new System.Drawing.Size(340, 22);
            this.tb_folderName.TabIndex = 2;
            this.tb_folderName.TextChanged += new System.EventHandler(this.Tb_folderName_TextChanged);
            // 
            // cb_files
            // 
            this.cb_files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_files.CheckOnClick = true;
            this.cb_files.ColumnWidth = 400;
            this.cb_files.FormattingEnabled = true;
            this.cb_files.Location = new System.Drawing.Point(20, 37);
            this.cb_files.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_files.MultiColumn = true;
            this.cb_files.Name = "cb_files";
            this.cb_files.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_files.Size = new System.Drawing.Size(479, 208);
            this.cb_files.TabIndex = 3;
            this.cb_files.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.Cb_files_Format);
            // 
            // pb_complete
            // 
            this.pb_complete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_complete.Location = new System.Drawing.Point(19, 248);
            this.pb_complete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_complete.Name = "pb_complete";
            this.pb_complete.Size = new System.Drawing.Size(383, 53);
            this.pb_complete.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Папка:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 312);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_complete);
            this.Controls.Add(this.cb_files);
            this.Controls.Add(this.tb_folderName);
            this.Controls.Add(this.bt_folderSelect);
            this.Controls.Add(this.bt_Create);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Реестр MD5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Create;
        private System.Windows.Forms.Button bt_folderSelect;
        private System.Windows.Forms.TextBox tb_folderName;
        private System.Windows.Forms.CheckedListBox cb_files;
        private System.Windows.Forms.ProgressBar pb_complete;
        private System.Windows.Forms.Label label1;
    }
}

