// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::AmazonMQ::Configuration
 *
 * @deprecated Configuration is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class Configuration extends pulumi.CustomResource {
    /**
     * Get an existing Configuration resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Configuration {
        pulumi.log.warn("Configuration is deprecated: Configuration is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new Configuration(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:amazonmq:Configuration';

    /**
     * Returns true if the given object is an instance of Configuration.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Configuration {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Configuration.__pulumiType;
    }

    public /*out*/ readonly arn!: pulumi.Output<string>;
    public readonly authenticationStrategy!: pulumi.Output<string | undefined>;
    public readonly data!: pulumi.Output<string>;
    public readonly description!: pulumi.Output<string | undefined>;
    public readonly engineType!: pulumi.Output<string>;
    public readonly engineVersion!: pulumi.Output<string>;
    public readonly name!: pulumi.Output<string>;
    public /*out*/ readonly revision!: pulumi.Output<number>;
    public readonly tags!: pulumi.Output<outputs.amazonmq.ConfigurationTagsEntry[] | undefined>;

    /**
     * Create a Configuration resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Configuration is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args: ConfigurationArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("Configuration is deprecated: Configuration is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.data === undefined) && !opts.urn) {
                throw new Error("Missing required property 'data'");
            }
            if ((!args || args.engineType === undefined) && !opts.urn) {
                throw new Error("Missing required property 'engineType'");
            }
            if ((!args || args.engineVersion === undefined) && !opts.urn) {
                throw new Error("Missing required property 'engineVersion'");
            }
            if ((!args || args.name === undefined) && !opts.urn) {
                throw new Error("Missing required property 'name'");
            }
            inputs["authenticationStrategy"] = args ? args.authenticationStrategy : undefined;
            inputs["data"] = args ? args.data : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["engineType"] = args ? args.engineType : undefined;
            inputs["engineVersion"] = args ? args.engineVersion : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["arn"] = undefined /*out*/;
            inputs["revision"] = undefined /*out*/;
        } else {
            inputs["arn"] = undefined /*out*/;
            inputs["authenticationStrategy"] = undefined /*out*/;
            inputs["data"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["engineType"] = undefined /*out*/;
            inputs["engineVersion"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["revision"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Configuration.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Configuration resource.
 */
export interface ConfigurationArgs {
    authenticationStrategy?: pulumi.Input<string>;
    data: pulumi.Input<string>;
    description?: pulumi.Input<string>;
    engineType: pulumi.Input<string>;
    engineVersion: pulumi.Input<string>;
    name: pulumi.Input<string>;
    tags?: pulumi.Input<pulumi.Input<inputs.amazonmq.ConfigurationTagsEntryArgs>[]>;
}
