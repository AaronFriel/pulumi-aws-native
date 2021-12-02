// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * A resource policy with specified policy statements that attaches to a Lex bot or bot alias.
 *
 * @deprecated ResourcePolicy is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class ResourcePolicy extends pulumi.CustomResource {
    /**
     * Get an existing ResourcePolicy resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ResourcePolicy {
        pulumi.log.warn("ResourcePolicy is deprecated: ResourcePolicy is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new ResourcePolicy(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:lex:ResourcePolicy';

    /**
     * Returns true if the given object is an instance of ResourcePolicy.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ResourcePolicy {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ResourcePolicy.__pulumiType;
    }

    public readonly policy!: pulumi.Output<outputs.lex.ResourcePolicyPolicy>;
    public readonly resourceArn!: pulumi.Output<string>;
    public /*out*/ readonly revisionId!: pulumi.Output<string>;

    /**
     * Create a ResourcePolicy resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated ResourcePolicy is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args: ResourcePolicyArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("ResourcePolicy is deprecated: ResourcePolicy is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.policy === undefined) && !opts.urn) {
                throw new Error("Missing required property 'policy'");
            }
            if ((!args || args.resourceArn === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceArn'");
            }
            inputs["policy"] = args ? args.policy : undefined;
            inputs["resourceArn"] = args ? args.resourceArn : undefined;
            inputs["revisionId"] = undefined /*out*/;
        } else {
            inputs["policy"] = undefined /*out*/;
            inputs["resourceArn"] = undefined /*out*/;
            inputs["revisionId"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(ResourcePolicy.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ResourcePolicy resource.
 */
export interface ResourcePolicyArgs {
    policy: pulumi.Input<inputs.lex.ResourcePolicyPolicyArgs>;
    resourceArn: pulumi.Input<string>;
}