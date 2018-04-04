using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryFIT
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"D:\");          
            FileInfo[] fi = directory.GetFiles();

            for(int i = 0; i < fi.Length; i++)
            {
                StreamReader sr = new StreamReader(fi[i].FullName);
                string text = sr.ReadToEnd();           
                
                for (int j = 0; j < text.Length - 2; j++)
                {
                    if (text[j] == 'F' && text[j + 1] == 'I' && text[j + 2] == 'T')
                        Console.WriteLine(fi[i].Name);
                }
            }
            Console.ReadKey();
        }
    }
}
