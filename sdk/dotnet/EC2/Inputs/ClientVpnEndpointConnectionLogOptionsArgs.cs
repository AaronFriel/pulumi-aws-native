// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.EC2.Inputs
{

    public sealed class ClientVpnEndpointConnectionLogOptionsArgs : Pulumi.ResourceArgs
    {
        [Input("cloudwatchLogGroup")]
        public Input<string>? CloudwatchLogGroup { get; set; }

        [Input("cloudwatchLogStream")]
        public Input<string>? CloudwatchLogStream { get; set; }

        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        public ClientVpnEndpointConnectionLogOptionsArgs()
        {
        }
    }
}
