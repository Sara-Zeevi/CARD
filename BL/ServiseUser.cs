
using DAL.DB;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
  public static class ServiseUser
    {
        /// <summary>
        /// add new user
        /// </summary>
        /// <param name="user"></param>
        public static void AddNewUser(User user) {
            var UserIfExsist = DB.Entity.User.FirstOrDefault(n => (n.TZ == user.TZ));
            if (UserIfExsist == null)
            {
                DB.Entity.User.Add(user);
                DB.Entity.SaveChanges();
            }                  
        }
       /// <summary>
       /// remove user
       /// </summary>
       /// <param name="user"></param>
        public static void RemoveUser(int id)
        {
            var UserIfExsist = SearchUser(id);
            if (UserIfExsist != null)
            {
                DB.Entity.User.Remove(UserIfExsist);
                DB.Entity.SaveChanges();
            }
        }
        /// <summary>
        /// search user by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static User SearchUser(int id)
        {
            return DB.Entity.User.Find(id);
            
        }
        /// <summary>
        /// update user
        /// </summary>
        /// <param name="user"></param>
        public static void UpdateUser(User user)
        {
            var UserIfExsist = SearchUser(user.Id);
            if (UserIfExsist != null)
            {
                UserIfExsist.Email = user.Email;
                UserIfExsist.Name = user.Name;
                UserIfExsist.Phone = user.Phone;
                UserIfExsist.DateOfBirth = user.DateOfBirth;
                DB.Entity.SaveChanges();
            }
        }
        /// <summary>
        /// return all user
        /// </summary>
        /// <returns></returns>
        public static List<User> GetAllUser()
        {
            List<User> MyAllUser = new List<User>();
            foreach (User u in DB.Entity.User)
                MyAllUser.Add(u);
            return MyAllUser;
        }
    }
}
