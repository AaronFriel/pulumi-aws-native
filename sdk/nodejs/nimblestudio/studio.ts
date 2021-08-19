// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-studio.html
 */
export class Studio extends pulumi.CustomResource {
    /**
     * Get an existing Studio resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Studio {
        return new Studio(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:NimbleStudio:Studio';

    /**
     * Returns true if the given object is an instance of Studio.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Studio {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Studio.__pulumiType;
    }

    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-studio.html#cfn-nimblestudio-studio-adminrolearn
     */
    public readonly adminRoleArn!: pulumi.Output<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-studio.html#cfn-nimblestudio-studio-displayname
     */
    public readonly displayName!: pulumi.Output<string>;
    public /*out*/ readonly homeRegion!: pulumi.Output<string>;
    public /*out*/ readonly ssoClientId!: pulumi.Output<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-studio.html#cfn-nimblestudio-studio-studioencryptionconfiguration
     */
    public readonly studioEncryptionConfiguration!: pulumi.Output<outputs.NimbleStudio.StudioStudioEncryptionConfiguration | undefined>;
    public /*out*/ readonly studioId!: pulumi.Output<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-studio.html#cfn-nimblestudio-studio-studioname
     */
    public readonly studioName!: pulumi.Output<string>;
    public /*out*/ readonly studioUrl!: pulumi.Output<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-studio.html#cfn-nimblestudio-studio-tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-studio.html#cfn-nimblestudio-studio-userrolearn
     */
    public readonly userRoleArn!: pulumi.Output<string>;

    /**
     * Create a Studio resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: StudioArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.adminRoleArn === undefined) && !opts.urn) {
                throw new Error("Missing required property 'adminRoleArn'");
            }
            if ((!args || args.displayName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'displayName'");
            }
            if ((!args || args.studioName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'studioName'");
            }
            if ((!args || args.userRoleArn === undefined) && !opts.urn) {
                throw new Error("Missing required property 'userRoleArn'");
            }
            inputs["adminRoleArn"] = args ? args.adminRoleArn : undefined;
            inputs["displayName"] = args ? args.displayName : undefined;
            inputs["studioEncryptionConfiguration"] = args ? args.studioEncryptionConfiguration : undefined;
            inputs["studioName"] = args ? args.studioName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["userRoleArn"] = args ? args.userRoleArn : undefined;
            inputs["homeRegion"] = undefined /*out*/;
            inputs["ssoClientId"] = undefined /*out*/;
            inputs["studioId"] = undefined /*out*/;
            inputs["studioUrl"] = undefined /*out*/;
        } else {
            inputs["adminRoleArn"] = undefined /*out*/;
            inputs["displayName"] = undefined /*out*/;
            inputs["homeRegion"] = undefined /*out*/;
            inputs["ssoClientId"] = undefined /*out*/;
            inputs["studioEncryptionConfiguration"] = undefined /*out*/;
            inputs["studioId"] = undefined /*out*/;
            inputs["studioName"] = undefined /*out*/;
            inputs["studioUrl"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["userRoleArn"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Studio.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Studio resource.
 */
export interface StudioArgs {
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-studio.html#cfn-nimblestudio-studio-adminrolearn
     */
    adminRoleArn: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-studio.html#cfn-nimblestudio-studio-displayname
     */
    displayName: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-studio.html#cfn-nimblestudio-studio-studioencryptionconfiguration
     */
    studioEncryptionConfiguration?: pulumi.Input<inputs.NimbleStudio.StudioStudioEncryptionConfigurationArgs>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-studio.html#cfn-nimblestudio-studio-studioname
     */
    studioName: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-studio.html#cfn-nimblestudio-studio-tags
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-nimblestudio-studio.html#cfn-nimblestudio-studio-userrolearn
     */
    userRoleArn: pulumi.Input<string>;
}