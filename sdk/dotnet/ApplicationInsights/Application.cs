// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ApplicationInsights
{
    /// <summary>
    /// Resource schema for AWS::ApplicationInsights::Application
    /// </summary>
    [AwsNativeResourceType("aws-native:applicationinsights:Application")]
    public partial class Application : Pulumi.CustomResource
    {
        /// <summary>
        /// The ARN of the ApplicationInsights application.
        /// </summary>
        [Output("applicationARN")]
        public Output<string> ApplicationARN { get; private set; } = null!;

        /// <summary>
        /// If set to true, application will be configured with recommended monitoring configuration.
        /// </summary>
        [Output("autoConfigurationEnabled")]
        public Output<bool?> AutoConfigurationEnabled { get; private set; } = null!;

        /// <summary>
        /// Indicates whether Application Insights can listen to CloudWatch events for the application resources.
        /// </summary>
        [Output("cWEMonitorEnabled")]
        public Output<bool?> CWEMonitorEnabled { get; private set; } = null!;

        /// <summary>
        /// The monitoring settings of the components.
        /// </summary>
        [Output("componentMonitoringSettings")]
        public Output<ImmutableArray<Outputs.ApplicationComponentMonitoringSetting>> ComponentMonitoringSettings { get; private set; } = null!;

        /// <summary>
        /// The custom grouped components.
        /// </summary>
        [Output("customComponents")]
        public Output<ImmutableArray<Outputs.ApplicationCustomComponent>> CustomComponents { get; private set; } = null!;

        /// <summary>
        /// The log pattern sets.
        /// </summary>
        [Output("logPatternSets")]
        public Output<ImmutableArray<Outputs.ApplicationLogPatternSet>> LogPatternSets { get; private set; } = null!;

        /// <summary>
        /// When set to true, creates opsItems for any problems detected on an application.
        /// </summary>
        [Output("opsCenterEnabled")]
        public Output<bool?> OpsCenterEnabled { get; private set; } = null!;

        /// <summary>
        /// The SNS topic provided to Application Insights that is associated to the created opsItem.
        /// </summary>
        [Output("opsItemSNSTopicArn")]
        public Output<string?> OpsItemSNSTopicArn { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// The tags of Application Insights application.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableArray<Outputs.ApplicationTag>> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a Application resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Application(string name, ApplicationArgs args, CustomResourceOptions? options = null)
            : base("aws-native:applicationinsights:Application", name, args ?? new ApplicationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Application(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:applicationinsights:Application", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing Application resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Application Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Application(name, id, options);
        }
    }

    public sealed class ApplicationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// If set to true, application will be configured with recommended monitoring configuration.
        /// </summary>
        [Input("autoConfigurationEnabled")]
        public Input<bool>? AutoConfigurationEnabled { get; set; }

        /// <summary>
        /// Indicates whether Application Insights can listen to CloudWatch events for the application resources.
        /// </summary>
        [Input("cWEMonitorEnabled")]
        public Input<bool>? CWEMonitorEnabled { get; set; }

        [Input("componentMonitoringSettings")]
        private InputList<Inputs.ApplicationComponentMonitoringSettingArgs>? _componentMonitoringSettings;

        /// <summary>
        /// The monitoring settings of the components.
        /// </summary>
        public InputList<Inputs.ApplicationComponentMonitoringSettingArgs> ComponentMonitoringSettings
        {
            get => _componentMonitoringSettings ?? (_componentMonitoringSettings = new InputList<Inputs.ApplicationComponentMonitoringSettingArgs>());
            set => _componentMonitoringSettings = value;
        }

        [Input("customComponents")]
        private InputList<Inputs.ApplicationCustomComponentArgs>? _customComponents;

        /// <summary>
        /// The custom grouped components.
        /// </summary>
        public InputList<Inputs.ApplicationCustomComponentArgs> CustomComponents
        {
            get => _customComponents ?? (_customComponents = new InputList<Inputs.ApplicationCustomComponentArgs>());
            set => _customComponents = value;
        }

        [Input("logPatternSets")]
        private InputList<Inputs.ApplicationLogPatternSetArgs>? _logPatternSets;

        /// <summary>
        /// The log pattern sets.
        /// </summary>
        public InputList<Inputs.ApplicationLogPatternSetArgs> LogPatternSets
        {
            get => _logPatternSets ?? (_logPatternSets = new InputList<Inputs.ApplicationLogPatternSetArgs>());
            set => _logPatternSets = value;
        }

        /// <summary>
        /// When set to true, creates opsItems for any problems detected on an application.
        /// </summary>
        [Input("opsCenterEnabled")]
        public Input<bool>? OpsCenterEnabled { get; set; }

        /// <summary>
        /// The SNS topic provided to Application Insights that is associated to the created opsItem.
        /// </summary>
        [Input("opsItemSNSTopicArn")]
        public Input<string>? OpsItemSNSTopicArn { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("tags")]
        private InputList<Inputs.ApplicationTagArgs>? _tags;

        /// <summary>
        /// The tags of Application Insights application.
        /// </summary>
        public InputList<Inputs.ApplicationTagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.ApplicationTagArgs>());
            set => _tags = value;
        }

        public ApplicationArgs()
        {
        }
    }
}
