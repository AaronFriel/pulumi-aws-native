// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package mediapackage

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource schema for AWS::MediaPackage::Channel
type Channel struct {
	pulumi.CustomResourceState

	// The Amazon Resource Name (ARN) assigned to the Channel.
	Arn pulumi.StringOutput `pulumi:"arn"`
	// A short text description of the Channel.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The configuration parameters for egress access logging.
	EgressAccessLogs ChannelLogConfigurationPtrOutput `pulumi:"egressAccessLogs"`
	// A short text description of the Channel.
	HlsIngest ChannelHlsIngestOutput `pulumi:"hlsIngest"`
	// The configuration parameters for egress access logging.
	IngressAccessLogs ChannelLogConfigurationPtrOutput `pulumi:"ingressAccessLogs"`
	// A collection of tags associated with a resource
	Tags ChannelTagArrayOutput `pulumi:"tags"`
}

// NewChannel registers a new resource with the given unique name, arguments, and options.
func NewChannel(ctx *pulumi.Context,
	name string, args *ChannelArgs, opts ...pulumi.ResourceOption) (*Channel, error) {
	if args == nil {
		args = &ChannelArgs{}
	}

	var resource Channel
	err := ctx.RegisterResource("aws-native:mediapackage:Channel", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetChannel gets an existing Channel resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetChannel(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ChannelState, opts ...pulumi.ResourceOption) (*Channel, error) {
	var resource Channel
	err := ctx.ReadResource("aws-native:mediapackage:Channel", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Channel resources.
type channelState struct {
}

type ChannelState struct {
}

func (ChannelState) ElementType() reflect.Type {
	return reflect.TypeOf((*channelState)(nil)).Elem()
}

type channelArgs struct {
	// A short text description of the Channel.
	Description *string `pulumi:"description"`
	// The configuration parameters for egress access logging.
	EgressAccessLogs *ChannelLogConfiguration `pulumi:"egressAccessLogs"`
	// The configuration parameters for egress access logging.
	IngressAccessLogs *ChannelLogConfiguration `pulumi:"ingressAccessLogs"`
	// A collection of tags associated with a resource
	Tags []ChannelTag `pulumi:"tags"`
}

// The set of arguments for constructing a Channel resource.
type ChannelArgs struct {
	// A short text description of the Channel.
	Description pulumi.StringPtrInput
	// The configuration parameters for egress access logging.
	EgressAccessLogs ChannelLogConfigurationPtrInput
	// The configuration parameters for egress access logging.
	IngressAccessLogs ChannelLogConfigurationPtrInput
	// A collection of tags associated with a resource
	Tags ChannelTagArrayInput
}

func (ChannelArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*channelArgs)(nil)).Elem()
}

type ChannelInput interface {
	pulumi.Input

	ToChannelOutput() ChannelOutput
	ToChannelOutputWithContext(ctx context.Context) ChannelOutput
}

func (*Channel) ElementType() reflect.Type {
	return reflect.TypeOf((*Channel)(nil))
}

func (i *Channel) ToChannelOutput() ChannelOutput {
	return i.ToChannelOutputWithContext(context.Background())
}

func (i *Channel) ToChannelOutputWithContext(ctx context.Context) ChannelOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ChannelOutput)
}

type ChannelOutput struct{ *pulumi.OutputState }

func (ChannelOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Channel)(nil))
}

func (o ChannelOutput) ToChannelOutput() ChannelOutput {
	return o
}

func (o ChannelOutput) ToChannelOutputWithContext(ctx context.Context) ChannelOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ChannelOutput{})
}
