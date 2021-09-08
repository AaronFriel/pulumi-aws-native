// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-datastore.html
 */
export class Datastore extends pulumi.CustomResource {
    /**
     * Get an existing Datastore resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Datastore {
        return new Datastore(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:iotanalytics:Datastore';

    /**
     * Returns true if the given object is an instance of Datastore.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Datastore {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Datastore.__pulumiType;
    }

    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-datastore.html#cfn-iotanalytics-datastore-datastorename
     */
    public readonly datastoreName!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-datastore.html#cfn-iotanalytics-datastore-datastorepartitions
     */
    public readonly datastorePartitions!: pulumi.Output<outputs.iotanalytics.DatastoreDatastorePartitions | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-datastore.html#cfn-iotanalytics-datastore-datastorestorage
     */
    public readonly datastoreStorage!: pulumi.Output<outputs.iotanalytics.DatastoreDatastoreStorage | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-datastore.html#cfn-iotanalytics-datastore-fileformatconfiguration
     */
    public readonly fileFormatConfiguration!: pulumi.Output<outputs.iotanalytics.DatastoreFileFormatConfiguration | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-datastore.html#cfn-iotanalytics-datastore-retentionperiod
     */
    public readonly retentionPeriod!: pulumi.Output<outputs.iotanalytics.DatastoreRetentionPeriod | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-datastore.html#cfn-iotanalytics-datastore-tags
     */
    public readonly tags!: pulumi.Output<outputs.Tag[] | undefined>;

    /**
     * Create a Datastore resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: DatastoreArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            inputs["datastoreName"] = args ? args.datastoreName : undefined;
            inputs["datastorePartitions"] = args ? args.datastorePartitions : undefined;
            inputs["datastoreStorage"] = args ? args.datastoreStorage : undefined;
            inputs["fileFormatConfiguration"] = args ? args.fileFormatConfiguration : undefined;
            inputs["retentionPeriod"] = args ? args.retentionPeriod : undefined;
            inputs["tags"] = args ? args.tags : undefined;
        } else {
            inputs["datastoreName"] = undefined /*out*/;
            inputs["datastorePartitions"] = undefined /*out*/;
            inputs["datastoreStorage"] = undefined /*out*/;
            inputs["fileFormatConfiguration"] = undefined /*out*/;
            inputs["retentionPeriod"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Datastore.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Datastore resource.
 */
export interface DatastoreArgs {
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-datastore.html#cfn-iotanalytics-datastore-datastorename
     */
    datastoreName?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-datastore.html#cfn-iotanalytics-datastore-datastorepartitions
     */
    datastorePartitions?: pulumi.Input<inputs.iotanalytics.DatastoreDatastorePartitionsArgs>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-datastore.html#cfn-iotanalytics-datastore-datastorestorage
     */
    datastoreStorage?: pulumi.Input<inputs.iotanalytics.DatastoreDatastoreStorageArgs>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-datastore.html#cfn-iotanalytics-datastore-fileformatconfiguration
     */
    fileFormatConfiguration?: pulumi.Input<inputs.iotanalytics.DatastoreFileFormatConfigurationArgs>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-datastore.html#cfn-iotanalytics-datastore-retentionperiod
     */
    retentionPeriod?: pulumi.Input<inputs.iotanalytics.DatastoreRetentionPeriodArgs>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-datastore.html#cfn-iotanalytics-datastore-tags
     */
    tags?: pulumi.Input<pulumi.Input<inputs.TagArgs>[]>;
}