// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::ElasticLoadBalancingV2::LoadBalancer
 *
 * @deprecated LoadBalancer is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
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
        pulumi.log.warn("LoadBalancer is deprecated: LoadBalancer is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new LoadBalancer(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:elasticloadbalancingv2:LoadBalancer';

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

    public /*out*/ readonly canonicalHostedZoneID!: pulumi.Output<string>;
    public /*out*/ readonly dNSName!: pulumi.Output<string>;
    public readonly ipAddressType!: pulumi.Output<string | undefined>;
    public readonly loadBalancerAttributes!: pulumi.Output<outputs.elasticloadbalancingv2.LoadBalancerLoadBalancerAttribute[] | undefined>;
    public /*out*/ readonly loadBalancerFullName!: pulumi.Output<string>;
    public /*out*/ readonly loadBalancerName!: pulumi.Output<string>;
    public readonly name!: pulumi.Output<string | undefined>;
    public readonly scheme!: pulumi.Output<string | undefined>;
    public readonly securityGroups!: pulumi.Output<string[] | undefined>;
    public readonly subnetMappings!: pulumi.Output<outputs.elasticloadbalancingv2.LoadBalancerSubnetMapping[] | undefined>;
    public readonly subnets!: pulumi.Output<string[] | undefined>;
    public readonly tags!: pulumi.Output<outputs.elasticloadbalancingv2.LoadBalancerTag[] | undefined>;
    public readonly type!: pulumi.Output<string | undefined>;

    /**
     * Create a LoadBalancer resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated LoadBalancer is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args?: LoadBalancerArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("LoadBalancer is deprecated: LoadBalancer is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            inputs["ipAddressType"] = args ? args.ipAddressType : undefined;
            inputs["loadBalancerAttributes"] = args ? args.loadBalancerAttributes : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["scheme"] = args ? args.scheme : undefined;
            inputs["securityGroups"] = args ? args.securityGroups : undefined;
            inputs["subnetMappings"] = args ? args.subnetMappings : undefined;
            inputs["subnets"] = args ? args.subnets : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["type"] = args ? args.type : undefined;
            inputs["canonicalHostedZoneID"] = undefined /*out*/;
            inputs["dNSName"] = undefined /*out*/;
            inputs["loadBalancerFullName"] = undefined /*out*/;
            inputs["loadBalancerName"] = undefined /*out*/;
        } else {
            inputs["canonicalHostedZoneID"] = undefined /*out*/;
            inputs["dNSName"] = undefined /*out*/;
            inputs["ipAddressType"] = undefined /*out*/;
            inputs["loadBalancerAttributes"] = undefined /*out*/;
            inputs["loadBalancerFullName"] = undefined /*out*/;
            inputs["loadBalancerName"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["scheme"] = undefined /*out*/;
            inputs["securityGroups"] = undefined /*out*/;
            inputs["subnetMappings"] = undefined /*out*/;
            inputs["subnets"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
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
    ipAddressType?: pulumi.Input<string>;
    loadBalancerAttributes?: pulumi.Input<pulumi.Input<inputs.elasticloadbalancingv2.LoadBalancerLoadBalancerAttributeArgs>[]>;
    name?: pulumi.Input<string>;
    scheme?: pulumi.Input<string>;
    securityGroups?: pulumi.Input<pulumi.Input<string>[]>;
    subnetMappings?: pulumi.Input<pulumi.Input<inputs.elasticloadbalancingv2.LoadBalancerSubnetMappingArgs>[]>;
    subnets?: pulumi.Input<pulumi.Input<string>[]>;
    tags?: pulumi.Input<pulumi.Input<inputs.elasticloadbalancingv2.LoadBalancerTagArgs>[]>;
    type?: pulumi.Input<string>;
}
