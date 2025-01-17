// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::EC2::ClientVpnRoute
 *
 * @deprecated ClientVpnRoute is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class ClientVpnRoute extends pulumi.CustomResource {
    /**
     * Get an existing ClientVpnRoute resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ClientVpnRoute {
        pulumi.log.warn("ClientVpnRoute is deprecated: ClientVpnRoute is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new ClientVpnRoute(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:ec2:ClientVpnRoute';

    /**
     * Returns true if the given object is an instance of ClientVpnRoute.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ClientVpnRoute {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ClientVpnRoute.__pulumiType;
    }

    public readonly clientVpnEndpointId!: pulumi.Output<string>;
    public readonly description!: pulumi.Output<string | undefined>;
    public readonly destinationCidrBlock!: pulumi.Output<string>;
    public readonly targetVpcSubnetId!: pulumi.Output<string>;

    /**
     * Create a ClientVpnRoute resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated ClientVpnRoute is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args: ClientVpnRouteArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("ClientVpnRoute is deprecated: ClientVpnRoute is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.clientVpnEndpointId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'clientVpnEndpointId'");
            }
            if ((!args || args.destinationCidrBlock === undefined) && !opts.urn) {
                throw new Error("Missing required property 'destinationCidrBlock'");
            }
            if ((!args || args.targetVpcSubnetId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'targetVpcSubnetId'");
            }
            inputs["clientVpnEndpointId"] = args ? args.clientVpnEndpointId : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["destinationCidrBlock"] = args ? args.destinationCidrBlock : undefined;
            inputs["targetVpcSubnetId"] = args ? args.targetVpcSubnetId : undefined;
        } else {
            inputs["clientVpnEndpointId"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["destinationCidrBlock"] = undefined /*out*/;
            inputs["targetVpcSubnetId"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(ClientVpnRoute.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ClientVpnRoute resource.
 */
export interface ClientVpnRouteArgs {
    clientVpnEndpointId: pulumi.Input<string>;
    description?: pulumi.Input<string>;
    destinationCidrBlock: pulumi.Input<string>;
    targetVpcSubnetId: pulumi.Input<string>;
}
