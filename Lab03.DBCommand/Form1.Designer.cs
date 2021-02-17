
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
            this.SimpleQueryButton = new System.Windows.Forms.Button();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.MultiQueryButton = new System.Windows.Forms.Button();
            this.ProcedureButton = new System.Windows.Forms.Button();
            this.procedureSqlCommand = new System.Data.SqlClient.SqlCommand();
            this.CreateTableButton = new System.Windows.Forms.Button();
            this.createSqlCommand = new System.Data.SqlClient.SqlCommand();
            this.ParameterQueryButton = new System.Windows.Forms.Button();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.parameterSqlCommand = new System.Data.SqlClient.SqlCommand();
            this.ParameterProcedureButton = new System.Windows.Forms.Button();
            this.CategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.OrdYearTextBox = new System.Windows.Forms.TextBox();
            this.parameterProcedureSqlCommand = new System.Data.SqlClient.SqlCommand();
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
            // SimpleQueryButton
            // 
            this.SimpleQueryButton.Location = new System.Drawing.Point(527, 12);
            this.SimpleQueryButton.Name = "SimpleQueryButton";
            this.SimpleQueryButton.Size = new System.Drawing.Size(188, 23);
            this.SimpleQueryButton.TabIndex = 0;
            this.SimpleQueryButton.Text = "Запрос данных";
            this.SimpleQueryButton.UseVisualStyleBackColor = true;
            this.SimpleQueryButton.Click += new System.EventHandler(this.SimpleQueryButton_Click);
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Location = new System.Drawing.Point(12, 12);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultsTextBox.Size = new System.Drawing.Size(509, 257);
            this.ResultsTextBox.TabIndex = 1;
            // 
            // MultiQueryButton
            // 
            this.MultiQueryButton.Location = new System.Drawing.Point(527, 41);
            this.MultiQueryButton.Name = "MultiQueryButton";
            this.MultiQueryButton.Size = new System.Drawing.Size(188, 23);
            this.MultiQueryButton.TabIndex = 2;
            this.MultiQueryButton.Text = "Пакетный запрос";
            this.MultiQueryButton.UseVisualStyleBackColor = true;
            this.MultiQueryButton.Click += new System.EventHandler(this.MultiQueryButton_Click);
            // 
            // ProcedureButton
            // 
            this.ProcedureButton.Location = new System.Drawing.Point(527, 70);
            this.ProcedureButton.Name = "ProcedureButton";
            this.ProcedureButton.Size = new System.Drawing.Size(188, 23);
            this.ProcedureButton.TabIndex = 3;
            this.ProcedureButton.Text = "Вызов процедуры";
            this.ProcedureButton.UseVisualStyleBackColor = true;
            this.ProcedureButton.Click += new System.EventHandler(this.ProcedureQueryButton_Click);
            // 
            // procedureSqlCommand
            // 
            this.procedureSqlCommand.CommandText = "Ten Most Expensive Products";
            this.procedureSqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.procedureSqlCommand.Connection = this.sqlConnection;
            // 
            // CreateTableButton
            // 
            this.CreateTableButton.Location = new System.Drawing.Point(527, 99);
            this.CreateTableButton.Name = "CreateTableButton";
            this.CreateTableButton.Size = new System.Drawing.Size(188, 23);
            this.CreateTableButton.TabIndex = 4;
            this.CreateTableButton.Text = "Создание таблицы";
            this.CreateTableButton.UseVisualStyleBackColor = true;
            this.CreateTableButton.Click += new System.EventHandler(this.CreateTableButton_Click);
            // 
            // createSqlCommand
            // 
            this.createSqlCommand.Connection = this.sqlConnection;
            // 
            // ParameterQueryButton
            // 
            this.ParameterQueryButton.Location = new System.Drawing.Point(527, 128);
            this.ParameterQueryButton.Name = "ParameterQueryButton";
            this.ParameterQueryButton.Size = new System.Drawing.Size(188, 23);
            this.ParameterQueryButton.TabIndex = 5;
            this.ParameterQueryButton.Text = "Запрос с параметром";
            this.ParameterQueryButton.UseVisualStyleBackColor = true;
            this.ParameterQueryButton.Click += new System.EventHandler(this.ParameterQueryButton_Click);
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(527, 158);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(188, 22);
            this.CityTextBox.TabIndex = 6;
            this.CityTextBox.Text = "London";
            // 
            // parameterSqlCommand
            // 
            this.parameterSqlCommand.CommandText = "SELECT CustomerID, CompanyName, City FROM Customers WHERE City = @City";
            this.parameterSqlCommand.Connection = this.sqlConnection;
            this.parameterSqlCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City")});
            // 
            // ParameterProcedureButton
            // 
            this.ParameterProcedureButton.Location = new System.Drawing.Point(527, 187);
            this.ParameterProcedureButton.Name = "ParameterProcedureButton";
            this.ParameterProcedureButton.Size = new System.Drawing.Size(188, 23);
            this.ParameterProcedureButton.TabIndex = 7;
            this.ParameterProcedureButton.Text = "Процедура с параметром";
            this.ParameterProcedureButton.UseVisualStyleBackColor = true;
            this.ParameterProcedureButton.Click += new System.EventHandler(this.ParameterProcedureButton_Click);
            // 
            // CategoryNameTextBox
            // 
            this.CategoryNameTextBox.Location = new System.Drawing.Point(528, 217);
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            this.CategoryNameTextBox.Size = new System.Drawing.Size(187, 22);
            this.CategoryNameTextBox.TabIndex = 8;
            this.CategoryNameTextBox.Text = "Beverages";
            // 
            // OrdYearTextBox
            // 
            this.OrdYearTextBox.Location = new System.Drawing.Point(528, 246);
            this.OrdYearTextBox.Name = "OrdYearTextBox";
            this.OrdYearTextBox.Size = new System.Drawing.Size(187, 22);
            this.OrdYearTextBox.TabIndex = 9;
            this.OrdYearTextBox.Text = "1997";
            // 
            // parameterProcedureSqlCommand
            // 
            this.parameterProcedureSqlCommand.CommandText = "SalesByCategory";
            this.parameterProcedureSqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.parameterProcedureSqlCommand.Connection = this.sqlConnection;
            this.parameterProcedureSqlCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CategoryName", System.Data.SqlDbType.NVarChar, 15),
            new System.Data.SqlClient.SqlParameter("@OrdYear", System.Data.SqlDbType.NVarChar, 4)});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 281);
            this.Controls.Add(this.OrdYearTextBox);
            this.Controls.Add(this.CategoryNameTextBox);
            this.Controls.Add(this.ParameterProcedureButton);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.ParameterQueryButton);
            this.Controls.Add(this.CreateTableButton);
            this.Controls.Add(this.ProcedureButton);
            this.Controls.Add(this.MultiQueryButton);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.SimpleQueryButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "DBCommand";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Data.SqlClient.SqlCommand selectSqlCommand;
        private System.Windows.Forms.Button SimpleQueryButton;
        private System.Windows.Forms.TextBox ResultsTextBox;
        private System.Windows.Forms.Button MultiQueryButton;
        private System.Windows.Forms.Button ProcedureButton;
        private System.Data.SqlClient.SqlCommand procedureSqlCommand;
        private System.Windows.Forms.Button CreateTableButton;
        private System.Data.SqlClient.SqlCommand createSqlCommand;
        private System.Windows.Forms.Button ParameterQueryButton;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Data.SqlClient.SqlCommand parameterSqlCommand;
        private System.Windows.Forms.Button ParameterProcedureButton;
        private System.Windows.Forms.TextBox CategoryNameTextBox;
        private System.Windows.Forms.TextBox OrdYearTextBox;
        private System.Data.SqlClient.SqlCommand parameterProcedureSqlCommand;
    }
}

