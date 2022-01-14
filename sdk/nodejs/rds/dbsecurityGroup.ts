// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::RDS::DBSecurityGroup
 *
 * @deprecated DBSecurityGroup is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class DBSecurityGroup extends pulumi.CustomResource {
    /**
     * Get an existing DBSecurityGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): DBSecurityGroup {
        pulumi.log.warn("DBSecurityGroup is deprecated: DBSecurityGroup is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new DBSecurityGroup(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:rds:DBSecurityGroup';

    /**
     * Returns true if the given object is an instance of DBSecurityGroup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DBSecurityGroup {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DBSecurityGroup.__pulumiType;
    }

    public readonly dBSecurityGroupIngress!: pulumi.Output<outputs.rds.DBSecurityGroupIngress[]>;
    public readonly eC2VpcId!: pulumi.Output<string | undefined>;
    public readonly groupDescription!: pulumi.Output<string>;
    public readonly tags!: pulumi.Output<outputs.rds.DBSecurityGroupTag[] | undefined>;

    /**
     * Create a DBSecurityGroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated DBSecurityGroup is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args: DBSecurityGroupArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("DBSecurityGroup is deprecated: DBSecurityGroup is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.dBSecurityGroupIngress === undefined) && !opts.urn) {
                throw new Error("Missing required property 'dBSecurityGroupIngress'");
            }
            if ((!args || args.groupDescription === undefined) && !opts.urn) {
                throw new Error("Missing required property 'groupDescription'");
            }
            inputs["dBSecurityGroupIngress"] = args ? args.dBSecurityGroupIngress : undefined;
            inputs["eC2VpcId"] = args ? args.eC2VpcId : undefined;
            inputs["groupDescription"] = args ? args.groupDescription : undefined;
            inputs["tags"] = args ? args.tags : undefined;
        } else {
            inputs["dBSecurityGroupIngress"] = undefined /*out*/;
            inputs["eC2VpcId"] = undefined /*out*/;
            inputs["groupDescription"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(DBSecurityGroup.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a DBSecurityGroup resource.
 */
export interface DBSecurityGroupArgs {
    dBSecurityGroupIngress: pulumi.Input<pulumi.Input<inputs.rds.DBSecurityGroupIngressArgs>[]>;
    eC2VpcId?: pulumi.Input<string>;
    groupDescription: pulumi.Input<string>;
    tags?: pulumi.Input<pulumi.Input<inputs.rds.DBSecurityGroupTagArgs>[]>;
}
