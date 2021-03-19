namespace Web_Brauser
{
    partial class History
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
            this.delHis = new System.Windows.Forms.Button();
            this.dataBaseHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // delHis
            // 
            this.delHis.Font = new System.Drawing.Font("Arial Narrow", 9.841726F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delHis.Location = new System.Drawing.Point(312, 397);
            this.delHis.Name = "delHis";
            this.delHis.Size = new System.Drawing.Size(171, 40);
            this.delHis.TabIndex = 1;
            this.delHis.Text = "Delete history";
            this.delHis.UseVisualStyleBackColor = true;
            this.delHis.Click += new System.EventHandler(this.delHis_Click);
            // 
            // dataBaseHistory
            // 
            this.dataBaseHistory.AllowUserToAddRows = false;
            this.dataBaseHistory.AllowUserToDeleteRows = false;
            this.dataBaseHistory.AllowUserToResizeColumns = false;
            this.dataBaseHistory.AllowUserToResizeRows = false;
            this.dataBaseHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataBaseHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataBaseHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBaseHistory.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataBaseHistory.Location = new System.Drawing.Point(13, 13);
            this.dataBaseHistory.MultiSelect = false;
            this.dataBaseHistory.Name = "dataBaseHistory";
            this.dataBaseHistory.RowHeadersWidth = 59;
            this.dataBaseHistory.RowTemplate.Height = 24;
            this.dataBaseHistory.Size = new System.Drawing.Size(775, 378);
            this.dataBaseHistory.TabIndex = 2;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.dataBaseHistory);
            this.Controls.Add(this.delHis);
            this.Name = "History";
            this.Text = "History";
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button delHis;
        private System.Windows.Forms.DataGridView dataBaseHistory;
    }
}