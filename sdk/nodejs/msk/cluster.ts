// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::MSK::Cluster
 *
 * @deprecated Cluster is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class Cluster extends pulumi.CustomResource {
    /**
     * Get an existing Cluster resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Cluster {
        pulumi.log.warn("Cluster is deprecated: Cluster is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new Cluster(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:msk:Cluster';

    /**
     * Returns true if the given object is an instance of Cluster.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Cluster {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Cluster.__pulumiType;
    }

    public readonly brokerNodeGroupInfo!: pulumi.Output<outputs.msk.ClusterBrokerNodeGroupInfo>;
    public readonly clientAuthentication!: pulumi.Output<outputs.msk.ClusterClientAuthentication | undefined>;
    public readonly clusterName!: pulumi.Output<string>;
    public readonly configurationInfo!: pulumi.Output<outputs.msk.ClusterConfigurationInfo | undefined>;
    public readonly encryptionInfo!: pulumi.Output<outputs.msk.ClusterEncryptionInfo | undefined>;
    public readonly enhancedMonitoring!: pulumi.Output<string | undefined>;
    public readonly kafkaVersion!: pulumi.Output<string>;
    public readonly loggingInfo!: pulumi.Output<outputs.msk.ClusterLoggingInfo | undefined>;
    public readonly numberOfBrokerNodes!: pulumi.Output<number>;
    public readonly openMonitoring!: pulumi.Output<outputs.msk.ClusterOpenMonitoring | undefined>;
    public readonly tags!: pulumi.Output<any | undefined>;

    /**
     * Create a Cluster resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Cluster is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args: ClusterArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("Cluster is deprecated: Cluster is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.brokerNodeGroupInfo === undefined) && !opts.urn) {
                throw new Error("Missing required property 'brokerNodeGroupInfo'");
            }
            if ((!args || args.clusterName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'clusterName'");
            }
            if ((!args || args.kafkaVersion === undefined) && !opts.urn) {
                throw new Error("Missing required property 'kafkaVersion'");
            }
            if ((!args || args.numberOfBrokerNodes === undefined) && !opts.urn) {
                throw new Error("Missing required property 'numberOfBrokerNodes'");
            }
            inputs["brokerNodeGroupInfo"] = args ? args.brokerNodeGroupInfo : undefined;
            inputs["clientAuthentication"] = args ? args.clientAuthentication : undefined;
            inputs["clusterName"] = args ? args.clusterName : undefined;
            inputs["configurationInfo"] = args ? args.configurationInfo : undefined;
            inputs["encryptionInfo"] = args ? args.encryptionInfo : undefined;
            inputs["enhancedMonitoring"] = args ? args.enhancedMonitoring : undefined;
            inputs["kafkaVersion"] = args ? args.kafkaVersion : undefined;
            inputs["loggingInfo"] = args ? args.loggingInfo : undefined;
            inputs["numberOfBrokerNodes"] = args ? args.numberOfBrokerNodes : undefined;
            inputs["openMonitoring"] = args ? args.openMonitoring : undefined;
            inputs["tags"] = args ? args.tags : undefined;
        } else {
            inputs["brokerNodeGroupInfo"] = undefined /*out*/;
            inputs["clientAuthentication"] = undefined /*out*/;
            inputs["clusterName"] = undefined /*out*/;
            inputs["configurationInfo"] = undefined /*out*/;
            inputs["encryptionInfo"] = undefined /*out*/;
            inputs["enhancedMonitoring"] = undefined /*out*/;
            inputs["kafkaVersion"] = undefined /*out*/;
            inputs["loggingInfo"] = undefined /*out*/;
            inputs["numberOfBrokerNodes"] = undefined /*out*/;
            inputs["openMonitoring"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Cluster.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Cluster resource.
 */
export interface ClusterArgs {
    brokerNodeGroupInfo: pulumi.Input<inputs.msk.ClusterBrokerNodeGroupInfoArgs>;
    clientAuthentication?: pulumi.Input<inputs.msk.ClusterClientAuthenticationArgs>;
    clusterName: pulumi.Input<string>;
    configurationInfo?: pulumi.Input<inputs.msk.ClusterConfigurationInfoArgs>;
    encryptionInfo?: pulumi.Input<inputs.msk.ClusterEncryptionInfoArgs>;
    enhancedMonitoring?: pulumi.Input<string>;
    kafkaVersion: pulumi.Input<string>;
    loggingInfo?: pulumi.Input<inputs.msk.ClusterLoggingInfoArgs>;
    numberOfBrokerNodes: pulumi.Input<number>;
    openMonitoring?: pulumi.Input<inputs.msk.ClusterOpenMonitoringArgs>;
    tags?: any;
}
