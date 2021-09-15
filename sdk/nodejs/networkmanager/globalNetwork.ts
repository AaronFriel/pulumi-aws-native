// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * The AWS::NetworkManager::GlobalNetwork type specifies a global network of the user's account
 */
export class GlobalNetwork extends pulumi.CustomResource {
    /**
     * Get an existing GlobalNetwork resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): GlobalNetwork {
        return new GlobalNetwork(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:networkmanager:GlobalNetwork';

    /**
     * Returns true if the given object is an instance of GlobalNetwork.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is GlobalNetwork {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === GlobalNetwork.__pulumiType;
    }

    /**
     * The Amazon Resource Name (ARN) of the global network.
     */
    public /*out*/ readonly arn!: pulumi.Output<string>;
    /**
     * The description of the global network.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * The tags for the global network.
     */
    public readonly tags!: pulumi.Output<outputs.networkmanager.GlobalNetworkTag[] | undefined>;

    /**
     * Create a GlobalNetwork resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: GlobalNetworkArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            inputs["description"] = args ? args.description : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["arn"] = undefined /*out*/;
        } else {
            inputs["arn"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(GlobalNetwork.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a GlobalNetwork resource.
 */
export interface GlobalNetworkArgs {
    /**
     * The description of the global network.
     */
    description?: pulumi.Input<string>;
    /**
     * The tags for the global network.
     */
    tags?: pulumi.Input<pulumi.Input<inputs.networkmanager.GlobalNetworkTagArgs>[]>;
}
