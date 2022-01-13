// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.FIS
{
    /// <summary>
    /// Resource schema for AWS::FIS::ExperimentTemplate
    /// </summary>
    [AwsNativeResourceType("aws-native:fis:ExperimentTemplate")]
    public partial class ExperimentTemplate : Pulumi.CustomResource
    {
        [Output("actions")]
        public Output<Outputs.ExperimentTemplateActionMap?> Actions { get; private set; } = null!;

        [Output("description")]
        public Output<string> Description { get; private set; } = null!;

        [Output("roleArn")]
        public Output<string> RoleArn { get; private set; } = null!;

        [Output("stopConditions")]
        public Output<ImmutableArray<Outputs.ExperimentTemplateStopCondition>> StopConditions { get; private set; } = null!;

        [Output("tags")]
        public Output<object> Tags { get; private set; } = null!;

        [Output("targets")]
        public Output<Outputs.ExperimentTemplateTargetMap> Targets { get; private set; } = null!;


        /// <summary>
        /// Create a ExperimentTemplate resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ExperimentTemplate(string name, ExperimentTemplateArgs args, CustomResourceOptions? options = null)
            : base("aws-native:fis:ExperimentTemplate", name, args ?? new ExperimentTemplateArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ExperimentTemplate(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:fis:ExperimentTemplate", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing ExperimentTemplate resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ExperimentTemplate Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ExperimentTemplate(name, id, options);
        }
    }

    public sealed class ExperimentTemplateArgs : Pulumi.ResourceArgs
    {
        [Input("actions")]
        public Input<Inputs.ExperimentTemplateActionMapArgs>? Actions { get; set; }

        [Input("description", required: true)]
        public Input<string> Description { get; set; } = null!;

        [Input("roleArn", required: true)]
        public Input<string> RoleArn { get; set; } = null!;

        [Input("stopConditions", required: true)]
        private InputList<Inputs.ExperimentTemplateStopConditionArgs>? _stopConditions;
        public InputList<Inputs.ExperimentTemplateStopConditionArgs> StopConditions
        {
            get => _stopConditions ?? (_stopConditions = new InputList<Inputs.ExperimentTemplateStopConditionArgs>());
            set => _stopConditions = value;
        }

        [Input("tags", required: true)]
        public Input<object> Tags { get; set; } = null!;

        [Input("targets", required: true)]
        public Input<Inputs.ExperimentTemplateTargetMapArgs> Targets { get; set; } = null!;

        public ExperimentTemplateArgs()
        {
        }
    }
}
