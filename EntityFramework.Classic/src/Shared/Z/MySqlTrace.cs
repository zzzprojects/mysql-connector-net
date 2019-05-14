using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace MySql.Data.MySqlClient
{
    /// <summary>my SQL trace custom.</summary>
    public class MySqlTraceCustom
    {
        /// <summary>my SQL exception delegate.</summary>
        private static readonly Lazy<Action<int, string>> _mySqlExceptionDelegate = new Lazy<Action<int, string>>(() =>
        {
            // parameter
            var parameter1 = Expression.Parameter(typeof(int));
            var parameter2 = Expression.Parameter(typeof(string));

            // expression
            var type = typeof(MySqlTrace);
            var logInformationMethod = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static).Single(x => x.Name == "LogInformation" && x.GetParameters().Length == 2 && x.GetParameters()[0].ParameterType == typeof(int) && x.GetParameters()[1].ParameterType == typeof(string));
            var expression = Expression.Call(logInformationMethod, parameter1, parameter2);

            // compile
            var compiled = Expression.Lambda<Action<int, string>>(expression, parameter1).Compile();
            return compiled;
        });

        /// <summary>Logs an information.</summary>
        /// <param name="id">The identifier.</param>
        /// <param name="msg">The message.</param>
        internal static void LogInformation(int id, string msg)
        {
            _mySqlExceptionDelegate.Value(id, msg);
        }
    }
}
