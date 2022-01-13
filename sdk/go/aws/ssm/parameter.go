// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ssm

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::SSM::Parameter
//
// Deprecated: Parameter is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type Parameter struct {
	pulumi.CustomResourceState

	AllowedPattern pulumi.StringPtrOutput `pulumi:"allowedPattern"`
	DataType       pulumi.StringPtrOutput `pulumi:"dataType"`
	Description    pulumi.StringPtrOutput `pulumi:"description"`
	Name           pulumi.StringPtrOutput `pulumi:"name"`
	Policies       pulumi.StringPtrOutput `pulumi:"policies"`
	Tags           pulumi.AnyOutput       `pulumi:"tags"`
	Tier           pulumi.StringPtrOutput `pulumi:"tier"`
	Type           pulumi.StringOutput    `pulumi:"type"`
	Value          pulumi.StringOutput    `pulumi:"value"`
}

// NewParameter registers a new resource with the given unique name, arguments, and options.
func NewParameter(ctx *pulumi.Context,
	name string, args *ParameterArgs, opts ...pulumi.ResourceOption) (*Parameter, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Type == nil {
		return nil, errors.New("invalid value for required argument 'Type'")
	}
	if args.Value == nil {
		return nil, errors.New("invalid value for required argument 'Value'")
	}
	var resource Parameter
	err := ctx.RegisterResource("aws-native:ssm:Parameter", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetParameter gets an existing Parameter resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetParameter(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ParameterState, opts ...pulumi.ResourceOption) (*Parameter, error) {
	var resource Parameter
	err := ctx.ReadResource("aws-native:ssm:Parameter", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Parameter resources.
type parameterState struct {
}

type ParameterState struct {
}

func (ParameterState) ElementType() reflect.Type {
	return reflect.TypeOf((*parameterState)(nil)).Elem()
}

type parameterArgs struct {
	AllowedPattern *string     `pulumi:"allowedPattern"`
	DataType       *string     `pulumi:"dataType"`
	Description    *string     `pulumi:"description"`
	Name           *string     `pulumi:"name"`
	Policies       *string     `pulumi:"policies"`
	Tags           interface{} `pulumi:"tags"`
	Tier           *string     `pulumi:"tier"`
	Type           string      `pulumi:"type"`
	Value          string      `pulumi:"value"`
}

// The set of arguments for constructing a Parameter resource.
type ParameterArgs struct {
	AllowedPattern pulumi.StringPtrInput
	DataType       pulumi.StringPtrInput
	Description    pulumi.StringPtrInput
	Name           pulumi.StringPtrInput
	Policies       pulumi.StringPtrInput
	Tags           pulumi.Input
	Tier           pulumi.StringPtrInput
	Type           pulumi.StringInput
	Value          pulumi.StringInput
}

func (ParameterArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*parameterArgs)(nil)).Elem()
}

type ParameterInput interface {
	pulumi.Input

	ToParameterOutput() ParameterOutput
	ToParameterOutputWithContext(ctx context.Context) ParameterOutput
}

func (*Parameter) ElementType() reflect.Type {
	return reflect.TypeOf((*Parameter)(nil))
}

func (i *Parameter) ToParameterOutput() ParameterOutput {
	return i.ToParameterOutputWithContext(context.Background())
}

func (i *Parameter) ToParameterOutputWithContext(ctx context.Context) ParameterOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ParameterOutput)
}

type ParameterOutput struct{ *pulumi.OutputState }

func (ParameterOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Parameter)(nil))
}

func (o ParameterOutput) ToParameterOutput() ParameterOutput {
	return o
}

func (o ParameterOutput) ToParameterOutputWithContext(ctx context.Context) ParameterOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ParameterInput)(nil)).Elem(), &Parameter{})
	pulumi.RegisterOutputType(ParameterOutput{})
}
