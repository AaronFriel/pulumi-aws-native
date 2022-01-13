// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * The AWS::SSM::Document resource is an SSM document in AWS Systems Manager that defines the actions that Systems Manager performs, which can be used to set up and run commands on your instances.
 */
export class Document extends pulumi.CustomResource {
    /**
     * Get an existing Document resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Document {
        return new Document(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:ssm:Document';

    /**
     * Returns true if the given object is an instance of Document.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Document {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Document.__pulumiType;
    }

    /**
     * A list of key and value pairs that describe attachments to a version of a document.
     */
    public readonly attachments!: pulumi.Output<outputs.ssm.DocumentAttachmentsSource[] | undefined>;
    /**
     * The content for the Systems Manager document in JSON, YAML or String format.
     */
    public readonly content!: pulumi.Output<any>;
    /**
     * Specify the document format for the request. The document format can be either JSON or YAML. JSON is the default format.
     */
    public readonly documentFormat!: pulumi.Output<enums.ssm.DocumentFormat | undefined>;
    /**
     * The type of document to create.
     */
    public readonly documentType!: pulumi.Output<enums.ssm.DocumentType | undefined>;
    /**
     * A name for the Systems Manager document.
     */
    public readonly name!: pulumi.Output<string | undefined>;
    /**
     * A list of SSM documents required by a document. For example, an ApplicationConfiguration document requires an ApplicationConfigurationSchema document.
     */
    public readonly requires!: pulumi.Output<outputs.ssm.DocumentRequires[] | undefined>;
    /**
     * Optional metadata that you assign to a resource. Tags enable you to categorize a resource in different ways, such as by purpose, owner, or environment.
     */
    public readonly tags!: pulumi.Output<outputs.ssm.DocumentTag[] | undefined>;
    /**
     * Specify a target type to define the kinds of resources the document can run on.
     */
    public readonly targetType!: pulumi.Output<string | undefined>;
    /**
     * An optional field specifying the version of the artifact you are creating with the document. This value is unique across all versions of a document, and cannot be changed.
     */
    public readonly versionName!: pulumi.Output<string | undefined>;

    /**
     * Create a Document resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DocumentArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.content === undefined) && !opts.urn) {
                throw new Error("Missing required property 'content'");
            }
            inputs["attachments"] = args ? args.attachments : undefined;
            inputs["content"] = args ? args.content : undefined;
            inputs["documentFormat"] = args ? args.documentFormat : undefined;
            inputs["documentType"] = args ? args.documentType : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["requires"] = args ? args.requires : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["targetType"] = args ? args.targetType : undefined;
            inputs["versionName"] = args ? args.versionName : undefined;
        } else {
            inputs["attachments"] = undefined /*out*/;
            inputs["content"] = undefined /*out*/;
            inputs["documentFormat"] = undefined /*out*/;
            inputs["documentType"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["requires"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["targetType"] = undefined /*out*/;
            inputs["versionName"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Document.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Document resource.
 */
export interface DocumentArgs {
    /**
     * A list of key and value pairs that describe attachments to a version of a document.
     */
    attachments?: pulumi.Input<pulumi.Input<inputs.ssm.DocumentAttachmentsSourceArgs>[]>;
    /**
     * The content for the Systems Manager document in JSON, YAML or String format.
     */
    content: any;
    /**
     * Specify the document format for the request. The document format can be either JSON or YAML. JSON is the default format.
     */
    documentFormat?: pulumi.Input<enums.ssm.DocumentFormat>;
    /**
     * The type of document to create.
     */
    documentType?: pulumi.Input<enums.ssm.DocumentType>;
    /**
     * A name for the Systems Manager document.
     */
    name?: pulumi.Input<string>;
    /**
     * A list of SSM documents required by a document. For example, an ApplicationConfiguration document requires an ApplicationConfigurationSchema document.
     */
    requires?: pulumi.Input<pulumi.Input<inputs.ssm.DocumentRequiresArgs>[]>;
    /**
     * Optional metadata that you assign to a resource. Tags enable you to categorize a resource in different ways, such as by purpose, owner, or environment.
     */
    tags?: pulumi.Input<pulumi.Input<inputs.ssm.DocumentTagArgs>[]>;
    /**
     * Specify a target type to define the kinds of resources the document can run on.
     */
    targetType?: pulumi.Input<string>;
    /**
     * An optional field specifying the version of the artifact you are creating with the document. This value is unique across all versions of a document, and cannot be changed.
     */
    versionName?: pulumi.Input<string>;
}
