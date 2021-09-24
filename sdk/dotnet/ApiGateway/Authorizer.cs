// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ApiGateway
{
    /// <summary>
    /// Resource Type definition for AWS::ApiGateway::Authorizer
    /// </summary>
    [Obsolete(@"Authorizer is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.")]
    [AwsNativeResourceType("aws-native:apigateway:Authorizer")]
    public partial class Authorizer : Pulumi.CustomResource
    {
        [Output("authType")]
        public Output<string?> AuthType { get; private set; } = null!;

        [Output("authorizerCredentials")]
        public Output<string?> AuthorizerCredentials { get; private set; } = null!;

        [Output("authorizerResultTtlInSeconds")]
        public Output<int?> AuthorizerResultTtlInSeconds { get; private set; } = null!;

        [Output("authorizerUri")]
        public Output<string?> AuthorizerUri { get; private set; } = null!;

        [Output("identitySource")]
        public Output<string?> IdentitySource { get; private set; } = null!;

        [Output("identityValidationExpression")]
        public Output<string?> IdentityValidationExpression { get; private set; } = null!;

        [Output("name")]
        public Output<string?> Name { get; private set; } = null!;

        [Output("providerARNs")]
        public Output<ImmutableArray<string>> ProviderARNs { get; private set; } = null!;

        [Output("restApiId")]
        public Output<string> RestApiId { get; private set; } = null!;

        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a Authorizer resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Authorizer(string name, AuthorizerArgs args, CustomResourceOptions? options = null)
            : base("aws-native:apigateway:Authorizer", name, args ?? new AuthorizerArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Authorizer(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:apigateway:Authorizer", name, null, MakeResourceOptions(options, id))
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
        [Input("authType")]
        public Input<string>? AuthType { get; set; }

        [Input("authorizerCredentials")]
        public Input<string>? AuthorizerCredentials { get; set; }

        [Input("authorizerResultTtlInSeconds")]
        public Input<int>? AuthorizerResultTtlInSeconds { get; set; }

        [Input("authorizerUri")]
        public Input<string>? AuthorizerUri { get; set; }

        [Input("identitySource")]
        public Input<string>? IdentitySource { get; set; }

        [Input("identityValidationExpression")]
        public Input<string>? IdentityValidationExpression { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("providerARNs")]
        private InputList<string>? _providerARNs;
        public InputList<string> ProviderARNs
        {
            get => _providerARNs ?? (_providerARNs = new InputList<string>());
            set => _providerARNs = value;
        }

        [Input("restApiId", required: true)]
        public Input<string> RestApiId { get; set; } = null!;

        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public AuthorizerArgs()
        {
        }
    }
}