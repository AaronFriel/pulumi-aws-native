// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Resource schema for AWS::Cassandra::Table
 */
export class Table extends pulumi.CustomResource {
    /**
     * Get an existing Table resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Table {
        return new Table(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:cassandra:Table';

    /**
     * Returns true if the given object is an instance of Table.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Table {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Table.__pulumiType;
    }

    public readonly billingMode!: pulumi.Output<outputs.cassandra.TableBillingMode | undefined>;
    /**
     * Clustering key columns of the table
     */
    public readonly clusteringKeyColumns!: pulumi.Output<outputs.cassandra.TableClusteringKeyColumn[] | undefined>;
    public readonly encryptionSpecification!: pulumi.Output<outputs.cassandra.TableEncryptionSpecification | undefined>;
    /**
     * Name for Cassandra keyspace
     */
    public readonly keyspaceName!: pulumi.Output<string>;
    /**
     * Partition key columns of the table
     */
    public readonly partitionKeyColumns!: pulumi.Output<outputs.cassandra.TableColumn[]>;
    /**
     * Indicates whether point in time recovery is enabled (true) or disabled (false) on the table
     */
    public readonly pointInTimeRecoveryEnabled!: pulumi.Output<boolean | undefined>;
    /**
     * Non-key columns of the table
     */
    public readonly regularColumns!: pulumi.Output<outputs.cassandra.TableColumn[] | undefined>;
    /**
     * Name for Cassandra table
     */
    public readonly tableName!: pulumi.Output<string | undefined>;
    /**
     * An array of key-value pairs to apply to this resource
     */
    public readonly tags!: pulumi.Output<outputs.cassandra.TableTag[] | undefined>;

    /**
     * Create a Table resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: TableArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.keyspaceName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'keyspaceName'");
            }
            if ((!args || args.partitionKeyColumns === undefined) && !opts.urn) {
                throw new Error("Missing required property 'partitionKeyColumns'");
            }
            inputs["billingMode"] = args ? args.billingMode : undefined;
            inputs["clusteringKeyColumns"] = args ? args.clusteringKeyColumns : undefined;
            inputs["encryptionSpecification"] = args ? args.encryptionSpecification : undefined;
            inputs["keyspaceName"] = args ? args.keyspaceName : undefined;
            inputs["partitionKeyColumns"] = args ? args.partitionKeyColumns : undefined;
            inputs["pointInTimeRecoveryEnabled"] = args ? args.pointInTimeRecoveryEnabled : undefined;
            inputs["regularColumns"] = args ? args.regularColumns : undefined;
            inputs["tableName"] = args ? args.tableName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
        } else {
            inputs["billingMode"] = undefined /*out*/;
            inputs["clusteringKeyColumns"] = undefined /*out*/;
            inputs["encryptionSpecification"] = undefined /*out*/;
            inputs["keyspaceName"] = undefined /*out*/;
            inputs["partitionKeyColumns"] = undefined /*out*/;
            inputs["pointInTimeRecoveryEnabled"] = undefined /*out*/;
            inputs["regularColumns"] = undefined /*out*/;
            inputs["tableName"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Table.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Table resource.
 */
export interface TableArgs {
    billingMode?: pulumi.Input<inputs.cassandra.TableBillingModeArgs>;
    /**
     * Clustering key columns of the table
     */
    clusteringKeyColumns?: pulumi.Input<pulumi.Input<inputs.cassandra.TableClusteringKeyColumnArgs>[]>;
    encryptionSpecification?: pulumi.Input<inputs.cassandra.TableEncryptionSpecificationArgs>;
    /**
     * Name for Cassandra keyspace
     */
    keyspaceName: pulumi.Input<string>;
    /**
     * Partition key columns of the table
     */
    partitionKeyColumns: pulumi.Input<pulumi.Input<inputs.cassandra.TableColumnArgs>[]>;
    /**
     * Indicates whether point in time recovery is enabled (true) or disabled (false) on the table
     */
    pointInTimeRecoveryEnabled?: pulumi.Input<boolean>;
    /**
     * Non-key columns of the table
     */
    regularColumns?: pulumi.Input<pulumi.Input<inputs.cassandra.TableColumnArgs>[]>;
    /**
     * Name for Cassandra table
     */
    tableName?: pulumi.Input<string>;
    /**
     * An array of key-value pairs to apply to this resource
     */
    tags?: pulumi.Input<pulumi.Input<inputs.cassandra.TableTagArgs>[]>;
}
