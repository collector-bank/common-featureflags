// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FeatureFlag.cs" company="Collector AB">
//   Copyright © Collector AB. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Collector.Common.FeatureFlags
{
    public abstract class FeatureFlag<T>
    {
        public abstract string Keyname { get; }
    }
}