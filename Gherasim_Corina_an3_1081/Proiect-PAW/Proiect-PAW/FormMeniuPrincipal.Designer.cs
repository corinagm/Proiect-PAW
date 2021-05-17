namespace Proiect_PAW
{
    partial class FormMeniuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMeniuPrincipal));
            this.btnInscriere = new System.Windows.Forms.Button();
            this.btnCandidatiInscrisi = new System.Windows.Forms.Button();
            this.btnPrezentareFacultati = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInscriere
            // 
            this.btnInscriere.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInscriere.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscriere.Location = new System.Drawing.Point(179, 57);
            this.btnInscriere.Margin = new System.Windows.Forms.Padding(4);
            this.btnInscriere.Name = "btnInscriere";
            this.btnInscriere.Size = new System.Drawing.Size(280, 67);
            this.btnInscriere.TabIndex = 0;
            this.btnInscriere.Text = "Inscriere Facultate";
            this.btnInscriere.UseVisualStyleBackColor = false;
            this.btnInscriere.Click += new System.EventHandler(this.btnInscriere_Click);
            // 
            // btnCandidatiInscrisi
            // 
            this.btnCandidatiInscrisi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCandidatiInscrisi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCandidatiInscrisi.Location = new System.Drawing.Point(179, 170);
            this.btnCandidatiInscrisi.Margin = new System.Windows.Forms.Padding(4);
            this.btnCandidatiInscrisi.Name = "btnCandidatiInscrisi";
            this.btnCandidatiInscrisi.Size = new System.Drawing.Size(280, 68);
            this.btnCandidatiInscrisi.TabIndex = 1;
            this.btnCandidatiInscrisi.Text = "Candidati Inscrisi";
            this.btnCandidatiInscrisi.UseVisualStyleBackColor = false;
            this.btnCandidatiInscrisi.Click += new System.EventHandler(this.btnCandidatiInscrisi_Click);
            // 
            // btnPrezentareFacultati
            // 
            this.btnPrezentareFacultati.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrezentareFacultati.Location = new System.Drawing.Point(189, 303);
            this.btnPrezentareFacultati.Name = "btnPrezentareFacultati";
            this.btnPrezentareFacultati.Size = new System.Drawing.Size(270, 58);
            this.btnPrezentareFacultati.TabIndex = 2;
            this.btnPrezentareFacultati.Text = "Prezentare Facultati";
            this.btnPrezentareFacultati.UseVisualStyleBackColor = false;
            this.btnPrezentareFacultati.Click += new System.EventHandler(this.btnPrezentareFacultati_Click);
            // 
            // FormMeniuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(683, 547);
            this.Controls.Add(this.btnPrezentareFacultati);
            this.Controls.Add(this.btnCandidatiInscrisi);
            this.Controls.Add(this.btnInscriere);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMeniuPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInscriere;
        private System.Windows.Forms.Button btnCandidatiInscrisi;
        private System.Windows.Forms.Button btnPrezentareFacultati;
    }
}

