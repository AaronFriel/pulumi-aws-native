// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ec2

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::EC2::CapacityReservationFleet
type CapacityReservationFleet struct {
	pulumi.CustomResourceState

	AllocationStrategy         pulumi.StringPtrOutput                                       `pulumi:"allocationStrategy"`
	CapacityReservationFleetId pulumi.StringOutput                                          `pulumi:"capacityReservationFleetId"`
	EndDate                    pulumi.StringPtrOutput                                       `pulumi:"endDate"`
	InstanceMatchCriteria      CapacityReservationFleetInstanceMatchCriteriaPtrOutput       `pulumi:"instanceMatchCriteria"`
	InstanceTypeSpecifications CapacityReservationFleetInstanceTypeSpecificationArrayOutput `pulumi:"instanceTypeSpecifications"`
	NoRemoveEndDate            pulumi.BoolPtrOutput                                         `pulumi:"noRemoveEndDate"`
	RemoveEndDate              pulumi.BoolPtrOutput                                         `pulumi:"removeEndDate"`
	TagSpecifications          CapacityReservationFleetTagSpecificationArrayOutput          `pulumi:"tagSpecifications"`
	Tenancy                    CapacityReservationFleetTenancyPtrOutput                     `pulumi:"tenancy"`
	TotalTargetCapacity        pulumi.IntPtrOutput                                          `pulumi:"totalTargetCapacity"`
}

// NewCapacityReservationFleet registers a new resource with the given unique name, arguments, and options.
func NewCapacityReservationFleet(ctx *pulumi.Context,
	name string, args *CapacityReservationFleetArgs, opts ...pulumi.ResourceOption) (*CapacityReservationFleet, error) {
	if args == nil {
		args = &CapacityReservationFleetArgs{}
	}

	var resource CapacityReservationFleet
	err := ctx.RegisterResource("aws-native:ec2:CapacityReservationFleet", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCapacityReservationFleet gets an existing CapacityReservationFleet resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCapacityReservationFleet(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CapacityReservationFleetState, opts ...pulumi.ResourceOption) (*CapacityReservationFleet, error) {
	var resource CapacityReservationFleet
	err := ctx.ReadResource("aws-native:ec2:CapacityReservationFleet", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering CapacityReservationFleet resources.
type capacityReservationFleetState struct {
}

type CapacityReservationFleetState struct {
}

func (CapacityReservationFleetState) ElementType() reflect.Type {
	return reflect.TypeOf((*capacityReservationFleetState)(nil)).Elem()
}

type capacityReservationFleetArgs struct {
	AllocationStrategy         *string                                             `pulumi:"allocationStrategy"`
	EndDate                    *string                                             `pulumi:"endDate"`
	InstanceMatchCriteria      *CapacityReservationFleetInstanceMatchCriteria      `pulumi:"instanceMatchCriteria"`
	InstanceTypeSpecifications []CapacityReservationFleetInstanceTypeSpecification `pulumi:"instanceTypeSpecifications"`
	NoRemoveEndDate            *bool                                               `pulumi:"noRemoveEndDate"`
	RemoveEndDate              *bool                                               `pulumi:"removeEndDate"`
	TagSpecifications          []CapacityReservationFleetTagSpecification          `pulumi:"tagSpecifications"`
	Tenancy                    *CapacityReservationFleetTenancy                    `pulumi:"tenancy"`
	TotalTargetCapacity        *int                                                `pulumi:"totalTargetCapacity"`
}

// The set of arguments for constructing a CapacityReservationFleet resource.
type CapacityReservationFleetArgs struct {
	AllocationStrategy         pulumi.StringPtrInput
	EndDate                    pulumi.StringPtrInput
	InstanceMatchCriteria      CapacityReservationFleetInstanceMatchCriteriaPtrInput
	InstanceTypeSpecifications CapacityReservationFleetInstanceTypeSpecificationArrayInput
	NoRemoveEndDate            pulumi.BoolPtrInput
	RemoveEndDate              pulumi.BoolPtrInput
	TagSpecifications          CapacityReservationFleetTagSpecificationArrayInput
	Tenancy                    CapacityReservationFleetTenancyPtrInput
	TotalTargetCapacity        pulumi.IntPtrInput
}

func (CapacityReservationFleetArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*capacityReservationFleetArgs)(nil)).Elem()
}

type CapacityReservationFleetInput interface {
	pulumi.Input

	ToCapacityReservationFleetOutput() CapacityReservationFleetOutput
	ToCapacityReservationFleetOutputWithContext(ctx context.Context) CapacityReservationFleetOutput
}

func (*CapacityReservationFleet) ElementType() reflect.Type {
	return reflect.TypeOf((*CapacityReservationFleet)(nil))
}

func (i *CapacityReservationFleet) ToCapacityReservationFleetOutput() CapacityReservationFleetOutput {
	return i.ToCapacityReservationFleetOutputWithContext(context.Background())
}

func (i *CapacityReservationFleet) ToCapacityReservationFleetOutputWithContext(ctx context.Context) CapacityReservationFleetOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CapacityReservationFleetOutput)
}

type CapacityReservationFleetOutput struct{ *pulumi.OutputState }

func (CapacityReservationFleetOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*CapacityReservationFleet)(nil))
}

func (o CapacityReservationFleetOutput) ToCapacityReservationFleetOutput() CapacityReservationFleetOutput {
	return o
}

func (o CapacityReservationFleetOutput) ToCapacityReservationFleetOutputWithContext(ctx context.Context) CapacityReservationFleetOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(CapacityReservationFleetOutput{})
}