// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package logs

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::Logs::SubscriptionFilter
//
// Deprecated: SubscriptionFilter is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.
type SubscriptionFilter struct {
	pulumi.CustomResourceState

	DestinationArn pulumi.StringOutput    `pulumi:"destinationArn"`
	FilterPattern  pulumi.StringOutput    `pulumi:"filterPattern"`
	LogGroupName   pulumi.StringOutput    `pulumi:"logGroupName"`
	RoleArn        pulumi.StringPtrOutput `pulumi:"roleArn"`
}

// NewSubscriptionFilter registers a new resource with the given unique name, arguments, and options.
func NewSubscriptionFilter(ctx *pulumi.Context,
	name string, args *SubscriptionFilterArgs, opts ...pulumi.ResourceOption) (*SubscriptionFilter, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DestinationArn == nil {
		return nil, errors.New("invalid value for required argument 'DestinationArn'")
	}
	if args.FilterPattern == nil {
		return nil, errors.New("invalid value for required argument 'FilterPattern'")
	}
	if args.LogGroupName == nil {
		return nil, errors.New("invalid value for required argument 'LogGroupName'")
	}
	var resource SubscriptionFilter
	err := ctx.RegisterResource("aws-native:logs:SubscriptionFilter", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSubscriptionFilter gets an existing SubscriptionFilter resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSubscriptionFilter(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SubscriptionFilterState, opts ...pulumi.ResourceOption) (*SubscriptionFilter, error) {
	var resource SubscriptionFilter
	err := ctx.ReadResource("aws-native:logs:SubscriptionFilter", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SubscriptionFilter resources.
type subscriptionFilterState struct {
}

type SubscriptionFilterState struct {
}

func (SubscriptionFilterState) ElementType() reflect.Type {
	return reflect.TypeOf((*subscriptionFilterState)(nil)).Elem()
}

type subscriptionFilterArgs struct {
	DestinationArn string  `pulumi:"destinationArn"`
	FilterPattern  string  `pulumi:"filterPattern"`
	LogGroupName   string  `pulumi:"logGroupName"`
	RoleArn        *string `pulumi:"roleArn"`
}

// The set of arguments for constructing a SubscriptionFilter resource.
type SubscriptionFilterArgs struct {
	DestinationArn pulumi.StringInput
	FilterPattern  pulumi.StringInput
	LogGroupName   pulumi.StringInput
	RoleArn        pulumi.StringPtrInput
}

func (SubscriptionFilterArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*subscriptionFilterArgs)(nil)).Elem()
}

type SubscriptionFilterInput interface {
	pulumi.Input

	ToSubscriptionFilterOutput() SubscriptionFilterOutput
	ToSubscriptionFilterOutputWithContext(ctx context.Context) SubscriptionFilterOutput
}

func (*SubscriptionFilter) ElementType() reflect.Type {
	return reflect.TypeOf((*SubscriptionFilter)(nil))
}

func (i *SubscriptionFilter) ToSubscriptionFilterOutput() SubscriptionFilterOutput {
	return i.ToSubscriptionFilterOutputWithContext(context.Background())
}

func (i *SubscriptionFilter) ToSubscriptionFilterOutputWithContext(ctx context.Context) SubscriptionFilterOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SubscriptionFilterOutput)
}

type SubscriptionFilterOutput struct{ *pulumi.OutputState }

func (SubscriptionFilterOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SubscriptionFilter)(nil))
}

func (o SubscriptionFilterOutput) ToSubscriptionFilterOutput() SubscriptionFilterOutput {
	return o
}

func (o SubscriptionFilterOutput) ToSubscriptionFilterOutputWithContext(ctx context.Context) SubscriptionFilterOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(SubscriptionFilterOutput{})
}