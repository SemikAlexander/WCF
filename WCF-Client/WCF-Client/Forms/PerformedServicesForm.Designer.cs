
namespace WCF_Client.Forms
{
    partial class PerformedServicesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceStationsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.totalAmountSTOTextBox = new System.Windows.Forms.TextBox();
            this.countServicesSTOTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.countServicesTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totalAmountTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.filterCheckBox = new System.Windows.Forms.CheckBox();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.untilDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameCar,
            this.YearCar,
            this.Service,
            this.Price,
            this.DateService});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(688, 332);
            this.dataGridView1.TabIndex = 5;
            // 
            // NameCar
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.NameCar.DefaultCellStyle = dataGridViewCellStyle2;
            this.NameCar.HeaderText = "Название авто";
            this.NameCar.Name = "NameCar";
            this.NameCar.ReadOnly = true;
            this.NameCar.Width = 170;
            // 
            // YearCar
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.YearCar.DefaultCellStyle = dataGridViewCellStyle3;
            this.YearCar.HeaderText = "Год";
            this.YearCar.Name = "YearCar";
            this.YearCar.ReadOnly = true;
            this.YearCar.Width = 70;
            // 
            // Service
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Service.DefaultCellStyle = dataGridViewCellStyle4;
            this.Service.HeaderText = "Услуга";
            this.Service.Name = "Service";
            this.Service.ReadOnly = true;
            this.Service.Width = 200;
            // 
            // Price
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Price.DefaultCellStyle = dataGridViewCellStyle5;
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 80;
            // 
            // DateService
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.DateService.DefaultCellStyle = dataGridViewCellStyle6;
            this.DateService.HeaderText = "Дата выполнения";
            this.DateService.Name = "DateService";
            this.DateService.ReadOnly = true;
            this.DateService.Width = 120;
            // 
            // serviceStationsComboBox
            // 
            this.serviceStationsComboBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.serviceStationsComboBox.FormattingEnabled = true;
            this.serviceStationsComboBox.Location = new System.Drawing.Point(135, 355);
            this.serviceStationsComboBox.Name = "serviceStationsComboBox";
            this.serviceStationsComboBox.Size = new System.Drawing.Size(283, 25);
            this.serviceStationsComboBox.TabIndex = 17;
            this.serviceStationsComboBox.SelectedIndexChanged += new System.EventHandler(this.serviceStationsComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.Location = new System.Drawing.Point(28, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Назвение СТО";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(243, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Сумма";
            // 
            // totalAmountSTOTextBox
            // 
            this.totalAmountSTOTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.totalAmountSTOTextBox.Location = new System.Drawing.Point(305, 386);
            this.totalAmountSTOTextBox.Name = "totalAmountSTOTextBox";
            this.totalAmountSTOTextBox.ReadOnly = true;
            this.totalAmountSTOTextBox.Size = new System.Drawing.Size(113, 23);
            this.totalAmountSTOTextBox.TabIndex = 19;
            // 
            // countServicesSTOTextBox
            // 
            this.countServicesSTOTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.countServicesSTOTextBox.Location = new System.Drawing.Point(135, 386);
            this.countServicesSTOTextBox.Name = "countServicesSTOTextBox";
            this.countServicesSTOTextBox.ReadOnly = true;
            this.countServicesSTOTextBox.Size = new System.Drawing.Size(100, 23);
            this.countServicesSTOTextBox.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.Location = new System.Drawing.Point(12, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Выполнено услуг";
            // 
            // countServicesTextBox
            // 
            this.countServicesTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.countServicesTextBox.Location = new System.Drawing.Point(598, 358);
            this.countServicesTextBox.Name = "countServicesTextBox";
            this.countServicesTextBox.ReadOnly = true;
            this.countServicesTextBox.Size = new System.Drawing.Size(102, 23);
            this.countServicesTextBox.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.Location = new System.Drawing.Point(435, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Всего выполнено услуг";
            // 
            // totalAmountTextBox
            // 
            this.totalAmountTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.totalAmountTextBox.Location = new System.Drawing.Point(598, 387);
            this.totalAmountTextBox.Name = "totalAmountTextBox";
            this.totalAmountTextBox.ReadOnly = true;
            this.totalAmountTextBox.Size = new System.Drawing.Size(102, 23);
            this.totalAmountTextBox.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label5.Location = new System.Drawing.Point(487, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Общая сумма";
            // 
            // filterCheckBox
            // 
            this.filterCheckBox.AutoSize = true;
            this.filterCheckBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.filterCheckBox.Location = new System.Drawing.Point(385, 423);
            this.filterCheckBox.Name = "filterCheckBox";
            this.filterCheckBox.Size = new System.Drawing.Size(142, 21);
            this.filterCheckBox.TabIndex = 27;
            this.filterCheckBox.Text = "Учитывать фильтр";
            this.filterCheckBox.UseVisualStyleBackColor = true;
            this.filterCheckBox.CheckedChanged += new System.EventHandler(this.filterCheckBox_CheckedChanged);
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.fromDateTimePicker.Location = new System.Drawing.Point(41, 421);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(153, 23);
            this.fromDateTimePicker.TabIndex = 28;
            this.fromDateTimePicker.ValueChanged += new System.EventHandler(this.fromDateTimePicker_ValueChanged);
            // 
            // untilDateTimePicker
            // 
            this.untilDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.untilDateTimePicker.Location = new System.Drawing.Point(232, 421);
            this.untilDateTimePicker.Name = "untilDateTimePicker";
            this.untilDateTimePicker.Size = new System.Drawing.Size(147, 23);
            this.untilDateTimePicker.TabIndex = 29;
            this.untilDateTimePicker.ValueChanged += new System.EventHandler(this.untilDateTimePicker_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label6.Location = new System.Drawing.Point(12, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "С:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label7.Location = new System.Drawing.Point(200, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "По:";
            // 
            // PerformedServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 456);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.untilDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.filterCheckBox);
            this.Controls.Add(this.countServicesTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalAmountTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.countServicesSTOTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalAmountSTOTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serviceStationsComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PerformedServicesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о выполненных услугах";
            this.Load += new System.EventHandler(this.PerformedServicesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox serviceStationsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalAmountSTOTextBox;
        private System.Windows.Forms.TextBox countServicesSTOTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox countServicesTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalAmountTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox filterCheckBox;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.DateTimePicker untilDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}