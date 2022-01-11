// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Lambda
{
    /// <summary>
    /// Resource Type definition for AWS::Lambda::LayerVersionPermission
    /// </summary>
    [Obsolete(@"LayerVersionPermission is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")]
    [AwsNativeResourceType("aws-native:lambda:LayerVersionPermission")]
    public partial class LayerVersionPermission : Pulumi.CustomResource
    {
        [Output("action")]
        public Output<string> Action { get; private set; } = null!;

        [Output("layerVersionArn")]
        public Output<string> LayerVersionArn { get; private set; } = null!;

        [Output("organizationId")]
        public Output<string?> OrganizationId { get; private set; } = null!;

        [Output("principal")]
        public Output<string> Principal { get; private set; } = null!;


        /// <summary>
        /// Create a LayerVersionPermission resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LayerVersionPermission(string name, LayerVersionPermissionArgs args, CustomResourceOptions? options = null)
            : base("aws-native:lambda:LayerVersionPermission", name, args ?? new LayerVersionPermissionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private LayerVersionPermission(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:lambda:LayerVersionPermission", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing LayerVersionPermission resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LayerVersionPermission Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new LayerVersionPermission(name, id, options);
        }
    }

    public sealed class LayerVersionPermissionArgs : Pulumi.ResourceArgs
    {
        [Input("action", required: true)]
        public Input<string> Action { get; set; } = null!;

        [Input("layerVersionArn", required: true)]
        public Input<string> LayerVersionArn { get; set; } = null!;

        [Input("organizationId")]
        public Input<string>? OrganizationId { get; set; }

        [Input("principal", required: true)]
        public Input<string> Principal { get; set; } = null!;

        public LayerVersionPermissionArgs()
        {
        }
    }
}
