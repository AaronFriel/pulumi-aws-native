// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Route53RecoveryReadiness
{
    /// <summary>
    /// The API Schema for AWS Route53 Recovery Readiness Cells.
    /// </summary>
    [AwsNativeResourceType("aws-native:route53recoveryreadiness:Cell")]
    public partial class Cell : Pulumi.CustomResource
    {
        /// <summary>
        /// The Amazon Resource Name (ARN) of the cell.
        /// </summary>
        [Output("cellArn")]
        public Output<string> CellArn { get; private set; } = null!;

        /// <summary>
        /// The name of the cell to create.
        /// </summary>
        [Output("cellName")]
        public Output<string> CellName { get; private set; } = null!;

        /// <summary>
        /// A list of cell Amazon Resource Names (ARNs) contained within this cell, for use in nested cells. For example, Availability Zones within specific Regions.
        /// </summary>
        [Output("cells")]
        public Output<ImmutableArray<string>> Cells { get; private set; } = null!;

        /// <summary>
        /// The readiness scope for the cell, which can be a cell Amazon Resource Name (ARN) or a recovery group ARN. This is a list but currently can have only one element.
        /// </summary>
        [Output("parentReadinessScopes")]
        public Output<ImmutableArray<string>> ParentReadinessScopes { get; private set; } = null!;

        /// <summary>
        /// A collection of tags associated with a resource
        /// </summary>
        [Output("tags")]
        public Output<ImmutableArray<Outputs.CellTag>> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a Cell resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Cell(string name, CellArgs? args = null, CustomResourceOptions? options = null)
            : base("aws-native:route53recoveryreadiness:Cell", name, args ?? new CellArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Cell(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:route53recoveryreadiness:Cell", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing Cell resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Cell Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Cell(name, id, options);
        }
    }

    public sealed class CellArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the cell to create.
        /// </summary>
        [Input("cellName")]
        public Input<string>? CellName { get; set; }

        [Input("cells")]
        private InputList<string>? _cells;

        /// <summary>
        /// A list of cell Amazon Resource Names (ARNs) contained within this cell, for use in nested cells. For example, Availability Zones within specific Regions.
        /// </summary>
        public InputList<string> Cells
        {
            get => _cells ?? (_cells = new InputList<string>());
            set => _cells = value;
        }

        [Input("tags")]
        private InputList<Inputs.CellTagArgs>? _tags;

        /// <summary>
        /// A collection of tags associated with a resource
        /// </summary>
        public InputList<Inputs.CellTagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.CellTagArgs>());
            set => _tags = value;
        }

        public CellArgs()
        {
        }
    }
}
