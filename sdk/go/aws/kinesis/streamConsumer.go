// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package kinesis

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::Kinesis::StreamConsumer
//
// Deprecated: StreamConsumer is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type StreamConsumer struct {
	pulumi.CustomResourceState

	ConsumerARN               pulumi.StringOutput `pulumi:"consumerARN"`
	ConsumerCreationTimestamp pulumi.StringOutput `pulumi:"consumerCreationTimestamp"`
	ConsumerName              pulumi.StringOutput `pulumi:"consumerName"`
	ConsumerStatus            pulumi.StringOutput `pulumi:"consumerStatus"`
	StreamARN                 pulumi.StringOutput `pulumi:"streamARN"`
}

// NewStreamConsumer registers a new resource with the given unique name, arguments, and options.
func NewStreamConsumer(ctx *pulumi.Context,
	name string, args *StreamConsumerArgs, opts ...pulumi.ResourceOption) (*StreamConsumer, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ConsumerName == nil {
		return nil, errors.New("invalid value for required argument 'ConsumerName'")
	}
	if args.StreamARN == nil {
		return nil, errors.New("invalid value for required argument 'StreamARN'")
	}
	var resource StreamConsumer
	err := ctx.RegisterResource("aws-native:kinesis:StreamConsumer", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetStreamConsumer gets an existing StreamConsumer resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetStreamConsumer(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *StreamConsumerState, opts ...pulumi.ResourceOption) (*StreamConsumer, error) {
	var resource StreamConsumer
	err := ctx.ReadResource("aws-native:kinesis:StreamConsumer", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering StreamConsumer resources.
type streamConsumerState struct {
}

type StreamConsumerState struct {
}

func (StreamConsumerState) ElementType() reflect.Type {
	return reflect.TypeOf((*streamConsumerState)(nil)).Elem()
}

type streamConsumerArgs struct {
	ConsumerName string `pulumi:"consumerName"`
	StreamARN    string `pulumi:"streamARN"`
}

// The set of arguments for constructing a StreamConsumer resource.
type StreamConsumerArgs struct {
	ConsumerName pulumi.StringInput
	StreamARN    pulumi.StringInput
}

func (StreamConsumerArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*streamConsumerArgs)(nil)).Elem()
}

type StreamConsumerInput interface {
	pulumi.Input

	ToStreamConsumerOutput() StreamConsumerOutput
	ToStreamConsumerOutputWithContext(ctx context.Context) StreamConsumerOutput
}

func (*StreamConsumer) ElementType() reflect.Type {
	return reflect.TypeOf((*StreamConsumer)(nil))
}

func (i *StreamConsumer) ToStreamConsumerOutput() StreamConsumerOutput {
	return i.ToStreamConsumerOutputWithContext(context.Background())
}

func (i *StreamConsumer) ToStreamConsumerOutputWithContext(ctx context.Context) StreamConsumerOutput {
	return pulumi.ToOutputWithContext(ctx, i).(StreamConsumerOutput)
}

type StreamConsumerOutput struct{ *pulumi.OutputState }

func (StreamConsumerOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*StreamConsumer)(nil))
}

func (o StreamConsumerOutput) ToStreamConsumerOutput() StreamConsumerOutput {
	return o
}

func (o StreamConsumerOutput) ToStreamConsumerOutputWithContext(ctx context.Context) StreamConsumerOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(StreamConsumerOutput{})
}
