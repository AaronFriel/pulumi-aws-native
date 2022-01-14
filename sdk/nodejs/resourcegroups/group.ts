// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Schema for ResourceGroups::Group
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
        return new Group(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:resourcegroups:Group';

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

    /**
     * The Resource Group ARN.
     */
    public /*out*/ readonly arn!: pulumi.Output<string>;
    public readonly configuration!: pulumi.Output<outputs.resourcegroups.GroupConfigurationItem[] | undefined>;
    /**
     * The description of the resource group
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * The name of the resource group
     */
    public readonly name!: pulumi.Output<string>;
    public readonly resourceQuery!: pulumi.Output<outputs.resourcegroups.GroupResourceQuery | undefined>;
    public readonly resources!: pulumi.Output<string[] | undefined>;
    public readonly tags!: pulumi.Output<outputs.resourcegroups.GroupTag[] | undefined>;

    /**
     * Create a Group resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: GroupArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            inputs["configuration"] = args ? args.configuration : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceQuery"] = args ? args.resourceQuery : undefined;
            inputs["resources"] = args ? args.resources : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["arn"] = undefined /*out*/;
        } else {
            inputs["arn"] = undefined /*out*/;
            inputs["configuration"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["resourceQuery"] = undefined /*out*/;
            inputs["resources"] = undefined /*out*/;
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
    configuration?: pulumi.Input<pulumi.Input<inputs.resourcegroups.GroupConfigurationItemArgs>[]>;
    /**
     * The description of the resource group
     */
    description?: pulumi.Input<string>;
    /**
     * The name of the resource group
     */
    name?: pulumi.Input<string>;
    resourceQuery?: pulumi.Input<inputs.resourcegroups.GroupResourceQueryArgs>;
    resources?: pulumi.Input<pulumi.Input<string>[]>;
    tags?: pulumi.Input<pulumi.Input<inputs.resourcegroups.GroupTagArgs>[]>;
}
