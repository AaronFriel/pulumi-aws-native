// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package iot1click

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::IoT1Click::Placement
//
// Deprecated: Placement is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type Placement struct {
	pulumi.CustomResourceState

	AssociatedDevices pulumi.AnyOutput       `pulumi:"associatedDevices"`
	Attributes        pulumi.AnyOutput       `pulumi:"attributes"`
	PlacementName     pulumi.StringPtrOutput `pulumi:"placementName"`
	ProjectName       pulumi.StringOutput    `pulumi:"projectName"`
}

// NewPlacement registers a new resource with the given unique name, arguments, and options.
func NewPlacement(ctx *pulumi.Context,
	name string, args *PlacementArgs, opts ...pulumi.ResourceOption) (*Placement, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ProjectName == nil {
		return nil, errors.New("invalid value for required argument 'ProjectName'")
	}
	var resource Placement
	err := ctx.RegisterResource("aws-native:iot1click:Placement", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPlacement gets an existing Placement resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPlacement(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PlacementState, opts ...pulumi.ResourceOption) (*Placement, error) {
	var resource Placement
	err := ctx.ReadResource("aws-native:iot1click:Placement", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Placement resources.
type placementState struct {
}

type PlacementState struct {
}

func (PlacementState) ElementType() reflect.Type {
	return reflect.TypeOf((*placementState)(nil)).Elem()
}

type placementArgs struct {
	AssociatedDevices interface{} `pulumi:"associatedDevices"`
	Attributes        interface{} `pulumi:"attributes"`
	PlacementName     *string     `pulumi:"placementName"`
	ProjectName       string      `pulumi:"projectName"`
}

// The set of arguments for constructing a Placement resource.
type PlacementArgs struct {
	AssociatedDevices pulumi.Input
	Attributes        pulumi.Input
	PlacementName     pulumi.StringPtrInput
	ProjectName       pulumi.StringInput
}

func (PlacementArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*placementArgs)(nil)).Elem()
}

type PlacementInput interface {
	pulumi.Input

	ToPlacementOutput() PlacementOutput
	ToPlacementOutputWithContext(ctx context.Context) PlacementOutput
}

func (*Placement) ElementType() reflect.Type {
	return reflect.TypeOf((*Placement)(nil))
}

func (i *Placement) ToPlacementOutput() PlacementOutput {
	return i.ToPlacementOutputWithContext(context.Background())
}

func (i *Placement) ToPlacementOutputWithContext(ctx context.Context) PlacementOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PlacementOutput)
}

type PlacementOutput struct{ *pulumi.OutputState }

func (PlacementOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Placement)(nil))
}

func (o PlacementOutput) ToPlacementOutput() PlacementOutput {
	return o
}

func (o PlacementOutput) ToPlacementOutputWithContext(ctx context.Context) PlacementOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(PlacementOutput{})
}
