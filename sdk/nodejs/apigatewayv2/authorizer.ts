// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::ApiGatewayV2::Authorizer
 *
 * @deprecated Authorizer is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class Authorizer extends pulumi.CustomResource {
    /**
     * Get an existing Authorizer resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Authorizer {
        pulumi.log.warn("Authorizer is deprecated: Authorizer is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new Authorizer(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:apigatewayv2:Authorizer';

    /**
     * Returns true if the given object is an instance of Authorizer.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Authorizer {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Authorizer.__pulumiType;
    }

    public readonly apiId!: pulumi.Output<string>;
    public readonly authorizerCredentialsArn!: pulumi.Output<string | undefined>;
    public readonly authorizerPayloadFormatVersion!: pulumi.Output<string | undefined>;
    public readonly authorizerResultTtlInSeconds!: pulumi.Output<number | undefined>;
    public readonly authorizerType!: pulumi.Output<string>;
    public readonly authorizerUri!: pulumi.Output<string | undefined>;
    public readonly enableSimpleResponses!: pulumi.Output<boolean | undefined>;
    public readonly identitySource!: pulumi.Output<string[] | undefined>;
    public readonly identityValidationExpression!: pulumi.Output<string | undefined>;
    public readonly jwtConfiguration!: pulumi.Output<outputs.apigatewayv2.AuthorizerJWTConfiguration | undefined>;
    public readonly name!: pulumi.Output<string>;

    /**
     * Create a Authorizer resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Authorizer is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args: AuthorizerArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("Authorizer is deprecated: Authorizer is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.apiId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'apiId'");
            }
            if ((!args || args.authorizerType === undefined) && !opts.urn) {
                throw new Error("Missing required property 'authorizerType'");
            }
            if ((!args || args.name === undefined) && !opts.urn) {
                throw new Error("Missing required property 'name'");
            }
            inputs["apiId"] = args ? args.apiId : undefined;
            inputs["authorizerCredentialsArn"] = args ? args.authorizerCredentialsArn : undefined;
            inputs["authorizerPayloadFormatVersion"] = args ? args.authorizerPayloadFormatVersion : undefined;
            inputs["authorizerResultTtlInSeconds"] = args ? args.authorizerResultTtlInSeconds : undefined;
            inputs["authorizerType"] = args ? args.authorizerType : undefined;
            inputs["authorizerUri"] = args ? args.authorizerUri : undefined;
            inputs["enableSimpleResponses"] = args ? args.enableSimpleResponses : undefined;
            inputs["identitySource"] = args ? args.identitySource : undefined;
            inputs["identityValidationExpression"] = args ? args.identityValidationExpression : undefined;
            inputs["jwtConfiguration"] = args ? args.jwtConfiguration : undefined;
            inputs["name"] = args ? args.name : undefined;
        } else {
            inputs["apiId"] = undefined /*out*/;
            inputs["authorizerCredentialsArn"] = undefined /*out*/;
            inputs["authorizerPayloadFormatVersion"] = undefined /*out*/;
            inputs["authorizerResultTtlInSeconds"] = undefined /*out*/;
            inputs["authorizerType"] = undefined /*out*/;
            inputs["authorizerUri"] = undefined /*out*/;
            inputs["enableSimpleResponses"] = undefined /*out*/;
            inputs["identitySource"] = undefined /*out*/;
            inputs["identityValidationExpression"] = undefined /*out*/;
            inputs["jwtConfiguration"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Authorizer.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Authorizer resource.
 */
export interface AuthorizerArgs {
    apiId: pulumi.Input<string>;
    authorizerCredentialsArn?: pulumi.Input<string>;
    authorizerPayloadFormatVersion?: pulumi.Input<string>;
    authorizerResultTtlInSeconds?: pulumi.Input<number>;
    authorizerType: pulumi.Input<string>;
    authorizerUri?: pulumi.Input<string>;
    enableSimpleResponses?: pulumi.Input<boolean>;
    identitySource?: pulumi.Input<pulumi.Input<string>[]>;
    identityValidationExpression?: pulumi.Input<string>;
    jwtConfiguration?: pulumi.Input<inputs.apigatewayv2.AuthorizerJWTConfigurationArgs>;
    name: pulumi.Input<string>;
}
