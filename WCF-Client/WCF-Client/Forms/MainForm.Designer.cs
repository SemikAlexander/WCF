
namespace WCF_Client
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выполненнуюРаботуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маркиМашинToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видыУслугToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выполенныеУслугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDStation,
            this.NameStation,
            this.AddressStation,
            this.DescriptionStation});
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(551, 472);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // IDStation
            // 
            this.IDStation.HeaderText = "ID";
            this.IDStation.Name = "IDStation";
            this.IDStation.ReadOnly = true;
            this.IDStation.Visible = false;
            // 
            // NameStation
            // 
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameStation.DefaultCellStyle = dataGridViewCellStyle14;
            this.NameStation.HeaderText = "Название";
            this.NameStation.Name = "NameStation";
            this.NameStation.ReadOnly = true;
            this.NameStation.Width = 150;
            // 
            // AddressStation
            // 
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.AddressStation.DefaultCellStyle = dataGridViewCellStyle15;
            this.AddressStation.HeaderText = "Адрес";
            this.AddressStation.Name = "AddressStation";
            this.AddressStation.ReadOnly = true;
            this.AddressStation.Width = 150;
            // 
            // DescriptionStation
            // 
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.DescriptionStation.DefaultCellStyle = dataGridViewCellStyle16;
            this.DescriptionStation.HeaderText = "Описание";
            this.DescriptionStation.Name = "DescriptionStation";
            this.DescriptionStation.ReadOnly = true;
            this.DescriptionStation.Width = 200;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Location = new System.Drawing.Point(12, 505);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 234);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.Location = new System.Drawing.Point(278, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Адрес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(3, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Описание";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionTextBox.Location = new System.Drawing.Point(3, 69);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(544, 125);
            this.descriptionTextBox.TabIndex = 7;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressTextBox.Location = new System.Drawing.Point(275, 24);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(271, 22);
            this.addressTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.nameTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.nameTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(3, 24);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(266, 22);
            this.nameTextBox.TabIndex = 5;
            this.nameTextBox.Tag = "";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(180, 200);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(180, 31);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "ДОБАВИТЬ";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(575, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выполненнуюРаботуToolStripMenuItem});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // выполненнуюРаботуToolStripMenuItem
            // 
            this.выполненнуюРаботуToolStripMenuItem.Name = "выполненнуюРаботуToolStripMenuItem";
            this.выполненнуюРаботуToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.выполненнуюРаботуToolStripMenuItem.Text = "Выполненную работу";
            this.выполненнуюРаботуToolStripMenuItem.Click += new System.EventHandler(this.выполненнуюРаботуToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.маркиМашинToolStripMenuItem,
            this.видыУслугToolStripMenuItem,
            this.выполенныеУслугиToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.справкаToolStripMenuItem.Text = "Просмотр";
            // 
            // маркиМашинToolStripMenuItem
            // 
            this.маркиМашинToolStripMenuItem.Name = "маркиМашинToolStripMenuItem";
            this.маркиМашинToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.маркиМашинToolStripMenuItem.Text = "Марки машин";
            this.маркиМашинToolStripMenuItem.Click += new System.EventHandler(this.маркиМашинToolStripMenuItem_Click);
            // 
            // видыУслугToolStripMenuItem
            // 
            this.видыУслугToolStripMenuItem.Name = "видыУслугToolStripMenuItem";
            this.видыУслугToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.видыУслугToolStripMenuItem.Text = "Виды услуг";
            this.видыУслугToolStripMenuItem.Click += new System.EventHandler(this.видыУслугToolStripMenuItem_Click);
            // 
            // выполенныеУслугиToolStripMenuItem
            // 
            this.выполенныеУслугиToolStripMenuItem.Name = "выполенныеУслугиToolStripMenuItem";
            this.выполенныеУслугиToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.выполенныеУслугиToolStripMenuItem.Text = "Выполенных работ";
            this.выполенныеУслугиToolStripMenuItem.Click += new System.EventHandler(this.выполенныеУслугиToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 751);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маркиМашинToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видыУслугToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionStation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выполненнуюРаботуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выполенныеУслугиToolStripMenuItem;
    }
}