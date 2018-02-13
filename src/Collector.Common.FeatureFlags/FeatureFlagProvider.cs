// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FeatureFlagProvider.cs" company="Collector AB">
//   Copyright © Collector AB. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Collector.Common.FeatureFlags
{
    public static class FeatureFlagProvider
    {
        public static IFeatureFlagProvider Instance { get; set; }
    }
}