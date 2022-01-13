// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::AppMesh::VirtualService
 *
 * @deprecated VirtualService is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class VirtualService extends pulumi.CustomResource {
    /**
     * Get an existing VirtualService resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): VirtualService {
        pulumi.log.warn("VirtualService is deprecated: VirtualService is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new VirtualService(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:appmesh:VirtualService';

    /**
     * Returns true if the given object is an instance of VirtualService.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is VirtualService {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === VirtualService.__pulumiType;
    }

    public /*out*/ readonly arn!: pulumi.Output<string>;
    public readonly meshName!: pulumi.Output<string>;
    public readonly meshOwner!: pulumi.Output<string | undefined>;
    public /*out*/ readonly resourceOwner!: pulumi.Output<string>;
    public readonly spec!: pulumi.Output<outputs.appmesh.VirtualServiceSpec>;
    public readonly tags!: pulumi.Output<outputs.appmesh.VirtualServiceTag[] | undefined>;
    public /*out*/ readonly uid!: pulumi.Output<string>;
    public readonly virtualServiceName!: pulumi.Output<string>;

    /**
     * Create a VirtualService resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated VirtualService is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args: VirtualServiceArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("VirtualService is deprecated: VirtualService is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.meshName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'meshName'");
            }
            if ((!args || args.spec === undefined) && !opts.urn) {
                throw new Error("Missing required property 'spec'");
            }
            inputs["meshName"] = args ? args.meshName : undefined;
            inputs["meshOwner"] = args ? args.meshOwner : undefined;
            inputs["spec"] = args ? args.spec : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["virtualServiceName"] = args ? args.virtualServiceName : undefined;
            inputs["arn"] = undefined /*out*/;
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
            inputs["virtualServiceName"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(VirtualService.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a VirtualService resource.
 */
export interface VirtualServiceArgs {
    meshName: pulumi.Input<string>;
    meshOwner?: pulumi.Input<string>;
    spec: pulumi.Input<inputs.appmesh.VirtualServiceSpecArgs>;
    tags?: pulumi.Input<pulumi.Input<inputs.appmesh.VirtualServiceTagArgs>[]>;
    virtualServiceName?: pulumi.Input<string>;
}
