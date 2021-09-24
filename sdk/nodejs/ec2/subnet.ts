// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::EC2::Subnet
 *
 * @deprecated Subnet is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class Subnet extends pulumi.CustomResource {
    /**
     * Get an existing Subnet resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Subnet {
        pulumi.log.warn("Subnet is deprecated: Subnet is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new Subnet(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:ec2:Subnet';

    /**
     * Returns true if the given object is an instance of Subnet.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Subnet {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Subnet.__pulumiType;
    }

    public readonly assignIpv6AddressOnCreation!: pulumi.Output<boolean | undefined>;
    public readonly availabilityZone!: pulumi.Output<string | undefined>;
    public readonly cidrBlock!: pulumi.Output<string>;
    public readonly ipv6CidrBlock!: pulumi.Output<string | undefined>;
    public /*out*/ readonly ipv6CidrBlocks!: pulumi.Output<string[]>;
    public readonly mapPublicIpOnLaunch!: pulumi.Output<boolean | undefined>;
    public /*out*/ readonly networkAclAssociationId!: pulumi.Output<string>;
    public readonly outpostArn!: pulumi.Output<string | undefined>;
    public readonly tags!: pulumi.Output<outputs.ec2.SubnetTag[] | undefined>;
    public readonly vpcId!: pulumi.Output<string>;

    /**
     * Create a Subnet resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Subnet is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args: SubnetArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("Subnet is deprecated: Subnet is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.cidrBlock === undefined) && !opts.urn) {
                throw new Error("Missing required property 'cidrBlock'");
            }
            if ((!args || args.vpcId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'vpcId'");
            }
            inputs["assignIpv6AddressOnCreation"] = args ? args.assignIpv6AddressOnCreation : undefined;
            inputs["availabilityZone"] = args ? args.availabilityZone : undefined;
            inputs["cidrBlock"] = args ? args.cidrBlock : undefined;
            inputs["ipv6CidrBlock"] = args ? args.ipv6CidrBlock : undefined;
            inputs["mapPublicIpOnLaunch"] = args ? args.mapPublicIpOnLaunch : undefined;
            inputs["outpostArn"] = args ? args.outpostArn : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["vpcId"] = args ? args.vpcId : undefined;
            inputs["ipv6CidrBlocks"] = undefined /*out*/;
            inputs["networkAclAssociationId"] = undefined /*out*/;
        } else {
            inputs["assignIpv6AddressOnCreation"] = undefined /*out*/;
            inputs["availabilityZone"] = undefined /*out*/;
            inputs["cidrBlock"] = undefined /*out*/;
            inputs["ipv6CidrBlock"] = undefined /*out*/;
            inputs["ipv6CidrBlocks"] = undefined /*out*/;
            inputs["mapPublicIpOnLaunch"] = undefined /*out*/;
            inputs["networkAclAssociationId"] = undefined /*out*/;
            inputs["outpostArn"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["vpcId"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Subnet.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Subnet resource.
 */
export interface SubnetArgs {
    assignIpv6AddressOnCreation?: pulumi.Input<boolean>;
    availabilityZone?: pulumi.Input<string>;
    cidrBlock: pulumi.Input<string>;
    ipv6CidrBlock?: pulumi.Input<string>;
    mapPublicIpOnLaunch?: pulumi.Input<boolean>;
    outpostArn?: pulumi.Input<string>;
    tags?: pulumi.Input<pulumi.Input<inputs.ec2.SubnetTagArgs>[]>;
    vpcId: pulumi.Input<string>;
}