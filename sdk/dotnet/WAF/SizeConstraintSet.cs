// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.WAF
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-sizeconstraintset.html
    /// </summary>
    [AwsNativeResourceType("aws-native:waf:SizeConstraintSet")]
    public partial class SizeConstraintSet : Pulumi.CustomResource
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-sizeconstraintset.html#cfn-waf-sizeconstraintset-name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-sizeconstraintset.html#cfn-waf-sizeconstraintset-sizeconstraints
        /// </summary>
        [Output("sizeConstraints")]
        public Output<ImmutableArray<Outputs.SizeConstraintSetSizeConstraint>> SizeConstraints { get; private set; } = null!;


        /// <summary>
        /// Create a SizeConstraintSet resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SizeConstraintSet(string name, SizeConstraintSetArgs args, CustomResourceOptions? options = null)
            : base("aws-native:waf:SizeConstraintSet", name, args ?? new SizeConstraintSetArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SizeConstraintSet(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:waf:SizeConstraintSet", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing SizeConstraintSet resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SizeConstraintSet Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new SizeConstraintSet(name, id, options);
        }
    }

    public sealed class SizeConstraintSetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-sizeconstraintset.html#cfn-waf-sizeconstraintset-name
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("sizeConstraints", required: true)]
        private InputList<Inputs.SizeConstraintSetSizeConstraintArgs>? _sizeConstraints;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-sizeconstraintset.html#cfn-waf-sizeconstraintset-sizeconstraints
        /// </summary>
        public InputList<Inputs.SizeConstraintSetSizeConstraintArgs> SizeConstraints
        {
            get => _sizeConstraints ?? (_sizeConstraints = new InputList<Inputs.SizeConstraintSetSizeConstraintArgs>());
            set => _sizeConstraints = value;
        }

        public SizeConstraintSetArgs()
        {
        }
    }
}