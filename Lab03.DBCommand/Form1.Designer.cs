
namespace DBCommand
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
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.selectSqlCommand = new System.Data.SqlClient.SqlCommand();
            this.simpleQueryButton = new System.Windows.Forms.Button();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.multiQueryButton = new System.Windows.Forms.Button();
            this.procedureButton = new System.Windows.Forms.Button();
            this.procedureSqlCommand = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // sqlConnection
            // 
            this.sqlConnection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=" +
    "True";
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // selectSqlCommand
            // 
            this.selectSqlCommand.CommandText = "SELECT CustomerID, CompanyName\r\nFROM     Customers";
            this.selectSqlCommand.Connection = this.sqlConnection;
            // 
            // simpleQueryButton
            // 
            this.simpleQueryButton.Location = new System.Drawing.Point(12, 278);
            this.simpleQueryButton.Name = "simpleQueryButton";
            this.simpleQueryButton.Size = new System.Drawing.Size(124, 23);
            this.simpleQueryButton.TabIndex = 0;
            this.simpleQueryButton.Text = "Запрос данных";
            this.simpleQueryButton.UseVisualStyleBackColor = true;
            this.simpleQueryButton.Click += new System.EventHandler(this.simpleQueryButton_Click);
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Location = new System.Drawing.Point(12, 12);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultsTextBox.Size = new System.Drawing.Size(419, 251);
            this.ResultsTextBox.TabIndex = 1;
            // 
            // multiQueryButton
            // 
            this.multiQueryButton.Location = new System.Drawing.Point(142, 278);
            this.multiQueryButton.Name = "multiQueryButton";
            this.multiQueryButton.Size = new System.Drawing.Size(142, 23);
            this.multiQueryButton.TabIndex = 2;
            this.multiQueryButton.Text = "Пакетный запрос";
            this.multiQueryButton.UseVisualStyleBackColor = true;
            this.multiQueryButton.Click += new System.EventHandler(this.multiQueryButton_Click);
            // 
            // procedureButton
            // 
            this.procedureButton.Location = new System.Drawing.Point(290, 278);
            this.procedureButton.Name = "procedureButton";
            this.procedureButton.Size = new System.Drawing.Size(141, 23);
            this.procedureButton.TabIndex = 3;
            this.procedureButton.Text = "Вызов процедуры";
            this.procedureButton.UseVisualStyleBackColor = true;
            this.procedureButton.Click += new System.EventHandler(this.procedureQueryButton_Click);
            // 
            // procedureSqlCommand
            // 
            this.procedureSqlCommand.CommandText = "Ten Most Expensive Products";
            this.procedureSqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.procedureSqlCommand.Connection = this.sqlConnection;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 322);
            this.Controls.Add(this.procedureButton);
            this.Controls.Add(this.multiQueryButton);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.simpleQueryButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "DBCommand";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Data.SqlClient.SqlCommand selectSqlCommand;
        private System.Windows.Forms.Button simpleQueryButton;
        private System.Windows.Forms.TextBox ResultsTextBox;
        private System.Windows.Forms.Button multiQueryButton;
        private System.Windows.Forms.Button procedureButton;
        private System.Data.SqlClient.SqlCommand procedureSqlCommand;
    }
}

