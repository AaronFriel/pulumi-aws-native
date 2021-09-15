// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Version: None. Resource Type definition for AWS::DynamoDB::GlobalTable
 */
export class GlobalTable extends pulumi.CustomResource {
    /**
     * Get an existing GlobalTable resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): GlobalTable {
        return new GlobalTable(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:dynamodb:GlobalTable';

    /**
     * Returns true if the given object is an instance of GlobalTable.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is GlobalTable {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === GlobalTable.__pulumiType;
    }

    public /*out*/ readonly arn!: pulumi.Output<string>;
    public readonly attributeDefinitions!: pulumi.Output<outputs.dynamodb.GlobalTableAttributeDefinition[]>;
    public readonly billingMode!: pulumi.Output<string | undefined>;
    public readonly globalSecondaryIndexes!: pulumi.Output<outputs.dynamodb.GlobalTableGlobalSecondaryIndex[] | undefined>;
    public readonly keySchema!: pulumi.Output<outputs.dynamodb.GlobalTableKeySchema[]>;
    public readonly localSecondaryIndexes!: pulumi.Output<outputs.dynamodb.GlobalTableLocalSecondaryIndex[] | undefined>;
    public readonly replicas!: pulumi.Output<outputs.dynamodb.GlobalTableReplicaSpecification[]>;
    public readonly sSESpecification!: pulumi.Output<outputs.dynamodb.GlobalTableSSESpecification | undefined>;
    public /*out*/ readonly streamArn!: pulumi.Output<string>;
    public readonly streamSpecification!: pulumi.Output<outputs.dynamodb.GlobalTableStreamSpecification | undefined>;
    public /*out*/ readonly tableId!: pulumi.Output<string>;
    public readonly tableName!: pulumi.Output<string | undefined>;
    public readonly timeToLiveSpecification!: pulumi.Output<outputs.dynamodb.GlobalTableTimeToLiveSpecification | undefined>;
    public readonly writeProvisionedThroughputSettings!: pulumi.Output<outputs.dynamodb.GlobalTableWriteProvisionedThroughputSettings | undefined>;

    /**
     * Create a GlobalTable resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: GlobalTableArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.attributeDefinitions === undefined) && !opts.urn) {
                throw new Error("Missing required property 'attributeDefinitions'");
            }
            if ((!args || args.keySchema === undefined) && !opts.urn) {
                throw new Error("Missing required property 'keySchema'");
            }
            if ((!args || args.replicas === undefined) && !opts.urn) {
                throw new Error("Missing required property 'replicas'");
            }
            inputs["attributeDefinitions"] = args ? args.attributeDefinitions : undefined;
            inputs["billingMode"] = args ? args.billingMode : undefined;
            inputs["globalSecondaryIndexes"] = args ? args.globalSecondaryIndexes : undefined;
            inputs["keySchema"] = args ? args.keySchema : undefined;
            inputs["localSecondaryIndexes"] = args ? args.localSecondaryIndexes : undefined;
            inputs["replicas"] = args ? args.replicas : undefined;
            inputs["sSESpecification"] = args ? args.sSESpecification : undefined;
            inputs["streamSpecification"] = args ? args.streamSpecification : undefined;
            inputs["tableName"] = args ? args.tableName : undefined;
            inputs["timeToLiveSpecification"] = args ? args.timeToLiveSpecification : undefined;
            inputs["writeProvisionedThroughputSettings"] = args ? args.writeProvisionedThroughputSettings : undefined;
            inputs["arn"] = undefined /*out*/;
            inputs["streamArn"] = undefined /*out*/;
            inputs["tableId"] = undefined /*out*/;
        } else {
            inputs["arn"] = undefined /*out*/;
            inputs["attributeDefinitions"] = undefined /*out*/;
            inputs["billingMode"] = undefined /*out*/;
            inputs["globalSecondaryIndexes"] = undefined /*out*/;
            inputs["keySchema"] = undefined /*out*/;
            inputs["localSecondaryIndexes"] = undefined /*out*/;
            inputs["replicas"] = undefined /*out*/;
            inputs["sSESpecification"] = undefined /*out*/;
            inputs["streamArn"] = undefined /*out*/;
            inputs["streamSpecification"] = undefined /*out*/;
            inputs["tableId"] = undefined /*out*/;
            inputs["tableName"] = undefined /*out*/;
            inputs["timeToLiveSpecification"] = undefined /*out*/;
            inputs["writeProvisionedThroughputSettings"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(GlobalTable.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a GlobalTable resource.
 */
export interface GlobalTableArgs {
    attributeDefinitions: pulumi.Input<pulumi.Input<inputs.dynamodb.GlobalTableAttributeDefinitionArgs>[]>;
    billingMode?: pulumi.Input<string>;
    globalSecondaryIndexes?: pulumi.Input<pulumi.Input<inputs.dynamodb.GlobalTableGlobalSecondaryIndexArgs>[]>;
    keySchema: pulumi.Input<pulumi.Input<inputs.dynamodb.GlobalTableKeySchemaArgs>[]>;
    localSecondaryIndexes?: pulumi.Input<pulumi.Input<inputs.dynamodb.GlobalTableLocalSecondaryIndexArgs>[]>;
    replicas: pulumi.Input<pulumi.Input<inputs.dynamodb.GlobalTableReplicaSpecificationArgs>[]>;
    sSESpecification?: pulumi.Input<inputs.dynamodb.GlobalTableSSESpecificationArgs>;
    streamSpecification?: pulumi.Input<inputs.dynamodb.GlobalTableStreamSpecificationArgs>;
    tableName?: pulumi.Input<string>;
    timeToLiveSpecification?: pulumi.Input<inputs.dynamodb.GlobalTableTimeToLiveSpecificationArgs>;
    writeProvisionedThroughputSettings?: pulumi.Input<inputs.dynamodb.GlobalTableWriteProvisionedThroughputSettingsArgs>;
}
