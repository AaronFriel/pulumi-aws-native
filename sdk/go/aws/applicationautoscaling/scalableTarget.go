// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package applicationautoscaling

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html
type ScalableTarget struct {
	pulumi.CustomResourceState

	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-maxcapacity
	MaxCapacity pulumi.IntOutput `pulumi:"maxCapacity"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-mincapacity
	MinCapacity pulumi.IntOutput `pulumi:"minCapacity"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-resourceid
	ResourceId pulumi.StringOutput `pulumi:"resourceId"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-rolearn
	RoleARN pulumi.StringOutput `pulumi:"roleARN"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-scalabledimension
	ScalableDimension pulumi.StringOutput `pulumi:"scalableDimension"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-scheduledactions
	ScheduledActions ScalableTargetScheduledActionArrayOutput `pulumi:"scheduledActions"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-servicenamespace
	ServiceNamespace pulumi.StringOutput `pulumi:"serviceNamespace"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-suspendedstate
	SuspendedState ScalableTargetSuspendedStatePtrOutput `pulumi:"suspendedState"`
}

// NewScalableTarget registers a new resource with the given unique name, arguments, and options.
func NewScalableTarget(ctx *pulumi.Context,
	name string, args *ScalableTargetArgs, opts ...pulumi.ResourceOption) (*ScalableTarget, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.MaxCapacity == nil {
		return nil, errors.New("invalid value for required argument 'MaxCapacity'")
	}
	if args.MinCapacity == nil {
		return nil, errors.New("invalid value for required argument 'MinCapacity'")
	}
	if args.ResourceId == nil {
		return nil, errors.New("invalid value for required argument 'ResourceId'")
	}
	if args.RoleARN == nil {
		return nil, errors.New("invalid value for required argument 'RoleARN'")
	}
	if args.ScalableDimension == nil {
		return nil, errors.New("invalid value for required argument 'ScalableDimension'")
	}
	if args.ServiceNamespace == nil {
		return nil, errors.New("invalid value for required argument 'ServiceNamespace'")
	}
	var resource ScalableTarget
	err := ctx.RegisterResource("aws-native:applicationautoscaling:ScalableTarget", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetScalableTarget gets an existing ScalableTarget resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetScalableTarget(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ScalableTargetState, opts ...pulumi.ResourceOption) (*ScalableTarget, error) {
	var resource ScalableTarget
	err := ctx.ReadResource("aws-native:applicationautoscaling:ScalableTarget", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ScalableTarget resources.
type scalableTargetState struct {
}

type ScalableTargetState struct {
}

func (ScalableTargetState) ElementType() reflect.Type {
	return reflect.TypeOf((*scalableTargetState)(nil)).Elem()
}

type scalableTargetArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-maxcapacity
	MaxCapacity int `pulumi:"maxCapacity"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-mincapacity
	MinCapacity int `pulumi:"minCapacity"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-resourceid
	ResourceId string `pulumi:"resourceId"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-rolearn
	RoleARN string `pulumi:"roleARN"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-scalabledimension
	ScalableDimension string `pulumi:"scalableDimension"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-scheduledactions
	ScheduledActions []ScalableTargetScheduledAction `pulumi:"scheduledActions"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-servicenamespace
	ServiceNamespace string `pulumi:"serviceNamespace"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-suspendedstate
	SuspendedState *ScalableTargetSuspendedState `pulumi:"suspendedState"`
}

// The set of arguments for constructing a ScalableTarget resource.
type ScalableTargetArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-maxcapacity
	MaxCapacity pulumi.IntInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-mincapacity
	MinCapacity pulumi.IntInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-resourceid
	ResourceId pulumi.StringInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-rolearn
	RoleARN pulumi.StringInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-scalabledimension
	ScalableDimension pulumi.StringInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-scheduledactions
	ScheduledActions ScalableTargetScheduledActionArrayInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-servicenamespace
	ServiceNamespace pulumi.StringInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-suspendedstate
	SuspendedState ScalableTargetSuspendedStatePtrInput
}

func (ScalableTargetArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*scalableTargetArgs)(nil)).Elem()
}

type ScalableTargetInput interface {
	pulumi.Input

	ToScalableTargetOutput() ScalableTargetOutput
	ToScalableTargetOutputWithContext(ctx context.Context) ScalableTargetOutput
}

func (*ScalableTarget) ElementType() reflect.Type {
	return reflect.TypeOf((*ScalableTarget)(nil))
}

func (i *ScalableTarget) ToScalableTargetOutput() ScalableTargetOutput {
	return i.ToScalableTargetOutputWithContext(context.Background())
}

func (i *ScalableTarget) ToScalableTargetOutputWithContext(ctx context.Context) ScalableTargetOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ScalableTargetOutput)
}

type ScalableTargetOutput struct{ *pulumi.OutputState }

func (ScalableTargetOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ScalableTarget)(nil))
}

func (o ScalableTargetOutput) ToScalableTargetOutput() ScalableTargetOutput {
	return o
}

func (o ScalableTargetOutput) ToScalableTargetOutputWithContext(ctx context.Context) ScalableTargetOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ScalableTargetOutput{})
}