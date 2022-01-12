// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::AutoScaling::ScalingPolicy
 *
 * @deprecated ScalingPolicy is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class ScalingPolicy extends pulumi.CustomResource {
    /**
     * Get an existing ScalingPolicy resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ScalingPolicy {
        pulumi.log.warn("ScalingPolicy is deprecated: ScalingPolicy is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new ScalingPolicy(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:autoscaling:ScalingPolicy';

    /**
     * Returns true if the given object is an instance of ScalingPolicy.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ScalingPolicy {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ScalingPolicy.__pulumiType;
    }

    public readonly adjustmentType!: pulumi.Output<string | undefined>;
    public readonly autoScalingGroupName!: pulumi.Output<string>;
    public readonly cooldown!: pulumi.Output<string | undefined>;
    public readonly estimatedInstanceWarmup!: pulumi.Output<number | undefined>;
    public readonly metricAggregationType!: pulumi.Output<string | undefined>;
    public readonly minAdjustmentMagnitude!: pulumi.Output<number | undefined>;
    public readonly policyType!: pulumi.Output<string | undefined>;
    public readonly predictiveScalingConfiguration!: pulumi.Output<outputs.autoscaling.ScalingPolicyPredictiveScalingConfiguration | undefined>;
    public readonly scalingAdjustment!: pulumi.Output<number | undefined>;
    public readonly stepAdjustments!: pulumi.Output<outputs.autoscaling.ScalingPolicyStepAdjustment[] | undefined>;
    public readonly targetTrackingConfiguration!: pulumi.Output<outputs.autoscaling.ScalingPolicyTargetTrackingConfiguration | undefined>;

    /**
     * Create a ScalingPolicy resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated ScalingPolicy is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args: ScalingPolicyArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("ScalingPolicy is deprecated: ScalingPolicy is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.autoScalingGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'autoScalingGroupName'");
            }
            inputs["adjustmentType"] = args ? args.adjustmentType : undefined;
            inputs["autoScalingGroupName"] = args ? args.autoScalingGroupName : undefined;
            inputs["cooldown"] = args ? args.cooldown : undefined;
            inputs["estimatedInstanceWarmup"] = args ? args.estimatedInstanceWarmup : undefined;
            inputs["metricAggregationType"] = args ? args.metricAggregationType : undefined;
            inputs["minAdjustmentMagnitude"] = args ? args.minAdjustmentMagnitude : undefined;
            inputs["policyType"] = args ? args.policyType : undefined;
            inputs["predictiveScalingConfiguration"] = args ? args.predictiveScalingConfiguration : undefined;
            inputs["scalingAdjustment"] = args ? args.scalingAdjustment : undefined;
            inputs["stepAdjustments"] = args ? args.stepAdjustments : undefined;
            inputs["targetTrackingConfiguration"] = args ? args.targetTrackingConfiguration : undefined;
        } else {
            inputs["adjustmentType"] = undefined /*out*/;
            inputs["autoScalingGroupName"] = undefined /*out*/;
            inputs["cooldown"] = undefined /*out*/;
            inputs["estimatedInstanceWarmup"] = undefined /*out*/;
            inputs["metricAggregationType"] = undefined /*out*/;
            inputs["minAdjustmentMagnitude"] = undefined /*out*/;
            inputs["policyType"] = undefined /*out*/;
            inputs["predictiveScalingConfiguration"] = undefined /*out*/;
            inputs["scalingAdjustment"] = undefined /*out*/;
            inputs["stepAdjustments"] = undefined /*out*/;
            inputs["targetTrackingConfiguration"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(ScalingPolicy.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ScalingPolicy resource.
 */
export interface ScalingPolicyArgs {
    adjustmentType?: pulumi.Input<string>;
    autoScalingGroupName: pulumi.Input<string>;
    cooldown?: pulumi.Input<string>;
    estimatedInstanceWarmup?: pulumi.Input<number>;
    metricAggregationType?: pulumi.Input<string>;
    minAdjustmentMagnitude?: pulumi.Input<number>;
    policyType?: pulumi.Input<string>;
    predictiveScalingConfiguration?: pulumi.Input<inputs.autoscaling.ScalingPolicyPredictiveScalingConfigurationArgs>;
    scalingAdjustment?: pulumi.Input<number>;
    stepAdjustments?: pulumi.Input<pulumi.Input<inputs.autoscaling.ScalingPolicyStepAdjustmentArgs>[]>;
    targetTrackingConfiguration?: pulumi.Input<inputs.autoscaling.ScalingPolicyTargetTrackingConfigurationArgs>;
}
