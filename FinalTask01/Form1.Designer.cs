
namespace FinalTask01
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
            this.fillListViewButton = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.beginDateTextBox = new System.Windows.Forms.TextBox();
            this.endDateTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fillListViewButton
            // 
            this.fillListViewButton.Location = new System.Drawing.Point(255, 21);
            this.fillListViewButton.Name = "fillListViewButton";
            this.fillListViewButton.Size = new System.Drawing.Size(152, 66);
            this.fillListViewButton.TabIndex = 1;
            this.fillListViewButton.Text = "Загрузить данные";
            this.fillListViewButton.UseVisualStyleBackColor = true;
            this.fillListViewButton.Click += new System.EventHandler(this.fillListViewButton_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 105);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(800, 345);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID заказа";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Дата заказа";
            this.columnHeader2.Width = 167;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Сумма";
            this.columnHeader3.Width = 276;
            // 
            // beginDateTextBox
            // 
            this.beginDateTextBox.Location = new System.Drawing.Point(6, 34);
            this.beginDateTextBox.Name = "beginDateTextBox";
            this.beginDateTextBox.Size = new System.Drawing.Size(100, 22);
            this.beginDateTextBox.TabIndex = 3;
            this.beginDateTextBox.Text = "2011-04-16";
            // 
            // endDateTextBox
            // 
            this.endDateTextBox.Location = new System.Drawing.Point(121, 34);
            this.endDateTextBox.Name = "endDateTextBox";
            this.endDateTextBox.Size = new System.Drawing.Size(100, 22);
            this.endDateTextBox.TabIndex = 4;
            this.endDateTextBox.Text = "2014-06-24";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.endDateTextBox);
            this.groupBox1.Controls.Add(this.beginDateTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 74);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Даты выборки";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.fillListViewButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Final Task 1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button fillListViewButton;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox beginDateTextBox;
        private System.Windows.Forms.TextBox endDateTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

