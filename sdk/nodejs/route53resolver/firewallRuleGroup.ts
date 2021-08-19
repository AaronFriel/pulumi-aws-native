// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-firewallrulegroup.html
 */
export class FirewallRuleGroup extends pulumi.CustomResource {
    /**
     * Get an existing FirewallRuleGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): FirewallRuleGroup {
        return new FirewallRuleGroup(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:Route53Resolver:FirewallRuleGroup';

    /**
     * Returns true if the given object is an instance of FirewallRuleGroup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is FirewallRuleGroup {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === FirewallRuleGroup.__pulumiType;
    }

    public /*out*/ readonly arn!: pulumi.Output<string>;
    public /*out*/ readonly creationTime!: pulumi.Output<string>;
    public /*out*/ readonly creatorRequestId!: pulumi.Output<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-firewallrulegroup.html#cfn-route53resolver-firewallrulegroup-firewallrules
     */
    public readonly firewallRules!: pulumi.Output<outputs.Route53Resolver.FirewallRuleGroupFirewallRule[] | undefined>;
    public /*out*/ readonly id!: pulumi.Output<string>;
    public /*out*/ readonly modificationTime!: pulumi.Output<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-firewallrulegroup.html#cfn-route53resolver-firewallrulegroup-name
     */
    public readonly name!: pulumi.Output<string | undefined>;
    public /*out*/ readonly ownerId!: pulumi.Output<string>;
    public /*out*/ readonly ruleCount!: pulumi.Output<number>;
    public /*out*/ readonly shareStatus!: pulumi.Output<string>;
    public /*out*/ readonly status!: pulumi.Output<string>;
    public /*out*/ readonly statusMessage!: pulumi.Output<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-firewallrulegroup.html#cfn-route53resolver-firewallrulegroup-tags
     */
    public readonly tags!: pulumi.Output<outputs.Tag[] | undefined>;

    /**
     * Create a FirewallRuleGroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: FirewallRuleGroupArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            inputs["firewallRules"] = args ? args.firewallRules : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["arn"] = undefined /*out*/;
            inputs["creationTime"] = undefined /*out*/;
            inputs["creatorRequestId"] = undefined /*out*/;
            inputs["id"] = undefined /*out*/;
            inputs["modificationTime"] = undefined /*out*/;
            inputs["ownerId"] = undefined /*out*/;
            inputs["ruleCount"] = undefined /*out*/;
            inputs["shareStatus"] = undefined /*out*/;
            inputs["status"] = undefined /*out*/;
            inputs["statusMessage"] = undefined /*out*/;
        } else {
            inputs["arn"] = undefined /*out*/;
            inputs["creationTime"] = undefined /*out*/;
            inputs["creatorRequestId"] = undefined /*out*/;
            inputs["firewallRules"] = undefined /*out*/;
            inputs["id"] = undefined /*out*/;
            inputs["modificationTime"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["ownerId"] = undefined /*out*/;
            inputs["ruleCount"] = undefined /*out*/;
            inputs["shareStatus"] = undefined /*out*/;
            inputs["status"] = undefined /*out*/;
            inputs["statusMessage"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(FirewallRuleGroup.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a FirewallRuleGroup resource.
 */
export interface FirewallRuleGroupArgs {
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-firewallrulegroup.html#cfn-route53resolver-firewallrulegroup-firewallrules
     */
    firewallRules?: pulumi.Input<pulumi.Input<inputs.Route53Resolver.FirewallRuleGroupFirewallRuleArgs>[]>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-firewallrulegroup.html#cfn-route53resolver-firewallrulegroup-name
     */
    name?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-firewallrulegroup.html#cfn-route53resolver-firewallrulegroup-tags
     */
    tags?: pulumi.Input<pulumi.Input<inputs.TagArgs>[]>;
}