// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * The AWS::AutoScaling::LaunchConfiguration resource specifies the launch configuration that can be used by an Auto Scaling group to configure Amazon EC2 instances.
 */
export class LaunchConfiguration extends pulumi.CustomResource {
    /**
     * Get an existing LaunchConfiguration resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): LaunchConfiguration {
        return new LaunchConfiguration(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:autoscaling:LaunchConfiguration';

    /**
     * Returns true if the given object is an instance of LaunchConfiguration.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is LaunchConfiguration {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === LaunchConfiguration.__pulumiType;
    }

    /**
     * For Auto Scaling groups that are running in a virtual private cloud (VPC), specifies whether to assign a public IP address to the group's instances.
     */
    public readonly associatePublicIpAddress!: pulumi.Output<boolean | undefined>;
    /**
     * Specifies how block devices are exposed to the instance. You can specify virtual devices and EBS volumes.
     */
    public readonly blockDeviceMappings!: pulumi.Output<outputs.autoscaling.LaunchConfigurationBlockDeviceMapping[] | undefined>;
    /**
     * The ID of a ClassicLink-enabled VPC to link your EC2-Classic instances to.
     */
    public readonly classicLinkVPCId!: pulumi.Output<string | undefined>;
    /**
     * The IDs of one or more security groups for the VPC that you specified in the ClassicLinkVPCId property.
     */
    public readonly classicLinkVPCSecurityGroups!: pulumi.Output<string[] | undefined>;
    /**
     * Specifies whether the launch configuration is optimized for EBS I/O (true) or not (false).
     */
    public readonly ebsOptimized!: pulumi.Output<boolean | undefined>;
    /**
     * Provides the name or the Amazon Resource Name (ARN) of the instance profile associated with the IAM role for the instance. The instance profile contains the IAM role.
     */
    public readonly iamInstanceProfile!: pulumi.Output<string | undefined>;
    /**
     * Provides the unique ID of the Amazon Machine Image (AMI) that was assigned during registration.
     */
    public readonly imageId!: pulumi.Output<string>;
    /**
     * The ID of the Amazon EC2 instance you want to use to create the launch configuration.
     */
    public readonly instanceId!: pulumi.Output<string | undefined>;
    /**
     * Controls whether instances in this group are launched with detailed (true) or basic (false) monitoring.
     */
    public readonly instanceMonitoring!: pulumi.Output<boolean | undefined>;
    /**
     * Specifies the instance type of the EC2 instance.
     */
    public readonly instanceType!: pulumi.Output<string>;
    /**
     * Provides the ID of the kernel associated with the EC2 AMI.
     */
    public readonly kernelId!: pulumi.Output<string | undefined>;
    /**
     * Provides the name of the EC2 key pair.
     */
    public readonly keyName!: pulumi.Output<string | undefined>;
    /**
     * The name of the launch configuration. This name must be unique per Region per account.
     */
    public readonly launchConfigurationName!: pulumi.Output<string | undefined>;
    /**
     * The metadata options for the instances.
     */
    public readonly metadataOptions!: pulumi.Output<outputs.autoscaling.LaunchConfigurationMetadataOptions | undefined>;
    /**
     * The tenancy of the instance, either default or dedicated.
     */
    public readonly placementTenancy!: pulumi.Output<string | undefined>;
    /**
     * The ID of the RAM disk to select.
     */
    public readonly ramDiskId!: pulumi.Output<string | undefined>;
    /**
     * A list that contains the security groups to assign to the instances in the Auto Scaling group.
     */
    public readonly securityGroups!: pulumi.Output<string[] | undefined>;
    /**
     * The maximum hourly price you are willing to pay for any Spot Instances launched to fulfill the request.
     */
    public readonly spotPrice!: pulumi.Output<string | undefined>;
    /**
     * The Base64-encoded user data to make available to the launched EC2 instances.
     */
    public readonly userData!: pulumi.Output<string | undefined>;

    /**
     * Create a LaunchConfiguration resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: LaunchConfigurationArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.imageId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'imageId'");
            }
            if ((!args || args.instanceType === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceType'");
            }
            inputs["associatePublicIpAddress"] = args ? args.associatePublicIpAddress : undefined;
            inputs["blockDeviceMappings"] = args ? args.blockDeviceMappings : undefined;
            inputs["classicLinkVPCId"] = args ? args.classicLinkVPCId : undefined;
            inputs["classicLinkVPCSecurityGroups"] = args ? args.classicLinkVPCSecurityGroups : undefined;
            inputs["ebsOptimized"] = args ? args.ebsOptimized : undefined;
            inputs["iamInstanceProfile"] = args ? args.iamInstanceProfile : undefined;
            inputs["imageId"] = args ? args.imageId : undefined;
            inputs["instanceId"] = args ? args.instanceId : undefined;
            inputs["instanceMonitoring"] = args ? args.instanceMonitoring : undefined;
            inputs["instanceType"] = args ? args.instanceType : undefined;
            inputs["kernelId"] = args ? args.kernelId : undefined;
            inputs["keyName"] = args ? args.keyName : undefined;
            inputs["launchConfigurationName"] = args ? args.launchConfigurationName : undefined;
            inputs["metadataOptions"] = args ? args.metadataOptions : undefined;
            inputs["placementTenancy"] = args ? args.placementTenancy : undefined;
            inputs["ramDiskId"] = args ? args.ramDiskId : undefined;
            inputs["securityGroups"] = args ? args.securityGroups : undefined;
            inputs["spotPrice"] = args ? args.spotPrice : undefined;
            inputs["userData"] = args ? args.userData : undefined;
        } else {
            inputs["associatePublicIpAddress"] = undefined /*out*/;
            inputs["blockDeviceMappings"] = undefined /*out*/;
            inputs["classicLinkVPCId"] = undefined /*out*/;
            inputs["classicLinkVPCSecurityGroups"] = undefined /*out*/;
            inputs["ebsOptimized"] = undefined /*out*/;
            inputs["iamInstanceProfile"] = undefined /*out*/;
            inputs["imageId"] = undefined /*out*/;
            inputs["instanceId"] = undefined /*out*/;
            inputs["instanceMonitoring"] = undefined /*out*/;
            inputs["instanceType"] = undefined /*out*/;
            inputs["kernelId"] = undefined /*out*/;
            inputs["keyName"] = undefined /*out*/;
            inputs["launchConfigurationName"] = undefined /*out*/;
            inputs["metadataOptions"] = undefined /*out*/;
            inputs["placementTenancy"] = undefined /*out*/;
            inputs["ramDiskId"] = undefined /*out*/;
            inputs["securityGroups"] = undefined /*out*/;
            inputs["spotPrice"] = undefined /*out*/;
            inputs["userData"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(LaunchConfiguration.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a LaunchConfiguration resource.
 */
export interface LaunchConfigurationArgs {
    /**
     * For Auto Scaling groups that are running in a virtual private cloud (VPC), specifies whether to assign a public IP address to the group's instances.
     */
    associatePublicIpAddress?: pulumi.Input<boolean>;
    /**
     * Specifies how block devices are exposed to the instance. You can specify virtual devices and EBS volumes.
     */
    blockDeviceMappings?: pulumi.Input<pulumi.Input<inputs.autoscaling.LaunchConfigurationBlockDeviceMappingArgs>[]>;
    /**
     * The ID of a ClassicLink-enabled VPC to link your EC2-Classic instances to.
     */
    classicLinkVPCId?: pulumi.Input<string>;
    /**
     * The IDs of one or more security groups for the VPC that you specified in the ClassicLinkVPCId property.
     */
    classicLinkVPCSecurityGroups?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Specifies whether the launch configuration is optimized for EBS I/O (true) or not (false).
     */
    ebsOptimized?: pulumi.Input<boolean>;
    /**
     * Provides the name or the Amazon Resource Name (ARN) of the instance profile associated with the IAM role for the instance. The instance profile contains the IAM role.
     */
    iamInstanceProfile?: pulumi.Input<string>;
    /**
     * Provides the unique ID of the Amazon Machine Image (AMI) that was assigned during registration.
     */
    imageId: pulumi.Input<string>;
    /**
     * The ID of the Amazon EC2 instance you want to use to create the launch configuration.
     */
    instanceId?: pulumi.Input<string>;
    /**
     * Controls whether instances in this group are launched with detailed (true) or basic (false) monitoring.
     */
    instanceMonitoring?: pulumi.Input<boolean>;
    /**
     * Specifies the instance type of the EC2 instance.
     */
    instanceType: pulumi.Input<string>;
    /**
     * Provides the ID of the kernel associated with the EC2 AMI.
     */
    kernelId?: pulumi.Input<string>;
    /**
     * Provides the name of the EC2 key pair.
     */
    keyName?: pulumi.Input<string>;
    /**
     * The name of the launch configuration. This name must be unique per Region per account.
     */
    launchConfigurationName?: pulumi.Input<string>;
    /**
     * The metadata options for the instances.
     */
    metadataOptions?: pulumi.Input<inputs.autoscaling.LaunchConfigurationMetadataOptionsArgs>;
    /**
     * The tenancy of the instance, either default or dedicated.
     */
    placementTenancy?: pulumi.Input<string>;
    /**
     * The ID of the RAM disk to select.
     */
    ramDiskId?: pulumi.Input<string>;
    /**
     * A list that contains the security groups to assign to the instances in the Auto Scaling group.
     */
    securityGroups?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The maximum hourly price you are willing to pay for any Spot Instances launched to fulfill the request.
     */
    spotPrice?: pulumi.Input<string>;
    /**
     * The Base64-encoded user data to make available to the launched EC2 instances.
     */
    userData?: pulumi.Input<string>;
}
