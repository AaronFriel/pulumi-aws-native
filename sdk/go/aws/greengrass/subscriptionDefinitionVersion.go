// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package greengrass

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::Greengrass::SubscriptionDefinitionVersion
//
// Deprecated: SubscriptionDefinitionVersion is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type SubscriptionDefinitionVersion struct {
	pulumi.CustomResourceState

	SubscriptionDefinitionId pulumi.StringOutput                                  `pulumi:"subscriptionDefinitionId"`
	Subscriptions            SubscriptionDefinitionVersionSubscriptionArrayOutput `pulumi:"subscriptions"`
}

// NewSubscriptionDefinitionVersion registers a new resource with the given unique name, arguments, and options.
func NewSubscriptionDefinitionVersion(ctx *pulumi.Context,
	name string, args *SubscriptionDefinitionVersionArgs, opts ...pulumi.ResourceOption) (*SubscriptionDefinitionVersion, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.SubscriptionDefinitionId == nil {
		return nil, errors.New("invalid value for required argument 'SubscriptionDefinitionId'")
	}
	if args.Subscriptions == nil {
		return nil, errors.New("invalid value for required argument 'Subscriptions'")
	}
	var resource SubscriptionDefinitionVersion
	err := ctx.RegisterResource("aws-native:greengrass:SubscriptionDefinitionVersion", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSubscriptionDefinitionVersion gets an existing SubscriptionDefinitionVersion resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSubscriptionDefinitionVersion(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SubscriptionDefinitionVersionState, opts ...pulumi.ResourceOption) (*SubscriptionDefinitionVersion, error) {
	var resource SubscriptionDefinitionVersion
	err := ctx.ReadResource("aws-native:greengrass:SubscriptionDefinitionVersion", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SubscriptionDefinitionVersion resources.
type subscriptionDefinitionVersionState struct {
}

type SubscriptionDefinitionVersionState struct {
}

func (SubscriptionDefinitionVersionState) ElementType() reflect.Type {
	return reflect.TypeOf((*subscriptionDefinitionVersionState)(nil)).Elem()
}

type subscriptionDefinitionVersionArgs struct {
	SubscriptionDefinitionId string                                      `pulumi:"subscriptionDefinitionId"`
	Subscriptions            []SubscriptionDefinitionVersionSubscription `pulumi:"subscriptions"`
}

// The set of arguments for constructing a SubscriptionDefinitionVersion resource.
type SubscriptionDefinitionVersionArgs struct {
	SubscriptionDefinitionId pulumi.StringInput
	Subscriptions            SubscriptionDefinitionVersionSubscriptionArrayInput
}

func (SubscriptionDefinitionVersionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*subscriptionDefinitionVersionArgs)(nil)).Elem()
}

type SubscriptionDefinitionVersionInput interface {
	pulumi.Input

	ToSubscriptionDefinitionVersionOutput() SubscriptionDefinitionVersionOutput
	ToSubscriptionDefinitionVersionOutputWithContext(ctx context.Context) SubscriptionDefinitionVersionOutput
}

func (*SubscriptionDefinitionVersion) ElementType() reflect.Type {
	return reflect.TypeOf((*SubscriptionDefinitionVersion)(nil))
}

func (i *SubscriptionDefinitionVersion) ToSubscriptionDefinitionVersionOutput() SubscriptionDefinitionVersionOutput {
	return i.ToSubscriptionDefinitionVersionOutputWithContext(context.Background())
}

func (i *SubscriptionDefinitionVersion) ToSubscriptionDefinitionVersionOutputWithContext(ctx context.Context) SubscriptionDefinitionVersionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SubscriptionDefinitionVersionOutput)
}

type SubscriptionDefinitionVersionOutput struct{ *pulumi.OutputState }

func (SubscriptionDefinitionVersionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SubscriptionDefinitionVersion)(nil))
}

func (o SubscriptionDefinitionVersionOutput) ToSubscriptionDefinitionVersionOutput() SubscriptionDefinitionVersionOutput {
	return o
}

func (o SubscriptionDefinitionVersionOutput) ToSubscriptionDefinitionVersionOutputWithContext(ctx context.Context) SubscriptionDefinitionVersionOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(SubscriptionDefinitionVersionOutput{})
}
