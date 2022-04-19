using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectCarRent
{

    public partial class Form4 : Form
    {
        private const string DataBase_connect_string = @"Data Source=DMAN-PC\SQLEXPRESS;Initial Catalog=CarRental;User ID=darko;Password=kako1";

        private SqlDataReader ExecuteReader(SqlConnection conn, string sql)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            return cmd.ExecuteReader();
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            using (Form1 form1 = new Form1())
                form1.ShowDialog();
            Show();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            cmdReturnCar.Visible = false;
           
            getRentData();
        }

        private void getRentData()
        {            
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            try
            {
                //loading Rent table
                string sql = "select * from Rent";
                using (SqlConnection conn = new SqlConnection(DataBase_connect_string))
                {
                    SqlDataReader dtr = ExecuteReader(conn, sql);                    
                    while (dtr.Read())
                    {
                        ListViewItem lvit = new ListViewItem(dtr[0].ToString());
                        for (int i = 1; i <= dtr.FieldCount - 1; i++)
                        {
                            DateTime d = DateTime.Parse(dtr[3].ToString());
                            if (i == 3)
                            {   //odsjecanje Time od DateTime i ubacivanje u listview objekat
                                DateTime dat = DateTime.Parse(dtr[3].ToString());
                                lvit.SubItems.Add(dat.ToShortDateString());
                            }
                            else if((i==4) && (dtr[4].ToString()!=""))
                            {
                                //odsjecanje Time od DateTime i ubacivanje u listview objekat
                                DateTime dat = DateTime.Parse(dtr[4].ToString());
                               lvit.SubItems.Add(dat.ToShortDateString());

                            }
                            else
                            {
                                lvit.SubItems.Add(dtr[i].ToString());
                            }
                        }
                        listView1.Items.Add(lvit);
                    }
                    dtr.Close();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdRent_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            var sql = "INSERT INTO Rent(DriverLicenseID,CarID,RentDate) VALUES(@DriverLicenseID,@CarID,@RentDate)";
            InsertRentInfo(sql);
            listView1.Items.Clear();
            getRentData();


        }
        private void InsertRentInfo(string sql)
        {
            try
            {
                //Rent a car-insert rent info into Rent table
                string connString;
                SqlConnection con;
                connString = DataBase_connect_string;
                con = new SqlConnection(connString);
                con.Open();
                string CarID = cmbCar.SelectedItem.ToString();
                CarID = CarID.Substring(0, CarID.IndexOf(" "));
                using (var cmd = new SqlCommand(sql, con))
                {
                    string DrivLicID = cmbCustomer.SelectedItem.ToString();
                    cmd.Parameters.AddWithValue("@DriverLicenseID", int.Parse(DrivLicID.Substring(0, DrivLicID.IndexOf(" "))));
                    cmd.Parameters.AddWithValue("@CarID", int.Parse(CarID));
                    cmd.Parameters.AddWithValue("@RentDate", DateTime.Now.ToShortDateString());

                    int i = cmd.ExecuteNonQuery();
                    con.Close();

                    if (i != 0)
                        MessageBox.Show("Data saved!");
                    Form4_Load(this, null);
                    groupBox1.Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Select the car and the customer first!");
            }
        }
        private void InsertReturnedCarInfo()
        {
            try
            {
                //Return car and charge rent
                string connString;
                SqlConnection con;
                connString = DataBase_connect_string;
                con = new SqlConnection(connString);
                string RetCarID = cmbReturnCar.SelectedItem.ToString().Substring(0, cmbReturnCar.SelectedItem.ToString().IndexOf(" "));
                            
                decimal RentCharged = Convert.ToDecimal(txtPayAmount.Text);
                
                string sql = "UPDATE Rent SET DateOfReturn=@DateOfRet,ChargedRent=@ChargedRent WHERE CarID=@RetCarID AND DateOfReturn IS NULL";
                con.Open();
                using (var cmd = new SqlCommand(sql, con))
                {
                    DateTime DateOfReturn = DateTime.Parse((monthCalendar1.SelectionRange.Start).ToString());
                    cmd.Parameters.AddWithValue("@RetCarID", RetCarID);
                    cmd.Parameters.AddWithValue("@DateOfRet",DateOfReturn.ToShortDateString());
                    cmd.Parameters.AddWithValue("@ChargedRent",decimal.Parse(txtPayAmount.Text));
                    int i = cmd.ExecuteNonQuery();
                    con.Close();

                    if (i != 0)
                        MessageBox.Show("Data saved!");
                    Form4_Load(this, null);
                    groupBox1.Visible = false;
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cmdReturnCar_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
                      
            try
            {                
                InsertReturnedCarInfo();
                listView1.Items.Clear();
                getRentData();
            }
            catch
            {
                MessageBox.Show("Error!First you must select the car to return and date of return.Try again!");
            }

        }
        private void RentACar_Click_1(object sender, EventArgs e)
        {
            groupBox1.Visible = true;         
            groupBox2.Visible = false;
            //SQL query selects cars with empty DateOfReturn(rented) or cars not rented before-cars available for rent
            cmbCar.Items.Clear();
            cmbCustomer.Items.Clear();
            string availableCars = "SELECT CarID,Manufacturer,model FROM Car WHERE CarID IN(SELECT CarID from Rent WHERE DateOfReturn IS NOT NULL) OR CarID NOT IN(SELECT CarID FROM Rent)";
            string AllCustomers = "SELECT DriverLicenseID,Name,FamilyName FROM Customer";
             getCarData(availableCars);
             getCustomerData(AllCustomers);         

        }

        private void getCustomerData(string sqlCustomer)
        {
            //loading Customers into combo box cmdCustomer
            try
            {
                using (SqlConnection conn = new SqlConnection(DataBase_connect_string))
                {
                    SqlDataReader dtr = ExecuteReader(conn, sqlCustomer);
                    while (dtr.Read())
                    {
                            string cmbCust;
                            cmbCust = dtr[0].ToString() + " " + dtr[1].ToString() + " " + dtr[2].ToString();
                            cmbCustomer.Items.Add(cmbCust);                                               
                    }
                    dtr.Close();
                    conn.Close();
                }
            }
            catch
            {
                MessageBox.Show("Error!Try again!");
            }
        }
        private string getCustReturningCarData(string CustReturningCar)
        {
            try
            {
                //loading customer who rented selected car into txtCustomerInfo
                using (SqlConnection conn = new SqlConnection(DataBase_connect_string))
                {
                    string data = "";
                    SqlDataReader dtr = ExecuteReader(conn,CustReturningCar);  
                    while (dtr.Read())
                    {
                        data = dtr[0].ToString() + " " + dtr[1].ToString() + " " + dtr[2].ToString();
                    }
                    dtr.Close();
                    conn.Close();
                    return data;
                }
            }
            catch
            {
                MessageBox.Show("Error!Try again!");
                return "error";
            }
        }

        private void getCarData(string sqlCar)
        {
            try 
            {
                //loading Cars in combo box cmbCar if DateOfReturn is empty  in Rent table
                using (SqlConnection conn = new SqlConnection(DataBase_connect_string))
                {
                    SqlDataReader dtr = ExecuteReader(conn, sqlCar);
                    while (dtr.Read())
                    {
                        string Cars;
                        Cars = dtr[0].ToString() + " " + dtr[1].ToString() + " " + dtr[2].ToString();
                        //if car is to be rented, cmbCar is loaded,if it is to be returned, cmbReturnCar is loaded
                        cmbCar.Items.Add(Cars);
                        cmbReturnCar.Items.Add(Cars);
                    }
                    dtr.Close();
                    conn.Close();
                }
            }
              catch 
            {
                MessageBox.Show("Error!Try again!");
            }
        }

        private void ReturnCar_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible = false;
            cmbReturnCar.Items.Clear();
            string rentedCars = "SELECT CarID,Manufacturer,model FROM Car WHERE CarID IN(SELECT CarID from Rent WHERE DateOfReturn IS NULL)";
            //gets rented cars-those that have empty DateOfReturn in Rent table
            getCarData(rentedCars);

        }         

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            cmdReturnCar.Visible = true;
            try
            {
                //calculates days between rent and return, multiplies by price per day of rented car, for total rent cost
                DateTime d1 = DateTime.Parse(monthCalendar1.SelectionRange.Start.ToShortDateString());
                string RentDate = $"SELECT RentDate,DriverLicenseID,CarID FROM Rent WHERE CarID={RetCarID} AND DateOfReturn IS NULL";
                string RentingDate = (getCustReturningCarData(RentDate));
                RentingDate = RentingDate.Substring(0, RentingDate.IndexOf(" "));
                DateTime d2 = DateTime.Parse(RentingDate);
                string Price = $"SELECT PricePerDay,Manufacturer,Model From Car WHERE CarID={RetCarID}";
                string PricePerDay = getCustReturningCarData(Price);
                PricePerDay = PricePerDay.Substring(0, PricePerDay.IndexOf(" "));
                txtPayAmount.Text = (float.Parse((d1 - d2).Days.ToString()) * float.Parse(PricePerDay)).ToString();
                if (float.Parse(txtPayAmount.Text) < 0)
                {
                    MessageBox.Show("Selected date of return is earlier than date of renting!Try again.");
                    txtPayAmount.Text = " ";
                }
            }
            catch
            {
                MessageBox.Show("First select the car to return, than select date of return.Try again.");
            }
        }

        public string RetCarID;
        private void cmbReturnCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //takes selected CarID from cmbReturnCar and reads data of the customer that rented the car, and loads data in txtCustomerInfo
            int ReturnCarID = int.Parse(cmbReturnCar.SelectedItem.ToString().Substring(0, cmbReturnCar.SelectedItem.ToString().IndexOf(" ")));; ;
            RetCarID = ReturnCarID.ToString();
            string CustReturningCar = $"SELECT DriverLicenseID,Name,FamilyName FROM Customer WHERE DriverLicenseID=(SELECT DriverLicenseID FROM Rent WHERE CarID={RetCarID} AND DateOfReturn IS NULL)";
            string data=getCustReturningCarData(CustReturningCar);
            txtCustomerInfo.Text= data;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible =false ;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }

}
            

