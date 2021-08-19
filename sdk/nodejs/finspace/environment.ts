// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-finspace-environment.html
 */
export class Environment extends pulumi.CustomResource {
    /**
     * Get an existing Environment resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Environment {
        return new Environment(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:FinSpace:Environment';

    /**
     * Returns true if the given object is an instance of Environment.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Environment {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Environment.__pulumiType;
    }

    public /*out*/ readonly awsAccountId!: pulumi.Output<string>;
    public /*out*/ readonly dedicatedServiceAccountId!: pulumi.Output<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-finspace-environment.html#cfn-finspace-environment-description
     */
    public readonly description!: pulumi.Output<string | undefined>;
    public /*out*/ readonly environmentArn!: pulumi.Output<string>;
    public /*out*/ readonly environmentId!: pulumi.Output<string>;
    public /*out*/ readonly environmentUrl!: pulumi.Output<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-finspace-environment.html#cfn-finspace-environment-federationmode
     */
    public readonly federationMode!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-finspace-environment.html#cfn-finspace-environment-federationparameters
     */
    public readonly federationParameters!: pulumi.Output<outputs.FinSpace.EnvironmentFederationParameters | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-finspace-environment.html#cfn-finspace-environment-kmskeyid
     */
    public readonly kmsKeyId!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-finspace-environment.html#cfn-finspace-environment-name
     */
    public readonly name!: pulumi.Output<string>;
    public /*out*/ readonly sageMakerStudioDomainUrl!: pulumi.Output<string>;
    public /*out*/ readonly status!: pulumi.Output<string>;

    /**
     * Create a Environment resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: EnvironmentArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.name === undefined) && !opts.urn) {
                throw new Error("Missing required property 'name'");
            }
            inputs["description"] = args ? args.description : undefined;
            inputs["federationMode"] = args ? args.federationMode : undefined;
            inputs["federationParameters"] = args ? args.federationParameters : undefined;
            inputs["kmsKeyId"] = args ? args.kmsKeyId : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["awsAccountId"] = undefined /*out*/;
            inputs["dedicatedServiceAccountId"] = undefined /*out*/;
            inputs["environmentArn"] = undefined /*out*/;
            inputs["environmentId"] = undefined /*out*/;
            inputs["environmentUrl"] = undefined /*out*/;
            inputs["sageMakerStudioDomainUrl"] = undefined /*out*/;
            inputs["status"] = undefined /*out*/;
        } else {
            inputs["awsAccountId"] = undefined /*out*/;
            inputs["dedicatedServiceAccountId"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["environmentArn"] = undefined /*out*/;
            inputs["environmentId"] = undefined /*out*/;
            inputs["environmentUrl"] = undefined /*out*/;
            inputs["federationMode"] = undefined /*out*/;
            inputs["federationParameters"] = undefined /*out*/;
            inputs["kmsKeyId"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["sageMakerStudioDomainUrl"] = undefined /*out*/;
            inputs["status"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Environment.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Environment resource.
 */
export interface EnvironmentArgs {
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-finspace-environment.html#cfn-finspace-environment-description
     */
    description?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-finspace-environment.html#cfn-finspace-environment-federationmode
     */
    federationMode?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-finspace-environment.html#cfn-finspace-environment-federationparameters
     */
    federationParameters?: pulumi.Input<inputs.FinSpace.EnvironmentFederationParametersArgs>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-finspace-environment.html#cfn-finspace-environment-kmskeyid
     */
    kmsKeyId?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-finspace-environment.html#cfn-finspace-environment-name
     */
    name: pulumi.Input<string>;
}