// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.SageMaker.Outputs
{

    /// <summary>
    /// Key-value pair to associate as a tag for the resource
    /// </summary>
    [OutputType]
    public sealed class DeviceFleetTag
    {
        /// <summary>
        /// The key name of the tag. You can specify a value that is 1 to 127 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -. 
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// The key value of the tag. You can specify a value that is 1 to 127 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -. 
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private DeviceFleetTag(
            string key,

            string value)
        {
            Key = key;
            Value = value;
        }
    }
}
