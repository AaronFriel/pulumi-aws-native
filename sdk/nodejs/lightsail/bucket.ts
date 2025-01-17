// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::Lightsail::Bucket
 */
export class Bucket extends pulumi.CustomResource {
    /**
     * Get an existing Bucket resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Bucket {
        return new Bucket(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:lightsail:Bucket';

    /**
     * Returns true if the given object is an instance of Bucket.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Bucket {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Bucket.__pulumiType;
    }

    /**
     * Indicates whether the bundle that is currently applied to a bucket can be changed to another bundle. You can update a bucket's bundle only one time within a monthly AWS billing cycle.
     */
    public /*out*/ readonly ableToUpdateBundle!: pulumi.Output<boolean>;
    public readonly accessRules!: pulumi.Output<outputs.lightsail.BucketAccessRules | undefined>;
    public /*out*/ readonly bucketArn!: pulumi.Output<string>;
    /**
     * The name for the bucket.
     */
    public readonly bucketName!: pulumi.Output<string>;
    /**
     * The ID of the bundle to use for the bucket.
     */
    public readonly bundleId!: pulumi.Output<string>;
    /**
     * Specifies whether to enable or disable versioning of objects in the bucket.
     */
    public readonly objectVersioning!: pulumi.Output<boolean | undefined>;
    /**
     * An array of strings to specify the AWS account IDs that can access the bucket.
     */
    public readonly readOnlyAccessAccounts!: pulumi.Output<string[] | undefined>;
    /**
     * The names of the Lightsail resources for which to set bucket access.
     */
    public readonly resourcesReceivingAccess!: pulumi.Output<string[] | undefined>;
    /**
     * An array of key-value pairs to apply to this resource.
     */
    public readonly tags!: pulumi.Output<outputs.lightsail.BucketTag[] | undefined>;
    /**
     * The URL of the bucket.
     */
    public /*out*/ readonly url!: pulumi.Output<string>;

    /**
     * Create a Bucket resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: BucketArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.bundleId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'bundleId'");
            }
            inputs["accessRules"] = args ? args.accessRules : undefined;
            inputs["bucketName"] = args ? args.bucketName : undefined;
            inputs["bundleId"] = args ? args.bundleId : undefined;
            inputs["objectVersioning"] = args ? args.objectVersioning : undefined;
            inputs["readOnlyAccessAccounts"] = args ? args.readOnlyAccessAccounts : undefined;
            inputs["resourcesReceivingAccess"] = args ? args.resourcesReceivingAccess : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["ableToUpdateBundle"] = undefined /*out*/;
            inputs["bucketArn"] = undefined /*out*/;
            inputs["url"] = undefined /*out*/;
        } else {
            inputs["ableToUpdateBundle"] = undefined /*out*/;
            inputs["accessRules"] = undefined /*out*/;
            inputs["bucketArn"] = undefined /*out*/;
            inputs["bucketName"] = undefined /*out*/;
            inputs["bundleId"] = undefined /*out*/;
            inputs["objectVersioning"] = undefined /*out*/;
            inputs["readOnlyAccessAccounts"] = undefined /*out*/;
            inputs["resourcesReceivingAccess"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["url"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Bucket.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Bucket resource.
 */
export interface BucketArgs {
    accessRules?: pulumi.Input<inputs.lightsail.BucketAccessRulesArgs>;
    /**
     * The name for the bucket.
     */
    bucketName?: pulumi.Input<string>;
    /**
     * The ID of the bundle to use for the bucket.
     */
    bundleId: pulumi.Input<string>;
    /**
     * Specifies whether to enable or disable versioning of objects in the bucket.
     */
    objectVersioning?: pulumi.Input<boolean>;
    /**
     * An array of strings to specify the AWS account IDs that can access the bucket.
     */
    readOnlyAccessAccounts?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The names of the Lightsail resources for which to set bucket access.
     */
    resourcesReceivingAccess?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * An array of key-value pairs to apply to this resource.
     */
    tags?: pulumi.Input<pulumi.Input<inputs.lightsail.BucketTagArgs>[]>;
}
