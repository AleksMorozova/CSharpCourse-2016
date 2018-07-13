using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_1
{
    class FilesHandler : IFilesHandler
    {
        private readonly IDictionary<string, AbstractHandler> files;

        public FilesHandler()
        {
            files = new Dictionary<string, AbstractHandler>();
        }
        public AbstractHandler GetHandler(string extension)
        {
            return files[extension.ToLower()];
        }

        public void Register(string extension, AbstractHandler handler)
        {
            files.Add(extension.ToLower(), handler);
        }
    }
}
