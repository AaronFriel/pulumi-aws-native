// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ec2

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi-aws-native/sdk/go/aws"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html
type TrafficMirrorSession struct {
	pulumi.CustomResourceState

	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html#cfn-ec2-trafficmirrorsession-description
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html#cfn-ec2-trafficmirrorsession-networkinterfaceid
	NetworkInterfaceId pulumi.StringOutput `pulumi:"networkInterfaceId"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html#cfn-ec2-trafficmirrorsession-packetlength
	PacketLength pulumi.IntPtrOutput `pulumi:"packetLength"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html#cfn-ec2-trafficmirrorsession-sessionnumber
	SessionNumber pulumi.IntOutput `pulumi:"sessionNumber"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html#cfn-ec2-trafficmirrorsession-tags
	Tags aws.TagArrayOutput `pulumi:"tags"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html#cfn-ec2-trafficmirrorsession-trafficmirrorfilterid
	TrafficMirrorFilterId pulumi.StringOutput `pulumi:"trafficMirrorFilterId"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html#cfn-ec2-trafficmirrorsession-trafficmirrortargetid
	TrafficMirrorTargetId pulumi.StringOutput `pulumi:"trafficMirrorTargetId"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html#cfn-ec2-trafficmirrorsession-virtualnetworkid
	VirtualNetworkId pulumi.IntPtrOutput `pulumi:"virtualNetworkId"`
}

// NewTrafficMirrorSession registers a new resource with the given unique name, arguments, and options.
func NewTrafficMirrorSession(ctx *pulumi.Context,
	name string, args *TrafficMirrorSessionArgs, opts ...pulumi.ResourceOption) (*TrafficMirrorSession, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.NetworkInterfaceId == nil {
		return nil, errors.New("invalid value for required argument 'NetworkInterfaceId'")
	}
	if args.SessionNumber == nil {
		return nil, errors.New("invalid value for required argument 'SessionNumber'")
	}
	if args.TrafficMirrorFilterId == nil {
		return nil, errors.New("invalid value for required argument 'TrafficMirrorFilterId'")
	}
	if args.TrafficMirrorTargetId == nil {
		return nil, errors.New("invalid value for required argument 'TrafficMirrorTargetId'")
	}
	var resource TrafficMirrorSession
	err := ctx.RegisterResource("aws-native:ec2:TrafficMirrorSession", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetTrafficMirrorSession gets an existing TrafficMirrorSession resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTrafficMirrorSession(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TrafficMirrorSessionState, opts ...pulumi.ResourceOption) (*TrafficMirrorSession, error) {
	var resource TrafficMirrorSession
	err := ctx.ReadResource("aws-native:ec2:TrafficMirrorSession", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering TrafficMirrorSession resources.
type trafficMirrorSessionState struct {
}

type TrafficMirrorSessionState struct {
}

func (TrafficMirrorSessionState) ElementType() reflect.Type {
	return reflect.TypeOf((*trafficMirrorSessionState)(nil)).Elem()
}

type trafficMirrorSessionArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html#cfn-ec2-trafficmirrorsession-description
	Description *string `pulumi:"description"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html#cfn-ec2-trafficmirrorsession-networkinterfaceid
	NetworkInterfaceId string `pulumi:"networkInterfaceId"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html#cfn-ec2-trafficmirrorsession-packetlength
	PacketLength *int `pulumi:"packetLength"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html#cfn-ec2-trafficmirrorsession-sessionnumber
	SessionNumber int `pulumi:"sessionNumber"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html#cfn-ec2-trafficmirrorsession-tags
	Tags []aws.Tag `pulumi:"tags"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html#cfn-ec2-trafficmirrorsession-trafficmirrorfilterid
	TrafficMirrorFilterId string `pulumi:"trafficMirrorFilterId"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html#cfn-ec2-trafficmirrorsession-trafficmirrortargetid
	TrafficMirrorTargetId string `pulumi:"trafficMirrorTargetId"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html#cfn-ec2-trafficmirrorsession-virtualnetworkid
	VirtualNetworkId *int `pulumi:"virtualNetworkId"`
}

// The set of arguments for constructing a TrafficMirrorSession resource.
type TrafficMirrorSessionArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html#cfn-ec2-trafficmirrorsession-description
	Description pulumi.StringPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html#cfn-ec2-trafficmirrorsession-networkinterfaceid
	NetworkInterfaceId pulumi.StringInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html#cfn-ec2-trafficmirrorsession-packetlength
	PacketLength pulumi.IntPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html#cfn-ec2-trafficmirrorsession-sessionnumber
	SessionNumber pulumi.IntInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html#cfn-ec2-trafficmirrorsession-tags
	Tags aws.TagArrayInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html#cfn-ec2-trafficmirrorsession-trafficmirrorfilterid
	TrafficMirrorFilterId pulumi.StringInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html#cfn-ec2-trafficmirrorsession-trafficmirrortargetid
	TrafficMirrorTargetId pulumi.StringInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html#cfn-ec2-trafficmirrorsession-virtualnetworkid
	VirtualNetworkId pulumi.IntPtrInput
}

func (TrafficMirrorSessionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*trafficMirrorSessionArgs)(nil)).Elem()
}

type TrafficMirrorSessionInput interface {
	pulumi.Input

	ToTrafficMirrorSessionOutput() TrafficMirrorSessionOutput
	ToTrafficMirrorSessionOutputWithContext(ctx context.Context) TrafficMirrorSessionOutput
}

func (*TrafficMirrorSession) ElementType() reflect.Type {
	return reflect.TypeOf((*TrafficMirrorSession)(nil))
}

func (i *TrafficMirrorSession) ToTrafficMirrorSessionOutput() TrafficMirrorSessionOutput {
	return i.ToTrafficMirrorSessionOutputWithContext(context.Background())
}

func (i *TrafficMirrorSession) ToTrafficMirrorSessionOutputWithContext(ctx context.Context) TrafficMirrorSessionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TrafficMirrorSessionOutput)
}

type TrafficMirrorSessionOutput struct{ *pulumi.OutputState }

func (TrafficMirrorSessionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*TrafficMirrorSession)(nil))
}

func (o TrafficMirrorSessionOutput) ToTrafficMirrorSessionOutput() TrafficMirrorSessionOutput {
	return o
}

func (o TrafficMirrorSessionOutput) ToTrafficMirrorSessionOutputWithContext(ctx context.Context) TrafficMirrorSessionOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(TrafficMirrorSessionOutput{})
}