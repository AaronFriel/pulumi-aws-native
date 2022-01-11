// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::DMS::ReplicationTask
 *
 * @deprecated ReplicationTask is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class ReplicationTask extends pulumi.CustomResource {
    /**
     * Get an existing ReplicationTask resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ReplicationTask {
        pulumi.log.warn("ReplicationTask is deprecated: ReplicationTask is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new ReplicationTask(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:dms:ReplicationTask';

    /**
     * Returns true if the given object is an instance of ReplicationTask.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ReplicationTask {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ReplicationTask.__pulumiType;
    }

    public readonly cdcStartPosition!: pulumi.Output<string | undefined>;
    public readonly cdcStartTime!: pulumi.Output<number | undefined>;
    public readonly cdcStopPosition!: pulumi.Output<string | undefined>;
    public readonly migrationType!: pulumi.Output<string>;
    public readonly replicationInstanceArn!: pulumi.Output<string>;
    public readonly replicationTaskIdentifier!: pulumi.Output<string | undefined>;
    public readonly replicationTaskSettings!: pulumi.Output<string | undefined>;
    public readonly resourceIdentifier!: pulumi.Output<string | undefined>;
    public readonly sourceEndpointArn!: pulumi.Output<string>;
    public readonly tableMappings!: pulumi.Output<string>;
    public readonly tags!: pulumi.Output<outputs.dms.ReplicationTaskTag[] | undefined>;
    public readonly targetEndpointArn!: pulumi.Output<string>;
    public readonly taskData!: pulumi.Output<string | undefined>;

    /**
     * Create a ReplicationTask resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated ReplicationTask is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args: ReplicationTaskArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("ReplicationTask is deprecated: ReplicationTask is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.migrationType === undefined) && !opts.urn) {
                throw new Error("Missing required property 'migrationType'");
            }
            if ((!args || args.replicationInstanceArn === undefined) && !opts.urn) {
                throw new Error("Missing required property 'replicationInstanceArn'");
            }
            if ((!args || args.sourceEndpointArn === undefined) && !opts.urn) {
                throw new Error("Missing required property 'sourceEndpointArn'");
            }
            if ((!args || args.tableMappings === undefined) && !opts.urn) {
                throw new Error("Missing required property 'tableMappings'");
            }
            if ((!args || args.targetEndpointArn === undefined) && !opts.urn) {
                throw new Error("Missing required property 'targetEndpointArn'");
            }
            inputs["cdcStartPosition"] = args ? args.cdcStartPosition : undefined;
            inputs["cdcStartTime"] = args ? args.cdcStartTime : undefined;
            inputs["cdcStopPosition"] = args ? args.cdcStopPosition : undefined;
            inputs["migrationType"] = args ? args.migrationType : undefined;
            inputs["replicationInstanceArn"] = args ? args.replicationInstanceArn : undefined;
            inputs["replicationTaskIdentifier"] = args ? args.replicationTaskIdentifier : undefined;
            inputs["replicationTaskSettings"] = args ? args.replicationTaskSettings : undefined;
            inputs["resourceIdentifier"] = args ? args.resourceIdentifier : undefined;
            inputs["sourceEndpointArn"] = args ? args.sourceEndpointArn : undefined;
            inputs["tableMappings"] = args ? args.tableMappings : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["targetEndpointArn"] = args ? args.targetEndpointArn : undefined;
            inputs["taskData"] = args ? args.taskData : undefined;
        } else {
            inputs["cdcStartPosition"] = undefined /*out*/;
            inputs["cdcStartTime"] = undefined /*out*/;
            inputs["cdcStopPosition"] = undefined /*out*/;
            inputs["migrationType"] = undefined /*out*/;
            inputs["replicationInstanceArn"] = undefined /*out*/;
            inputs["replicationTaskIdentifier"] = undefined /*out*/;
            inputs["replicationTaskSettings"] = undefined /*out*/;
            inputs["resourceIdentifier"] = undefined /*out*/;
            inputs["sourceEndpointArn"] = undefined /*out*/;
            inputs["tableMappings"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["targetEndpointArn"] = undefined /*out*/;
            inputs["taskData"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(ReplicationTask.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ReplicationTask resource.
 */
export interface ReplicationTaskArgs {
    cdcStartPosition?: pulumi.Input<string>;
    cdcStartTime?: pulumi.Input<number>;
    cdcStopPosition?: pulumi.Input<string>;
    migrationType: pulumi.Input<string>;
    replicationInstanceArn: pulumi.Input<string>;
    replicationTaskIdentifier?: pulumi.Input<string>;
    replicationTaskSettings?: pulumi.Input<string>;
    resourceIdentifier?: pulumi.Input<string>;
    sourceEndpointArn: pulumi.Input<string>;
    tableMappings: pulumi.Input<string>;
    tags?: pulumi.Input<pulumi.Input<inputs.dms.ReplicationTaskTagArgs>[]>;
    targetEndpointArn: pulumi.Input<string>;
    taskData?: pulumi.Input<string>;
}
