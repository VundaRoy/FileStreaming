using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStreaming
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\oldham.txt";
            if(File.Exists(path))
            { File.Delete(path); }
            File.Create(path);
            
        }
    }
}
