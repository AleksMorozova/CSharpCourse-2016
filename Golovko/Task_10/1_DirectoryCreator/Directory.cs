using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1_Directory
{
    class Directory
    {
        public static void Create(string path, string name, int count)
        {
            DirectoryInfo directoryInfo;
            for (int i = 0; i < count; i++)
            {
                directoryInfo = new DirectoryInfo(String.Format(@"{0}\{1}_{2}", path, name, i));
                if (!directoryInfo.Exists)
                {
                    try
                    {
                        directoryInfo.Create();
                        Logger.Write("New directory created: " + directoryInfo.FullName);
                    }
                    catch (DirectoryNotFoundException e)
                    {
                        Logger.Write(e.Message);
                    }
                }
                else
                {
                    Logger.Write("Folder has already created: " + directoryInfo.FullName);
                }
            }            
        }
        public static void Remove(string path, string nameMask, bool recursive)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            if (directoryInfo.Exists)
            {
                foreach (DirectoryInfo directory in directoryInfo.GetDirectories())
                {
                    if (directory.FullName.Contains(nameMask))
                    {
                        directory.Delete(recursive);
                        Logger.Write("Folder has deleted: " + directory.FullName);
                    }

                }
            }
            else
            {
                Logger.Write("The directory by path " + path + " doesn't exist");
            }
        }
    }
}
