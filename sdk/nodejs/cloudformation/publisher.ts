// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Register as a publisher in the CloudFormation Registry.
 */
export class Publisher extends pulumi.CustomResource {
    /**
     * Get an existing Publisher resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Publisher {
        return new Publisher(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:cloudformation:Publisher';

    /**
     * Returns true if the given object is an instance of Publisher.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Publisher {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Publisher.__pulumiType;
    }

    /**
     * Whether you accept the terms and conditions for publishing extensions in the CloudFormation registry. You must accept the terms and conditions in order to publish public extensions to the CloudFormation registry. The terms and conditions can be found at https://cloudformation-registry-documents.s3.amazonaws.com/Terms_and_Conditions_for_AWS_CloudFormation_Registry_Publishers.pdf
     */
    public readonly acceptTermsAndConditions!: pulumi.Output<boolean>;
    /**
     * If you are using a Bitbucket or GitHub account for identity verification, the Amazon Resource Name (ARN) for your connection to that account.
     */
    public readonly connectionArn!: pulumi.Output<string | undefined>;
    /**
     * The type of account used as the identity provider when registering this publisher with CloudFormation.
     */
    public /*out*/ readonly identityProvider!: pulumi.Output<string>;
    /**
     * The publisher id assigned by CloudFormation for publishing in this region.
     */
    public /*out*/ readonly publisherId!: pulumi.Output<string>;
    /**
     * The URL to the publisher's profile with the identity provider.
     */
    public /*out*/ readonly publisherProfile!: pulumi.Output<string>;
    /**
     * Whether the publisher is verified.
     */
    public /*out*/ readonly publisherStatus!: pulumi.Output<string>;

    /**
     * Create a Publisher resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: PublisherArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.acceptTermsAndConditions === undefined) && !opts.urn) {
                throw new Error("Missing required property 'acceptTermsAndConditions'");
            }
            inputs["acceptTermsAndConditions"] = args ? args.acceptTermsAndConditions : undefined;
            inputs["connectionArn"] = args ? args.connectionArn : undefined;
            inputs["identityProvider"] = undefined /*out*/;
            inputs["publisherId"] = undefined /*out*/;
            inputs["publisherProfile"] = undefined /*out*/;
            inputs["publisherStatus"] = undefined /*out*/;
        } else {
            inputs["acceptTermsAndConditions"] = undefined /*out*/;
            inputs["connectionArn"] = undefined /*out*/;
            inputs["identityProvider"] = undefined /*out*/;
            inputs["publisherId"] = undefined /*out*/;
            inputs["publisherProfile"] = undefined /*out*/;
            inputs["publisherStatus"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Publisher.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Publisher resource.
 */
export interface PublisherArgs {
    /**
     * Whether you accept the terms and conditions for publishing extensions in the CloudFormation registry. You must accept the terms and conditions in order to publish public extensions to the CloudFormation registry. The terms and conditions can be found at https://cloudformation-registry-documents.s3.amazonaws.com/Terms_and_Conditions_for_AWS_CloudFormation_Registry_Publishers.pdf
     */
    acceptTermsAndConditions: pulumi.Input<boolean>;
    /**
     * If you are using a Bitbucket or GitHub account for identity verification, the Amazon Resource Name (ARN) for your connection to that account.
     */
    connectionArn?: pulumi.Input<string>;
}
