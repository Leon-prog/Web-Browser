namespace Web_Brauser
{
    partial class SiteMark
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
            this.dataBaseMark = new System.Windows.Forms.DataGridView();
            this.delMark = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseMark)).BeginInit();
            this.SuspendLayout();
            // 
            // dataBaseMark
            // 
            this.dataBaseMark.AllowUserToAddRows = false;
            this.dataBaseMark.AllowUserToDeleteRows = false;
            this.dataBaseMark.AllowUserToResizeColumns = false;
            this.dataBaseMark.AllowUserToResizeRows = false;
            this.dataBaseMark.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataBaseMark.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataBaseMark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBaseMark.Location = new System.Drawing.Point(13, 13);
            this.dataBaseMark.Name = "dataBaseMark";
            this.dataBaseMark.RowHeadersWidth = 59;
            this.dataBaseMark.RowTemplate.Height = 24;
            this.dataBaseMark.Size = new System.Drawing.Size(775, 378);
            this.dataBaseMark.TabIndex = 0;
            // 
            // delMark
            // 
            this.delMark.Font = new System.Drawing.Font("Arial Narrow", 9.841726F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delMark.Location = new System.Drawing.Point(319, 397);
            this.delMark.Name = "delMark";
            this.delMark.Size = new System.Drawing.Size(155, 41);
            this.delMark.TabIndex = 1;
            this.delMark.Text = "Delete mark";
            this.delMark.UseVisualStyleBackColor = true;
            this.delMark.Click += new System.EventHandler(this.delMark_Click);
            // 
            // SiteMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delMark);
            this.Controls.Add(this.dataBaseMark);
            this.Name = "SiteMark";
            this.Text = "SiteMark";
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataBaseMark;
        private System.Windows.Forms.Button delMark;
    }
}