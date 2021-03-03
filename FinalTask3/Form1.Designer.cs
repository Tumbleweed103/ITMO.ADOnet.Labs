
namespace FinalTask3
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
            this.customerGridView = new System.Windows.Forms.DataGridView();
            this.showCustomersButton = new System.Windows.Forms.Button();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.closeFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerGridView
            // 
            this.customerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.customerGridView.Location = new System.Drawing.Point(0, 63);
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.RowHeadersWidth = 51;
            this.customerGridView.RowTemplate.Height = 24;
            this.customerGridView.Size = new System.Drawing.Size(800, 387);
            this.customerGridView.TabIndex = 0;
            this.customerGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerGridView_CellEndEdit);
            // 
            // showCustomersButton
            // 
            this.showCustomersButton.Location = new System.Drawing.Point(13, 13);
            this.showCustomersButton.Name = "showCustomersButton";
            this.showCustomersButton.Size = new System.Drawing.Size(159, 44);
            this.showCustomersButton.TabIndex = 1;
            this.showCustomersButton.Text = "Показать клиентов";
            this.showCustomersButton.UseVisualStyleBackColor = true;
            this.showCustomersButton.Click += new System.EventHandler(this.showCustomersButton_Click);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(178, 13);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(178, 44);
            this.saveChangesButton.TabIndex = 3;
            this.saveChangesButton.Text = "Сохранить изменения";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // closeFormButton
            // 
            this.closeFormButton.Location = new System.Drawing.Point(363, 13);
            this.closeFormButton.Name = "closeFormButton";
            this.closeFormButton.Size = new System.Drawing.Size(147, 44);
            this.closeFormButton.TabIndex = 4;
            this.closeFormButton.Text = "Закрыть";
            this.closeFormButton.UseVisualStyleBackColor = true;
            this.closeFormButton.Click += new System.EventHandler(this.closeFormButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeFormButton);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.showCustomersButton);
            this.Controls.Add(this.customerGridView);
            this.Name = "Form1";
            this.Text = "Final Task 3";
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView customerGridView;
        private System.Windows.Forms.Button showCustomersButton;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Button closeFormButton;
    }
}

