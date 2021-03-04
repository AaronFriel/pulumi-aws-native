// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Glue.Outputs
{

    [OutputType]
    public sealed class TriggerCondition
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-trigger-condition.html#cfn-glue-trigger-condition-crawlstate
        /// </summary>
        public readonly string? CrawlState;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-trigger-condition.html#cfn-glue-trigger-condition-crawlername
        /// </summary>
        public readonly string? CrawlerName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-trigger-condition.html#cfn-glue-trigger-condition-jobname
        /// </summary>
        public readonly string? JobName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-trigger-condition.html#cfn-glue-trigger-condition-logicaloperator
        /// </summary>
        public readonly string? LogicalOperator;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-trigger-condition.html#cfn-glue-trigger-condition-state
        /// </summary>
        public readonly string? State;

        [OutputConstructor]
        private TriggerCondition(
            string? CrawlState,

            string? CrawlerName,

            string? JobName,

            string? LogicalOperator,

            string? State)
        {
            this.CrawlState = CrawlState;
            this.CrawlerName = CrawlerName;
            this.JobName = JobName;
            this.LogicalOperator = LogicalOperator;
            this.State = State;
        }
    }
}
