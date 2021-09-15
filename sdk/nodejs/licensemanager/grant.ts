// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * An example resource schema demonstrating some basic constructs and validation rules.
 */
export class Grant extends pulumi.CustomResource {
    /**
     * Get an existing Grant resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Grant {
        return new Grant(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:licensemanager:Grant';

    /**
     * Returns true if the given object is an instance of Grant.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Grant {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Grant.__pulumiType;
    }

    public readonly allowedOperations!: pulumi.Output<string[] | undefined>;
    /**
     * Arn of the grant.
     */
    public /*out*/ readonly grantArn!: pulumi.Output<string>;
    /**
     * Name for the created Grant.
     */
    public readonly grantName!: pulumi.Output<string | undefined>;
    /**
     * Home region for the created grant.
     */
    public readonly homeRegion!: pulumi.Output<string | undefined>;
    /**
     * License Arn for the grant.
     */
    public readonly licenseArn!: pulumi.Output<string | undefined>;
    public readonly principals!: pulumi.Output<string[] | undefined>;
    public readonly status!: pulumi.Output<string | undefined>;
    /**
     * The version of the grant.
     */
    public /*out*/ readonly version!: pulumi.Output<string>;

    /**
     * Create a Grant resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: GrantArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            inputs["allowedOperations"] = args ? args.allowedOperations : undefined;
            inputs["grantName"] = args ? args.grantName : undefined;
            inputs["homeRegion"] = args ? args.homeRegion : undefined;
            inputs["licenseArn"] = args ? args.licenseArn : undefined;
            inputs["principals"] = args ? args.principals : undefined;
            inputs["status"] = args ? args.status : undefined;
            inputs["grantArn"] = undefined /*out*/;
            inputs["version"] = undefined /*out*/;
        } else {
            inputs["allowedOperations"] = undefined /*out*/;
            inputs["grantArn"] = undefined /*out*/;
            inputs["grantName"] = undefined /*out*/;
            inputs["homeRegion"] = undefined /*out*/;
            inputs["licenseArn"] = undefined /*out*/;
            inputs["principals"] = undefined /*out*/;
            inputs["status"] = undefined /*out*/;
            inputs["version"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Grant.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Grant resource.
 */
export interface GrantArgs {
    allowedOperations?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Name for the created Grant.
     */
    grantName?: pulumi.Input<string>;
    /**
     * Home region for the created grant.
     */
    homeRegion?: pulumi.Input<string>;
    /**
     * License Arn for the grant.
     */
    licenseArn?: pulumi.Input<string>;
    principals?: pulumi.Input<pulumi.Input<string>[]>;
    status?: pulumi.Input<string>;
}
