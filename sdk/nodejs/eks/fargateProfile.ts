// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Schema for AWS::EKS::FargateProfile
 */
export class FargateProfile extends pulumi.CustomResource {
    /**
     * Get an existing FargateProfile resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): FargateProfile {
        return new FargateProfile(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:eks:FargateProfile';

    /**
     * Returns true if the given object is an instance of FargateProfile.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is FargateProfile {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === FargateProfile.__pulumiType;
    }

    public /*out*/ readonly arn!: pulumi.Output<string>;
    /**
     * Name of the Cluster
     */
    public readonly clusterName!: pulumi.Output<string>;
    /**
     * Name of FargateProfile
     */
    public readonly fargateProfileName!: pulumi.Output<string | undefined>;
    /**
     * The IAM policy arn for pods
     */
    public readonly podExecutionRoleArn!: pulumi.Output<string>;
    public readonly selectors!: pulumi.Output<outputs.eks.FargateProfileSelector[]>;
    public readonly subnets!: pulumi.Output<string[] | undefined>;
    /**
     * An array of key-value pairs to apply to this resource.
     */
    public readonly tags!: pulumi.Output<outputs.eks.FargateProfileTag[] | undefined>;

    /**
     * Create a FargateProfile resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: FargateProfileArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.clusterName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'clusterName'");
            }
            if ((!args || args.podExecutionRoleArn === undefined) && !opts.urn) {
                throw new Error("Missing required property 'podExecutionRoleArn'");
            }
            if ((!args || args.selectors === undefined) && !opts.urn) {
                throw new Error("Missing required property 'selectors'");
            }
            inputs["clusterName"] = args ? args.clusterName : undefined;
            inputs["fargateProfileName"] = args ? args.fargateProfileName : undefined;
            inputs["podExecutionRoleArn"] = args ? args.podExecutionRoleArn : undefined;
            inputs["selectors"] = args ? args.selectors : undefined;
            inputs["subnets"] = args ? args.subnets : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["arn"] = undefined /*out*/;
        } else {
            inputs["arn"] = undefined /*out*/;
            inputs["clusterName"] = undefined /*out*/;
            inputs["fargateProfileName"] = undefined /*out*/;
            inputs["podExecutionRoleArn"] = undefined /*out*/;
            inputs["selectors"] = undefined /*out*/;
            inputs["subnets"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(FargateProfile.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a FargateProfile resource.
 */
export interface FargateProfileArgs {
    /**
     * Name of the Cluster
     */
    clusterName: pulumi.Input<string>;
    /**
     * Name of FargateProfile
     */
    fargateProfileName?: pulumi.Input<string>;
    /**
     * The IAM policy arn for pods
     */
    podExecutionRoleArn: pulumi.Input<string>;
    selectors: pulumi.Input<pulumi.Input<inputs.eks.FargateProfileSelectorArgs>[]>;
    subnets?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * An array of key-value pairs to apply to this resource.
     */
    tags?: pulumi.Input<pulumi.Input<inputs.eks.FargateProfileTagArgs>[]>;
}
