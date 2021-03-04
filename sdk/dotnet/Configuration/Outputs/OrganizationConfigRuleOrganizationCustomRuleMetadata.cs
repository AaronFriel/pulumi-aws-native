// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Configuration.Outputs
{

    [OutputType]
    public sealed class OrganizationConfigRuleOrganizationCustomRuleMetadata
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-organizationconfigrule-organizationcustomrulemetadata.html#cfn-config-organizationconfigrule-organizationcustomrulemetadata-description
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-organizationconfigrule-organizationcustomrulemetadata.html#cfn-config-organizationconfigrule-organizationcustomrulemetadata-inputparameters
        /// </summary>
        public readonly string? InputParameters;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-organizationconfigrule-organizationcustomrulemetadata.html#cfn-config-organizationconfigrule-organizationcustomrulemetadata-lambdafunctionarn
        /// </summary>
        public readonly string LambdaFunctionArn;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-organizationconfigrule-organizationcustomrulemetadata.html#cfn-config-organizationconfigrule-organizationcustomrulemetadata-maximumexecutionfrequency
        /// </summary>
        public readonly string? MaximumExecutionFrequency;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-organizationconfigrule-organizationcustomrulemetadata.html#cfn-config-organizationconfigrule-organizationcustomrulemetadata-organizationconfigruletriggertypes
        /// </summary>
        public readonly ImmutableArray<string> OrganizationConfigRuleTriggerTypes;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-organizationconfigrule-organizationcustomrulemetadata.html#cfn-config-organizationconfigrule-organizationcustomrulemetadata-resourceidscope
        /// </summary>
        public readonly string? ResourceIdScope;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-organizationconfigrule-organizationcustomrulemetadata.html#cfn-config-organizationconfigrule-organizationcustomrulemetadata-resourcetypesscope
        /// </summary>
        public readonly ImmutableArray<string> ResourceTypesScope;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-organizationconfigrule-organizationcustomrulemetadata.html#cfn-config-organizationconfigrule-organizationcustomrulemetadata-tagkeyscope
        /// </summary>
        public readonly string? TagKeyScope;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-organizationconfigrule-organizationcustomrulemetadata.html#cfn-config-organizationconfigrule-organizationcustomrulemetadata-tagvaluescope
        /// </summary>
        public readonly string? TagValueScope;

        [OutputConstructor]
        private OrganizationConfigRuleOrganizationCustomRuleMetadata(
            string? Description,

            string? InputParameters,

            string LambdaFunctionArn,

            string? MaximumExecutionFrequency,

            ImmutableArray<string> OrganizationConfigRuleTriggerTypes,

            string? ResourceIdScope,

            ImmutableArray<string> ResourceTypesScope,

            string? TagKeyScope,

            string? TagValueScope)
        {
            this.Description = Description;
            this.InputParameters = InputParameters;
            this.LambdaFunctionArn = LambdaFunctionArn;
            this.MaximumExecutionFrequency = MaximumExecutionFrequency;
            this.OrganizationConfigRuleTriggerTypes = OrganizationConfigRuleTriggerTypes;
            this.ResourceIdScope = ResourceIdScope;
            this.ResourceTypesScope = ResourceTypesScope;
            this.TagKeyScope = TagKeyScope;
            this.TagValueScope = TagValueScope;
        }
    }
}
