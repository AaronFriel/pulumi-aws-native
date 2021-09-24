// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package dax

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::DAX::SubnetGroup
//
// Deprecated: SubnetGroup is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type SubnetGroup struct {
	pulumi.CustomResourceState

	Description     pulumi.StringPtrOutput   `pulumi:"description"`
	SubnetGroupName pulumi.StringPtrOutput   `pulumi:"subnetGroupName"`
	SubnetIds       pulumi.StringArrayOutput `pulumi:"subnetIds"`
}

// NewSubnetGroup registers a new resource with the given unique name, arguments, and options.
func NewSubnetGroup(ctx *pulumi.Context,
	name string, args *SubnetGroupArgs, opts ...pulumi.ResourceOption) (*SubnetGroup, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.SubnetIds == nil {
		return nil, errors.New("invalid value for required argument 'SubnetIds'")
	}
	var resource SubnetGroup
	err := ctx.RegisterResource("aws-native:dax:SubnetGroup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSubnetGroup gets an existing SubnetGroup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSubnetGroup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SubnetGroupState, opts ...pulumi.ResourceOption) (*SubnetGroup, error) {
	var resource SubnetGroup
	err := ctx.ReadResource("aws-native:dax:SubnetGroup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SubnetGroup resources.
type subnetGroupState struct {
}

type SubnetGroupState struct {
}

func (SubnetGroupState) ElementType() reflect.Type {
	return reflect.TypeOf((*subnetGroupState)(nil)).Elem()
}

type subnetGroupArgs struct {
	Description     *string  `pulumi:"description"`
	SubnetGroupName *string  `pulumi:"subnetGroupName"`
	SubnetIds       []string `pulumi:"subnetIds"`
}

// The set of arguments for constructing a SubnetGroup resource.
type SubnetGroupArgs struct {
	Description     pulumi.StringPtrInput
	SubnetGroupName pulumi.StringPtrInput
	SubnetIds       pulumi.StringArrayInput
}

func (SubnetGroupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*subnetGroupArgs)(nil)).Elem()
}

type SubnetGroupInput interface {
	pulumi.Input

	ToSubnetGroupOutput() SubnetGroupOutput
	ToSubnetGroupOutputWithContext(ctx context.Context) SubnetGroupOutput
}

func (*SubnetGroup) ElementType() reflect.Type {
	return reflect.TypeOf((*SubnetGroup)(nil))
}

func (i *SubnetGroup) ToSubnetGroupOutput() SubnetGroupOutput {
	return i.ToSubnetGroupOutputWithContext(context.Background())
}

func (i *SubnetGroup) ToSubnetGroupOutputWithContext(ctx context.Context) SubnetGroupOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SubnetGroupOutput)
}

type SubnetGroupOutput struct{ *pulumi.OutputState }

func (SubnetGroupOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SubnetGroup)(nil))
}

func (o SubnetGroupOutput) ToSubnetGroupOutput() SubnetGroupOutput {
	return o
}

func (o SubnetGroupOutput) ToSubnetGroupOutputWithContext(ctx context.Context) SubnetGroupOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(SubnetGroupOutput{})
}
