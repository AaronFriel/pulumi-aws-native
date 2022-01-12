// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.WAFv2.Outputs
{

    /// <summary>
    /// Action taken when Rule matches its condition.
    /// </summary>
    [OutputType]
    public sealed class RuleGroupRuleAction
    {
        /// <summary>
        /// Allow traffic towards application.
        /// </summary>
        public readonly Outputs.RuleGroupRuleActionAllowProperties? Allow;
        /// <summary>
        /// Block traffic towards application.
        /// </summary>
        public readonly Outputs.RuleGroupRuleActionBlockProperties? Block;
        /// <summary>
        /// Checks valid token exists with request.
        /// </summary>
        public readonly Outputs.RuleGroupRuleActionCaptchaProperties? Captcha;
        /// <summary>
        /// Count traffic towards application.
        /// </summary>
        public readonly Outputs.RuleGroupRuleActionCountProperties? Count;

        [OutputConstructor]
        private RuleGroupRuleAction(
            Outputs.RuleGroupRuleActionAllowProperties? allow,

            Outputs.RuleGroupRuleActionBlockProperties? block,

            Outputs.RuleGroupRuleActionCaptchaProperties? captcha,

            Outputs.RuleGroupRuleActionCountProperties? count)
        {
            Allow = allow;
            Block = block;
            Captcha = captcha;
            Count = count;
        }
    }
}
