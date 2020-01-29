using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace ProjectHash
{
    public class Worker
    {
        public Worker()
        {

        }
        public struct FileProjectInfo
        {
            public string fileName;
            public string lastWriteTime;
            public string md5;
            public string size;
        }
        private FileProjectInfo GetFileProjectInfo(string fileName)
        {
            using (var md5 = MD5.Create())
            {
                var fi = new FileInfo(fileName.ToString());
                FileProjectInfo fpi = new FileProjectInfo();

                fpi.fileName = fi.Name;
                fpi.lastWriteTime = fi.LastWriteTime.ToString("dd.MM.yyyy hh:mm");
                fpi.size = fi.Length.ToString();
                try
                {
                    using (var stream = File.OpenRead(fileName.ToString()))
                    {
                        fpi.md5 = BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "");
                    }
                }
                catch (Exception exc)
                {
                    fpi.md5 = "Ошибка доступа к файлу";
                }
                return fpi;
            }
        }
        public Task<FileProjectInfo> AddFile(string file)
        {
            Func<string, FileProjectInfo> v = new Func<string, FileProjectInfo>(GetFileProjectInfo);
            Task<FileProjectInfo> t = new Task<FileProjectInfo>(()=> v.Invoke(file));
            return t;
        }       
    }
}
