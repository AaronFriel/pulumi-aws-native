// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.SecurityHub
{
    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-hub.html
    /// </summary>
    [AwsNativeResourceType("aws-native:securityhub:Hub")]
    public partial class Hub : Pulumi.CustomResource
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-hub.html#cfn-securityhub-hub-tags
        /// </summary>
        [Output("tags")]
        public Output<Union<System.Text.Json.JsonElement, string>?> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a Hub resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Hub(string name, HubArgs? args = null, CustomResourceOptions? options = null)
            : base("aws-native:securityhub:Hub", name, args ?? new HubArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Hub(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:securityhub:Hub", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing Hub resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Hub Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Hub(name, id, options);
        }
    }

    public sealed class HubArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-hub.html#cfn-securityhub-hub-tags
        /// </summary>
        [Input("tags")]
        public InputUnion<System.Text.Json.JsonElement, string>? Tags { get; set; }

        public HubArgs()
        {
        }
    }
}