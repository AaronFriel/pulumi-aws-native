// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Definition of AWS::Location::GeofenceCollection Resource Type
 */
export class GeofenceCollection extends pulumi.CustomResource {
    /**
     * Get an existing GeofenceCollection resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): GeofenceCollection {
        return new GeofenceCollection(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:location:GeofenceCollection';

    /**
     * Returns true if the given object is an instance of GeofenceCollection.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is GeofenceCollection {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === GeofenceCollection.__pulumiType;
    }

    public /*out*/ readonly arn!: pulumi.Output<string>;
    public /*out*/ readonly collectionArn!: pulumi.Output<string>;
    public readonly collectionName!: pulumi.Output<string>;
    public /*out*/ readonly createTime!: pulumi.Output<string>;
    public readonly description!: pulumi.Output<string | undefined>;
    public readonly kmsKeyId!: pulumi.Output<string | undefined>;
    public readonly pricingPlan!: pulumi.Output<string>;
    public readonly pricingPlanDataSource!: pulumi.Output<string | undefined>;
    public /*out*/ readonly updateTime!: pulumi.Output<string>;

    /**
     * Create a GeofenceCollection resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: GeofenceCollectionArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.collectionName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'collectionName'");
            }
            if ((!args || args.pricingPlan === undefined) && !opts.urn) {
                throw new Error("Missing required property 'pricingPlan'");
            }
            inputs["collectionName"] = args ? args.collectionName : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["kmsKeyId"] = args ? args.kmsKeyId : undefined;
            inputs["pricingPlan"] = args ? args.pricingPlan : undefined;
            inputs["pricingPlanDataSource"] = args ? args.pricingPlanDataSource : undefined;
            inputs["arn"] = undefined /*out*/;
            inputs["collectionArn"] = undefined /*out*/;
            inputs["createTime"] = undefined /*out*/;
            inputs["updateTime"] = undefined /*out*/;
        } else {
            inputs["arn"] = undefined /*out*/;
            inputs["collectionArn"] = undefined /*out*/;
            inputs["collectionName"] = undefined /*out*/;
            inputs["createTime"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["kmsKeyId"] = undefined /*out*/;
            inputs["pricingPlan"] = undefined /*out*/;
            inputs["pricingPlanDataSource"] = undefined /*out*/;
            inputs["updateTime"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(GeofenceCollection.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a GeofenceCollection resource.
 */
export interface GeofenceCollectionArgs {
    collectionName: pulumi.Input<string>;
    description?: pulumi.Input<string>;
    kmsKeyId?: pulumi.Input<string>;
    pricingPlan: pulumi.Input<string>;
    pricingPlanDataSource?: pulumi.Input<string>;
}
