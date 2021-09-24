// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ec2

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::EC2::CapacityReservation
//
// Deprecated: CapacityReservation is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type CapacityReservation struct {
	pulumi.CustomResourceState

	AvailabilityZone       pulumi.StringOutput                            `pulumi:"availabilityZone"`
	AvailableInstanceCount pulumi.IntOutput                               `pulumi:"availableInstanceCount"`
	EbsOptimized           pulumi.BoolPtrOutput                           `pulumi:"ebsOptimized"`
	EndDate                pulumi.StringPtrOutput                         `pulumi:"endDate"`
	EndDateType            pulumi.StringPtrOutput                         `pulumi:"endDateType"`
	EphemeralStorage       pulumi.BoolPtrOutput                           `pulumi:"ephemeralStorage"`
	InstanceCount          pulumi.IntOutput                               `pulumi:"instanceCount"`
	InstanceMatchCriteria  pulumi.StringPtrOutput                         `pulumi:"instanceMatchCriteria"`
	InstancePlatform       pulumi.StringOutput                            `pulumi:"instancePlatform"`
	InstanceType           pulumi.StringOutput                            `pulumi:"instanceType"`
	TagSpecifications      CapacityReservationTagSpecificationArrayOutput `pulumi:"tagSpecifications"`
	Tenancy                pulumi.StringPtrOutput                         `pulumi:"tenancy"`
	TotalInstanceCount     pulumi.IntOutput                               `pulumi:"totalInstanceCount"`
}

// NewCapacityReservation registers a new resource with the given unique name, arguments, and options.
func NewCapacityReservation(ctx *pulumi.Context,
	name string, args *CapacityReservationArgs, opts ...pulumi.ResourceOption) (*CapacityReservation, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AvailabilityZone == nil {
		return nil, errors.New("invalid value for required argument 'AvailabilityZone'")
	}
	if args.InstanceCount == nil {
		return nil, errors.New("invalid value for required argument 'InstanceCount'")
	}
	if args.InstancePlatform == nil {
		return nil, errors.New("invalid value for required argument 'InstancePlatform'")
	}
	if args.InstanceType == nil {
		return nil, errors.New("invalid value for required argument 'InstanceType'")
	}
	var resource CapacityReservation
	err := ctx.RegisterResource("aws-native:ec2:CapacityReservation", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCapacityReservation gets an existing CapacityReservation resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCapacityReservation(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CapacityReservationState, opts ...pulumi.ResourceOption) (*CapacityReservation, error) {
	var resource CapacityReservation
	err := ctx.ReadResource("aws-native:ec2:CapacityReservation", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering CapacityReservation resources.
type capacityReservationState struct {
}

type CapacityReservationState struct {
}

func (CapacityReservationState) ElementType() reflect.Type {
	return reflect.TypeOf((*capacityReservationState)(nil)).Elem()
}

type capacityReservationArgs struct {
	AvailabilityZone      string                                `pulumi:"availabilityZone"`
	EbsOptimized          *bool                                 `pulumi:"ebsOptimized"`
	EndDate               *string                               `pulumi:"endDate"`
	EndDateType           *string                               `pulumi:"endDateType"`
	EphemeralStorage      *bool                                 `pulumi:"ephemeralStorage"`
	InstanceCount         int                                   `pulumi:"instanceCount"`
	InstanceMatchCriteria *string                               `pulumi:"instanceMatchCriteria"`
	InstancePlatform      string                                `pulumi:"instancePlatform"`
	InstanceType          string                                `pulumi:"instanceType"`
	TagSpecifications     []CapacityReservationTagSpecification `pulumi:"tagSpecifications"`
	Tenancy               *string                               `pulumi:"tenancy"`
}

// The set of arguments for constructing a CapacityReservation resource.
type CapacityReservationArgs struct {
	AvailabilityZone      pulumi.StringInput
	EbsOptimized          pulumi.BoolPtrInput
	EndDate               pulumi.StringPtrInput
	EndDateType           pulumi.StringPtrInput
	EphemeralStorage      pulumi.BoolPtrInput
	InstanceCount         pulumi.IntInput
	InstanceMatchCriteria pulumi.StringPtrInput
	InstancePlatform      pulumi.StringInput
	InstanceType          pulumi.StringInput
	TagSpecifications     CapacityReservationTagSpecificationArrayInput
	Tenancy               pulumi.StringPtrInput
}

func (CapacityReservationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*capacityReservationArgs)(nil)).Elem()
}

type CapacityReservationInput interface {
	pulumi.Input

	ToCapacityReservationOutput() CapacityReservationOutput
	ToCapacityReservationOutputWithContext(ctx context.Context) CapacityReservationOutput
}

func (*CapacityReservation) ElementType() reflect.Type {
	return reflect.TypeOf((*CapacityReservation)(nil))
}

func (i *CapacityReservation) ToCapacityReservationOutput() CapacityReservationOutput {
	return i.ToCapacityReservationOutputWithContext(context.Background())
}

func (i *CapacityReservation) ToCapacityReservationOutputWithContext(ctx context.Context) CapacityReservationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CapacityReservationOutput)
}

type CapacityReservationOutput struct{ *pulumi.OutputState }

func (CapacityReservationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*CapacityReservation)(nil))
}

func (o CapacityReservationOutput) ToCapacityReservationOutput() CapacityReservationOutput {
	return o
}

func (o CapacityReservationOutput) ToCapacityReservationOutputWithContext(ctx context.Context) CapacityReservationOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(CapacityReservationOutput{})
}
