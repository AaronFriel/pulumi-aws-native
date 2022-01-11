// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Creates a gateway task definition.
 */
export class TaskDefinition extends pulumi.CustomResource {
    /**
     * Get an existing TaskDefinition resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): TaskDefinition {
        return new TaskDefinition(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:iotwireless:TaskDefinition';

    /**
     * Returns true if the given object is an instance of TaskDefinition.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is TaskDefinition {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === TaskDefinition.__pulumiType;
    }

    /**
     * TaskDefinition arn. Returned after successful create.
     */
    public /*out*/ readonly arn!: pulumi.Output<string>;
    /**
     * Whether to automatically create tasks using this task definition for all gateways with the specified current version. If false, the task must me created by calling CreateWirelessGatewayTask.
     */
    public readonly autoCreateTasks!: pulumi.Output<boolean>;
    /**
     * The list of task definitions.
     */
    public readonly loRaWANUpdateGatewayTaskEntry!: pulumi.Output<outputs.iotwireless.TaskDefinitionLoRaWANUpdateGatewayTaskEntry | undefined>;
    /**
     * The name of the new resource.
     */
    public readonly name!: pulumi.Output<string | undefined>;
    /**
     * A list of key-value pairs that contain metadata for the destination.
     */
    public readonly tags!: pulumi.Output<outputs.iotwireless.TaskDefinitionTag[] | undefined>;
    /**
     * A filter to list only the wireless gateway task definitions that use this task definition type
     */
    public readonly taskDefinitionType!: pulumi.Output<enums.iotwireless.TaskDefinitionType | undefined>;
    /**
     * Information about the gateways to update.
     */
    public readonly update!: pulumi.Output<outputs.iotwireless.TaskDefinitionUpdateWirelessGatewayTaskCreate | undefined>;

    /**
     * Create a TaskDefinition resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: TaskDefinitionArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.autoCreateTasks === undefined) && !opts.urn) {
                throw new Error("Missing required property 'autoCreateTasks'");
            }
            inputs["autoCreateTasks"] = args ? args.autoCreateTasks : undefined;
            inputs["loRaWANUpdateGatewayTaskEntry"] = args ? args.loRaWANUpdateGatewayTaskEntry : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["taskDefinitionType"] = args ? args.taskDefinitionType : undefined;
            inputs["update"] = args ? args.update : undefined;
            inputs["arn"] = undefined /*out*/;
        } else {
            inputs["arn"] = undefined /*out*/;
            inputs["autoCreateTasks"] = undefined /*out*/;
            inputs["loRaWANUpdateGatewayTaskEntry"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["taskDefinitionType"] = undefined /*out*/;
            inputs["update"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(TaskDefinition.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a TaskDefinition resource.
 */
export interface TaskDefinitionArgs {
    /**
     * Whether to automatically create tasks using this task definition for all gateways with the specified current version. If false, the task must me created by calling CreateWirelessGatewayTask.
     */
    autoCreateTasks: pulumi.Input<boolean>;
    /**
     * The list of task definitions.
     */
    loRaWANUpdateGatewayTaskEntry?: pulumi.Input<inputs.iotwireless.TaskDefinitionLoRaWANUpdateGatewayTaskEntryArgs>;
    /**
     * The name of the new resource.
     */
    name?: pulumi.Input<string>;
    /**
     * A list of key-value pairs that contain metadata for the destination.
     */
    tags?: pulumi.Input<pulumi.Input<inputs.iotwireless.TaskDefinitionTagArgs>[]>;
    /**
     * A filter to list only the wireless gateway task definitions that use this task definition type
     */
    taskDefinitionType?: pulumi.Input<enums.iotwireless.TaskDefinitionType>;
    /**
     * Information about the gateways to update.
     */
    update?: pulumi.Input<inputs.iotwireless.TaskDefinitionUpdateWirelessGatewayTaskCreateArgs>;
}
