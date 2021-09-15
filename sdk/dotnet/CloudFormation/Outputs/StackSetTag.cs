// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CloudFormation.Outputs
{

    /// <summary>
    /// Tag type enables you to specify a key-value pair that can be used to store information about an AWS CloudFormation StackSet.
    /// </summary>
    [OutputType]
    public sealed class StackSetTag
    {
        /// <summary>
        /// A string used to identify this tag. You can specify a maximum of 127 characters for a tag key.
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// A string containing the value for this tag. You can specify a maximum of 256 characters for a tag value.
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private StackSetTag(
            string key,

            string value)
        {
            Key = key;
            Value = value;
        }
    }
}
