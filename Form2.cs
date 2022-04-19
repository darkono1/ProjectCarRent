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

namespace ProjectCarRent
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
             listView1.Items.Clear();
            string connString;
            SqlConnection con;
            connString = @"Data Source=DMAN-PC\SQLEXPRESS;Initial Catalog=CarRental;User ID=darko;Password=kako1";
            con = new SqlConnection(connString);
            con.Open();
            SqlCommand comm;
            SqlDataReader dtr;
            string sql = "select * from Car;";
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

        private void ResetButtonColor(Button B)
        {
            //resets all buttons main menu do default color and then changes clicked button do different color
            cmdMainFrm.BackColor = Color.FromArgb(13, 33, 47);
            cmdUpdateCar.BackColor = Color.FromArgb(13, 33, 47);
            cmdDelete.BackColor = Color.FromArgb(13, 33, 47);
            cmdAddCar.BackColor = Color.FromArgb(13, 33, 47);

            B.BackColor = Color.FromArgb(10, 240, 233);
            B.ForeColor = Color.FromArgb(51, 55, 240);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
           
            using (Form1 form1 = new Form1())
                form1.ShowDialog();
            Show();
        }
       
                
        
        private void cmdAddData_Click(object sender, EventArgs e)
        {
            ResetButtonColor(cmdAddData);
            try
            {
                string connString;
                SqlConnection con;
                connString = @"Data Source=DMAN-PC\SQLEXPRESS;Initial Catalog=CarRental;User ID=darko;Password=kako1";
                con = new SqlConnection(connString);
                con.Open();
                var sql = "INSERT INTO Car(CarID,RegPlate,Manufacturer,Model,Color,PricePerDay) VALUES(@CarID,@RegPlate,@Manufacturer,@Model,@Color,@PricePerDay)";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@CarID", int.Parse(textBox1.Text));
                    cmd.Parameters.AddWithValue("@RegPlate", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Manufacturer", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Model", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Color", textBox5.Text);
                    cmd.Parameters.AddWithValue("@PricePerDay", float.Parse(textBox6.Text));
                    int i= cmd.ExecuteNonQuery();
                    con.Close();
               
                    if (i != 0)
                
                    MessageBox.Show("Data saved!");
                    Form2_Load(this, null);
                                 
                    groupBox1.Visible = false;


                }
            }
            catch
            {
                MessageBox.Show("error!");
                groupBox1.Visible = false;

            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            ResetButtonColor(cmdDelete);
            try
            {
                int ID = int.Parse (listView1.SelectedItems [0].Text );
                string connString;
                SqlConnection con;
                connString = @"Data Source=DMAN-PC\SQLEXPRESS;Initial Catalog=CarRental;User ID=darko;Password=kako1";
                con = new SqlConnection(connString);
                con.Open();
                var sql = "DELETE  FROM Car WHERE CarID=@ID";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    int i = cmd.ExecuteNonQuery();
                    con.Close();

                    if (i != 0)

                        MessageBox.Show("Data saved!");
                    groupBox1.Visible = false;
                    Form2_Load(this, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Form2_Load(this, null);

            }
        }

      

        private void cmdUpdateCar_Click(object sender, EventArgs e)
        {
            ResetButtonColor(cmdUpdateCar);
            try
            { 
           
                  textBox1.Text = (listView1.SelectedItems[0].SubItems[0].Text );
                  textBox2.Text = (listView1.SelectedItems[0].SubItems[1].Text);
                  textBox3.Text = (listView1.SelectedItems[0].SubItems[2].Text);
                  textBox4.Text = (listView1.SelectedItems[0].SubItems[3].Text);
                  textBox5.Text = (listView1.SelectedItems[0].SubItems[4].Text);
                  textBox6.Text = (listView1.SelectedItems[0].SubItems[5].Text);
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
            var sql = "UPDATE Car SET RegPlate=@RegPlate,Manufacturer=@Manufacturer,Model=@Model,Color=@Color,PricePerDay=@PricePerDay WHERE CarID=@CarID";
            using (var cmd = new SqlCommand(sql, con))
               {
                cmd.Parameters.AddWithValue("@CarID", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@RegPlate", textBox2.Text);
                cmd.Parameters.AddWithValue("@Manufacturer", textBox3.Text);
                cmd.Parameters.AddWithValue("@Model", textBox4.Text);
                cmd.Parameters.AddWithValue("@Color", textBox5.Text);
                cmd.Parameters.AddWithValue("@PricePerDay", float.Parse(textBox6.Text));
                int i = cmd.ExecuteNonQuery();
                con.Close();

                if (i != 0)

                    MessageBox.Show("Data changed!");
                 
                    Form2_Load(this,null); 

                    groupBox1.Visible = false;
                }
            }
               catch
               {

                MessageBox.Show("error!");

               }
            }

        private void cmdAddCar_Click_1(object sender, EventArgs e)
        {
            ResetButtonColor(cmdAddCar);
            groupBox1.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            cmdSaveChanges.Visible = false;
            cmdAddData.Visible = true;
        }
    }

     
}
