namespace HRDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.компанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCompanyItem = new System.Windows.Forms.ToolStripMenuItem();
            this.департаментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddDepItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelDepItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditDepItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddEmployeeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelEmployeeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditEmployeeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Caption = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EmployeesList = new System.Windows.Forms.ListBox();
            this.DepartmentsList = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BirthField = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.MailField = new System.Windows.Forms.TextBox();
            this.ExperField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SalaryField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PosField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SpecField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PhoneField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PhotoBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.компанияToolStripMenuItem,
            this.департаментыToolStripMenuItem,
            this.сотрудникиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // компанияToolStripMenuItem
            // 
            this.компанияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditCompanyItem});
            this.компанияToolStripMenuItem.Name = "компанияToolStripMenuItem";
            this.компанияToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.компанияToolStripMenuItem.Text = "Компания";
            // 
            // EditCompanyItem
            // 
            this.EditCompanyItem.Name = "EditCompanyItem";
            this.EditCompanyItem.Size = new System.Drawing.Size(128, 22);
            this.EditCompanyItem.Text = "Изменить";
            // 
            // департаментыToolStripMenuItem
            // 
            this.департаментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddDepItem,
            this.DelDepItem,
            this.EditDepItem});
            this.департаментыToolStripMenuItem.Name = "департаментыToolStripMenuItem";
            this.департаментыToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.департаментыToolStripMenuItem.Text = "Департаменты";
            // 
            // AddDepItem
            // 
            this.AddDepItem.Name = "AddDepItem";
            this.AddDepItem.Size = new System.Drawing.Size(128, 22);
            this.AddDepItem.Text = "Добавить";
            this.AddDepItem.Click += new System.EventHandler(this.AddDepItem_Click);
            // 
            // DelDepItem
            // 
            this.DelDepItem.Name = "DelDepItem";
            this.DelDepItem.Size = new System.Drawing.Size(128, 22);
            this.DelDepItem.Text = "Удалить";
            this.DelDepItem.Click += new System.EventHandler(this.DelDepItem_Click);
            // 
            // EditDepItem
            // 
            this.EditDepItem.Name = "EditDepItem";
            this.EditDepItem.Size = new System.Drawing.Size(128, 22);
            this.EditDepItem.Text = "Изменить";
            this.EditDepItem.Click += new System.EventHandler(this.EditDepItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddEmployeeItem,
            this.DelEmployeeItem,
            this.EditEmployeeItem});
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            // 
            // AddEmployeeItem
            // 
            this.AddEmployeeItem.Name = "AddEmployeeItem";
            this.AddEmployeeItem.Size = new System.Drawing.Size(128, 22);
            this.AddEmployeeItem.Text = "Добавить";
            // 
            // DelEmployeeItem
            // 
            this.DelEmployeeItem.Name = "DelEmployeeItem";
            this.DelEmployeeItem.Size = new System.Drawing.Size(128, 22);
            this.DelEmployeeItem.Text = "Удалить";
            // 
            // EditEmployeeItem
            // 
            this.EditEmployeeItem.Name = "EditEmployeeItem";
            this.EditEmployeeItem.Size = new System.Drawing.Size(128, 22);
            this.EditEmployeeItem.Text = "Изменить";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Caption);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 100);
            this.panel1.TabIndex = 1;
            // 
            // Caption
            // 
            this.Caption.AutoSize = true;
            this.Caption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Caption.ForeColor = System.Drawing.Color.Blue;
            this.Caption.Location = new System.Drawing.Point(248, 34);
            this.Caption.Name = "Caption";
            this.Caption.Size = new System.Drawing.Size(418, 24);
            this.Caption.TabIndex = 1;
            this.Caption.Text = "Отдел кадров компании \"Company name\"";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::HRDepartment.Properties.Resources.iconfinder_squirrel_298871;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EmployeesList);
            this.groupBox1.Controls.Add(this.DepartmentsList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 546);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Департаменты";
            // 
            // EmployeesList
            // 
            this.EmployeesList.FormattingEnabled = true;
            this.EmployeesList.ItemHeight = 20;
            this.EmployeesList.Location = new System.Drawing.Point(6, 59);
            this.EmployeesList.Name = "EmployeesList";
            this.EmployeesList.ScrollAlwaysVisible = true;
            this.EmployeesList.Size = new System.Drawing.Size(226, 384);
            this.EmployeesList.TabIndex = 1;
            this.EmployeesList.SelectedIndexChanged += new System.EventHandler(this.EmployeesList_SelectedIndexChanged);
            // 
            // DepartmentsList
            // 
            this.DepartmentsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartmentsList.FormattingEnabled = true;
            this.DepartmentsList.Location = new System.Drawing.Point(6, 25);
            this.DepartmentsList.Name = "DepartmentsList";
            this.DepartmentsList.Size = new System.Drawing.Size(226, 28);
            this.DepartmentsList.TabIndex = 0;
            this.DepartmentsList.SelectedIndexChanged += new System.EventHandler(this.DepartmentsList_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BirthField);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.MailField);
            this.groupBox2.Controls.Add(this.ExperField);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.SalaryField);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.PosField);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.SpecField);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.PhoneField);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.NameField);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(513, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 546);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Персональная информация";
            // 
            // BirthField
            // 
            this.BirthField.Location = new System.Drawing.Point(10, 111);
            this.BirthField.Name = "BirthField";
            this.BirthField.Size = new System.Drawing.Size(254, 26);
            this.BirthField.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(6, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Email";
            // 
            // MailField
            // 
            this.MailField.Location = new System.Drawing.Point(10, 221);
            this.MailField.Name = "MailField";
            this.MailField.ReadOnly = true;
            this.MailField.Size = new System.Drawing.Size(254, 26);
            this.MailField.TabIndex = 15;
            // 
            // ExperField
            // 
            this.ExperField.Location = new System.Drawing.Point(10, 433);
            this.ExperField.Name = "ExperField";
            this.ExperField.ReadOnly = true;
            this.ExperField.Size = new System.Drawing.Size(254, 26);
            this.ExperField.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(6, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Стаж";
            // 
            // SalaryField
            // 
            this.SalaryField.Location = new System.Drawing.Point(10, 381);
            this.SalaryField.Name = "SalaryField";
            this.SalaryField.ReadOnly = true;
            this.SalaryField.Size = new System.Drawing.Size(254, 26);
            this.SalaryField.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(6, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Зарплата";
            // 
            // PosField
            // 
            this.PosField.Location = new System.Drawing.Point(10, 329);
            this.PosField.Name = "PosField";
            this.PosField.ReadOnly = true;
            this.PosField.Size = new System.Drawing.Size(254, 26);
            this.PosField.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(6, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Должность";
            // 
            // SpecField
            // 
            this.SpecField.Location = new System.Drawing.Point(10, 277);
            this.SpecField.Name = "SpecField";
            this.SpecField.ReadOnly = true;
            this.SpecField.Size = new System.Drawing.Size(254, 26);
            this.SpecField.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(6, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Специальность";
            // 
            // PhoneField
            // 
            this.PhoneField.Location = new System.Drawing.Point(10, 169);
            this.PhoneField.Name = "PhoneField";
            this.PhoneField.ReadOnly = true;
            this.PhoneField.Size = new System.Drawing.Size(254, 26);
            this.PhoneField.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(6, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Телефон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата рождения";
            // 
            // NameField
            // 
            this.NameField.Location = new System.Drawing.Point(10, 59);
            this.NameField.Name = "NameField";
            this.NameField.ReadOnly = true;
            this.NameField.Size = new System.Drawing.Size(254, 26);
            this.NameField.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия Имя";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PhotoBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(238, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 546);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Фото сотрудника";
            // 
            // PhotoBox
            // 
            this.PhotoBox.Image = global::HRDepartment.Properties.Resources.profile;
            this.PhotoBox.Location = new System.Drawing.Point(0, 25);
            this.PhotoBox.Name = "PhotoBox";
            this.PhotoBox.Size = new System.Drawing.Size(269, 330);
            this.PhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhotoBox.TabIndex = 0;
            this.PhotoBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 670);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Система управления отделом кадров компании";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem компанияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditCompanyItem;
        private System.Windows.Forms.ToolStripMenuItem департаментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddDepItem;
        private System.Windows.Forms.ToolStripMenuItem DelDepItem;
        private System.Windows.Forms.ToolStripMenuItem EditDepItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddEmployeeItem;
        private System.Windows.Forms.ToolStripMenuItem DelEmployeeItem;
        private System.Windows.Forms.ToolStripMenuItem EditEmployeeItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Caption;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox DepartmentsList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox EmployeesList;
        private System.Windows.Forms.DateTimePicker BirthField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MailField;
        private System.Windows.Forms.TextBox ExperField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SalaryField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PosField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SpecField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PhoneField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PhotoBox;
    }
}

