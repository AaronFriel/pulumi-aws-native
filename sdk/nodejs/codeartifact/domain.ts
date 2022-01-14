// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * The resource schema to create a CodeArtifact domain.
 */
export class Domain extends pulumi.CustomResource {
    /**
     * Get an existing Domain resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Domain {
        return new Domain(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:codeartifact:Domain';

    /**
     * Returns true if the given object is an instance of Domain.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Domain {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Domain.__pulumiType;
    }

    /**
     * The ARN of the domain.
     */
    public /*out*/ readonly arn!: pulumi.Output<string>;
    /**
     * The name of the domain.
     */
    public readonly domainName!: pulumi.Output<string>;
    /**
     * The ARN of an AWS Key Management Service (AWS KMS) key associated with a domain.
     */
    public /*out*/ readonly encryptionKey!: pulumi.Output<string>;
    /**
     * The name of the domain. This field is used for GetAtt
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The 12-digit account ID of the AWS account that owns the domain. This field is used for GetAtt
     */
    public /*out*/ readonly owner!: pulumi.Output<string>;
    /**
     * The access control resource policy on the provided domain.
     */
    public readonly permissionsPolicyDocument!: pulumi.Output<any | undefined>;
    /**
     * An array of key-value pairs to apply to this resource.
     */
    public readonly tags!: pulumi.Output<outputs.codeartifact.DomainTag[] | undefined>;

    /**
     * Create a Domain resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: DomainArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            inputs["domainName"] = args ? args.domainName : undefined;
            inputs["permissionsPolicyDocument"] = args ? args.permissionsPolicyDocument : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["arn"] = undefined /*out*/;
            inputs["encryptionKey"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["owner"] = undefined /*out*/;
        } else {
            inputs["arn"] = undefined /*out*/;
            inputs["domainName"] = undefined /*out*/;
            inputs["encryptionKey"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["owner"] = undefined /*out*/;
            inputs["permissionsPolicyDocument"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Domain.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Domain resource.
 */
export interface DomainArgs {
    /**
     * The name of the domain.
     */
    domainName?: pulumi.Input<string>;
    /**
     * The access control resource policy on the provided domain.
     */
    permissionsPolicyDocument?: any;
    /**
     * An array of key-value pairs to apply to this resource.
     */
    tags?: pulumi.Input<pulumi.Input<inputs.codeartifact.DomainTagArgs>[]>;
}
