namespace DZ_Na_TIMER
{
    partial class Form2
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblNewYear = new System.Windows.Forms.Label();
            this.lblCustom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblBirthday.Location = new System.Drawing.Point(36, 9);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(86, 31);
            this.lblBirthday.TabIndex = 0;
            this.lblBirthday.Text = "label1";
            // 
            // lblNewYear
            // 
            this.lblNewYear.AutoSize = true;
            this.lblNewYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblNewYear.Location = new System.Drawing.Point(36, 91);
            this.lblNewYear.Name = "lblNewYear";
            this.lblNewYear.Size = new System.Drawing.Size(86, 31);
            this.lblNewYear.TabIndex = 1;
            this.lblNewYear.Text = "label2";
            // 
            // lblCustom
            // 
            this.lblCustom.AutoSize = true;
            this.lblCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblCustom.Location = new System.Drawing.Point(36, 168);
            this.lblCustom.Name = "lblCustom";
            this.lblCustom.Size = new System.Drawing.Size(86, 31);
            this.lblCustom.TabIndex = 2;
            this.lblCustom.Text = "label3";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCustom);
            this.Controls.Add(this.lblNewYear);
            this.Controls.Add(this.lblBirthday);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblNewYear;
        private System.Windows.Forms.Label lblCustom;
    }
}