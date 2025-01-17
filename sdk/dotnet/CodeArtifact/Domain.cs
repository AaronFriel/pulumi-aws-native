// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CodeArtifact
{
    /// <summary>
    /// The resource schema to create a CodeArtifact domain.
    /// </summary>
    [AwsNativeResourceType("aws-native:codeartifact:Domain")]
    public partial class Domain : Pulumi.CustomResource
    {
        /// <summary>
        /// The ARN of the domain.
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// The name of the domain.
        /// </summary>
        [Output("domainName")]
        public Output<string> DomainName { get; private set; } = null!;

        /// <summary>
        /// The ARN of an AWS Key Management Service (AWS KMS) key associated with a domain.
        /// </summary>
        [Output("encryptionKey")]
        public Output<string> EncryptionKey { get; private set; } = null!;

        /// <summary>
        /// The name of the domain. This field is used for GetAtt
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The 12-digit account ID of the AWS account that owns the domain. This field is used for GetAtt
        /// </summary>
        [Output("owner")]
        public Output<string> Owner { get; private set; } = null!;

        /// <summary>
        /// The access control resource policy on the provided domain.
        /// </summary>
        [Output("permissionsPolicyDocument")]
        public Output<object?> PermissionsPolicyDocument { get; private set; } = null!;

        /// <summary>
        /// An array of key-value pairs to apply to this resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableArray<Outputs.DomainTag>> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a Domain resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Domain(string name, DomainArgs? args = null, CustomResourceOptions? options = null)
            : base("aws-native:codeartifact:Domain", name, args ?? new DomainArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Domain(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:codeartifact:Domain", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing Domain resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Domain Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Domain(name, id, options);
        }
    }

    public sealed class DomainArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the domain.
        /// </summary>
        [Input("domainName")]
        public Input<string>? DomainName { get; set; }

        /// <summary>
        /// The access control resource policy on the provided domain.
        /// </summary>
        [Input("permissionsPolicyDocument")]
        public Input<object>? PermissionsPolicyDocument { get; set; }

        [Input("tags")]
        private InputList<Inputs.DomainTagArgs>? _tags;

        /// <summary>
        /// An array of key-value pairs to apply to this resource.
        /// </summary>
        public InputList<Inputs.DomainTagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.DomainTagArgs>());
            set => _tags = value;
        }

        public DomainArgs()
        {
        }
    }
}
