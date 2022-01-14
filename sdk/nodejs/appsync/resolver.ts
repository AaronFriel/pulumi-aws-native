// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::AppSync::Resolver
 *
 * @deprecated Resolver is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class Resolver extends pulumi.CustomResource {
    /**
     * Get an existing Resolver resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Resolver {
        pulumi.log.warn("Resolver is deprecated: Resolver is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new Resolver(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:appsync:Resolver';

    /**
     * Returns true if the given object is an instance of Resolver.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Resolver {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Resolver.__pulumiType;
    }

    public readonly apiId!: pulumi.Output<string>;
    public readonly cachingConfig!: pulumi.Output<outputs.appsync.ResolverCachingConfig | undefined>;
    public readonly dataSourceName!: pulumi.Output<string | undefined>;
    public readonly fieldName!: pulumi.Output<string>;
    public readonly kind!: pulumi.Output<string | undefined>;
    public readonly pipelineConfig!: pulumi.Output<outputs.appsync.ResolverPipelineConfig | undefined>;
    public readonly requestMappingTemplate!: pulumi.Output<string | undefined>;
    public readonly requestMappingTemplateS3Location!: pulumi.Output<string | undefined>;
    public /*out*/ readonly resolverArn!: pulumi.Output<string>;
    public readonly responseMappingTemplate!: pulumi.Output<string | undefined>;
    public readonly responseMappingTemplateS3Location!: pulumi.Output<string | undefined>;
    public readonly syncConfig!: pulumi.Output<outputs.appsync.ResolverSyncConfig | undefined>;
    public readonly typeName!: pulumi.Output<string>;

    /**
     * Create a Resolver resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Resolver is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args: ResolverArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("Resolver is deprecated: Resolver is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.apiId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'apiId'");
            }
            if ((!args || args.fieldName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'fieldName'");
            }
            if ((!args || args.typeName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'typeName'");
            }
            inputs["apiId"] = args ? args.apiId : undefined;
            inputs["cachingConfig"] = args ? args.cachingConfig : undefined;
            inputs["dataSourceName"] = args ? args.dataSourceName : undefined;
            inputs["fieldName"] = args ? args.fieldName : undefined;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["pipelineConfig"] = args ? args.pipelineConfig : undefined;
            inputs["requestMappingTemplate"] = args ? args.requestMappingTemplate : undefined;
            inputs["requestMappingTemplateS3Location"] = args ? args.requestMappingTemplateS3Location : undefined;
            inputs["responseMappingTemplate"] = args ? args.responseMappingTemplate : undefined;
            inputs["responseMappingTemplateS3Location"] = args ? args.responseMappingTemplateS3Location : undefined;
            inputs["syncConfig"] = args ? args.syncConfig : undefined;
            inputs["typeName"] = args ? args.typeName : undefined;
            inputs["resolverArn"] = undefined /*out*/;
        } else {
            inputs["apiId"] = undefined /*out*/;
            inputs["cachingConfig"] = undefined /*out*/;
            inputs["dataSourceName"] = undefined /*out*/;
            inputs["fieldName"] = undefined /*out*/;
            inputs["kind"] = undefined /*out*/;
            inputs["pipelineConfig"] = undefined /*out*/;
            inputs["requestMappingTemplate"] = undefined /*out*/;
            inputs["requestMappingTemplateS3Location"] = undefined /*out*/;
            inputs["resolverArn"] = undefined /*out*/;
            inputs["responseMappingTemplate"] = undefined /*out*/;
            inputs["responseMappingTemplateS3Location"] = undefined /*out*/;
            inputs["syncConfig"] = undefined /*out*/;
            inputs["typeName"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Resolver.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Resolver resource.
 */
export interface ResolverArgs {
    apiId: pulumi.Input<string>;
    cachingConfig?: pulumi.Input<inputs.appsync.ResolverCachingConfigArgs>;
    dataSourceName?: pulumi.Input<string>;
    fieldName: pulumi.Input<string>;
    kind?: pulumi.Input<string>;
    pipelineConfig?: pulumi.Input<inputs.appsync.ResolverPipelineConfigArgs>;
    requestMappingTemplate?: pulumi.Input<string>;
    requestMappingTemplateS3Location?: pulumi.Input<string>;
    responseMappingTemplate?: pulumi.Input<string>;
    responseMappingTemplateS3Location?: pulumi.Input<string>;
    syncConfig?: pulumi.Input<inputs.appsync.ResolverSyncConfigArgs>;
    typeName: pulumi.Input<string>;
}
