// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Synthetics.Outputs
{

    [OutputType]
    public sealed class CanarySchedule
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-schedule.html#cfn-synthetics-canary-schedule-durationinseconds
        /// </summary>
        public readonly string? DurationInSeconds;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-synthetics-canary-schedule.html#cfn-synthetics-canary-schedule-expression
        /// </summary>
        public readonly string Expression;

        [OutputConstructor]
        private CanarySchedule(
            string? DurationInSeconds,

            string Expression)
        {
            this.DurationInSeconds = DurationInSeconds;
            this.Expression = Expression;
        }
    }
}
