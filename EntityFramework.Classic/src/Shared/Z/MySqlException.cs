using System;
using System.Linq;
using System.Linq.Expressions;

namespace MySql.Data.MySqlClient
{
    /// <summary>my SQL exception custom.</summary>
    internal class MySqlExceptionCustom
    {
        /// <summary>my SQL exception delegate.</summary>
        private static readonly Lazy<Func<string, MySqlException>> _mySqlExceptionDelegate = new Lazy<Func<string, MySqlException>>(() =>
        {
            // parameter
            var parameter1 = Expression.Parameter(typeof(string));

            // expression
            var type = typeof(MySqlException);
            var constructor = type.GetConstructors().ToList().Single(x => x.GetParameters().Length == 1 && x.GetParameters()[0].ParameterType == typeof(string));
            var expression = Expression.New(constructor, parameter1);

            // compile
            var compiled = Expression.Lambda<Func<string, MySqlException>>(expression, parameter1).Compile();
            return compiled;
        });

        /// <summary>Throws.</summary>
        /// <param name="message">The message.</param>
        /// <returns>A MySqlException.</returns>
        internal static MySqlException Throw(string message)
        {
            return _mySqlExceptionDelegate.Value(message);
        }
    }
}
