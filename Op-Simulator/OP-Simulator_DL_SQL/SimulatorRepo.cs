using System.Data;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;
using OP_Simulator_BL.Model;
using Microsoft.Data.SqlClient;

namespace OP_Simulator_DL_SQL
{
    public class SimulatorRepo
    {
        public SimulatorRepo(string connectieString)
        {
            _connectieString = connectieString;
        }

        private string _connectieString;

        public void UploadKlantenDB(List<Klant> klanten)
        {
            string query = "INSERT INTO Klant (voornaam, familienaam, email, geboortedatum, postcode, gemeente, straat, huisnr) VALUES (@voornaam, @familienaam, @email, @geboortedatum, @postcode, @gemeente, @straat, @huisnr)";

            using (SqlConnection connection = new SqlConnection(_connectieString))
            using (SqlCommand cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@voornaam", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("@familienaam", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("@email", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("@geboortedatum", SqlDbType.Date));
                cmd.Parameters.Add(new SqlParameter("@postcode", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("@gemeente", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("@straat", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("@huisnr", SqlDbType.NVarChar));



                try
                {
                    foreach (Klant klant in klanten)
                    {
                        cmd.Parameters["voornaam"].Value = klant.Voornaam;
                        cmd.Parameters["familienaam"].Value = klant.Voornaam;
                        cmd.Parameters["email"].Value = klant.Voornaam;
                        cmd.Parameters["geboortedatum"].Value = klant.Voornaam;
                        cmd.Parameters["postcode"].Value = klant.Voornaam;
                        cmd.Parameters["gemeente"].Value = klant.Voornaam;
                        cmd.Parameters["provincieNaam"].Value = klant.Voornaam;
                        cmd.Parameters["provincieNaam"].Value = klant.Voornaam;

                        cmd.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }
    }
}
