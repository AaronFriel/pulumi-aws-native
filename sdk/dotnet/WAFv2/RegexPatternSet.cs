// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.WAFv2
{
    /// <summary>
    /// Contains a list of Regular expressions based on the provided inputs. RegexPatternSet can be used with other WAF entities with RegexPatternSetReferenceStatement to perform other actions .
    /// </summary>
    [AwsNativeResourceType("aws-native:wafv2:RegexPatternSet")]
    public partial class RegexPatternSet : Pulumi.CustomResource
    {
        /// <summary>
        /// ARN of the WAF entity.
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// Description of the entity.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Name of the RegexPatternSet.
        /// </summary>
        [Output("name")]
        public Output<string?> Name { get; private set; } = null!;

        [Output("regularExpressionList")]
        public Output<ImmutableArray<string>> RegularExpressionList { get; private set; } = null!;

        /// <summary>
        /// Use CLOUDFRONT for CloudFront RegexPatternSet, use REGIONAL for Application Load Balancer and API Gateway.
        /// </summary>
        [Output("scope")]
        public Output<string> Scope { get; private set; } = null!;

        [Output("tags")]
        public Output<ImmutableArray<Outputs.RegexPatternSetTag>> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a RegexPatternSet resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public RegexPatternSet(string name, RegexPatternSetArgs args, CustomResourceOptions? options = null)
            : base("aws-native:wafv2:RegexPatternSet", name, args ?? new RegexPatternSetArgs(), MakeResourceOptions(options, ""))
        {
        }

        private RegexPatternSet(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:wafv2:RegexPatternSet", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing RegexPatternSet resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static RegexPatternSet Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new RegexPatternSet(name, id, options);
        }
    }

    public sealed class RegexPatternSetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Description of the entity.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Name of the RegexPatternSet.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("regularExpressionList", required: true)]
        private InputList<string>? _regularExpressionList;
        public InputList<string> RegularExpressionList
        {
            get => _regularExpressionList ?? (_regularExpressionList = new InputList<string>());
            set => _regularExpressionList = value;
        }

        /// <summary>
        /// Use CLOUDFRONT for CloudFront RegexPatternSet, use REGIONAL for Application Load Balancer and API Gateway.
        /// </summary>
        [Input("scope", required: true)]
        public Input<string> Scope { get; set; } = null!;

        [Input("tags")]
        private InputList<Inputs.RegexPatternSetTagArgs>? _tags;
        public InputList<Inputs.RegexPatternSetTagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.RegexPatternSetTagArgs>());
            set => _tags = value;
        }

        public RegexPatternSetArgs()
        {
        }
    }
}
