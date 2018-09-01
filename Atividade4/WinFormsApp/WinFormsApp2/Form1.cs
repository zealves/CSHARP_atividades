using System;
using System.Windows.Forms;
using System.IO;
namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            DirectoryInfo dirImagem = new DirectoryInfo(@"C:\Users\ASUS\Documents\image");
            FileInfo[] ficheiros;
            ficheiros = dirImagem.GetFiles();
            int numFicheiros;
            numFicheiros = ficheiros.Length;
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = numFicheiros;
            int numFichEscolhido;
            numFichEscolhido = (int)numericUpDown1.Value - 1;
            string caminhoFichEscolhido;
            caminhoFichEscolhido = ficheiros[numFichEscolhido].FullName;
            try
            {
                pictureBox1.BackgroundImage = System.Drawing.Image.FromFile(caminhoFichEscolhido);
                toolTip1.SetToolTip(pictureBox1,caminhoFichEscolhido);
            }
            catch
            {
                pictureBox1.BackgroundImage = null;
                toolTip1.SetToolTip(pictureBox1, "Imagem não disponivel.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
