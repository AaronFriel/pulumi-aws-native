// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoveryreadiness-cell.html
 */
export class Cell extends pulumi.CustomResource {
    /**
     * Get an existing Cell resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Cell {
        return new Cell(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:Route53RecoveryReadiness:Cell';

    /**
     * Returns true if the given object is an instance of Cell.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Cell {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Cell.__pulumiType;
    }

    public /*out*/ readonly cellArn!: pulumi.Output<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoveryreadiness-cell.html#cfn-route53recoveryreadiness-cell-cellname
     */
    public readonly cellName!: pulumi.Output<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoveryreadiness-cell.html#cfn-route53recoveryreadiness-cell-cells
     */
    public readonly cells!: pulumi.Output<string[] | undefined>;
    public /*out*/ readonly parentReadinessScopes!: pulumi.Output<string[]>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoveryreadiness-cell.html#cfn-route53recoveryreadiness-cell-tags
     */
    public readonly tags!: pulumi.Output<outputs.Tag[] | undefined>;

    /**
     * Create a Cell resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: CellArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.cellName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'cellName'");
            }
            inputs["cellName"] = args ? args.cellName : undefined;
            inputs["cells"] = args ? args.cells : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["cellArn"] = undefined /*out*/;
            inputs["parentReadinessScopes"] = undefined /*out*/;
        } else {
            inputs["cellArn"] = undefined /*out*/;
            inputs["cellName"] = undefined /*out*/;
            inputs["cells"] = undefined /*out*/;
            inputs["parentReadinessScopes"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Cell.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Cell resource.
 */
export interface CellArgs {
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoveryreadiness-cell.html#cfn-route53recoveryreadiness-cell-cellname
     */
    cellName: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoveryreadiness-cell.html#cfn-route53recoveryreadiness-cell-cells
     */
    cells?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoveryreadiness-cell.html#cfn-route53recoveryreadiness-cell-tags
     */
    tags?: pulumi.Input<pulumi.Input<inputs.TagArgs>[]>;
}