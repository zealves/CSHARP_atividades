using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace WinFormsAppBD
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=PC14-LAB2\SQLEXPRESS;DataBase=Utilizador;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;
        public Form1()
        {
            InitializeComponent();
            MostraData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MostraData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.RegistoPessoal", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void LimparData()
        {
            txt_Name.Text = "";
            txt_Profissao.Text = "";
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Profissao.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_Name.Text != "" && txt_Profissao.Text != "")
            {
                cmd = new SqlCommand("UPDATE RegistoPessoal(Nome,Profissao) VALUES(@nome,@prof)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@nome", txt_Name.Text);
                cmd.Parameters.AddWithValue("@prof", txt_Profissao.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registo inserido com sucesso!");
                MostraData();
                LimparData();
            }
            else
            {
                MessageBox.Show("Por favor forneça detalhes!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != "" && txt_Profissao.Text != "")
            {
                cmd = new SqlCommand("UPDATE RegistoPessoal SET Nome=@nome,Profissao=@prof WHERE ID=@id",con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@nome", txt_Name.Text);
                cmd.Parameters.AddWithValue("@prof", txt_Profissao.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registo atualizado com sucesso!");
                con.Close();
                MostraData();
                LimparData();
            }
            else
            {
                MessageBox.Show("Por favor selecione um registo para atualizar!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(ID != 0)
            {
                cmd = new SqlCommand("DELETE RegistoPessoal WHERE ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registo eliminado com sucesso!");
                MostraData();
                LimparData();
            }
            else
            {
                MessageBox.Show("Por favor selecione um registo para eliminar!");
            }
        }
    }
}
