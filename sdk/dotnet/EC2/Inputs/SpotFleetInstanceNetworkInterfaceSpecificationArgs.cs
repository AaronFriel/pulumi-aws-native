// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.EC2.Inputs
{

    public sealed class SpotFleetInstanceNetworkInterfaceSpecificationArgs : Pulumi.ResourceArgs
    {
        [Input("associatePublicIpAddress")]
        public Input<bool>? AssociatePublicIpAddress { get; set; }

        [Input("deleteOnTermination")]
        public Input<bool>? DeleteOnTermination { get; set; }

        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("deviceIndex")]
        public Input<int>? DeviceIndex { get; set; }

        [Input("groups")]
        private InputList<string>? _groups;
        public InputList<string> Groups
        {
            get => _groups ?? (_groups = new InputList<string>());
            set => _groups = value;
        }

        [Input("ipv6AddressCount")]
        public Input<int>? Ipv6AddressCount { get; set; }

        [Input("ipv6Addresses")]
        private InputList<Inputs.SpotFleetInstanceIpv6AddressArgs>? _ipv6Addresses;
        public InputList<Inputs.SpotFleetInstanceIpv6AddressArgs> Ipv6Addresses
        {
            get => _ipv6Addresses ?? (_ipv6Addresses = new InputList<Inputs.SpotFleetInstanceIpv6AddressArgs>());
            set => _ipv6Addresses = value;
        }

        [Input("networkInterfaceId")]
        public Input<string>? NetworkInterfaceId { get; set; }

        [Input("privateIpAddresses")]
        private InputList<Inputs.SpotFleetPrivateIpAddressSpecificationArgs>? _privateIpAddresses;
        public InputList<Inputs.SpotFleetPrivateIpAddressSpecificationArgs> PrivateIpAddresses
        {
            get => _privateIpAddresses ?? (_privateIpAddresses = new InputList<Inputs.SpotFleetPrivateIpAddressSpecificationArgs>());
            set => _privateIpAddresses = value;
        }

        [Input("secondaryPrivateIpAddressCount")]
        public Input<int>? SecondaryPrivateIpAddressCount { get; set; }

        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        public SpotFleetInstanceNetworkInterfaceSpecificationArgs()
        {
        }
    }
}
