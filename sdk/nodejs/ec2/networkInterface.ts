// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * The AWS::EC2::NetworkInterface resource creates network interface
 */
export class NetworkInterface extends pulumi.CustomResource {
    /**
     * Get an existing NetworkInterface resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): NetworkInterface {
        return new NetworkInterface(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:ec2:NetworkInterface';

    /**
     * Returns true if the given object is an instance of NetworkInterface.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is NetworkInterface {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === NetworkInterface.__pulumiType;
    }

    /**
     * A description for the network interface.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * A list of security group IDs associated with this network interface.
     */
    public readonly groupSet!: pulumi.Output<string[] | undefined>;
    /**
     * Indicates the type of network interface.
     */
    public readonly interfaceType!: pulumi.Output<string | undefined>;
    /**
     * The number of IPv6 addresses to assign to a network interface. Amazon EC2 automatically selects the IPv6 addresses from the subnet range. To specify specific IPv6 addresses, use the Ipv6Addresses property and don't specify this property.
     */
    public readonly ipv6AddressCount!: pulumi.Output<number | undefined>;
    /**
     * One or more specific IPv6 addresses from the IPv6 CIDR block range of your subnet to associate with the network interface. If you're specifying a number of IPv6 addresses, use the Ipv6AddressCount property and don't specify this property.
     */
    public readonly ipv6Addresses!: pulumi.Output<outputs.ec2.NetworkInterfaceInstanceIpv6Address[] | undefined>;
    /**
     * Returns the primary private IP address of the network interface.
     */
    public /*out*/ readonly primaryPrivateIpAddress!: pulumi.Output<string>;
    /**
     * Assigns a single private IP address to the network interface, which is used as the primary private IP address. If you want to specify multiple private IP address, use the PrivateIpAddresses property. 
     */
    public readonly privateIpAddress!: pulumi.Output<string | undefined>;
    /**
     * Assigns a list of private IP addresses to the network interface. You can specify a primary private IP address by setting the value of the Primary property to true in the PrivateIpAddressSpecification property. If you want EC2 to automatically assign private IP addresses, use the SecondaryPrivateIpAddressCount property and do not specify this property.
     */
    public readonly privateIpAddresses!: pulumi.Output<outputs.ec2.NetworkInterfacePrivateIpAddressSpecification[] | undefined>;
    /**
     * The number of secondary private IPv4 addresses to assign to a network interface. When you specify a number of secondary IPv4 addresses, Amazon EC2 selects these IP addresses within the subnet's IPv4 CIDR range. You can't specify this option and specify more than one private IP address using privateIpAddresses
     */
    public readonly secondaryPrivateIpAddressCount!: pulumi.Output<number | undefined>;
    /**
     * Returns the secondary private IP addresses of the network interface.
     */
    public /*out*/ readonly secondaryPrivateIpAddresses!: pulumi.Output<string[]>;
    /**
     * Indicates whether traffic to or from the instance is validated.
     */
    public readonly sourceDestCheck!: pulumi.Output<boolean | undefined>;
    /**
     * The ID of the subnet to associate with the network interface.
     */
    public readonly subnetId!: pulumi.Output<string>;
    /**
     * An arbitrary set of tags (key-value pairs) for this network interface.
     */
    public readonly tags!: pulumi.Output<outputs.ec2.NetworkInterfaceTag[] | undefined>;

    /**
     * Create a NetworkInterface resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: NetworkInterfaceArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.subnetId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'subnetId'");
            }
            inputs["description"] = args ? args.description : undefined;
            inputs["groupSet"] = args ? args.groupSet : undefined;
            inputs["interfaceType"] = args ? args.interfaceType : undefined;
            inputs["ipv6AddressCount"] = args ? args.ipv6AddressCount : undefined;
            inputs["ipv6Addresses"] = args ? args.ipv6Addresses : undefined;
            inputs["privateIpAddress"] = args ? args.privateIpAddress : undefined;
            inputs["privateIpAddresses"] = args ? args.privateIpAddresses : undefined;
            inputs["secondaryPrivateIpAddressCount"] = args ? args.secondaryPrivateIpAddressCount : undefined;
            inputs["sourceDestCheck"] = args ? args.sourceDestCheck : undefined;
            inputs["subnetId"] = args ? args.subnetId : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["primaryPrivateIpAddress"] = undefined /*out*/;
            inputs["secondaryPrivateIpAddresses"] = undefined /*out*/;
        } else {
            inputs["description"] = undefined /*out*/;
            inputs["groupSet"] = undefined /*out*/;
            inputs["interfaceType"] = undefined /*out*/;
            inputs["ipv6AddressCount"] = undefined /*out*/;
            inputs["ipv6Addresses"] = undefined /*out*/;
            inputs["primaryPrivateIpAddress"] = undefined /*out*/;
            inputs["privateIpAddress"] = undefined /*out*/;
            inputs["privateIpAddresses"] = undefined /*out*/;
            inputs["secondaryPrivateIpAddressCount"] = undefined /*out*/;
            inputs["secondaryPrivateIpAddresses"] = undefined /*out*/;
            inputs["sourceDestCheck"] = undefined /*out*/;
            inputs["subnetId"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(NetworkInterface.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a NetworkInterface resource.
 */
export interface NetworkInterfaceArgs {
    /**
     * A description for the network interface.
     */
    description?: pulumi.Input<string>;
    /**
     * A list of security group IDs associated with this network interface.
     */
    groupSet?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Indicates the type of network interface.
     */
    interfaceType?: pulumi.Input<string>;
    /**
     * The number of IPv6 addresses to assign to a network interface. Amazon EC2 automatically selects the IPv6 addresses from the subnet range. To specify specific IPv6 addresses, use the Ipv6Addresses property and don't specify this property.
     */
    ipv6AddressCount?: pulumi.Input<number>;
    /**
     * One or more specific IPv6 addresses from the IPv6 CIDR block range of your subnet to associate with the network interface. If you're specifying a number of IPv6 addresses, use the Ipv6AddressCount property and don't specify this property.
     */
    ipv6Addresses?: pulumi.Input<pulumi.Input<inputs.ec2.NetworkInterfaceInstanceIpv6AddressArgs>[]>;
    /**
     * Assigns a single private IP address to the network interface, which is used as the primary private IP address. If you want to specify multiple private IP address, use the PrivateIpAddresses property. 
     */
    privateIpAddress?: pulumi.Input<string>;
    /**
     * Assigns a list of private IP addresses to the network interface. You can specify a primary private IP address by setting the value of the Primary property to true in the PrivateIpAddressSpecification property. If you want EC2 to automatically assign private IP addresses, use the SecondaryPrivateIpAddressCount property and do not specify this property.
     */
    privateIpAddresses?: pulumi.Input<pulumi.Input<inputs.ec2.NetworkInterfacePrivateIpAddressSpecificationArgs>[]>;
    /**
     * The number of secondary private IPv4 addresses to assign to a network interface. When you specify a number of secondary IPv4 addresses, Amazon EC2 selects these IP addresses within the subnet's IPv4 CIDR range. You can't specify this option and specify more than one private IP address using privateIpAddresses
     */
    secondaryPrivateIpAddressCount?: pulumi.Input<number>;
    /**
     * Indicates whether traffic to or from the instance is validated.
     */
    sourceDestCheck?: pulumi.Input<boolean>;
    /**
     * The ID of the subnet to associate with the network interface.
     */
    subnetId: pulumi.Input<string>;
    /**
     * An arbitrary set of tags (key-value pairs) for this network interface.
     */
    tags?: pulumi.Input<pulumi.Input<inputs.ec2.NetworkInterfaceTagArgs>[]>;
}
