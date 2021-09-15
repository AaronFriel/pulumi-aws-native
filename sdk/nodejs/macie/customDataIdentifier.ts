// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Macie CustomDataIdentifier resource schema
 */
export class CustomDataIdentifier extends pulumi.CustomResource {
    /**
     * Get an existing CustomDataIdentifier resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): CustomDataIdentifier {
        return new CustomDataIdentifier(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:macie:CustomDataIdentifier';

    /**
     * Returns true if the given object is an instance of CustomDataIdentifier.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is CustomDataIdentifier {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === CustomDataIdentifier.__pulumiType;
    }

    /**
     * Custom data identifier ARN.
     */
    public /*out*/ readonly arn!: pulumi.Output<string>;
    /**
     * Description of custom data identifier.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Words to be ignored.
     */
    public readonly ignoreWords!: pulumi.Output<string[] | undefined>;
    /**
     * Keywords to be matched against.
     */
    public readonly keywords!: pulumi.Output<string[] | undefined>;
    /**
     * Maximum match distance.
     */
    public readonly maximumMatchDistance!: pulumi.Output<number | undefined>;
    /**
     * Name of custom data identifier.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Regular expression for custom data identifier.
     */
    public readonly regex!: pulumi.Output<string>;

    /**
     * Create a CustomDataIdentifier resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: CustomDataIdentifierArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.name === undefined) && !opts.urn) {
                throw new Error("Missing required property 'name'");
            }
            if ((!args || args.regex === undefined) && !opts.urn) {
                throw new Error("Missing required property 'regex'");
            }
            inputs["description"] = args ? args.description : undefined;
            inputs["ignoreWords"] = args ? args.ignoreWords : undefined;
            inputs["keywords"] = args ? args.keywords : undefined;
            inputs["maximumMatchDistance"] = args ? args.maximumMatchDistance : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["regex"] = args ? args.regex : undefined;
            inputs["arn"] = undefined /*out*/;
        } else {
            inputs["arn"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["ignoreWords"] = undefined /*out*/;
            inputs["keywords"] = undefined /*out*/;
            inputs["maximumMatchDistance"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["regex"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(CustomDataIdentifier.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a CustomDataIdentifier resource.
 */
export interface CustomDataIdentifierArgs {
    /**
     * Description of custom data identifier.
     */
    description?: pulumi.Input<string>;
    /**
     * Words to be ignored.
     */
    ignoreWords?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Keywords to be matched against.
     */
    keywords?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Maximum match distance.
     */
    maximumMatchDistance?: pulumi.Input<number>;
    /**
     * Name of custom data identifier.
     */
    name: pulumi.Input<string>;
    /**
     * Regular expression for custom data identifier.
     */
    regex: pulumi.Input<string>;
}
