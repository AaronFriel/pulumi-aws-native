// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DynamoDB.Inputs
{

    public sealed class GlobalTableWriteProvisionedThroughputSettingsArgs : Pulumi.ResourceArgs
    {
        [Input("writeCapacityAutoScalingSettings")]
        public Input<Inputs.GlobalTableCapacityAutoScalingSettingsArgs>? WriteCapacityAutoScalingSettings { get; set; }

        public GlobalTableWriteProvisionedThroughputSettingsArgs()
        {
        }
    }
}
