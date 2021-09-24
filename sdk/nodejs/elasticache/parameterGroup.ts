// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::ElastiCache::ParameterGroup
 *
 * @deprecated ParameterGroup is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class ParameterGroup extends pulumi.CustomResource {
    /**
     * Get an existing ParameterGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ParameterGroup {
        pulumi.log.warn("ParameterGroup is deprecated: ParameterGroup is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new ParameterGroup(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:elasticache:ParameterGroup';

    /**
     * Returns true if the given object is an instance of ParameterGroup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ParameterGroup {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ParameterGroup.__pulumiType;
    }

    public readonly cacheParameterGroupFamily!: pulumi.Output<string>;
    public readonly description!: pulumi.Output<string>;
    public readonly properties!: pulumi.Output<any | undefined>;
    public readonly tags!: pulumi.Output<outputs.elasticache.ParameterGroupTag[] | undefined>;

    /**
     * Create a ParameterGroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated ParameterGroup is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args: ParameterGroupArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("ParameterGroup is deprecated: ParameterGroup is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.cacheParameterGroupFamily === undefined) && !opts.urn) {
                throw new Error("Missing required property 'cacheParameterGroupFamily'");
            }
            if ((!args || args.description === undefined) && !opts.urn) {
                throw new Error("Missing required property 'description'");
            }
            inputs["cacheParameterGroupFamily"] = args ? args.cacheParameterGroupFamily : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["properties"] = args ? args.properties : undefined;
            inputs["tags"] = args ? args.tags : undefined;
        } else {
            inputs["cacheParameterGroupFamily"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["properties"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(ParameterGroup.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ParameterGroup resource.
 */
export interface ParameterGroupArgs {
    cacheParameterGroupFamily: pulumi.Input<string>;
    description: pulumi.Input<string>;
    properties?: any;
    tags?: pulumi.Input<pulumi.Input<inputs.elasticache.ParameterGroupTagArgs>[]>;
}
