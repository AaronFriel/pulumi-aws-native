// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoT
{
    /// <summary>
    /// Creates an authorizer.
    /// </summary>
    [AwsNativeResourceType("aws-native:iot:Authorizer")]
    public partial class Authorizer : Pulumi.CustomResource
    {
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        [Output("authorizerFunctionArn")]
        public Output<string> AuthorizerFunctionArn { get; private set; } = null!;

        [Output("authorizerName")]
        public Output<string?> AuthorizerName { get; private set; } = null!;

        [Output("signingDisabled")]
        public Output<bool?> SigningDisabled { get; private set; } = null!;

        [Output("status")]
        public Output<string?> Status { get; private set; } = null!;

        [Output("tags")]
        public Output<ImmutableArray<Outputs.AuthorizerTag>> Tags { get; private set; } = null!;

        [Output("tokenKeyName")]
        public Output<string?> TokenKeyName { get; private set; } = null!;

        [Output("tokenSigningPublicKeys")]
        public Output<object?> TokenSigningPublicKeys { get; private set; } = null!;


        /// <summary>
        /// Create a Authorizer resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Authorizer(string name, AuthorizerArgs args, CustomResourceOptions? options = null)
            : base("aws-native:iot:Authorizer", name, args ?? new AuthorizerArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Authorizer(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:iot:Authorizer", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing Authorizer resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Authorizer Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Authorizer(name, id, options);
        }
    }

    public sealed class AuthorizerArgs : Pulumi.ResourceArgs
    {
        [Input("authorizerFunctionArn", required: true)]
        public Input<string> AuthorizerFunctionArn { get; set; } = null!;

        [Input("authorizerName")]
        public Input<string>? AuthorizerName { get; set; }

        [Input("signingDisabled")]
        public Input<bool>? SigningDisabled { get; set; }

        [Input("status")]
        public Input<string>? Status { get; set; }

        [Input("tags")]
        private InputList<Inputs.AuthorizerTagArgs>? _tags;
        public InputList<Inputs.AuthorizerTagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.AuthorizerTagArgs>());
            set => _tags = value;
        }

        [Input("tokenKeyName")]
        public Input<string>? TokenKeyName { get; set; }

        [Input("tokenSigningPublicKeys")]
        public Input<object>? TokenSigningPublicKeys { get; set; }

        public AuthorizerArgs()
        {
        }
    }
}
