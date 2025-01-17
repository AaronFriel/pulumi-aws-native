// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::ApiGatewayV2::Route
 *
 * @deprecated Route is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class Route extends pulumi.CustomResource {
    /**
     * Get an existing Route resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Route {
        pulumi.log.warn("Route is deprecated: Route is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new Route(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:apigatewayv2:Route';

    /**
     * Returns true if the given object is an instance of Route.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Route {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Route.__pulumiType;
    }

    public readonly apiId!: pulumi.Output<string>;
    public readonly apiKeyRequired!: pulumi.Output<boolean | undefined>;
    public readonly authorizationScopes!: pulumi.Output<string[] | undefined>;
    public readonly authorizationType!: pulumi.Output<string | undefined>;
    public readonly authorizerId!: pulumi.Output<string | undefined>;
    public readonly modelSelectionExpression!: pulumi.Output<string | undefined>;
    public readonly operationName!: pulumi.Output<string | undefined>;
    public readonly requestModels!: pulumi.Output<any | undefined>;
    public readonly requestParameters!: pulumi.Output<any | undefined>;
    public readonly routeKey!: pulumi.Output<string>;
    public readonly routeResponseSelectionExpression!: pulumi.Output<string | undefined>;
    public readonly target!: pulumi.Output<string | undefined>;

    /**
     * Create a Route resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Route is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args: RouteArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("Route is deprecated: Route is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.apiId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'apiId'");
            }
            if ((!args || args.routeKey === undefined) && !opts.urn) {
                throw new Error("Missing required property 'routeKey'");
            }
            inputs["apiId"] = args ? args.apiId : undefined;
            inputs["apiKeyRequired"] = args ? args.apiKeyRequired : undefined;
            inputs["authorizationScopes"] = args ? args.authorizationScopes : undefined;
            inputs["authorizationType"] = args ? args.authorizationType : undefined;
            inputs["authorizerId"] = args ? args.authorizerId : undefined;
            inputs["modelSelectionExpression"] = args ? args.modelSelectionExpression : undefined;
            inputs["operationName"] = args ? args.operationName : undefined;
            inputs["requestModels"] = args ? args.requestModels : undefined;
            inputs["requestParameters"] = args ? args.requestParameters : undefined;
            inputs["routeKey"] = args ? args.routeKey : undefined;
            inputs["routeResponseSelectionExpression"] = args ? args.routeResponseSelectionExpression : undefined;
            inputs["target"] = args ? args.target : undefined;
        } else {
            inputs["apiId"] = undefined /*out*/;
            inputs["apiKeyRequired"] = undefined /*out*/;
            inputs["authorizationScopes"] = undefined /*out*/;
            inputs["authorizationType"] = undefined /*out*/;
            inputs["authorizerId"] = undefined /*out*/;
            inputs["modelSelectionExpression"] = undefined /*out*/;
            inputs["operationName"] = undefined /*out*/;
            inputs["requestModels"] = undefined /*out*/;
            inputs["requestParameters"] = undefined /*out*/;
            inputs["routeKey"] = undefined /*out*/;
            inputs["routeResponseSelectionExpression"] = undefined /*out*/;
            inputs["target"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Route.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Route resource.
 */
export interface RouteArgs {
    apiId: pulumi.Input<string>;
    apiKeyRequired?: pulumi.Input<boolean>;
    authorizationScopes?: pulumi.Input<pulumi.Input<string>[]>;
    authorizationType?: pulumi.Input<string>;
    authorizerId?: pulumi.Input<string>;
    modelSelectionExpression?: pulumi.Input<string>;
    operationName?: pulumi.Input<string>;
    requestModels?: any;
    requestParameters?: any;
    routeKey: pulumi.Input<string>;
    routeResponseSelectionExpression?: pulumi.Input<string>;
    target?: pulumi.Input<string>;
}
