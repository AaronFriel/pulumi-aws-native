// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::AppConfig::ConfigurationProfile
 *
 * @deprecated ConfigurationProfile is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class ConfigurationProfile extends pulumi.CustomResource {
    /**
     * Get an existing ConfigurationProfile resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ConfigurationProfile {
        pulumi.log.warn("ConfigurationProfile is deprecated: ConfigurationProfile is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new ConfigurationProfile(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:appconfig:ConfigurationProfile';

    /**
     * Returns true if the given object is an instance of ConfigurationProfile.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ConfigurationProfile {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ConfigurationProfile.__pulumiType;
    }

    public readonly applicationId!: pulumi.Output<string>;
    public readonly description!: pulumi.Output<string | undefined>;
    public readonly locationUri!: pulumi.Output<string>;
    public readonly name!: pulumi.Output<string>;
    public readonly retrievalRoleArn!: pulumi.Output<string | undefined>;
    public readonly tags!: pulumi.Output<outputs.appconfig.ConfigurationProfileTags[] | undefined>;
    public readonly type!: pulumi.Output<string | undefined>;
    public readonly validators!: pulumi.Output<outputs.appconfig.ConfigurationProfileValidators[] | undefined>;

    /**
     * Create a ConfigurationProfile resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated ConfigurationProfile is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args: ConfigurationProfileArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("ConfigurationProfile is deprecated: ConfigurationProfile is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.applicationId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'applicationId'");
            }
            if ((!args || args.locationUri === undefined) && !opts.urn) {
                throw new Error("Missing required property 'locationUri'");
            }
            inputs["applicationId"] = args ? args.applicationId : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["locationUri"] = args ? args.locationUri : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["retrievalRoleArn"] = args ? args.retrievalRoleArn : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["type"] = args ? args.type : undefined;
            inputs["validators"] = args ? args.validators : undefined;
        } else {
            inputs["applicationId"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["locationUri"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["retrievalRoleArn"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["validators"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(ConfigurationProfile.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ConfigurationProfile resource.
 */
export interface ConfigurationProfileArgs {
    applicationId: pulumi.Input<string>;
    description?: pulumi.Input<string>;
    locationUri: pulumi.Input<string>;
    name?: pulumi.Input<string>;
    retrievalRoleArn?: pulumi.Input<string>;
    tags?: pulumi.Input<pulumi.Input<inputs.appconfig.ConfigurationProfileTagsArgs>[]>;
    type?: pulumi.Input<string>;
    validators?: pulumi.Input<pulumi.Input<inputs.appconfig.ConfigurationProfileValidatorsArgs>[]>;
}
