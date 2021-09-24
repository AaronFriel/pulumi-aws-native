// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CodeCommit
{
    /// <summary>
    /// Resource Type definition for AWS::CodeCommit::Repository
    /// </summary>
    [Obsolete(@"Repository is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")]
    [AwsNativeResourceType("aws-native:codecommit:Repository")]
    public partial class Repository : Pulumi.CustomResource
    {
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        [Output("cloneUrlHttp")]
        public Output<string> CloneUrlHttp { get; private set; } = null!;

        [Output("cloneUrlSsh")]
        public Output<string> CloneUrlSsh { get; private set; } = null!;

        [Output("code")]
        public Output<Outputs.RepositoryCode?> Code { get; private set; } = null!;

        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("repositoryDescription")]
        public Output<string?> RepositoryDescription { get; private set; } = null!;

        [Output("repositoryName")]
        public Output<string> RepositoryName { get; private set; } = null!;

        [Output("tags")]
        public Output<ImmutableArray<Outputs.RepositoryTag>> Tags { get; private set; } = null!;

        [Output("triggers")]
        public Output<ImmutableArray<Outputs.RepositoryRepositoryTrigger>> Triggers { get; private set; } = null!;


        /// <summary>
        /// Create a Repository resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Repository(string name, RepositoryArgs args, CustomResourceOptions? options = null)
            : base("aws-native:codecommit:Repository", name, args ?? new RepositoryArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Repository(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:codecommit:Repository", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing Repository resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Repository Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Repository(name, id, options);
        }
    }

    public sealed class RepositoryArgs : Pulumi.ResourceArgs
    {
        [Input("code")]
        public Input<Inputs.RepositoryCodeArgs>? Code { get; set; }

        [Input("repositoryDescription")]
        public Input<string>? RepositoryDescription { get; set; }

        [Input("repositoryName", required: true)]
        public Input<string> RepositoryName { get; set; } = null!;

        [Input("tags")]
        private InputList<Inputs.RepositoryTagArgs>? _tags;
        public InputList<Inputs.RepositoryTagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.RepositoryTagArgs>());
            set => _tags = value;
        }

        [Input("triggers")]
        private InputList<Inputs.RepositoryRepositoryTriggerArgs>? _triggers;
        public InputList<Inputs.RepositoryRepositoryTriggerArgs> Triggers
        {
            get => _triggers ?? (_triggers = new InputList<Inputs.RepositoryRepositoryTriggerArgs>());
            set => _triggers = value;
        }

        public RepositoryArgs()
        {
        }
    }
}
