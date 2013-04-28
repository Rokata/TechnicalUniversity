namespace StudentInfoSystem.View
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginLogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.btnVisualOptions = new System.Windows.Forms.Button();
            this.pictureButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.studentInfoGroupbox = new System.Windows.Forms.GroupBox();
            this.groupNumTextbox = new System.Windows.Forms.TextBox();
            this.groupLbl = new System.Windows.Forms.Label();
            this.streamTextbox = new System.Windows.Forms.TextBox();
            this.streamLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.oksLbl = new System.Windows.Forms.Label();
            this.statusDropdown = new System.Windows.Forms.ComboBox();
            this.oksDropdown = new System.Windows.Forms.ComboBox();
            this.courseDropdown = new System.Windows.Forms.NumericUpDown();
            this.specialtyTextbox = new System.Windows.Forms.TextBox();
            this.specialtyLbl = new System.Windows.Forms.Label();
            this.facNumTextbox = new System.Windows.Forms.TextBox();
            this.facultyTextbox = new System.Windows.Forms.TextBox();
            this.facNumLbl = new System.Windows.Forms.Label();
            this.facultyLbl = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.personalInfoGroupbox = new System.Windows.Forms.GroupBox();
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            this.middleNameTextbox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.pictureGroupbox = new System.Windows.Forms.GroupBox();
            this.studentPic = new System.Windows.Forms.PictureBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.openPictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.studentInfoGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseDropdown)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.personalInfoGroupbox.SuspendLayout();
            this.pictureGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentPic)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editrToolStripMenuItem,
            this.iewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(686, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginLogoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loginLogoutToolStripMenuItem
            // 
            this.loginLogoutToolStripMenuItem.Name = "loginLogoutToolStripMenuItem";
            this.loginLogoutToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.loginLogoutToolStripMenuItem.Text = "Login";
            this.loginLogoutToolStripMenuItem.Click += new System.EventHandler(this.loginLogoutToolStripMenuItem_Click);
            // 
            // editrToolStripMenuItem
            // 
            this.editrToolStripMenuItem.Name = "editrToolStripMenuItem";
            this.editrToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editrToolStripMenuItem.Text = "Edit";
            // 
            // iewToolStripMenuItem
            // 
            this.iewToolStripMenuItem.Name = "iewToolStripMenuItem";
            this.iewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.iewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabPage1);
            this.mainTabControl.Controls.Add(this.tabPage2);
            this.mainTabControl.Location = new System.Drawing.Point(13, 28);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(667, 505);
            this.mainTabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.addStudentBtn);
            this.tabPage1.Controls.Add(this.btnVisualOptions);
            this.tabPage1.Controls.Add(this.pictureButton);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.studentInfoGroupbox);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.personalInfoGroupbox);
            this.tabPage1.Controls.Add(this.pictureGroupbox);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(659, 479);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Студент";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.Location = new System.Drawing.Point(24, 391);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(109, 23);
            this.addStudentBtn.TabIndex = 10;
            this.addStudentBtn.Text = "Add Student";
            this.addStudentBtn.UseVisualStyleBackColor = true;
            this.addStudentBtn.Visible = false;
            this.addStudentBtn.Click += new System.EventHandler(this.addStudentBtn_Click);
            // 
            // btnVisualOptions
            // 
            this.btnVisualOptions.Location = new System.Drawing.Point(24, 431);
            this.btnVisualOptions.Name = "btnVisualOptions";
            this.btnVisualOptions.Size = new System.Drawing.Size(109, 23);
            this.btnVisualOptions.TabIndex = 9;
            this.btnVisualOptions.Text = "Visual Options...";
            this.btnVisualOptions.UseVisualStyleBackColor = true;
            this.btnVisualOptions.Click += new System.EventHandler(this.btnVisualOptions_Click);
            // 
            // pictureButton
            // 
            this.pictureButton.Location = new System.Drawing.Point(42, 190);
            this.pictureButton.Name = "pictureButton";
            this.pictureButton.Size = new System.Drawing.Size(75, 23);
            this.pictureButton.TabIndex = 8;
            this.pictureButton.Text = "Upload...";
            this.pictureButton.UseVisualStyleBackColor = true;
            this.pictureButton.Click += new System.EventHandler(this.pictureButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(743, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Поток:";
            // 
            // studentInfoGroupbox
            // 
            this.studentInfoGroupbox.Controls.Add(this.groupNumTextbox);
            this.studentInfoGroupbox.Controls.Add(this.groupLbl);
            this.studentInfoGroupbox.Controls.Add(this.streamTextbox);
            this.studentInfoGroupbox.Controls.Add(this.streamLbl);
            this.studentInfoGroupbox.Controls.Add(this.label8);
            this.studentInfoGroupbox.Controls.Add(this.statusLbl);
            this.studentInfoGroupbox.Controls.Add(this.oksLbl);
            this.studentInfoGroupbox.Controls.Add(this.statusDropdown);
            this.studentInfoGroupbox.Controls.Add(this.oksDropdown);
            this.studentInfoGroupbox.Controls.Add(this.courseDropdown);
            this.studentInfoGroupbox.Controls.Add(this.specialtyTextbox);
            this.studentInfoGroupbox.Controls.Add(this.specialtyLbl);
            this.studentInfoGroupbox.Controls.Add(this.facNumTextbox);
            this.studentInfoGroupbox.Controls.Add(this.facultyTextbox);
            this.studentInfoGroupbox.Controls.Add(this.facNumLbl);
            this.studentInfoGroupbox.Controls.Add(this.facultyLbl);
            this.studentInfoGroupbox.Location = new System.Drawing.Point(157, 222);
            this.studentInfoGroupbox.Name = "studentInfoGroupbox";
            this.studentInfoGroupbox.Size = new System.Drawing.Size(468, 232);
            this.studentInfoGroupbox.TabIndex = 2;
            this.studentInfoGroupbox.TabStop = false;
            this.studentInfoGroupbox.Text = "Студентска информация";
            // 
            // groupNumTextbox
            // 
            this.groupNumTextbox.Location = new System.Drawing.Point(346, 82);
            this.groupNumTextbox.Name = "groupNumTextbox";
            this.groupNumTextbox.Size = new System.Drawing.Size(47, 20);
            this.groupNumTextbox.TabIndex = 8;
            // 
            // groupLbl
            // 
            this.groupLbl.AutoSize = true;
            this.groupLbl.Location = new System.Drawing.Point(301, 85);
            this.groupLbl.Name = "groupLbl";
            this.groupLbl.Size = new System.Drawing.Size(39, 13);
            this.groupLbl.TabIndex = 7;
            this.groupLbl.Text = "Група:";
            // 
            // streamTextbox
            // 
            this.streamTextbox.Location = new System.Drawing.Point(347, 56);
            this.streamTextbox.Name = "streamTextbox";
            this.streamTextbox.Size = new System.Drawing.Size(47, 20);
            this.streamTextbox.TabIndex = 8;
            // 
            // streamLbl
            // 
            this.streamLbl.AutoSize = true;
            this.streamLbl.Location = new System.Drawing.Point(301, 59);
            this.streamLbl.Name = "streamLbl";
            this.streamLbl.Size = new System.Drawing.Size(41, 13);
            this.streamLbl.TabIndex = 7;
            this.streamLbl.Text = "Поток:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(306, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Курс:";
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(36, 111);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(44, 13);
            this.statusLbl.TabIndex = 6;
            this.statusLbl.Text = "Статус:";
            // 
            // oksLbl
            // 
            this.oksLbl.AutoSize = true;
            this.oksLbl.Location = new System.Drawing.Point(48, 85);
            this.oksLbl.Name = "oksLbl";
            this.oksLbl.Size = new System.Drawing.Size(32, 13);
            this.oksLbl.TabIndex = 6;
            this.oksLbl.Text = "ОКС:";
            // 
            // statusDropdown
            // 
            this.statusDropdown.FormattingEnabled = true;
            this.statusDropdown.Items.AddRange(new object[] {
            "Избери...",
            "Редовно\t",
            "Задочно",
            "Прекъснато",
            "Изгонен",
            "Изритан"});
            this.statusDropdown.Location = new System.Drawing.Point(86, 108);
            this.statusDropdown.Name = "statusDropdown";
            this.statusDropdown.Size = new System.Drawing.Size(121, 21);
            this.statusDropdown.TabIndex = 5;
            // 
            // oksDropdown
            // 
            this.oksDropdown.FormattingEnabled = true;
            this.oksDropdown.Items.AddRange(new object[] {
            "Избери...",
            "Бакалавър",
            "Магистър",
            "Друга"});
            this.oksDropdown.Location = new System.Drawing.Point(86, 81);
            this.oksDropdown.Name = "oksDropdown";
            this.oksDropdown.Size = new System.Drawing.Size(121, 21);
            this.oksDropdown.TabIndex = 5;
            // 
            // courseDropdown
            // 
            this.courseDropdown.Location = new System.Drawing.Point(346, 28);
            this.courseDropdown.Name = "courseDropdown";
            this.courseDropdown.Size = new System.Drawing.Size(48, 20);
            this.courseDropdown.TabIndex = 4;
            // 
            // specialtyTextbox
            // 
            this.specialtyTextbox.Location = new System.Drawing.Point(86, 53);
            this.specialtyTextbox.Name = "specialtyTextbox";
            this.specialtyTextbox.Size = new System.Drawing.Size(211, 20);
            this.specialtyTextbox.TabIndex = 3;
            // 
            // specialtyLbl
            // 
            this.specialtyLbl.AutoSize = true;
            this.specialtyLbl.Location = new System.Drawing.Point(4, 56);
            this.specialtyLbl.Name = "specialtyLbl";
            this.specialtyLbl.Size = new System.Drawing.Size(76, 13);
            this.specialtyLbl.TabIndex = 2;
            this.specialtyLbl.Text = "Специалност:";
            // 
            // facNumTextbox
            // 
            this.facNumTextbox.Location = new System.Drawing.Point(86, 135);
            this.facNumTextbox.Name = "facNumTextbox";
            this.facNumTextbox.Size = new System.Drawing.Size(211, 20);
            this.facNumTextbox.TabIndex = 1;
            // 
            // facultyTextbox
            // 
            this.facultyTextbox.Location = new System.Drawing.Point(86, 28);
            this.facultyTextbox.Name = "facultyTextbox";
            this.facultyTextbox.Size = new System.Drawing.Size(211, 20);
            this.facultyTextbox.TabIndex = 1;
            // 
            // facNumLbl
            // 
            this.facNumLbl.AutoSize = true;
            this.facNumLbl.Location = new System.Drawing.Point(9, 138);
            this.facNumLbl.Name = "facNumLbl";
            this.facNumLbl.Size = new System.Drawing.Size(71, 13);
            this.facNumLbl.TabIndex = 0;
            this.facNumLbl.Text = "Фак. номер:";
            // 
            // facultyLbl
            // 
            this.facultyLbl.AutoSize = true;
            this.facultyLbl.Location = new System.Drawing.Point(20, 28);
            this.facultyLbl.Name = "facultyLbl";
            this.facultyLbl.Size = new System.Drawing.Size(60, 13);
            this.facultyLbl.TabIndex = 0;
            this.facultyLbl.Text = "Факултет:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(165, 228);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(443, 232);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Студентска информация";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Поток:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Курс:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ОКС:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(78, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(346, 28);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(78, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Специалност:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Факултет:";
            // 
            // personalInfoGroupbox
            // 
            this.personalInfoGroupbox.Controls.Add(this.lastNameTextbox);
            this.personalInfoGroupbox.Controls.Add(this.middleNameTextbox);
            this.personalInfoGroupbox.Controls.Add(this.lastNameLabel);
            this.personalInfoGroupbox.Controls.Add(this.middleNameLabel);
            this.personalInfoGroupbox.Controls.Add(this.nameTextBox);
            this.personalInfoGroupbox.Controls.Add(this.nameLabel);
            this.personalInfoGroupbox.Location = new System.Drawing.Point(165, 22);
            this.personalInfoGroupbox.Name = "personalInfoGroupbox";
            this.personalInfoGroupbox.Size = new System.Drawing.Size(329, 162);
            this.personalInfoGroupbox.TabIndex = 1;
            this.personalInfoGroupbox.TabStop = false;
            this.personalInfoGroupbox.Text = "Лични данни";
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Location = new System.Drawing.Point(74, 81);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(215, 20);
            this.lastNameTextbox.TabIndex = 5;
            // 
            // middleNameTextbox
            // 
            this.middleNameTextbox.Location = new System.Drawing.Point(74, 49);
            this.middleNameTextbox.Name = "middleNameTextbox";
            this.middleNameTextbox.Size = new System.Drawing.Size(215, 20);
            this.middleNameTextbox.TabIndex = 4;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(16, 84);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Фамилия";
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Location = new System.Drawing.Point(19, 56);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(53, 13);
            this.middleNameLabel.TabIndex = 2;
            this.middleNameLabel.Text = "Презиме";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(74, 20);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(215, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(43, 27);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(29, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Име";
            // 
            // pictureGroupbox
            // 
            this.pictureGroupbox.Controls.Add(this.studentPic);
            this.pictureGroupbox.Location = new System.Drawing.Point(18, 14);
            this.pictureGroupbox.Name = "pictureGroupbox";
            this.pictureGroupbox.Size = new System.Drawing.Size(129, 170);
            this.pictureGroupbox.TabIndex = 0;
            this.pictureGroupbox.TabStop = false;
            this.pictureGroupbox.Text = "Снимка";
            // 
            // studentPic
            // 
            this.studentPic.Location = new System.Drawing.Point(6, 19);
            this.studentPic.Name = "studentPic";
            this.studentPic.Size = new System.Drawing.Size(117, 145);
            this.studentPic.TabIndex = 0;
            this.studentPic.TabStop = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(511, 282);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(48, 20);
            this.textBox6.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(515, 282);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(56, 20);
            this.textBox3.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(659, 479);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Оценки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // openPictureDialog
            // 
            this.openPictureDialog.FileName = "openFileDialog1";
            this.openPictureDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 545);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.studentInfoGroupbox.ResumeLayout(false);
            this.studentInfoGroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseDropdown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.personalInfoGroupbox.ResumeLayout(false);
            this.personalInfoGroupbox.PerformLayout();
            this.pictureGroupbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox personalInfoGroupbox;
        private System.Windows.Forms.TextBox lastNameTextbox;
        private System.Windows.Forms.TextBox middleNameTextbox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox pictureGroupbox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox studentInfoGroupbox;
        private System.Windows.Forms.TextBox groupNumTextbox;
        private System.Windows.Forms.Label groupLbl;
        private System.Windows.Forms.TextBox streamTextbox;
        private System.Windows.Forms.Label streamLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label oksLbl;
        private System.Windows.Forms.ComboBox statusDropdown;
        private System.Windows.Forms.ComboBox oksDropdown;
        private System.Windows.Forms.NumericUpDown courseDropdown;
        private System.Windows.Forms.TextBox specialtyTextbox;
        private System.Windows.Forms.Label specialtyLbl;
        private System.Windows.Forms.TextBox facultyTextbox;
        private System.Windows.Forms.Label facultyLbl;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox facNumTextbox;
        private System.Windows.Forms.Label facNumLbl;
        private System.Windows.Forms.PictureBox studentPic;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginLogoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iewToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openPictureDialog;
        private System.Windows.Forms.Button pictureButton;
        private System.Windows.Forms.Button btnVisualOptions;
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.Button button1;
    }
}