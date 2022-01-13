// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * The AWS::ECR::Repository resource specifies an Amazon Elastic Container Registry (Amazon ECR) repository, where users can push and pull Docker images. For more information, see https://docs.aws.amazon.com/AmazonECR/latest/userguide/Repositories.html
 */
export class Repository extends pulumi.CustomResource {
    /**
     * Get an existing Repository resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Repository {
        return new Repository(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:ecr:Repository';

    /**
     * Returns true if the given object is an instance of Repository.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Repository {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Repository.__pulumiType;
    }

    public /*out*/ readonly arn!: pulumi.Output<string>;
    public readonly encryptionConfiguration!: pulumi.Output<outputs.ecr.RepositoryEncryptionConfiguration | undefined>;
    public readonly imageScanningConfiguration!: pulumi.Output<outputs.ecr.RepositoryImageScanningConfiguration | undefined>;
    /**
     * The image tag mutability setting for the repository.
     */
    public readonly imageTagMutability!: pulumi.Output<enums.ecr.RepositoryImageTagMutability | undefined>;
    public readonly lifecyclePolicy!: pulumi.Output<outputs.ecr.RepositoryLifecyclePolicy | undefined>;
    /**
     * The name to use for the repository. The repository name may be specified on its own (such as nginx-web-app) or it can be prepended with a namespace to group the repository into a category (such as project-a/nginx-web-app). If you don't specify a name, AWS CloudFormation generates a unique physical ID and uses that ID for the repository name. For more information, see https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-name.html.
     */
    public readonly repositoryName!: pulumi.Output<string | undefined>;
    /**
     * The JSON repository policy text to apply to the repository. For more information, see https://docs.aws.amazon.com/AmazonECR/latest/userguide/RepositoryPolicyExamples.html in the Amazon Elastic Container Registry User Guide. 
     */
    public readonly repositoryPolicyText!: pulumi.Output<any | undefined>;
    public /*out*/ readonly repositoryUri!: pulumi.Output<string>;
    /**
     * An array of key-value pairs to apply to this resource.
     */
    public readonly tags!: pulumi.Output<outputs.ecr.RepositoryTag[] | undefined>;

    /**
     * Create a Repository resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: RepositoryArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            inputs["encryptionConfiguration"] = args ? args.encryptionConfiguration : undefined;
            inputs["imageScanningConfiguration"] = args ? args.imageScanningConfiguration : undefined;
            inputs["imageTagMutability"] = args ? args.imageTagMutability : undefined;
            inputs["lifecyclePolicy"] = args ? args.lifecyclePolicy : undefined;
            inputs["repositoryName"] = args ? args.repositoryName : undefined;
            inputs["repositoryPolicyText"] = args ? args.repositoryPolicyText : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["arn"] = undefined /*out*/;
            inputs["repositoryUri"] = undefined /*out*/;
        } else {
            inputs["arn"] = undefined /*out*/;
            inputs["encryptionConfiguration"] = undefined /*out*/;
            inputs["imageScanningConfiguration"] = undefined /*out*/;
            inputs["imageTagMutability"] = undefined /*out*/;
            inputs["lifecyclePolicy"] = undefined /*out*/;
            inputs["repositoryName"] = undefined /*out*/;
            inputs["repositoryPolicyText"] = undefined /*out*/;
            inputs["repositoryUri"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Repository.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Repository resource.
 */
export interface RepositoryArgs {
    encryptionConfiguration?: pulumi.Input<inputs.ecr.RepositoryEncryptionConfigurationArgs>;
    imageScanningConfiguration?: pulumi.Input<inputs.ecr.RepositoryImageScanningConfigurationArgs>;
    /**
     * The image tag mutability setting for the repository.
     */
    imageTagMutability?: pulumi.Input<enums.ecr.RepositoryImageTagMutability>;
    lifecyclePolicy?: pulumi.Input<inputs.ecr.RepositoryLifecyclePolicyArgs>;
    /**
     * The name to use for the repository. The repository name may be specified on its own (such as nginx-web-app) or it can be prepended with a namespace to group the repository into a category (such as project-a/nginx-web-app). If you don't specify a name, AWS CloudFormation generates a unique physical ID and uses that ID for the repository name. For more information, see https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-name.html.
     */
    repositoryName?: pulumi.Input<string>;
    /**
     * The JSON repository policy text to apply to the repository. For more information, see https://docs.aws.amazon.com/AmazonECR/latest/userguide/RepositoryPolicyExamples.html in the Amazon Elastic Container Registry User Guide. 
     */
    repositoryPolicyText?: any;
    /**
     * An array of key-value pairs to apply to this resource.
     */
    tags?: pulumi.Input<pulumi.Input<inputs.ecr.RepositoryTagArgs>[]>;
}
