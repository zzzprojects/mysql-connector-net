using System;
using System.Linq.Expressions;
using System.Reflection;

namespace MySql.Data.MySqlClient
{
    internal static class ConnectionExtensions
    {
        /// <summary>The get settings delegate.</summary>
        private static readonly Lazy<Func<MySqlConnection, MySqlConnectionStringBuilder>> _getSettingsDelegate = new Lazy<Func<MySqlConnection, MySqlConnectionStringBuilder>>(() =>
        {
            // parameter
            var parameter1 = Expression.Parameter(typeof(MySqlConnection));
            
            // expression
            var settingsProperty = typeof(MySqlConnection).GetProperty("Settings", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            var expression = Expression.Property(parameter1, settingsProperty);

            // compile
            var compiled = Expression.Lambda<Func<MySqlConnection, MySqlConnectionStringBuilder>>(expression, parameter1).Compile();
            return compiled;
        });

        /// <summary>A MySqlConnection extension method that gets the settings.</summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The settings.</returns>
        internal static MySqlConnectionStringBuilder GetSettings(this MySqlConnection @this)
        {
            return _getSettingsDelegate.Value(@this);
        }
    }
}
