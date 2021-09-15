// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Route53RecoveryReadiness
{
    /// <summary>
    /// AWS Route53 Recovery Readiness Recovery Group Schema and API specifications.
    /// </summary>
    [AwsNativeResourceType("aws-native:route53recoveryreadiness:RecoveryGroup")]
    public partial class RecoveryGroup : Pulumi.CustomResource
    {
        /// <summary>
        /// A list of the cell Amazon Resource Names (ARNs) in the recovery group.
        /// </summary>
        [Output("cells")]
        public Output<ImmutableArray<string>> Cells { get; private set; } = null!;

        /// <summary>
        /// A collection of tags associated with a resource.
        /// </summary>
        [Output("recoveryGroupArn")]
        public Output<string> RecoveryGroupArn { get; private set; } = null!;

        /// <summary>
        /// The name of the recovery group to create.
        /// </summary>
        [Output("recoveryGroupName")]
        public Output<string> RecoveryGroupName { get; private set; } = null!;

        /// <summary>
        /// A collection of tags associated with a resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableArray<Outputs.RecoveryGroupTag>> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a RecoveryGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public RecoveryGroup(string name, RecoveryGroupArgs args, CustomResourceOptions? options = null)
            : base("aws-native:route53recoveryreadiness:RecoveryGroup", name, args ?? new RecoveryGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private RecoveryGroup(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:route53recoveryreadiness:RecoveryGroup", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing RecoveryGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static RecoveryGroup Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new RecoveryGroup(name, id, options);
        }
    }

    public sealed class RecoveryGroupArgs : Pulumi.ResourceArgs
    {
        [Input("cells")]
        private InputList<string>? _cells;

        /// <summary>
        /// A list of the cell Amazon Resource Names (ARNs) in the recovery group.
        /// </summary>
        public InputList<string> Cells
        {
            get => _cells ?? (_cells = new InputList<string>());
            set => _cells = value;
        }

        /// <summary>
        /// The name of the recovery group to create.
        /// </summary>
        [Input("recoveryGroupName", required: true)]
        public Input<string> RecoveryGroupName { get; set; } = null!;

        [Input("tags")]
        private InputList<Inputs.RecoveryGroupTagArgs>? _tags;

        /// <summary>
        /// A collection of tags associated with a resource.
        /// </summary>
        public InputList<Inputs.RecoveryGroupTagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.RecoveryGroupTagArgs>());
            set => _tags = value;
        }

        public RecoveryGroupArgs()
        {
        }
    }
}
