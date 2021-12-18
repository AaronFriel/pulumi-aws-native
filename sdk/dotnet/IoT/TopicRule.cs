// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoT
{
    /// <summary>
    /// Resource Type definition for AWS::IoT::TopicRule
    /// </summary>
    [AwsNativeResourceType("aws-native:iot:TopicRule")]
    public partial class TopicRule : Pulumi.CustomResource
    {
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        [Output("ruleName")]
        public Output<string?> RuleName { get; private set; } = null!;

        [Output("tags")]
        public Output<ImmutableArray<Outputs.TopicRuleTag>> Tags { get; private set; } = null!;

        [Output("topicRulePayload")]
        public Output<Outputs.TopicRulePayload> TopicRulePayload { get; private set; } = null!;


        /// <summary>
        /// Create a TopicRule resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public TopicRule(string name, TopicRuleArgs args, CustomResourceOptions? options = null)
            : base("aws-native:iot:TopicRule", name, args ?? new TopicRuleArgs(), MakeResourceOptions(options, ""))
        {
        }

        private TopicRule(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:iot:TopicRule", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing TopicRule resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static TopicRule Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new TopicRule(name, id, options);
        }
    }

    public sealed class TopicRuleArgs : Pulumi.ResourceArgs
    {
        [Input("ruleName")]
        public Input<string>? RuleName { get; set; }

        [Input("tags")]
        private InputList<Inputs.TopicRuleTagArgs>? _tags;
        public InputList<Inputs.TopicRuleTagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.TopicRuleTagArgs>());
            set => _tags = value;
        }

        [Input("topicRulePayload", required: true)]
        public Input<Inputs.TopicRulePayloadArgs> TopicRulePayload { get; set; } = null!;

        public TopicRuleArgs()
        {
        }
    }
}
