using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Data.SqlClient;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial
{
    public partial class Register
    {
        public Register()
        {
            Date = DateTime.Now.Date;

            registers = new ObservableCollection<Register>
            {
                new Register
                {
                    Title = 
                    Description = "test"
                }
            };
        }

        [PrimaryKey]
        public string Title { get; set; }

        public string Description { get; set; }
        public DateTime Date { get; set; }

        internal const string server = "LAPTOP-6SLH18HM";
        internal const string dataBase = "SegundoParcial";
        internal const string userName = "freddy_048";
        internal const string passWord = "freddy04122002";
        internal const string table = "Emergency";

        internal SqlConnection sqlConnection = new SqlConnection(connectionString);

        const string connectionString = $"Server = {server}; Database = {dataBase}; UID = {userName} ; PWD = {passWord}";

        internal List<List<string>> list = new List<List<string>>();

        public ObservableCollection<Register> registers {  get; set; }

        
    }
}
