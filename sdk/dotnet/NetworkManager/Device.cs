// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.NetworkManager
{
    /// <summary>
    /// The AWS::NetworkManager::Device type describes a device.
    /// </summary>
    [AwsNativeResourceType("aws-native:networkmanager:Device")]
    public partial class Device : Pulumi.CustomResource
    {
        /// <summary>
        /// The description of the device.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The Amazon Resource Name (ARN) of the device.
        /// </summary>
        [Output("deviceArn")]
        public Output<string> DeviceArn { get; private set; } = null!;

        /// <summary>
        /// The ID of the device.
        /// </summary>
        [Output("deviceId")]
        public Output<string> DeviceId { get; private set; } = null!;

        /// <summary>
        /// The ID of the global network.
        /// </summary>
        [Output("globalNetworkId")]
        public Output<string> GlobalNetworkId { get; private set; } = null!;

        /// <summary>
        /// The site location.
        /// </summary>
        [Output("location")]
        public Output<Outputs.DeviceLocation?> Location { get; private set; } = null!;

        /// <summary>
        /// The device model
        /// </summary>
        [Output("model")]
        public Output<string?> Model { get; private set; } = null!;

        /// <summary>
        /// The device serial number.
        /// </summary>
        [Output("serialNumber")]
        public Output<string?> SerialNumber { get; private set; } = null!;

        /// <summary>
        /// The site ID.
        /// </summary>
        [Output("siteId")]
        public Output<string?> SiteId { get; private set; } = null!;

        /// <summary>
        /// The tags for the device.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableArray<Outputs.DeviceTag>> Tags { get; private set; } = null!;

        /// <summary>
        /// The device type.
        /// </summary>
        [Output("type")]
        public Output<string?> Type { get; private set; } = null!;

        /// <summary>
        /// The device vendor.
        /// </summary>
        [Output("vendor")]
        public Output<string?> Vendor { get; private set; } = null!;


        /// <summary>
        /// Create a Device resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Device(string name, DeviceArgs args, CustomResourceOptions? options = null)
            : base("aws-native:networkmanager:Device", name, args ?? new DeviceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Device(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:networkmanager:Device", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing Device resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Device Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Device(name, id, options);
        }
    }

    public sealed class DeviceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The description of the device.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The ID of the global network.
        /// </summary>
        [Input("globalNetworkId", required: true)]
        public Input<string> GlobalNetworkId { get; set; } = null!;

        /// <summary>
        /// The site location.
        /// </summary>
        [Input("location")]
        public Input<Inputs.DeviceLocationArgs>? Location { get; set; }

        /// <summary>
        /// The device model
        /// </summary>
        [Input("model")]
        public Input<string>? Model { get; set; }

        /// <summary>
        /// The device serial number.
        /// </summary>
        [Input("serialNumber")]
        public Input<string>? SerialNumber { get; set; }

        /// <summary>
        /// The site ID.
        /// </summary>
        [Input("siteId")]
        public Input<string>? SiteId { get; set; }

        [Input("tags")]
        private InputList<Inputs.DeviceTagArgs>? _tags;

        /// <summary>
        /// The tags for the device.
        /// </summary>
        public InputList<Inputs.DeviceTagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.DeviceTagArgs>());
            set => _tags = value;
        }

        /// <summary>
        /// The device type.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// The device vendor.
        /// </summary>
        [Input("vendor")]
        public Input<string>? Vendor { get; set; }

        public DeviceArgs()
        {
        }
    }
}
