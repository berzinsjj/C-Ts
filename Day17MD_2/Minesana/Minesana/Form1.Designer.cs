
namespace Minesana
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
            this.PirmaPoga = new System.Windows.Forms.Button();
            this.OtraPoga = new System.Windows.Forms.Button();
            this.PirmaIevade = new System.Windows.Forms.TextBox();
            this.OtraIevade = new System.Windows.Forms.TextBox();
            this.RezultatuRaditajs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PirmaPoga
            // 
            this.PirmaPoga.Location = new System.Drawing.Point(0, 0);
            this.PirmaPoga.Name = "PirmaPoga";
            this.PirmaPoga.Size = new System.Drawing.Size(173, 66);
            this.PirmaPoga.TabIndex = 0;
            this.PirmaPoga.Text = "PirmaisSpiedines";
            this.PirmaPoga.UseVisualStyleBackColor = true;
            this.PirmaPoga.Click += new System.EventHandler(this.PirmaPoga_Click);
            // 
            // OtraPoga
            // 
            this.OtraPoga.Location = new System.Drawing.Point(0, 167);
            this.OtraPoga.Name = "OtraPoga";
            this.OtraPoga.Size = new System.Drawing.Size(173, 66);
            this.OtraPoga.TabIndex = 1;
            this.OtraPoga.Text = "OtraisSPiediens";
            this.OtraPoga.UseVisualStyleBackColor = true;
            this.OtraPoga.Click += new System.EventHandler(this.OtraPoga_Click);
            // 
            // PirmaIevade
            // 
            this.PirmaIevade.Location = new System.Drawing.Point(215, 24);
            this.PirmaIevade.Name = "PirmaIevade";
            this.PirmaIevade.Size = new System.Drawing.Size(100, 20);
            this.PirmaIevade.TabIndex = 2;
            this.PirmaIevade.Text = "Ievadi Vardu";
            // 
            // OtraIevade
            // 
            this.OtraIevade.Location = new System.Drawing.Point(215, 191);
            this.OtraIevade.Name = "OtraIevade";
            this.OtraIevade.Size = new System.Drawing.Size(100, 20);
            this.OtraIevade.TabIndex = 3;
            this.OtraIevade.Text = "MiniVardu";
            // 
            // RezultatuRaditajs
            // 
            this.RezultatuRaditajs.AutoSize = true;
            this.RezultatuRaditajs.Location = new System.Drawing.Point(516, 131);
            this.RezultatuRaditajs.Name = "RezultatuRaditajs";
            this.RezultatuRaditajs.Size = new System.Drawing.Size(79, 13);
            this.RezultatuRaditajs.TabIndex = 4;
            this.RezultatuRaditajs.Text = "!                      !";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RezultatuRaditajs);
            this.Controls.Add(this.OtraIevade);
            this.Controls.Add(this.PirmaIevade);
            this.Controls.Add(this.OtraPoga);
            this.Controls.Add(this.PirmaPoga);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PirmaPoga;
        private System.Windows.Forms.Button OtraPoga;
        private System.Windows.Forms.TextBox PirmaIevade;
        private System.Windows.Forms.TextBox OtraIevade;
        private System.Windows.Forms.Label RezultatuRaditajs;
    }
}

