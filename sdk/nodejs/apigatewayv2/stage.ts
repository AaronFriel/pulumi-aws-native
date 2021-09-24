// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::ApiGatewayV2::Stage
 *
 * @deprecated Stage is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class Stage extends pulumi.CustomResource {
    /**
     * Get an existing Stage resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Stage {
        pulumi.log.warn("Stage is deprecated: Stage is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new Stage(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:apigatewayv2:Stage';

    /**
     * Returns true if the given object is an instance of Stage.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Stage {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Stage.__pulumiType;
    }

    public readonly accessLogSettings!: pulumi.Output<outputs.apigatewayv2.StageAccessLogSettings | undefined>;
    public readonly accessPolicyId!: pulumi.Output<string | undefined>;
    public readonly apiId!: pulumi.Output<string>;
    public readonly autoDeploy!: pulumi.Output<boolean | undefined>;
    public readonly clientCertificateId!: pulumi.Output<string | undefined>;
    public readonly defaultRouteSettings!: pulumi.Output<outputs.apigatewayv2.StageRouteSettings | undefined>;
    public readonly deploymentId!: pulumi.Output<string | undefined>;
    public readonly description!: pulumi.Output<string | undefined>;
    public readonly routeSettings!: pulumi.Output<any | undefined>;
    public readonly stageName!: pulumi.Output<string>;
    public readonly stageVariables!: pulumi.Output<any | undefined>;
    public readonly tags!: pulumi.Output<any | undefined>;

    /**
     * Create a Stage resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Stage is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args: StageArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("Stage is deprecated: Stage is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.apiId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'apiId'");
            }
            if ((!args || args.stageName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'stageName'");
            }
            inputs["accessLogSettings"] = args ? args.accessLogSettings : undefined;
            inputs["accessPolicyId"] = args ? args.accessPolicyId : undefined;
            inputs["apiId"] = args ? args.apiId : undefined;
            inputs["autoDeploy"] = args ? args.autoDeploy : undefined;
            inputs["clientCertificateId"] = args ? args.clientCertificateId : undefined;
            inputs["defaultRouteSettings"] = args ? args.defaultRouteSettings : undefined;
            inputs["deploymentId"] = args ? args.deploymentId : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["routeSettings"] = args ? args.routeSettings : undefined;
            inputs["stageName"] = args ? args.stageName : undefined;
            inputs["stageVariables"] = args ? args.stageVariables : undefined;
            inputs["tags"] = args ? args.tags : undefined;
        } else {
            inputs["accessLogSettings"] = undefined /*out*/;
            inputs["accessPolicyId"] = undefined /*out*/;
            inputs["apiId"] = undefined /*out*/;
            inputs["autoDeploy"] = undefined /*out*/;
            inputs["clientCertificateId"] = undefined /*out*/;
            inputs["defaultRouteSettings"] = undefined /*out*/;
            inputs["deploymentId"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["routeSettings"] = undefined /*out*/;
            inputs["stageName"] = undefined /*out*/;
            inputs["stageVariables"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Stage.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Stage resource.
 */
export interface StageArgs {
    accessLogSettings?: pulumi.Input<inputs.apigatewayv2.StageAccessLogSettingsArgs>;
    accessPolicyId?: pulumi.Input<string>;
    apiId: pulumi.Input<string>;
    autoDeploy?: pulumi.Input<boolean>;
    clientCertificateId?: pulumi.Input<string>;
    defaultRouteSettings?: pulumi.Input<inputs.apigatewayv2.StageRouteSettingsArgs>;
    deploymentId?: pulumi.Input<string>;
    description?: pulumi.Input<string>;
    routeSettings?: any;
    stageName: pulumi.Input<string>;
    stageVariables?: any;
    tags?: any;
}
