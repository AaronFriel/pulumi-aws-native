// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * A module that has been registered in the CloudFormation registry.
 */
export class ModuleVersion extends pulumi.CustomResource {
    /**
     * Get an existing ModuleVersion resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ModuleVersion {
        return new ModuleVersion(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:cloudformation:ModuleVersion';

    /**
     * Returns true if the given object is an instance of ModuleVersion.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ModuleVersion {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ModuleVersion.__pulumiType;
    }

    /**
     * The Amazon Resource Name (ARN) of the module.
     */
    public /*out*/ readonly arn!: pulumi.Output<string>;
    /**
     * The description of the registered module.
     */
    public /*out*/ readonly description!: pulumi.Output<string>;
    /**
     * The URL of a page providing detailed documentation for this module.
     */
    public /*out*/ readonly documentationUrl!: pulumi.Output<string>;
    /**
     * Indicator of whether this module version is the current default version
     */
    public /*out*/ readonly isDefaultVersion!: pulumi.Output<boolean>;
    /**
     * The name of the module being registered.
     *
     * Recommended module naming pattern: company_or_organization::service::type::MODULE.
     */
    public readonly moduleName!: pulumi.Output<string>;
    /**
     * The url to the S3 bucket containing the schema and template fragment for the module you want to register.
     */
    public readonly modulePackage!: pulumi.Output<string>;
    /**
     * The schema defining input parameters to and resources generated by the module.
     */
    public /*out*/ readonly schema!: pulumi.Output<string>;
    /**
     * The time that the specified module version was registered.
     */
    public /*out*/ readonly timeCreated!: pulumi.Output<string>;
    /**
     * The version ID of the module represented by this module instance.
     */
    public /*out*/ readonly versionId!: pulumi.Output<string>;
    /**
     * The scope at which the type is visible and usable in CloudFormation operations.
     *
     * The only allowed value at present is:
     *
     * PRIVATE: The type is only visible and usable within the account in which it is registered. Currently, AWS CloudFormation marks any types you register as PRIVATE.
     */
    public /*out*/ readonly visibility!: pulumi.Output<string>;

    /**
     * Create a ModuleVersion resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ModuleVersionArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.moduleName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'moduleName'");
            }
            if ((!args || args.modulePackage === undefined) && !opts.urn) {
                throw new Error("Missing required property 'modulePackage'");
            }
            inputs["moduleName"] = args ? args.moduleName : undefined;
            inputs["modulePackage"] = args ? args.modulePackage : undefined;
            inputs["arn"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["documentationUrl"] = undefined /*out*/;
            inputs["isDefaultVersion"] = undefined /*out*/;
            inputs["schema"] = undefined /*out*/;
            inputs["timeCreated"] = undefined /*out*/;
            inputs["versionId"] = undefined /*out*/;
            inputs["visibility"] = undefined /*out*/;
        } else {
            inputs["arn"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["documentationUrl"] = undefined /*out*/;
            inputs["isDefaultVersion"] = undefined /*out*/;
            inputs["moduleName"] = undefined /*out*/;
            inputs["modulePackage"] = undefined /*out*/;
            inputs["schema"] = undefined /*out*/;
            inputs["timeCreated"] = undefined /*out*/;
            inputs["versionId"] = undefined /*out*/;
            inputs["visibility"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(ModuleVersion.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ModuleVersion resource.
 */
export interface ModuleVersionArgs {
    /**
     * The name of the module being registered.
     *
     * Recommended module naming pattern: company_or_organization::service::type::MODULE.
     */
    moduleName: pulumi.Input<string>;
    /**
     * The url to the S3 bucket containing the schema and template fragment for the module you want to register.
     */
    modulePackage: pulumi.Input<string>;
}
