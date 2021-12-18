// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * AWS::DeviceFarm::InstanceProfile creates a new Device Farm Instance Profile
 */
export class InstanceProfile extends pulumi.CustomResource {
    /**
     * Get an existing InstanceProfile resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): InstanceProfile {
        return new InstanceProfile(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:devicefarm:InstanceProfile';

    /**
     * Returns true if the given object is an instance of InstanceProfile.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is InstanceProfile {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === InstanceProfile.__pulumiType;
    }

    public /*out*/ readonly arn!: pulumi.Output<string>;
    public readonly description!: pulumi.Output<string | undefined>;
    public readonly excludeAppPackagesFromCleanup!: pulumi.Output<string[] | undefined>;
    public readonly name!: pulumi.Output<string>;
    public readonly packageCleanup!: pulumi.Output<boolean | undefined>;
    public readonly rebootAfterUse!: pulumi.Output<boolean | undefined>;
    public readonly tags!: pulumi.Output<outputs.devicefarm.InstanceProfileTag[] | undefined>;

    /**
     * Create a InstanceProfile resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: InstanceProfileArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            inputs["description"] = args ? args.description : undefined;
            inputs["excludeAppPackagesFromCleanup"] = args ? args.excludeAppPackagesFromCleanup : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["packageCleanup"] = args ? args.packageCleanup : undefined;
            inputs["rebootAfterUse"] = args ? args.rebootAfterUse : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["arn"] = undefined /*out*/;
        } else {
            inputs["arn"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["excludeAppPackagesFromCleanup"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["packageCleanup"] = undefined /*out*/;
            inputs["rebootAfterUse"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(InstanceProfile.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a InstanceProfile resource.
 */
export interface InstanceProfileArgs {
    description?: pulumi.Input<string>;
    excludeAppPackagesFromCleanup?: pulumi.Input<pulumi.Input<string>[]>;
    name?: pulumi.Input<string>;
    packageCleanup?: pulumi.Input<boolean>;
    rebootAfterUse?: pulumi.Input<boolean>;
    tags?: pulumi.Input<pulumi.Input<inputs.devicefarm.InstanceProfileTagArgs>[]>;
}
