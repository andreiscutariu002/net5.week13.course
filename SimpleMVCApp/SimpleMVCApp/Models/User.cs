namespace SimpleMVCApp.Models
{
    using System.Collections.Generic;

    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
    }

    public class UserData
    {
        private static readonly List<User> Users = new List<User>();

        static UserData()
        {
            Users.Add(new User { Id = 1, Email = "and@yahoo.com", Name = "and" });
            Users.Add(new User { Id = 2, Email = "mih@yahoo.com", Name = "mih" });
        }

        public UserData()
        {
        }

        public List<User> GetUsers()
        {
            return Users;
        }

        public User GetUser(int id)
        {
            return Users.Find(x => x.Id == id);
        }
    }
}
