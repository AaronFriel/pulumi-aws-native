// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type Definition for Resiliency Policy.
 */
export class ResiliencyPolicy extends pulumi.CustomResource {
    /**
     * Get an existing ResiliencyPolicy resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ResiliencyPolicy {
        return new ResiliencyPolicy(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:resiliencehub:ResiliencyPolicy';

    /**
     * Returns true if the given object is an instance of ResiliencyPolicy.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ResiliencyPolicy {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ResiliencyPolicy.__pulumiType;
    }

    /**
     * Data Location Constraint of the Policy.
     */
    public readonly dataLocationConstraint!: pulumi.Output<enums.resiliencehub.ResiliencyPolicyDataLocationConstraint | undefined>;
    public readonly policy!: pulumi.Output<outputs.resiliencehub.ResiliencyPolicyPolicyMap>;
    /**
     * Amazon Resource Name (ARN) of the Resiliency Policy.
     */
    public /*out*/ readonly policyArn!: pulumi.Output<string>;
    /**
     * Description of Resiliency Policy.
     */
    public readonly policyDescription!: pulumi.Output<string | undefined>;
    /**
     * Name of Resiliency Policy.
     */
    public readonly policyName!: pulumi.Output<string>;
    public readonly tags!: pulumi.Output<outputs.resiliencehub.ResiliencyPolicyTagMap | undefined>;
    /**
     * Resiliency Policy Tier.
     */
    public readonly tier!: pulumi.Output<enums.resiliencehub.ResiliencyPolicyTier>;

    /**
     * Create a ResiliencyPolicy resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ResiliencyPolicyArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.policy === undefined) && !opts.urn) {
                throw new Error("Missing required property 'policy'");
            }
            if ((!args || args.policyName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'policyName'");
            }
            if ((!args || args.tier === undefined) && !opts.urn) {
                throw new Error("Missing required property 'tier'");
            }
            inputs["dataLocationConstraint"] = args ? args.dataLocationConstraint : undefined;
            inputs["policy"] = args ? args.policy : undefined;
            inputs["policyDescription"] = args ? args.policyDescription : undefined;
            inputs["policyName"] = args ? args.policyName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["tier"] = args ? args.tier : undefined;
            inputs["policyArn"] = undefined /*out*/;
        } else {
            inputs["dataLocationConstraint"] = undefined /*out*/;
            inputs["policy"] = undefined /*out*/;
            inputs["policyArn"] = undefined /*out*/;
            inputs["policyDescription"] = undefined /*out*/;
            inputs["policyName"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["tier"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(ResiliencyPolicy.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ResiliencyPolicy resource.
 */
export interface ResiliencyPolicyArgs {
    /**
     * Data Location Constraint of the Policy.
     */
    dataLocationConstraint?: pulumi.Input<enums.resiliencehub.ResiliencyPolicyDataLocationConstraint>;
    policy: pulumi.Input<inputs.resiliencehub.ResiliencyPolicyPolicyMapArgs>;
    /**
     * Description of Resiliency Policy.
     */
    policyDescription?: pulumi.Input<string>;
    /**
     * Name of Resiliency Policy.
     */
    policyName: pulumi.Input<string>;
    tags?: pulumi.Input<inputs.resiliencehub.ResiliencyPolicyTagMapArgs>;
    /**
     * Resiliency Policy Tier.
     */
    tier: pulumi.Input<enums.resiliencehub.ResiliencyPolicyTier>;
}
