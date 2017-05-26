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
        private const string CANNOT_BE_NULL_OR_EMPTY = "Cannot be null or empty.";

        public User(string teamKeyPart, string userKeyPart)
        {
            if (string.IsNullOrWhiteSpace(teamKeyPart))
                throw new ArgumentException(CANNOT_BE_NULL_OR_EMPTY, nameof(teamKeyPart));

            if (string.IsNullOrWhiteSpace(userKeyPart))
                throw new ArgumentException(CANNOT_BE_NULL_OR_EMPTY, nameof(userKeyPart));

            Key = $"{teamKeyPart}-{userKeyPart}";
            CustomAttributes = new Dictionary<string, object>();
        }

        public string Key { get; }

        public string Email { get; set; }

        public string CountryCode { get; set; }

        public IDictionary<string, object> CustomAttributes { get; }

        public User With(string customAttributeName, object customAttributeValue)
        {
            CustomAttributes[customAttributeName] = customAttributeValue;

            return this;
        }
    }
}
