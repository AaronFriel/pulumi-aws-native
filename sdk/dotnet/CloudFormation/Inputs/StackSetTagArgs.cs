// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CloudFormation.Inputs
{

    /// <summary>
    /// Tag type enables you to specify a key-value pair that can be used to store information about an AWS CloudFormation StackSet.
    /// </summary>
    public sealed class StackSetTagArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A string used to identify this tag. You can specify a maximum of 127 characters for a tag key.
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        /// <summary>
        /// A string containing the value for this tag. You can specify a maximum of 256 characters for a tag value.
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public StackSetTagArgs()
        {
        }
    }
}
