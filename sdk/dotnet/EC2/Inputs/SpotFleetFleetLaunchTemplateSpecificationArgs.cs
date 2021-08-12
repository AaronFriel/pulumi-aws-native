// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.EC2.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-fleetlaunchtemplatespecification.html
    /// </summary>
    public sealed class SpotFleetFleetLaunchTemplateSpecificationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-fleetlaunchtemplatespecification.html#cfn-ec2-spotfleet-fleetlaunchtemplatespecification-launchtemplateid
        /// </summary>
        [Input("launchTemplateId")]
        public Input<string>? LaunchTemplateId { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-fleetlaunchtemplatespecification.html#cfn-ec2-spotfleet-fleetlaunchtemplatespecification-launchtemplatename
        /// </summary>
        [Input("launchTemplateName")]
        public Input<string>? LaunchTemplateName { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-fleetlaunchtemplatespecification.html#cfn-ec2-spotfleet-fleetlaunchtemplatespecification-version
        /// </summary>
        [Input("version", required: true)]
        public Input<string> Version { get; set; } = null!;

        public SpotFleetFleetLaunchTemplateSpecificationArgs()
        {
        }
    }
}