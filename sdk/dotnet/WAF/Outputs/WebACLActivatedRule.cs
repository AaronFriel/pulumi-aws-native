// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.WAF.Outputs
{

    [OutputType]
    public sealed class WebACLActivatedRule
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-webacl-rules.html#cfn-waf-webacl-rules-action
        /// </summary>
        public readonly Outputs.WebACLWafAction? Action;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-webacl-rules.html#cfn-waf-webacl-rules-priority
        /// </summary>
        public readonly int Priority;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-webacl-rules.html#cfn-waf-webacl-rules-ruleid
        /// </summary>
        public readonly string RuleId;

        [OutputConstructor]
        private WebACLActivatedRule(
            Outputs.WebACLWafAction? Action,

            int Priority,

            string RuleId)
        {
            this.Action = Action;
            this.Priority = Priority;
            this.RuleId = RuleId;
        }
    }
}
