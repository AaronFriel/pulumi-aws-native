// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ElasticLoadBalancing.Inputs
{

    public sealed class LoadBalancerConnectionSettingsArgs : Pulumi.ResourceArgs
    {
        [Input("idleTimeout", required: true)]
        public Input<int> IdleTimeout { get; set; } = null!;

        public LoadBalancerConnectionSettingsArgs()
        {
        }
    }
}
