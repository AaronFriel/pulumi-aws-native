// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Resource schema for AWS::DataSync::LocationSMB.
 */
export class LocationSMB extends pulumi.CustomResource {
    /**
     * Get an existing LocationSMB resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): LocationSMB {
        return new LocationSMB(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:datasync:LocationSMB';

    /**
     * Returns true if the given object is an instance of LocationSMB.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is LocationSMB {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === LocationSMB.__pulumiType;
    }

    /**
     * The Amazon Resource Names (ARNs) of agents to use for a Simple Message Block (SMB) location.
     */
    public readonly agentArns!: pulumi.Output<string[]>;
    /**
     * The name of the Windows domain that the SMB server belongs to.
     */
    public readonly domain!: pulumi.Output<string | undefined>;
    /**
     * The Amazon Resource Name (ARN) of the SMB location that is created.
     */
    public /*out*/ readonly locationArn!: pulumi.Output<string>;
    /**
     * The URL of the SMB location that was described.
     */
    public /*out*/ readonly locationUri!: pulumi.Output<string>;
    public readonly mountOptions!: pulumi.Output<outputs.datasync.LocationSMBMountOptions | undefined>;
    /**
     * The password of the user who can mount the share and has the permissions to access files and folders in the SMB share.
     */
    public readonly password!: pulumi.Output<string>;
    /**
     * The name of the SMB server. This value is the IP address or Domain Name Service (DNS) name of the SMB server.
     */
    public readonly serverHostname!: pulumi.Output<string>;
    /**
     * The subdirectory in the SMB file system that is used to read data from the SMB source location or write data to the SMB destination
     */
    public readonly subdirectory!: pulumi.Output<string>;
    /**
     * An array of key-value pairs to apply to this resource.
     */
    public readonly tags!: pulumi.Output<outputs.datasync.LocationSMBTag[] | undefined>;
    /**
     * The user who can mount the share, has the permissions to access files and folders in the SMB share.
     */
    public readonly user!: pulumi.Output<string>;

    /**
     * Create a LocationSMB resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: LocationSMBArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.agentArns === undefined) && !opts.urn) {
                throw new Error("Missing required property 'agentArns'");
            }
            if ((!args || args.password === undefined) && !opts.urn) {
                throw new Error("Missing required property 'password'");
            }
            if ((!args || args.serverHostname === undefined) && !opts.urn) {
                throw new Error("Missing required property 'serverHostname'");
            }
            if ((!args || args.subdirectory === undefined) && !opts.urn) {
                throw new Error("Missing required property 'subdirectory'");
            }
            if ((!args || args.user === undefined) && !opts.urn) {
                throw new Error("Missing required property 'user'");
            }
            inputs["agentArns"] = args ? args.agentArns : undefined;
            inputs["domain"] = args ? args.domain : undefined;
            inputs["mountOptions"] = args ? args.mountOptions : undefined;
            inputs["password"] = args ? args.password : undefined;
            inputs["serverHostname"] = args ? args.serverHostname : undefined;
            inputs["subdirectory"] = args ? args.subdirectory : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["user"] = args ? args.user : undefined;
            inputs["locationArn"] = undefined /*out*/;
            inputs["locationUri"] = undefined /*out*/;
        } else {
            inputs["agentArns"] = undefined /*out*/;
            inputs["domain"] = undefined /*out*/;
            inputs["locationArn"] = undefined /*out*/;
            inputs["locationUri"] = undefined /*out*/;
            inputs["mountOptions"] = undefined /*out*/;
            inputs["password"] = undefined /*out*/;
            inputs["serverHostname"] = undefined /*out*/;
            inputs["subdirectory"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["user"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(LocationSMB.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a LocationSMB resource.
 */
export interface LocationSMBArgs {
    /**
     * The Amazon Resource Names (ARNs) of agents to use for a Simple Message Block (SMB) location.
     */
    agentArns: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The name of the Windows domain that the SMB server belongs to.
     */
    domain?: pulumi.Input<string>;
    mountOptions?: pulumi.Input<inputs.datasync.LocationSMBMountOptionsArgs>;
    /**
     * The password of the user who can mount the share and has the permissions to access files and folders in the SMB share.
     */
    password: pulumi.Input<string>;
    /**
     * The name of the SMB server. This value is the IP address or Domain Name Service (DNS) name of the SMB server.
     */
    serverHostname: pulumi.Input<string>;
    /**
     * The subdirectory in the SMB file system that is used to read data from the SMB source location or write data to the SMB destination
     */
    subdirectory: pulumi.Input<string>;
    /**
     * An array of key-value pairs to apply to this resource.
     */
    tags?: pulumi.Input<pulumi.Input<inputs.datasync.LocationSMBTagArgs>[]>;
    /**
     * The user who can mount the share, has the permissions to access files and folders in the SMB share.
     */
    user: pulumi.Input<string>;
}
