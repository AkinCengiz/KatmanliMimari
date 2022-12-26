using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data;

namespace DataAccessLayer
{
    public class PersonelDAL
    {
        public static List<PersonelEntity> PersonelList()
        {
            List<PersonelEntity> personelList = new List<PersonelEntity>();
            SqlCommand command = new SqlCommand("select * from tbl_Personel", Connection.connect);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                PersonelEntity personelEntity = new PersonelEntity();
                personelEntity.PersonelId = int.Parse(reader["PersonelId"].ToString());
                personelEntity.PersonelAd = reader["PersonelAd"].ToString();
                personelEntity.PersonelSoyad = reader["PersonelSoyad"].ToString();
                personelEntity.PersonelSehir = reader["PersonelSehir"].ToString();
                personelEntity.PersonelMaas = short.Parse(reader["PersonelMaas"].ToString());
                personelEntity.PersonelDurum = bool.Parse(reader["PersonelDurum"].ToString());
                personelEntity.PersonelMeslek = reader["PersonelMeslek"].ToString();
                personelList.Add(personelEntity);
            }
            reader.Close();
            command.Connection.Close();
            return personelList;
        }

        public static void PersonelEkle(PersonelEntity personel)
        {
            SqlCommand command = new SqlCommand(
                "insert into tbl_Personel (PersonelAd, PersonelSoyad, PersonelSehir, PersonelMaas, PersonelDurum, PersonelMeslek) values (@PersonelAd, @PersonelSoyad, @PersonelSehir, @PersonelMaas, @PersonelDurum, @PersonelMeslek)",
                Connection.connect);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            command.Parameters.AddWithValue("@PersonelAd", personel.PersonelAd);
            command.Parameters.AddWithValue("@PersonelSoyad", personel.PersonelSoyad);
            command.Parameters.AddWithValue("@PersonelSehir", personel.PersonelSehir);
            command.Parameters.AddWithValue("@PersonelMaas", personel.PersonelMaas);
            command.Parameters.AddWithValue("@PersonelDurum", personel.PersonelDurum);
            command.Parameters.AddWithValue("@PersonelMeslek", personel.PersonelMeslek);
            command.ExecuteNonQuery();
            command.Connection.Close();
        }

        public static bool PersonelSil(int id)
        {
            SqlCommand command = new SqlCommand("delete from tbl_Personel where PersonelId = @Id", Connection.connect);
            command.Parameters.AddWithValue("@Id", id);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }

            return command.ExecuteNonQuery() > 0;
        }

        public static bool PersonelGuncelle(PersonelEntity personel)
        {
            SqlCommand command =
                new SqlCommand(
                    "update tbl_Personel set PersonelAd=@Ad, PersonelSoyad=@Soyad, PersonelSehir=@Sehir, PersonelMaas=@Maas, PersonelDurum=@Durum, PersonelMeslek=@Meslek where PersonelId=@Id",
                    Connection.connect);
            command.Parameters.AddWithValue("@Ad", personel.PersonelAd);
            command.Parameters.AddWithValue("@Soyad", personel.PersonelSoyad);
            command.Parameters.AddWithValue("@Sehir", personel.PersonelSehir);
            command.Parameters.AddWithValue("@Maas", personel.PersonelMaas);
            command.Parameters.AddWithValue("@Durum", personel.PersonelDurum);
            command.Parameters.AddWithValue("@Meslek", personel.PersonelMeslek);
            command.Parameters.AddWithValue("@Id", personel.PersonelId);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }

            return command.ExecuteNonQuery() > 0;
        }
    }
}
