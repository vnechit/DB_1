namespace DB_1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dgClients = new System.Windows.Forms.DataGridView();
            this.dgCases = new System.Windows.Forms.DataGridView();
            this.dgWOCases = new System.Windows.Forms.DataGridView();
            this.dgPunishmentMore5 = new System.Windows.Forms.DataGridView();
            this.dgMoreThen1Case = new System.Windows.Forms.DataGridView();
            this.ClientWithOutCase = new System.Windows.Forms.Button();
            this.PunishmentMoreThen5 = new System.Windows.Forms.Button();
            this.ClientsMoreThen1Case = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnAvg = new System.Windows.Forms.Button();
            this.tbAvg = new System.Windows.Forms.TextBox();
            this.dgSorted = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgWOCases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPunishmentMore5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMoreThen1Case)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSorted)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1577, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.caseToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(68, 29);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // caseToolStripMenuItem
            // 
            this.caseToolStripMenuItem.Name = "caseToolStripMenuItem";
            this.caseToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.caseToolStripMenuItem.Text = "Cases";
            this.caseToolStripMenuItem.Click += new System.EventHandler(this.caseToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dgClients
            // 
            this.dgClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClients.Location = new System.Drawing.Point(23, 51);
            this.dgClients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgClients.Name = "dgClients";
            this.dgClients.Size = new System.Drawing.Size(620, 234);
            this.dgClients.TabIndex = 2;
            // 
            // dgCases
            // 
            this.dgCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCases.Location = new System.Drawing.Point(23, 352);
            this.dgCases.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgCases.Name = "dgCases";
            this.dgCases.Size = new System.Drawing.Size(620, 223);
            this.dgCases.TabIndex = 3;
            // 
            // dgWOCases
            // 
            this.dgWOCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWOCases.Location = new System.Drawing.Point(781, 51);
            this.dgWOCases.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgWOCases.Name = "dgWOCases";
            this.dgWOCases.Size = new System.Drawing.Size(369, 258);
            this.dgWOCases.TabIndex = 5;
            // 
            // dgPunishmentMore5
            // 
            this.dgPunishmentMore5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPunishmentMore5.Location = new System.Drawing.Point(781, 340);
            this.dgPunishmentMore5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgPunishmentMore5.Name = "dgPunishmentMore5";
            this.dgPunishmentMore5.Size = new System.Drawing.Size(369, 258);
            this.dgPunishmentMore5.TabIndex = 6;
            // 
            // dgMoreThen1Case
            // 
            this.dgMoreThen1Case.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMoreThen1Case.Location = new System.Drawing.Point(781, 629);
            this.dgMoreThen1Case.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgMoreThen1Case.Name = "dgMoreThen1Case";
            this.dgMoreThen1Case.Size = new System.Drawing.Size(369, 258);
            this.dgMoreThen1Case.TabIndex = 7;
            // 
            // ClientWithOutCase
            // 
            this.ClientWithOutCase.Location = new System.Drawing.Point(1227, 51);
            this.ClientWithOutCase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClientWithOutCase.Name = "ClientWithOutCase";
            this.ClientWithOutCase.Size = new System.Drawing.Size(160, 72);
            this.ClientWithOutCase.TabIndex = 8;
            this.ClientWithOutCase.Text = "Clients without case";
            this.ClientWithOutCase.UseVisualStyleBackColor = true;
            this.ClientWithOutCase.Click += new System.EventHandler(this.ClientWithOutCase_Click);
            // 
            // PunishmentMoreThen5
            // 
            this.PunishmentMoreThen5.Location = new System.Drawing.Point(1227, 186);
            this.PunishmentMoreThen5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PunishmentMoreThen5.Name = "PunishmentMoreThen5";
            this.PunishmentMoreThen5.Size = new System.Drawing.Size(160, 72);
            this.PunishmentMoreThen5.TabIndex = 9;
            this.PunishmentMoreThen5.Text = "Punishment > 5";
            this.PunishmentMoreThen5.UseVisualStyleBackColor = true;
            this.PunishmentMoreThen5.Click += new System.EventHandler(this.PunishmentMoreThen5_Click);
            // 
            // ClientsMoreThen1Case
            // 
            this.ClientsMoreThen1Case.Location = new System.Drawing.Point(1227, 321);
            this.ClientsMoreThen1Case.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClientsMoreThen1Case.Name = "ClientsMoreThen1Case";
            this.ClientsMoreThen1Case.Size = new System.Drawing.Size(160, 72);
            this.ClientsMoreThen1Case.TabIndex = 10;
            this.ClientsMoreThen1Case.Text = "Count case per client";
            this.ClientsMoreThen1Case.UseVisualStyleBackColor = true;
            this.ClientsMoreThen1Case.Click += new System.EventHandler(this.ClientsMoreThen1Case_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(1226, 436);
            this.btnSort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(161, 72);
            this.btnSort.TabIndex = 11;
            this.btnSort.Text = "Sort by name";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnAvg
            // 
            this.btnAvg.Location = new System.Drawing.Point(1227, 550);
            this.btnAvg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(161, 72);
            this.btnAvg.TabIndex = 13;
            this.btnAvg.Text = "Avg max punishment(w/oo 0 p/m)";
            this.btnAvg.UseVisualStyleBackColor = true;
            this.btnAvg.Click += new System.EventHandler(this.btnAvg_Click);
            // 
            // tbAvg
            // 
            this.tbAvg.Location = new System.Drawing.Point(1237, 660);
            this.tbAvg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAvg.Name = "tbAvg";
            this.tbAvg.Size = new System.Drawing.Size(150, 26);
            this.tbAvg.TabIndex = 15;
            // 
            // dgSorted
            // 
            this.dgSorted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSorted.Location = new System.Drawing.Point(274, 629);
            this.dgSorted.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgSorted.Name = "dgSorted";
            this.dgSorted.RowHeadersWidth = 51;
            this.dgSorted.Size = new System.Drawing.Size(369, 246);
            this.dgSorted.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1577, 901);
            this.Controls.Add(this.dgSorted);
            this.Controls.Add(this.tbAvg);
            this.Controls.Add(this.btnAvg);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.ClientsMoreThen1Case);
            this.Controls.Add(this.PunishmentMoreThen5);
            this.Controls.Add(this.ClientWithOutCase);
            this.Controls.Add(this.dgMoreThen1Case);
            this.Controls.Add(this.dgPunishmentMore5);
            this.Controls.Add(this.dgWOCases);
            this.Controls.Add(this.dgCases);
            this.Controls.Add(this.dgClients);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgWOCases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPunishmentMore5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMoreThen1Case)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSorted)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caseToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dgClients;
        private System.Windows.Forms.DataGridView dgCases;
        private System.Windows.Forms.DataGridView dgWOCases;
        private System.Windows.Forms.DataGridView dgPunishmentMore5;
        private System.Windows.Forms.DataGridView dgMoreThen1Case;
        private System.Windows.Forms.Button ClientWithOutCase;
        private System.Windows.Forms.Button PunishmentMoreThen5;
        private System.Windows.Forms.Button ClientsMoreThen1Case;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnAvg;
        private System.Windows.Forms.TextBox tbAvg;
        private System.Windows.Forms.DataGridView dgSorted;
    }
}

