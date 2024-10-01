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

namespace Doktori
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        messageBox ms;

        private void Form1_Load(object sender, EventArgs e)
        {
            ms = new messageBox();
        }

        public class messageBox
        {
            static public void Show(string bezveze)
            {
                Form2 forma2 = new Form2();
                forma2.Show();
                Application.OpenForms[0].Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
                {
                    MessageBox.Show("Greška");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(@"Data Source=Tin-Macan\SQLEXPRESS;Initial Catalog=Lijecnik;Integrated Security=True"))
                {

                    string upit = "SELECT * FROM Prijava WHERE Username = @username AND Password = @password";

                    SqlCommand cmd = new SqlCommand(upit, connection);
                    cmd.Parameters.Add("@username", textBox1.Text);
                    cmd.Parameters.Add("@password", textBox2.Text);

                    SqlDataReader read = cmd.ExecuteReader();

                    if (read.HasRows)
                    {
                        Form2 forma2 = new Form2();
                        forma2.Show();
                        this.Hide();
                    }
                }
            
            }
            catch
            {
                messageBox.Show("Pogreška!");
            }


        }
    }
}
