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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void dijagnozaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=ANT-HOH\SQLEXPRESS01;Initial Catalog=Lijecnik;Integrated Security=True"))
            {
                string pacijent = textBox1.Text;
                string ime = "", prezime = "";
                int ip = 0;
                for (int i = 0; i < pacijent.Length; i++)
                {
                    if (pacijent[i] == ' ')
                    {
                        ip = 1;
                        continue;
                    }
                    if (ip == 0)
                    {
                        ime += pacijent[i];
                    }
                    else
                    {
                        prezime += pacijent[i];
                    }
                }

                string upit = "SELECT * FROM Dijagnoza INNER JOIN Pacijent on Dijagnoza.PacijentID = Pacijent.ID WHERE Pacijent.Ime = '" + ime + "' " +
                    "AND Pacijent.Prezime =  '" + prezime + "';";

                SqlDataAdapter da = new SqlDataAdapter(upit, connection);

                SqlCommandBuilder SC = new SqlCommandBuilder(da);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                da.Fill(table);
                dataGridView1.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            }
        }
    }
}
