﻿namespace GestionEleve.Autre
{
    partial class R3
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.NOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COEFFICIENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.erreur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOM,
            this.COEFFICIENT});
            this.dataGrid.Location = new System.Drawing.Point(26, 26);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(294, 286);
            this.dataGrid.TabIndex = 0;
            // 
            // NOM
            // 
            this.NOM.DataPropertyName = "NOM";
            this.NOM.HeaderText = "NOM";
            this.NOM.Name = "NOM";
            this.NOM.ReadOnly = true;
            // 
            // COEFFICIENT
            // 
            this.COEFFICIENT.DataPropertyName = "COEFFICIENT";
            this.COEFFICIENT.HeaderText = "COEFFICIENT";
            this.COEFFICIENT.Name = "COEFFICIENT";
            this.COEFFICIENT.ReadOnly = true;
            this.COEFFICIENT.Width = 150;
            // 
            // erreur
            // 
            this.erreur.AutoSize = true;
            this.erreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erreur.ForeColor = System.Drawing.Color.Red;
            this.erreur.Location = new System.Drawing.Point(53, 147);
            this.erreur.Name = "erreur";
            this.erreur.Size = new System.Drawing.Size(0, 25);
            this.erreur.TabIndex = 1;
            // 
            // R3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.erreur);
            this.Controls.Add(this.dataGrid);
            this.Name = "R3";
            this.Size = new System.Drawing.Size(351, 340);
            this.Load += new System.EventHandler(this.R3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn COEFFICIENT;
        private System.Windows.Forms.Label erreur;
    }
}
