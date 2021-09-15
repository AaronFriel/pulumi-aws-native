// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.LookoutMetrics.Outputs
{

    /// <summary>
    /// Configuration options for a Lambda alert action.
    /// </summary>
    [OutputType]
    public sealed class AlertLambdaConfiguration
    {
        /// <summary>
        /// ARN of a Lambda to send alert notifications to.
        /// </summary>
        public readonly string LambdaArn;
        /// <summary>
        /// ARN of an IAM role that LookoutMetrics should assume to access the Lambda function.
        /// </summary>
        public readonly string RoleArn;

        [OutputConstructor]
        private AlertLambdaConfiguration(
            string lambdaArn,

            string roleArn)
        {
            LambdaArn = lambdaArn;
            RoleArn = roleArn;
        }
    }
}
