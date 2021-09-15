// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * A pseudo-resource that manages which of your ECS task sets is primary.
 */
export class PrimaryTaskSet extends pulumi.CustomResource {
    /**
     * Get an existing PrimaryTaskSet resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): PrimaryTaskSet {
        return new PrimaryTaskSet(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:ecs:PrimaryTaskSet';

    /**
     * Returns true if the given object is an instance of PrimaryTaskSet.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is PrimaryTaskSet {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === PrimaryTaskSet.__pulumiType;
    }

    /**
     * The short name or full Amazon Resource Name (ARN) of the cluster that hosts the service to create the task set in.
     */
    public readonly cluster!: pulumi.Output<string>;
    /**
     * The short name or full Amazon Resource Name (ARN) of the service to create the task set in.
     */
    public readonly service!: pulumi.Output<string>;
    /**
     * The ID or full Amazon Resource Name (ARN) of the task set.
     */
    public readonly taskSetId!: pulumi.Output<string>;

    /**
     * Create a PrimaryTaskSet resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: PrimaryTaskSetArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.cluster === undefined) && !opts.urn) {
                throw new Error("Missing required property 'cluster'");
            }
            if ((!args || args.service === undefined) && !opts.urn) {
                throw new Error("Missing required property 'service'");
            }
            if ((!args || args.taskSetId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'taskSetId'");
            }
            inputs["cluster"] = args ? args.cluster : undefined;
            inputs["service"] = args ? args.service : undefined;
            inputs["taskSetId"] = args ? args.taskSetId : undefined;
        } else {
            inputs["cluster"] = undefined /*out*/;
            inputs["service"] = undefined /*out*/;
            inputs["taskSetId"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(PrimaryTaskSet.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a PrimaryTaskSet resource.
 */
export interface PrimaryTaskSetArgs {
    /**
     * The short name or full Amazon Resource Name (ARN) of the cluster that hosts the service to create the task set in.
     */
    cluster: pulumi.Input<string>;
    /**
     * The short name or full Amazon Resource Name (ARN) of the service to create the task set in.
     */
    service: pulumi.Input<string>;
    /**
     * The ID or full Amazon Resource Name (ARN) of the task set.
     */
    taskSetId: pulumi.Input<string>;
}
