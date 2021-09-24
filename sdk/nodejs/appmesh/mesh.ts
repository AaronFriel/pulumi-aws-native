// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::AppMesh::Mesh
 *
 * @deprecated Mesh is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class Mesh extends pulumi.CustomResource {
    /**
     * Get an existing Mesh resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Mesh {
        pulumi.log.warn("Mesh is deprecated: Mesh is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new Mesh(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:appmesh:Mesh';

    /**
     * Returns true if the given object is an instance of Mesh.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Mesh {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Mesh.__pulumiType;
    }

    public /*out*/ readonly arn!: pulumi.Output<string>;
    public readonly meshName!: pulumi.Output<string | undefined>;
    public /*out*/ readonly meshOwner!: pulumi.Output<string>;
    public /*out*/ readonly resourceOwner!: pulumi.Output<string>;
    public readonly spec!: pulumi.Output<outputs.appmesh.MeshMeshSpec | undefined>;
    public readonly tags!: pulumi.Output<outputs.appmesh.MeshTag[] | undefined>;
    public /*out*/ readonly uid!: pulumi.Output<string>;

    /**
     * Create a Mesh resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Mesh is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args?: MeshArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("Mesh is deprecated: Mesh is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            inputs["meshName"] = args ? args.meshName : undefined;
            inputs["spec"] = args ? args.spec : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["arn"] = undefined /*out*/;
            inputs["meshOwner"] = undefined /*out*/;
            inputs["resourceOwner"] = undefined /*out*/;
            inputs["uid"] = undefined /*out*/;
        } else {
            inputs["arn"] = undefined /*out*/;
            inputs["meshName"] = undefined /*out*/;
            inputs["meshOwner"] = undefined /*out*/;
            inputs["resourceOwner"] = undefined /*out*/;
            inputs["spec"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["uid"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Mesh.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Mesh resource.
 */
export interface MeshArgs {
    meshName?: pulumi.Input<string>;
    spec?: pulumi.Input<inputs.appmesh.MeshMeshSpecArgs>;
    tags?: pulumi.Input<pulumi.Input<inputs.appmesh.MeshTagArgs>[]>;
}