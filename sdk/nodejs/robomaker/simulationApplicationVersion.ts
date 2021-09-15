// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * An example resource schema demonstrating some basic constructs and validation rules.
 */
export class SimulationApplicationVersion extends pulumi.CustomResource {
    /**
     * Get an existing SimulationApplicationVersion resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): SimulationApplicationVersion {
        return new SimulationApplicationVersion(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:robomaker:SimulationApplicationVersion';

    /**
     * Returns true if the given object is an instance of SimulationApplicationVersion.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SimulationApplicationVersion {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SimulationApplicationVersion.__pulumiType;
    }

    public readonly application!: pulumi.Output<string>;
    public /*out*/ readonly applicationVersion!: pulumi.Output<string>;
    public /*out*/ readonly arn!: pulumi.Output<string>;
    /**
     * The revision ID of robot application.
     */
    public readonly currentRevisionId!: pulumi.Output<string | undefined>;

    /**
     * Create a SimulationApplicationVersion resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SimulationApplicationVersionArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.application === undefined) && !opts.urn) {
                throw new Error("Missing required property 'application'");
            }
            inputs["application"] = args ? args.application : undefined;
            inputs["currentRevisionId"] = args ? args.currentRevisionId : undefined;
            inputs["applicationVersion"] = undefined /*out*/;
            inputs["arn"] = undefined /*out*/;
        } else {
            inputs["application"] = undefined /*out*/;
            inputs["applicationVersion"] = undefined /*out*/;
            inputs["arn"] = undefined /*out*/;
            inputs["currentRevisionId"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(SimulationApplicationVersion.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a SimulationApplicationVersion resource.
 */
export interface SimulationApplicationVersionArgs {
    application: pulumi.Input<string>;
    /**
     * The revision ID of robot application.
     */
    currentRevisionId?: pulumi.Input<string>;
}
