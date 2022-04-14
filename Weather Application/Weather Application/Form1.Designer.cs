namespace Weather_Application
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.TBCity = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LabCondition = new System.Windows.Forms.Label();
            this.labDetails = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labSunrise = new System.Windows.Forms.Label();
            this.labSunset = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labPressure = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labWindSpeed = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(203, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "City : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBCity
            // 
            this.TBCity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCity.Location = new System.Drawing.Point(274, 116);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(180, 32);
            this.TBCity.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(476, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabCondition
            // 
            this.LabCondition.AutoSize = true;
            this.LabCondition.BackColor = System.Drawing.Color.Transparent;
            this.LabCondition.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCondition.ForeColor = System.Drawing.SystemColors.Control;
            this.LabCondition.Location = new System.Drawing.Point(215, 233);
            this.LabCondition.Name = "LabCondition";
            this.LabCondition.Size = new System.Drawing.Size(119, 28);
            this.LabCondition.TabIndex = 3;
            this.LabCondition.Text = "Condition : ";
            // 
            // labDetails
            // 
            this.labDetails.AutoSize = true;
            this.labDetails.BackColor = System.Drawing.Color.Transparent;
            this.labDetails.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetails.ForeColor = System.Drawing.SystemColors.Control;
            this.labDetails.Location = new System.Drawing.Point(216, 277);
            this.labDetails.Name = "labDetails";
            this.labDetails.Size = new System.Drawing.Size(95, 28);
            this.labDetails.TabIndex = 4;
            this.labDetails.Text = "Details : ";
            this.labDetails.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(216, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sunrine : ";
            // 
            // labSunrise
            // 
            this.labSunrise.AutoSize = true;
            this.labSunrise.BackColor = System.Drawing.Color.Transparent;
            this.labSunrise.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunrise.ForeColor = System.Drawing.SystemColors.Control;
            this.labSunrise.Location = new System.Drawing.Point(323, 315);
            this.labSunrise.Name = "labSunrise";
            this.labSunrise.Size = new System.Drawing.Size(61, 28);
            this.labSunrise.TabIndex = 6;
            this.labSunrise.Text = "N / A";
            // 
            // labSunset
            // 
            this.labSunset.AutoSize = true;
            this.labSunset.BackColor = System.Drawing.Color.Transparent;
            this.labSunset.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunset.ForeColor = System.Drawing.SystemColors.Control;
            this.labSunset.Location = new System.Drawing.Point(309, 357);
            this.labSunset.Name = "labSunset";
            this.labSunset.Size = new System.Drawing.Size(61, 28);
            this.labSunset.TabIndex = 8;
            this.labSunset.Text = "N / A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(216, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sunset :";
            // 
            // labPressure
            // 
            this.labPressure.AutoSize = true;
            this.labPressure.BackColor = System.Drawing.Color.Transparent;
            this.labPressure.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPressure.ForeColor = System.Drawing.SystemColors.Control;
            this.labPressure.Location = new System.Drawing.Point(625, 278);
            this.labPressure.Name = "labPressure";
            this.labPressure.Size = new System.Drawing.Size(61, 28);
            this.labPressure.TabIndex = 10;
            this.labPressure.Text = "N / A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(509, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pressure : ";
            // 
            // labWindSpeed
            // 
            this.labWindSpeed.AutoSize = true;
            this.labWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labWindSpeed.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWindSpeed.ForeColor = System.Drawing.SystemColors.Control;
            this.labWindSpeed.Location = new System.Drawing.Point(649, 234);
            this.labWindSpeed.Name = "labWindSpeed";
            this.labWindSpeed.Size = new System.Drawing.Size(61, 28);
            this.labWindSpeed.TabIndex = 12;
            this.labWindSpeed.Text = "N / A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(500, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 28);
            this.label7.TabIndex = 11;
            this.label7.Text = "Wind Speed : ";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(82, 234);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(91, 46);
            this.picIcon.TabIndex = 13;
            this.picIcon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(823, 538);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.labWindSpeed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labPressure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labSunset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labSunrise);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labDetails);
            this.Controls.Add(this.LabCondition);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TBCity);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBCity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LabCondition;
        private System.Windows.Forms.Label labDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labSunrise;
        private System.Windows.Forms.Label labSunset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labPressure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labWindSpeed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picIcon;
    }
}

