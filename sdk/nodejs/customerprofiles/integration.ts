// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * The resource schema for creating an Amazon Connect Customer Profiles Integration.
 */
export class Integration extends pulumi.CustomResource {
    /**
     * Get an existing Integration resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Integration {
        return new Integration(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:customerprofiles:Integration';

    /**
     * Returns true if the given object is an instance of Integration.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Integration {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Integration.__pulumiType;
    }

    /**
     * The time of this integration got created
     */
    public /*out*/ readonly createdAt!: pulumi.Output<string>;
    /**
     * The unique name of the domain.
     */
    public readonly domainName!: pulumi.Output<string>;
    public readonly flowDefinition!: pulumi.Output<outputs.customerprofiles.IntegrationFlowDefinition | undefined>;
    /**
     * The time of this integration got last updated at
     */
    public /*out*/ readonly lastUpdatedAt!: pulumi.Output<string>;
    /**
     * The name of the ObjectType defined for the 3rd party data in Profile Service
     */
    public readonly objectTypeName!: pulumi.Output<string>;
    /**
     * The tags (keys and values) associated with the integration
     */
    public readonly tags!: pulumi.Output<outputs.customerprofiles.IntegrationTag[] | undefined>;
    /**
     * The URI of the S3 bucket or any other type of data source.
     */
    public readonly uri!: pulumi.Output<string | undefined>;

    /**
     * Create a Integration resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: IntegrationArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.domainName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'domainName'");
            }
            if ((!args || args.objectTypeName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'objectTypeName'");
            }
            inputs["domainName"] = args ? args.domainName : undefined;
            inputs["flowDefinition"] = args ? args.flowDefinition : undefined;
            inputs["objectTypeName"] = args ? args.objectTypeName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["uri"] = args ? args.uri : undefined;
            inputs["createdAt"] = undefined /*out*/;
            inputs["lastUpdatedAt"] = undefined /*out*/;
        } else {
            inputs["createdAt"] = undefined /*out*/;
            inputs["domainName"] = undefined /*out*/;
            inputs["flowDefinition"] = undefined /*out*/;
            inputs["lastUpdatedAt"] = undefined /*out*/;
            inputs["objectTypeName"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["uri"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Integration.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Integration resource.
 */
export interface IntegrationArgs {
    /**
     * The unique name of the domain.
     */
    domainName: pulumi.Input<string>;
    flowDefinition?: pulumi.Input<inputs.customerprofiles.IntegrationFlowDefinitionArgs>;
    /**
     * The name of the ObjectType defined for the 3rd party data in Profile Service
     */
    objectTypeName: pulumi.Input<string>;
    /**
     * The tags (keys and values) associated with the integration
     */
    tags?: pulumi.Input<pulumi.Input<inputs.customerprofiles.IntegrationTagArgs>[]>;
    /**
     * The URI of the S3 bucket or any other type of data source.
     */
    uri?: pulumi.Input<string>;
}
