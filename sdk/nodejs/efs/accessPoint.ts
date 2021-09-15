// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::EFS::AccessPoint
 */
export class AccessPoint extends pulumi.CustomResource {
    /**
     * Get an existing AccessPoint resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): AccessPoint {
        return new AccessPoint(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:efs:AccessPoint';

    /**
     * Returns true if the given object is an instance of AccessPoint.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AccessPoint {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AccessPoint.__pulumiType;
    }

    public /*out*/ readonly accessPointId!: pulumi.Output<string>;
    public readonly accessPointTags!: pulumi.Output<outputs.efs.AccessPointAccessPointTag[] | undefined>;
    public /*out*/ readonly arn!: pulumi.Output<string>;
    /**
     * (optional) A string of up to 64 ASCII characters that Amazon EFS uses to ensure idempotent creation.
     */
    public readonly clientToken!: pulumi.Output<string | undefined>;
    /**
     * The ID of the EFS file system that the access point provides access to.
     */
    public readonly fileSystemId!: pulumi.Output<string>;
    /**
     * The operating system user and group applied to all file system requests made using the access point.
     */
    public readonly posixUser!: pulumi.Output<outputs.efs.AccessPointPosixUser | undefined>;
    /**
     * Specifies the directory on the Amazon EFS file system that the access point exposes as the root directory of your file system to NFS clients using the access point. The clients using the access point can only access the root directory and below. If the RootDirectory>Path specified does not exist, EFS creates it and applies the CreationInfo settings when a client connects to an access point. When specifying a RootDirectory, you need to provide the Path, and the CreationInfo is optional.
     */
    public readonly rootDirectory!: pulumi.Output<outputs.efs.AccessPointRootDirectory | undefined>;

    /**
     * Create a AccessPoint resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AccessPointArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.fileSystemId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'fileSystemId'");
            }
            inputs["accessPointTags"] = args ? args.accessPointTags : undefined;
            inputs["clientToken"] = args ? args.clientToken : undefined;
            inputs["fileSystemId"] = args ? args.fileSystemId : undefined;
            inputs["posixUser"] = args ? args.posixUser : undefined;
            inputs["rootDirectory"] = args ? args.rootDirectory : undefined;
            inputs["accessPointId"] = undefined /*out*/;
            inputs["arn"] = undefined /*out*/;
        } else {
            inputs["accessPointId"] = undefined /*out*/;
            inputs["accessPointTags"] = undefined /*out*/;
            inputs["arn"] = undefined /*out*/;
            inputs["clientToken"] = undefined /*out*/;
            inputs["fileSystemId"] = undefined /*out*/;
            inputs["posixUser"] = undefined /*out*/;
            inputs["rootDirectory"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(AccessPoint.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a AccessPoint resource.
 */
export interface AccessPointArgs {
    accessPointTags?: pulumi.Input<pulumi.Input<inputs.efs.AccessPointAccessPointTagArgs>[]>;
    /**
     * (optional) A string of up to 64 ASCII characters that Amazon EFS uses to ensure idempotent creation.
     */
    clientToken?: pulumi.Input<string>;
    /**
     * The ID of the EFS file system that the access point provides access to.
     */
    fileSystemId: pulumi.Input<string>;
    /**
     * The operating system user and group applied to all file system requests made using the access point.
     */
    posixUser?: pulumi.Input<inputs.efs.AccessPointPosixUserArgs>;
    /**
     * Specifies the directory on the Amazon EFS file system that the access point exposes as the root directory of your file system to NFS clients using the access point. The clients using the access point can only access the root directory and below. If the RootDirectory>Path specified does not exist, EFS creates it and applies the CreationInfo settings when a client connects to an access point. When specifying a RootDirectory, you need to provide the Path, and the CreationInfo is optional.
     */
    rootDirectory?: pulumi.Input<inputs.efs.AccessPointRootDirectoryArgs>;
}
