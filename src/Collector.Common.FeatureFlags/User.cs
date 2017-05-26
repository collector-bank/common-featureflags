// --------------------------------------------------------------------------------------------------------------------
// <copyright file="User.cs" company="Collector AB">
//   Copyright © Collector AB. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Collector.Common.FeatureFlags
{
    using System;
    using System.Collections.Generic;

    public class User
    {
        public User(string key)
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key), "Key is required.");

            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentException("Key cannot be empty.", nameof(key));

            Key = key;
            CustomAttributes = new Dictionary<string, object>();
        }

        public string Key { get; }

        public string Email { get; set; }

        public string CountryCode { get; set; }

        public string TeamName { get; set; }

        public IDictionary<string, object> CustomAttributes { get; }

        public User With(string customAttributeName, object customAttributeValue)
        {
            this.CustomAttributes[customAttributeName] = customAttributeValue;

            return this;
        }
    }
}
