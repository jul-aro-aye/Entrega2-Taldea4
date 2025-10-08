using System.Collections.Generic;
using MySql.Data.MySqlClient;
using WindowsFormsApp1.DB;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.DA
{
    public class LangileaDAO
    {
        public List<Langilea> GetLangileak(bool ezabatuta = false)
        {
            List<Langilea> lista = new List<Langilea>();
            using (var kon = DBKonexioa.GetKonexioa())
            {
                kon.Open();
                string sql = "SELECT * FROM langileak WHERE Ezabatuta=@e";
                var cmd = new MySqlCommand(sql, kon);
                cmd.Parameters.AddWithValue("@e", ezabatuta);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Langilea
                    {
                        Id = reader.GetInt32("Id"),
                        Izena = reader.GetString("Izena"),
                        Arduraduna = reader.GetBoolean("Arduraduna"),
                        Ezabatua = reader.GetBoolean("Ezabatuta")
                    });
                }
            }
            return lista;
        }

        public void Gehitu(Langilea l)
        {
            using (var kon = DBKonexioa.GetKonexioa())
            {
                kon.Open();
                string sql = "INSERT INTO langileak (Izena, Arduraduna, Ezabatuta) VALUES (@i,@a,0)";
                var cmd = new MySqlCommand(sql, kon);
                cmd.Parameters.AddWithValue("@i", l.Izena);
                cmd.Parameters.AddWithValue("@a", l.Arduraduna);
                cmd.ExecuteNonQuery();
            }
        }

        public void EzabatuSoft(int id)
        {
            using (var kon = DBKonexioa.GetKonexioa())
            {
                kon.Open();
                string sql = "UPDATE langileak SET Ezabatuta=1 WHERE Id=@id";
                var cmd = new MySqlCommand(sql, kon);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public void EzabatuHard(int id)
        {
            using (var kon = DBKonexioa.GetKonexioa())
            {
                kon.Open();
                string sql = "DELETE FROM langileak WHERE Id=@id";
                var cmd = new MySqlCommand(sql, kon);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
