// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::GameLift::Script
 *
 * @deprecated Script is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class Script extends pulumi.CustomResource {
    /**
     * Get an existing Script resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Script {
        pulumi.log.warn("Script is deprecated: Script is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new Script(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:gamelift:Script';

    /**
     * Returns true if the given object is an instance of Script.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Script {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Script.__pulumiType;
    }

    public /*out*/ readonly arn!: pulumi.Output<string>;
    public readonly name!: pulumi.Output<string | undefined>;
    public readonly storageLocation!: pulumi.Output<outputs.gamelift.ScriptS3Location>;
    public readonly version!: pulumi.Output<string | undefined>;

    /**
     * Create a Script resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Script is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args: ScriptArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("Script is deprecated: Script is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.storageLocation === undefined) && !opts.urn) {
                throw new Error("Missing required property 'storageLocation'");
            }
            inputs["name"] = args ? args.name : undefined;
            inputs["storageLocation"] = args ? args.storageLocation : undefined;
            inputs["version"] = args ? args.version : undefined;
            inputs["arn"] = undefined /*out*/;
        } else {
            inputs["arn"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["storageLocation"] = undefined /*out*/;
            inputs["version"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Script.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Script resource.
 */
export interface ScriptArgs {
    name?: pulumi.Input<string>;
    storageLocation: pulumi.Input<inputs.gamelift.ScriptS3LocationArgs>;
    version?: pulumi.Input<string>;
}
