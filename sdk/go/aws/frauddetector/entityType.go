// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package frauddetector

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// An entity type for fraud detector.
type EntityType struct {
	pulumi.CustomResourceState

	// The entity type ARN.
	Arn pulumi.StringOutput `pulumi:"arn"`
	// The timestamp when the entity type was created.
	CreatedTime pulumi.StringOutput `pulumi:"createdTime"`
	// The entity type description.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The timestamp when the entity type was last updated.
	LastUpdatedTime pulumi.StringOutput `pulumi:"lastUpdatedTime"`
	// The name of the entity type.
	Name pulumi.StringOutput `pulumi:"name"`
	// Tags associated with this entity type.
	Tags EntityTypeTagArrayOutput `pulumi:"tags"`
}

// NewEntityType registers a new resource with the given unique name, arguments, and options.
func NewEntityType(ctx *pulumi.Context,
	name string, args *EntityTypeArgs, opts ...pulumi.ResourceOption) (*EntityType, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Name == nil {
		return nil, errors.New("invalid value for required argument 'Name'")
	}
	var resource EntityType
	err := ctx.RegisterResource("aws-native:frauddetector:EntityType", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetEntityType gets an existing EntityType resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetEntityType(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *EntityTypeState, opts ...pulumi.ResourceOption) (*EntityType, error) {
	var resource EntityType
	err := ctx.ReadResource("aws-native:frauddetector:EntityType", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering EntityType resources.
type entityTypeState struct {
}

type EntityTypeState struct {
}

func (EntityTypeState) ElementType() reflect.Type {
	return reflect.TypeOf((*entityTypeState)(nil)).Elem()
}

type entityTypeArgs struct {
	// The entity type description.
	Description *string `pulumi:"description"`
	// The name of the entity type.
	Name string `pulumi:"name"`
	// Tags associated with this entity type.
	Tags []EntityTypeTag `pulumi:"tags"`
}

// The set of arguments for constructing a EntityType resource.
type EntityTypeArgs struct {
	// The entity type description.
	Description pulumi.StringPtrInput
	// The name of the entity type.
	Name pulumi.StringInput
	// Tags associated with this entity type.
	Tags EntityTypeTagArrayInput
}

func (EntityTypeArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*entityTypeArgs)(nil)).Elem()
}

type EntityTypeInput interface {
	pulumi.Input

	ToEntityTypeOutput() EntityTypeOutput
	ToEntityTypeOutputWithContext(ctx context.Context) EntityTypeOutput
}

func (*EntityType) ElementType() reflect.Type {
	return reflect.TypeOf((*EntityType)(nil))
}

func (i *EntityType) ToEntityTypeOutput() EntityTypeOutput {
	return i.ToEntityTypeOutputWithContext(context.Background())
}

func (i *EntityType) ToEntityTypeOutputWithContext(ctx context.Context) EntityTypeOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EntityTypeOutput)
}

type EntityTypeOutput struct{ *pulumi.OutputState }

func (EntityTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*EntityType)(nil))
}

func (o EntityTypeOutput) ToEntityTypeOutput() EntityTypeOutput {
	return o
}

func (o EntityTypeOutput) ToEntityTypeOutputWithContext(ctx context.Context) EntityTypeOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(EntityTypeOutput{})
}
