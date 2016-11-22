using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2_FileWriterReader
{
    static class File
    {
        public static void Save(string path, string fileName, string data)
        {
            FileInfo fileInfo = new FileInfo(path + @"\" + fileName);
            if (!fileInfo.Exists)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(fileInfo.FullName))
                    {
                        writer.Write(data);
                    }
                }
                catch (DirectoryNotFoundException e)
                {
                    Logger.Write(e.Message);
                }
            }
            else
            {
                Logger.Write("File " + fileInfo.FullName + " has already existed");
            }
        }
        public static string Read(string path)
        {
            string data = string.Empty;
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    data = reader.ReadToEnd();
                }
            }
            catch (FileNotFoundException e)
            {
                Logger.Write(e.Message);
            }
            catch (FileLoadException e)
            {
                Logger.Write(e.Message);
            }
            return data;
        }
        
    }
}
