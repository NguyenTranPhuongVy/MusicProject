using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Music.Model.EF;

namespace Music.Model.DAO
{
    public class NationsDAO
    {
        private MusicProjectDataEntities db = new MusicProjectDataEntities();
        //Hàm thêm
        public bool Add(National national)
        {
            try
            {
                db.Nationals.Add(national);
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
        //Hàm sửa
        public bool Edit(National national)
        {
            try
            {
                db.Entry(national).State = EntityState.Modified;
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
                National national = db.Nationals.Find(id);
                db.Nationals.Remove(national);
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
                National national = db.Nationals.Find(id);
                national.nation_active =! national.nation_active;

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
                National national = db.Nationals.Find(id);
                national.nation_option = !national.nation_option;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Del
        public bool Del(int? id)
        {
            try
            {
                National national = db.Nationals.Find(id);
                national.nation_bin = true;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
