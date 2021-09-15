// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.EMRContainers
{
    /// <summary>
    /// Resource Schema of AWS::EMRContainers::VirtualCluster Type
    /// </summary>
    [AwsNativeResourceType("aws-native:emrcontainers:VirtualCluster")]
    public partial class VirtualCluster : Pulumi.CustomResource
    {
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// Container provider of the virtual cluster.
        /// </summary>
        [Output("containerProvider")]
        public Output<Outputs.VirtualClusterContainerProvider> ContainerProvider { get; private set; } = null!;

        /// <summary>
        /// Name of the virtual cluster.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// An array of key-value pairs to apply to this virtual cluster.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableArray<Outputs.VirtualClusterTag>> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a VirtualCluster resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public VirtualCluster(string name, VirtualClusterArgs args, CustomResourceOptions? options = null)
            : base("aws-native:emrcontainers:VirtualCluster", name, args ?? new VirtualClusterArgs(), MakeResourceOptions(options, ""))
        {
        }

        private VirtualCluster(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:emrcontainers:VirtualCluster", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing VirtualCluster resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static VirtualCluster Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new VirtualCluster(name, id, options);
        }
    }

    public sealed class VirtualClusterArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Container provider of the virtual cluster.
        /// </summary>
        [Input("containerProvider", required: true)]
        public Input<Inputs.VirtualClusterContainerProviderArgs> ContainerProvider { get; set; } = null!;

        /// <summary>
        /// Name of the virtual cluster.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("tags")]
        private InputList<Inputs.VirtualClusterTagArgs>? _tags;

        /// <summary>
        /// An array of key-value pairs to apply to this virtual cluster.
        /// </summary>
        public InputList<Inputs.VirtualClusterTagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.VirtualClusterTagArgs>());
            set => _tags = value;
        }

        public VirtualClusterArgs()
        {
        }
    }
}
