// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppConfig
{
    /// <summary>
    /// Resource Type definition for AWS::AppConfig::Environment
    /// </summary>
    [Obsolete(@"Environment is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")]
    [AwsNativeResourceType("aws-native:appconfig:Environment")]
    public partial class Environment : Pulumi.CustomResource
    {
        [Output("applicationId")]
        public Output<string> ApplicationId { get; private set; } = null!;

        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        [Output("monitors")]
        public Output<ImmutableArray<Outputs.EnvironmentMonitors>> Monitors { get; private set; } = null!;

        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("tags")]
        public Output<ImmutableArray<Outputs.EnvironmentTags>> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a Environment resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Environment(string name, EnvironmentArgs args, CustomResourceOptions? options = null)
            : base("aws-native:appconfig:Environment", name, args ?? new EnvironmentArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Environment(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:appconfig:Environment", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing Environment resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Environment Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Environment(name, id, options);
        }
    }

    public sealed class EnvironmentArgs : Pulumi.ResourceArgs
    {
        [Input("applicationId", required: true)]
        public Input<string> ApplicationId { get; set; } = null!;

        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("monitors")]
        private InputList<Inputs.EnvironmentMonitorsArgs>? _monitors;
        public InputList<Inputs.EnvironmentMonitorsArgs> Monitors
        {
            get => _monitors ?? (_monitors = new InputList<Inputs.EnvironmentMonitorsArgs>());
            set => _monitors = value;
        }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("tags")]
        private InputList<Inputs.EnvironmentTagsArgs>? _tags;
        public InputList<Inputs.EnvironmentTagsArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.EnvironmentTagsArgs>());
            set => _tags = value;
        }

        public EnvironmentArgs()
        {
        }
    }
}
