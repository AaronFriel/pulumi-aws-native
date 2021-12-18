// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::EC2::EIP
 *
 * @deprecated EIP is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class EIP extends pulumi.CustomResource {
    /**
     * Get an existing EIP resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): EIP {
        pulumi.log.warn("EIP is deprecated: EIP is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new EIP(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:ec2:EIP';

    /**
     * Returns true if the given object is an instance of EIP.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is EIP {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === EIP.__pulumiType;
    }

    public /*out*/ readonly allocationId!: pulumi.Output<string>;
    public readonly domain!: pulumi.Output<string | undefined>;
    public readonly instanceId!: pulumi.Output<string | undefined>;
    public readonly publicIpv4Pool!: pulumi.Output<string | undefined>;
    public readonly tags!: pulumi.Output<outputs.ec2.EIPTag[] | undefined>;

    /**
     * Create a EIP resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated EIP is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args?: EIPArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("EIP is deprecated: EIP is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            inputs["domain"] = args ? args.domain : undefined;
            inputs["instanceId"] = args ? args.instanceId : undefined;
            inputs["publicIpv4Pool"] = args ? args.publicIpv4Pool : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["allocationId"] = undefined /*out*/;
        } else {
            inputs["allocationId"] = undefined /*out*/;
            inputs["domain"] = undefined /*out*/;
            inputs["instanceId"] = undefined /*out*/;
            inputs["publicIpv4Pool"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(EIP.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a EIP resource.
 */
export interface EIPArgs {
    domain?: pulumi.Input<string>;
    instanceId?: pulumi.Input<string>;
    publicIpv4Pool?: pulumi.Input<string>;
    tags?: pulumi.Input<pulumi.Input<inputs.ec2.EIPTagArgs>[]>;
}
