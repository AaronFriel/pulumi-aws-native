// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::Logs::Destination
 *
 * @deprecated Destination is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class Destination extends pulumi.CustomResource {
    /**
     * Get an existing Destination resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Destination {
        pulumi.log.warn("Destination is deprecated: Destination is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new Destination(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:logs:Destination';

    /**
     * Returns true if the given object is an instance of Destination.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Destination {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Destination.__pulumiType;
    }

    public /*out*/ readonly arn!: pulumi.Output<string>;
    public readonly destinationName!: pulumi.Output<string>;
    public readonly destinationPolicy!: pulumi.Output<string>;
    public readonly roleArn!: pulumi.Output<string>;
    public readonly targetArn!: pulumi.Output<string>;

    /**
     * Create a Destination resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Destination is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args: DestinationArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("Destination is deprecated: Destination is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.destinationName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'destinationName'");
            }
            if ((!args || args.destinationPolicy === undefined) && !opts.urn) {
                throw new Error("Missing required property 'destinationPolicy'");
            }
            if ((!args || args.roleArn === undefined) && !opts.urn) {
                throw new Error("Missing required property 'roleArn'");
            }
            if ((!args || args.targetArn === undefined) && !opts.urn) {
                throw new Error("Missing required property 'targetArn'");
            }
            inputs["destinationName"] = args ? args.destinationName : undefined;
            inputs["destinationPolicy"] = args ? args.destinationPolicy : undefined;
            inputs["roleArn"] = args ? args.roleArn : undefined;
            inputs["targetArn"] = args ? args.targetArn : undefined;
            inputs["arn"] = undefined /*out*/;
        } else {
            inputs["arn"] = undefined /*out*/;
            inputs["destinationName"] = undefined /*out*/;
            inputs["destinationPolicy"] = undefined /*out*/;
            inputs["roleArn"] = undefined /*out*/;
            inputs["targetArn"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Destination.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Destination resource.
 */
export interface DestinationArgs {
    destinationName: pulumi.Input<string>;
    destinationPolicy: pulumi.Input<string>;
    roleArn: pulumi.Input<string>;
    targetArn: pulumi.Input<string>;
}
