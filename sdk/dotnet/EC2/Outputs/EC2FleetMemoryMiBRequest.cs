// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.EC2.Outputs
{

    [OutputType]
    public sealed class EC2FleetMemoryMiBRequest
    {
        public readonly int? Max;
        public readonly int? Min;

        [OutputConstructor]
        private EC2FleetMemoryMiBRequest(
            int? max,

            int? min)
        {
            Max = max;
            Min = min;
        }
    }
}