using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCarRent
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void ResetButtonColor(Button B)
        {
            //resets all buttons main menu do default color and then changes clicked button do different color
            cmdMainFrm.BackColor = Color.FromArgb(13, 33, 47);
            cmdUpdateCustomer.BackColor = Color.FromArgb(13, 33, 47);
            cmdDeleteCustomer.BackColor = Color.FromArgb(13, 33, 47);
            cmdAddCustomer.BackColor = Color.FromArgb(13, 33, 47);

            B.BackColor = Color.FromArgb(10, 240, 233);
            B.ForeColor = Color.FromArgb(51, 55, 240);

        }
        private void cmdBack_Click(object sender, EventArgs e)
        {
            ResetButtonColor(cmdMainFrm);
            Hide();
            using (Form1 form1 = new Form1())
                form1.ShowDialog();
            Show();
        }

        private void Form3_Load(object sender, EventArgs e)

        {
            groupBox1.Visible = false;
            listView1.Items.Clear();
            string connString;
            SqlConnection con;
            connString = @"Data Source=DMAN-PC\SQLEXPRESS;Initial Catalog=CarRental;User ID=darko;Password=kako1";
            con = new SqlConnection(connString);
            con.Open();
            SqlCommand comm;
            SqlDataReader dtr;
            string sql = "select * from Customer;";
            comm = new SqlCommand(sql, con);
            dtr = comm.ExecuteReader();

            while (dtr.Read())
            {
                ListViewItem lvit = new ListViewItem(dtr[0].ToString());
                for (int i = 1; i <= dtr.FieldCount - 1; i++)
                {
                    lvit.SubItems.Add(dtr[i].ToString());
                }
                listView1.Items.Add(lvit);

            }

            dtr.Close();
            comm.Dispose();
            con.Close();
        }



        private void addCustomer_Click(object sender, EventArgs e)
        {
            ResetButtonColor(cmdAddCustomer);
            groupBox1.Visible = true;
            cmdAddData.Visible = true;
            cmdSaveChanges.Visible = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }



        private void addData_Click(object sender, EventArgs e)
        {
            
            try
            {
                string connString;
                SqlConnection con;
                connString = @"Data Source=DMAN-PC\SQLEXPRESS;Initial Catalog=CarRental;User ID=darko;Password=kako1";
                con = new SqlConnection(connString);
                con.Open();
                var sql = "INSERT INTO Customer(DriverLicenseID,Name,FamilyName,Country,Adress) VALUES(@DriverLicenseID,@Name,@FamilyName,@Country,@Adress)";
                using (var cmd = new SqlCommand(sql, con))
               {
                    cmd.Parameters.AddWithValue("@DriverLicenseID", int.Parse(textBox1.Text));
                    cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                    cmd.Parameters.AddWithValue("@FamilyName", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Country", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Adress", textBox5.Text);

                   int i = cmd.ExecuteNonQuery();
                    con.Close();
                   
                    if (i != 0)

                   MessageBox.Show("Data saved!");
                   Form3_Load(this, null);
                    groupBox1.Visible = false;
                }
           }
            catch
            {
                MessageBox.Show("Error!Try again!");
                groupBox1.Visible = false;

            }
        }

        private void cmdDeleteCustomer_Click(object sender, EventArgs e)
        {
            ResetButtonColor(cmdDeleteCustomer);
            try
            {
                int ID = int.Parse(listView1.SelectedItems[0].Text);
                string connString;
                SqlConnection con;
                connString = @"Data Source=DMAN-PC\SQLEXPRESS;Initial Catalog=CarRental;User ID=darko;Password=kako1";
                con = new SqlConnection(connString);
                con.Open();
                var sql = "DELETE  FROM Customer WHERE DriverLicenseID=@ID";
                try
                {
                    using (var cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", ID);
                        int i = cmd.ExecuteNonQuery();
                        con.Close();

                        if (i != 0)
                        {
                            MessageBox.Show("Customer deleted!");
                        }

                        groupBox1.Visible = false;
                        Form3_Load(this, null);
                    }
                }
                catch
                {
                    MessageBox.Show("Customer has rented cars and can't be deleted!");
                }
            }
            catch
            {
                MessageBox.Show("Select the customer!");
                Form3_Load(this, null);

            }
        }

        private void cmdUpdateCustomer_Click(object sender, EventArgs e)
        {
            ResetButtonColor(cmdUpdateCustomer);
            try
            {
              
                cmdSaveChanges.Visible = false;
                textBox1.Text = (listView1.SelectedItems[0].SubItems[0].Text);
                textBox2.Text = (listView1.SelectedItems[0].SubItems[1].Text);
                textBox3.Text = (listView1.SelectedItems[0].SubItems[2].Text);
                textBox4.Text = (listView1.SelectedItems[0].SubItems[3].Text);
                textBox5.Text = (listView1.SelectedItems[0].SubItems[4].Text);
                
                groupBox1.Visible = true;
                cmdSaveChanges.Visible = true;
                cmdAddData.Visible = false;


            }
            catch
            {
                MessageBox.Show("Select an item to change!");
            }
        }

        private void cmdSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                string connString;
                SqlConnection con;
                connString = @"Data Source=DMAN-PC\SQLEXPRESS;Initial Catalog=CarRental;User ID=darko;Password=kako1";
                con = new SqlConnection(connString);
                con.Open();
                var sql = "UPDATE Customer SET DriverLicenseID=@ID,Name=@Name, FamilyName=@FamilyName,Country=@Country,Adress=@Adress WHERE DriverLicenseID=@ID";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
                    cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                    cmd.Parameters.AddWithValue("@FamilyName", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Country", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Adress", textBox5.Text);
                    int i = cmd.ExecuteNonQuery();
                    con.Close();

                    if (i != 0)

                        MessageBox.Show("Data changed!");

                    Form3_Load(this, null);

                    groupBox1.Visible = false;
                }
            }
            catch
            {

                MessageBox.Show("error!");
                

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
