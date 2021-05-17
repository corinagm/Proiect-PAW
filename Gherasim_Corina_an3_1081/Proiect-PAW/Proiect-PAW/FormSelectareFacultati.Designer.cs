namespace Proiect_PAW
{
    partial class FormSelectareFacultati
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
            this.btnFinalizeazaInscrierea = new System.Windows.Forms.Button();
            this.cbOptiune1 = new System.Windows.Forms.ComboBox();
            this.cbOptiune2 = new System.Windows.Forms.ComboBox();
            this.cbOptiune3 = new System.Windows.Forms.ComboBox();
            this.lbOptiune1 = new System.Windows.Forms.Label();
            this.lbOptiune2 = new System.Windows.Forms.Label();
            this.lbOptiune3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFinalizeazaInscrierea
            // 
            this.btnFinalizeazaInscrierea.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnFinalizeazaInscrierea.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizeazaInscrierea.Location = new System.Drawing.Point(319, 198);
            this.btnFinalizeazaInscrierea.Name = "btnFinalizeazaInscrierea";
            this.btnFinalizeazaInscrierea.Size = new System.Drawing.Size(208, 34);
            this.btnFinalizeazaInscrierea.TabIndex = 0;
            this.btnFinalizeazaInscrierea.Text = "Finalizeaza Inscrierea";
            this.btnFinalizeazaInscrierea.UseVisualStyleBackColor = false;
            this.btnFinalizeazaInscrierea.Click += new System.EventHandler(this.btnFinalizeazaInscrierea_Click);
            // 
            // cbOptiune1
            // 
            this.cbOptiune1.FormattingEnabled = true;
            this.cbOptiune1.Items.AddRange(new object[] {
            "CSIE",
            "FABBV",
            "MAN",
            "MKT",
            "REI",
            "ETA",
            "EGM",
            "BT",
            "DREPT",
            "CIG",
            "AAM",
            "AA"});
            this.cbOptiune1.Location = new System.Drawing.Point(406, 36);
            this.cbOptiune1.Name = "cbOptiune1";
            this.cbOptiune1.Size = new System.Drawing.Size(121, 21);
            this.cbOptiune1.TabIndex = 1;
            // 
            // cbOptiune2
            // 
            this.cbOptiune2.FormattingEnabled = true;
            this.cbOptiune2.Items.AddRange(new object[] {
            "CSIE",
            "FABBV",
            "MAN",
            "MKT",
            "REI",
            "ETA",
            "EGM",
            "BT",
            "DREPT",
            "CIG",
            "AAM",
            "AA"});
            this.cbOptiune2.Location = new System.Drawing.Point(406, 86);
            this.cbOptiune2.Name = "cbOptiune2";
            this.cbOptiune2.Size = new System.Drawing.Size(121, 21);
            this.cbOptiune2.TabIndex = 2;
            // 
            // cbOptiune3
            // 
            this.cbOptiune3.FormattingEnabled = true;
            this.cbOptiune3.Items.AddRange(new object[] {
            "CSIE",
            "FABBV",
            "MAN",
            "MKT",
            "REI",
            "ETA",
            "EGM",
            "BT",
            "DREPT",
            "CIG",
            "AAM",
            "AA"});
            this.cbOptiune3.Location = new System.Drawing.Point(406, 135);
            this.cbOptiune3.Name = "cbOptiune3";
            this.cbOptiune3.Size = new System.Drawing.Size(121, 21);
            this.cbOptiune3.TabIndex = 3;
            // 
            // lbOptiune1
            // 
            this.lbOptiune1.AutoSize = true;
            this.lbOptiune1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOptiune1.Location = new System.Drawing.Point(316, 44);
            this.lbOptiune1.Name = "lbOptiune1";
            this.lbOptiune1.Size = new System.Drawing.Size(71, 17);
            this.lbOptiune1.TabIndex = 4;
            this.lbOptiune1.Text = "Optiune I";
            // 
            // lbOptiune2
            // 
            this.lbOptiune2.AutoSize = true;
            this.lbOptiune2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOptiune2.Location = new System.Drawing.Point(316, 94);
            this.lbOptiune2.Name = "lbOptiune2";
            this.lbOptiune2.Size = new System.Drawing.Size(77, 17);
            this.lbOptiune2.TabIndex = 5;
            this.lbOptiune2.Text = "Optiune II";
            // 
            // lbOptiune3
            // 
            this.lbOptiune3.AutoSize = true;
            this.lbOptiune3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOptiune3.Location = new System.Drawing.Point(316, 143);
            this.lbOptiune3.Name = "lbOptiune3";
            this.lbOptiune3.Size = new System.Drawing.Size(83, 17);
            this.lbOptiune3.TabIndex = 6;
            this.lbOptiune3.Text = "Optiune III";
            // 
            // FormSelectareFacultati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbOptiune3);
            this.Controls.Add(this.lbOptiune2);
            this.Controls.Add(this.lbOptiune1);
            this.Controls.Add(this.cbOptiune3);
            this.Controls.Add(this.cbOptiune2);
            this.Controls.Add(this.cbOptiune1);
            this.Controls.Add(this.btnFinalizeazaInscrierea);
            this.Name = "FormSelectareFacultati";
            this.Text = "FormSelectareFacultati";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinalizeazaInscrierea;
        private System.Windows.Forms.ComboBox cbOptiune1;
        private System.Windows.Forms.ComboBox cbOptiune2;
        private System.Windows.Forms.ComboBox cbOptiune3;
        private System.Windows.Forms.Label lbOptiune1;
        private System.Windows.Forms.Label lbOptiune2;
        private System.Windows.Forms.Label lbOptiune3;
    }
}