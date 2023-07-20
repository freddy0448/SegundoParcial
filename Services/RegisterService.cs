
using SQLite;

namespace SegundoParcial.Services
{
    internal static class RegisterService
    {
        static SQLiteAsyncConnection db;
        static async Task Init()
        {
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "MyData.db");

            db = new SQLiteAsyncConnection(databasePath);
            db.CreateTableAsync<Register>();
        }

        public static async Task AgregarRegistro(string title, string description)
        {
            await Init();
            var register = new Register()
            {
                Title = title,
                Description = description
            };

            await db.InsertAsync(register);
        }

        public static async Task GetRegistro()
        {
            await Init();

            var register = await db.Table<Register>().ToListAsync();
            return register;
        }
    }
}
