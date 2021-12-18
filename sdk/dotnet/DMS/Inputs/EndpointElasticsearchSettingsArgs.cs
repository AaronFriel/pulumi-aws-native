// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DMS.Inputs
{

    public sealed class EndpointElasticsearchSettingsArgs : Pulumi.ResourceArgs
    {
        [Input("endpointUri")]
        public Input<string>? EndpointUri { get; set; }

        [Input("errorRetryDuration")]
        public Input<int>? ErrorRetryDuration { get; set; }

        [Input("fullLoadErrorPercentage")]
        public Input<int>? FullLoadErrorPercentage { get; set; }

        [Input("serviceAccessRoleArn")]
        public Input<string>? ServiceAccessRoleArn { get; set; }

        public EndpointElasticsearchSettingsArgs()
        {
        }
    }
}
