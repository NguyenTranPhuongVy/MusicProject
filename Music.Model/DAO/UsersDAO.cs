using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Music.Model.EF;

namespace Music.Model.DAO
{
    public class UsersDAO
    {
        private MusicProjectDataEntities db = new MusicProjectDataEntities();
        //Hàm thêm
        public bool Add(User user)
        {
            try
            {
                user.user_datecreate = DateTime.Now;
                user.user_datelogin = DateTime.Now;
                user.user_token = Guid.NewGuid().ToString();
                user.user_code = "#Music_Admin";

                db.Users.Add(user);
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
        //Hàm sửa
        public bool Edit(User user)
        {
            try
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Hàm xoá
        public bool Delete(int? id)
        {
            try
            {
                User user = db.Users.Find(id);
                db.Users.Remove(user);

                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Active
        public bool Active(int? id)
        {
            try
            {
                User user = db.Users.Find(id);
                user.user_active = !user.user_active;
                
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Option
        public bool Option(int? id)
        {
            try
            {
                User user = db.Users.Find(id);
                user.user_option = !user.user_option;

                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Thùng rác
        public bool Del(int? id)
        {
            try
            {
                User user = db.Users.Find(id);
                user.user_bin = true;

                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Khôi Phục
        public bool Restore(int? id)
        {
            try
            {
                User user = db.Users.Find(id);
                user.user_bin = false;

                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
