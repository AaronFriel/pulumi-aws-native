// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AutoScaling.Outputs
{

    [OutputType]
    public sealed class AutoScalingGroupVCpuCountRequest
    {
        public readonly int? Max;
        public readonly int? Min;

        [OutputConstructor]
        private AutoScalingGroupVCpuCountRequest(
            int? max,

            int? min)
        {
            Max = max;
            Min = min;
        }
    }
}
