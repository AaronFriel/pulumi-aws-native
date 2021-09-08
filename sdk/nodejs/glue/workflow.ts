// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-workflow.html
 */
export class Workflow extends pulumi.CustomResource {
    /**
     * Get an existing Workflow resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Workflow {
        return new Workflow(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:glue:Workflow';

    /**
     * Returns true if the given object is an instance of Workflow.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Workflow {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Workflow.__pulumiType;
    }

    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-workflow.html#cfn-glue-workflow-defaultrunproperties
     */
    public readonly defaultRunProperties!: pulumi.Output<any | string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-workflow.html#cfn-glue-workflow-description
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-workflow.html#cfn-glue-workflow-name
     */
    public readonly name!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-workflow.html#cfn-glue-workflow-tags
     */
    public readonly tags!: pulumi.Output<any | string | undefined>;

    /**
     * Create a Workflow resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: WorkflowArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            inputs["defaultRunProperties"] = args ? args.defaultRunProperties : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["tags"] = args ? args.tags : undefined;
        } else {
            inputs["defaultRunProperties"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Workflow.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Workflow resource.
 */
export interface WorkflowArgs {
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-workflow.html#cfn-glue-workflow-defaultrunproperties
     */
    defaultRunProperties?: pulumi.Input<any | string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-workflow.html#cfn-glue-workflow-description
     */
    description?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-workflow.html#cfn-glue-workflow-name
     */
    name?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-workflow.html#cfn-glue-workflow-tags
     */
    tags?: pulumi.Input<any | string>;
}