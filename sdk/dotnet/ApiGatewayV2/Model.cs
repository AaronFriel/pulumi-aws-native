// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ApiGatewayV2
{
    /// <summary>
    /// Resource Type definition for AWS::ApiGatewayV2::Model
    /// </summary>
    [Obsolete(@"Model is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")]
    [AwsNativeResourceType("aws-native:apigatewayv2:Model")]
    public partial class Model : Pulumi.CustomResource
    {
        [Output("apiId")]
        public Output<string> ApiId { get; private set; } = null!;

        [Output("contentType")]
        public Output<string?> ContentType { get; private set; } = null!;

        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("schema")]
        public Output<object> Schema { get; private set; } = null!;


        /// <summary>
        /// Create a Model resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Model(string name, ModelArgs args, CustomResourceOptions? options = null)
            : base("aws-native:apigatewayv2:Model", name, args ?? new ModelArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Model(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:apigatewayv2:Model", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing Model resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Model Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Model(name, id, options);
        }
    }

    public sealed class ModelArgs : Pulumi.ResourceArgs
    {
        [Input("apiId", required: true)]
        public Input<string> ApiId { get; set; } = null!;

        [Input("contentType")]
        public Input<string>? ContentType { get; set; }

        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("schema", required: true)]
        public Input<object> Schema { get; set; } = null!;

        public ModelArgs()
        {
        }
    }
}
