// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Events.Outputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-retrypolicy.html
    /// </summary>
    [OutputType]
    public sealed class RuleRetryPolicy
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-retrypolicy.html#cfn-events-rule-retrypolicy-maximumeventageinseconds
        /// </summary>
        public readonly int? MaximumEventAgeInSeconds;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-retrypolicy.html#cfn-events-rule-retrypolicy-maximumretryattempts
        /// </summary>
        public readonly int? MaximumRetryAttempts;

        [OutputConstructor]
        private RuleRetryPolicy(
            int? maximumEventAgeInSeconds,

            int? maximumRetryAttempts)
        {
            MaximumEventAgeInSeconds = maximumEventAgeInSeconds;
            MaximumRetryAttempts = maximumRetryAttempts;
        }
    }
}