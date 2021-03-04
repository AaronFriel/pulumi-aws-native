// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ASK.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ask-skill.html
    /// </summary>
    public sealed class SkillPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ask-skill.html#cfn-ask-skill-authenticationconfiguration
        /// </summary>
        [Input("AuthenticationConfiguration", required: true)]
        public Input<Inputs.SkillAuthenticationConfigurationArgs> AuthenticationConfiguration { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ask-skill.html#cfn-ask-skill-skillpackage
        /// </summary>
        [Input("SkillPackage", required: true)]
        public Input<Inputs.SkillSkillPackageArgs> SkillPackage { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ask-skill.html#cfn-ask-skill-vendorid
        /// </summary>
        [Input("VendorId", required: true)]
        public Input<string> VendorId { get; set; } = null!;

        public SkillPropertiesArgs()
        {
        }
    }
}
