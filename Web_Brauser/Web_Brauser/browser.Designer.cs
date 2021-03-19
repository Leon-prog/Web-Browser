namespace Web_Brauser
{
    partial class browser
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(browser));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.back = new System.Windows.Forms.ToolStripButton();
            this.forward = new System.Windows.Forms.ToolStripButton();
            this.refresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.research = new System.Windows.Forms.ToolStripTextBox();
            this.Go = new System.Windows.Forms.ToolStripButton();
            this.add_ = new System.Windows.Forms.ToolStripButton();
            this.delete = new System.Windows.Forms.ToolStripButton();
            this.addUrl = new System.Windows.Forms.ToolStripButton();
            this.menu = new System.Windows.Forms.ToolStripDropDownButton();
            this.history = new System.Windows.Forms.ToolStripMenuItem();
            this.siteMark = new System.Windows.Forms.ToolStripMenuItem();
            this.pages = new System.Windows.Forms.TabControl();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(23, 23);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.back,
            this.forward,
            this.refresh,
            this.toolStripButton1,
            this.research,
            this.Go,
            this.add_,
            this.delete,
            this.toolStripSeparator1,
            this.addUrl,
            this.menu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1141, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // back
            // 
            this.back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(33, 27);
            this.back.Text = "toolStripButton1";
            this.back.ToolTipText = "назад";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // forward
            // 
            this.forward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forward.Image = ((System.Drawing.Image)(resources.GetObject("forward.Image")));
            this.forward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(33, 27);
            this.forward.Text = "toolStripButton2";
            this.forward.ToolTipText = "вперёд";
            this.forward.Click += new System.EventHandler(this.forward_Click);
            // 
            // refresh
            // 
            this.refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(33, 27);
            this.refresh.Text = "toolStripButton3";
            this.refresh.ToolTipText = "перезагрузка";
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(33, 27);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // research
            // 
            this.research.Font = new System.Drawing.Font("Segoe UI", 8.805756F);
            this.research.Name = "research";
            this.research.Size = new System.Drawing.Size(600, 31);
            // 
            // Go
            // 
            this.Go.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Go.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Go.Image = ((System.Drawing.Image)(resources.GetObject("Go.Image")));
            this.Go.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(33, 27);
            this.Go.Text = "Go";
            this.Go.ToolTipText = "Go";
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // add_
            // 
            this.add_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.add_.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.add_.Image = ((System.Drawing.Image)(resources.GetObject("add_.Image")));
            this.add_.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.add_.Name = "add_";
            this.add_.Size = new System.Drawing.Size(33, 27);
            this.add_.Text = "+";
            this.add_.ToolTipText = "добавление вкладки";
            this.add_.Click += new System.EventHandler(this.add__Click);
            // 
            // delete
            // 
            this.delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(33, 27);
            this.delete.ToolTipText = "удаление вкладки";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // addUrl
            // 
            this.addUrl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addUrl.Image = ((System.Drawing.Image)(resources.GetObject("addUrl.Image")));
            this.addUrl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addUrl.Name = "addUrl";
            this.addUrl.Size = new System.Drawing.Size(33, 27);
            this.addUrl.Text = "toolStripButton2";
            this.addUrl.ToolTipText = "добавить в закладки";
            this.addUrl.Click += new System.EventHandler(this.addUrl_Click);
            // 
            // menu
            // 
            this.menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.history,
            this.siteMark});
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(40, 27);
            this.menu.Text = "toolStripDropDownButton1";
            this.menu.ToolTipText = "меню";
            // 
            // history
            // 
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(261, 32);
            this.history.Text = "History";
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // siteMark
            // 
            this.siteMark.Name = "siteMark";
            this.siteMark.Size = new System.Drawing.Size(261, 32);
            this.siteMark.Text = "Sitemark";
            this.siteMark.Click += new System.EventHandler(this.siteMark_Click);
            // 
            // pages
            // 
            this.pages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pages.Location = new System.Drawing.Point(0, 31);
            this.pages.Name = "pages";
            this.pages.SelectedIndex = 0;
            this.pages.Size = new System.Drawing.Size(1141, 548);
            this.pages.TabIndex = 2;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(23, 23);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 34);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(234, 30);
            this.saveToolStripMenuItem.Text = "save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 579);
            this.Controls.Add(this.pages);
            this.Controls.Add(this.toolStrip1);
            this.Name = "browser";
            this.Text = "browser";
            this.Load += new System.EventHandler(this.browser_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton back;
        private System.Windows.Forms.ToolStripButton forward;
        private System.Windows.Forms.ToolStripButton refresh;
        private System.Windows.Forms.ToolStripTextBox research;
        private System.Windows.Forms.ToolStripButton add_;
        private System.Windows.Forms.TabControl pages;
        private System.Windows.Forms.ToolStripButton Go;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton delete;
        private System.Windows.Forms.ToolStripButton addUrl;
        private System.Windows.Forms.ToolStripDropDownButton menu;
        private System.Windows.Forms.ToolStripMenuItem history;
        private System.Windows.Forms.ToolStripMenuItem siteMark;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

