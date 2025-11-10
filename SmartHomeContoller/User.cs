using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeContoller
{
    internal class User
    {
        private int userID;
        private string username;
        private string password;
        private string contactInfo;
        private bool isLoggedIn;

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string ContactInfo
        {
            get { return contactInfo; }
            set { contactInfo = value; }
        }

        public bool IsLoggedIn
        {
            get { return isLoggedIn; }
            set { isLoggedIn = value; }
        }

        public User(int userID, string username, string contactInfo, string password, bool isLoggedIn)
        {
            this.userID = userID;
            this.username = username;
            this.contactInfo = contactInfo;
            this.password = password;
            this.isLoggedIn = isLoggedIn;
        }

        public bool Login(string username, string password)
        {
            if(username == this.username && password == this.password)
            {
                Console.WriteLine("Login successful.");
                isLoggedIn = true;
            }
            else
            {
                Console.WriteLine("Login failed.");
                isLoggedIn = false;
            }
            return isLoggedIn;
        }

        public void Logout()
        {
            if(!isLoggedIn)
            {
                Console.WriteLine("User is not logged in.");
                return;
            }
            Console.WriteLine("User logged out.");
            isLoggedIn = false;
        }
    }

}
