using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proxy;

namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFile file = new FileProxy("AAA?AAAtext.txt");

            var size = file.GetSize();
            var path = file.GetPath();
            var bytes = file.Show();

            Console.WriteLine($"Size: {size}");
            Console.WriteLine($"Path: {path}");
            Console.WriteLine($"Show: {Encoding.UTF8.GetString(bytes)}");
        }
    }
}
