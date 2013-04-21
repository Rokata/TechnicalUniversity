using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentInfoSystem.Data;
using System.Windows.Forms;

namespace StudentInfoSystem.Logic
{
    public class LoginValidation
    {
        private string username;
        private string password;
        public string errText {get; private set;}
        public const int FieldLength = 6;

        public LoginValidation(string username, string password)
        {
            this.username = username;
            this.password = password;
            this.errText = string.Empty;
        }

        private bool CheckUsername()
        {
            if (String.IsNullOrEmpty(username) || username.Length < LoginValidation.FieldLength) {
                
                this.errText += "Username empty or too short.";
                return false;
            }
            return true;
        }

        private bool CheckPassword()
        {
            if (String.IsNullOrEmpty(password) || password.Length < LoginValidation.FieldLength)
            {               
                this.errText += " Password empty or too short.";
                return false;
            }
            return true;
        }

        public bool ValidateUserInput(out User user)
        {
            bool validUsername = CheckUsername();
            bool validPassword = CheckPassword();

            User queryResult = UserData.IsUserPassCorrect(username, password);
            user = queryResult;

            if (validPassword && validUsername)
            {
                if (queryResult == null)
                {
                    this.errText += "Въвели сте грешно потребителско име или парола!";
                    return false;
                }

                if (UserData.IsUsernameTaken(this.username)) 
                {
                    this.errText += "Потребителското име е заето!";
                }
            }
            return (validUsername && validPassword);
        }
    }
}
