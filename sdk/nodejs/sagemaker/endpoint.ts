// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::SageMaker::Endpoint
 *
 * @deprecated Endpoint is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class Endpoint extends pulumi.CustomResource {
    /**
     * Get an existing Endpoint resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Endpoint {
        pulumi.log.warn("Endpoint is deprecated: Endpoint is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new Endpoint(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:sagemaker:Endpoint';

    /**
     * Returns true if the given object is an instance of Endpoint.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Endpoint {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Endpoint.__pulumiType;
    }

    public readonly deploymentConfig!: pulumi.Output<outputs.sagemaker.EndpointDeploymentConfig | undefined>;
    public readonly endpointConfigName!: pulumi.Output<string>;
    public readonly endpointName!: pulumi.Output<string | undefined>;
    public readonly excludeRetainedVariantProperties!: pulumi.Output<outputs.sagemaker.EndpointVariantProperty[] | undefined>;
    public readonly retainAllVariantProperties!: pulumi.Output<boolean | undefined>;
    public readonly tags!: pulumi.Output<outputs.sagemaker.EndpointTag[] | undefined>;

    /**
     * Create a Endpoint resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Endpoint is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args: EndpointArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("Endpoint is deprecated: Endpoint is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.endpointConfigName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'endpointConfigName'");
            }
            inputs["deploymentConfig"] = args ? args.deploymentConfig : undefined;
            inputs["endpointConfigName"] = args ? args.endpointConfigName : undefined;
            inputs["endpointName"] = args ? args.endpointName : undefined;
            inputs["excludeRetainedVariantProperties"] = args ? args.excludeRetainedVariantProperties : undefined;
            inputs["retainAllVariantProperties"] = args ? args.retainAllVariantProperties : undefined;
            inputs["tags"] = args ? args.tags : undefined;
        } else {
            inputs["deploymentConfig"] = undefined /*out*/;
            inputs["endpointConfigName"] = undefined /*out*/;
            inputs["endpointName"] = undefined /*out*/;
            inputs["excludeRetainedVariantProperties"] = undefined /*out*/;
            inputs["retainAllVariantProperties"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Endpoint.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Endpoint resource.
 */
export interface EndpointArgs {
    deploymentConfig?: pulumi.Input<inputs.sagemaker.EndpointDeploymentConfigArgs>;
    endpointConfigName: pulumi.Input<string>;
    endpointName?: pulumi.Input<string>;
    excludeRetainedVariantProperties?: pulumi.Input<pulumi.Input<inputs.sagemaker.EndpointVariantPropertyArgs>[]>;
    retainAllVariantProperties?: pulumi.Input<boolean>;
    tags?: pulumi.Input<pulumi.Input<inputs.sagemaker.EndpointTagArgs>[]>;
}
