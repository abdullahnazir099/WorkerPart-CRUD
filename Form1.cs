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

namespace workerPart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           SqlConnection con =new SqlConnection("Data Source=DESKTOP-GARLJAI\\SQLEXPRESS;Initial Catalog=Worker;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Table_1 values(@id,@workname,@status)", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@workname",textBox2.Text);
            cmd.Parameters.AddWithValue("@status", textBox3.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("sucessfullay saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GARLJAI\\SQLEXPRESS;Initial Catalog=Worker;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update  Table_1 set workname = @workname,status = @status where id = @id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@workname", textBox2.Text);
            cmd.Parameters.AddWithValue("@status", textBox3.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("sucessfullay updated");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GARLJAI\\SQLEXPRESS;Initial Catalog=Worker;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Table_1 where id =@id",con);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("sucessfullay deleted");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GARLJAI\\SQLEXPRESS;Initial Catalog=Worker;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Table_1", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);  
            DataTable dt = new DataTable();
           da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_FontChanged(object sender, EventArgs e)
        {

        }
    }
}
