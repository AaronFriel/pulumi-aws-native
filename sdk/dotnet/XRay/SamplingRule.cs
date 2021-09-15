// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.XRay
{
    /// <summary>
    /// This schema provides construct and validation rules for AWS-XRay SamplingRule resource parameters.
    /// </summary>
    [AwsNativeResourceType("aws-native:xray:SamplingRule")]
    public partial class SamplingRule : Pulumi.CustomResource
    {
        [Output("ruleARN")]
        public Output<string> RuleARN { get; private set; } = null!;

        [Output("ruleName")]
        public Output<string?> RuleName { get; private set; } = null!;

        [Output("samplingRule")]
        public Output<Outputs.SamplingRuleSamplingRule?> SamplingRuleValue { get; private set; } = null!;

        [Output("samplingRuleRecord")]
        public Output<Outputs.SamplingRuleSamplingRuleRecord?> SamplingRuleRecord { get; private set; } = null!;

        [Output("samplingRuleUpdate")]
        public Output<Outputs.SamplingRuleSamplingRuleUpdate?> SamplingRuleUpdate { get; private set; } = null!;

        [Output("tags")]
        public Output<ImmutableArray<object>> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a SamplingRule resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SamplingRule(string name, SamplingRuleArgs? args = null, CustomResourceOptions? options = null)
            : base("aws-native:xray:SamplingRule", name, args ?? new SamplingRuleArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SamplingRule(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:xray:SamplingRule", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing SamplingRule resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SamplingRule Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new SamplingRule(name, id, options);
        }
    }

    public sealed class SamplingRuleArgs : Pulumi.ResourceArgs
    {
        [Input("ruleName")]
        public Input<string>? RuleName { get; set; }

        [Input("samplingRule")]
        public Input<Inputs.SamplingRuleSamplingRuleArgs>? SamplingRuleValue { get; set; }

        [Input("samplingRuleRecord")]
        public Input<Inputs.SamplingRuleSamplingRuleRecordArgs>? SamplingRuleRecord { get; set; }

        [Input("samplingRuleUpdate")]
        public Input<Inputs.SamplingRuleSamplingRuleUpdateArgs>? SamplingRuleUpdate { get; set; }

        [Input("tags")]
        private InputList<object>? _tags;
        public InputList<object> Tags
        {
            get => _tags ?? (_tags = new InputList<object>());
            set => _tags = value;
        }

        public SamplingRuleArgs()
        {
        }
    }
}
