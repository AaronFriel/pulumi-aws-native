// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.S3.Inputs
{

    /// <summary>
    /// The Virtual Private Cloud (VPC) configuration for a bucket access point.
    /// </summary>
    public sealed class AccessPointVpcConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// If this field is specified, this access point will only allow connections from the specified VPC ID.
        /// </summary>
        [Input("vpcId")]
        public Input<string>? VpcId { get; set; }

        public AccessPointVpcConfigurationArgs()
        {
        }
    }
}
