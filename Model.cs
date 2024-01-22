using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Events_MVP_hw
{
    internal class User
    {
        static private int usersNumber = 0;
        static private List<User> usersBase = new List<User>();
        public int UserId { get; }
        public string UserName { get; set; }
        public User(string name)
        {
            this.UserId = usersNumber++;
            this.UserName = name;
            usersBase.Add(this);
        }

        public string SendMessege(string messege, int recipientUserId)
        {
            User recipientUser;
            for (int i = 0; i < User.usersBase.Count; i++)
            {
                if (usersBase[i].UserId == recipientUserId)
                {
                    recipientUser = usersBase[i];
                    return $"user: {UserName} \nsent messege: {messege} \nto user: {recipientUser.UserName}";
                }
            }
            return "ther is no user with such id";
        }
    }
}
