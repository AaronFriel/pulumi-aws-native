// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package groundstation

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// AWS Ground Station DataflowEndpointGroup schema for CloudFormation
type DataflowEndpointGroup struct {
	pulumi.CustomResourceState

	Arn             pulumi.StringOutput                             `pulumi:"arn"`
	EndpointDetails DataflowEndpointGroupEndpointDetailsArrayOutput `pulumi:"endpointDetails"`
	Tags            DataflowEndpointGroupTagArrayOutput             `pulumi:"tags"`
}

// NewDataflowEndpointGroup registers a new resource with the given unique name, arguments, and options.
func NewDataflowEndpointGroup(ctx *pulumi.Context,
	name string, args *DataflowEndpointGroupArgs, opts ...pulumi.ResourceOption) (*DataflowEndpointGroup, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.EndpointDetails == nil {
		return nil, errors.New("invalid value for required argument 'EndpointDetails'")
	}
	var resource DataflowEndpointGroup
	err := ctx.RegisterResource("aws-native:groundstation:DataflowEndpointGroup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDataflowEndpointGroup gets an existing DataflowEndpointGroup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDataflowEndpointGroup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DataflowEndpointGroupState, opts ...pulumi.ResourceOption) (*DataflowEndpointGroup, error) {
	var resource DataflowEndpointGroup
	err := ctx.ReadResource("aws-native:groundstation:DataflowEndpointGroup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DataflowEndpointGroup resources.
type dataflowEndpointGroupState struct {
}

type DataflowEndpointGroupState struct {
}

func (DataflowEndpointGroupState) ElementType() reflect.Type {
	return reflect.TypeOf((*dataflowEndpointGroupState)(nil)).Elem()
}

type dataflowEndpointGroupArgs struct {
	EndpointDetails []DataflowEndpointGroupEndpointDetails `pulumi:"endpointDetails"`
	Tags            []DataflowEndpointGroupTag             `pulumi:"tags"`
}

// The set of arguments for constructing a DataflowEndpointGroup resource.
type DataflowEndpointGroupArgs struct {
	EndpointDetails DataflowEndpointGroupEndpointDetailsArrayInput
	Tags            DataflowEndpointGroupTagArrayInput
}

func (DataflowEndpointGroupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*dataflowEndpointGroupArgs)(nil)).Elem()
}

type DataflowEndpointGroupInput interface {
	pulumi.Input

	ToDataflowEndpointGroupOutput() DataflowEndpointGroupOutput
	ToDataflowEndpointGroupOutputWithContext(ctx context.Context) DataflowEndpointGroupOutput
}

func (*DataflowEndpointGroup) ElementType() reflect.Type {
	return reflect.TypeOf((*DataflowEndpointGroup)(nil))
}

func (i *DataflowEndpointGroup) ToDataflowEndpointGroupOutput() DataflowEndpointGroupOutput {
	return i.ToDataflowEndpointGroupOutputWithContext(context.Background())
}

func (i *DataflowEndpointGroup) ToDataflowEndpointGroupOutputWithContext(ctx context.Context) DataflowEndpointGroupOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DataflowEndpointGroupOutput)
}

type DataflowEndpointGroupOutput struct{ *pulumi.OutputState }

func (DataflowEndpointGroupOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*DataflowEndpointGroup)(nil))
}

func (o DataflowEndpointGroupOutput) ToDataflowEndpointGroupOutput() DataflowEndpointGroupOutput {
	return o
}

func (o DataflowEndpointGroupOutput) ToDataflowEndpointGroupOutputWithContext(ctx context.Context) DataflowEndpointGroupOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(DataflowEndpointGroupOutput{})
}
