// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.MediaConnect
{
    /// <summary>
    /// Resource schema for AWS::MediaConnect::FlowSource
    /// </summary>
    [AwsNativeResourceType("aws-native:mediaconnect:FlowSource")]
    public partial class FlowSource : Pulumi.CustomResource
    {
        /// <summary>
        /// The type of encryption that is used on the content ingested from this source.
        /// </summary>
        [Output("decryption")]
        public Output<Outputs.FlowSourceEncryption?> Decryption { get; private set; } = null!;

        /// <summary>
        /// A description for the source. This value is not used or seen outside of the current AWS Elemental MediaConnect account.
        /// </summary>
        [Output("description")]
        public Output<string> Description { get; private set; } = null!;

        /// <summary>
        /// The ARN of the entitlement that allows you to subscribe to content that comes from another AWS account. The entitlement is set by the content originator and the ARN is generated as part of the originator's flow.
        /// </summary>
        [Output("entitlementArn")]
        public Output<string?> EntitlementArn { get; private set; } = null!;

        /// <summary>
        /// The ARN of the flow.
        /// </summary>
        [Output("flowArn")]
        public Output<string?> FlowArn { get; private set; } = null!;

        /// <summary>
        /// The IP address that the flow will be listening on for incoming content.
        /// </summary>
        [Output("ingestIp")]
        public Output<string> IngestIp { get; private set; } = null!;

        /// <summary>
        /// The port that the flow will be listening on for incoming content.
        /// </summary>
        [Output("ingestPort")]
        public Output<int?> IngestPort { get; private set; } = null!;

        /// <summary>
        /// The smoothing max bitrate for RIST, RTP, and RTP-FEC streams.
        /// </summary>
        [Output("maxBitrate")]
        public Output<int?> MaxBitrate { get; private set; } = null!;

        /// <summary>
        /// The maximum latency in milliseconds. This parameter applies only to RIST-based and Zixi-based streams.
        /// </summary>
        [Output("maxLatency")]
        public Output<int?> MaxLatency { get; private set; } = null!;

        /// <summary>
        /// The name of the source.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The protocol that is used by the source.
        /// </summary>
        [Output("protocol")]
        public Output<string?> Protocol { get; private set; } = null!;

        /// <summary>
        /// The ARN of the source.
        /// </summary>
        [Output("sourceArn")]
        public Output<string> SourceArn { get; private set; } = null!;

        /// <summary>
        /// The stream ID that you want to use for this transport. This parameter applies only to Zixi-based streams.
        /// </summary>
        [Output("streamId")]
        public Output<string?> StreamId { get; private set; } = null!;

        /// <summary>
        /// The name of the VPC Interface this Source is configured with.
        /// </summary>
        [Output("vpcInterfaceName")]
        public Output<string?> VpcInterfaceName { get; private set; } = null!;

        /// <summary>
        /// The range of IP addresses that should be allowed to contribute content to your source. These IP addresses should be in the form of a Classless Inter-Domain Routing (CIDR) block; for example, 10.0.0.0/16.
        /// </summary>
        [Output("whitelistCidr")]
        public Output<string?> WhitelistCidr { get; private set; } = null!;


        /// <summary>
        /// Create a FlowSource resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public FlowSource(string name, FlowSourceArgs args, CustomResourceOptions? options = null)
            : base("aws-native:mediaconnect:FlowSource", name, args ?? new FlowSourceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private FlowSource(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:mediaconnect:FlowSource", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing FlowSource resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static FlowSource Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new FlowSource(name, id, options);
        }
    }

    public sealed class FlowSourceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The type of encryption that is used on the content ingested from this source.
        /// </summary>
        [Input("decryption")]
        public Input<Inputs.FlowSourceEncryptionArgs>? Decryption { get; set; }

        /// <summary>
        /// A description for the source. This value is not used or seen outside of the current AWS Elemental MediaConnect account.
        /// </summary>
        [Input("description", required: true)]
        public Input<string> Description { get; set; } = null!;

        /// <summary>
        /// The ARN of the entitlement that allows you to subscribe to content that comes from another AWS account. The entitlement is set by the content originator and the ARN is generated as part of the originator's flow.
        /// </summary>
        [Input("entitlementArn")]
        public Input<string>? EntitlementArn { get; set; }

        /// <summary>
        /// The ARN of the flow.
        /// </summary>
        [Input("flowArn")]
        public Input<string>? FlowArn { get; set; }

        /// <summary>
        /// The port that the flow will be listening on for incoming content.
        /// </summary>
        [Input("ingestPort")]
        public Input<int>? IngestPort { get; set; }

        /// <summary>
        /// The smoothing max bitrate for RIST, RTP, and RTP-FEC streams.
        /// </summary>
        [Input("maxBitrate")]
        public Input<int>? MaxBitrate { get; set; }

        /// <summary>
        /// The maximum latency in milliseconds. This parameter applies only to RIST-based and Zixi-based streams.
        /// </summary>
        [Input("maxLatency")]
        public Input<int>? MaxLatency { get; set; }

        /// <summary>
        /// The name of the source.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The protocol that is used by the source.
        /// </summary>
        [Input("protocol")]
        public Input<string>? Protocol { get; set; }

        /// <summary>
        /// The stream ID that you want to use for this transport. This parameter applies only to Zixi-based streams.
        /// </summary>
        [Input("streamId")]
        public Input<string>? StreamId { get; set; }

        /// <summary>
        /// The name of the VPC Interface this Source is configured with.
        /// </summary>
        [Input("vpcInterfaceName")]
        public Input<string>? VpcInterfaceName { get; set; }

        /// <summary>
        /// The range of IP addresses that should be allowed to contribute content to your source. These IP addresses should be in the form of a Classless Inter-Domain Routing (CIDR) block; for example, 10.0.0.0/16.
        /// </summary>
        [Input("whitelistCidr")]
        public Input<string>? WhitelistCidr { get; set; }

        public FlowSourceArgs()
        {
        }
    }
}
