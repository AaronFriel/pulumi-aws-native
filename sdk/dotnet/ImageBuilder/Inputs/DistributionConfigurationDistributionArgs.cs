// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ImageBuilder.Inputs
{

    /// <summary>
    /// The distributions of the distribution configuration.
    /// </summary>
    public sealed class DistributionConfigurationDistributionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The specific AMI settings (for example, launch permissions, AMI tags).
        /// </summary>
        [Input("amiDistributionConfiguration")]
        public Input<object>? AmiDistributionConfiguration { get; set; }

        /// <summary>
        /// Container distribution settings for encryption, licensing, and sharing in a specific Region.
        /// </summary>
        [Input("containerDistributionConfiguration")]
        public Input<object>? ContainerDistributionConfiguration { get; set; }

        [Input("launchTemplateConfigurations")]
        private InputList<Inputs.DistributionConfigurationLaunchTemplateConfigurationArgs>? _launchTemplateConfigurations;

        /// <summary>
        /// A group of launchTemplateConfiguration settings that apply to image distribution.
        /// </summary>
        public InputList<Inputs.DistributionConfigurationLaunchTemplateConfigurationArgs> LaunchTemplateConfigurations
        {
            get => _launchTemplateConfigurations ?? (_launchTemplateConfigurations = new InputList<Inputs.DistributionConfigurationLaunchTemplateConfigurationArgs>());
            set => _launchTemplateConfigurations = value;
        }

        [Input("licenseConfigurationArns")]
        private InputList<string>? _licenseConfigurationArns;

        /// <summary>
        /// The License Manager Configuration to associate with the AMI in the specified Region.
        /// </summary>
        public InputList<string> LicenseConfigurationArns
        {
            get => _licenseConfigurationArns ?? (_licenseConfigurationArns = new InputList<string>());
            set => _licenseConfigurationArns = value;
        }

        /// <summary>
        /// region
        /// </summary>
        [Input("region", required: true)]
        public Input<string> Region { get; set; } = null!;

        public DistributionConfigurationDistributionArgs()
        {
        }
    }
}
