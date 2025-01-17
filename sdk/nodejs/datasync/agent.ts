// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource schema for AWS::DataSync::Agent.
 */
export class Agent extends pulumi.CustomResource {
    /**
     * Get an existing Agent resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Agent {
        return new Agent(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:datasync:Agent';

    /**
     * Returns true if the given object is an instance of Agent.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Agent {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Agent.__pulumiType;
    }

    /**
     * Activation key of the Agent.
     */
    public readonly activationKey!: pulumi.Output<string>;
    /**
     * The DataSync Agent ARN.
     */
    public /*out*/ readonly agentArn!: pulumi.Output<string>;
    /**
     * The name configured for the agent. Text reference used to identify the agent in the console.
     */
    public readonly agentName!: pulumi.Output<string | undefined>;
    /**
     * The service endpoints that the agent will connect to.
     */
    public /*out*/ readonly endpointType!: pulumi.Output<enums.datasync.AgentEndpointType>;
    /**
     * The ARNs of the security group used to protect your data transfer task subnets.
     */
    public readonly securityGroupArns!: pulumi.Output<string[] | undefined>;
    /**
     * The ARNs of the subnets in which DataSync will create elastic network interfaces for each data transfer task.
     */
    public readonly subnetArns!: pulumi.Output<string[] | undefined>;
    /**
     * An array of key-value pairs to apply to this resource.
     */
    public readonly tags!: pulumi.Output<outputs.datasync.AgentTag[] | undefined>;
    /**
     * The ID of the VPC endpoint that the agent has access to.
     */
    public readonly vpcEndpointId!: pulumi.Output<string | undefined>;

    /**
     * Create a Agent resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AgentArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.activationKey === undefined) && !opts.urn) {
                throw new Error("Missing required property 'activationKey'");
            }
            inputs["activationKey"] = args ? args.activationKey : undefined;
            inputs["agentName"] = args ? args.agentName : undefined;
            inputs["securityGroupArns"] = args ? args.securityGroupArns : undefined;
            inputs["subnetArns"] = args ? args.subnetArns : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["vpcEndpointId"] = args ? args.vpcEndpointId : undefined;
            inputs["agentArn"] = undefined /*out*/;
            inputs["endpointType"] = undefined /*out*/;
        } else {
            inputs["activationKey"] = undefined /*out*/;
            inputs["agentArn"] = undefined /*out*/;
            inputs["agentName"] = undefined /*out*/;
            inputs["endpointType"] = undefined /*out*/;
            inputs["securityGroupArns"] = undefined /*out*/;
            inputs["subnetArns"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["vpcEndpointId"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Agent.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Agent resource.
 */
export interface AgentArgs {
    /**
     * Activation key of the Agent.
     */
    activationKey: pulumi.Input<string>;
    /**
     * The name configured for the agent. Text reference used to identify the agent in the console.
     */
    agentName?: pulumi.Input<string>;
    /**
     * The ARNs of the security group used to protect your data transfer task subnets.
     */
    securityGroupArns?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The ARNs of the subnets in which DataSync will create elastic network interfaces for each data transfer task.
     */
    subnetArns?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * An array of key-value pairs to apply to this resource.
     */
    tags?: pulumi.Input<pulumi.Input<inputs.datasync.AgentTagArgs>[]>;
    /**
     * The ID of the VPC endpoint that the agent has access to.
     */
    vpcEndpointId?: pulumi.Input<string>;
}
