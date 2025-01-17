// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::EC2::TransitGatewayAttachment
 *
 * @deprecated TransitGatewayAttachment is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class TransitGatewayAttachment extends pulumi.CustomResource {
    /**
     * Get an existing TransitGatewayAttachment resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): TransitGatewayAttachment {
        pulumi.log.warn("TransitGatewayAttachment is deprecated: TransitGatewayAttachment is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new TransitGatewayAttachment(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:ec2:TransitGatewayAttachment';

    /**
     * Returns true if the given object is an instance of TransitGatewayAttachment.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is TransitGatewayAttachment {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === TransitGatewayAttachment.__pulumiType;
    }

    public readonly subnetIds!: pulumi.Output<string[]>;
    public readonly tags!: pulumi.Output<outputs.ec2.TransitGatewayAttachmentTag[] | undefined>;
    public readonly transitGatewayId!: pulumi.Output<string>;
    public readonly vpcId!: pulumi.Output<string>;

    /**
     * Create a TransitGatewayAttachment resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated TransitGatewayAttachment is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args: TransitGatewayAttachmentArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("TransitGatewayAttachment is deprecated: TransitGatewayAttachment is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.subnetIds === undefined) && !opts.urn) {
                throw new Error("Missing required property 'subnetIds'");
            }
            if ((!args || args.transitGatewayId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'transitGatewayId'");
            }
            if ((!args || args.vpcId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'vpcId'");
            }
            inputs["subnetIds"] = args ? args.subnetIds : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["transitGatewayId"] = args ? args.transitGatewayId : undefined;
            inputs["vpcId"] = args ? args.vpcId : undefined;
        } else {
            inputs["subnetIds"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["transitGatewayId"] = undefined /*out*/;
            inputs["vpcId"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(TransitGatewayAttachment.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a TransitGatewayAttachment resource.
 */
export interface TransitGatewayAttachmentArgs {
    subnetIds: pulumi.Input<pulumi.Input<string>[]>;
    tags?: pulumi.Input<pulumi.Input<inputs.ec2.TransitGatewayAttachmentTagArgs>[]>;
    transitGatewayId: pulumi.Input<string>;
    vpcId: pulumi.Input<string>;
}
