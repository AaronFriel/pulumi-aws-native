// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.EC2.Inputs
{

    public sealed class SpotFleetPrivateIpAddressSpecificationArgs : Pulumi.ResourceArgs
    {
        [Input("primary")]
        public Input<bool>? Primary { get; set; }

        [Input("privateIpAddress", required: true)]
        public Input<string> PrivateIpAddress { get; set; } = null!;

        public SpotFleetPrivateIpAddressSpecificationArgs()
        {
        }
    }
}
