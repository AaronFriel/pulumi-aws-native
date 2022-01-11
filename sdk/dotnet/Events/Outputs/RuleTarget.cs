// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Events.Outputs
{

    [OutputType]
    public sealed class RuleTarget
    {
        public readonly string Arn;
        public readonly Outputs.RuleBatchParameters? BatchParameters;
        public readonly Outputs.RuleDeadLetterConfig? DeadLetterConfig;
        public readonly Outputs.RuleEcsParameters? EcsParameters;
        public readonly Outputs.RuleHttpParameters? HttpParameters;
        public readonly string Id;
        public readonly string? Input;
        public readonly string? InputPath;
        public readonly Outputs.RuleInputTransformer? InputTransformer;
        public readonly Outputs.RuleKinesisParameters? KinesisParameters;
        public readonly Outputs.RuleRedshiftDataParameters? RedshiftDataParameters;
        public readonly Outputs.RuleRetryPolicy? RetryPolicy;
        public readonly string? RoleArn;
        public readonly Outputs.RuleRunCommandParameters? RunCommandParameters;
        public readonly Outputs.RuleSqsParameters? SqsParameters;

        [OutputConstructor]
        private RuleTarget(
            string arn,

            Outputs.RuleBatchParameters? batchParameters,

            Outputs.RuleDeadLetterConfig? deadLetterConfig,

            Outputs.RuleEcsParameters? ecsParameters,

            Outputs.RuleHttpParameters? httpParameters,

            string id,

            string? input,

            string? inputPath,

            Outputs.RuleInputTransformer? inputTransformer,

            Outputs.RuleKinesisParameters? kinesisParameters,

            Outputs.RuleRedshiftDataParameters? redshiftDataParameters,

            Outputs.RuleRetryPolicy? retryPolicy,

            string? roleArn,

            Outputs.RuleRunCommandParameters? runCommandParameters,

            Outputs.RuleSqsParameters? sqsParameters)
        {
            Arn = arn;
            BatchParameters = batchParameters;
            DeadLetterConfig = deadLetterConfig;
            EcsParameters = ecsParameters;
            HttpParameters = httpParameters;
            Id = id;
            Input = input;
            InputPath = inputPath;
            InputTransformer = inputTransformer;
            KinesisParameters = kinesisParameters;
            RedshiftDataParameters = redshiftDataParameters;
            RetryPolicy = retryPolicy;
            RoleArn = roleArn;
            RunCommandParameters = runCommandParameters;
            SqsParameters = sqsParameters;
        }
    }
}
