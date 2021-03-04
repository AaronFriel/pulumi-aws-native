// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.S3.Outputs
{

    [OutputType]
    public sealed class BucketRoutingRule
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration-routingrules.html#cfn-s3-websiteconfiguration-routingrules-redirectrule
        /// </summary>
        public readonly Outputs.BucketRedirectRule RedirectRule;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration-routingrules.html#cfn-s3-websiteconfiguration-routingrules-routingrulecondition
        /// </summary>
        public readonly Outputs.BucketRoutingRuleCondition? RoutingRuleCondition;

        [OutputConstructor]
        private BucketRoutingRule(
            Outputs.BucketRedirectRule RedirectRule,

            Outputs.BucketRoutingRuleCondition? RoutingRuleCondition)
        {
            this.RedirectRule = RedirectRule;
            this.RoutingRuleCondition = RoutingRuleCondition;
        }
    }
}
