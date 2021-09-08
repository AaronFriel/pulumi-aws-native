// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AutoScaling
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html
    /// </summary>
    [AwsNativeResourceType("aws-native:autoscaling:LaunchConfiguration")]
    public partial class LaunchConfiguration : Pulumi.CustomResource
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cf-as-launchconfig-associatepubip
        /// </summary>
        [Output("associatePublicIpAddress")]
        public Output<bool?> AssociatePublicIpAddress { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-blockdevicemappings
        /// </summary>
        [Output("blockDeviceMappings")]
        public Output<ImmutableArray<Outputs.LaunchConfigurationBlockDeviceMapping>> BlockDeviceMappings { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-classiclinkvpcid
        /// </summary>
        [Output("classicLinkVPCId")]
        public Output<string?> ClassicLinkVPCId { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-classiclinkvpcsecuritygroups
        /// </summary>
        [Output("classicLinkVPCSecurityGroups")]
        public Output<ImmutableArray<string>> ClassicLinkVPCSecurityGroups { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-ebsoptimized
        /// </summary>
        [Output("ebsOptimized")]
        public Output<bool?> EbsOptimized { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-iaminstanceprofile
        /// </summary>
        [Output("iamInstanceProfile")]
        public Output<string?> IamInstanceProfile { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-imageid
        /// </summary>
        [Output("imageId")]
        public Output<string> ImageId { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-instanceid
        /// </summary>
        [Output("instanceId")]
        public Output<string?> InstanceId { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-instancemonitoring
        /// </summary>
        [Output("instanceMonitoring")]
        public Output<bool?> InstanceMonitoring { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-instancetype
        /// </summary>
        [Output("instanceType")]
        public Output<string> InstanceType { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-kernelid
        /// </summary>
        [Output("kernelId")]
        public Output<string?> KernelId { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-keyname
        /// </summary>
        [Output("keyName")]
        public Output<string?> KeyName { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-autoscaling-launchconfig-launchconfigurationname
        /// </summary>
        [Output("launchConfigurationName")]
        public Output<string?> LaunchConfigurationName { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-autoscaling-launchconfig-metadataoptions
        /// </summary>
        [Output("metadataOptions")]
        public Output<Outputs.LaunchConfigurationMetadataOptions?> MetadataOptions { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-placementtenancy
        /// </summary>
        [Output("placementTenancy")]
        public Output<string?> PlacementTenancy { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-ramdiskid
        /// </summary>
        [Output("ramDiskId")]
        public Output<string?> RamDiskId { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-securitygroups
        /// </summary>
        [Output("securityGroups")]
        public Output<ImmutableArray<string>> SecurityGroups { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-spotprice
        /// </summary>
        [Output("spotPrice")]
        public Output<string?> SpotPrice { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-userdata
        /// </summary>
        [Output("userData")]
        public Output<string?> UserData { get; private set; } = null!;


        /// <summary>
        /// Create a LaunchConfiguration resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LaunchConfiguration(string name, LaunchConfigurationArgs args, CustomResourceOptions? options = null)
            : base("aws-native:autoscaling:LaunchConfiguration", name, args ?? new LaunchConfigurationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private LaunchConfiguration(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:autoscaling:LaunchConfiguration", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing LaunchConfiguration resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LaunchConfiguration Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new LaunchConfiguration(name, id, options);
        }
    }

    public sealed class LaunchConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cf-as-launchconfig-associatepubip
        /// </summary>
        [Input("associatePublicIpAddress")]
        public Input<bool>? AssociatePublicIpAddress { get; set; }

        [Input("blockDeviceMappings")]
        private InputList<Inputs.LaunchConfigurationBlockDeviceMappingArgs>? _blockDeviceMappings;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-blockdevicemappings
        /// </summary>
        public InputList<Inputs.LaunchConfigurationBlockDeviceMappingArgs> BlockDeviceMappings
        {
            get => _blockDeviceMappings ?? (_blockDeviceMappings = new InputList<Inputs.LaunchConfigurationBlockDeviceMappingArgs>());
            set => _blockDeviceMappings = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-classiclinkvpcid
        /// </summary>
        [Input("classicLinkVPCId")]
        public Input<string>? ClassicLinkVPCId { get; set; }

        [Input("classicLinkVPCSecurityGroups")]
        private InputList<string>? _classicLinkVPCSecurityGroups;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-classiclinkvpcsecuritygroups
        /// </summary>
        public InputList<string> ClassicLinkVPCSecurityGroups
        {
            get => _classicLinkVPCSecurityGroups ?? (_classicLinkVPCSecurityGroups = new InputList<string>());
            set => _classicLinkVPCSecurityGroups = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-ebsoptimized
        /// </summary>
        [Input("ebsOptimized")]
        public Input<bool>? EbsOptimized { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-iaminstanceprofile
        /// </summary>
        [Input("iamInstanceProfile")]
        public Input<string>? IamInstanceProfile { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-imageid
        /// </summary>
        [Input("imageId", required: true)]
        public Input<string> ImageId { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-instanceid
        /// </summary>
        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-instancemonitoring
        /// </summary>
        [Input("instanceMonitoring")]
        public Input<bool>? InstanceMonitoring { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-instancetype
        /// </summary>
        [Input("instanceType", required: true)]
        public Input<string> InstanceType { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-kernelid
        /// </summary>
        [Input("kernelId")]
        public Input<string>? KernelId { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-keyname
        /// </summary>
        [Input("keyName")]
        public Input<string>? KeyName { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-autoscaling-launchconfig-launchconfigurationname
        /// </summary>
        [Input("launchConfigurationName")]
        public Input<string>? LaunchConfigurationName { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-autoscaling-launchconfig-metadataoptions
        /// </summary>
        [Input("metadataOptions")]
        public Input<Inputs.LaunchConfigurationMetadataOptionsArgs>? MetadataOptions { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-placementtenancy
        /// </summary>
        [Input("placementTenancy")]
        public Input<string>? PlacementTenancy { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-ramdiskid
        /// </summary>
        [Input("ramDiskId")]
        public Input<string>? RamDiskId { get; set; }

        [Input("securityGroups")]
        private InputList<string>? _securityGroups;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-securitygroups
        /// </summary>
        public InputList<string> SecurityGroups
        {
            get => _securityGroups ?? (_securityGroups = new InputList<string>());
            set => _securityGroups = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-spotprice
        /// </summary>
        [Input("spotPrice")]
        public Input<string>? SpotPrice { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-userdata
        /// </summary>
        [Input("userData")]
        public Input<string>? UserData { get; set; }

        public LaunchConfigurationArgs()
        {
        }
    }
}