// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.EC2
{
    /// <summary>
    /// Resource Type definition for AWS::EC2::CapacityReservation
    /// </summary>
    [Obsolete(@"CapacityReservation is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")]
    [AwsNativeResourceType("aws-native:ec2:CapacityReservation")]
    public partial class CapacityReservation : Pulumi.CustomResource
    {
        [Output("availabilityZone")]
        public Output<string> AvailabilityZone { get; private set; } = null!;

        [Output("availableInstanceCount")]
        public Output<int> AvailableInstanceCount { get; private set; } = null!;

        [Output("ebsOptimized")]
        public Output<bool?> EbsOptimized { get; private set; } = null!;

        [Output("endDate")]
        public Output<string?> EndDate { get; private set; } = null!;

        [Output("endDateType")]
        public Output<string?> EndDateType { get; private set; } = null!;

        [Output("ephemeralStorage")]
        public Output<bool?> EphemeralStorage { get; private set; } = null!;

        [Output("instanceCount")]
        public Output<int> InstanceCount { get; private set; } = null!;

        [Output("instanceMatchCriteria")]
        public Output<string?> InstanceMatchCriteria { get; private set; } = null!;

        [Output("instancePlatform")]
        public Output<string> InstancePlatform { get; private set; } = null!;

        [Output("instanceType")]
        public Output<string> InstanceType { get; private set; } = null!;

        [Output("tagSpecifications")]
        public Output<ImmutableArray<Outputs.CapacityReservationTagSpecification>> TagSpecifications { get; private set; } = null!;

        [Output("tenancy")]
        public Output<string?> Tenancy { get; private set; } = null!;

        [Output("totalInstanceCount")]
        public Output<int> TotalInstanceCount { get; private set; } = null!;


        /// <summary>
        /// Create a CapacityReservation resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CapacityReservation(string name, CapacityReservationArgs args, CustomResourceOptions? options = null)
            : base("aws-native:ec2:CapacityReservation", name, args ?? new CapacityReservationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private CapacityReservation(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:ec2:CapacityReservation", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing CapacityReservation resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CapacityReservation Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new CapacityReservation(name, id, options);
        }
    }

    public sealed class CapacityReservationArgs : Pulumi.ResourceArgs
    {
        [Input("availabilityZone", required: true)]
        public Input<string> AvailabilityZone { get; set; } = null!;

        [Input("ebsOptimized")]
        public Input<bool>? EbsOptimized { get; set; }

        [Input("endDate")]
        public Input<string>? EndDate { get; set; }

        [Input("endDateType")]
        public Input<string>? EndDateType { get; set; }

        [Input("ephemeralStorage")]
        public Input<bool>? EphemeralStorage { get; set; }

        [Input("instanceCount", required: true)]
        public Input<int> InstanceCount { get; set; } = null!;

        [Input("instanceMatchCriteria")]
        public Input<string>? InstanceMatchCriteria { get; set; }

        [Input("instancePlatform", required: true)]
        public Input<string> InstancePlatform { get; set; } = null!;

        [Input("instanceType", required: true)]
        public Input<string> InstanceType { get; set; } = null!;

        [Input("tagSpecifications")]
        private InputList<Inputs.CapacityReservationTagSpecificationArgs>? _tagSpecifications;
        public InputList<Inputs.CapacityReservationTagSpecificationArgs> TagSpecifications
        {
            get => _tagSpecifications ?? (_tagSpecifications = new InputList<Inputs.CapacityReservationTagSpecificationArgs>());
            set => _tagSpecifications = value;
        }

        [Input("tenancy")]
        public Input<string>? Tenancy { get; set; }

        public CapacityReservationArgs()
        {
        }
    }
}
