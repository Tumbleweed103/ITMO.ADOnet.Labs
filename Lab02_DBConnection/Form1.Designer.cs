
namespace DBConnection
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.actionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asyncConnectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scalarButton = new System.Windows.Forms.Button();
            this.scalarLabel = new System.Windows.Forms.Label();
            this.scalarMethodLabel = new System.Windows.Forms.Label();
            this.scalarMethodButton = new System.Windows.Forms.Button();
            this.listViewButton = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.transactionButton = new System.Windows.Forms.Button();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(549, 28);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "Работа с базой данных";
            // 
            // actionsMenuItem
            // 
            this.actionsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectMenuItem,
            this.disconnectMenuItem,
            this.asyncConnectMenuItem,
            this.connectionListMenuItem});
            this.actionsMenuItem.Name = "actionsMenuItem";
            this.actionsMenuItem.Size = new System.Drawing.Size(105, 24);
            this.actionsMenuItem.Text = "Работа с БД";
            // 
            // connectMenuItem
            // 
            this.connectMenuItem.Name = "connectMenuItem";
            this.connectMenuItem.Size = new System.Drawing.Size(320, 26);
            this.connectMenuItem.Text = "Подключиться к БД";
            this.connectMenuItem.Click += new System.EventHandler(this.connectMenuItem_Click);
            // 
            // disconnectMenuItem
            // 
            this.disconnectMenuItem.Name = "disconnectMenuItem";
            this.disconnectMenuItem.Size = new System.Drawing.Size(320, 26);
            this.disconnectMenuItem.Text = "Отключиться от БД";
            this.disconnectMenuItem.Click += new System.EventHandler(this.disconnectMenuItem_Click);
            // 
            // asyncConnectMenuItem
            // 
            this.asyncConnectMenuItem.Name = "asyncConnectMenuItem";
            this.asyncConnectMenuItem.Size = new System.Drawing.Size(320, 26);
            this.asyncConnectMenuItem.Text = "Асинхронное подключение к БД";
            this.asyncConnectMenuItem.Click += new System.EventHandler(this.asyncConnectMenuItem_Click);
            // 
            // connectionListMenuItem
            // 
            this.connectionListMenuItem.Name = "connectionListMenuItem";
            this.connectionListMenuItem.Size = new System.Drawing.Size(320, 26);
            this.connectionListMenuItem.Text = "Список подключений";
            this.connectionListMenuItem.Click += new System.EventHandler(this.connectionListMenuItem_Click);
            // 
            // scalarButton
            // 
            this.scalarButton.Location = new System.Drawing.Point(15, 68);
            this.scalarButton.Name = "scalarButton";
            this.scalarButton.Size = new System.Drawing.Size(162, 23);
            this.scalarButton.TabIndex = 1;
            this.scalarButton.Text = "Сколько продуктов";
            this.scalarButton.UseVisualStyleBackColor = true;
            this.scalarButton.Click += new System.EventHandler(this.scalarButton_Click);
            // 
            // scalarLabel
            // 
            this.scalarLabel.AutoSize = true;
            this.scalarLabel.Location = new System.Drawing.Point(15, 38);
            this.scalarLabel.Name = "scalarLabel";
            this.scalarLabel.Size = new System.Drawing.Size(20, 17);
            this.scalarLabel.TabIndex = 2;
            this.scalarLabel.Text = "...";
            // 
            // scalarMethodLabel
            // 
            this.scalarMethodLabel.AutoSize = true;
            this.scalarMethodLabel.Location = new System.Drawing.Point(15, 107);
            this.scalarMethodLabel.Name = "scalarMethodLabel";
            this.scalarMethodLabel.Size = new System.Drawing.Size(20, 17);
            this.scalarMethodLabel.TabIndex = 3;
            this.scalarMethodLabel.Text = "...";
            // 
            // scalarMethodButton
            // 
            this.scalarMethodButton.Location = new System.Drawing.Point(15, 136);
            this.scalarMethodButton.Name = "scalarMethodButton";
            this.scalarMethodButton.Size = new System.Drawing.Size(162, 23);
            this.scalarMethodButton.TabIndex = 4;
            this.scalarMethodButton.Text = "Сколько продуктов";
            this.scalarMethodButton.UseVisualStyleBackColor = true;
            this.scalarMethodButton.Click += new System.EventHandler(this.scalarMethodButton_Click);
            // 
            // listViewButton
            // 
            this.listViewButton.Location = new System.Drawing.Point(255, 281);
            this.listViewButton.Name = "listViewButton";
            this.listViewButton.Size = new System.Drawing.Size(227, 23);
            this.listViewButton.TabIndex = 5;
            this.listViewButton.Text = "Список продуктов";
            this.listViewButton.UseVisualStyleBackColor = true;
            this.listViewButton.Click += new System.EventHandler(this.listViewButton_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(214, 38);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(309, 213);
            this.listView.TabIndex = 6;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название продукта";
            this.columnHeader1.Width = 168;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Цена";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Фасовка";
            // 
            // transactionButton
            // 
            this.transactionButton.Location = new System.Drawing.Point(15, 195);
            this.transactionButton.Name = "transactionButton";
            this.transactionButton.Size = new System.Drawing.Size(162, 23);
            this.transactionButton.TabIndex = 7;
            this.transactionButton.Text = "Транзакция";
            this.transactionButton.UseVisualStyleBackColor = true;
            this.transactionButton.Click += new System.EventHandler(this.transactionButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 323);
            this.Controls.Add(this.transactionButton);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.listViewButton);
            this.Controls.Add(this.scalarMethodButton);
            this.Controls.Add(this.scalarMethodLabel);
            this.Controls.Add(this.scalarLabel);
            this.Controls.Add(this.scalarButton);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Form1";
            this.Text = "Northwind DB";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem actionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asyncConnectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionListMenuItem;
        private System.Windows.Forms.Button scalarButton;
        private System.Windows.Forms.Label scalarLabel;
        private System.Windows.Forms.Label scalarMethodLabel;
        private System.Windows.Forms.Button scalarMethodButton;
        private System.Windows.Forms.Button listViewButton;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button transactionButton;
    }
}

