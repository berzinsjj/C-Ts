
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
            this.Poga = new System.Windows.Forms.Button();
            this.RezultatuRaditajs = new System.Windows.Forms.Label();
            this.TekstuIerakstitajs = new System.Windows.Forms.TextBox();
            this.TekstuIerakstitajs2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Poga
            // 
            this.Poga.Location = new System.Drawing.Point(3, 135);
            this.Poga.Name = "Poga";
            this.Poga.Size = new System.Drawing.Size(130, 93);
            this.Poga.TabIndex = 0;
            this.Poga.Text = "Nospied";
            this.Poga.UseVisualStyleBackColor = true;
            this.Poga.Click += new System.EventHandler(this.Poga_Click);
            // 
            // RezultatuRaditajs
            // 
            this.RezultatuRaditajs.AutoSize = true;
            this.RezultatuRaditajs.Location = new System.Drawing.Point(470, 175);
            this.RezultatuRaditajs.Name = "RezultatuRaditajs";
            this.RezultatuRaditajs.Size = new System.Drawing.Size(55, 13);
            this.RezultatuRaditajs.TabIndex = 1;
            this.RezultatuRaditajs.Text = ".              .";
            // 
            // TekstuIerakstitajs
            // 
            this.TekstuIerakstitajs.Location = new System.Drawing.Point(160, 172);
            this.TekstuIerakstitajs.Name = "TekstuIerakstitajs";
            this.TekstuIerakstitajs.Size = new System.Drawing.Size(100, 20);
            this.TekstuIerakstitajs.TabIndex = 2;
            // 
            // TekstuIerakstitajs2
            // 
            this.TekstuIerakstitajs2.Location = new System.Drawing.Point(302, 172);
            this.TekstuIerakstitajs2.Name = "TekstuIerakstitajs2";
            this.TekstuIerakstitajs2.Size = new System.Drawing.Size(100, 20);
            this.TekstuIerakstitajs2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TekstuIerakstitajs2);
            this.Controls.Add(this.TekstuIerakstitajs);
            this.Controls.Add(this.RezultatuRaditajs);
            this.Controls.Add(this.Poga);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Poga;
        private System.Windows.Forms.Label RezultatuRaditajs;
        private System.Windows.Forms.TextBox TekstuIerakstitajs;
        private System.Windows.Forms.TextBox TekstuIerakstitajs2;
    }
}

