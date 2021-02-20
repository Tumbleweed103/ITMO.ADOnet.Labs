
namespace Lab08_1_2_LINQsql_1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LoadDataButton = new System.Windows.Forms.Button();
            this.ClearListButton = new System.Windows.Forms.Button();
            this.AddObjectButton = new System.Windows.Forms.Button();
            this.DeleteObjectButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LoadAssociatedDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(290, 356);
            this.listBox1.TabIndex = 0;
            // 
            // LoadDataButton
            // 
            this.LoadDataButton.Location = new System.Drawing.Point(13, 376);
            this.LoadDataButton.Name = "LoadDataButton";
            this.LoadDataButton.Size = new System.Drawing.Size(142, 23);
            this.LoadDataButton.TabIndex = 1;
            this.LoadDataButton.Text = "Загрузка данных";
            this.LoadDataButton.UseVisualStyleBackColor = true;
            this.LoadDataButton.Click += new System.EventHandler(this.LoadDataButton_Click);
            // 
            // ClearListButton
            // 
            this.ClearListButton.Location = new System.Drawing.Point(13, 406);
            this.ClearListButton.Name = "ClearListButton";
            this.ClearListButton.Size = new System.Drawing.Size(142, 23);
            this.ClearListButton.TabIndex = 2;
            this.ClearListButton.Text = "Очистить список";
            this.ClearListButton.UseVisualStyleBackColor = true;
            this.ClearListButton.Click += new System.EventHandler(this.ClearListButton_Click);
            // 
            // AddObjectButton
            // 
            this.AddObjectButton.Location = new System.Drawing.Point(162, 376);
            this.AddObjectButton.Name = "AddObjectButton";
            this.AddObjectButton.Size = new System.Drawing.Size(141, 23);
            this.AddObjectButton.TabIndex = 3;
            this.AddObjectButton.Text = "Добавить объект";
            this.AddObjectButton.UseVisualStyleBackColor = true;
            this.AddObjectButton.Click += new System.EventHandler(this.AddObjectButton_Click);
            // 
            // DeleteObjectButton
            // 
            this.DeleteObjectButton.Location = new System.Drawing.Point(162, 406);
            this.DeleteObjectButton.Name = "DeleteObjectButton";
            this.DeleteObjectButton.Size = new System.Drawing.Size(141, 23);
            this.DeleteObjectButton.TabIndex = 4;
            this.DeleteObjectButton.Text = "Удалить объект";
            this.DeleteObjectButton.UseVisualStyleBackColor = true;
            this.DeleteObjectButton.Click += new System.EventHandler(this.DeleteObjectButton_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(310, 13);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(303, 356);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CustomerID";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "City";
            this.columnHeader2.Width = 83;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "OrdersCount";
            this.columnHeader3.Width = 90;
            // 
            // LoadAssociatedDataButton
            // 
            this.LoadAssociatedDataButton.Location = new System.Drawing.Point(385, 375);
            this.LoadAssociatedDataButton.Name = "LoadAssociatedDataButton";
            this.LoadAssociatedDataButton.Size = new System.Drawing.Size(149, 53);
            this.LoadAssociatedDataButton.TabIndex = 6;
            this.LoadAssociatedDataButton.Text = "Загрузка связанных данных";
            this.LoadAssociatedDataButton.UseVisualStyleBackColor = true;
            this.LoadAssociatedDataButton.Click += new System.EventHandler(this.LoadAssociatedDataButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.LoadAssociatedDataButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.DeleteObjectButton);
            this.Controls.Add(this.AddObjectButton);
            this.Controls.Add(this.ClearListButton);
            this.Controls.Add(this.LoadDataButton);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button LoadDataButton;
        private System.Windows.Forms.Button ClearListButton;
        private System.Windows.Forms.Button AddObjectButton;
        private System.Windows.Forms.Button DeleteObjectButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button LoadAssociatedDataButton;
    }
}

