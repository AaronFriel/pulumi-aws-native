// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::Pinpoint::SMSChannel
 *
 * @deprecated SMSChannel is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class SMSChannel extends pulumi.CustomResource {
    /**
     * Get an existing SMSChannel resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): SMSChannel {
        pulumi.log.warn("SMSChannel is deprecated: SMSChannel is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new SMSChannel(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:pinpoint:SMSChannel';

    /**
     * Returns true if the given object is an instance of SMSChannel.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SMSChannel {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SMSChannel.__pulumiType;
    }

    public readonly applicationId!: pulumi.Output<string>;
    public readonly enabled!: pulumi.Output<boolean | undefined>;
    public readonly senderId!: pulumi.Output<string | undefined>;
    public readonly shortCode!: pulumi.Output<string | undefined>;

    /**
     * Create a SMSChannel resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated SMSChannel is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args: SMSChannelArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("SMSChannel is deprecated: SMSChannel is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.applicationId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'applicationId'");
            }
            inputs["applicationId"] = args ? args.applicationId : undefined;
            inputs["enabled"] = args ? args.enabled : undefined;
            inputs["senderId"] = args ? args.senderId : undefined;
            inputs["shortCode"] = args ? args.shortCode : undefined;
        } else {
            inputs["applicationId"] = undefined /*out*/;
            inputs["enabled"] = undefined /*out*/;
            inputs["senderId"] = undefined /*out*/;
            inputs["shortCode"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(SMSChannel.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a SMSChannel resource.
 */
export interface SMSChannelArgs {
    applicationId: pulumi.Input<string>;
    enabled?: pulumi.Input<boolean>;
    senderId?: pulumi.Input<string>;
    shortCode?: pulumi.Input<string>;
}
