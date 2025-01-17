// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ec2

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::EC2::TrafficMirrorTarget
//
// Deprecated: TrafficMirrorTarget is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type TrafficMirrorTarget struct {
	pulumi.CustomResourceState

	Description            pulumi.StringPtrOutput            `pulumi:"description"`
	NetworkInterfaceId     pulumi.StringPtrOutput            `pulumi:"networkInterfaceId"`
	NetworkLoadBalancerArn pulumi.StringPtrOutput            `pulumi:"networkLoadBalancerArn"`
	Tags                   TrafficMirrorTargetTagArrayOutput `pulumi:"tags"`
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
	Description            *string                  `pulumi:"description"`
	NetworkInterfaceId     *string                  `pulumi:"networkInterfaceId"`
	NetworkLoadBalancerArn *string                  `pulumi:"networkLoadBalancerArn"`
	Tags                   []TrafficMirrorTargetTag `pulumi:"tags"`
}

// The set of arguments for constructing a TrafficMirrorTarget resource.
type TrafficMirrorTargetArgs struct {
	Description            pulumi.StringPtrInput
	NetworkInterfaceId     pulumi.StringPtrInput
	NetworkLoadBalancerArn pulumi.StringPtrInput
	Tags                   TrafficMirrorTargetTagArrayInput
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
	pulumi.RegisterInputType(reflect.TypeOf((*TrafficMirrorTargetInput)(nil)).Elem(), &TrafficMirrorTarget{})
	pulumi.RegisterOutputType(TrafficMirrorTargetOutput{})
}
