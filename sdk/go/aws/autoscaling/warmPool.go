// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package autoscaling

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-warmpool.html
type WarmPool struct {
	pulumi.CustomResourceState

	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-warmpool.html#cfn-autoscaling-warmpool-autoscalinggroupname
	AutoScalingGroupName pulumi.StringOutput `pulumi:"autoScalingGroupName"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-warmpool.html#cfn-autoscaling-warmpool-maxgrouppreparedcapacity
	MaxGroupPreparedCapacity pulumi.IntPtrOutput `pulumi:"maxGroupPreparedCapacity"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-warmpool.html#cfn-autoscaling-warmpool-minsize
	MinSize pulumi.IntPtrOutput `pulumi:"minSize"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-warmpool.html#cfn-autoscaling-warmpool-poolstate
	PoolState pulumi.StringPtrOutput `pulumi:"poolState"`
}

// NewWarmPool registers a new resource with the given unique name, arguments, and options.
func NewWarmPool(ctx *pulumi.Context,
	name string, args *WarmPoolArgs, opts ...pulumi.ResourceOption) (*WarmPool, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AutoScalingGroupName == nil {
		return nil, errors.New("invalid value for required argument 'AutoScalingGroupName'")
	}
	var resource WarmPool
	err := ctx.RegisterResource("aws-native:AutoScaling:WarmPool", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWarmPool gets an existing WarmPool resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWarmPool(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WarmPoolState, opts ...pulumi.ResourceOption) (*WarmPool, error) {
	var resource WarmPool
	err := ctx.ReadResource("aws-native:AutoScaling:WarmPool", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering WarmPool resources.
type warmPoolState struct {
}

type WarmPoolState struct {
}

func (WarmPoolState) ElementType() reflect.Type {
	return reflect.TypeOf((*warmPoolState)(nil)).Elem()
}

type warmPoolArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-warmpool.html#cfn-autoscaling-warmpool-autoscalinggroupname
	AutoScalingGroupName string `pulumi:"autoScalingGroupName"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-warmpool.html#cfn-autoscaling-warmpool-maxgrouppreparedcapacity
	MaxGroupPreparedCapacity *int `pulumi:"maxGroupPreparedCapacity"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-warmpool.html#cfn-autoscaling-warmpool-minsize
	MinSize *int `pulumi:"minSize"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-warmpool.html#cfn-autoscaling-warmpool-poolstate
	PoolState *string `pulumi:"poolState"`
}

// The set of arguments for constructing a WarmPool resource.
type WarmPoolArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-warmpool.html#cfn-autoscaling-warmpool-autoscalinggroupname
	AutoScalingGroupName pulumi.StringInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-warmpool.html#cfn-autoscaling-warmpool-maxgrouppreparedcapacity
	MaxGroupPreparedCapacity pulumi.IntPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-warmpool.html#cfn-autoscaling-warmpool-minsize
	MinSize pulumi.IntPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-warmpool.html#cfn-autoscaling-warmpool-poolstate
	PoolState pulumi.StringPtrInput
}

func (WarmPoolArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*warmPoolArgs)(nil)).Elem()
}

type WarmPoolInput interface {
	pulumi.Input

	ToWarmPoolOutput() WarmPoolOutput
	ToWarmPoolOutputWithContext(ctx context.Context) WarmPoolOutput
}

func (*WarmPool) ElementType() reflect.Type {
	return reflect.TypeOf((*WarmPool)(nil))
}

func (i *WarmPool) ToWarmPoolOutput() WarmPoolOutput {
	return i.ToWarmPoolOutputWithContext(context.Background())
}

func (i *WarmPool) ToWarmPoolOutputWithContext(ctx context.Context) WarmPoolOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WarmPoolOutput)
}

type WarmPoolOutput struct{ *pulumi.OutputState }

func (WarmPoolOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*WarmPool)(nil))
}

func (o WarmPoolOutput) ToWarmPoolOutput() WarmPoolOutput {
	return o
}

func (o WarmPoolOutput) ToWarmPoolOutputWithContext(ctx context.Context) WarmPoolOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(WarmPoolOutput{})
}