using System;
using System.Reflection;
using MySql.Data.MySqlClient;

namespace MySql.Data.MySqlClient
{
    internal static class ConnectionExtensions
    {
        internal static MySqlConnectionStringBuilder GetSettings(this MySqlConnection @this)
        {
            var property = @this.GetType().GetProperty("Settings", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            return (MySqlConnectionStringBuilder)property.GetValue(@this, null);
            return null;
        }
    }
}
