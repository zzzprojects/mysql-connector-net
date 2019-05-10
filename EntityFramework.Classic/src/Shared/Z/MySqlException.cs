using System;
using MySql.Data.MySqlClient;

namespace MySql.Data.MySqlClient
{
    internal class MySqlExceptionCustom
    {
        internal static Exception Throw(string message)
        {
            return new Exception(message);
        }
    }
}
