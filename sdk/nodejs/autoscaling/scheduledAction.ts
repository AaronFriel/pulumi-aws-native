// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::AutoScaling::ScheduledAction
 *
 * @deprecated ScheduledAction is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class ScheduledAction extends pulumi.CustomResource {
    /**
     * Get an existing ScheduledAction resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ScheduledAction {
        pulumi.log.warn("ScheduledAction is deprecated: ScheduledAction is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new ScheduledAction(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:autoscaling:ScheduledAction';

    /**
     * Returns true if the given object is an instance of ScheduledAction.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ScheduledAction {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ScheduledAction.__pulumiType;
    }

    public readonly autoScalingGroupName!: pulumi.Output<string>;
    public readonly desiredCapacity!: pulumi.Output<number | undefined>;
    public readonly endTime!: pulumi.Output<string | undefined>;
    public readonly maxSize!: pulumi.Output<number | undefined>;
    public readonly minSize!: pulumi.Output<number | undefined>;
    public readonly recurrence!: pulumi.Output<string | undefined>;
    public readonly startTime!: pulumi.Output<string | undefined>;
    public readonly timeZone!: pulumi.Output<string | undefined>;

    /**
     * Create a ScheduledAction resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated ScheduledAction is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args: ScheduledActionArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("ScheduledAction is deprecated: ScheduledAction is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.autoScalingGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'autoScalingGroupName'");
            }
            inputs["autoScalingGroupName"] = args ? args.autoScalingGroupName : undefined;
            inputs["desiredCapacity"] = args ? args.desiredCapacity : undefined;
            inputs["endTime"] = args ? args.endTime : undefined;
            inputs["maxSize"] = args ? args.maxSize : undefined;
            inputs["minSize"] = args ? args.minSize : undefined;
            inputs["recurrence"] = args ? args.recurrence : undefined;
            inputs["startTime"] = args ? args.startTime : undefined;
            inputs["timeZone"] = args ? args.timeZone : undefined;
        } else {
            inputs["autoScalingGroupName"] = undefined /*out*/;
            inputs["desiredCapacity"] = undefined /*out*/;
            inputs["endTime"] = undefined /*out*/;
            inputs["maxSize"] = undefined /*out*/;
            inputs["minSize"] = undefined /*out*/;
            inputs["recurrence"] = undefined /*out*/;
            inputs["startTime"] = undefined /*out*/;
            inputs["timeZone"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(ScheduledAction.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ScheduledAction resource.
 */
export interface ScheduledActionArgs {
    autoScalingGroupName: pulumi.Input<string>;
    desiredCapacity?: pulumi.Input<number>;
    endTime?: pulumi.Input<string>;
    maxSize?: pulumi.Input<number>;
    minSize?: pulumi.Input<number>;
    recurrence?: pulumi.Input<string>;
    startTime?: pulumi.Input<string>;
    timeZone?: pulumi.Input<string>;
}
