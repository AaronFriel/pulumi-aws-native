// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DLM.Outputs
{

    [OutputType]
    public sealed class LifecyclePolicySchedule
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-schedule.html#cfn-dlm-lifecyclepolicy-schedule-copytags
        /// </summary>
        public readonly bool? CopyTags;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-schedule.html#cfn-dlm-lifecyclepolicy-schedule-createrule
        /// </summary>
        public readonly Outputs.LifecyclePolicyCreateRule? CreateRule;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-schedule.html#cfn-dlm-lifecyclepolicy-schedule-crossregioncopyrules
        /// </summary>
        public readonly ImmutableArray<Outputs.LifecyclePolicyCrossRegionCopyRule> CrossRegionCopyRules;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-schedule.html#cfn-dlm-lifecyclepolicy-schedule-fastrestorerule
        /// </summary>
        public readonly Outputs.LifecyclePolicyFastRestoreRule? FastRestoreRule;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-schedule.html#cfn-dlm-lifecyclepolicy-schedule-name
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-schedule.html#cfn-dlm-lifecyclepolicy-schedule-retainrule
        /// </summary>
        public readonly Outputs.LifecyclePolicyRetainRule? RetainRule;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-schedule.html#cfn-dlm-lifecyclepolicy-schedule-sharerules
        /// </summary>
        public readonly ImmutableArray<Outputs.LifecyclePolicyShareRule> ShareRules;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-schedule.html#cfn-dlm-lifecyclepolicy-schedule-tagstoadd
        /// </summary>
        public readonly ImmutableArray<Pulumi.AwsNative.Outputs.Tag> TagsToAdd;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-schedule.html#cfn-dlm-lifecyclepolicy-schedule-variabletags
        /// </summary>
        public readonly ImmutableArray<Pulumi.AwsNative.Outputs.Tag> VariableTags;

        [OutputConstructor]
        private LifecyclePolicySchedule(
            bool? CopyTags,

            Outputs.LifecyclePolicyCreateRule? CreateRule,

            ImmutableArray<Outputs.LifecyclePolicyCrossRegionCopyRule> CrossRegionCopyRules,

            Outputs.LifecyclePolicyFastRestoreRule? FastRestoreRule,

            string? Name,

            Outputs.LifecyclePolicyRetainRule? RetainRule,

            ImmutableArray<Outputs.LifecyclePolicyShareRule> ShareRules,

            ImmutableArray<Pulumi.AwsNative.Outputs.Tag> TagsToAdd,

            ImmutableArray<Pulumi.AwsNative.Outputs.Tag> VariableTags)
        {
            this.CopyTags = CopyTags;
            this.CreateRule = CreateRule;
            this.CrossRegionCopyRules = CrossRegionCopyRules;
            this.FastRestoreRule = FastRestoreRule;
            this.Name = Name;
            this.RetainRule = RetainRule;
            this.ShareRules = ShareRules;
            this.TagsToAdd = TagsToAdd;
            this.VariableTags = VariableTags;
        }
    }
}
