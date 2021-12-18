// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * AWS::DeviceFarm::VPCEConfiguration creates a new Device Farm VPCE Configuration
 */
export class VPCEConfiguration extends pulumi.CustomResource {
    /**
     * Get an existing VPCEConfiguration resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): VPCEConfiguration {
        return new VPCEConfiguration(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:devicefarm:VPCEConfiguration';

    /**
     * Returns true if the given object is an instance of VPCEConfiguration.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is VPCEConfiguration {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === VPCEConfiguration.__pulumiType;
    }

    public /*out*/ readonly arn!: pulumi.Output<string>;
    public readonly serviceDnsName!: pulumi.Output<string>;
    public readonly tags!: pulumi.Output<outputs.devicefarm.VPCEConfigurationTag[] | undefined>;
    public readonly vpceConfigurationDescription!: pulumi.Output<string | undefined>;
    public readonly vpceConfigurationName!: pulumi.Output<string>;
    public readonly vpceServiceName!: pulumi.Output<string>;

    /**
     * Create a VPCEConfiguration resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: VPCEConfigurationArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.serviceDnsName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'serviceDnsName'");
            }
            if ((!args || args.vpceConfigurationName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'vpceConfigurationName'");
            }
            if ((!args || args.vpceServiceName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'vpceServiceName'");
            }
            inputs["serviceDnsName"] = args ? args.serviceDnsName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["vpceConfigurationDescription"] = args ? args.vpceConfigurationDescription : undefined;
            inputs["vpceConfigurationName"] = args ? args.vpceConfigurationName : undefined;
            inputs["vpceServiceName"] = args ? args.vpceServiceName : undefined;
            inputs["arn"] = undefined /*out*/;
        } else {
            inputs["arn"] = undefined /*out*/;
            inputs["serviceDnsName"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["vpceConfigurationDescription"] = undefined /*out*/;
            inputs["vpceConfigurationName"] = undefined /*out*/;
            inputs["vpceServiceName"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(VPCEConfiguration.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a VPCEConfiguration resource.
 */
export interface VPCEConfigurationArgs {
    serviceDnsName: pulumi.Input<string>;
    tags?: pulumi.Input<pulumi.Input<inputs.devicefarm.VPCEConfigurationTagArgs>[]>;
    vpceConfigurationDescription?: pulumi.Input<string>;
    vpceConfigurationName: pulumi.Input<string>;
    vpceServiceName: pulumi.Input<string>;
}
