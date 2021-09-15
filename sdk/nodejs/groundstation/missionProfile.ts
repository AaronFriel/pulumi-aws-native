// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * AWS Ground Station Mission Profile resource type for CloudFormation.
 */
export class MissionProfile extends pulumi.CustomResource {
    /**
     * Get an existing MissionProfile resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): MissionProfile {
        return new MissionProfile(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:groundstation:MissionProfile';

    /**
     * Returns true if the given object is an instance of MissionProfile.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is MissionProfile {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === MissionProfile.__pulumiType;
    }

    public /*out*/ readonly arn!: pulumi.Output<string>;
    /**
     * Post-pass time needed after the contact.
     */
    public readonly contactPostPassDurationSeconds!: pulumi.Output<number | undefined>;
    /**
     * Pre-pass time needed before the contact.
     */
    public readonly contactPrePassDurationSeconds!: pulumi.Output<number | undefined>;
    public readonly dataflowEdges!: pulumi.Output<outputs.groundstation.MissionProfileDataflowEdge[]>;
    /**
     * Visibilities with shorter duration than the specified minimum viable contact duration will be ignored when searching for available contacts.
     */
    public readonly minimumViableContactDurationSeconds!: pulumi.Output<number>;
    /**
     * A name used to identify a mission profile.
     */
    public readonly name!: pulumi.Output<string>;
    public /*out*/ readonly region!: pulumi.Output<string>;
    public readonly tags!: pulumi.Output<outputs.groundstation.MissionProfileTag[] | undefined>;
    public readonly trackingConfigArn!: pulumi.Output<string>;

    /**
     * Create a MissionProfile resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: MissionProfileArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.dataflowEdges === undefined) && !opts.urn) {
                throw new Error("Missing required property 'dataflowEdges'");
            }
            if ((!args || args.minimumViableContactDurationSeconds === undefined) && !opts.urn) {
                throw new Error("Missing required property 'minimumViableContactDurationSeconds'");
            }
            if ((!args || args.name === undefined) && !opts.urn) {
                throw new Error("Missing required property 'name'");
            }
            if ((!args || args.trackingConfigArn === undefined) && !opts.urn) {
                throw new Error("Missing required property 'trackingConfigArn'");
            }
            inputs["contactPostPassDurationSeconds"] = args ? args.contactPostPassDurationSeconds : undefined;
            inputs["contactPrePassDurationSeconds"] = args ? args.contactPrePassDurationSeconds : undefined;
            inputs["dataflowEdges"] = args ? args.dataflowEdges : undefined;
            inputs["minimumViableContactDurationSeconds"] = args ? args.minimumViableContactDurationSeconds : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["trackingConfigArn"] = args ? args.trackingConfigArn : undefined;
            inputs["arn"] = undefined /*out*/;
            inputs["region"] = undefined /*out*/;
        } else {
            inputs["arn"] = undefined /*out*/;
            inputs["contactPostPassDurationSeconds"] = undefined /*out*/;
            inputs["contactPrePassDurationSeconds"] = undefined /*out*/;
            inputs["dataflowEdges"] = undefined /*out*/;
            inputs["minimumViableContactDurationSeconds"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["region"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["trackingConfigArn"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(MissionProfile.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a MissionProfile resource.
 */
export interface MissionProfileArgs {
    /**
     * Post-pass time needed after the contact.
     */
    contactPostPassDurationSeconds?: pulumi.Input<number>;
    /**
     * Pre-pass time needed before the contact.
     */
    contactPrePassDurationSeconds?: pulumi.Input<number>;
    dataflowEdges: pulumi.Input<pulumi.Input<inputs.groundstation.MissionProfileDataflowEdgeArgs>[]>;
    /**
     * Visibilities with shorter duration than the specified minimum viable contact duration will be ignored when searching for available contacts.
     */
    minimumViableContactDurationSeconds: pulumi.Input<number>;
    /**
     * A name used to identify a mission profile.
     */
    name: pulumi.Input<string>;
    tags?: pulumi.Input<pulumi.Input<inputs.groundstation.MissionProfileTagArgs>[]>;
    trackingConfigArn: pulumi.Input<string>;
}
