// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.OpsWorks.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-layer.html
    /// </summary>
    public sealed class LayerPropertiesArgs : Pulumi.ResourceArgs
    {
        [Input("Attributes")]
        private InputMap<string>? _Attributes;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-layer.html#cfn-opsworks-layer-attributes
        /// </summary>
        public InputMap<string> Attributes
        {
            get => _Attributes ?? (_Attributes = new InputMap<string>());
            set => _Attributes = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-layer.html#cfn-opsworks-layer-autoassignelasticips
        /// </summary>
        [Input("AutoAssignElasticIps", required: true)]
        public Input<bool> AutoAssignElasticIps { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-layer.html#cfn-opsworks-layer-autoassignpublicips
        /// </summary>
        [Input("AutoAssignPublicIps", required: true)]
        public Input<bool> AutoAssignPublicIps { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-layer.html#cfn-opsworks-layer-custominstanceprofilearn
        /// </summary>
        [Input("CustomInstanceProfileArn")]
        public Input<string>? CustomInstanceProfileArn { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-layer.html#cfn-opsworks-layer-customjson
        /// </summary>
        [Input("CustomJson")]
        public InputUnion<System.Text.Json.JsonElement, string>? CustomJson { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-layer.html#cfn-opsworks-layer-customrecipes
        /// </summary>
        [Input("CustomRecipes")]
        public Input<Inputs.LayerRecipesArgs>? CustomRecipes { get; set; }

        [Input("CustomSecurityGroupIds")]
        private InputList<string>? _CustomSecurityGroupIds;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-layer.html#cfn-opsworks-layer-customsecuritygroupids
        /// </summary>
        public InputList<string> CustomSecurityGroupIds
        {
            get => _CustomSecurityGroupIds ?? (_CustomSecurityGroupIds = new InputList<string>());
            set => _CustomSecurityGroupIds = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-layer.html#cfn-opsworks-layer-enableautohealing
        /// </summary>
        [Input("EnableAutoHealing", required: true)]
        public Input<bool> EnableAutoHealing { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-layer.html#cfn-opsworks-layer-installupdatesonboot
        /// </summary>
        [Input("InstallUpdatesOnBoot")]
        public Input<bool>? InstallUpdatesOnBoot { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-layer.html#cfn-opsworks-layer-lifecycleeventconfiguration
        /// </summary>
        [Input("LifecycleEventConfiguration")]
        public Input<Inputs.LayerLifecycleEventConfigurationArgs>? LifecycleEventConfiguration { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-layer.html#cfn-opsworks-layer-loadbasedautoscaling
        /// </summary>
        [Input("LoadBasedAutoScaling")]
        public Input<Inputs.LayerLoadBasedAutoScalingArgs>? LoadBasedAutoScaling { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-layer.html#cfn-opsworks-layer-name
        /// </summary>
        [Input("Name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("Packages")]
        private InputList<string>? _Packages;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-layer.html#cfn-opsworks-layer-packages
        /// </summary>
        public InputList<string> Packages
        {
            get => _Packages ?? (_Packages = new InputList<string>());
            set => _Packages = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-layer.html#cfn-opsworks-layer-shortname
        /// </summary>
        [Input("Shortname", required: true)]
        public Input<string> Shortname { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-layer.html#cfn-opsworks-layer-stackid
        /// </summary>
        [Input("StackId", required: true)]
        public Input<string> StackId { get; set; } = null!;

        [Input("Tags")]
        private InputList<Pulumi.AwsNative.Inputs.TagArgs>? _Tags;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-layer.html#cfn-opsworks-layer-tags
        /// </summary>
        public InputList<Pulumi.AwsNative.Inputs.TagArgs> Tags
        {
            get => _Tags ?? (_Tags = new InputList<Pulumi.AwsNative.Inputs.TagArgs>());
            set => _Tags = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-layer.html#cfn-opsworks-layer-type
        /// </summary>
        [Input("Type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-layer.html#cfn-opsworks-layer-useebsoptimizedinstances
        /// </summary>
        [Input("UseEbsOptimizedInstances")]
        public Input<bool>? UseEbsOptimizedInstances { get; set; }

        [Input("VolumeConfigurations")]
        private InputList<Inputs.LayerVolumeConfigurationArgs>? _VolumeConfigurations;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-layer.html#cfn-opsworks-layer-volumeconfigurations
        /// </summary>
        public InputList<Inputs.LayerVolumeConfigurationArgs> VolumeConfigurations
        {
            get => _VolumeConfigurations ?? (_VolumeConfigurations = new InputList<Inputs.LayerVolumeConfigurationArgs>());
            set => _VolumeConfigurations = value;
        }

        public LayerPropertiesArgs()
        {
        }
    }
}
