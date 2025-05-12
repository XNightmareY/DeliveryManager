namespace DeliveryManager
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
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.deliveryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.addDeliveryButton = new System.Windows.Forms.Button();
            this.removeDeliveryButton = new System.Windows.Forms.Button();
            this.updateStatusButton = new System.Windows.Forms.Button();
            this.deliveriesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(10, 10);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(150, 20);
            this.customerNameTextBox.TabIndex = 0;
            this.customerNameTextBox.Text = "Имя клиента";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(170, 10);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(200, 20);
            this.addressTextBox.TabIndex = 1;
            this.addressTextBox.Text = "Адрес";
            // 
            // deliveryDatePicker
            // 
            this.deliveryDatePicker.Location = new System.Drawing.Point(380, 10);
            this.deliveryDatePicker.Name = "deliveryDatePicker";
            this.deliveryDatePicker.Size = new System.Drawing.Size(200, 20);
            this.deliveryDatePicker.TabIndex = 2;
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Новый",
            "В пути",
            "Доставлен"});
            this.statusComboBox.Location = new System.Drawing.Point(10, 40);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(100, 21);
            this.statusComboBox.TabIndex = 3;
            // 
            // addDeliveryButton
            // 
            this.addDeliveryButton.Location = new System.Drawing.Point(10, 70);
            this.addDeliveryButton.Name = "addDeliveryButton";
            this.addDeliveryButton.Size = new System.Drawing.Size(100, 23);
            this.addDeliveryButton.TabIndex = 4;
            this.addDeliveryButton.Text = "Добавить";
            this.addDeliveryButton.UseVisualStyleBackColor = true;
            // 
            // removeDeliveryButton
            // 
            this.removeDeliveryButton.Location = new System.Drawing.Point(120, 70);
            this.removeDeliveryButton.Name = "removeDeliveryButton";
            this.removeDeliveryButton.Size = new System.Drawing.Size(100, 23);
            this.removeDeliveryButton.TabIndex = 5;
            this.removeDeliveryButton.Text = "Удалить";
            this.removeDeliveryButton.UseVisualStyleBackColor = true;
            // 
            // updateStatusButton
            // 
            this.updateStatusButton.Location = new System.Drawing.Point(230, 70);
            this.updateStatusButton.Name = "updateStatusButton";
            this.updateStatusButton.Size = new System.Drawing.Size(120, 23);
            this.updateStatusButton.TabIndex = 6;
            this.updateStatusButton.Text = "Обновить статус";
            this.updateStatusButton.UseVisualStyleBackColor = true;
            // 
            // deliveriesListBox
            // 
            this.deliveriesListBox.FormattingEnabled = true;
            this.deliveriesListBox.Location = new System.Drawing.Point(10, 100);
            this.deliveriesListBox.Name = "deliveriesListBox";
            this.deliveriesListBox.Size = new System.Drawing.Size(560, 238);
            this.deliveriesListBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.deliveriesListBox);
            this.Controls.Add(this.updateStatusButton);
            this.Controls.Add(this.removeDeliveryButton);
            this.Controls.Add(this.addDeliveryButton);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.deliveryDatePicker);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Name = "Form1";
            this.Text = "Управление доставкой";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.DateTimePicker deliveryDatePicker;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Button addDeliveryButton;
        private System.Windows.Forms.Button removeDeliveryButton;
        private System.Windows.Forms.Button updateStatusButton;
        private System.Windows.Forms.ListBox deliveriesListBox;
    }
}

