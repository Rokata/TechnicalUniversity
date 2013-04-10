using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentInfoSystem.Data
{
    public class UserData
    {
        public static User IsUserPassCorrect(string username, string password)
        {
            return UserData._IsUserPassCorrect(username, password);
        }

        private static User _IsUserPassCorrect(string username, string password)
        {
            UserDataClassesDataContext dc = new UserDataClassesDataContext();
            var queryResult = (from users in dc.GetTable<User>()
                               where (users.Username == username) &&
                               (users.Password == password)
                               select users).ToArray<User>();

            if (queryResult.Count<User>() > 0)
                return queryResult.ElementAt<User>(0);

            return null;
        }

        public static bool IsUsernameTaken(string username)
        {
            UserDataClassesDataContext dc = new UserDataClassesDataContext();
            var queryResult = (from users in dc.GetTable<User>()
                               where (users.Username == username)
                               select users.Username).ToArray<string>();

            if (queryResult.Count<string>() > 0)
                return true;

            return false;
        }

        public static Student GetStudentDataByUser(string facNumber)
        {
            UserDataClassesDataContext dc = new UserDataClassesDataContext();
            var result = (from students in dc.GetTable<Student>()
                          where (students.FacNumber == facNumber)
                          select students).ToArray<Student>();

            if (result.Count<Student>() > 0)
                return result[0] as Student;

            return null;
        }
    }
}
