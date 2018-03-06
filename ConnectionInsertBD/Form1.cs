using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectionInsertBD
{
    public partial class Form1 : Form
    {
        
         //Conexao com o SQL SERVER 
            SqlConnection connec = new SqlConnection("Data source=DALTON;" + "Initial Catalog=Trabalho2;" + "User id=sysdba2014;" + "Password=Master2014;");
            SqlCommand InsertBd = new SqlCommand();
           
    public Form1()
        {
            InitializeComponent();
        }

    private void Form1_Load(object sender, EventArgs e)
    {

        InsertBd.Connection = connec;

    }

        private void button1_Click(object sender, EventArgs e)
        {

           connec.Open();
           //Inserir dados botao1
           InsertBd.CommandText = "INSERT INTO Funcionario ( Nome, Endereco, Cpf) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "' )";
           InsertBd.ExecuteNonQuery();
           connec.Close();
            
            MessageBox.Show("Dados Inseridos com Sucesso! ");

        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }
    }
}
