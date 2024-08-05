namespace HYItest
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.takimID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.irtifa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.enlem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GPSirtifa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GyroZ = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.GyroY = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.GyroX = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.boylam = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.crc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.angle = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.accZ = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.accY = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.accX = new System.Windows.Forms.TextBox();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HYItest.Properties.Resources._353934322_1413856396059454_2700734664438747177_n;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seri Port Seç:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(11, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "Bağlan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(276, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "YER İSTASYONU";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(11, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 55);
            this.button2.TabIndex = 5;
            this.button2.Text = "Kapat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // takimID
            // 
            this.takimID.Enabled = false;
            this.takimID.Location = new System.Drawing.Point(161, 126);
            this.takimID.Name = "takimID";
            this.takimID.ReadOnly = true;
            this.takimID.Size = new System.Drawing.Size(81, 20);
            this.takimID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Takım ID: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "İrtifa: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // irtifa
            // 
            this.irtifa.Enabled = false;
            this.irtifa.Location = new System.Drawing.Point(161, 152);
            this.irtifa.Name = "irtifa";
            this.irtifa.ReadOnly = true;
            this.irtifa.Size = new System.Drawing.Size(81, 20);
            this.irtifa.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Enlem: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // enlem
            // 
            this.enlem.Enabled = false;
            this.enlem.Location = new System.Drawing.Point(161, 204);
            this.enlem.Name = "enlem";
            this.enlem.ReadOnly = true;
            this.enlem.Size = new System.Drawing.Size(81, 20);
            this.enlem.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "GPS İrtifa: ";
            // 
            // GPSirtifa
            // 
            this.GPSirtifa.Enabled = false;
            this.GPSirtifa.Location = new System.Drawing.Point(161, 178);
            this.GPSirtifa.Name = "GPSirtifa";
            this.GPSirtifa.ReadOnly = true;
            this.GPSirtifa.Size = new System.Drawing.Size(81, 20);
            this.GPSirtifa.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Jiroskop Z:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GyroZ
            // 
            this.GyroZ.Enabled = false;
            this.GyroZ.Location = new System.Drawing.Point(161, 308);
            this.GyroZ.Name = "GyroZ";
            this.GyroZ.ReadOnly = true;
            this.GyroZ.Size = new System.Drawing.Size(81, 20);
            this.GyroZ.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(99, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Jiroskop Y: ";
            // 
            // GyroY
            // 
            this.GyroY.Enabled = false;
            this.GyroY.Location = new System.Drawing.Point(161, 282);
            this.GyroY.Name = "GyroY";
            this.GyroY.ReadOnly = true;
            this.GyroY.Size = new System.Drawing.Size(81, 20);
            this.GyroY.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(99, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Jiroskop X:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // GyroX
            // 
            this.GyroX.Enabled = false;
            this.GyroX.Location = new System.Drawing.Point(161, 256);
            this.GyroX.Name = "GyroX";
            this.GyroX.ReadOnly = true;
            this.GyroX.Size = new System.Drawing.Size(81, 20);
            this.GyroX.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(99, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Boylam:";
            // 
            // boylam
            // 
            this.boylam.Enabled = false;
            this.boylam.Location = new System.Drawing.Point(161, 230);
            this.boylam.Name = "boylam";
            this.boylam.ReadOnly = true;
            this.boylam.Size = new System.Drawing.Size(81, 20);
            this.boylam.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(279, 285);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "CRC:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // crc
            // 
            this.crc.Enabled = false;
            this.crc.Location = new System.Drawing.Point(341, 282);
            this.crc.Name = "crc";
            this.crc.ReadOnly = true;
            this.crc.Size = new System.Drawing.Size(81, 20);
            this.crc.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(279, 259);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Durum:";
            // 
            // status
            // 
            this.status.Enabled = false;
            this.status.Location = new System.Drawing.Point(341, 256);
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Size = new System.Drawing.Size(81, 20);
            this.status.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(279, 233);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Açı: ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // angle
            // 
            this.angle.Enabled = false;
            this.angle.Location = new System.Drawing.Point(341, 230);
            this.angle.Name = "angle";
            this.angle.ReadOnly = true;
            this.angle.Size = new System.Drawing.Size(81, 20);
            this.angle.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(279, 207);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "İvme Z:";
            // 
            // accZ
            // 
            this.accZ.Enabled = false;
            this.accZ.Location = new System.Drawing.Point(341, 204);
            this.accZ.Name = "accZ";
            this.accZ.ReadOnly = true;
            this.accZ.Size = new System.Drawing.Size(81, 20);
            this.accZ.TabIndex = 26;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(279, 181);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "İvme Y: ";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // accY
            // 
            this.accY.Enabled = false;
            this.accY.Location = new System.Drawing.Point(341, 178);
            this.accY.Name = "accY";
            this.accY.ReadOnly = true;
            this.accY.Size = new System.Drawing.Size(81, 20);
            this.accY.TabIndex = 24;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(279, 155);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "İvme X:";
            // 
            // accX
            // 
            this.accX.Enabled = false;
            this.accX.Location = new System.Drawing.Point(341, 152);
            this.accX.Name = "accX";
            this.accX.ReadOnly = true;
            this.accX.Size = new System.Drawing.Size(81, 20);
            this.accX.TabIndex = 22;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "115200"});
            this.comboBox2.Location = new System.Drawing.Point(11, 177);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(76, 21);
            this.comboBox2.TabIndex = 34;
            this.comboBox2.Text = "9600";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(12, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Baud Rate:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.crc);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.angle);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.accZ);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.accY);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.accX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GyroZ);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GyroY);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GyroX);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.boylam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.enlem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GPSirtifa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.irtifa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.takimID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Quick Roket Takımı Yer İstasyonu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox takimID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox irtifa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox enlem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox GPSirtifa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox GyroZ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox GyroY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox GyroX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox boylam;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox crc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox angle;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox accZ;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox accY;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox accX;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label11;
    }
}

