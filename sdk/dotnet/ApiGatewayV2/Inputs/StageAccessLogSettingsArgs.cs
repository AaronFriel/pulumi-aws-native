// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ApiGatewayV2.Inputs
{

    public sealed class StageAccessLogSettingsArgs : Pulumi.ResourceArgs
    {
        [Input("destinationArn")]
        public Input<string>? DestinationArn { get; set; }

        [Input("format")]
        public Input<string>? Format { get; set; }

        public StageAccessLogSettingsArgs()
        {
        }
    }
}
