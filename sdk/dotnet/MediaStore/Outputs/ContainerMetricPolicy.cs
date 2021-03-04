// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.MediaStore.Outputs
{

    [OutputType]
    public sealed class ContainerMetricPolicy
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediastore-container-metricpolicy.html#cfn-mediastore-container-metricpolicy-containerlevelmetrics
        /// </summary>
        public readonly string ContainerLevelMetrics;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediastore-container-metricpolicy.html#cfn-mediastore-container-metricpolicy-metricpolicyrules
        /// </summary>
        public readonly ImmutableArray<Outputs.ContainerMetricPolicyRule> MetricPolicyRules;

        [OutputConstructor]
        private ContainerMetricPolicy(
            string ContainerLevelMetrics,

            ImmutableArray<Outputs.ContainerMetricPolicyRule> MetricPolicyRules)
        {
            this.ContainerLevelMetrics = ContainerLevelMetrics;
            this.MetricPolicyRules = MetricPolicyRules;
        }
    }
}
