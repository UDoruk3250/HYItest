namespace SeriPortProgrami
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxSeriPortlar = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.textBoxMessages = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.label7 = new System.Windows.Forms.Label();
            this.GyroZ = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.GyroY = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.GyroX = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.boylam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.enlem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GPSirtifa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.irtifa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.takimID = new System.Windows.Forms.TextBox();
            this.sayac = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSeriPortlar
            // 
            this.comboBoxSeriPortlar.FormattingEnabled = true;
            this.comboBoxSeriPortlar.Location = new System.Drawing.Point(13, 114);
            this.comboBoxSeriPortlar.Name = "comboBoxSeriPortlar";
            this.comboBoxSeriPortlar.Size = new System.Drawing.Size(65, 21);
            this.comboBoxSeriPortlar.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(12, 156);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(65, 48);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Bağlan";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(12, 210);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(65, 48);
            this.buttonDisconnect.TabIndex = 1;
            this.buttonDisconnect.Text = "Bağlantı Kes";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // textBoxMessages
            // 
            this.textBoxMessages.Location = new System.Drawing.Point(451, 38);
            this.textBoxMessages.Multiline = true;
            this.textBoxMessages.Name = "textBoxMessages";
            this.textBoxMessages.Size = new System.Drawing.Size(152, 245);
            this.textBoxMessages.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(135, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "QUICK HAKEM YER İSTASYONU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Port:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(287, 219);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 61;
            this.label13.Text = "CRC:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // crc
            // 
            this.crc.Enabled = false;
            this.crc.Location = new System.Drawing.Point(349, 216);
            this.crc.Name = "crc";
            this.crc.ReadOnly = true;
            this.crc.Size = new System.Drawing.Size(81, 20);
            this.crc.TabIndex = 60;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(287, 193);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 59;
            this.label14.Text = "Durum:";
            // 
            // status
            // 
            this.status.Enabled = false;
            this.status.Location = new System.Drawing.Point(349, 190);
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Size = new System.Drawing.Size(81, 20);
            this.status.TabIndex = 58;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(287, 167);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 57;
            this.label15.Text = "Açı: ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // angle
            // 
            this.angle.Enabled = false;
            this.angle.Location = new System.Drawing.Point(349, 164);
            this.angle.Name = "angle";
            this.angle.ReadOnly = true;
            this.angle.Size = new System.Drawing.Size(81, 20);
            this.angle.TabIndex = 56;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(287, 141);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 55;
            this.label16.Text = "İvme Z:";
            // 
            // accZ
            // 
            this.accZ.Enabled = false;
            this.accZ.Location = new System.Drawing.Point(349, 138);
            this.accZ.Name = "accZ";
            this.accZ.ReadOnly = true;
            this.accZ.Size = new System.Drawing.Size(81, 20);
            this.accZ.TabIndex = 54;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(287, 115);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 53;
            this.label17.Text = "İvme Y: ";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // accY
            // 
            this.accY.Enabled = false;
            this.accY.Location = new System.Drawing.Point(349, 112);
            this.accY.Name = "accY";
            this.accY.ReadOnly = true;
            this.accY.Size = new System.Drawing.Size(81, 20);
            this.accY.TabIndex = 52;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(287, 89);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 13);
            this.label18.TabIndex = 51;
            this.label18.Text = "İvme X:";
            // 
            // accX
            // 
            this.accX.Enabled = false;
            this.accX.Location = new System.Drawing.Point(349, 86);
            this.accX.Name = "accX";
            this.accX.ReadOnly = true;
            this.accX.Size = new System.Drawing.Size(81, 20);
            this.accX.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Jiroskop Z:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GyroZ
            // 
            this.GyroZ.Enabled = false;
            this.GyroZ.Location = new System.Drawing.Point(169, 242);
            this.GyroZ.Name = "GyroZ";
            this.GyroZ.ReadOnly = true;
            this.GyroZ.Size = new System.Drawing.Size(81, 20);
            this.GyroZ.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(107, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Jiroskop Y: ";
            // 
            // GyroY
            // 
            this.GyroY.Enabled = false;
            this.GyroY.Location = new System.Drawing.Point(169, 216);
            this.GyroY.Name = "GyroY";
            this.GyroY.ReadOnly = true;
            this.GyroY.Size = new System.Drawing.Size(81, 20);
            this.GyroY.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(107, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Jiroskop X:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // GyroX
            // 
            this.GyroX.Enabled = false;
            this.GyroX.Location = new System.Drawing.Point(169, 190);
            this.GyroX.Name = "GyroX";
            this.GyroX.ReadOnly = true;
            this.GyroX.Size = new System.Drawing.Size(81, 20);
            this.GyroX.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(107, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Boylam:";
            // 
            // boylam
            // 
            this.boylam.Enabled = false;
            this.boylam.Location = new System.Drawing.Point(169, 164);
            this.boylam.Name = "boylam";
            this.boylam.ReadOnly = true;
            this.boylam.Size = new System.Drawing.Size(81, 20);
            this.boylam.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Enlem: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // enlem
            // 
            this.enlem.Enabled = false;
            this.enlem.Location = new System.Drawing.Point(169, 138);
            this.enlem.Name = "enlem";
            this.enlem.ReadOnly = true;
            this.enlem.Size = new System.Drawing.Size(81, 20);
            this.enlem.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "GPS İrtifa: ";
            // 
            // GPSirtifa
            // 
            this.GPSirtifa.Enabled = false;
            this.GPSirtifa.Location = new System.Drawing.Point(169, 112);
            this.GPSirtifa.Name = "GPSirtifa";
            this.GPSirtifa.ReadOnly = true;
            this.GPSirtifa.Size = new System.Drawing.Size(81, 20);
            this.GPSirtifa.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "İrtifa: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // irtifa
            // 
            this.irtifa.Enabled = false;
            this.irtifa.Location = new System.Drawing.Point(169, 86);
            this.irtifa.Name = "irtifa";
            this.irtifa.ReadOnly = true;
            this.irtifa.Size = new System.Drawing.Size(81, 20);
            this.irtifa.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Takım ID: ";
            // 
            // takimID
            // 
            this.takimID.Enabled = false;
            this.takimID.Location = new System.Drawing.Point(169, 60);
            this.takimID.Name = "takimID";
            this.takimID.ReadOnly = true;
            this.takimID.Size = new System.Drawing.Size(81, 20);
            this.takimID.TabIndex = 34;
            // 
            // sayac
            // 
            this.sayac.Enabled = false;
            this.sayac.Location = new System.Drawing.Point(349, 60);
            this.sayac.Name = "sayac";
            this.sayac.ReadOnly = true;
            this.sayac.Size = new System.Drawing.Size(81, 20);
            this.sayac.TabIndex = 62;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(287, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 63;
            this.label11.Text = "Sayaç: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 323);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sayac);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxMessages);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.comboBoxSeriPortlar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSeriPortlar;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.TextBox textBoxMessages;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox GyroZ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox GyroY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox GyroX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox boylam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox enlem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox GPSirtifa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox irtifa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox takimID;
        private System.Windows.Forms.TextBox sayac;
        private System.Windows.Forms.Label label11;
    }
}

