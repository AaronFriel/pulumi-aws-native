// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CloudFront
{
    /// <summary>
    /// Resource Type definition for AWS::CloudFront::ResponseHeadersPolicy
    /// </summary>
    [AwsNativeResourceType("aws-native:cloudfront:ResponseHeadersPolicy")]
    public partial class ResponseHeadersPolicy : Pulumi.CustomResource
    {
        [Output("lastModifiedTime")]
        public Output<string> LastModifiedTime { get; private set; } = null!;

        [Output("responseHeadersPolicyConfig")]
        public Output<Outputs.ResponseHeadersPolicyConfig> ResponseHeadersPolicyConfig { get; private set; } = null!;


        /// <summary>
        /// Create a ResponseHeadersPolicy resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ResponseHeadersPolicy(string name, ResponseHeadersPolicyArgs args, CustomResourceOptions? options = null)
            : base("aws-native:cloudfront:ResponseHeadersPolicy", name, args ?? new ResponseHeadersPolicyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ResponseHeadersPolicy(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:cloudfront:ResponseHeadersPolicy", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing ResponseHeadersPolicy resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ResponseHeadersPolicy Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ResponseHeadersPolicy(name, id, options);
        }
    }

    public sealed class ResponseHeadersPolicyArgs : Pulumi.ResourceArgs
    {
        [Input("responseHeadersPolicyConfig", required: true)]
        public Input<Inputs.ResponseHeadersPolicyConfigArgs> ResponseHeadersPolicyConfig { get; set; } = null!;

        public ResponseHeadersPolicyArgs()
        {
        }
    }
}