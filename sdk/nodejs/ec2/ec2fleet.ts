// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::EC2::EC2Fleet
 */
export class EC2Fleet extends pulumi.CustomResource {
    /**
     * Get an existing EC2Fleet resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): EC2Fleet {
        return new EC2Fleet(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:ec2:EC2Fleet';

    /**
     * Returns true if the given object is an instance of EC2Fleet.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is EC2Fleet {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === EC2Fleet.__pulumiType;
    }

    public readonly context!: pulumi.Output<string | undefined>;
    public readonly excessCapacityTerminationPolicy!: pulumi.Output<enums.ec2.EC2FleetExcessCapacityTerminationPolicy | undefined>;
    public /*out*/ readonly fleetId!: pulumi.Output<string>;
    public readonly launchTemplateConfigs!: pulumi.Output<outputs.ec2.EC2FleetFleetLaunchTemplateConfigRequest[]>;
    public readonly onDemandOptions!: pulumi.Output<outputs.ec2.EC2FleetOnDemandOptionsRequest | undefined>;
    public readonly replaceUnhealthyInstances!: pulumi.Output<boolean | undefined>;
    public readonly spotOptions!: pulumi.Output<outputs.ec2.EC2FleetSpotOptionsRequest | undefined>;
    public readonly tagSpecifications!: pulumi.Output<outputs.ec2.EC2FleetTagSpecification[] | undefined>;
    public readonly targetCapacitySpecification!: pulumi.Output<outputs.ec2.EC2FleetTargetCapacitySpecificationRequest>;
    public readonly terminateInstancesWithExpiration!: pulumi.Output<boolean | undefined>;
    public readonly type!: pulumi.Output<enums.ec2.EC2FleetType | undefined>;
    public readonly validFrom!: pulumi.Output<string | undefined>;
    public readonly validUntil!: pulumi.Output<string | undefined>;

    /**
     * Create a EC2Fleet resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: EC2FleetArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.launchTemplateConfigs === undefined) && !opts.urn) {
                throw new Error("Missing required property 'launchTemplateConfigs'");
            }
            if ((!args || args.targetCapacitySpecification === undefined) && !opts.urn) {
                throw new Error("Missing required property 'targetCapacitySpecification'");
            }
            inputs["context"] = args ? args.context : undefined;
            inputs["excessCapacityTerminationPolicy"] = args ? args.excessCapacityTerminationPolicy : undefined;
            inputs["launchTemplateConfigs"] = args ? args.launchTemplateConfigs : undefined;
            inputs["onDemandOptions"] = args ? args.onDemandOptions : undefined;
            inputs["replaceUnhealthyInstances"] = args ? args.replaceUnhealthyInstances : undefined;
            inputs["spotOptions"] = args ? args.spotOptions : undefined;
            inputs["tagSpecifications"] = args ? args.tagSpecifications : undefined;
            inputs["targetCapacitySpecification"] = args ? args.targetCapacitySpecification : undefined;
            inputs["terminateInstancesWithExpiration"] = args ? args.terminateInstancesWithExpiration : undefined;
            inputs["type"] = args ? args.type : undefined;
            inputs["validFrom"] = args ? args.validFrom : undefined;
            inputs["validUntil"] = args ? args.validUntil : undefined;
            inputs["fleetId"] = undefined /*out*/;
        } else {
            inputs["context"] = undefined /*out*/;
            inputs["excessCapacityTerminationPolicy"] = undefined /*out*/;
            inputs["fleetId"] = undefined /*out*/;
            inputs["launchTemplateConfigs"] = undefined /*out*/;
            inputs["onDemandOptions"] = undefined /*out*/;
            inputs["replaceUnhealthyInstances"] = undefined /*out*/;
            inputs["spotOptions"] = undefined /*out*/;
            inputs["tagSpecifications"] = undefined /*out*/;
            inputs["targetCapacitySpecification"] = undefined /*out*/;
            inputs["terminateInstancesWithExpiration"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["validFrom"] = undefined /*out*/;
            inputs["validUntil"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(EC2Fleet.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a EC2Fleet resource.
 */
export interface EC2FleetArgs {
    context?: pulumi.Input<string>;
    excessCapacityTerminationPolicy?: pulumi.Input<enums.ec2.EC2FleetExcessCapacityTerminationPolicy>;
    launchTemplateConfigs: pulumi.Input<pulumi.Input<inputs.ec2.EC2FleetFleetLaunchTemplateConfigRequestArgs>[]>;
    onDemandOptions?: pulumi.Input<inputs.ec2.EC2FleetOnDemandOptionsRequestArgs>;
    replaceUnhealthyInstances?: pulumi.Input<boolean>;
    spotOptions?: pulumi.Input<inputs.ec2.EC2FleetSpotOptionsRequestArgs>;
    tagSpecifications?: pulumi.Input<pulumi.Input<inputs.ec2.EC2FleetTagSpecificationArgs>[]>;
    targetCapacitySpecification: pulumi.Input<inputs.ec2.EC2FleetTargetCapacitySpecificationRequestArgs>;
    terminateInstancesWithExpiration?: pulumi.Input<boolean>;
    type?: pulumi.Input<enums.ec2.EC2FleetType>;
    validFrom?: pulumi.Input<string>;
    validUntil?: pulumi.Input<string>;
}
