// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::SSM::MaintenanceWindow
 *
 * @deprecated MaintenanceWindow is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class MaintenanceWindow extends pulumi.CustomResource {
    /**
     * Get an existing MaintenanceWindow resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): MaintenanceWindow {
        pulumi.log.warn("MaintenanceWindow is deprecated: MaintenanceWindow is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new MaintenanceWindow(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:ssm:MaintenanceWindow';

    /**
     * Returns true if the given object is an instance of MaintenanceWindow.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is MaintenanceWindow {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === MaintenanceWindow.__pulumiType;
    }

    public readonly allowUnassociatedTargets!: pulumi.Output<boolean>;
    public readonly cutoff!: pulumi.Output<number>;
    public readonly description!: pulumi.Output<string | undefined>;
    public readonly duration!: pulumi.Output<number>;
    public readonly endDate!: pulumi.Output<string | undefined>;
    public readonly name!: pulumi.Output<string>;
    public readonly schedule!: pulumi.Output<string>;
    public readonly scheduleOffset!: pulumi.Output<number | undefined>;
    public readonly scheduleTimezone!: pulumi.Output<string | undefined>;
    public readonly startDate!: pulumi.Output<string | undefined>;
    public readonly tags!: pulumi.Output<outputs.ssm.MaintenanceWindowTag[] | undefined>;

    /**
     * Create a MaintenanceWindow resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated MaintenanceWindow is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args: MaintenanceWindowArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("MaintenanceWindow is deprecated: MaintenanceWindow is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.allowUnassociatedTargets === undefined) && !opts.urn) {
                throw new Error("Missing required property 'allowUnassociatedTargets'");
            }
            if ((!args || args.cutoff === undefined) && !opts.urn) {
                throw new Error("Missing required property 'cutoff'");
            }
            if ((!args || args.duration === undefined) && !opts.urn) {
                throw new Error("Missing required property 'duration'");
            }
            if ((!args || args.schedule === undefined) && !opts.urn) {
                throw new Error("Missing required property 'schedule'");
            }
            inputs["allowUnassociatedTargets"] = args ? args.allowUnassociatedTargets : undefined;
            inputs["cutoff"] = args ? args.cutoff : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["duration"] = args ? args.duration : undefined;
            inputs["endDate"] = args ? args.endDate : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["schedule"] = args ? args.schedule : undefined;
            inputs["scheduleOffset"] = args ? args.scheduleOffset : undefined;
            inputs["scheduleTimezone"] = args ? args.scheduleTimezone : undefined;
            inputs["startDate"] = args ? args.startDate : undefined;
            inputs["tags"] = args ? args.tags : undefined;
        } else {
            inputs["allowUnassociatedTargets"] = undefined /*out*/;
            inputs["cutoff"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["duration"] = undefined /*out*/;
            inputs["endDate"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["schedule"] = undefined /*out*/;
            inputs["scheduleOffset"] = undefined /*out*/;
            inputs["scheduleTimezone"] = undefined /*out*/;
            inputs["startDate"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(MaintenanceWindow.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a MaintenanceWindow resource.
 */
export interface MaintenanceWindowArgs {
    allowUnassociatedTargets: pulumi.Input<boolean>;
    cutoff: pulumi.Input<number>;
    description?: pulumi.Input<string>;
    duration: pulumi.Input<number>;
    endDate?: pulumi.Input<string>;
    name?: pulumi.Input<string>;
    schedule: pulumi.Input<string>;
    scheduleOffset?: pulumi.Input<number>;
    scheduleTimezone?: pulumi.Input<string>;
    startDate?: pulumi.Input<string>;
    tags?: pulumi.Input<pulumi.Input<inputs.ssm.MaintenanceWindowTagArgs>[]>;
}
