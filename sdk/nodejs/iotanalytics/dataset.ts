// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::IoTAnalytics::Dataset
 */
export class Dataset extends pulumi.CustomResource {
    /**
     * Get an existing Dataset resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Dataset {
        return new Dataset(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:iotanalytics:Dataset';

    /**
     * Returns true if the given object is an instance of Dataset.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Dataset {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Dataset.__pulumiType;
    }

    public readonly actions!: pulumi.Output<outputs.iotanalytics.DatasetAction[]>;
    public readonly contentDeliveryRules!: pulumi.Output<outputs.iotanalytics.DatasetContentDeliveryRule[] | undefined>;
    public readonly datasetName!: pulumi.Output<string | undefined>;
    public readonly lateDataRules!: pulumi.Output<outputs.iotanalytics.DatasetLateDataRule[] | undefined>;
    public readonly retentionPeriod!: pulumi.Output<outputs.iotanalytics.DatasetRetentionPeriod | undefined>;
    public readonly tags!: pulumi.Output<outputs.iotanalytics.DatasetTag[] | undefined>;
    public readonly triggers!: pulumi.Output<outputs.iotanalytics.DatasetTrigger[] | undefined>;
    public readonly versioningConfiguration!: pulumi.Output<outputs.iotanalytics.DatasetVersioningConfiguration | undefined>;

    /**
     * Create a Dataset resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DatasetArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.actions === undefined) && !opts.urn) {
                throw new Error("Missing required property 'actions'");
            }
            inputs["actions"] = args ? args.actions : undefined;
            inputs["contentDeliveryRules"] = args ? args.contentDeliveryRules : undefined;
            inputs["datasetName"] = args ? args.datasetName : undefined;
            inputs["lateDataRules"] = args ? args.lateDataRules : undefined;
            inputs["retentionPeriod"] = args ? args.retentionPeriod : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["triggers"] = args ? args.triggers : undefined;
            inputs["versioningConfiguration"] = args ? args.versioningConfiguration : undefined;
        } else {
            inputs["actions"] = undefined /*out*/;
            inputs["contentDeliveryRules"] = undefined /*out*/;
            inputs["datasetName"] = undefined /*out*/;
            inputs["lateDataRules"] = undefined /*out*/;
            inputs["retentionPeriod"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["triggers"] = undefined /*out*/;
            inputs["versioningConfiguration"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Dataset.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Dataset resource.
 */
export interface DatasetArgs {
    actions: pulumi.Input<pulumi.Input<inputs.iotanalytics.DatasetActionArgs>[]>;
    contentDeliveryRules?: pulumi.Input<pulumi.Input<inputs.iotanalytics.DatasetContentDeliveryRuleArgs>[]>;
    datasetName?: pulumi.Input<string>;
    lateDataRules?: pulumi.Input<pulumi.Input<inputs.iotanalytics.DatasetLateDataRuleArgs>[]>;
    retentionPeriod?: pulumi.Input<inputs.iotanalytics.DatasetRetentionPeriodArgs>;
    tags?: pulumi.Input<pulumi.Input<inputs.iotanalytics.DatasetTagArgs>[]>;
    triggers?: pulumi.Input<pulumi.Input<inputs.iotanalytics.DatasetTriggerArgs>[]>;
    versioningConfiguration?: pulumi.Input<inputs.iotanalytics.DatasetVersioningConfigurationArgs>;
}
