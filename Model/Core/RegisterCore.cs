using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.Model.Core
{
    internal class RegisterCore
    {

        internal const string server = "LAPTOP-6SLH18HM";
        internal const string dataBase = "SegundoParcial";
        internal const string userName = "freddy_048";
        internal const string passWord = "freddy04122002";
        internal const string table = "Emergency";

        internal SqlConnection  sqlConnection = new SqlConnection(connectionString);

        const string connectionString = $"Server = {server}; Database = {dataBase}; UID = {userName} ; PWD = {passWord}";

        internal List<List<string>> list = new List<List<string>>();
    }
}
