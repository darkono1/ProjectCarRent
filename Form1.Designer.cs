
namespace ProjectCarRent
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmdShowCar = new System.Windows.Forms.Button();
            this.cmdShowCustomers = new System.Windows.Forms.Button();
            this.cmdRentCar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdExit = new System.Windows.Forms.Button();
            this.pnlCars = new System.Windows.Forms.Panel();
            this.pnlCustomers = new System.Windows.Forms.Panel();
            this.pnlRent = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdShowCar
            // 
            this.cmdShowCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(33)))), ((int)(((byte)(47)))));
            this.cmdShowCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdShowCar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdShowCar.ForeColor = System.Drawing.Color.AliceBlue;
            this.cmdShowCar.Location = new System.Drawing.Point(0, 60);
            this.cmdShowCar.Name = "cmdShowCar";
            this.cmdShowCar.Size = new System.Drawing.Size(137, 61);
            this.cmdShowCar.TabIndex = 2;
            this.cmdShowCar.Text = "Cars";
            this.cmdShowCar.UseVisualStyleBackColor = false;
            this.cmdShowCar.Click += new System.EventHandler(this.cmdShowCars_click);
            // 
            // cmdShowCustomers
            // 
            this.cmdShowCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(33)))), ((int)(((byte)(47)))));
            this.cmdShowCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdShowCustomers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdShowCustomers.ForeColor = System.Drawing.Color.AliceBlue;
            this.cmdShowCustomers.Location = new System.Drawing.Point(0, 0);
            this.cmdShowCustomers.Name = "cmdShowCustomers";
            this.cmdShowCustomers.Size = new System.Drawing.Size(137, 60);
            this.cmdShowCustomers.TabIndex = 3;
            this.cmdShowCustomers.Text = "Customers";
            this.cmdShowCustomers.UseVisualStyleBackColor = false;
            this.cmdShowCustomers.Click += new System.EventHandler(this.cmdShowCustomers_click);
            // 
            // cmdRentCar
            // 
            this.cmdRentCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(33)))), ((int)(((byte)(47)))));
            this.cmdRentCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdRentCar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdRentCar.ForeColor = System.Drawing.Color.AliceBlue;
            this.cmdRentCar.Location = new System.Drawing.Point(0, 121);
            this.cmdRentCar.Name = "cmdRentCar";
            this.cmdRentCar.Size = new System.Drawing.Size(137, 61);
            this.cmdRentCar.TabIndex = 5;
            this.cmdRentCar.Text = "Rent a car";
            this.cmdRentCar.UseVisualStyleBackColor = false;
            this.cmdRentCar.Click += new System.EventHandler(this.cmdShowRent_click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(35)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.cmdExit);
            this.panel1.Controls.Add(this.cmdRentCar);
            this.panel1.Controls.Add(this.cmdShowCar);
            this.panel1.Controls.Add(this.cmdShowCustomers);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 311);
            this.panel1.TabIndex = 6;
            // 
            // cmdExit
            // 
            this.cmdExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(33)))), ((int)(((byte)(47)))));
            this.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.cmdExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdExit.ForeColor = System.Drawing.Color.AliceBlue;
            this.cmdExit.Location = new System.Drawing.Point(0, 182);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(137, 62);
            this.cmdExit.TabIndex = 6;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Click += new System.EventHandler(this.ExitApp);
            // 
            // pnlCars
            // 
            this.pnlCars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(45)))), ((int)(((byte)(75)))));
            this.pnlCars.Location = new System.Drawing.Point(136, 0);
            this.pnlCars.Name = "pnlCars";
            this.pnlCars.Size = new System.Drawing.Size(654, 314);
            this.pnlCars.TabIndex = 0;
            // 
            // pnlCustomers
            // 
            this.pnlCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(45)))), ((int)(((byte)(75)))));
            this.pnlCustomers.Location = new System.Drawing.Point(136, 0);
            this.pnlCustomers.Name = "pnlCustomers";
            this.pnlCustomers.Size = new System.Drawing.Size(654, 314);
            this.pnlCustomers.TabIndex = 7;
            // 
            // pnlRent
            // 
            this.pnlRent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(45)))), ((int)(((byte)(75)))));
            this.pnlRent.Location = new System.Drawing.Point(136, 0);
            this.pnlRent.Name = "pnlRent";
            this.pnlRent.Size = new System.Drawing.Size(651, 311);
            this.pnlRent.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(151, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(619, 293);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(780, 307);
            this.Controls.Add(this.pnlCars);
            this.Controls.Add(this.pnlRent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCustomers);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car rent";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdShowCar;
        private System.Windows.Forms.Button cmdShowCustomers;
        private System.Windows.Forms.Button cmdRentCar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlCustomers;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Panel pnlCars;
        private System.Windows.Forms.Panel pnlRent;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

