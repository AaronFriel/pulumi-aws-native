// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::IoTAnalytics::Channel
 */
export class Channel extends pulumi.CustomResource {
    /**
     * Get an existing Channel resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Channel {
        return new Channel(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:iotanalytics:Channel';

    /**
     * Returns true if the given object is an instance of Channel.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Channel {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Channel.__pulumiType;
    }

    public readonly channelName!: pulumi.Output<string | undefined>;
    public readonly channelStorage!: pulumi.Output<outputs.iotanalytics.ChannelStorage | undefined>;
    public readonly retentionPeriod!: pulumi.Output<outputs.iotanalytics.ChannelRetentionPeriod | undefined>;
    public readonly tags!: pulumi.Output<outputs.iotanalytics.ChannelTag[] | undefined>;

    /**
     * Create a Channel resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: ChannelArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            inputs["channelName"] = args ? args.channelName : undefined;
            inputs["channelStorage"] = args ? args.channelStorage : undefined;
            inputs["retentionPeriod"] = args ? args.retentionPeriod : undefined;
            inputs["tags"] = args ? args.tags : undefined;
        } else {
            inputs["channelName"] = undefined /*out*/;
            inputs["channelStorage"] = undefined /*out*/;
            inputs["retentionPeriod"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Channel.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Channel resource.
 */
export interface ChannelArgs {
    channelName?: pulumi.Input<string>;
    channelStorage?: pulumi.Input<inputs.iotanalytics.ChannelStorageArgs>;
    retentionPeriod?: pulumi.Input<inputs.iotanalytics.ChannelRetentionPeriodArgs>;
    tags?: pulumi.Input<pulumi.Input<inputs.iotanalytics.ChannelTagArgs>[]>;
}
