// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::Config::StoredQuery
 */
export class StoredQuery extends pulumi.CustomResource {
    /**
     * Get an existing StoredQuery resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): StoredQuery {
        return new StoredQuery(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:configuration:StoredQuery';

    /**
     * Returns true if the given object is an instance of StoredQuery.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is StoredQuery {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === StoredQuery.__pulumiType;
    }

    public /*out*/ readonly queryArn!: pulumi.Output<string>;
    public readonly queryDescription!: pulumi.Output<string | undefined>;
    public readonly queryExpression!: pulumi.Output<string>;
    public /*out*/ readonly queryId!: pulumi.Output<string>;
    public readonly queryName!: pulumi.Output<string>;
    /**
     * The tags for the stored query.
     */
    public readonly tags!: pulumi.Output<outputs.configuration.StoredQueryTag[] | undefined>;

    /**
     * Create a StoredQuery resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: StoredQueryArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.queryExpression === undefined) && !opts.urn) {
                throw new Error("Missing required property 'queryExpression'");
            }
            if ((!args || args.queryName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'queryName'");
            }
            inputs["queryDescription"] = args ? args.queryDescription : undefined;
            inputs["queryExpression"] = args ? args.queryExpression : undefined;
            inputs["queryName"] = args ? args.queryName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["queryArn"] = undefined /*out*/;
            inputs["queryId"] = undefined /*out*/;
        } else {
            inputs["queryArn"] = undefined /*out*/;
            inputs["queryDescription"] = undefined /*out*/;
            inputs["queryExpression"] = undefined /*out*/;
            inputs["queryId"] = undefined /*out*/;
            inputs["queryName"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(StoredQuery.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a StoredQuery resource.
 */
export interface StoredQueryArgs {
    queryDescription?: pulumi.Input<string>;
    queryExpression: pulumi.Input<string>;
    queryName: pulumi.Input<string>;
    /**
     * The tags for the stored query.
     */
    tags?: pulumi.Input<pulumi.Input<inputs.configuration.StoredQueryTagArgs>[]>;
}
