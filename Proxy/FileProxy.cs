using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class FileProxy : IFile
    {
        private string _filePath;
        private File? _file;

        public FileProxy(string filePath)
        {
            _filePath = filePath;
            _file = new File(filePath);
        }

        public double GetSize()
        {
            if (_file != null)
            {
                return _file.GetSize();
            }
            else
            {
                return new FileInfo(_filePath).Length;
            }
        }

        public string GetPath()
        {
            if (_file != null)
            {
                return _file.GetPath();
            }
            else
            {
                return _filePath;
            }
        }

        public byte[] Show()
        {
            if (_file == null)
            {
                _file = new File(_filePath);
            }
            return _file.Show();
        }
    }
}
