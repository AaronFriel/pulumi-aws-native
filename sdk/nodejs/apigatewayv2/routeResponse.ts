// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::ApiGatewayV2::RouteResponse
 *
 * @deprecated RouteResponse is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class RouteResponse extends pulumi.CustomResource {
    /**
     * Get an existing RouteResponse resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): RouteResponse {
        pulumi.log.warn("RouteResponse is deprecated: RouteResponse is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new RouteResponse(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:apigatewayv2:RouteResponse';

    /**
     * Returns true if the given object is an instance of RouteResponse.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is RouteResponse {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === RouteResponse.__pulumiType;
    }

    public readonly apiId!: pulumi.Output<string>;
    public readonly modelSelectionExpression!: pulumi.Output<string | undefined>;
    public readonly responseModels!: pulumi.Output<any | undefined>;
    public readonly responseParameters!: pulumi.Output<any | undefined>;
    public readonly routeId!: pulumi.Output<string>;
    public readonly routeResponseKey!: pulumi.Output<string>;

    /**
     * Create a RouteResponse resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated RouteResponse is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args: RouteResponseArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("RouteResponse is deprecated: RouteResponse is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.apiId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'apiId'");
            }
            if ((!args || args.routeId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'routeId'");
            }
            if ((!args || args.routeResponseKey === undefined) && !opts.urn) {
                throw new Error("Missing required property 'routeResponseKey'");
            }
            inputs["apiId"] = args ? args.apiId : undefined;
            inputs["modelSelectionExpression"] = args ? args.modelSelectionExpression : undefined;
            inputs["responseModels"] = args ? args.responseModels : undefined;
            inputs["responseParameters"] = args ? args.responseParameters : undefined;
            inputs["routeId"] = args ? args.routeId : undefined;
            inputs["routeResponseKey"] = args ? args.routeResponseKey : undefined;
        } else {
            inputs["apiId"] = undefined /*out*/;
            inputs["modelSelectionExpression"] = undefined /*out*/;
            inputs["responseModels"] = undefined /*out*/;
            inputs["responseParameters"] = undefined /*out*/;
            inputs["routeId"] = undefined /*out*/;
            inputs["routeResponseKey"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(RouteResponse.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a RouteResponse resource.
 */
export interface RouteResponseArgs {
    apiId: pulumi.Input<string>;
    modelSelectionExpression?: pulumi.Input<string>;
    responseModels?: any;
    responseParameters?: any;
    routeId: pulumi.Input<string>;
    routeResponseKey: pulumi.Input<string>;
}
