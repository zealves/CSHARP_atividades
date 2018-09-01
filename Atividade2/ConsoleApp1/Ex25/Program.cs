using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex25
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files;
            if (Directory.Exists(@"C:\Users\ASUS\Desktop\ProjetosVisualStudios\Atividade2\ConsoleApp1"))
            {
                //  files = Directory.GetFiles(@"C:\Users\tecminho1\Desktop\projetos\Projeto2\Applicacao", @"*.*", SearchOption.TopDirectoryOnly);
                StringBuilder sb = new StringBuilder();
                foreach (string txtName in Directory.GetFiles(@"C:\Users\ASUS\Desktop\ProjetosVisualStudios\Atividade2\ConsoleApp1", "*.*"))
                {
                    using (StreamReader sr = new StreamReader(txtName))
                    {
                        sb.AppendLine(txtName.ToString());
                        sb.AppendLine("= = = = = =");
                        sb.Append(sr.ReadToEnd());
                        sb.AppendLine();
                        sb.AppendLine();

                        Console.WriteLine(txtName);
                    }
                    using (StreamWriter outfile = new StreamWriter(@"C:\Users\ASUS\Desktop\ProjetosVisualStudios\Atividade2\ConsoleApp1\aqui.txt"))
                    {
                        // outfile.Write(sb.ToString());
                        outfile.Write(txtName);

                    }

                }


            }
            else
                Console.WriteLine("não existe");
        }
    }
}
