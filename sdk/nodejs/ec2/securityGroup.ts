// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::EC2::SecurityGroup
 *
 * @deprecated SecurityGroup is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class SecurityGroup extends pulumi.CustomResource {
    /**
     * Get an existing SecurityGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): SecurityGroup {
        pulumi.log.warn("SecurityGroup is deprecated: SecurityGroup is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new SecurityGroup(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:ec2:SecurityGroup';

    /**
     * Returns true if the given object is an instance of SecurityGroup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SecurityGroup {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SecurityGroup.__pulumiType;
    }

    public readonly groupDescription!: pulumi.Output<string>;
    public /*out*/ readonly groupId!: pulumi.Output<string>;
    public readonly groupName!: pulumi.Output<string | undefined>;
    public readonly securityGroupEgress!: pulumi.Output<outputs.ec2.SecurityGroupEgress[] | undefined>;
    public readonly securityGroupIngress!: pulumi.Output<outputs.ec2.SecurityGroupIngress[] | undefined>;
    public readonly tags!: pulumi.Output<outputs.ec2.SecurityGroupTag[] | undefined>;
    public readonly vpcId!: pulumi.Output<string | undefined>;

    /**
     * Create a SecurityGroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated SecurityGroup is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args: SecurityGroupArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("SecurityGroup is deprecated: SecurityGroup is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.groupDescription === undefined) && !opts.urn) {
                throw new Error("Missing required property 'groupDescription'");
            }
            inputs["groupDescription"] = args ? args.groupDescription : undefined;
            inputs["groupName"] = args ? args.groupName : undefined;
            inputs["securityGroupEgress"] = args ? args.securityGroupEgress : undefined;
            inputs["securityGroupIngress"] = args ? args.securityGroupIngress : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["vpcId"] = args ? args.vpcId : undefined;
            inputs["groupId"] = undefined /*out*/;
        } else {
            inputs["groupDescription"] = undefined /*out*/;
            inputs["groupId"] = undefined /*out*/;
            inputs["groupName"] = undefined /*out*/;
            inputs["securityGroupEgress"] = undefined /*out*/;
            inputs["securityGroupIngress"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["vpcId"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(SecurityGroup.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a SecurityGroup resource.
 */
export interface SecurityGroupArgs {
    groupDescription: pulumi.Input<string>;
    groupName?: pulumi.Input<string>;
    securityGroupEgress?: pulumi.Input<pulumi.Input<inputs.ec2.SecurityGroupEgressArgs>[]>;
    securityGroupIngress?: pulumi.Input<pulumi.Input<inputs.ec2.SecurityGroupIngressArgs>[]>;
    tags?: pulumi.Input<pulumi.Input<inputs.ec2.SecurityGroupTagArgs>[]>;
    vpcId?: pulumi.Input<string>;
}
