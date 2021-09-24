// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::Greengrass::Group
 *
 * @deprecated Group is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class Group extends pulumi.CustomResource {
    /**
     * Get an existing Group resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Group {
        pulumi.log.warn("Group is deprecated: Group is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new Group(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:greengrass:Group';

    /**
     * Returns true if the given object is an instance of Group.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Group {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Group.__pulumiType;
    }

    public /*out*/ readonly arn!: pulumi.Output<string>;
    public readonly initialVersion!: pulumi.Output<outputs.greengrass.GroupGroupVersion | undefined>;
    public /*out*/ readonly latestVersionArn!: pulumi.Output<string>;
    public readonly name!: pulumi.Output<string>;
    public readonly roleArn!: pulumi.Output<string | undefined>;
    public /*out*/ readonly roleAttachedAt!: pulumi.Output<string>;
    public readonly tags!: pulumi.Output<any | undefined>;

    /**
     * Create a Group resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Group is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args: GroupArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("Group is deprecated: Group is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.name === undefined) && !opts.urn) {
                throw new Error("Missing required property 'name'");
            }
            inputs["initialVersion"] = args ? args.initialVersion : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["roleArn"] = args ? args.roleArn : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["arn"] = undefined /*out*/;
            inputs["latestVersionArn"] = undefined /*out*/;
            inputs["roleAttachedAt"] = undefined /*out*/;
        } else {
            inputs["arn"] = undefined /*out*/;
            inputs["initialVersion"] = undefined /*out*/;
            inputs["latestVersionArn"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["roleArn"] = undefined /*out*/;
            inputs["roleAttachedAt"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Group.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Group resource.
 */
export interface GroupArgs {
    initialVersion?: pulumi.Input<inputs.greengrass.GroupGroupVersionArgs>;
    name: pulumi.Input<string>;
    roleArn?: pulumi.Input<string>;
    tags?: any;
}
