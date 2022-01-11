// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package sns

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::SNS::Subscription
//
// Deprecated: Subscription is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type Subscription struct {
	pulumi.CustomResourceState

	DeliveryPolicy      pulumi.AnyOutput       `pulumi:"deliveryPolicy"`
	Endpoint            pulumi.StringPtrOutput `pulumi:"endpoint"`
	FilterPolicy        pulumi.AnyOutput       `pulumi:"filterPolicy"`
	Protocol            pulumi.StringOutput    `pulumi:"protocol"`
	RawMessageDelivery  pulumi.BoolPtrOutput   `pulumi:"rawMessageDelivery"`
	RedrivePolicy       pulumi.AnyOutput       `pulumi:"redrivePolicy"`
	Region              pulumi.StringPtrOutput `pulumi:"region"`
	SubscriptionRoleArn pulumi.StringPtrOutput `pulumi:"subscriptionRoleArn"`
	TopicArn            pulumi.StringOutput    `pulumi:"topicArn"`
}

// NewSubscription registers a new resource with the given unique name, arguments, and options.
func NewSubscription(ctx *pulumi.Context,
	name string, args *SubscriptionArgs, opts ...pulumi.ResourceOption) (*Subscription, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Protocol == nil {
		return nil, errors.New("invalid value for required argument 'Protocol'")
	}
	if args.TopicArn == nil {
		return nil, errors.New("invalid value for required argument 'TopicArn'")
	}
	var resource Subscription
	err := ctx.RegisterResource("aws-native:sns:Subscription", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSubscription gets an existing Subscription resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSubscription(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SubscriptionState, opts ...pulumi.ResourceOption) (*Subscription, error) {
	var resource Subscription
	err := ctx.ReadResource("aws-native:sns:Subscription", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Subscription resources.
type subscriptionState struct {
}

type SubscriptionState struct {
}

func (SubscriptionState) ElementType() reflect.Type {
	return reflect.TypeOf((*subscriptionState)(nil)).Elem()
}

type subscriptionArgs struct {
	DeliveryPolicy      interface{} `pulumi:"deliveryPolicy"`
	Endpoint            *string     `pulumi:"endpoint"`
	FilterPolicy        interface{} `pulumi:"filterPolicy"`
	Protocol            string      `pulumi:"protocol"`
	RawMessageDelivery  *bool       `pulumi:"rawMessageDelivery"`
	RedrivePolicy       interface{} `pulumi:"redrivePolicy"`
	Region              *string     `pulumi:"region"`
	SubscriptionRoleArn *string     `pulumi:"subscriptionRoleArn"`
	TopicArn            string      `pulumi:"topicArn"`
}

// The set of arguments for constructing a Subscription resource.
type SubscriptionArgs struct {
	DeliveryPolicy      pulumi.Input
	Endpoint            pulumi.StringPtrInput
	FilterPolicy        pulumi.Input
	Protocol            pulumi.StringInput
	RawMessageDelivery  pulumi.BoolPtrInput
	RedrivePolicy       pulumi.Input
	Region              pulumi.StringPtrInput
	SubscriptionRoleArn pulumi.StringPtrInput
	TopicArn            pulumi.StringInput
}

func (SubscriptionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*subscriptionArgs)(nil)).Elem()
}

type SubscriptionInput interface {
	pulumi.Input

	ToSubscriptionOutput() SubscriptionOutput
	ToSubscriptionOutputWithContext(ctx context.Context) SubscriptionOutput
}

func (*Subscription) ElementType() reflect.Type {
	return reflect.TypeOf((*Subscription)(nil))
}

func (i *Subscription) ToSubscriptionOutput() SubscriptionOutput {
	return i.ToSubscriptionOutputWithContext(context.Background())
}

func (i *Subscription) ToSubscriptionOutputWithContext(ctx context.Context) SubscriptionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SubscriptionOutput)
}

type SubscriptionOutput struct{ *pulumi.OutputState }

func (SubscriptionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Subscription)(nil))
}

func (o SubscriptionOutput) ToSubscriptionOutput() SubscriptionOutput {
	return o
}

func (o SubscriptionOutput) ToSubscriptionOutputWithContext(ctx context.Context) SubscriptionOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*SubscriptionInput)(nil)).Elem(), &Subscription{})
	pulumi.RegisterOutputType(SubscriptionOutput{})
}
