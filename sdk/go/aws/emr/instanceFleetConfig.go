// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package emr

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html
type InstanceFleetConfig struct {
	pulumi.CustomResourceState

	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-clusterid
	ClusterId pulumi.StringOutput `pulumi:"clusterId"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-instancefleettype
	InstanceFleetType pulumi.StringOutput `pulumi:"instanceFleetType"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-instancetypeconfigs
	InstanceTypeConfigs InstanceFleetConfigInstanceTypeConfigArrayOutput `pulumi:"instanceTypeConfigs"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-launchspecifications
	LaunchSpecifications InstanceFleetConfigInstanceFleetProvisioningSpecificationsPtrOutput `pulumi:"launchSpecifications"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-name
	Name pulumi.StringPtrOutput `pulumi:"name"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-targetondemandcapacity
	TargetOnDemandCapacity pulumi.IntPtrOutput `pulumi:"targetOnDemandCapacity"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-targetspotcapacity
	TargetSpotCapacity pulumi.IntPtrOutput `pulumi:"targetSpotCapacity"`
}

// NewInstanceFleetConfig registers a new resource with the given unique name, arguments, and options.
func NewInstanceFleetConfig(ctx *pulumi.Context,
	name string, args *InstanceFleetConfigArgs, opts ...pulumi.ResourceOption) (*InstanceFleetConfig, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ClusterId == nil {
		return nil, errors.New("invalid value for required argument 'ClusterId'")
	}
	if args.InstanceFleetType == nil {
		return nil, errors.New("invalid value for required argument 'InstanceFleetType'")
	}
	var resource InstanceFleetConfig
	err := ctx.RegisterResource("aws-native:emr:InstanceFleetConfig", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetInstanceFleetConfig gets an existing InstanceFleetConfig resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetInstanceFleetConfig(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *InstanceFleetConfigState, opts ...pulumi.ResourceOption) (*InstanceFleetConfig, error) {
	var resource InstanceFleetConfig
	err := ctx.ReadResource("aws-native:emr:InstanceFleetConfig", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering InstanceFleetConfig resources.
type instanceFleetConfigState struct {
}

type InstanceFleetConfigState struct {
}

func (InstanceFleetConfigState) ElementType() reflect.Type {
	return reflect.TypeOf((*instanceFleetConfigState)(nil)).Elem()
}

type instanceFleetConfigArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-clusterid
	ClusterId string `pulumi:"clusterId"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-instancefleettype
	InstanceFleetType string `pulumi:"instanceFleetType"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-instancetypeconfigs
	InstanceTypeConfigs []InstanceFleetConfigInstanceTypeConfig `pulumi:"instanceTypeConfigs"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-launchspecifications
	LaunchSpecifications *InstanceFleetConfigInstanceFleetProvisioningSpecifications `pulumi:"launchSpecifications"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-name
	Name *string `pulumi:"name"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-targetondemandcapacity
	TargetOnDemandCapacity *int `pulumi:"targetOnDemandCapacity"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-targetspotcapacity
	TargetSpotCapacity *int `pulumi:"targetSpotCapacity"`
}

// The set of arguments for constructing a InstanceFleetConfig resource.
type InstanceFleetConfigArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-clusterid
	ClusterId pulumi.StringInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-instancefleettype
	InstanceFleetType pulumi.StringInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-instancetypeconfigs
	InstanceTypeConfigs InstanceFleetConfigInstanceTypeConfigArrayInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-launchspecifications
	LaunchSpecifications InstanceFleetConfigInstanceFleetProvisioningSpecificationsPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-name
	Name pulumi.StringPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-targetondemandcapacity
	TargetOnDemandCapacity pulumi.IntPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-targetspotcapacity
	TargetSpotCapacity pulumi.IntPtrInput
}

func (InstanceFleetConfigArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*instanceFleetConfigArgs)(nil)).Elem()
}

type InstanceFleetConfigInput interface {
	pulumi.Input

	ToInstanceFleetConfigOutput() InstanceFleetConfigOutput
	ToInstanceFleetConfigOutputWithContext(ctx context.Context) InstanceFleetConfigOutput
}

func (*InstanceFleetConfig) ElementType() reflect.Type {
	return reflect.TypeOf((*InstanceFleetConfig)(nil))
}

func (i *InstanceFleetConfig) ToInstanceFleetConfigOutput() InstanceFleetConfigOutput {
	return i.ToInstanceFleetConfigOutputWithContext(context.Background())
}

func (i *InstanceFleetConfig) ToInstanceFleetConfigOutputWithContext(ctx context.Context) InstanceFleetConfigOutput {
	return pulumi.ToOutputWithContext(ctx, i).(InstanceFleetConfigOutput)
}

type InstanceFleetConfigOutput struct{ *pulumi.OutputState }

func (InstanceFleetConfigOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*InstanceFleetConfig)(nil))
}

func (o InstanceFleetConfigOutput) ToInstanceFleetConfigOutput() InstanceFleetConfigOutput {
	return o
}

func (o InstanceFleetConfigOutput) ToInstanceFleetConfigOutputWithContext(ctx context.Context) InstanceFleetConfigOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(InstanceFleetConfigOutput{})
}