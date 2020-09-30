using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static private SqlConnection cn = new SqlConnection(@"Data Source=HSDANIEL86\SQLEXPRESS;Initial Catalog=ProWay;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            //SqlCommand command = new SqlCommand("select Placar from Painel", cn);
            SqlCommand command  = new SqlCommand("select sum ( Placar) from Painel", cn);
            //DataTable table = new DataTable();
            //adapter.Fill(table);
            //dataGridView1.DataSource = table;
            txttotal.Text = command.ExecuteScalar().ToString();
            cn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand command = new SqlCommand("select count (placar) from painel", cn);
            txttotal.Text = command.ExecuteScalar().ToString();
            cn.Close();
        }
    }
}
