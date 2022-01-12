// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::Evidently::Experiment.
 */
export class Experiment extends pulumi.CustomResource {
    /**
     * Get an existing Experiment resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Experiment {
        return new Experiment(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:evidently:Experiment';

    /**
     * Returns true if the given object is an instance of Experiment.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Experiment {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Experiment.__pulumiType;
    }

    public /*out*/ readonly arn!: pulumi.Output<string>;
    public readonly description!: pulumi.Output<string | undefined>;
    public readonly metricGoals!: pulumi.Output<outputs.evidently.ExperimentMetricGoalObject[]>;
    public readonly name!: pulumi.Output<string>;
    public readonly onlineAbConfig!: pulumi.Output<outputs.evidently.ExperimentOnlineAbConfigObject>;
    public readonly project!: pulumi.Output<string>;
    public readonly randomizationSalt!: pulumi.Output<string | undefined>;
    public readonly samplingRate!: pulumi.Output<number | undefined>;
    /**
     * An array of key-value pairs to apply to this resource.
     */
    public readonly tags!: pulumi.Output<outputs.evidently.ExperimentTag[] | undefined>;
    public readonly treatments!: pulumi.Output<outputs.evidently.ExperimentTreatmentObject[]>;

    /**
     * Create a Experiment resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ExperimentArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.metricGoals === undefined) && !opts.urn) {
                throw new Error("Missing required property 'metricGoals'");
            }
            if ((!args || args.onlineAbConfig === undefined) && !opts.urn) {
                throw new Error("Missing required property 'onlineAbConfig'");
            }
            if ((!args || args.project === undefined) && !opts.urn) {
                throw new Error("Missing required property 'project'");
            }
            if ((!args || args.treatments === undefined) && !opts.urn) {
                throw new Error("Missing required property 'treatments'");
            }
            inputs["description"] = args ? args.description : undefined;
            inputs["metricGoals"] = args ? args.metricGoals : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["onlineAbConfig"] = args ? args.onlineAbConfig : undefined;
            inputs["project"] = args ? args.project : undefined;
            inputs["randomizationSalt"] = args ? args.randomizationSalt : undefined;
            inputs["samplingRate"] = args ? args.samplingRate : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["treatments"] = args ? args.treatments : undefined;
            inputs["arn"] = undefined /*out*/;
        } else {
            inputs["arn"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["metricGoals"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["onlineAbConfig"] = undefined /*out*/;
            inputs["project"] = undefined /*out*/;
            inputs["randomizationSalt"] = undefined /*out*/;
            inputs["samplingRate"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["treatments"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Experiment.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Experiment resource.
 */
export interface ExperimentArgs {
    description?: pulumi.Input<string>;
    metricGoals: pulumi.Input<pulumi.Input<inputs.evidently.ExperimentMetricGoalObjectArgs>[]>;
    name?: pulumi.Input<string>;
    onlineAbConfig: pulumi.Input<inputs.evidently.ExperimentOnlineAbConfigObjectArgs>;
    project: pulumi.Input<string>;
    randomizationSalt?: pulumi.Input<string>;
    samplingRate?: pulumi.Input<number>;
    /**
     * An array of key-value pairs to apply to this resource.
     */
    tags?: pulumi.Input<pulumi.Input<inputs.evidently.ExperimentTagArgs>[]>;
    treatments: pulumi.Input<pulumi.Input<inputs.evidently.ExperimentTreatmentObjectArgs>[]>;
}
