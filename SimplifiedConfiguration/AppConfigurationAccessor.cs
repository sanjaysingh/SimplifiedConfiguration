using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Linq.Expressions;

namespace SimplifiedConfiguration
{
    /// <summary>
    /// This class is responsible for providing access to application configuration.
    /// </summary>
    public class AppConfigurationAccessor
    {
        #region Fields and Constants

        private IAppConfigurationProvider configurationProvider;
        private const string DefaultStringValue = "";

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AppConfigurationAccessor"/> class.
        /// </summary>
        public AppConfigurationAccessor()
            : this(new DefaultAppConfigurationProvider())
        {

        }


        /// <summary>
        /// Initializes a new instance of the <see cref="AppConfigurationAccessor"/> class.
        /// </summary>
        /// <param name="configurationProvider">The configuration provider.</param>
        public AppConfigurationAccessor(IAppConfigurationProvider configurationProvider)
        {
            this.configurationProvider = configurationProvider;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the value as int32.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns></returns>
        public int GetValueAsInt32(string key, int defaultValue = default(int))
        {
            string stringValue = this.configurationProvider.GetValue(key);
            int value;
            if (!int.TryParse(stringValue, out value))
            {
                value = defaultValue;
            }
            return value;
            
        }


        /// <summary>
        /// Gets the value as int32.
        /// </summary>
        /// <param name="propertyExpression">The property expression.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns></returns>
        public int GetValueAsInt32(Expression<Func<int>> propertyExpression , int defaultValue = default(int))
        {
            return GetValueAsInt32(GetPropertyNameFromExpression(propertyExpression), defaultValue);
        }

        /// <summary>
        /// Gets the value as boolean.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="defaultValue">if set to <c>true</c> [default value].</param>
        /// <returns></returns>
        public bool GetValueAsBoolean(string key, bool defaultValue = default(bool))
        {
            string stringValue = this.configurationProvider.GetValue(key);
            bool value;
            if (!bool.TryParse(stringValue, out value))
            {
                value = defaultValue;
            }
            return value;

        }

        /// <summary>
        /// Gets the value as boolean.
        /// </summary>
        /// <param name="propertyExpression">The property expression.</param>
        /// <param name="defaultValue">if set to <c>true</c> [default value].</param>
        /// <returns></returns>
        public bool GetValueAsBoolean(Expression<Func<bool>> propertyExpression, bool defaultValue = default(bool))
        {
            return GetValueAsBoolean(GetPropertyNameFromExpression(propertyExpression), defaultValue);
        }

        /// <summary>
        /// Gets the value as date time.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns></returns>
        public DateTime GetValueAsDateTime(string key, DateTime defaultValue = default(DateTime))
        {
            string stringValue = this.configurationProvider.GetValue(key);
            DateTime value;
            if (!DateTime.TryParse(stringValue, out value))
            {
                value = defaultValue;
            }
            return value;

        }

        /// <summary>
        /// Gets the value as date time.
        /// </summary>
        /// <param name="propertyExpression">The property expression.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns></returns>
        public DateTime GetValueAsDateTime(Expression<Func<DateTime>> propertyExpression, DateTime defaultValue = default(DateTime))
        {
            return GetValueAsDateTime(GetPropertyNameFromExpression(propertyExpression), defaultValue);
        }

        /// <summary>
        /// Gets the value as int16.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns></returns>
        public short GetValueAsInt16(string key, short defaultValue = default(short))
        {
            string stringValue = this.configurationProvider.GetValue(key);
            short value;
            if (!short.TryParse(stringValue, out value))
            {
                value = defaultValue;
            }
            return value;

        }

        /// <summary>
        /// Gets the value as int16.
        /// </summary>
        /// <param name="propertyExpression">The property expression.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns></returns>
        public short GetValueAsInt16(Expression<Func<short>> propertyExpression, short defaultValue = default(short))
        {
            return GetValueAsInt16(GetPropertyNameFromExpression(propertyExpression), defaultValue);
        }

        /// <summary>
        /// Gets the value as int64.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns></returns>
        public long GetValueAsInt64(string key, long defaultValue = default(long))
        {
            string stringValue = this.configurationProvider.GetValue(key);
            long value;
            if (!long.TryParse(stringValue, out value))
            {
                value = defaultValue;
            }
            return value;

        }

        /// <summary>
        /// Gets the value as int64.
        /// </summary>
        /// <param name="propertyExpression">The property expression.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns></returns>
        public long GetValueAsInt64(Expression<Func<long>> propertyExpression, long defaultValue = default(long))
        {
            return GetValueAsInt64(GetPropertyNameFromExpression(propertyExpression), defaultValue);
        }

        /// <summary>
        /// Gets the value as double.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns></returns>
        public double GetValueAsDouble(string key, double defaultValue = default(double))
        {
            string stringValue = this.configurationProvider.GetValue(key);
            double value;
            if (!double.TryParse(stringValue, out value))
            {
                value = defaultValue;
            }
            return value;

        }

        /// <summary>
        /// Gets the value as double.
        /// </summary>
        /// <param name="propertyExpression">The property expression.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns></returns>
        public double GetValueAsDouble(Expression<Func<double>> propertyExpression, double defaultValue = default(double))
        {
            return GetValueAsDouble(GetPropertyNameFromExpression(propertyExpression), defaultValue);
        }

        /// <summary>
        /// Gets the value as string.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns></returns>
        public string GetValueAsString(string key, string defaultValue = DefaultStringValue)
        {
            string stringValue = this.configurationProvider.GetValue(key);
            string value = stringValue;
            if (string.IsNullOrEmpty(stringValue))
            {
                value = defaultValue;
            }
            return value;

        }

        /// <summary>
        /// Gets the value as string.
        /// </summary>
        /// <param name="propertyExpression">The property expression.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns></returns>
        public string GetValueAsString(Expression<Func<string>> propertyExpression, string defaultValue = DefaultStringValue)
        {
            return GetValueAsString(GetPropertyNameFromExpression(propertyExpression), defaultValue);
        }

        #endregion

        #region Private Methods

        private string GetPropertyNameFromExpression<T>(Expression<Func<T>> expression)
        {
            return ((MemberExpression)expression.Body).Member.Name;
        }

        #endregion
    }
}
