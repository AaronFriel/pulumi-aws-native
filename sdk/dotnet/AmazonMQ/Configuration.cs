// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AmazonMQ
{
    /// <summary>
    /// Resource Type definition for AWS::AmazonMQ::Configuration
    /// </summary>
    [Obsolete(@"Configuration is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")]
    [AwsNativeResourceType("aws-native:amazonmq:Configuration")]
    public partial class Configuration : Pulumi.CustomResource
    {
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        [Output("authenticationStrategy")]
        public Output<string?> AuthenticationStrategy { get; private set; } = null!;

        [Output("data")]
        public Output<string> Data { get; private set; } = null!;

        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        [Output("engineType")]
        public Output<string> EngineType { get; private set; } = null!;

        [Output("engineVersion")]
        public Output<string> EngineVersion { get; private set; } = null!;

        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("revision")]
        public Output<int> Revision { get; private set; } = null!;

        [Output("tags")]
        public Output<ImmutableArray<Outputs.ConfigurationTagsEntry>> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a Configuration resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Configuration(string name, ConfigurationArgs args, CustomResourceOptions? options = null)
            : base("aws-native:amazonmq:Configuration", name, args ?? new ConfigurationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Configuration(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:amazonmq:Configuration", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing Configuration resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Configuration Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Configuration(name, id, options);
        }
    }

    public sealed class ConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("authenticationStrategy")]
        public Input<string>? AuthenticationStrategy { get; set; }

        [Input("data", required: true)]
        public Input<string> Data { get; set; } = null!;

        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("engineType", required: true)]
        public Input<string> EngineType { get; set; } = null!;

        [Input("engineVersion", required: true)]
        public Input<string> EngineVersion { get; set; } = null!;

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("tags")]
        private InputList<Inputs.ConfigurationTagsEntryArgs>? _tags;
        public InputList<Inputs.ConfigurationTagsEntryArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.ConfigurationTagsEntryArgs>());
            set => _tags = value;
        }

        public ConfigurationArgs()
        {
        }
    }
}
