using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class PersonelLogic
    {
        public static List<PersonelEntity> LogicPersonalList()
        {
            return PersonelDAL.PersonelList();
        }

        public static void LogicPersonelEkle(PersonelEntity personel)
        {
            if (personel != null)
            {
                PersonelDAL.PersonelEkle(personel);
            }
        }

        public static bool LogicPersonelSil(int id)
        {
            if (id > 0)
            {
                return PersonelDAL.PersonelSil(id);
            }
            else
            {
                return false;
            }
        }

        public static bool LogicPersonelGuncelle(PersonelEntity personel)
        {
            if (personel != null)
            {
                return PersonelDAL.PersonelGuncelle(personel);
            }
            else
            {
                return false;
            }
        }
    }
}
