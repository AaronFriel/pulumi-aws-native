// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package sns

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::SNS::Topic
//
// Deprecated: Topic is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type Topic struct {
	pulumi.CustomResourceState

	ContentBasedDeduplication pulumi.BoolPtrOutput         `pulumi:"contentBasedDeduplication"`
	DisplayName               pulumi.StringPtrOutput       `pulumi:"displayName"`
	FifoTopic                 pulumi.BoolPtrOutput         `pulumi:"fifoTopic"`
	KmsMasterKeyId            pulumi.StringPtrOutput       `pulumi:"kmsMasterKeyId"`
	Subscription              TopicSubscriptionArrayOutput `pulumi:"subscription"`
	Tags                      TopicTagArrayOutput          `pulumi:"tags"`
	TopicName                 pulumi.StringPtrOutput       `pulumi:"topicName"`
}

// NewTopic registers a new resource with the given unique name, arguments, and options.
func NewTopic(ctx *pulumi.Context,
	name string, args *TopicArgs, opts ...pulumi.ResourceOption) (*Topic, error) {
	if args == nil {
		args = &TopicArgs{}
	}

	var resource Topic
	err := ctx.RegisterResource("aws-native:sns:Topic", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetTopic gets an existing Topic resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTopic(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TopicState, opts ...pulumi.ResourceOption) (*Topic, error) {
	var resource Topic
	err := ctx.ReadResource("aws-native:sns:Topic", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Topic resources.
type topicState struct {
}

type TopicState struct {
}

func (TopicState) ElementType() reflect.Type {
	return reflect.TypeOf((*topicState)(nil)).Elem()
}

type topicArgs struct {
	ContentBasedDeduplication *bool               `pulumi:"contentBasedDeduplication"`
	DisplayName               *string             `pulumi:"displayName"`
	FifoTopic                 *bool               `pulumi:"fifoTopic"`
	KmsMasterKeyId            *string             `pulumi:"kmsMasterKeyId"`
	Subscription              []TopicSubscription `pulumi:"subscription"`
	Tags                      []TopicTag          `pulumi:"tags"`
	TopicName                 *string             `pulumi:"topicName"`
}

// The set of arguments for constructing a Topic resource.
type TopicArgs struct {
	ContentBasedDeduplication pulumi.BoolPtrInput
	DisplayName               pulumi.StringPtrInput
	FifoTopic                 pulumi.BoolPtrInput
	KmsMasterKeyId            pulumi.StringPtrInput
	Subscription              TopicSubscriptionArrayInput
	Tags                      TopicTagArrayInput
	TopicName                 pulumi.StringPtrInput
}

func (TopicArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*topicArgs)(nil)).Elem()
}

type TopicInput interface {
	pulumi.Input

	ToTopicOutput() TopicOutput
	ToTopicOutputWithContext(ctx context.Context) TopicOutput
}

func (*Topic) ElementType() reflect.Type {
	return reflect.TypeOf((*Topic)(nil))
}

func (i *Topic) ToTopicOutput() TopicOutput {
	return i.ToTopicOutputWithContext(context.Background())
}

func (i *Topic) ToTopicOutputWithContext(ctx context.Context) TopicOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TopicOutput)
}

type TopicOutput struct{ *pulumi.OutputState }

func (TopicOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Topic)(nil))
}

func (o TopicOutput) ToTopicOutput() TopicOutput {
	return o
}

func (o TopicOutput) ToTopicOutputWithContext(ctx context.Context) TopicOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*TopicInput)(nil)).Elem(), &Topic{})
	pulumi.RegisterOutputType(TopicOutput{})
}
