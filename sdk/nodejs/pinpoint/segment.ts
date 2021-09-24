// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::Pinpoint::Segment
 *
 * @deprecated Segment is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class Segment extends pulumi.CustomResource {
    /**
     * Get an existing Segment resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Segment {
        pulumi.log.warn("Segment is deprecated: Segment is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new Segment(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:pinpoint:Segment';

    /**
     * Returns true if the given object is an instance of Segment.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Segment {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Segment.__pulumiType;
    }

    public readonly applicationId!: pulumi.Output<string>;
    public /*out*/ readonly arn!: pulumi.Output<string>;
    public readonly dimensions!: pulumi.Output<outputs.pinpoint.SegmentSegmentDimensions | undefined>;
    public readonly name!: pulumi.Output<string>;
    public readonly segmentGroups!: pulumi.Output<outputs.pinpoint.SegmentSegmentGroups | undefined>;
    public /*out*/ readonly segmentId!: pulumi.Output<string>;
    public readonly tags!: pulumi.Output<any | undefined>;

    /**
     * Create a Segment resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Segment is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args: SegmentArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("Segment is deprecated: Segment is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.applicationId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'applicationId'");
            }
            if ((!args || args.name === undefined) && !opts.urn) {
                throw new Error("Missing required property 'name'");
            }
            inputs["applicationId"] = args ? args.applicationId : undefined;
            inputs["dimensions"] = args ? args.dimensions : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["segmentGroups"] = args ? args.segmentGroups : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["arn"] = undefined /*out*/;
            inputs["segmentId"] = undefined /*out*/;
        } else {
            inputs["applicationId"] = undefined /*out*/;
            inputs["arn"] = undefined /*out*/;
            inputs["dimensions"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["segmentGroups"] = undefined /*out*/;
            inputs["segmentId"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Segment.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Segment resource.
 */
export interface SegmentArgs {
    applicationId: pulumi.Input<string>;
    dimensions?: pulumi.Input<inputs.pinpoint.SegmentSegmentDimensionsArgs>;
    name: pulumi.Input<string>;
    segmentGroups?: pulumi.Input<inputs.pinpoint.SegmentSegmentGroupsArgs>;
    tags?: any;
}
