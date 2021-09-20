// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppIntegrations.Outputs
{

    [OutputType]
    public sealed class EventIntegrationTag
    {
        /// <summary>
        /// A key to identify the tag.
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// Corresponding tag value for the key.
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private EventIntegrationTag(
            string key,

            string value)
        {
            Key = key;
            Value = value;
        }
    }
}