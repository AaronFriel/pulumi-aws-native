// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * This resource adds Key-Value metadata to a Schema version of Glue Schema Registry.
 */
export class SchemaVersionMetadata extends pulumi.CustomResource {
    /**
     * Get an existing SchemaVersionMetadata resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): SchemaVersionMetadata {
        return new SchemaVersionMetadata(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:glue:SchemaVersionMetadata';

    /**
     * Returns true if the given object is an instance of SchemaVersionMetadata.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SchemaVersionMetadata {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SchemaVersionMetadata.__pulumiType;
    }

    /**
     * Metadata key
     */
    public readonly key!: pulumi.Output<string>;
    /**
     * Represents the version ID associated with the schema version.
     */
    public readonly schemaVersionId!: pulumi.Output<string>;
    /**
     * Metadata value
     */
    public readonly value!: pulumi.Output<string>;

    /**
     * Create a SchemaVersionMetadata resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SchemaVersionMetadataArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.key === undefined) && !opts.urn) {
                throw new Error("Missing required property 'key'");
            }
            if ((!args || args.schemaVersionId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'schemaVersionId'");
            }
            if ((!args || args.value === undefined) && !opts.urn) {
                throw new Error("Missing required property 'value'");
            }
            inputs["key"] = args ? args.key : undefined;
            inputs["schemaVersionId"] = args ? args.schemaVersionId : undefined;
            inputs["value"] = args ? args.value : undefined;
        } else {
            inputs["key"] = undefined /*out*/;
            inputs["schemaVersionId"] = undefined /*out*/;
            inputs["value"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(SchemaVersionMetadata.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a SchemaVersionMetadata resource.
 */
export interface SchemaVersionMetadataArgs {
    /**
     * Metadata key
     */
    key: pulumi.Input<string>;
    /**
     * Represents the version ID associated with the schema version.
     */
    schemaVersionId: pulumi.Input<string>;
    /**
     * Metadata value
     */
    value: pulumi.Input<string>;
}
