namespace WindowsFormsApp7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.تحاليل = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ستفسارات = new System.Windows.Forms.Button();
            this.اغلاق = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.from1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // تحاليل
            // 
            this.تحاليل.BackColor = System.Drawing.SystemColors.Window;
            this.تحاليل.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.تحاليل.Location = new System.Drawing.Point(827, 261);
            this.تحاليل.Margin = new System.Windows.Forms.Padding(4);
            this.تحاليل.Name = "تحاليل";
            this.تحاليل.Size = new System.Drawing.Size(235, 80);
            this.تحاليل.TabIndex = 0;
            this.تحاليل.Text = "تحاليل";
            this.تحاليل.UseVisualStyleBackColor = false;
            this.تحاليل.Click += new System.EventHandler(this.تحاليل_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(827, 135);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 84);
            this.button2.TabIndex = 1;
            this.button2.Text = "عيادات خارجية";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ستفسارات
            // 
            this.ستفسارات.BackColor = System.Drawing.SystemColors.Window;
            this.ستفسارات.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ستفسارات.Location = new System.Drawing.Point(827, 373);
            this.ستفسارات.Margin = new System.Windows.Forms.Padding(4);
            this.ستفسارات.Name = "ستفسارات";
            this.ستفسارات.Size = new System.Drawing.Size(235, 86);
            this.ستفسارات.TabIndex = 2;
            this.ستفسارات.Text = "استفسارات";
            this.ستفسارات.UseVisualStyleBackColor = false;
            this.ستفسارات.Click += new System.EventHandler(this.ستفسارات_Click);
            // 
            // اغلاق
            // 
            this.اغلاق.BackColor = System.Drawing.SystemColors.Window;
            this.اغلاق.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.اغلاق.Location = new System.Drawing.Point(16, 412);
            this.اغلاق.Margin = new System.Windows.Forms.Padding(4);
            this.اغلاق.Name = "اغلاق";
            this.اغلاق.Size = new System.Drawing.Size(227, 79);
            this.اغلاق.TabIndex = 4;
            this.اغلاق.Text = "اغلاق البرنامج";
            this.اغلاق.UseVisualStyleBackColor = false;
            this.اغلاق.Click += new System.EventHandler(this.اغلاق_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 65);
            this.label1.TabIndex = 5;
            this.label1.Text = "مستشفى الحياة\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // from1
            // 
            this.from1.AutoEllipsis = true;
            this.from1.AutoSize = true;
            this.from1.Location = new System.Drawing.Point(147, 495);
            this.from1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.from1.Name = "from1";
            this.from1.Size = new System.Drawing.Size(40, 16);
            this.from1.TabIndex = 6;
            this.from1.Text = "form1";
            this.from1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.from1.Visible = false;
            this.from1.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 42);
            this.label2.TabIndex = 7;
            this.label2.Text = "حياتك ..... تهمنا";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1096, 502);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.from1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.اغلاق);
            this.Controls.Add(this.ستفسارات);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.تحاليل);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مستشفى الحياة";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button تحاليل;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ستفسارات;
        private System.Windows.Forms.Button اغلاق;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label from1;
        private System.Windows.Forms.Label label2;
    }
}

