// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.RefactorSpaces
{
    /// <summary>
    /// Definition of AWS::RefactorSpaces::Environment Resource Type
    /// </summary>
    [AwsNativeResourceType("aws-native:refactorspaces:Environment")]
    public partial class Environment : Pulumi.CustomResource
    {
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        [Output("environmentIdentifier")]
        public Output<string> EnvironmentIdentifier { get; private set; } = null!;

        [Output("name")]
        public Output<string?> Name { get; private set; } = null!;

        [Output("networkFabricType")]
        public Output<Pulumi.AwsNative.RefactorSpaces.EnvironmentNetworkFabricType?> NetworkFabricType { get; private set; } = null!;

        /// <summary>
        /// Metadata that you can assign to help organize the frameworks that you create. Each tag is a key-value pair.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableArray<Outputs.EnvironmentTag>> Tags { get; private set; } = null!;

        [Output("transitGatewayId")]
        public Output<string> TransitGatewayId { get; private set; } = null!;


        /// <summary>
        /// Create a Environment resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Environment(string name, EnvironmentArgs? args = null, CustomResourceOptions? options = null)
            : base("aws-native:refactorspaces:Environment", name, args ?? new EnvironmentArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Environment(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:refactorspaces:Environment", name, null, MakeResourceOptions(options, id))
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
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("networkFabricType")]
        public Input<Pulumi.AwsNative.RefactorSpaces.EnvironmentNetworkFabricType>? NetworkFabricType { get; set; }

        [Input("tags")]
        private InputList<Inputs.EnvironmentTagArgs>? _tags;

        /// <summary>
        /// Metadata that you can assign to help organize the frameworks that you create. Each tag is a key-value pair.
        /// </summary>
        public InputList<Inputs.EnvironmentTagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.EnvironmentTagArgs>());
            set => _tags = value;
        }

        public EnvironmentArgs()
        {
        }
    }
}
