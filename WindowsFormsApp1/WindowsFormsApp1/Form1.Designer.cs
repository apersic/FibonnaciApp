namespace WindowsFormsApp1
{
    partial class FrmFibbonaci
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
            this.lblNbrj = new System.Windows.Forms.Label();
            this.txtbxBrojN = new System.Windows.Forms.TextBox();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.grpbxRezultat = new System.Windows.Forms.GroupBox();
            this.txtbxRezultat = new System.Windows.Forms.TextBox();
            this.grpbxRezultat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNbrj
            // 
            this.lblNbrj.AutoSize = true;
            this.lblNbrj.Location = new System.Drawing.Point(12, 25);
            this.lblNbrj.Name = "lblNbrj";
            this.lblNbrj.Size = new System.Drawing.Size(138, 13);
            this.lblNbrj.TabIndex = 0;
            this.lblNbrj.Text = "Unesite gornju granicu niza:";
            // 
            // txtbxBrojN
            // 
            this.txtbxBrojN.Location = new System.Drawing.Point(156, 22);
            this.txtbxBrojN.Name = "txtbxBrojN";
            this.txtbxBrojN.Size = new System.Drawing.Size(103, 20);
            this.txtbxBrojN.TabIndex = 1;
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.Location = new System.Drawing.Point(184, 60);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(75, 23);
            this.btnIzracunaj.TabIndex = 2;
            this.btnIzracunaj.Text = "Izracunaj";
            this.btnIzracunaj.UseVisualStyleBackColor = true;
            // 
            // grpbxRezultat
            // 
            this.grpbxRezultat.Controls.Add(this.txtbxRezultat);
            this.grpbxRezultat.Location = new System.Drawing.Point(15, 100);
            this.grpbxRezultat.Name = "grpbxRezultat";
            this.grpbxRezultat.Size = new System.Drawing.Size(244, 149);
            this.grpbxRezultat.TabIndex = 3;
            this.grpbxRezultat.TabStop = false;
            this.grpbxRezultat.Text = "Fibonacijev niz:";
            // 
            // txtbxRezultat
            // 
            this.txtbxRezultat.Enabled = false;
            this.txtbxRezultat.Location = new System.Drawing.Point(0, 19);
            this.txtbxRezultat.Name = "txtbxRezultat";
            this.txtbxRezultat.Size = new System.Drawing.Size(244, 20);
            this.txtbxRezultat.TabIndex = 0;
            // 
            // FrmFibbonaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.grpbxRezultat);
            this.Controls.Add(this.btnIzracunaj);
            this.Controls.Add(this.txtbxBrojN);
            this.Controls.Add(this.lblNbrj);
            this.Name = "FrmFibbonaci";
            this.grpbxRezultat.ResumeLayout(false);
            this.grpbxRezultat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNbrj;
        private System.Windows.Forms.TextBox txtbxBrojN;
        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.GroupBox grpbxRezultat;
        private System.Windows.Forms.TextBox txtbxRezultat;
    }
}

