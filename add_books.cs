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

namespace MiniProject2._0
{
    public partial class add_books : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\MiniProject2.0\library.mdf;Integrated Security=True");

        public add_books()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into books_info values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+dateTimePicker1.Text+"',"+textBox5.Text+","+textBox6.Text+","+ textBox6.Text+")";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Book Added Successfully");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            
            textBox5.Clear();
            textBox6.Clear();
            textBox1.Focus();
        }
    }
}
