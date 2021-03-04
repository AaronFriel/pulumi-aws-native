// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.SSM.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-rule.html
    /// </summary>
    public sealed class PatchBaselineRuleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-rule.html#cfn-ssm-patchbaseline-rule-approveafterdays
        /// </summary>
        [Input("ApproveAfterDays")]
        public Input<int>? ApproveAfterDays { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-rule.html#cfn-ssm-patchbaseline-rule-approveuntildate
        /// </summary>
        [Input("ApproveUntilDate")]
        public Input<Inputs.PatchBaselinePatchStringDateArgs>? ApproveUntilDate { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-rule.html#cfn-ssm-patchbaseline-rule-compliancelevel
        /// </summary>
        [Input("ComplianceLevel")]
        public Input<string>? ComplianceLevel { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-rule.html#cfn-ssm-patchbaseline-rule-enablenonsecurity
        /// </summary>
        [Input("EnableNonSecurity")]
        public Input<bool>? EnableNonSecurity { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-rule.html#cfn-ssm-patchbaseline-rule-patchfiltergroup
        /// </summary>
        [Input("PatchFilterGroup")]
        public Input<Inputs.PatchBaselinePatchFilterGroupArgs>? PatchFilterGroup { get; set; }

        public PatchBaselineRuleArgs()
        {
        }
    }
}
