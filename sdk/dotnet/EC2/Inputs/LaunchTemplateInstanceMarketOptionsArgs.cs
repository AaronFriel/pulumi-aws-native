// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.EC2.Inputs
{

    public sealed class LaunchTemplateInstanceMarketOptionsArgs : Pulumi.ResourceArgs
    {
        [Input("marketType")]
        public Input<string>? MarketType { get; set; }

        [Input("spotOptions")]
        public Input<Inputs.LaunchTemplateSpotOptionsArgs>? SpotOptions { get; set; }

        public LaunchTemplateInstanceMarketOptionsArgs()
        {
        }
    }
}
