// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * AWS::S3ObjectLambda::AccessPointPolicy resource is an Amazon S3ObjectLambda policy type that you can use to control permissions for your S3ObjectLambda
 */
export class AccessPointPolicy extends pulumi.CustomResource {
    /**
     * Get an existing AccessPointPolicy resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): AccessPointPolicy {
        return new AccessPointPolicy(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:s3objectlambda:AccessPointPolicy';

    /**
     * Returns true if the given object is an instance of AccessPointPolicy.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AccessPointPolicy {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AccessPointPolicy.__pulumiType;
    }

    /**
     * The name of the Amazon S3 ObjectLambdaAccessPoint to which the policy applies.
     */
    public readonly objectLambdaAccessPoint!: pulumi.Output<string>;
    /**
     * A policy document containing permissions to add to the specified ObjectLambdaAccessPoint. For more information, see Access Policy Language Overview (https://docs.aws.amazon.com/AmazonS3/latest/dev/access-policy-language-overview.html) in the Amazon Simple Storage Service Developer Guide. 
     */
    public readonly policyDocument!: pulumi.Output<any>;

    /**
     * Create a AccessPointPolicy resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AccessPointPolicyArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.objectLambdaAccessPoint === undefined) && !opts.urn) {
                throw new Error("Missing required property 'objectLambdaAccessPoint'");
            }
            if ((!args || args.policyDocument === undefined) && !opts.urn) {
                throw new Error("Missing required property 'policyDocument'");
            }
            inputs["objectLambdaAccessPoint"] = args ? args.objectLambdaAccessPoint : undefined;
            inputs["policyDocument"] = args ? args.policyDocument : undefined;
        } else {
            inputs["objectLambdaAccessPoint"] = undefined /*out*/;
            inputs["policyDocument"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(AccessPointPolicy.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a AccessPointPolicy resource.
 */
export interface AccessPointPolicyArgs {
    /**
     * The name of the Amazon S3 ObjectLambdaAccessPoint to which the policy applies.
     */
    objectLambdaAccessPoint: pulumi.Input<string>;
    /**
     * A policy document containing permissions to add to the specified ObjectLambdaAccessPoint. For more information, see Access Policy Language Overview (https://docs.aws.amazon.com/AmazonS3/latest/dev/access-policy-language-overview.html) in the Amazon Simple Storage Service Developer Guide. 
     */
    policyDocument: any;
}
