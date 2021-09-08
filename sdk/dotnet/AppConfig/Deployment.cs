// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppConfig
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-deployment.html
    /// </summary>
    [AwsNativeResourceType("aws-native:appconfig:Deployment")]
    public partial class Deployment : Pulumi.CustomResource
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-deployment.html#cfn-appconfig-deployment-applicationid
        /// </summary>
        [Output("applicationId")]
        public Output<string> ApplicationId { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-deployment.html#cfn-appconfig-deployment-configurationprofileid
        /// </summary>
        [Output("configurationProfileId")]
        public Output<string> ConfigurationProfileId { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-deployment.html#cfn-appconfig-deployment-configurationversion
        /// </summary>
        [Output("configurationVersion")]
        public Output<string> ConfigurationVersion { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-deployment.html#cfn-appconfig-deployment-deploymentstrategyid
        /// </summary>
        [Output("deploymentStrategyId")]
        public Output<string> DeploymentStrategyId { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-deployment.html#cfn-appconfig-deployment-description
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-deployment.html#cfn-appconfig-deployment-environmentid
        /// </summary>
        [Output("environmentId")]
        public Output<string> EnvironmentId { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-deployment.html#cfn-appconfig-deployment-tags
        /// </summary>
        [Output("tags")]
        public Output<ImmutableArray<Outputs.DeploymentTags>> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a Deployment resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Deployment(string name, DeploymentArgs args, CustomResourceOptions? options = null)
            : base("aws-native:appconfig:Deployment", name, args ?? new DeploymentArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Deployment(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:appconfig:Deployment", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing Deployment resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Deployment Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Deployment(name, id, options);
        }
    }

    public sealed class DeploymentArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-deployment.html#cfn-appconfig-deployment-applicationid
        /// </summary>
        [Input("applicationId", required: true)]
        public Input<string> ApplicationId { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-deployment.html#cfn-appconfig-deployment-configurationprofileid
        /// </summary>
        [Input("configurationProfileId", required: true)]
        public Input<string> ConfigurationProfileId { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-deployment.html#cfn-appconfig-deployment-configurationversion
        /// </summary>
        [Input("configurationVersion", required: true)]
        public Input<string> ConfigurationVersion { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-deployment.html#cfn-appconfig-deployment-deploymentstrategyid
        /// </summary>
        [Input("deploymentStrategyId", required: true)]
        public Input<string> DeploymentStrategyId { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-deployment.html#cfn-appconfig-deployment-description
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-deployment.html#cfn-appconfig-deployment-environmentid
        /// </summary>
        [Input("environmentId", required: true)]
        public Input<string> EnvironmentId { get; set; } = null!;

        [Input("tags")]
        private InputList<Inputs.DeploymentTagsArgs>? _tags;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appconfig-deployment.html#cfn-appconfig-deployment-tags
        /// </summary>
        public InputList<Inputs.DeploymentTagsArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.DeploymentTagsArgs>());
            set => _tags = value;
        }

        public DeploymentArgs()
        {
        }
    }
}