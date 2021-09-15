// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DynamoDB.Outputs
{

    [OutputType]
    public sealed class GlobalTableReadProvisionedThroughputSettings
    {
        public readonly Outputs.GlobalTableCapacityAutoScalingSettings? ReadCapacityAutoScalingSettings;
        public readonly int? ReadCapacityUnits;

        [OutputConstructor]
        private GlobalTableReadProvisionedThroughputSettings(
            Outputs.GlobalTableCapacityAutoScalingSettings? readCapacityAutoScalingSettings,

            int? readCapacityUnits)
        {
            ReadCapacityAutoScalingSettings = readCapacityAutoScalingSettings;
            ReadCapacityUnits = readCapacityUnits;
        }
    }
}
