namespace FinalTask4
{
    partial class OrdersForm
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
            this.addOrderButton = new System.Windows.Forms.Button();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.paymentTypeLabel = new System.Windows.Forms.Label();
            this.deliveryTypeLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.ordersGridView = new System.Windows.Forms.DataGridView();
            this.viewOrderButton = new System.Windows.Forms.Button();
            this.deleteOrderButton = new System.Windows.Forms.Button();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.productTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.paymentTypeTextBox = new System.Windows.Forms.TextBox();
            this.deliveryTypeTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addOrderButton
            // 
            this.addOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.addOrderButton.Location = new System.Drawing.Point(378, 89);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(154, 44);
            this.addOrderButton.TabIndex = 15;
            this.addOrderButton.Text = "Добавить заказ";
            this.addOrderButton.UseVisualStyleBackColor = true;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityTextBox.Location = new System.Drawing.Point(139, 44);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(78, 24);
            this.quantityTextBox.TabIndex = 12;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(136, 24);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(86, 17);
            this.quantityLabel.TabIndex = 0;
            this.quantityLabel.Text = "Количество";
            // 
            // paymentTypeLabel
            // 
            this.paymentTypeLabel.AutoSize = true;
            this.paymentTypeLabel.Location = new System.Drawing.Point(375, 24);
            this.paymentTypeLabel.Name = "paymentTypeLabel";
            this.paymentTypeLabel.Size = new System.Drawing.Size(109, 17);
            this.paymentTypeLabel.TabIndex = 0;
            this.paymentTypeLabel.Text = "Способ оплаты";
            // 
            // deliveryTypeLabel
            // 
            this.deliveryTypeLabel.AutoSize = true;
            this.deliveryTypeLabel.Location = new System.Drawing.Point(9, 86);
            this.deliveryTypeLabel.Name = "deliveryTypeLabel";
            this.deliveryTypeLabel.Size = new System.Drawing.Size(120, 17);
            this.deliveryTypeLabel.TabIndex = 0;
            this.deliveryTypeLabel.Text = "Способ доставки";
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(9, 24);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(66, 17);
            this.productLabel.TabIndex = 0;
            this.productLabel.Text = "Предмет";
            // 
            // ordersGridView
            // 
            this.ordersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ordersGridView.Location = new System.Drawing.Point(0, 195);
            this.ordersGridView.Name = "ordersGridView";
            this.ordersGridView.RowHeadersWidth = 51;
            this.ordersGridView.RowTemplate.Height = 24;
            this.ordersGridView.Size = new System.Drawing.Size(736, 301);
            this.ordersGridView.TabIndex = 4;
            // 
            // viewOrderButton
            // 
            this.viewOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewOrderButton.Location = new System.Drawing.Point(12, 12);
            this.viewOrderButton.Name = "viewOrderButton";
            this.viewOrderButton.Size = new System.Drawing.Size(142, 42);
            this.viewOrderButton.TabIndex = 19;
            this.viewOrderButton.Text = "Смотреть заказы";
            this.viewOrderButton.UseVisualStyleBackColor = true;
            this.viewOrderButton.Click += new System.EventHandler(this.viewOrderButton_Click);
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.deleteOrderButton.Location = new System.Drawing.Point(12, 102);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(142, 42);
            this.deleteOrderButton.TabIndex = 20;
            this.deleteOrderButton.Text = "Удалить заказ";
            this.deleteOrderButton.UseVisualStyleBackColor = true;
            this.deleteOrderButton.Click += new System.EventHandler(this.deleteOrderButton_Click);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.saveChangesButton.Location = new System.Drawing.Point(12, 57);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(142, 42);
            this.saveChangesButton.TabIndex = 21;
            this.saveChangesButton.Text = "Сохранить изменения";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // productTextBox
            // 
            this.productTextBox.Location = new System.Drawing.Point(12, 44);
            this.productTextBox.Name = "productTextBox";
            this.productTextBox.Size = new System.Drawing.Size(100, 22);
            this.productTextBox.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deliveryTypeTextBox);
            this.groupBox1.Controls.Add(this.paymentTypeTextBox);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Controls.Add(this.addressLabel);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(this.priceLabel);
            this.groupBox1.Controls.Add(this.addOrderButton);
            this.groupBox1.Controls.Add(this.productTextBox);
            this.groupBox1.Controls.Add(this.productLabel);
            this.groupBox1.Controls.Add(this.quantityLabel);
            this.groupBox1.Controls.Add(this.quantityTextBox);
            this.groupBox1.Controls.Add(this.deliveryTypeLabel);
            this.groupBox1.Controls.Add(this.paymentTypeLabel);
            this.groupBox1.Location = new System.Drawing.Point(173, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 177);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Новый заказ";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(248, 46);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 22);
            this.priceTextBox.TabIndex = 24;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(245, 24);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(78, 17);
            this.priceLabel.TabIndex = 23;
            this.priceLabel.Text = "Стоимость";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(157, 86);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(112, 17);
            this.addressLabel.TabIndex = 25;
            this.addressLabel.Text = "Адрес доставки";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(160, 109);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(188, 22);
            this.addressTextBox.TabIndex = 26;
            // 
            // paymentTypeTextBox
            // 
            this.paymentTypeTextBox.Location = new System.Drawing.Point(378, 46);
            this.paymentTypeTextBox.Name = "paymentTypeTextBox";
            this.paymentTypeTextBox.Size = new System.Drawing.Size(106, 22);
            this.paymentTypeTextBox.TabIndex = 27;
            // 
            // deliveryTypeTextBox
            // 
            this.deliveryTypeTextBox.Location = new System.Drawing.Point(12, 107);
            this.deliveryTypeTextBox.Name = "deliveryTypeTextBox";
            this.deliveryTypeTextBox.Size = new System.Drawing.Size(117, 22);
            this.deliveryTypeTextBox.TabIndex = 28;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 147);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(142, 42);
            this.closeButton.TabIndex = 24;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 496);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.deleteOrderButton);
            this.Controls.Add(this.viewOrderButton);
            this.Controls.Add(this.ordersGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "OrdersForm";
            this.Text = "Final Task 4";
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label deliveryTypeLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label paymentTypeLabel;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.DataGridView ordersGridView;
        private System.Windows.Forms.Button viewOrderButton;
        private System.Windows.Forms.Button deleteOrderButton;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.TextBox productTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox deliveryTypeTextBox;
        private System.Windows.Forms.TextBox paymentTypeTextBox;
        private System.Windows.Forms.Button closeButton;
    }
}