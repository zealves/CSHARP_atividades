using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsAppChart_BD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fillChart()
        {
            SqlConnection con = new SqlConnection(@"Data Source=PC14-LAB2\SQLEXPRESS;DataBase=Salarios;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("Select Nome,Salario FROM Salarios", con);
            adapt.Fill(ds);
            chart1.DataSource = ds;
            chart1.Legends[0].Title = "Salários das Pessoas";
            chart1.Series[0].LegendText = "Salário";
            chart1.Series[0].XValueMember = "Nome";
            chart1.Series[0].YValueMembers = "Salario";
            con.Close();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillChart();
        }
    }
}
