// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Events.Outputs
{

    [OutputType]
    public sealed class RuleBatchParameters
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-batchparameters.html#cfn-events-rule-batchparameters-arrayproperties
        /// </summary>
        public readonly Outputs.RuleBatchArrayProperties? ArrayProperties;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-batchparameters.html#cfn-events-rule-batchparameters-jobdefinition
        /// </summary>
        public readonly string JobDefinition;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-batchparameters.html#cfn-events-rule-batchparameters-jobname
        /// </summary>
        public readonly string JobName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-batchparameters.html#cfn-events-rule-batchparameters-retrystrategy
        /// </summary>
        public readonly Outputs.RuleBatchRetryStrategy? RetryStrategy;

        [OutputConstructor]
        private RuleBatchParameters(
            Outputs.RuleBatchArrayProperties? ArrayProperties,

            string JobDefinition,

            string JobName,

            Outputs.RuleBatchRetryStrategy? RetryStrategy)
        {
            this.ArrayProperties = ArrayProperties;
            this.JobDefinition = JobDefinition;
            this.JobName = JobName;
            this.RetryStrategy = RetryStrategy;
        }
    }
}
