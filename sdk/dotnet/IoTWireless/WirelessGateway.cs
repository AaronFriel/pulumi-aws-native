// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoTWireless
{
    /// <summary>
    /// Create and manage wireless gateways, including LoRa gateways.
    /// </summary>
    [AwsNativeResourceType("aws-native:iotwireless:WirelessGateway")]
    public partial class WirelessGateway : Pulumi.CustomResource
    {
        /// <summary>
        /// Arn for Wireless Gateway. Returned upon successful create.
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// Description of Wireless Gateway.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The date and time when the most recent uplink was received.
        /// </summary>
        [Output("lastUplinkReceivedAt")]
        public Output<string?> LastUplinkReceivedAt { get; private set; } = null!;

        /// <summary>
        /// The combination of Package, Station and Model which represents the version of the LoRaWAN Wireless Gateway.
        /// </summary>
        [Output("loRaWAN")]
        public Output<Outputs.WirelessGatewayLoRaWANGateway> LoRaWAN { get; private set; } = null!;

        /// <summary>
        /// Name of Wireless Gateway.
        /// </summary>
        [Output("name")]
        public Output<string?> Name { get; private set; } = null!;

        /// <summary>
        /// A list of key-value pairs that contain metadata for the gateway.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableArray<Outputs.WirelessGatewayTag>> Tags { get; private set; } = null!;

        /// <summary>
        /// Thing Arn. Passed into Update to associate a Thing with the Wireless Gateway.
        /// </summary>
        [Output("thingArn")]
        public Output<string?> ThingArn { get; private set; } = null!;

        /// <summary>
        /// Thing Arn. If there is a Thing created, this can be returned with a Get call.
        /// </summary>
        [Output("thingName")]
        public Output<string> ThingName { get; private set; } = null!;


        /// <summary>
        /// Create a WirelessGateway resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public WirelessGateway(string name, WirelessGatewayArgs args, CustomResourceOptions? options = null)
            : base("aws-native:iotwireless:WirelessGateway", name, args ?? new WirelessGatewayArgs(), MakeResourceOptions(options, ""))
        {
        }

        private WirelessGateway(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:iotwireless:WirelessGateway", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing WirelessGateway resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static WirelessGateway Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new WirelessGateway(name, id, options);
        }
    }

    public sealed class WirelessGatewayArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Description of Wireless Gateway.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The date and time when the most recent uplink was received.
        /// </summary>
        [Input("lastUplinkReceivedAt")]
        public Input<string>? LastUplinkReceivedAt { get; set; }

        /// <summary>
        /// The combination of Package, Station and Model which represents the version of the LoRaWAN Wireless Gateway.
        /// </summary>
        [Input("loRaWAN", required: true)]
        public Input<Inputs.WirelessGatewayLoRaWANGatewayArgs> LoRaWAN { get; set; } = null!;

        /// <summary>
        /// Name of Wireless Gateway.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("tags")]
        private InputList<Inputs.WirelessGatewayTagArgs>? _tags;

        /// <summary>
        /// A list of key-value pairs that contain metadata for the gateway.
        /// </summary>
        public InputList<Inputs.WirelessGatewayTagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.WirelessGatewayTagArgs>());
            set => _tags = value;
        }

        /// <summary>
        /// Thing Arn. Passed into Update to associate a Thing with the Wireless Gateway.
        /// </summary>
        [Input("thingArn")]
        public Input<string>? ThingArn { get; set; }

        public WirelessGatewayArgs()
        {
        }
    }
}
