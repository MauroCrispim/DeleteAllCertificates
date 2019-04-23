using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DeleteAllCertificates
{
    class Program
    {
        static void Main(string[] args)
        {


            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\SystemCertificates\\My\\Certificates";

            DirectoryInfo dd = new DirectoryInfo(path);
            foreach (System.IO.FileInfo file in dd.GetFiles())
            {

                Console.WriteLine(file.Name);
                file.Delete();
            }

            Console.Read();
        }
    }
}
