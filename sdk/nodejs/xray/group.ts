// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * This schema provides construct and validation rules for AWS-XRay Group resource parameters.
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
    public static readonly __pulumiType = 'aws-native:xray:Group';

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
     * The filter expression defining criteria by which to group traces.
     */
    public readonly filterExpression!: pulumi.Output<string | undefined>;
    /**
     * The ARN of the group that was generated on creation.
     */
    public /*out*/ readonly groupARN!: pulumi.Output<string>;
    /**
     * The case-sensitive name of the new group. Names must be unique.
     */
    public readonly groupName!: pulumi.Output<string | undefined>;
    public readonly insightsConfiguration!: pulumi.Output<outputs.xray.GroupInsightsConfiguration | undefined>;
    public readonly tags!: pulumi.Output<any[] | undefined>;

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
            inputs["filterExpression"] = args ? args.filterExpression : undefined;
            inputs["groupName"] = args ? args.groupName : undefined;
            inputs["insightsConfiguration"] = args ? args.insightsConfiguration : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["groupARN"] = undefined /*out*/;
        } else {
            inputs["filterExpression"] = undefined /*out*/;
            inputs["groupARN"] = undefined /*out*/;
            inputs["groupName"] = undefined /*out*/;
            inputs["insightsConfiguration"] = undefined /*out*/;
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
    /**
     * The filter expression defining criteria by which to group traces.
     */
    filterExpression?: pulumi.Input<string>;
    /**
     * The case-sensitive name of the new group. Names must be unique.
     */
    groupName?: pulumi.Input<string>;
    insightsConfiguration?: pulumi.Input<inputs.xray.GroupInsightsConfigurationArgs>;
    tags?: pulumi.Input<any[]>;
}
