using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimplifiedConfiguration;

namespace SimplifiedConfigurationApp
{
    public static class AppSettings
    {
        private static AppConfigurationAccessor appConfiguration = new AppConfigurationAccessor();

        public static readonly int IntValue = appConfiguration.GetValueAsInt32(()=>IntValue);

        public static readonly short ShortValue = appConfiguration.GetValueAsInt16(()=>ShortValue);

        public static readonly bool BoolValue = appConfiguration.GetValueAsBoolean(()=>BoolValue);

        public static readonly long LongValue = appConfiguration.GetValueAsInt64(()=>LongValue);

        public static readonly double DoubleValue = appConfiguration.GetValueAsDouble(()=>DoubleValue);

        public static readonly DateTime DatetimeValue = appConfiguration.GetValueAsDateTime(()=>DatetimeValue);

        public static readonly string StringValue = appConfiguration.GetValueAsString(() => StringValue);
    }
}
