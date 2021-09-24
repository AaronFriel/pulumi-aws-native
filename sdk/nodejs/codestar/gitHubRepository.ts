// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::CodeStar::GitHubRepository
 *
 * @deprecated GitHubRepository is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class GitHubRepository extends pulumi.CustomResource {
    /**
     * Get an existing GitHubRepository resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): GitHubRepository {
        pulumi.log.warn("GitHubRepository is deprecated: GitHubRepository is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new GitHubRepository(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:codestar:GitHubRepository';

    /**
     * Returns true if the given object is an instance of GitHubRepository.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is GitHubRepository {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === GitHubRepository.__pulumiType;
    }

    public readonly code!: pulumi.Output<outputs.codestar.GitHubRepositoryCode | undefined>;
    public readonly connectionArn!: pulumi.Output<string | undefined>;
    public readonly enableIssues!: pulumi.Output<boolean | undefined>;
    public readonly isPrivate!: pulumi.Output<boolean | undefined>;
    public readonly repositoryAccessToken!: pulumi.Output<string | undefined>;
    public readonly repositoryDescription!: pulumi.Output<string | undefined>;
    public readonly repositoryName!: pulumi.Output<string>;
    public readonly repositoryOwner!: pulumi.Output<string>;

    /**
     * Create a GitHubRepository resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated GitHubRepository is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args: GitHubRepositoryArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("GitHubRepository is deprecated: GitHubRepository is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.repositoryName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'repositoryName'");
            }
            if ((!args || args.repositoryOwner === undefined) && !opts.urn) {
                throw new Error("Missing required property 'repositoryOwner'");
            }
            inputs["code"] = args ? args.code : undefined;
            inputs["connectionArn"] = args ? args.connectionArn : undefined;
            inputs["enableIssues"] = args ? args.enableIssues : undefined;
            inputs["isPrivate"] = args ? args.isPrivate : undefined;
            inputs["repositoryAccessToken"] = args ? args.repositoryAccessToken : undefined;
            inputs["repositoryDescription"] = args ? args.repositoryDescription : undefined;
            inputs["repositoryName"] = args ? args.repositoryName : undefined;
            inputs["repositoryOwner"] = args ? args.repositoryOwner : undefined;
        } else {
            inputs["code"] = undefined /*out*/;
            inputs["connectionArn"] = undefined /*out*/;
            inputs["enableIssues"] = undefined /*out*/;
            inputs["isPrivate"] = undefined /*out*/;
            inputs["repositoryAccessToken"] = undefined /*out*/;
            inputs["repositoryDescription"] = undefined /*out*/;
            inputs["repositoryName"] = undefined /*out*/;
            inputs["repositoryOwner"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(GitHubRepository.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a GitHubRepository resource.
 */
export interface GitHubRepositoryArgs {
    code?: pulumi.Input<inputs.codestar.GitHubRepositoryCodeArgs>;
    connectionArn?: pulumi.Input<string>;
    enableIssues?: pulumi.Input<boolean>;
    isPrivate?: pulumi.Input<boolean>;
    repositoryAccessToken?: pulumi.Input<string>;
    repositoryDescription?: pulumi.Input<string>;
    repositoryName: pulumi.Input<string>;
    repositoryOwner: pulumi.Input<string>;
}
