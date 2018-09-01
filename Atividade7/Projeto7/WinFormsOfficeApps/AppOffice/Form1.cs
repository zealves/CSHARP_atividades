//using Microsoft.Office.Interop.Excel;
using System;
using System.Windows.Forms;

namespace AppOffice
{
    public partial class Form1 : Form
    {
        string aluno;
        int freq1, freq2;
        float media;
        string aprov;

        Microsoft.Office.Interop.Excel.Application excelApp;

        string livro;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Excel";
            textBox1.Text = null;

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox1.Items.Add("");
            comboBox2.Items.Add("");

            for (int aval = 0; aval <= 20; aval++)
            {
                comboBox1.Items.Add(aval);
                comboBox2.Items.Add(aval);
            }

            comboBox1.Text = null;
            comboBox2.Text = null;
            textBox2.Text = null;
            textBox2.ReadOnly = true;

            IniciarExcel();
            if (VerificaFicheiro() == false)
            {
                CriarFicheiro();
            }
            else
            {
                AbrirFicheiro();
            }

        }

        private void IniciarExcel()
        {
            excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = true;
        }

       private bool VerificaFicheiro()
        {
            livro = Application.StartupPath + "/alunos.xlsx";
            if (System.IO.File.Exists(livro))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void CriarFicheiro()
        {
            excelApp.Workbooks.Add();
            excelApp.Sheets["Folha1"].Select();

            excelApp.Range["A1"].Value = "Nome";
            excelApp.Range["B1"].Value = "T1";
            excelApp.Range["C1"].Value = "T2";
            excelApp.Range["D1"].Value = "Média";
            excelApp.Range["E1"].Value = "Situação";

            FormatarFicheiro();
        }

        private void AbrirFicheiro()
        {
            excelApp.Workbooks.Open(livro);
        }

        private void FormatarFicheiro()
        {
            excelApp.Range["A1:E1"].Font.Bold = true;
            excelApp.Range["A1:E1"].Interior.Color = Microsoft.Office.Interop.Excel.Constants.xlGray50;
            excelApp.Range["A1:E1"].HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;

            excelApp.Columns["A:A"].ColumnWidth = 30;
            excelApp.Columns["B:B"].ColumnWidth = 10;
            excelApp.Columns["C:C"].ColumnWidth = 10;
            excelApp.Columns["D:D"].ColumnWidth = 10;
            excelApp.Columns["E:E"].ColumnWidth = 20;

            if (VerificaFicheiro() == false)
            {
                GravarFicheiroComo();
            }
            else
            {
                GravarFicheiro();
            }
        }

        private void GravarFicheiroComo()
        {
            excelApp.ActiveWorkbook.SaveAs(livro);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarDados() == true)
            {
                CalcularMedia();
            }
        }

        private bool ValidarDados()
        {
            if (textBox1.Text.Length < 2)
            {
                MessageBox.Show("Introduza o nome do aluno:");
                textBox1.SelectAll();
                textBox1.Focus();
                return false;
            }
            if (comboBox1.Text.Length == 0)
            {
                MessageBox.Show("Selecione a avaliação T1:");
                comboBox1.Focus();
                return false;
            }
            if (comboBox2.Text.Length == 0)
            {
                MessageBox.Show("Selecione a avaliação T2:");
                comboBox2.Focus();
                return false;
            }
            return true;
        }

        private void CalcularMedia()
        {
            aluno = textBox1.Text;
            freq1 = int.Parse(comboBox1.Text);
            freq2 = int.Parse(comboBox2.Text);
            media = (freq1 + freq2) / 2;

            if(freq1 < 8 && freq2 < 8)
            {
                aprov = "Reprovado";
            }
            else if (freq1 < 8 && freq2 >= 8)
            {
                aprov = "Repete T1";
            }
            else if (freq2 < 8 && freq1 >= 8)
            {
                aprov = "Repete T2";
            }
            else if (freq1 >= 8 && freq2 >= 8)
            {
                if(media >= 9.5)
                {
                    aprov = "Aprovado";
                }
                else
                {
                    aprov = "Oral";
                }
            }

            textBox2.Text = media + " (" + aprov + ")";
            ExportarExcel();
        }

        private void ExportarExcel()
        {
            excelApp.Sheets["Folha1"].Selec();
            int linhaExcel = 2;
            bool valor = true;

            while (valor == true)
            {
                if (excelApp.Range["A" + linhaExcel].Value != null)
                {
                    valor = true;
                    linhaExcel = linhaExcel + 1;
                }
                else
                {
                    valor = false;
                }
            }

            excelApp.Range["A" + linhaExcel].Value = aluno;
            excelApp.Range["B" + linhaExcel].Value = freq1;
            excelApp.Range["C" + linhaExcel].Value = freq2;
            excelApp.Range["D" + linhaExcel].Value = media;
            excelApp.Range["E" + linhaExcel].Value = aprov;
            FormatarFicheiro();
            Close();

        }
        private void GravarFicheiro()
        {
            excelApp.ActiveWorkbook.Save();
        }


    }
}
