
namespace Lab04_2CreatingDataTable
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
            this.fillChildTableButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fillParentTableButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // fillChildTableButton
            // 
            this.fillChildTableButton.Location = new System.Drawing.Point(12, 12);
            this.fillChildTableButton.Name = "fillChildTableButton";
            this.fillChildTableButton.Size = new System.Drawing.Size(554, 32);
            this.fillChildTableButton.TabIndex = 0;
            this.fillChildTableButton.Text = "Заполнить дочернюю таблицу";
            this.fillChildTableButton.UseVisualStyleBackColor = true;
            this.fillChildTableButton.Click += new System.EventHandler(this.fillChildTableButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(554, 299);
            this.dataGridView1.TabIndex = 1;
            // 
            // fillParentTableButton
            // 
            this.fillParentTableButton.Location = new System.Drawing.Point(573, 12);
            this.fillParentTableButton.Name = "fillParentTableButton";
            this.fillParentTableButton.Size = new System.Drawing.Size(564, 32);
            this.fillParentTableButton.TabIndex = 2;
            this.fillParentTableButton.Text = "Заполнить основную таблицу";
            this.fillParentTableButton.UseVisualStyleBackColor = true;
            this.fillParentTableButton.Click += new System.EventHandler(this.fillParentTableButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(573, 51);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(564, 299);
            this.dataGridView2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 362);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.fillParentTableButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fillChildTableButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "CreatingDataTable";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fillChildTableButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button fillParentTableButton;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

