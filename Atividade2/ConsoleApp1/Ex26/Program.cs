using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Ex26
{
    public class Dir
    {
        public string nome;
    }

    class Program
    {
        static void Main(string[] args)
        {
            


            if(Directory.Exists(@"C:\Users\ASUS\Desktop\ProjetosVisualStudios\Atividade2\ConsoleApp1"))
            {
                //  files = Directory.GetFiles(@"C:\Users\tecminho1\Desktop\projetos\Projeto2\Applicacao", @"*.*", SearchOption.TopDirectoryOnly);
                StringBuilder sb = new StringBuilder();
                foreach (string txtName in Directory.GetFiles(@"C:\Users\ASUS\Desktop\ProjetosVisualStudios\Atividade2\ConsoleApp1", "*.*"))
                {
                    using (StreamReader sr = new StreamReader(txtName))
                    {

                        Dir dir = new Dir();
                        dir.nome = txtName.ToString();// sr.ReadToEnd();

                        XmlSerializer writer = new XmlSerializer(typeof(Dir));
                        var path = @"C:\Users\ASUS\Desktop\ProjetosVisualStudios\Atividade2\ConsoleApp1\filexml.xml";
                        FileStream file = File.Create(path);
                        writer.Serialize(file,dir);
                        file.Close();

                    }
                    

                }


            }
            else
                Console.WriteLine("não existe");
        }
    }
}
