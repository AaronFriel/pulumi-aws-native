// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::Events::ApiDestination.
 */
export class ApiDestination extends pulumi.CustomResource {
    /**
     * Get an existing ApiDestination resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ApiDestination {
        return new ApiDestination(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:events:ApiDestination';

    /**
     * Returns true if the given object is an instance of ApiDestination.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ApiDestination {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ApiDestination.__pulumiType;
    }

    /**
     * The arn of the api destination.
     */
    public /*out*/ readonly arn!: pulumi.Output<string>;
    /**
     * The arn of the connection.
     */
    public readonly connectionArn!: pulumi.Output<string>;
    public readonly description!: pulumi.Output<string | undefined>;
    public readonly httpMethod!: pulumi.Output<enums.events.ApiDestinationHttpMethod>;
    /**
     * Url endpoint to invoke.
     */
    public readonly invocationEndpoint!: pulumi.Output<string>;
    public readonly invocationRateLimitPerSecond!: pulumi.Output<number | undefined>;
    /**
     * Name of the apiDestination.
     */
    public readonly name!: pulumi.Output<string | undefined>;

    /**
     * Create a ApiDestination resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ApiDestinationArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.connectionArn === undefined) && !opts.urn) {
                throw new Error("Missing required property 'connectionArn'");
            }
            if ((!args || args.httpMethod === undefined) && !opts.urn) {
                throw new Error("Missing required property 'httpMethod'");
            }
            if ((!args || args.invocationEndpoint === undefined) && !opts.urn) {
                throw new Error("Missing required property 'invocationEndpoint'");
            }
            inputs["connectionArn"] = args ? args.connectionArn : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["httpMethod"] = args ? args.httpMethod : undefined;
            inputs["invocationEndpoint"] = args ? args.invocationEndpoint : undefined;
            inputs["invocationRateLimitPerSecond"] = args ? args.invocationRateLimitPerSecond : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["arn"] = undefined /*out*/;
        } else {
            inputs["arn"] = undefined /*out*/;
            inputs["connectionArn"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["httpMethod"] = undefined /*out*/;
            inputs["invocationEndpoint"] = undefined /*out*/;
            inputs["invocationRateLimitPerSecond"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(ApiDestination.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ApiDestination resource.
 */
export interface ApiDestinationArgs {
    /**
     * The arn of the connection.
     */
    connectionArn: pulumi.Input<string>;
    description?: pulumi.Input<string>;
    httpMethod: pulumi.Input<enums.events.ApiDestinationHttpMethod>;
    /**
     * Url endpoint to invoke.
     */
    invocationEndpoint: pulumi.Input<string>;
    invocationRateLimitPerSecond?: pulumi.Input<number>;
    /**
     * Name of the apiDestination.
     */
    name?: pulumi.Input<string>;
}
