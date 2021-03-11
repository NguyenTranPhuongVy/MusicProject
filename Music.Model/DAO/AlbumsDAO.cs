using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Music.Model.EF;

namespace Music.Model.DAO
{
    public class AlbumsDAO
    {
        private MusicProjectDataEntities db = new MusicProjectDataEntities();
        //Hàm thêm
        public bool Add(Album album)
        {
            try
            {
                db.Albums.Add(album);
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
        //Hàm sửa
        public bool Edit(Album album)
        {
            try
            {
                db.Entry(album).State = EntityState.Modified;
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Hàm xoá
        public bool Delete(int ? id)
        {
            try
            {
                Album album = db.Albums.Find(id);
                db.Albums.Remove(album);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Active
        public bool Active(int ? id)
        {
            try
            {
                Album album = db.Albums.Find(id);
                album.album_active =! album.album_active;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Del
        public bool Del(int ? id)
        {
            try
            {
                Album album = db.Albums.Find(id);
                album.album_bin = true;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
