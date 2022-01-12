// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::SSM::PatchBaseline
 *
 * @deprecated PatchBaseline is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class PatchBaseline extends pulumi.CustomResource {
    /**
     * Get an existing PatchBaseline resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): PatchBaseline {
        pulumi.log.warn("PatchBaseline is deprecated: PatchBaseline is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new PatchBaseline(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:ssm:PatchBaseline';

    /**
     * Returns true if the given object is an instance of PatchBaseline.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is PatchBaseline {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === PatchBaseline.__pulumiType;
    }

    public readonly approvalRules!: pulumi.Output<outputs.ssm.PatchBaselineRuleGroup | undefined>;
    public readonly approvedPatches!: pulumi.Output<string[] | undefined>;
    public readonly approvedPatchesComplianceLevel!: pulumi.Output<string | undefined>;
    public readonly approvedPatchesEnableNonSecurity!: pulumi.Output<boolean | undefined>;
    public readonly description!: pulumi.Output<string | undefined>;
    public readonly globalFilters!: pulumi.Output<outputs.ssm.PatchBaselinePatchFilterGroup | undefined>;
    public readonly name!: pulumi.Output<string>;
    public readonly operatingSystem!: pulumi.Output<string | undefined>;
    public readonly patchGroups!: pulumi.Output<string[] | undefined>;
    public readonly rejectedPatches!: pulumi.Output<string[] | undefined>;
    public readonly rejectedPatchesAction!: pulumi.Output<string | undefined>;
    public readonly sources!: pulumi.Output<outputs.ssm.PatchBaselinePatchSource[] | undefined>;
    public readonly tags!: pulumi.Output<outputs.ssm.PatchBaselineTag[] | undefined>;

    /**
     * Create a PatchBaseline resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated PatchBaseline is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args?: PatchBaselineArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("PatchBaseline is deprecated: PatchBaseline is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            inputs["approvalRules"] = args ? args.approvalRules : undefined;
            inputs["approvedPatches"] = args ? args.approvedPatches : undefined;
            inputs["approvedPatchesComplianceLevel"] = args ? args.approvedPatchesComplianceLevel : undefined;
            inputs["approvedPatchesEnableNonSecurity"] = args ? args.approvedPatchesEnableNonSecurity : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["globalFilters"] = args ? args.globalFilters : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["operatingSystem"] = args ? args.operatingSystem : undefined;
            inputs["patchGroups"] = args ? args.patchGroups : undefined;
            inputs["rejectedPatches"] = args ? args.rejectedPatches : undefined;
            inputs["rejectedPatchesAction"] = args ? args.rejectedPatchesAction : undefined;
            inputs["sources"] = args ? args.sources : undefined;
            inputs["tags"] = args ? args.tags : undefined;
        } else {
            inputs["approvalRules"] = undefined /*out*/;
            inputs["approvedPatches"] = undefined /*out*/;
            inputs["approvedPatchesComplianceLevel"] = undefined /*out*/;
            inputs["approvedPatchesEnableNonSecurity"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["globalFilters"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["operatingSystem"] = undefined /*out*/;
            inputs["patchGroups"] = undefined /*out*/;
            inputs["rejectedPatches"] = undefined /*out*/;
            inputs["rejectedPatchesAction"] = undefined /*out*/;
            inputs["sources"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(PatchBaseline.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a PatchBaseline resource.
 */
export interface PatchBaselineArgs {
    approvalRules?: pulumi.Input<inputs.ssm.PatchBaselineRuleGroupArgs>;
    approvedPatches?: pulumi.Input<pulumi.Input<string>[]>;
    approvedPatchesComplianceLevel?: pulumi.Input<string>;
    approvedPatchesEnableNonSecurity?: pulumi.Input<boolean>;
    description?: pulumi.Input<string>;
    globalFilters?: pulumi.Input<inputs.ssm.PatchBaselinePatchFilterGroupArgs>;
    name?: pulumi.Input<string>;
    operatingSystem?: pulumi.Input<string>;
    patchGroups?: pulumi.Input<pulumi.Input<string>[]>;
    rejectedPatches?: pulumi.Input<pulumi.Input<string>[]>;
    rejectedPatchesAction?: pulumi.Input<string>;
    sources?: pulumi.Input<pulumi.Input<inputs.ssm.PatchBaselinePatchSourceArgs>[]>;
    tags?: pulumi.Input<pulumi.Input<inputs.ssm.PatchBaselineTagArgs>[]>;
}
