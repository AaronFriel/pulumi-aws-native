// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * A Kendra index
 */
export class Index extends pulumi.CustomResource {
    /**
     * Get an existing Index resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Index {
        return new Index(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:kendra:Index';

    /**
     * Returns true if the given object is an instance of Index.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Index {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Index.__pulumiType;
    }

    public /*out*/ readonly arn!: pulumi.Output<string>;
    /**
     * Capacity units
     */
    public readonly capacityUnits!: pulumi.Output<outputs.kendra.IndexCapacityUnitsConfiguration | undefined>;
    /**
     * A description for the index
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Document metadata configurations
     */
    public readonly documentMetadataConfigurations!: pulumi.Output<outputs.kendra.IndexDocumentMetadataConfiguration[] | undefined>;
    public readonly edition!: pulumi.Output<enums.kendra.IndexEdition>;
    public readonly name!: pulumi.Output<string>;
    public readonly roleArn!: pulumi.Output<string>;
    /**
     * Server side encryption configuration
     */
    public readonly serverSideEncryptionConfiguration!: pulumi.Output<outputs.kendra.IndexServerSideEncryptionConfiguration | undefined>;
    /**
     * Tags for labeling the index
     */
    public readonly tags!: pulumi.Output<outputs.kendra.IndexTag[] | undefined>;
    public readonly userContextPolicy!: pulumi.Output<enums.kendra.IndexUserContextPolicy | undefined>;
    public readonly userTokenConfigurations!: pulumi.Output<outputs.kendra.IndexUserTokenConfiguration[] | undefined>;

    /**
     * Create a Index resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: IndexArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.edition === undefined) && !opts.urn) {
                throw new Error("Missing required property 'edition'");
            }
            if ((!args || args.roleArn === undefined) && !opts.urn) {
                throw new Error("Missing required property 'roleArn'");
            }
            inputs["capacityUnits"] = args ? args.capacityUnits : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["documentMetadataConfigurations"] = args ? args.documentMetadataConfigurations : undefined;
            inputs["edition"] = args ? args.edition : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["roleArn"] = args ? args.roleArn : undefined;
            inputs["serverSideEncryptionConfiguration"] = args ? args.serverSideEncryptionConfiguration : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["userContextPolicy"] = args ? args.userContextPolicy : undefined;
            inputs["userTokenConfigurations"] = args ? args.userTokenConfigurations : undefined;
            inputs["arn"] = undefined /*out*/;
        } else {
            inputs["arn"] = undefined /*out*/;
            inputs["capacityUnits"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["documentMetadataConfigurations"] = undefined /*out*/;
            inputs["edition"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["roleArn"] = undefined /*out*/;
            inputs["serverSideEncryptionConfiguration"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["userContextPolicy"] = undefined /*out*/;
            inputs["userTokenConfigurations"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Index.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Index resource.
 */
export interface IndexArgs {
    /**
     * Capacity units
     */
    capacityUnits?: pulumi.Input<inputs.kendra.IndexCapacityUnitsConfigurationArgs>;
    /**
     * A description for the index
     */
    description?: pulumi.Input<string>;
    /**
     * Document metadata configurations
     */
    documentMetadataConfigurations?: pulumi.Input<pulumi.Input<inputs.kendra.IndexDocumentMetadataConfigurationArgs>[]>;
    edition: pulumi.Input<enums.kendra.IndexEdition>;
    name?: pulumi.Input<string>;
    roleArn: pulumi.Input<string>;
    /**
     * Server side encryption configuration
     */
    serverSideEncryptionConfiguration?: pulumi.Input<inputs.kendra.IndexServerSideEncryptionConfigurationArgs>;
    /**
     * Tags for labeling the index
     */
    tags?: pulumi.Input<pulumi.Input<inputs.kendra.IndexTagArgs>[]>;
    userContextPolicy?: pulumi.Input<enums.kendra.IndexUserContextPolicy>;
    userTokenConfigurations?: pulumi.Input<pulumi.Input<inputs.kendra.IndexUserTokenConfigurationArgs>[]>;
}
