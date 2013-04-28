using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudentInfoSystem.Logic;
using StudentInfoSystem.Data;

namespace StudentInfoSystem.View
{
    public partial class MainForm : Form
    {
        public UserStatus status { get; private set; }

        public MainForm()
        {
            InitializeComponent();
            status = UserStatus.ANONYMOUS;
            DisableAllControls();
        }

        private void ClearAllControls()
        {
            nameTextBox.Text = "";
            middleNameTextbox.Text = "";
            lastNameTextbox.Text = "";
            facultyTextbox.Text = "";
            specialtyTextbox.Text = "";
            groupNumTextbox.Text = "";
            facNumTextbox.Text = "";
            streamTextbox.Text = "";
            statusDropdown.SelectedIndex = 0;
            oksDropdown.SelectedIndex = 0;
            courseDropdown.Value = 0;

        }

        private void ShowStudentInfo(Data.Student s)
        {
            nameTextBox.Text = s.FirstName;
            middleNameTextbox.Text = s.MiddleName;
            lastNameTextbox.Text = s.LastName;
            facultyTextbox.Text = s.Faculty;
            groupNumTextbox.Text = s.Group.ToString();
            specialtyTextbox.Text = s.Specialty;
            facNumTextbox.Text = s.FacNumber;
            streamTextbox.Text = s.Potok.ToString();
            statusDropdown.SelectedIndex = 0;
            oksDropdown.SelectedIndex = 0;
            courseDropdown.Value = 0;
        }

        private void EnableAllControls()
        {
            personalInfoGroupbox.Enabled = true;
            studentInfoGroupbox.Enabled = true;
            pictureGroupbox.Enabled = true;
            loginLogoutToolStripMenuItem.Text = "Logout";
            pictureButton.Enabled = true;
            btnVisualOptions.Enabled = true;
        }

        private void DisableAllControls()
        {
            personalInfoGroupbox.Enabled = false;
            studentInfoGroupbox.Enabled = false;
            pictureGroupbox.Enabled = false;
            loginLogoutToolStripMenuItem.Text = "Login";
            pictureButton.Enabled = false;
            studentPic.ImageLocation = "";
            btnVisualOptions.Enabled = false;
        }

        private void Login()
        {
            LoginForm form = new LoginForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                EnableAllControls();

                if (UserData.HasAdminRights(form.user.Username))
                {
                    status = UserStatus.ADMIN;
                    addStudentBtn.Visible = true;
                    return;
                }

                Student result = UserData.GetStudentDataByUser(form.user.FacNumber);

                if (result != null)
                {
                    ShowStudentInfo(result);
                    status = UserStatus.STUDENT;
                }    
            }
        }

        private void Logout()
        {
            ClearAllControls();
            DisableAllControls();
            status = UserStatus.ANONYMOUS;
        }

        private void loginLogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (status)
            {
                case UserStatus.ANONYMOUS:
                    {
                        Login();
                        break;
                    }
                case UserStatus.STUDENT:
                    {
                        status = UserStatus.ANONYMOUS;
                        Logout();
                        break;
                    }
                case UserStatus.ADMIN:
                    status = UserStatus.ANONYMOUS;
                    Logout();
                    break;
                default:
                    break;
            }
        }

        private void pictureButton_Click(object sender, EventArgs e)
        {
            LoadStudentPicture();
        }

        private void LoadStudentPicture()
        {
            if (openPictureDialog.ShowDialog() == DialogResult.OK)
            {
                studentPic.ImageLocation = openPictureDialog.FileName;
            }
        }

        private void btnVisualOptions_Click(object sender, EventArgs e)
        {
            string text = GenerateInfoText();
            InfoForm infoForm = new InfoForm(text);
            infoForm.Show();
        }

        private string GenerateInfoText()
        {
            string text = "Уверение\n";
            text += nameTextBox.Text + " " + middleNameTextbox.Text + " " +
            lastNameTextbox.Text;
            text += " е студент/ка във Факултет " + facNumTextbox.Text +
            ", специалност " + specialtyTextbox.Text;
            text += "\n";
            return text;
        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            if (UserData.InsertStudent(new Student() {
                FirstName = "Test",
                LastName = "Testov",
                Faculty = "FKSU",
                Specialty = "KST",
                OKS = 2,
                StudentStatus = 1,
                FacNumber = "348234",
                Course = 3,
                Potok = "9",
                Group = 23,
                MiddleName = "Testov"
            }))
            {
                MessageBox.Show("Student added!");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GroupsForm form = new GroupsForm();
            form.Show();
        }
    }
}
