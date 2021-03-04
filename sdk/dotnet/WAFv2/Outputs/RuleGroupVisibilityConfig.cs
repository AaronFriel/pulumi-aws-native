// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.WAFv2.Outputs
{

    [OutputType]
    public sealed class RuleGroupVisibilityConfig
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-visibilityconfig.html#cfn-wafv2-rulegroup-visibilityconfig-cloudwatchmetricsenabled
        /// </summary>
        public readonly bool CloudWatchMetricsEnabled;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-visibilityconfig.html#cfn-wafv2-rulegroup-visibilityconfig-metricname
        /// </summary>
        public readonly string MetricName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafv2-rulegroup-visibilityconfig.html#cfn-wafv2-rulegroup-visibilityconfig-sampledrequestsenabled
        /// </summary>
        public readonly bool SampledRequestsEnabled;

        [OutputConstructor]
        private RuleGroupVisibilityConfig(
            bool CloudWatchMetricsEnabled,

            string MetricName,

            bool SampledRequestsEnabled)
        {
            this.CloudWatchMetricsEnabled = CloudWatchMetricsEnabled;
            this.MetricName = MetricName;
            this.SampledRequestsEnabled = SampledRequestsEnabled;
        }
    }
}
