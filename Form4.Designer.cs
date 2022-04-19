
namespace ProjectCarRent
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.RentID = new System.Windows.Forms.ColumnHeader();
            this.DriverLicenseID = new System.Windows.Forms.ColumnHeader();
            this.CarID = new System.Windows.Forms.ColumnHeader();
            this.RentDate = new System.Windows.Forms.ColumnHeader();
            this.DateOfReturn = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.cmdMainFrm = new System.Windows.Forms.Button();
            this.cmdReturCar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdRent = new System.Windows.Forms.Button();
            this.cmbCar = new System.Windows.Forms.ComboBox();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdCanc = new System.Windows.Forms.Button();
            this.txtCustomerInfo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPayAmount = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbReturnCar = new System.Windows.Forms.ComboBox();
            this.cmdReturnCar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdRentACar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RentID,
            this.DriverLicenseID,
            this.CarID,
            this.RentDate,
            this.DateOfReturn,
            this.columnHeader1});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listView1.ForeColor = System.Drawing.Color.DarkBlue;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 29);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(535, 210);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // RentID
            // 
            this.RentID.Text = "RentID";
            this.RentID.Width = 80;
            // 
            // DriverLicenseID
            // 
            this.DriverLicenseID.Text = "DriverLicenseID";
            this.DriverLicenseID.Width = 98;
            // 
            // CarID
            // 
            this.CarID.Text = "CarID";
            this.CarID.Width = 70;
            // 
            // RentDate
            // 
            this.RentDate.Text = "RentDate";
            this.RentDate.Width = 97;
            // 
            // DateOfReturn
            // 
            this.DateOfReturn.Text = "DateOfReturn";
            this.DateOfReturn.Width = 95;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ChargedRent";
            this.columnHeader1.Width = 91;
            // 
            // cmdMainFrm
            // 
            this.cmdMainFrm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmdMainFrm.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdMainFrm.ForeColor = System.Drawing.Color.DarkBlue;
            this.cmdMainFrm.Location = new System.Drawing.Point(2, 109);
            this.cmdMainFrm.Name = "cmdMainFrm";
            this.cmdMainFrm.Size = new System.Drawing.Size(108, 48);
            this.cmdMainFrm.TabIndex = 1;
            this.cmdMainFrm.Text = "main form";
            this.cmdMainFrm.UseVisualStyleBackColor = false;
            this.cmdMainFrm.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdReturCar
            // 
            this.cmdReturCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmdReturCar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdReturCar.ForeColor = System.Drawing.Color.DarkBlue;
            this.cmdReturCar.Location = new System.Drawing.Point(2, 55);
            this.cmdReturCar.Name = "cmdReturCar";
            this.cmdReturCar.Size = new System.Drawing.Size(108, 52);
            this.cmdReturCar.TabIndex = 3;
            this.cmdReturCar.Text = "Return a car";
            this.cmdReturCar.UseVisualStyleBackColor = false;
            this.cmdReturCar.Click += new System.EventHandler(this.ReturnCar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdCancel);
            this.groupBox1.Controls.Add(this.cmdRent);
            this.groupBox1.Controls.Add(this.cmbCar);
            this.groupBox1.Controls.Add(this.cmbCustomer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 312);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Renting a car";
            // 
            // cmdCancel
            // 
            this.cmdCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdCancel.ForeColor = System.Drawing.Color.Navy;
            this.cmdCancel.Location = new System.Drawing.Point(291, 193);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(93, 32);
            this.cmdCancel.TabIndex = 7;
            this.cmdCancel.Text = "cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdRent
            // 
            this.cmdRent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdRent.ForeColor = System.Drawing.Color.Navy;
            this.cmdRent.Location = new System.Drawing.Point(291, 135);
            this.cmdRent.Name = "cmdRent";
            this.cmdRent.Size = new System.Drawing.Size(93, 35);
            this.cmdRent.TabIndex = 6;
            this.cmdRent.Text = "Rent a car";
            this.cmdRent.UseVisualStyleBackColor = true;
            this.cmdRent.Click += new System.EventHandler(this.cmdRent_Click);
            // 
            // cmbCar
            // 
            this.cmbCar.FormattingEnabled = true;
            this.cmbCar.Location = new System.Drawing.Point(353, 77);
            this.cmbCar.Name = "cmbCar";
            this.cmbCar.Size = new System.Drawing.Size(240, 29);
            this.cmbCar.TabIndex = 5;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.AllowDrop = true;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(81, 77);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(233, 29);
            this.cmbCustomer.TabIndex = 4;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(81, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "select the customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(353, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "select the car";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdCanc);
            this.groupBox2.Controls.Add(this.txtCustomerInfo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtPayAmount);
            this.groupBox2.Controls.Add(this.monthCalendar1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbReturnCar);
            this.groupBox2.Controls.Add(this.cmdReturnCar);
            this.groupBox2.Location = new System.Drawing.Point(2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 308);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // cmdCanc
            // 
            this.cmdCanc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdCanc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmdCanc.Location = new System.Drawing.Point(231, 165);
            this.cmdCanc.Name = "cmdCanc";
            this.cmdCanc.Size = new System.Drawing.Size(88, 31);
            this.cmdCanc.TabIndex = 19;
            this.cmdCanc.Text = "cancel";
            this.cmdCanc.UseVisualStyleBackColor = true;
            this.cmdCanc.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCustomerInfo
            // 
            this.txtCustomerInfo.Location = new System.Drawing.Point(30, 77);
            this.txtCustomerInfo.Name = "txtCustomerInfo";
            this.txtCustomerInfo.Size = new System.Drawing.Size(290, 23);
            this.txtCustomerInfo.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(30, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Payment amount";
            // 
            // txtPayAmount
            // 
            this.txtPayAmount.Location = new System.Drawing.Point(30, 154);
            this.txtPayAmount.Name = "txtPayAmount";
            this.txtPayAmount.Size = new System.Drawing.Size(167, 23);
            this.txtPayAmount.TabIndex = 16;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.monthCalendar1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monthCalendar1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.monthCalendar1.Location = new System.Drawing.Point(355, 133);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 15;
            this.monthCalendar1.TrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(352, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "select the date of return";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(42, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Customer info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(355, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Select the car to return.";
            // 
            // cmbReturnCar
            // 
            this.cmbReturnCar.FormattingEnabled = true;
            this.cmbReturnCar.Location = new System.Drawing.Point(352, 77);
            this.cmbReturnCar.Name = "cmbReturnCar";
            this.cmbReturnCar.Size = new System.Drawing.Size(254, 23);
            this.cmbReturnCar.TabIndex = 10;
            this.cmbReturnCar.SelectedIndexChanged += new System.EventHandler(this.cmbReturnCar_SelectedIndexChanged);
            // 
            // cmdReturnCar
            // 
            this.cmdReturnCar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdReturnCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmdReturnCar.Location = new System.Drawing.Point(231, 214);
            this.cmdReturnCar.Name = "cmdReturnCar";
            this.cmdReturnCar.Size = new System.Drawing.Size(89, 33);
            this.cmdReturnCar.TabIndex = 7;
            this.cmdReturnCar.Text = "Return the car";
            this.cmdReturnCar.UseVisualStyleBackColor = true;
            this.cmdReturnCar.Click += new System.EventHandler(this.cmdReturnCar_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 53);
            this.label7.TabIndex = 10;
            this.label7.Text = "RentID";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdRentACar
            // 
            this.cmdRentACar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmdRentACar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdRentACar.ForeColor = System.Drawing.Color.DarkBlue;
            this.cmdRentACar.Location = new System.Drawing.Point(3, 3);
            this.cmdRentACar.Name = "cmdRentACar";
            this.cmdRentACar.Size = new System.Drawing.Size(107, 50);
            this.cmdRentACar.TabIndex = 8;
            this.cmdRentACar.Text = "Rent a car";
            this.cmdRentACar.UseVisualStyleBackColor = false;
            this.cmdRentACar.Click += new System.EventHandler(this.RentACar_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdRentACar);
            this.panel1.Controls.Add(this.cmdMainFrm);
            this.panel1.Controls.Add(this.cmdReturCar);
            this.panel1.Location = new System.Drawing.Point(537, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 210);
            this.panel1.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(86, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 53);
            this.label8.TabIndex = 11;
            this.label8.Text = "Driver License ID";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(184, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 53);
            this.label9.TabIndex = 12;
            this.label9.Text = "Car ID";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Silver;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(255, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 53);
            this.label10.TabIndex = 13;
            this.label10.Text = "Rent date";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Silver;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(351, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 53);
            this.label11.TabIndex = 14;
            this.label11.Text = "Date of return";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Silver;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(446, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 53);
            this.label12.TabIndex = 15;
            this.label12.Text = "Charged rent";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(40)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(651, 515);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button cmdMainFrm;
        private System.Windows.Forms.ColumnHeader RentID;
        private System.Windows.Forms.ColumnHeader DriverLicenseID;
        private System.Windows.Forms.ColumnHeader CarID;
        private System.Windows.Forms.ColumnHeader RentDate;
        private System.Windows.Forms.ColumnHeader DateOfReturn;
        private System.Windows.Forms.Button cmdReturCar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.ComboBox cmbCar;
        private System.Windows.Forms.Button cmdRent;
        private System.Windows.Forms.Button cmdReturnCar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbReturnCar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPayAmount;
        private System.Windows.Forms.TextBox txtCustomerInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button cmdCanc;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdRentACar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}