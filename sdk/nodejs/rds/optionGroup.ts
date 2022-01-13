// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::RDS::OptionGroup
 *
 * @deprecated OptionGroup is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class OptionGroup extends pulumi.CustomResource {
    /**
     * Get an existing OptionGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): OptionGroup {
        pulumi.log.warn("OptionGroup is deprecated: OptionGroup is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new OptionGroup(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:rds:OptionGroup';

    /**
     * Returns true if the given object is an instance of OptionGroup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is OptionGroup {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === OptionGroup.__pulumiType;
    }

    public readonly engineName!: pulumi.Output<string>;
    public readonly majorEngineVersion!: pulumi.Output<string>;
    public readonly optionConfigurations!: pulumi.Output<outputs.rds.OptionGroupOptionConfiguration[]>;
    public readonly optionGroupDescription!: pulumi.Output<string>;
    public readonly tags!: pulumi.Output<outputs.rds.OptionGroupTag[] | undefined>;

    /**
     * Create a OptionGroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated OptionGroup is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args: OptionGroupArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("OptionGroup is deprecated: OptionGroup is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.engineName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'engineName'");
            }
            if ((!args || args.majorEngineVersion === undefined) && !opts.urn) {
                throw new Error("Missing required property 'majorEngineVersion'");
            }
            if ((!args || args.optionConfigurations === undefined) && !opts.urn) {
                throw new Error("Missing required property 'optionConfigurations'");
            }
            if ((!args || args.optionGroupDescription === undefined) && !opts.urn) {
                throw new Error("Missing required property 'optionGroupDescription'");
            }
            inputs["engineName"] = args ? args.engineName : undefined;
            inputs["majorEngineVersion"] = args ? args.majorEngineVersion : undefined;
            inputs["optionConfigurations"] = args ? args.optionConfigurations : undefined;
            inputs["optionGroupDescription"] = args ? args.optionGroupDescription : undefined;
            inputs["tags"] = args ? args.tags : undefined;
        } else {
            inputs["engineName"] = undefined /*out*/;
            inputs["majorEngineVersion"] = undefined /*out*/;
            inputs["optionConfigurations"] = undefined /*out*/;
            inputs["optionGroupDescription"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(OptionGroup.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a OptionGroup resource.
 */
export interface OptionGroupArgs {
    engineName: pulumi.Input<string>;
    majorEngineVersion: pulumi.Input<string>;
    optionConfigurations: pulumi.Input<pulumi.Input<inputs.rds.OptionGroupOptionConfigurationArgs>[]>;
    optionGroupDescription: pulumi.Input<string>;
    tags?: pulumi.Input<pulumi.Input<inputs.rds.OptionGroupTagArgs>[]>;
}
