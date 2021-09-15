// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Creates a trail that specifies the settings for delivery of log data to an Amazon S3 bucket. A maximum of five trails can exist in a region, irrespective of the region in which they were created.
 */
export class Trail extends pulumi.CustomResource {
    /**
     * Get an existing Trail resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Trail {
        return new Trail(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:cloudtrail:Trail';

    /**
     * Returns true if the given object is an instance of Trail.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Trail {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Trail.__pulumiType;
    }

    public /*out*/ readonly arn!: pulumi.Output<string>;
    /**
     * Specifies a log group name using an Amazon Resource Name (ARN), a unique identifier that represents the log group to which CloudTrail logs will be delivered. Not required unless you specify CloudWatchLogsRoleArn.
     */
    public readonly cloudWatchLogsLogGroupArn!: pulumi.Output<string | undefined>;
    /**
     * Specifies the role for the CloudWatch Logs endpoint to assume to write to a user's log group.
     */
    public readonly cloudWatchLogsRoleArn!: pulumi.Output<string | undefined>;
    /**
     * Specifies whether log file validation is enabled. The default is false.
     */
    public readonly enableLogFileValidation!: pulumi.Output<boolean | undefined>;
    /**
     * Use event selectors to further specify the management and data event settings for your trail. By default, trails created without specific event selectors will be configured to log all read and write management events, and no data events. When an event occurs in your account, CloudTrail evaluates the event selector for all trails. For each trail, if the event matches any event selector, the trail processes and logs the event. If the event doesn't match any event selector, the trail doesn't log the event. You can configure up to five event selectors for a trail.
     */
    public readonly eventSelectors!: pulumi.Output<outputs.cloudtrail.TrailEventSelector[] | undefined>;
    /**
     * Specifies whether the trail is publishing events from global services such as IAM to the log files.
     */
    public readonly includeGlobalServiceEvents!: pulumi.Output<boolean | undefined>;
    /**
     * Lets you enable Insights event logging by specifying the Insights selectors that you want to enable on an existing trail.
     */
    public readonly insightSelectors!: pulumi.Output<outputs.cloudtrail.TrailInsightSelector[] | undefined>;
    /**
     * Whether the CloudTrail is currently logging AWS API calls.
     */
    public readonly isLogging!: pulumi.Output<boolean>;
    /**
     * Specifies whether the trail applies only to the current region or to all regions. The default is false. If the trail exists only in the current region and this value is set to true, shadow trails (replications of the trail) will be created in the other regions. If the trail exists in all regions and this value is set to false, the trail will remain in the region where it was created, and its shadow trails in other regions will be deleted. As a best practice, consider using trails that log events in all regions.
     */
    public readonly isMultiRegionTrail!: pulumi.Output<boolean | undefined>;
    /**
     * Specifies whether the trail is created for all accounts in an organization in AWS Organizations, or only for the current AWS account. The default is false, and cannot be true unless the call is made on behalf of an AWS account that is the master account for an organization in AWS Organizations.
     */
    public readonly isOrganizationTrail!: pulumi.Output<boolean | undefined>;
    /**
     * Specifies the KMS key ID to use to encrypt the logs delivered by CloudTrail. The value can be an alias name prefixed by 'alias/', a fully specified ARN to an alias, a fully specified ARN to a key, or a globally unique identifier.
     */
    public readonly kMSKeyId!: pulumi.Output<string | undefined>;
    /**
     * Specifies the name of the Amazon S3 bucket designated for publishing log files. See Amazon S3 Bucket Naming Requirements.
     */
    public readonly s3BucketName!: pulumi.Output<string>;
    /**
     * Specifies the Amazon S3 key prefix that comes after the name of the bucket you have designated for log file delivery. For more information, see Finding Your CloudTrail Log Files. The maximum length is 200 characters.
     */
    public readonly s3KeyPrefix!: pulumi.Output<string | undefined>;
    public /*out*/ readonly snsTopicArn!: pulumi.Output<string>;
    /**
     * Specifies the name of the Amazon SNS topic defined for notification of log file delivery. The maximum length is 256 characters.
     */
    public readonly snsTopicName!: pulumi.Output<string | undefined>;
    public readonly tags!: pulumi.Output<outputs.cloudtrail.TrailTag[] | undefined>;
    public readonly trailName!: pulumi.Output<string | undefined>;

    /**
     * Create a Trail resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: TrailArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.isLogging === undefined) && !opts.urn) {
                throw new Error("Missing required property 'isLogging'");
            }
            if ((!args || args.s3BucketName === undefined) && !opts.urn) {
                throw new Error("Missing required property 's3BucketName'");
            }
            inputs["cloudWatchLogsLogGroupArn"] = args ? args.cloudWatchLogsLogGroupArn : undefined;
            inputs["cloudWatchLogsRoleArn"] = args ? args.cloudWatchLogsRoleArn : undefined;
            inputs["enableLogFileValidation"] = args ? args.enableLogFileValidation : undefined;
            inputs["eventSelectors"] = args ? args.eventSelectors : undefined;
            inputs["includeGlobalServiceEvents"] = args ? args.includeGlobalServiceEvents : undefined;
            inputs["insightSelectors"] = args ? args.insightSelectors : undefined;
            inputs["isLogging"] = args ? args.isLogging : undefined;
            inputs["isMultiRegionTrail"] = args ? args.isMultiRegionTrail : undefined;
            inputs["isOrganizationTrail"] = args ? args.isOrganizationTrail : undefined;
            inputs["kMSKeyId"] = args ? args.kMSKeyId : undefined;
            inputs["s3BucketName"] = args ? args.s3BucketName : undefined;
            inputs["s3KeyPrefix"] = args ? args.s3KeyPrefix : undefined;
            inputs["snsTopicName"] = args ? args.snsTopicName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["trailName"] = args ? args.trailName : undefined;
            inputs["arn"] = undefined /*out*/;
            inputs["snsTopicArn"] = undefined /*out*/;
        } else {
            inputs["arn"] = undefined /*out*/;
            inputs["cloudWatchLogsLogGroupArn"] = undefined /*out*/;
            inputs["cloudWatchLogsRoleArn"] = undefined /*out*/;
            inputs["enableLogFileValidation"] = undefined /*out*/;
            inputs["eventSelectors"] = undefined /*out*/;
            inputs["includeGlobalServiceEvents"] = undefined /*out*/;
            inputs["insightSelectors"] = undefined /*out*/;
            inputs["isLogging"] = undefined /*out*/;
            inputs["isMultiRegionTrail"] = undefined /*out*/;
            inputs["isOrganizationTrail"] = undefined /*out*/;
            inputs["kMSKeyId"] = undefined /*out*/;
            inputs["s3BucketName"] = undefined /*out*/;
            inputs["s3KeyPrefix"] = undefined /*out*/;
            inputs["snsTopicArn"] = undefined /*out*/;
            inputs["snsTopicName"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["trailName"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Trail.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Trail resource.
 */
export interface TrailArgs {
    /**
     * Specifies a log group name using an Amazon Resource Name (ARN), a unique identifier that represents the log group to which CloudTrail logs will be delivered. Not required unless you specify CloudWatchLogsRoleArn.
     */
    cloudWatchLogsLogGroupArn?: pulumi.Input<string>;
    /**
     * Specifies the role for the CloudWatch Logs endpoint to assume to write to a user's log group.
     */
    cloudWatchLogsRoleArn?: pulumi.Input<string>;
    /**
     * Specifies whether log file validation is enabled. The default is false.
     */
    enableLogFileValidation?: pulumi.Input<boolean>;
    /**
     * Use event selectors to further specify the management and data event settings for your trail. By default, trails created without specific event selectors will be configured to log all read and write management events, and no data events. When an event occurs in your account, CloudTrail evaluates the event selector for all trails. For each trail, if the event matches any event selector, the trail processes and logs the event. If the event doesn't match any event selector, the trail doesn't log the event. You can configure up to five event selectors for a trail.
     */
    eventSelectors?: pulumi.Input<pulumi.Input<inputs.cloudtrail.TrailEventSelectorArgs>[]>;
    /**
     * Specifies whether the trail is publishing events from global services such as IAM to the log files.
     */
    includeGlobalServiceEvents?: pulumi.Input<boolean>;
    /**
     * Lets you enable Insights event logging by specifying the Insights selectors that you want to enable on an existing trail.
     */
    insightSelectors?: pulumi.Input<pulumi.Input<inputs.cloudtrail.TrailInsightSelectorArgs>[]>;
    /**
     * Whether the CloudTrail is currently logging AWS API calls.
     */
    isLogging: pulumi.Input<boolean>;
    /**
     * Specifies whether the trail applies only to the current region or to all regions. The default is false. If the trail exists only in the current region and this value is set to true, shadow trails (replications of the trail) will be created in the other regions. If the trail exists in all regions and this value is set to false, the trail will remain in the region where it was created, and its shadow trails in other regions will be deleted. As a best practice, consider using trails that log events in all regions.
     */
    isMultiRegionTrail?: pulumi.Input<boolean>;
    /**
     * Specifies whether the trail is created for all accounts in an organization in AWS Organizations, or only for the current AWS account. The default is false, and cannot be true unless the call is made on behalf of an AWS account that is the master account for an organization in AWS Organizations.
     */
    isOrganizationTrail?: pulumi.Input<boolean>;
    /**
     * Specifies the KMS key ID to use to encrypt the logs delivered by CloudTrail. The value can be an alias name prefixed by 'alias/', a fully specified ARN to an alias, a fully specified ARN to a key, or a globally unique identifier.
     */
    kMSKeyId?: pulumi.Input<string>;
    /**
     * Specifies the name of the Amazon S3 bucket designated for publishing log files. See Amazon S3 Bucket Naming Requirements.
     */
    s3BucketName: pulumi.Input<string>;
    /**
     * Specifies the Amazon S3 key prefix that comes after the name of the bucket you have designated for log file delivery. For more information, see Finding Your CloudTrail Log Files. The maximum length is 200 characters.
     */
    s3KeyPrefix?: pulumi.Input<string>;
    /**
     * Specifies the name of the Amazon SNS topic defined for notification of log file delivery. The maximum length is 256 characters.
     */
    snsTopicName?: pulumi.Input<string>;
    tags?: pulumi.Input<pulumi.Input<inputs.cloudtrail.TrailTagArgs>[]>;
    trailName?: pulumi.Input<string>;
}
