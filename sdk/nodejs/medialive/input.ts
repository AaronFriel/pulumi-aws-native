// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html
 */
export class Input extends pulumi.CustomResource {
    /**
     * Get an existing Input resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Input {
        return new Input(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:medialive:Input';

    /**
     * Returns true if the given object is an instance of Input.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Input {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Input.__pulumiType;
    }

    public /*out*/ readonly arn!: pulumi.Output<string>;
    public readonly destinations!: pulumi.Output<string[]>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-inputdevices
     */
    public readonly inputDevices!: pulumi.Output<outputs.medialive.InputInputDeviceSettings[] | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-inputsecuritygroups
     */
    public readonly inputSecurityGroups!: pulumi.Output<string[] | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-mediaconnectflows
     */
    public readonly mediaConnectFlows!: pulumi.Output<outputs.medialive.InputMediaConnectFlowRequest[] | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-name
     */
    public readonly name!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-rolearn
     */
    public readonly roleArn!: pulumi.Output<string | undefined>;
    public readonly sources!: pulumi.Output<string[]>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-tags
     */
    public readonly tags!: pulumi.Output<any | string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-type
     */
    public readonly type!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-vpc
     */
    public readonly vpc!: pulumi.Output<outputs.medialive.InputInputVpcRequest | undefined>;

    /**
     * Create a Input resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: InputArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            inputs["destinations"] = args ? args.destinations : undefined;
            inputs["inputDevices"] = args ? args.inputDevices : undefined;
            inputs["inputSecurityGroups"] = args ? args.inputSecurityGroups : undefined;
            inputs["mediaConnectFlows"] = args ? args.mediaConnectFlows : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["roleArn"] = args ? args.roleArn : undefined;
            inputs["sources"] = args ? args.sources : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["type"] = args ? args.type : undefined;
            inputs["vpc"] = args ? args.vpc : undefined;
            inputs["arn"] = undefined /*out*/;
        } else {
            inputs["arn"] = undefined /*out*/;
            inputs["destinations"] = undefined /*out*/;
            inputs["inputDevices"] = undefined /*out*/;
            inputs["inputSecurityGroups"] = undefined /*out*/;
            inputs["mediaConnectFlows"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["roleArn"] = undefined /*out*/;
            inputs["sources"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["vpc"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Input.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Input resource.
 */
export interface InputArgs {
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-destinations
     */
    destinations?: pulumi.Input<pulumi.Input<inputs.medialive.InputInputDestinationRequestArgs>[]>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-inputdevices
     */
    inputDevices?: pulumi.Input<pulumi.Input<inputs.medialive.InputInputDeviceSettingsArgs>[]>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-inputsecuritygroups
     */
    inputSecurityGroups?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-mediaconnectflows
     */
    mediaConnectFlows?: pulumi.Input<pulumi.Input<inputs.medialive.InputMediaConnectFlowRequestArgs>[]>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-name
     */
    name?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-rolearn
     */
    roleArn?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-sources
     */
    sources?: pulumi.Input<pulumi.Input<inputs.medialive.InputInputSourceRequestArgs>[]>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-tags
     */
    tags?: pulumi.Input<any | string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-type
     */
    type?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-input.html#cfn-medialive-input-vpc
     */
    vpc?: pulumi.Input<inputs.medialive.InputInputVpcRequestArgs>;
}