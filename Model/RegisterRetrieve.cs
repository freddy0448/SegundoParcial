using AndroidX.Emoji2.Text.FlatBuffer;
using Java.Util;
using Microsoft.Data.SqlClient;
using SegundoParcial.Model.Core;
using static Android.Icu.Text.CaseMap;
using static Android.Util.EventLogTags;

namespace SegundoParcial.Model
{
    internal class RegisterRetrieve :RegisterCore
    {
        private void RetrieveData()
        {
            try
            {
                sqlConnection.Open();
                var query = new SqlCommand($"SELECT * FROM {table}");
                var reader = query.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new List<string> { reader["Id"].ToString(), reader[nameof(Title)].ToString(),
                        reader[nameof(Description)].ToString(), reader[nameof(Date)].ToString() });
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally { sqlConnection.Close(); }
        }

    }
}
