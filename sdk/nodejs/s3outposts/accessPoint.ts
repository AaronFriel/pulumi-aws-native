// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type Definition for AWS::S3Outposts::AccessPoint
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
    public static readonly __pulumiType = 'aws-native:s3outposts:AccessPoint';

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

    /**
     * The Amazon Resource Name (ARN) of the specified AccessPoint.
     */
    public /*out*/ readonly arn!: pulumi.Output<string>;
    /**
     * The Amazon Resource Name (ARN) of the bucket you want to associate this AccessPoint with.
     */
    public readonly bucket!: pulumi.Output<string>;
    /**
     * A name for the AccessPoint.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The access point policy associated with this access point.
     */
    public readonly policy!: pulumi.Output<any | undefined>;
    /**
     * Virtual Private Cloud (VPC) from which requests can be made to the AccessPoint.
     */
    public readonly vpcConfiguration!: pulumi.Output<outputs.s3outposts.AccessPointVpcConfiguration>;

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
            if ((!args || args.bucket === undefined) && !opts.urn) {
                throw new Error("Missing required property 'bucket'");
            }
            if ((!args || args.vpcConfiguration === undefined) && !opts.urn) {
                throw new Error("Missing required property 'vpcConfiguration'");
            }
            inputs["bucket"] = args ? args.bucket : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["policy"] = args ? args.policy : undefined;
            inputs["vpcConfiguration"] = args ? args.vpcConfiguration : undefined;
            inputs["arn"] = undefined /*out*/;
        } else {
            inputs["arn"] = undefined /*out*/;
            inputs["bucket"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["policy"] = undefined /*out*/;
            inputs["vpcConfiguration"] = undefined /*out*/;
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
    /**
     * The Amazon Resource Name (ARN) of the bucket you want to associate this AccessPoint with.
     */
    bucket: pulumi.Input<string>;
    /**
     * A name for the AccessPoint.
     */
    name?: pulumi.Input<string>;
    /**
     * The access point policy associated with this access point.
     */
    policy?: any;
    /**
     * Virtual Private Cloud (VPC) from which requests can be made to the AccessPoint.
     */
    vpcConfiguration: pulumi.Input<inputs.s3outposts.AccessPointVpcConfigurationArgs>;
}
