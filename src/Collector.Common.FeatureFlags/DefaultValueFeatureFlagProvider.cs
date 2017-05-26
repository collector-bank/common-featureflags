// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DefaultValueFeatureFlagProvider.cs" company="Collector AB">
//   Copyright © Collector AB. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Collector.Common.FeatureFlags
{
    public class DefaultValueFeatureFlagProvider : IFeatureFlagProvider
    {
        public bool IsFeatureEnabled<T>(User user, bool defaultValue = false) where T : FeatureFlag<bool>, new()
        {
            return defaultValue;
        }

        public bool IsFeatureEnabled<T>(bool defaultValue = false) where T : FeatureFlag<bool>, new()
        {
            return defaultValue;
        }

        public bool GetBoolFlag<T>(User user, bool defaultValue = false) where T : FeatureFlag<bool>, new()
        {
            return defaultValue;
        }

        public bool GetBoolFlag<T>(bool defaultValue = false) where T : FeatureFlag<bool>, new()
        {
            return defaultValue;
        }

        public int GetIntFlag<T>(User user, int defaultValue) where T : FeatureFlag<int>, new()
        {
            return defaultValue;
        }

        public int GetIntFlag<T>(int defaultValue) where T : FeatureFlag<int>, new()
        {
            return defaultValue;
        }

        public string GetStringFlag<T>(User user, string defaultValue) where T : FeatureFlag<string>, new()
        {
            return defaultValue;
        }

        public string GetStringFlag<T>(string defaultValue) where T : FeatureFlag<string>, new()
        {
            return defaultValue;
        }
    }
}