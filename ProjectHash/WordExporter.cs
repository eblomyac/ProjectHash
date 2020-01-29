using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using static ProjectHash.Worker;

namespace ProjectHash
{
    public class WordExporter:IDisposable
    {
        Application wordApplication;
       

        public WordExporter()
        {           
            wordApplication = new Application();
        }

        public void Dispose()
        {
            this.wordApplication.Quit();
        }

        public void ExportToFile(IList<FileProjectInfo> items,string filePath)
        {


            try {
                Document doc = wordApplication.Documents.Open(filePath);              
                wordApplication.Visible = true;
                
                doc.Activate();
                
                //var Range = doc.Range(0, 0);
                var Table = doc.Tables[1];
                var Table2 = doc.Tables[2];
                //Table.Cell(0, 0).Range.Text = "Номер п/п";
                //Table.Cell(0, 1).Range.Text = "Наименование электронного документа (файла)";
                //Table.Cell(0, 2).Range.Text = "Дата и время последнего изменения документа (файла)";
                //Table.Cell(0, 3).Range.Text = "Размер файла (байт)";
                //Table.Cell(0, 4).Range.Text = "Версия";

                for (int loop = 0; loop < items.Count; loop++)
                {
                    Table.Rows.Add();
                    Table.Cell(loop + 2, 1).Range.Text = (loop + 1).ToString();
                    Table.Cell(loop + 2, 2).Range.Text = items[loop].fileName;
                    Table.Cell(loop + 2, 3).Range.Text = items[loop].lastWriteTime;
                    Table.Cell(loop + 2, 4).Range.Text = items[loop].size;
                    Table.Cell(loop + 2, 5).Range.Text = "1";
                }

                //Table2.Cell(0, 0).Range.Text = "Номер п/п";
                //Table2.Cell(0, 1).Range.Text = "MD5";
                for (int loop = 0; loop < items.Count; loop++)
                {
                    Table2.Rows.Add();
                    Table2.Cell(loop + 2, 1).Range.Text = (loop + 1).ToString();
                    Table2.Cell(loop + 2, 2).Range.Text = items[loop].md5;
                }


            }
            catch(Exception exc)
            {
                throw exc;
            }
            }
       
       
    }
}
