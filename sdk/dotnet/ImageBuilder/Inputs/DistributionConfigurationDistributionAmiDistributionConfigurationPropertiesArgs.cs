// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ImageBuilder.Inputs
{

    /// <summary>
    /// The specific AMI settings (for example, launch permissions, AMI tags).
    /// </summary>
    public sealed class DistributionConfigurationDistributionAmiDistributionConfigurationPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The tags to apply to AMIs distributed to this Region.
        /// </summary>
        [Input("amiTags")]
        public Input<object>? AmiTags { get; set; }

        /// <summary>
        /// The description of the AMI distribution configuration.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The KMS key identifier used to encrypt the distributed image.
        /// </summary>
        [Input("kmsKeyId")]
        public Input<string>? KmsKeyId { get; set; }

        /// <summary>
        /// Launch permissions can be used to configure which AWS accounts can use the AMI to launch instances.
        /// </summary>
        [Input("launchPermissionConfiguration")]
        public Input<Inputs.DistributionConfigurationDistributionAmiDistributionConfigurationPropertiesLaunchPermissionConfigurationPropertiesArgs>? LaunchPermissionConfiguration { get; set; }

        /// <summary>
        /// The name of the AMI distribution configuration.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("targetAccountIds")]
        private InputList<string>? _targetAccountIds;

        /// <summary>
        /// The ID of accounts to which you want to distribute an image.
        /// </summary>
        public InputList<string> TargetAccountIds
        {
            get => _targetAccountIds ?? (_targetAccountIds = new InputList<string>());
            set => _targetAccountIds = value;
        }

        public DistributionConfigurationDistributionAmiDistributionConfigurationPropertiesArgs()
        {
        }
    }
}
