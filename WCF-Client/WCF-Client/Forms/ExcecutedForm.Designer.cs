
namespace WCF_Client.Forms
{
    partial class ExcecutedForm
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
            this.servicesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addServiceButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.carBrandComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serviceStationsComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // servicesComboBox
            // 
            this.servicesComboBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.servicesComboBox.FormattingEnabled = true;
            this.servicesComboBox.Location = new System.Drawing.Point(87, 74);
            this.servicesComboBox.Name = "servicesComboBox";
            this.servicesComboBox.Size = new System.Drawing.Size(233, 25);
            this.servicesComboBox.TabIndex = 13;
            this.servicesComboBox.SelectedIndexChanged += new System.EventHandler(this.servicesComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(30, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Услуга";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.priceTextBox.Location = new System.Drawing.Point(87, 134);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(60, 23);
            this.priceTextBox.TabIndex = 17;
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.Location = new System.Drawing.Point(39, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Цена";
            // 
            // addServiceButton
            // 
            this.addServiceButton.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.addServiceButton.Location = new System.Drawing.Point(62, 169);
            this.addServiceButton.Name = "addServiceButton";
            this.addServiceButton.Size = new System.Drawing.Size(212, 33);
            this.addServiceButton.TabIndex = 18;
            this.addServiceButton.Text = "Добавить услугу";
            this.addServiceButton.UseVisualStyleBackColor = true;
            this.addServiceButton.Click += new System.EventHandler(this.addServiceButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.Location = new System.Drawing.Point(40, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Дата";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dateTimePicker.Location = new System.Drawing.Point(87, 105);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(158, 23);
            this.dateTimePicker.TabIndex = 20;
            // 
            // carBrandComboBox
            // 
            this.carBrandComboBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.carBrandComboBox.FormattingEnabled = true;
            this.carBrandComboBox.Location = new System.Drawing.Point(87, 43);
            this.carBrandComboBox.Name = "carBrandComboBox";
            this.carBrandComboBox.Size = new System.Drawing.Size(233, 25);
            this.carBrandComboBox.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label5.Location = new System.Drawing.Point(16, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Машина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Назвение";
            // 
            // serviceStationsComboBox
            // 
            this.serviceStationsComboBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.serviceStationsComboBox.FormattingEnabled = true;
            this.serviceStationsComboBox.Location = new System.Drawing.Point(87, 12);
            this.serviceStationsComboBox.Name = "serviceStationsComboBox";
            this.serviceStationsComboBox.Size = new System.Drawing.Size(233, 25);
            this.serviceStationsComboBox.TabIndex = 15;
            this.serviceStationsComboBox.SelectedIndexChanged += new System.EventHandler(this.serviceStationsComboBox_SelectedIndexChanged);
            // 
            // ExcecutedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 214);
            this.Controls.Add(this.carBrandComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addServiceButton);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.serviceStationsComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.servicesComboBox);
            this.Controls.Add(this.label1);
            this.Name = "ExcecutedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выполненные заказы";
            this.Load += new System.EventHandler(this.ExcecutedForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox servicesComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addServiceButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox carBrandComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox serviceStationsComboBox;
    }
}