// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource schema for AWS::MediaPackage::PackagingConfiguration
 */
export class PackagingConfiguration extends pulumi.CustomResource {
    /**
     * Get an existing PackagingConfiguration resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): PackagingConfiguration {
        return new PackagingConfiguration(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:mediapackage:PackagingConfiguration';

    /**
     * Returns true if the given object is an instance of PackagingConfiguration.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is PackagingConfiguration {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === PackagingConfiguration.__pulumiType;
    }

    /**
     * The ARN of the PackagingConfiguration.
     */
    public /*out*/ readonly arn!: pulumi.Output<string>;
    /**
     * A CMAF packaging configuration.
     */
    public readonly cmafPackage!: pulumi.Output<outputs.mediapackage.PackagingConfigurationCmafPackage | undefined>;
    /**
     * A Dynamic Adaptive Streaming over HTTP (DASH) packaging configuration.
     */
    public readonly dashPackage!: pulumi.Output<outputs.mediapackage.PackagingConfigurationDashPackage | undefined>;
    /**
     * An HTTP Live Streaming (HLS) packaging configuration.
     */
    public readonly hlsPackage!: pulumi.Output<outputs.mediapackage.PackagingConfigurationHlsPackage | undefined>;
    /**
     * A Microsoft Smooth Streaming (MSS) PackagingConfiguration.
     */
    public readonly mssPackage!: pulumi.Output<outputs.mediapackage.PackagingConfigurationMssPackage | undefined>;
    /**
     * The ID of a PackagingGroup.
     */
    public readonly packagingGroupId!: pulumi.Output<string>;
    /**
     * A collection of tags associated with a resource
     */
    public readonly tags!: pulumi.Output<outputs.mediapackage.PackagingConfigurationTag[] | undefined>;

    /**
     * Create a PackagingConfiguration resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: PackagingConfigurationArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.packagingGroupId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'packagingGroupId'");
            }
            inputs["cmafPackage"] = args ? args.cmafPackage : undefined;
            inputs["dashPackage"] = args ? args.dashPackage : undefined;
            inputs["hlsPackage"] = args ? args.hlsPackage : undefined;
            inputs["mssPackage"] = args ? args.mssPackage : undefined;
            inputs["packagingGroupId"] = args ? args.packagingGroupId : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["arn"] = undefined /*out*/;
        } else {
            inputs["arn"] = undefined /*out*/;
            inputs["cmafPackage"] = undefined /*out*/;
            inputs["dashPackage"] = undefined /*out*/;
            inputs["hlsPackage"] = undefined /*out*/;
            inputs["mssPackage"] = undefined /*out*/;
            inputs["packagingGroupId"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(PackagingConfiguration.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a PackagingConfiguration resource.
 */
export interface PackagingConfigurationArgs {
    /**
     * A CMAF packaging configuration.
     */
    cmafPackage?: pulumi.Input<inputs.mediapackage.PackagingConfigurationCmafPackageArgs>;
    /**
     * A Dynamic Adaptive Streaming over HTTP (DASH) packaging configuration.
     */
    dashPackage?: pulumi.Input<inputs.mediapackage.PackagingConfigurationDashPackageArgs>;
    /**
     * An HTTP Live Streaming (HLS) packaging configuration.
     */
    hlsPackage?: pulumi.Input<inputs.mediapackage.PackagingConfigurationHlsPackageArgs>;
    /**
     * A Microsoft Smooth Streaming (MSS) PackagingConfiguration.
     */
    mssPackage?: pulumi.Input<inputs.mediapackage.PackagingConfigurationMssPackageArgs>;
    /**
     * The ID of a PackagingGroup.
     */
    packagingGroupId: pulumi.Input<string>;
    /**
     * A collection of tags associated with a resource
     */
    tags?: pulumi.Input<pulumi.Input<inputs.mediapackage.PackagingConfigurationTagArgs>[]>;
}
