using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LerGravaBin
    {
        private const string FILE_NAME = "Test.data" +
            "";
        static void Main(string[] args)
        {
            if (File.Exists(FILE_NAME))
            {
                Console.WriteLine("{0} already exists!", FILE_NAME);
                return;
            }
            using (FileStream fs = new FileStream(FILE_NAME, FileMode.CreateNew))
            {
                using (BinaryWriter w = new BinaryWriter(fs))
                {
                    for (int i = 0;i < 11;i++)
                    {
                        w.Write(i);
                    }
                }
            }
            using (FileStream fs = new FileStream(FILE_NAME, FileMode.Open,FileAccess.Read))
            {
                using (BinaryReader r = new BinaryReader(fs))
                {
                    for (int i = 0; i < 11; i++)
                    {
                        Console.WriteLine(r.ReadInt32());
                    }
                }
            }
        }
    }
}
