// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::WAF::SqlInjectionMatchSet
 *
 * @deprecated SqlInjectionMatchSet is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class SqlInjectionMatchSet extends pulumi.CustomResource {
    /**
     * Get an existing SqlInjectionMatchSet resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): SqlInjectionMatchSet {
        pulumi.log.warn("SqlInjectionMatchSet is deprecated: SqlInjectionMatchSet is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new SqlInjectionMatchSet(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:waf:SqlInjectionMatchSet';

    /**
     * Returns true if the given object is an instance of SqlInjectionMatchSet.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SqlInjectionMatchSet {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SqlInjectionMatchSet.__pulumiType;
    }

    public readonly name!: pulumi.Output<string>;
    public readonly sqlInjectionMatchTuples!: pulumi.Output<outputs.waf.SqlInjectionMatchSetSqlInjectionMatchTuple[] | undefined>;

    /**
     * Create a SqlInjectionMatchSet resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated SqlInjectionMatchSet is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args: SqlInjectionMatchSetArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("SqlInjectionMatchSet is deprecated: SqlInjectionMatchSet is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.name === undefined) && !opts.urn) {
                throw new Error("Missing required property 'name'");
            }
            inputs["name"] = args ? args.name : undefined;
            inputs["sqlInjectionMatchTuples"] = args ? args.sqlInjectionMatchTuples : undefined;
        } else {
            inputs["name"] = undefined /*out*/;
            inputs["sqlInjectionMatchTuples"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(SqlInjectionMatchSet.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a SqlInjectionMatchSet resource.
 */
export interface SqlInjectionMatchSetArgs {
    name: pulumi.Input<string>;
    sqlInjectionMatchTuples?: pulumi.Input<pulumi.Input<inputs.waf.SqlInjectionMatchSetSqlInjectionMatchTupleArgs>[]>;
}
