
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static DictionaryPractice3.CollectionClass;

namespace DictionaryPractice3
{
    public class CollectionClass
    {
        User _user1;
        User _user2;
        User _user3;

        public CollectionClass()
        {
            _user1 = new User()
            {
                UserId = 1,
                FirstName = "William",
                LastName = "Smith",
            };

            _user2 = new User()
            {
                UserId = 2,
                FirstName = "Noah",
                LastName = "Brown",
            };
            _user3 = new User()
            {
                UserId = 3,
                FirstName = "Lucas",
                LastName = "Anderson",
            };
        }
        /***************/
        /***************/
        //List function
        public void ListFunction()
        {
            List<User> users = new List<User>();

            users.Add(_user1);
            users.Add(_user2);
            users.Add(_user3);


            //SEARCH
            //var user = users.FirstOrDefault(u => u.UserId == 2);
            //Console.WriteLine($"User: {user.UserId} {user.FirstName} {user.LastName}");


            var matchUsers = users.Where(u => u.FirstName.Contains("oa")).ToList();
            foreach (var user in matchUsers)
            {
                Console.WriteLine($"User: {user.UserId} {user.FirstName} {user.LastName}");
            }


            //var matchUsers= users.Where(u=> u.FirstName.ToLower() == "lucas").ToList();
            //foreach (var user in matchUsers) 
            //{
            //    Console.WriteLine($"User: {user.UserId} {user.FirstName} {user.LastName}");
            //}

            //ALL LIST OF USERS
            //foreach (var user in users)
            //{
            //    Console.WriteLine($"User: {user.UserId} {user.FirstName} {user.LastName}");
            //}
        }




        /***************/
        /***************/
        //Dictionary function
        public void DictionaryFunction()
        {
            var users = new Dictionary<int, User>();

            users.Add(_user1.UserId, _user1);
            users.Add(_user2.UserId, _user2);
            users.Add(_user3.UserId, _user3);

            User user = null;
            bool isMatchFound = users.TryGetValue(2, out user);

            if (isMatchFound)
            {
                Console.WriteLine($"User: {user.UserId} {user.FirstName} {user.LastName}");
            }

            //foreach (var user in users) 
            //{
            //    Console.WriteLine($"User: {user.Key} {user.Value.FirstName} {user.Value.LastName}");
            //}
        }
        /***************/
        /***************/
        //Array Function
        public void ArrayFunction()
        {
            User[] users = new User[3];
            users[0] = _user1;
            users[1] = _user2;
            users[2] = _user3;

            for (int i = 0; i < users.Length; i++)
            {
                var user = users[i];
                Console.WriteLine($"User: {user.UserId} {user.FirstName} {user.LastName}");
            }
        }


        public class User
        {
            public int UserId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}
