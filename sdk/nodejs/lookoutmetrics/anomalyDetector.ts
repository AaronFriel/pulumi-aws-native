// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * An Amazon Lookout for Metrics Detector
 */
export class AnomalyDetector extends pulumi.CustomResource {
    /**
     * Get an existing AnomalyDetector resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): AnomalyDetector {
        return new AnomalyDetector(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:lookoutmetrics:AnomalyDetector';

    /**
     * Returns true if the given object is an instance of AnomalyDetector.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AnomalyDetector {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AnomalyDetector.__pulumiType;
    }

    /**
     * Configuration options for the AnomalyDetector
     */
    public readonly anomalyDetectorConfig!: pulumi.Output<outputs.lookoutmetrics.AnomalyDetectorAnomalyDetectorConfig>;
    /**
     * A description for the AnomalyDetector.
     */
    public readonly anomalyDetectorDescription!: pulumi.Output<string | undefined>;
    /**
     * Name for the Amazon Lookout for Metrics Anomaly Detector
     */
    public readonly anomalyDetectorName!: pulumi.Output<string | undefined>;
    public /*out*/ readonly arn!: pulumi.Output<string>;
    /**
     * KMS key used to encrypt the AnomalyDetector data
     */
    public readonly kmsKeyArn!: pulumi.Output<string | undefined>;
    /**
     * List of metric sets for anomaly detection
     */
    public readonly metricSetList!: pulumi.Output<outputs.lookoutmetrics.AnomalyDetectorMetricSet[]>;

    /**
     * Create a AnomalyDetector resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AnomalyDetectorArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.anomalyDetectorConfig === undefined) && !opts.urn) {
                throw new Error("Missing required property 'anomalyDetectorConfig'");
            }
            if ((!args || args.metricSetList === undefined) && !opts.urn) {
                throw new Error("Missing required property 'metricSetList'");
            }
            inputs["anomalyDetectorConfig"] = args ? args.anomalyDetectorConfig : undefined;
            inputs["anomalyDetectorDescription"] = args ? args.anomalyDetectorDescription : undefined;
            inputs["anomalyDetectorName"] = args ? args.anomalyDetectorName : undefined;
            inputs["kmsKeyArn"] = args ? args.kmsKeyArn : undefined;
            inputs["metricSetList"] = args ? args.metricSetList : undefined;
            inputs["arn"] = undefined /*out*/;
        } else {
            inputs["anomalyDetectorConfig"] = undefined /*out*/;
            inputs["anomalyDetectorDescription"] = undefined /*out*/;
            inputs["anomalyDetectorName"] = undefined /*out*/;
            inputs["arn"] = undefined /*out*/;
            inputs["kmsKeyArn"] = undefined /*out*/;
            inputs["metricSetList"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(AnomalyDetector.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a AnomalyDetector resource.
 */
export interface AnomalyDetectorArgs {
    /**
     * Configuration options for the AnomalyDetector
     */
    anomalyDetectorConfig: pulumi.Input<inputs.lookoutmetrics.AnomalyDetectorAnomalyDetectorConfigArgs>;
    /**
     * A description for the AnomalyDetector.
     */
    anomalyDetectorDescription?: pulumi.Input<string>;
    /**
     * Name for the Amazon Lookout for Metrics Anomaly Detector
     */
    anomalyDetectorName?: pulumi.Input<string>;
    /**
     * KMS key used to encrypt the AnomalyDetector data
     */
    kmsKeyArn?: pulumi.Input<string>;
    /**
     * List of metric sets for anomaly detection
     */
    metricSetList: pulumi.Input<pulumi.Input<inputs.lookoutmetrics.AnomalyDetectorMetricSetArgs>[]>;
}
