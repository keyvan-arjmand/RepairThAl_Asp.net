using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DAL.Services
{
    public class User_Services
    {

        public void Insert(User user)
        {
            DB db = new DB();
            if(db.users.Where(x=>x.Email== user.Email && x.PhoneNumber == user.PhoneNumber).Any())
            {
                throw new Exception("کاربر با این مشخصات وجود دارد");
            }
            user.JoinDate = Helpers.TimeUtility.ToJalali(DateTime.Now);
            db.users.Add(user);
            db.SaveChanges();
        }
        public void Update(User user)
        {
            DB db = new DB();
            
            db.users.Update(user);
            db.SaveChanges();
        }
        public void Delete(User user)
        {
            DB db = new DB();
            var OrderUser = db.user_Orders.Where(x => x.User_ID == user.User__ID).ToList();
            db.users.Remove(user);

            foreach (var i in OrderUser)
            {
                db.user_Orders.Remove(i);
            }
            db.SaveChanges();
        }
        public List<User> GetUsers()
        {
            DB db = new DB();
            return db.users.ToList();
        }
        public User Get(int id)
        {
            DB db = new DB();
            return db.users.Find(id);
        }
        public User GetByEmail(string Email)
        {
            DB db = new DB();
            return db.users.Where(x => x.Email == Email).SingleOrDefault();
        }
        public int GetCount()
        {
            DB db = new DB();
            return db.users.Count();
        }
        public List<User> AdminList()
        {
            DB dB = new DB();
            return dB.users.Where(x => x.IsAdmin).ToList();
        }
        public User GetAdmin(int id)
        {
            DB db = new DB();
            return db.users.Where(x => x.User__ID == id && x.IsAdmin).FirstOrDefault();
        }

    }
}
