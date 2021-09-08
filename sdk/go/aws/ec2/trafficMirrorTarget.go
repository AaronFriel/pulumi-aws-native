// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ec2

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi-aws-native/sdk/go/aws"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrortarget.html
type TrafficMirrorTarget struct {
	pulumi.CustomResourceState

	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrortarget.html#cfn-ec2-trafficmirrortarget-description
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrortarget.html#cfn-ec2-trafficmirrortarget-networkinterfaceid
	NetworkInterfaceId pulumi.StringPtrOutput `pulumi:"networkInterfaceId"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrortarget.html#cfn-ec2-trafficmirrortarget-networkloadbalancerarn
	NetworkLoadBalancerArn pulumi.StringPtrOutput `pulumi:"networkLoadBalancerArn"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrortarget.html#cfn-ec2-trafficmirrortarget-tags
	Tags aws.TagArrayOutput `pulumi:"tags"`
}

// NewTrafficMirrorTarget registers a new resource with the given unique name, arguments, and options.
func NewTrafficMirrorTarget(ctx *pulumi.Context,
	name string, args *TrafficMirrorTargetArgs, opts ...pulumi.ResourceOption) (*TrafficMirrorTarget, error) {
	if args == nil {
		args = &TrafficMirrorTargetArgs{}
	}

	var resource TrafficMirrorTarget
	err := ctx.RegisterResource("aws-native:ec2:TrafficMirrorTarget", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetTrafficMirrorTarget gets an existing TrafficMirrorTarget resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTrafficMirrorTarget(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TrafficMirrorTargetState, opts ...pulumi.ResourceOption) (*TrafficMirrorTarget, error) {
	var resource TrafficMirrorTarget
	err := ctx.ReadResource("aws-native:ec2:TrafficMirrorTarget", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering TrafficMirrorTarget resources.
type trafficMirrorTargetState struct {
}

type TrafficMirrorTargetState struct {
}

func (TrafficMirrorTargetState) ElementType() reflect.Type {
	return reflect.TypeOf((*trafficMirrorTargetState)(nil)).Elem()
}

type trafficMirrorTargetArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrortarget.html#cfn-ec2-trafficmirrortarget-description
	Description *string `pulumi:"description"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrortarget.html#cfn-ec2-trafficmirrortarget-networkinterfaceid
	NetworkInterfaceId *string `pulumi:"networkInterfaceId"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrortarget.html#cfn-ec2-trafficmirrortarget-networkloadbalancerarn
	NetworkLoadBalancerArn *string `pulumi:"networkLoadBalancerArn"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrortarget.html#cfn-ec2-trafficmirrortarget-tags
	Tags []aws.Tag `pulumi:"tags"`
}

// The set of arguments for constructing a TrafficMirrorTarget resource.
type TrafficMirrorTargetArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrortarget.html#cfn-ec2-trafficmirrortarget-description
	Description pulumi.StringPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrortarget.html#cfn-ec2-trafficmirrortarget-networkinterfaceid
	NetworkInterfaceId pulumi.StringPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrortarget.html#cfn-ec2-trafficmirrortarget-networkloadbalancerarn
	NetworkLoadBalancerArn pulumi.StringPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrortarget.html#cfn-ec2-trafficmirrortarget-tags
	Tags aws.TagArrayInput
}

func (TrafficMirrorTargetArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*trafficMirrorTargetArgs)(nil)).Elem()
}

type TrafficMirrorTargetInput interface {
	pulumi.Input

	ToTrafficMirrorTargetOutput() TrafficMirrorTargetOutput
	ToTrafficMirrorTargetOutputWithContext(ctx context.Context) TrafficMirrorTargetOutput
}

func (*TrafficMirrorTarget) ElementType() reflect.Type {
	return reflect.TypeOf((*TrafficMirrorTarget)(nil))
}

func (i *TrafficMirrorTarget) ToTrafficMirrorTargetOutput() TrafficMirrorTargetOutput {
	return i.ToTrafficMirrorTargetOutputWithContext(context.Background())
}

func (i *TrafficMirrorTarget) ToTrafficMirrorTargetOutputWithContext(ctx context.Context) TrafficMirrorTargetOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TrafficMirrorTargetOutput)
}

type TrafficMirrorTargetOutput struct{ *pulumi.OutputState }

func (TrafficMirrorTargetOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*TrafficMirrorTarget)(nil))
}

func (o TrafficMirrorTargetOutput) ToTrafficMirrorTargetOutput() TrafficMirrorTargetOutput {
	return o
}

func (o TrafficMirrorTargetOutput) ToTrafficMirrorTargetOutputWithContext(ctx context.Context) TrafficMirrorTargetOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(TrafficMirrorTargetOutput{})
}