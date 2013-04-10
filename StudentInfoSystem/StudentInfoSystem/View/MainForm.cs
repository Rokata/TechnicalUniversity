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
        }

        private void DisableAllControls()
        {
            personalInfoGroupbox.Enabled = false;
            studentInfoGroupbox.Enabled = false;
            pictureGroupbox.Enabled = false;
            loginLogoutToolStripMenuItem.Text = "Login";
        }

        private void Login()
        {
            LoginForm form = new LoginForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                EnableAllControls();
                Student result = UserData.GetStudentDataByUser(form.user.FacNumber);

                if (result != null) 
                    ShowStudentInfo(result);
                else 
                    MessageBox.Show("No student found!");

                status = UserStatus.STUDENT;
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
                        status = UserStatus.STUDENT;
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
                    break;
                default:
                    break;
            }
        }
    }
}
