namespace Proiect_PAW
{
    partial class FormPrezentareFacultati
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
            this.lvListaFacultati = new System.Windows.Forms.ListView();
            this.lbDenumireFac = new System.Windows.Forms.Label();
            this.lbDescriereFac = new System.Windows.Forms.Label();
            this.tbDenumireFac = new System.Windows.Forms.TextBox();
            this.tbDescriereFac = new System.Windows.Forms.TextBox();
            this.btnPrezentareFac = new System.Windows.Forms.Button();
            this.lbListaFacultati = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvListaFacultati
            // 
            this.lvListaFacultati.HideSelection = false;
            this.lvListaFacultati.Location = new System.Drawing.Point(12, 48);
            this.lvListaFacultati.Name = "lvListaFacultati";
            this.lvListaFacultati.Size = new System.Drawing.Size(406, 544);
            this.lvListaFacultati.TabIndex = 0;
            this.lvListaFacultati.UseCompatibleStateImageBehavior = false;
            // 
            // lbDenumireFac
            // 
            this.lbDenumireFac.AutoSize = true;
            this.lbDenumireFac.Location = new System.Drawing.Point(565, 54);
            this.lbDenumireFac.Name = "lbDenumireFac";
            this.lbDenumireFac.Size = new System.Drawing.Size(149, 20);
            this.lbDenumireFac.TabIndex = 1;
            this.lbDenumireFac.Text = "Denumire Facultate";
            // 
            // lbDescriereFac
            // 
            this.lbDescriereFac.AutoSize = true;
            this.lbDescriereFac.Location = new System.Drawing.Point(565, 151);
            this.lbDescriereFac.Name = "lbDescriereFac";
            this.lbDescriereFac.Size = new System.Drawing.Size(77, 20);
            this.lbDescriereFac.TabIndex = 2;
            this.lbDescriereFac.Text = "Descriere";
            // 
            // tbDenumireFac
            // 
            this.tbDenumireFac.Location = new System.Drawing.Point(730, 48);
            this.tbDenumireFac.Name = "tbDenumireFac";
            this.tbDenumireFac.Size = new System.Drawing.Size(386, 26);
            this.tbDenumireFac.TabIndex = 3;
            // 
            // tbDescriereFac
            // 
            this.tbDescriereFac.Location = new System.Drawing.Point(730, 148);
            this.tbDescriereFac.Multiline = true;
            this.tbDescriereFac.Name = "tbDescriereFac";
            this.tbDescriereFac.Size = new System.Drawing.Size(386, 444);
            this.tbDescriereFac.TabIndex = 4;
            // 
            // btnPrezentareFac
            // 
            this.btnPrezentareFac.Location = new System.Drawing.Point(497, 526);
            this.btnPrezentareFac.Name = "btnPrezentareFac";
            this.btnPrezentareFac.Size = new System.Drawing.Size(149, 66);
            this.btnPrezentareFac.TabIndex = 5;
            this.btnPrezentareFac.Text = "Prezentare";
            this.btnPrezentareFac.UseVisualStyleBackColor = true;
            // 
            // lbListaFacultati
            // 
            this.lbListaFacultati.AutoSize = true;
            this.lbListaFacultati.Location = new System.Drawing.Point(164, 25);
            this.lbListaFacultati.Name = "lbListaFacultati";
            this.lbListaFacultati.Size = new System.Drawing.Size(112, 20);
            this.lbListaFacultati.TabIndex = 6;
            this.lbListaFacultati.Text = "Lista Facultati:";
            // 
            // FormPrezentareFacultati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1235, 620);
            this.Controls.Add(this.lbListaFacultati);
            this.Controls.Add(this.btnPrezentareFac);
            this.Controls.Add(this.tbDescriereFac);
            this.Controls.Add(this.tbDenumireFac);
            this.Controls.Add(this.lbDescriereFac);
            this.Controls.Add(this.lbDenumireFac);
            this.Controls.Add(this.lvListaFacultati);
            this.Name = "FormPrezentareFacultati";
            this.Text = "FormPrezentareFacultati";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvListaFacultati;
        private System.Windows.Forms.Label lbDenumireFac;
        private System.Windows.Forms.Label lbDescriereFac;
        private System.Windows.Forms.TextBox tbDenumireFac;
        private System.Windows.Forms.TextBox tbDescriereFac;
        private System.Windows.Forms.Button btnPrezentareFac;
        private System.Windows.Forms.Label lbListaFacultati;
    }
}