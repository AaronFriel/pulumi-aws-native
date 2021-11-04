// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::AppStream::ImageBuilder
 *
 * @deprecated ImageBuilder is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class ImageBuilder extends pulumi.CustomResource {
    /**
     * Get an existing ImageBuilder resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ImageBuilder {
        pulumi.log.warn("ImageBuilder is deprecated: ImageBuilder is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new ImageBuilder(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:appstream:ImageBuilder';

    /**
     * Returns true if the given object is an instance of ImageBuilder.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ImageBuilder {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ImageBuilder.__pulumiType;
    }

    public readonly accessEndpoints!: pulumi.Output<outputs.appstream.ImageBuilderAccessEndpoint[] | undefined>;
    public readonly appstreamAgentVersion!: pulumi.Output<string | undefined>;
    public readonly description!: pulumi.Output<string | undefined>;
    public readonly displayName!: pulumi.Output<string | undefined>;
    public readonly domainJoinInfo!: pulumi.Output<outputs.appstream.ImageBuilderDomainJoinInfo | undefined>;
    public readonly enableDefaultInternetAccess!: pulumi.Output<boolean | undefined>;
    public readonly iamRoleArn!: pulumi.Output<string | undefined>;
    public readonly imageArn!: pulumi.Output<string | undefined>;
    public readonly imageName!: pulumi.Output<string | undefined>;
    public readonly instanceType!: pulumi.Output<string>;
    public readonly name!: pulumi.Output<string>;
    public /*out*/ readonly streamingUrl!: pulumi.Output<string>;
    public readonly tags!: pulumi.Output<outputs.appstream.ImageBuilderTag[] | undefined>;
    public readonly vpcConfig!: pulumi.Output<outputs.appstream.ImageBuilderVpcConfig | undefined>;

    /**
     * Create a ImageBuilder resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated ImageBuilder is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args: ImageBuilderArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("ImageBuilder is deprecated: ImageBuilder is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.instanceType === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceType'");
            }
            inputs["accessEndpoints"] = args ? args.accessEndpoints : undefined;
            inputs["appstreamAgentVersion"] = args ? args.appstreamAgentVersion : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["displayName"] = args ? args.displayName : undefined;
            inputs["domainJoinInfo"] = args ? args.domainJoinInfo : undefined;
            inputs["enableDefaultInternetAccess"] = args ? args.enableDefaultInternetAccess : undefined;
            inputs["iamRoleArn"] = args ? args.iamRoleArn : undefined;
            inputs["imageArn"] = args ? args.imageArn : undefined;
            inputs["imageName"] = args ? args.imageName : undefined;
            inputs["instanceType"] = args ? args.instanceType : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["vpcConfig"] = args ? args.vpcConfig : undefined;
            inputs["streamingUrl"] = undefined /*out*/;
        } else {
            inputs["accessEndpoints"] = undefined /*out*/;
            inputs["appstreamAgentVersion"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["displayName"] = undefined /*out*/;
            inputs["domainJoinInfo"] = undefined /*out*/;
            inputs["enableDefaultInternetAccess"] = undefined /*out*/;
            inputs["iamRoleArn"] = undefined /*out*/;
            inputs["imageArn"] = undefined /*out*/;
            inputs["imageName"] = undefined /*out*/;
            inputs["instanceType"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["streamingUrl"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["vpcConfig"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(ImageBuilder.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ImageBuilder resource.
 */
export interface ImageBuilderArgs {
    accessEndpoints?: pulumi.Input<pulumi.Input<inputs.appstream.ImageBuilderAccessEndpointArgs>[]>;
    appstreamAgentVersion?: pulumi.Input<string>;
    description?: pulumi.Input<string>;
    displayName?: pulumi.Input<string>;
    domainJoinInfo?: pulumi.Input<inputs.appstream.ImageBuilderDomainJoinInfoArgs>;
    enableDefaultInternetAccess?: pulumi.Input<boolean>;
    iamRoleArn?: pulumi.Input<string>;
    imageArn?: pulumi.Input<string>;
    imageName?: pulumi.Input<string>;
    instanceType: pulumi.Input<string>;
    name?: pulumi.Input<string>;
    tags?: pulumi.Input<pulumi.Input<inputs.appstream.ImageBuilderTagArgs>[]>;
    vpcConfig?: pulumi.Input<inputs.appstream.ImageBuilderVpcConfigArgs>;
}
