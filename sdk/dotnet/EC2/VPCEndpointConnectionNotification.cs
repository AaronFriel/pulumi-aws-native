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
    /// Resource Type definition for AWS::EC2::VPCEndpointConnectionNotification
    /// </summary>
    [Obsolete(@"VPCEndpointConnectionNotification is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")]
    [AwsNativeResourceType("aws-native:ec2:VPCEndpointConnectionNotification")]
    public partial class VPCEndpointConnectionNotification : Pulumi.CustomResource
    {
        [Output("connectionEvents")]
        public Output<ImmutableArray<string>> ConnectionEvents { get; private set; } = null!;

        [Output("connectionNotificationArn")]
        public Output<string> ConnectionNotificationArn { get; private set; } = null!;

        [Output("serviceId")]
        public Output<string?> ServiceId { get; private set; } = null!;

        [Output("vPCEndpointId")]
        public Output<string?> VPCEndpointId { get; private set; } = null!;


        /// <summary>
        /// Create a VPCEndpointConnectionNotification resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public VPCEndpointConnectionNotification(string name, VPCEndpointConnectionNotificationArgs args, CustomResourceOptions? options = null)
            : base("aws-native:ec2:VPCEndpointConnectionNotification", name, args ?? new VPCEndpointConnectionNotificationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private VPCEndpointConnectionNotification(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:ec2:VPCEndpointConnectionNotification", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing VPCEndpointConnectionNotification resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static VPCEndpointConnectionNotification Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new VPCEndpointConnectionNotification(name, id, options);
        }
    }

    public sealed class VPCEndpointConnectionNotificationArgs : Pulumi.ResourceArgs
    {
        [Input("connectionEvents", required: true)]
        private InputList<string>? _connectionEvents;
        public InputList<string> ConnectionEvents
        {
            get => _connectionEvents ?? (_connectionEvents = new InputList<string>());
            set => _connectionEvents = value;
        }

        [Input("connectionNotificationArn", required: true)]
        public Input<string> ConnectionNotificationArn { get; set; } = null!;

        [Input("serviceId")]
        public Input<string>? ServiceId { get; set; }

        [Input("vPCEndpointId")]
        public Input<string>? VPCEndpointId { get; set; }

        public VPCEndpointConnectionNotificationArgs()
        {
        }
    }
}
