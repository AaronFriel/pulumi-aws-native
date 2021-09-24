// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::ManagedBlockchain::Node
 *
 * @deprecated Node is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class Node extends pulumi.CustomResource {
    /**
     * Get an existing Node resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Node {
        pulumi.log.warn("Node is deprecated: Node is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new Node(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:managedblockchain:Node';

    /**
     * Returns true if the given object is an instance of Node.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Node {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Node.__pulumiType;
    }

    public /*out*/ readonly arn!: pulumi.Output<string>;
    public readonly memberId!: pulumi.Output<string>;
    public readonly networkId!: pulumi.Output<string>;
    public readonly nodeConfiguration!: pulumi.Output<outputs.managedblockchain.NodeNodeConfiguration>;
    public /*out*/ readonly nodeId!: pulumi.Output<string>;

    /**
     * Create a Node resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Node is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args: NodeArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("Node is deprecated: Node is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.memberId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'memberId'");
            }
            if ((!args || args.networkId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'networkId'");
            }
            if ((!args || args.nodeConfiguration === undefined) && !opts.urn) {
                throw new Error("Missing required property 'nodeConfiguration'");
            }
            inputs["memberId"] = args ? args.memberId : undefined;
            inputs["networkId"] = args ? args.networkId : undefined;
            inputs["nodeConfiguration"] = args ? args.nodeConfiguration : undefined;
            inputs["arn"] = undefined /*out*/;
            inputs["nodeId"] = undefined /*out*/;
        } else {
            inputs["arn"] = undefined /*out*/;
            inputs["memberId"] = undefined /*out*/;
            inputs["networkId"] = undefined /*out*/;
            inputs["nodeConfiguration"] = undefined /*out*/;
            inputs["nodeId"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Node.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Node resource.
 */
export interface NodeArgs {
    memberId: pulumi.Input<string>;
    networkId: pulumi.Input<string>;
    nodeConfiguration: pulumi.Input<inputs.managedblockchain.NodeNodeConfigurationArgs>;
}
