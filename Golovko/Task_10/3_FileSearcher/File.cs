using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace _3_FileSearcher
{
    class File
    {
        private const string compressedExtension = ".zip";
        private readonly FileInfo fileInfo;
        public bool IsCompressed
        {
            get { return IsCompressedExist(); }
            protected set { }
        }
        public long Size { get; protected set; }
        public long CompressedSize
        {
            get { return GetFileSize(fileInfo.FullName + compressedExtension); }
            protected set { }
        }
        public File(FileInfo fileInfo)
        {
            this.fileInfo = fileInfo;
            this.Size = fileInfo.Length;
            this.CompressedSize = 0;
            this.IsCompressed = false;
        }
        public static FileInfo[] Search(string pattern, string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] filesInfo = new FileInfo[0];
            try
            {
                filesInfo = directoryInfo.GetFiles(pattern, SearchOption.AllDirectories);
            }
            catch (DirectoryNotFoundException e)
            {
                Logger.Write(e.Message);
            }
            catch (UnauthorizedAccessException e)
            {
                Logger.Write(e.Message);
            }
            if (filesInfo.Length > 0)
            {
                foreach (FileInfo file in filesInfo)
                {
                    Logger.Write(file.FullName);
                }
            }
            return filesInfo;
        }
        public void Show()
        {
            try
            {
                using (FileStream fileStream = new FileStream(fileInfo.FullName, FileMode.Open))
                {
                    byte[] byteArray = new byte[fileStream.Length];
                    fileStream.Read(byteArray, 0, byteArray.Length);
                    Logger.Write(Encoding.Default.GetString(byteArray));
                }
            }
            catch (FileNotFoundException e)
            {
                Logger.Write(e.Message);
            }
        }
        public void Compress()
        {
            if (!IsCompressed)
            {
                byte[] zipBytes = System.IO.File.ReadAllBytes(fileInfo.FullName);
                using (FileStream stream = new FileStream(fileInfo.FullName + compressedExtension, FileMode.CreateNew))
                {
                    using (GZipStream zip = new GZipStream(stream, CompressionMode.Compress, false))
                    {
                        zip.Write(zipBytes, 0, zipBytes.Length);
                        
                    }                    
                }
                IsCompressed = true;
                CompressedSize = GetFileSize(fileInfo.FullName + compressedExtension);
            }
            else
            {
                Logger.Write("File " + fileInfo.FullName + " has already compressed");
            }
        }
        private bool IsCompressedExist()
        {
            return new FileInfo(fileInfo.FullName + compressedExtension).Exists;
        }
        private long GetFileSize(string path)
        {
            return System.IO.File.ReadAllBytes(path).Length;
        }
    }
}
