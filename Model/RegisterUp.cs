
using Microsoft.Data.SqlClient;
using SegundoParcial.Model.Core;
using SegundoParcial.ViewModel;

namespace SegundoParcial.Model
{
    class RegisterUp : RegisterCore
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public string[] results;

        DateTime date = DateTime.Now.Date;

        private void LoadData(MainViewModel model, string title, string description)
        {
            try
            {
                sqlConnection.Open();
                var query = new SqlCommand($"INSERT INTO {table}(Title, Description, Date) VALUES ('{title}', '{description}', {date});");
                query.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally { sqlConnection.Close(); }

        }

    }
}
