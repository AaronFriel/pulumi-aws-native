// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DLM.Outputs
{

    [OutputType]
    public sealed class LifecyclePolicyRetainRule
    {
        public readonly int? Count;
        public readonly int? Interval;
        public readonly string? IntervalUnit;

        [OutputConstructor]
        private LifecyclePolicyRetainRule(
            int? count,

            int? interval,

            string? intervalUnit)
        {
            Count = count;
            Interval = interval;
            IntervalUnit = intervalUnit;
        }
    }
}
