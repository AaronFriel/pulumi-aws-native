// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package appintegrations

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::AppIntegrations::EventIntegration
type EventIntegration struct {
	pulumi.CustomResourceState

	// The associations with the event integration.
	Associations EventIntegrationEventIntegrationAssociationArrayOutput `pulumi:"associations"`
	// The event integration description.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The Amazon Eventbridge bus for the event integration.
	EventBridgeBus pulumi.StringOutput `pulumi:"eventBridgeBus"`
	// The EventFilter (source) associated with the event integration.
	EventFilter EventIntegrationEventFilterOutput `pulumi:"eventFilter"`
	// The Amazon Resource Name (ARN) of the event integration.
	EventIntegrationArn pulumi.StringOutput `pulumi:"eventIntegrationArn"`
	// The name of the event integration.
	Name pulumi.StringOutput `pulumi:"name"`
	// The tags (keys and values) associated with the event integration.
	Tags EventIntegrationTagArrayOutput `pulumi:"tags"`
}

// NewEventIntegration registers a new resource with the given unique name, arguments, and options.
func NewEventIntegration(ctx *pulumi.Context,
	name string, args *EventIntegrationArgs, opts ...pulumi.ResourceOption) (*EventIntegration, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.EventBridgeBus == nil {
		return nil, errors.New("invalid value for required argument 'EventBridgeBus'")
	}
	if args.EventFilter == nil {
		return nil, errors.New("invalid value for required argument 'EventFilter'")
	}
	if args.Name == nil {
		return nil, errors.New("invalid value for required argument 'Name'")
	}
	var resource EventIntegration
	err := ctx.RegisterResource("aws-native:appintegrations:EventIntegration", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetEventIntegration gets an existing EventIntegration resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetEventIntegration(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *EventIntegrationState, opts ...pulumi.ResourceOption) (*EventIntegration, error) {
	var resource EventIntegration
	err := ctx.ReadResource("aws-native:appintegrations:EventIntegration", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering EventIntegration resources.
type eventIntegrationState struct {
}

type EventIntegrationState struct {
}

func (EventIntegrationState) ElementType() reflect.Type {
	return reflect.TypeOf((*eventIntegrationState)(nil)).Elem()
}

type eventIntegrationArgs struct {
	// The event integration description.
	Description *string `pulumi:"description"`
	// The Amazon Eventbridge bus for the event integration.
	EventBridgeBus string `pulumi:"eventBridgeBus"`
	// The EventFilter (source) associated with the event integration.
	EventFilter EventIntegrationEventFilter `pulumi:"eventFilter"`
	// The name of the event integration.
	Name string `pulumi:"name"`
	// The tags (keys and values) associated with the event integration.
	Tags []EventIntegrationTag `pulumi:"tags"`
}

// The set of arguments for constructing a EventIntegration resource.
type EventIntegrationArgs struct {
	// The event integration description.
	Description pulumi.StringPtrInput
	// The Amazon Eventbridge bus for the event integration.
	EventBridgeBus pulumi.StringInput
	// The EventFilter (source) associated with the event integration.
	EventFilter EventIntegrationEventFilterInput
	// The name of the event integration.
	Name pulumi.StringInput
	// The tags (keys and values) associated with the event integration.
	Tags EventIntegrationTagArrayInput
}

func (EventIntegrationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*eventIntegrationArgs)(nil)).Elem()
}

type EventIntegrationInput interface {
	pulumi.Input

	ToEventIntegrationOutput() EventIntegrationOutput
	ToEventIntegrationOutputWithContext(ctx context.Context) EventIntegrationOutput
}

func (*EventIntegration) ElementType() reflect.Type {
	return reflect.TypeOf((*EventIntegration)(nil))
}

func (i *EventIntegration) ToEventIntegrationOutput() EventIntegrationOutput {
	return i.ToEventIntegrationOutputWithContext(context.Background())
}

func (i *EventIntegration) ToEventIntegrationOutputWithContext(ctx context.Context) EventIntegrationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EventIntegrationOutput)
}

type EventIntegrationOutput struct{ *pulumi.OutputState }

func (EventIntegrationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*EventIntegration)(nil))
}

func (o EventIntegrationOutput) ToEventIntegrationOutput() EventIntegrationOutput {
	return o
}

func (o EventIntegrationOutput) ToEventIntegrationOutputWithContext(ctx context.Context) EventIntegrationOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(EventIntegrationOutput{})
}
