// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::AppMesh::Route
 *
 * @deprecated Route is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.
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
        pulumi.log.warn("Route is deprecated: Route is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new Route(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:appmesh:Route';

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

    public /*out*/ readonly arn!: pulumi.Output<string>;
    public readonly meshName!: pulumi.Output<string>;
    public readonly meshOwner!: pulumi.Output<string | undefined>;
    public /*out*/ readonly resourceOwner!: pulumi.Output<string>;
    public readonly routeName!: pulumi.Output<string | undefined>;
    public readonly spec!: pulumi.Output<outputs.appmesh.RouteRouteSpec>;
    public readonly tags!: pulumi.Output<outputs.appmesh.RouteTag[] | undefined>;
    public /*out*/ readonly uid!: pulumi.Output<string>;
    public readonly virtualRouterName!: pulumi.Output<string>;

    /**
     * Create a Route resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Route is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args: RouteArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("Route is deprecated: Route is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.meshName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'meshName'");
            }
            if ((!args || args.spec === undefined) && !opts.urn) {
                throw new Error("Missing required property 'spec'");
            }
            if ((!args || args.virtualRouterName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'virtualRouterName'");
            }
            inputs["meshName"] = args ? args.meshName : undefined;
            inputs["meshOwner"] = args ? args.meshOwner : undefined;
            inputs["routeName"] = args ? args.routeName : undefined;
            inputs["spec"] = args ? args.spec : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["virtualRouterName"] = args ? args.virtualRouterName : undefined;
            inputs["arn"] = undefined /*out*/;
            inputs["resourceOwner"] = undefined /*out*/;
            inputs["uid"] = undefined /*out*/;
        } else {
            inputs["arn"] = undefined /*out*/;
            inputs["meshName"] = undefined /*out*/;
            inputs["meshOwner"] = undefined /*out*/;
            inputs["resourceOwner"] = undefined /*out*/;
            inputs["routeName"] = undefined /*out*/;
            inputs["spec"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["uid"] = undefined /*out*/;
            inputs["virtualRouterName"] = undefined /*out*/;
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
    meshName: pulumi.Input<string>;
    meshOwner?: pulumi.Input<string>;
    routeName?: pulumi.Input<string>;
    spec: pulumi.Input<inputs.appmesh.RouteRouteSpecArgs>;
    tags?: pulumi.Input<pulumi.Input<inputs.appmesh.RouteTagArgs>[]>;
    virtualRouterName: pulumi.Input<string>;
}