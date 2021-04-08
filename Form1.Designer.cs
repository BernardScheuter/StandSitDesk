
namespace StandSitDesk
{
    partial class lblForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lblForm1));
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnResetTimer = new System.Windows.Forms.Button();
            this.lblSwitch = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblInterval = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Black;
            this.lblTimer.Location = new System.Drawing.Point(12, 9);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(322, 46);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "Titel van het programma";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnResetTimer
            // 
            this.btnResetTimer.Location = new System.Drawing.Point(39, 58);
            this.btnResetTimer.Name = "btnResetTimer";
            this.btnResetTimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnResetTimer.Size = new System.Drawing.Size(75, 23);
            this.btnResetTimer.TabIndex = 1;
            this.btnResetTimer.Text = "Start/Reset";
            this.btnResetTimer.UseVisualStyleBackColor = true;
            this.btnResetTimer.Click += new System.EventHandler(this.btnResetTimer_Click);
            // 
            // lblSwitch
            // 
            this.lblSwitch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSwitch.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwitch.Location = new System.Drawing.Point(12, 84);
            this.lblSwitch.Name = "lblSwitch";
            this.lblSwitch.Size = new System.Drawing.Size(322, 23);
            this.lblSwitch.TabIndex = 2;
            this.lblSwitch.Text = "resterende tijd voor switch";
            this.lblSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSwitch.Click += new System.EventHandler(this.lblSwitch_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(260, 61);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // lblInterval
            // 
            this.lblInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInterval.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterval.Location = new System.Drawing.Point(12, 119);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(322, 23);
            this.lblInterval.TabIndex = 5;
            this.lblInterval.Text = "label1";
            this.lblInterval.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblInterval.Click += new System.EventHandler(this.lblInterval_Click);
            // 
            // lblForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 154);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblSwitch);
            this.Controls.Add(this.btnResetTimer);
            this.Controls.Add(this.lblTimer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "lblForm1";
            this.Text = "StandSitDesk RC";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnResetTimer;
        private System.Windows.Forms.Label lblSwitch;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblInterval;
    }
}

