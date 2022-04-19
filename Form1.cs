using System;
using System.Drawing;
using System.Windows.Forms;


namespace ProjectCarRent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void cmdShowCars_click(object sender, EventArgs e)
        {
            ResetButtonColor(cmdShowCar);//call function to change button cmdShowCustomer color
            HidePanels();
            pnlCars.Visible = true;
            Form2 objForm = new Form2();
            objForm.TopLevel = false;
            pnlCars.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        
        void HidePanels()
        {
            pnlCars.Visible = false;
            pnlCustomers.Visible = false;
            pnlRent.Visible = false;
        }

        private void ResetButtonColor(Button B)
        {
            //resets all buttons main menu do default color and then changes clicked button do different color
            cmdShowCustomers.BackColor = Color.FromArgb(13, 33, 47);
            cmdShowCar.BackColor = Color.FromArgb(13, 33, 47);
            cmdRentCar.BackColor = Color.FromArgb(13, 33, 47);
            cmdExit.BackColor = Color.FromArgb(13, 33, 47);
            
            B.BackColor = Color.FromArgb(10, 240, 233);
            B.ForeColor = Color.FromArgb(51, 55, 240);
            
        }
        private void cmdShowCustomers_click(object sender, EventArgs e)
        {
            ResetButtonColor(cmdShowCustomers);//call function to change button cmdShowCustomer color
            HidePanels();//call function to hide all panels to avoid errors
            pnlCustomers.Visible = true;//show customer panel
            Form3 objForm = new Form3();
            objForm.TopLevel = false;
            pnlCustomers.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
           Environment.Exit(0);                                   
        }

        private void cmdShowRent_click(object sender, EventArgs e)
        {
            ResetButtonColor(cmdRentCar);//call function to change button cmdShowCustomer color
            HidePanels();
            pnlRent.Visible = true;
            Form4 objForm2 = new Form4();
            objForm2.TopLevel = false;
            pnlRent.Controls.Add(objForm2);
            objForm2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm2.Dock = DockStyle.Fill;
            objForm2.Show();
        }

        

        private void ExitApp(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

