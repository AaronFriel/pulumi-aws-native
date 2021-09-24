// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::S3::Bucket
 *
 * @deprecated Bucket is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
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
        pulumi.log.warn("Bucket is deprecated: Bucket is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new Bucket(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:s3:Bucket';

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

    public readonly accelerateConfiguration!: pulumi.Output<outputs.s3.BucketAccelerateConfiguration | undefined>;
    public readonly accessControl!: pulumi.Output<string | undefined>;
    public readonly analyticsConfigurations!: pulumi.Output<outputs.s3.BucketAnalyticsConfiguration[] | undefined>;
    public /*out*/ readonly arn!: pulumi.Output<string>;
    public readonly bucketEncryption!: pulumi.Output<outputs.s3.BucketBucketEncryption | undefined>;
    public readonly bucketName!: pulumi.Output<string | undefined>;
    public readonly corsConfiguration!: pulumi.Output<outputs.s3.BucketCorsConfiguration | undefined>;
    public /*out*/ readonly domainName!: pulumi.Output<string>;
    public /*out*/ readonly dualStackDomainName!: pulumi.Output<string>;
    public readonly intelligentTieringConfigurations!: pulumi.Output<outputs.s3.BucketIntelligentTieringConfiguration[] | undefined>;
    public readonly inventoryConfigurations!: pulumi.Output<outputs.s3.BucketInventoryConfiguration[] | undefined>;
    public readonly lifecycleConfiguration!: pulumi.Output<outputs.s3.BucketLifecycleConfiguration | undefined>;
    public readonly loggingConfiguration!: pulumi.Output<outputs.s3.BucketLoggingConfiguration | undefined>;
    public readonly metricsConfigurations!: pulumi.Output<outputs.s3.BucketMetricsConfiguration[] | undefined>;
    public readonly notificationConfiguration!: pulumi.Output<outputs.s3.BucketNotificationConfiguration | undefined>;
    public readonly objectLockConfiguration!: pulumi.Output<outputs.s3.BucketObjectLockConfiguration | undefined>;
    public readonly objectLockEnabled!: pulumi.Output<boolean | undefined>;
    public readonly ownershipControls!: pulumi.Output<outputs.s3.BucketOwnershipControls | undefined>;
    public readonly publicAccessBlockConfiguration!: pulumi.Output<outputs.s3.BucketPublicAccessBlockConfiguration | undefined>;
    public /*out*/ readonly regionalDomainName!: pulumi.Output<string>;
    public readonly replicationConfiguration!: pulumi.Output<outputs.s3.BucketReplicationConfiguration | undefined>;
    public readonly tags!: pulumi.Output<outputs.s3.BucketTag[] | undefined>;
    public readonly versioningConfiguration!: pulumi.Output<outputs.s3.BucketVersioningConfiguration | undefined>;
    public readonly websiteConfiguration!: pulumi.Output<outputs.s3.BucketWebsiteConfiguration | undefined>;
    public /*out*/ readonly websiteURL!: pulumi.Output<string>;

    /**
     * Create a Bucket resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Bucket is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args?: BucketArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("Bucket is deprecated: Bucket is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            inputs["accelerateConfiguration"] = args ? args.accelerateConfiguration : undefined;
            inputs["accessControl"] = args ? args.accessControl : undefined;
            inputs["analyticsConfigurations"] = args ? args.analyticsConfigurations : undefined;
            inputs["bucketEncryption"] = args ? args.bucketEncryption : undefined;
            inputs["bucketName"] = args ? args.bucketName : undefined;
            inputs["corsConfiguration"] = args ? args.corsConfiguration : undefined;
            inputs["intelligentTieringConfigurations"] = args ? args.intelligentTieringConfigurations : undefined;
            inputs["inventoryConfigurations"] = args ? args.inventoryConfigurations : undefined;
            inputs["lifecycleConfiguration"] = args ? args.lifecycleConfiguration : undefined;
            inputs["loggingConfiguration"] = args ? args.loggingConfiguration : undefined;
            inputs["metricsConfigurations"] = args ? args.metricsConfigurations : undefined;
            inputs["notificationConfiguration"] = args ? args.notificationConfiguration : undefined;
            inputs["objectLockConfiguration"] = args ? args.objectLockConfiguration : undefined;
            inputs["objectLockEnabled"] = args ? args.objectLockEnabled : undefined;
            inputs["ownershipControls"] = args ? args.ownershipControls : undefined;
            inputs["publicAccessBlockConfiguration"] = args ? args.publicAccessBlockConfiguration : undefined;
            inputs["replicationConfiguration"] = args ? args.replicationConfiguration : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["versioningConfiguration"] = args ? args.versioningConfiguration : undefined;
            inputs["websiteConfiguration"] = args ? args.websiteConfiguration : undefined;
            inputs["arn"] = undefined /*out*/;
            inputs["domainName"] = undefined /*out*/;
            inputs["dualStackDomainName"] = undefined /*out*/;
            inputs["regionalDomainName"] = undefined /*out*/;
            inputs["websiteURL"] = undefined /*out*/;
        } else {
            inputs["accelerateConfiguration"] = undefined /*out*/;
            inputs["accessControl"] = undefined /*out*/;
            inputs["analyticsConfigurations"] = undefined /*out*/;
            inputs["arn"] = undefined /*out*/;
            inputs["bucketEncryption"] = undefined /*out*/;
            inputs["bucketName"] = undefined /*out*/;
            inputs["corsConfiguration"] = undefined /*out*/;
            inputs["domainName"] = undefined /*out*/;
            inputs["dualStackDomainName"] = undefined /*out*/;
            inputs["intelligentTieringConfigurations"] = undefined /*out*/;
            inputs["inventoryConfigurations"] = undefined /*out*/;
            inputs["lifecycleConfiguration"] = undefined /*out*/;
            inputs["loggingConfiguration"] = undefined /*out*/;
            inputs["metricsConfigurations"] = undefined /*out*/;
            inputs["notificationConfiguration"] = undefined /*out*/;
            inputs["objectLockConfiguration"] = undefined /*out*/;
            inputs["objectLockEnabled"] = undefined /*out*/;
            inputs["ownershipControls"] = undefined /*out*/;
            inputs["publicAccessBlockConfiguration"] = undefined /*out*/;
            inputs["regionalDomainName"] = undefined /*out*/;
            inputs["replicationConfiguration"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["versioningConfiguration"] = undefined /*out*/;
            inputs["websiteConfiguration"] = undefined /*out*/;
            inputs["websiteURL"] = undefined /*out*/;
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
    accelerateConfiguration?: pulumi.Input<inputs.s3.BucketAccelerateConfigurationArgs>;
    accessControl?: pulumi.Input<string>;
    analyticsConfigurations?: pulumi.Input<pulumi.Input<inputs.s3.BucketAnalyticsConfigurationArgs>[]>;
    bucketEncryption?: pulumi.Input<inputs.s3.BucketBucketEncryptionArgs>;
    bucketName?: pulumi.Input<string>;
    corsConfiguration?: pulumi.Input<inputs.s3.BucketCorsConfigurationArgs>;
    intelligentTieringConfigurations?: pulumi.Input<pulumi.Input<inputs.s3.BucketIntelligentTieringConfigurationArgs>[]>;
    inventoryConfigurations?: pulumi.Input<pulumi.Input<inputs.s3.BucketInventoryConfigurationArgs>[]>;
    lifecycleConfiguration?: pulumi.Input<inputs.s3.BucketLifecycleConfigurationArgs>;
    loggingConfiguration?: pulumi.Input<inputs.s3.BucketLoggingConfigurationArgs>;
    metricsConfigurations?: pulumi.Input<pulumi.Input<inputs.s3.BucketMetricsConfigurationArgs>[]>;
    notificationConfiguration?: pulumi.Input<inputs.s3.BucketNotificationConfigurationArgs>;
    objectLockConfiguration?: pulumi.Input<inputs.s3.BucketObjectLockConfigurationArgs>;
    objectLockEnabled?: pulumi.Input<boolean>;
    ownershipControls?: pulumi.Input<inputs.s3.BucketOwnershipControlsArgs>;
    publicAccessBlockConfiguration?: pulumi.Input<inputs.s3.BucketPublicAccessBlockConfigurationArgs>;
    replicationConfiguration?: pulumi.Input<inputs.s3.BucketReplicationConfigurationArgs>;
    tags?: pulumi.Input<pulumi.Input<inputs.s3.BucketTagArgs>[]>;
    versioningConfiguration?: pulumi.Input<inputs.s3.BucketVersioningConfigurationArgs>;
    websiteConfiguration?: pulumi.Input<inputs.s3.BucketWebsiteConfigurationArgs>;
}
