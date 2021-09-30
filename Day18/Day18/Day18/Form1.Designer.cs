
namespace Day18
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
            this.RezultataRaditajs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Poga
            // 
            this.Poga.Location = new System.Drawing.Point(31, 81);
            this.Poga.Name = "Poga";
            this.Poga.Size = new System.Drawing.Size(139, 60);
            this.Poga.TabIndex = 0;
            this.Poga.Text = "Spied +1";
            this.Poga.UseVisualStyleBackColor = true;
            this.Poga.Click += new System.EventHandler(this.Poga_Click);
            // 
            // RezultataRaditajs
            // 
            this.RezultataRaditajs.AutoSize = true;
            this.RezultataRaditajs.Location = new System.Drawing.Point(362, 105);
            this.RezultataRaditajs.Name = "RezultataRaditajs";
            this.RezultataRaditajs.Size = new System.Drawing.Size(13, 13);
            this.RezultataRaditajs.TabIndex = 1;
            this.RezultataRaditajs.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RezultataRaditajs);
            this.Controls.Add(this.Poga);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Poga;
        private System.Windows.Forms.Label RezultataRaditajs;
    }
}

