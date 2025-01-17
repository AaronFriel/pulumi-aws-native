// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::Lightsail::LoadBalancer
 */
export class LoadBalancer extends pulumi.CustomResource {
    /**
     * Get an existing LoadBalancer resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): LoadBalancer {
        return new LoadBalancer(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:lightsail:LoadBalancer';

    /**
     * Returns true if the given object is an instance of LoadBalancer.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is LoadBalancer {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === LoadBalancer.__pulumiType;
    }

    /**
     * The names of the instances attached to the load balancer.
     */
    public readonly attachedInstances!: pulumi.Output<string[] | undefined>;
    /**
     * The path you provided to perform the load balancer health check. If you didn't specify a health check path, Lightsail uses the root path of your website (e.g., "/").
     */
    public readonly healthCheckPath!: pulumi.Output<string | undefined>;
    /**
     * The instance port where you're creating your load balancer.
     */
    public readonly instancePort!: pulumi.Output<number>;
    /**
     * The IP address type for the load balancer. The possible values are ipv4 for IPv4 only, and dualstack for IPv4 and IPv6. The default value is dualstack.
     */
    public readonly ipAddressType!: pulumi.Output<string | undefined>;
    public /*out*/ readonly loadBalancerArn!: pulumi.Output<string>;
    /**
     * The name of your load balancer.
     */
    public readonly loadBalancerName!: pulumi.Output<string>;
    /**
     * Configuration option to enable session stickiness.
     */
    public readonly sessionStickinessEnabled!: pulumi.Output<boolean | undefined>;
    /**
     * Configuration option to adjust session stickiness cookie duration parameter.
     */
    public readonly sessionStickinessLBCookieDurationSeconds!: pulumi.Output<string | undefined>;
    /**
     * An array of key-value pairs to apply to this resource.
     */
    public readonly tags!: pulumi.Output<outputs.lightsail.LoadBalancerTag[] | undefined>;

    /**
     * Create a LoadBalancer resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: LoadBalancerArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.instancePort === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instancePort'");
            }
            inputs["attachedInstances"] = args ? args.attachedInstances : undefined;
            inputs["healthCheckPath"] = args ? args.healthCheckPath : undefined;
            inputs["instancePort"] = args ? args.instancePort : undefined;
            inputs["ipAddressType"] = args ? args.ipAddressType : undefined;
            inputs["loadBalancerName"] = args ? args.loadBalancerName : undefined;
            inputs["sessionStickinessEnabled"] = args ? args.sessionStickinessEnabled : undefined;
            inputs["sessionStickinessLBCookieDurationSeconds"] = args ? args.sessionStickinessLBCookieDurationSeconds : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["loadBalancerArn"] = undefined /*out*/;
        } else {
            inputs["attachedInstances"] = undefined /*out*/;
            inputs["healthCheckPath"] = undefined /*out*/;
            inputs["instancePort"] = undefined /*out*/;
            inputs["ipAddressType"] = undefined /*out*/;
            inputs["loadBalancerArn"] = undefined /*out*/;
            inputs["loadBalancerName"] = undefined /*out*/;
            inputs["sessionStickinessEnabled"] = undefined /*out*/;
            inputs["sessionStickinessLBCookieDurationSeconds"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(LoadBalancer.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a LoadBalancer resource.
 */
export interface LoadBalancerArgs {
    /**
     * The names of the instances attached to the load balancer.
     */
    attachedInstances?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The path you provided to perform the load balancer health check. If you didn't specify a health check path, Lightsail uses the root path of your website (e.g., "/").
     */
    healthCheckPath?: pulumi.Input<string>;
    /**
     * The instance port where you're creating your load balancer.
     */
    instancePort: pulumi.Input<number>;
    /**
     * The IP address type for the load balancer. The possible values are ipv4 for IPv4 only, and dualstack for IPv4 and IPv6. The default value is dualstack.
     */
    ipAddressType?: pulumi.Input<string>;
    /**
     * The name of your load balancer.
     */
    loadBalancerName?: pulumi.Input<string>;
    /**
     * Configuration option to enable session stickiness.
     */
    sessionStickinessEnabled?: pulumi.Input<boolean>;
    /**
     * Configuration option to adjust session stickiness cookie duration parameter.
     */
    sessionStickinessLBCookieDurationSeconds?: pulumi.Input<string>;
    /**
     * An array of key-value pairs to apply to this resource.
     */
    tags?: pulumi.Input<pulumi.Input<inputs.lightsail.LoadBalancerTagArgs>[]>;
}
