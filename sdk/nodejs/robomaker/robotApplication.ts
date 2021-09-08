// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-robotapplication.html
 */
export class RobotApplication extends pulumi.CustomResource {
    /**
     * Get an existing RobotApplication resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): RobotApplication {
        return new RobotApplication(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:robomaker:RobotApplication';

    /**
     * Returns true if the given object is an instance of RobotApplication.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is RobotApplication {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === RobotApplication.__pulumiType;
    }

    public /*out*/ readonly arn!: pulumi.Output<string>;
    public readonly currentRevisionId!: pulumi.Output<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-robotapplication.html#cfn-robomaker-robotapplication-name
     */
    public readonly name!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-robotapplication.html#cfn-robomaker-robotapplication-robotsoftwaresuite
     */
    public readonly robotSoftwareSuite!: pulumi.Output<outputs.robomaker.RobotApplicationRobotSoftwareSuite>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-robotapplication.html#cfn-robomaker-robotapplication-sources
     */
    public readonly sources!: pulumi.Output<outputs.robomaker.RobotApplicationSourceConfig[]>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-robotapplication.html#cfn-robomaker-robotapplication-tags
     */
    public readonly tags!: pulumi.Output<any | string | undefined>;

    /**
     * Create a RobotApplication resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: RobotApplicationArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.robotSoftwareSuite === undefined) && !opts.urn) {
                throw new Error("Missing required property 'robotSoftwareSuite'");
            }
            if ((!args || args.sources === undefined) && !opts.urn) {
                throw new Error("Missing required property 'sources'");
            }
            inputs["currentRevisionId"] = args ? args.currentRevisionId : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["robotSoftwareSuite"] = args ? args.robotSoftwareSuite : undefined;
            inputs["sources"] = args ? args.sources : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["arn"] = undefined /*out*/;
        } else {
            inputs["arn"] = undefined /*out*/;
            inputs["currentRevisionId"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["robotSoftwareSuite"] = undefined /*out*/;
            inputs["sources"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(RobotApplication.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a RobotApplication resource.
 */
export interface RobotApplicationArgs {
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-robotapplication.html#cfn-robomaker-robotapplication-currentrevisionid
     */
    currentRevisionId?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-robotapplication.html#cfn-robomaker-robotapplication-name
     */
    name?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-robotapplication.html#cfn-robomaker-robotapplication-robotsoftwaresuite
     */
    robotSoftwareSuite: pulumi.Input<inputs.robomaker.RobotApplicationRobotSoftwareSuiteArgs>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-robotapplication.html#cfn-robomaker-robotapplication-sources
     */
    sources: pulumi.Input<pulumi.Input<inputs.robomaker.RobotApplicationSourceConfigArgs>[]>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-robotapplication.html#cfn-robomaker-robotapplication-tags
     */
    tags?: pulumi.Input<any | string>;
}