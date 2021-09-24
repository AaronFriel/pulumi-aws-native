// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::WAFRegional::WebACL
 *
 * @deprecated WebACL is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class WebACL extends pulumi.CustomResource {
    /**
     * Get an existing WebACL resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): WebACL {
        pulumi.log.warn("WebACL is deprecated: WebACL is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new WebACL(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:wafregional:WebACL';

    /**
     * Returns true if the given object is an instance of WebACL.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is WebACL {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === WebACL.__pulumiType;
    }

    public readonly defaultAction!: pulumi.Output<outputs.wafregional.WebACLAction>;
    public readonly metricName!: pulumi.Output<string>;
    public readonly name!: pulumi.Output<string>;
    public readonly rules!: pulumi.Output<outputs.wafregional.WebACLRule[] | undefined>;

    /**
     * Create a WebACL resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated WebACL is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args: WebACLArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("WebACL is deprecated: WebACL is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.defaultAction === undefined) && !opts.urn) {
                throw new Error("Missing required property 'defaultAction'");
            }
            if ((!args || args.metricName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'metricName'");
            }
            if ((!args || args.name === undefined) && !opts.urn) {
                throw new Error("Missing required property 'name'");
            }
            inputs["defaultAction"] = args ? args.defaultAction : undefined;
            inputs["metricName"] = args ? args.metricName : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["rules"] = args ? args.rules : undefined;
        } else {
            inputs["defaultAction"] = undefined /*out*/;
            inputs["metricName"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["rules"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(WebACL.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a WebACL resource.
 */
export interface WebACLArgs {
    defaultAction: pulumi.Input<inputs.wafregional.WebACLActionArgs>;
    metricName: pulumi.Input<string>;
    name: pulumi.Input<string>;
    rules?: pulumi.Input<pulumi.Input<inputs.wafregional.WebACLRuleArgs>[]>;
}
