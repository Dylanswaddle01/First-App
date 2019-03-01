namespace WindowsFormsApp1
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
            this.btnpressme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnpressme
            // 
            this.btnpressme.BackColor = System.Drawing.Color.Gray;
            this.btnpressme.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpressme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnpressme.Location = new System.Drawing.Point(166, 131);
            this.btnpressme.Name = "btnpressme";
            this.btnpressme.Size = new System.Drawing.Size(397, 215);
            this.btnpressme.TabIndex = 0;
            this.btnpressme.Text = "Press Me!";
            this.btnpressme.UseVisualStyleBackColor = false;
            this.btnpressme.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(753, 554);
            this.Controls.Add(this.btnpressme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnpressme;
    }
}

