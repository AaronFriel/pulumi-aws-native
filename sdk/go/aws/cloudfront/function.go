// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package cloudfront

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::CloudFront::Function
type Function struct {
	pulumi.CustomResourceState

	AutoPublish      pulumi.BoolPtrOutput      `pulumi:"autoPublish"`
	FunctionARN      pulumi.StringOutput       `pulumi:"functionARN"`
	FunctionCode     pulumi.StringPtrOutput    `pulumi:"functionCode"`
	FunctionConfig   FunctionConfigPtrOutput   `pulumi:"functionConfig"`
	FunctionMetadata FunctionMetadataPtrOutput `pulumi:"functionMetadata"`
	Name             pulumi.StringOutput       `pulumi:"name"`
	Stage            pulumi.StringOutput       `pulumi:"stage"`
}

// NewFunction registers a new resource with the given unique name, arguments, and options.
func NewFunction(ctx *pulumi.Context,
	name string, args *FunctionArgs, opts ...pulumi.ResourceOption) (*Function, error) {
	if args == nil {
		args = &FunctionArgs{}
	}

	var resource Function
	err := ctx.RegisterResource("aws-native:cloudfront:Function", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetFunction gets an existing Function resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetFunction(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *FunctionState, opts ...pulumi.ResourceOption) (*Function, error) {
	var resource Function
	err := ctx.ReadResource("aws-native:cloudfront:Function", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Function resources.
type functionState struct {
}

type FunctionState struct {
}

func (FunctionState) ElementType() reflect.Type {
	return reflect.TypeOf((*functionState)(nil)).Elem()
}

type functionArgs struct {
	AutoPublish      *bool             `pulumi:"autoPublish"`
	FunctionCode     *string           `pulumi:"functionCode"`
	FunctionConfig   *FunctionConfig   `pulumi:"functionConfig"`
	FunctionMetadata *FunctionMetadata `pulumi:"functionMetadata"`
	Name             *string           `pulumi:"name"`
}

// The set of arguments for constructing a Function resource.
type FunctionArgs struct {
	AutoPublish      pulumi.BoolPtrInput
	FunctionCode     pulumi.StringPtrInput
	FunctionConfig   FunctionConfigPtrInput
	FunctionMetadata FunctionMetadataPtrInput
	Name             pulumi.StringPtrInput
}

func (FunctionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*functionArgs)(nil)).Elem()
}

type FunctionInput interface {
	pulumi.Input

	ToFunctionOutput() FunctionOutput
	ToFunctionOutputWithContext(ctx context.Context) FunctionOutput
}

func (*Function) ElementType() reflect.Type {
	return reflect.TypeOf((*Function)(nil))
}

func (i *Function) ToFunctionOutput() FunctionOutput {
	return i.ToFunctionOutputWithContext(context.Background())
}

func (i *Function) ToFunctionOutputWithContext(ctx context.Context) FunctionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FunctionOutput)
}

type FunctionOutput struct{ *pulumi.OutputState }

func (FunctionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Function)(nil))
}

func (o FunctionOutput) ToFunctionOutput() FunctionOutput {
	return o
}

func (o FunctionOutput) ToFunctionOutputWithContext(ctx context.Context) FunctionOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*FunctionInput)(nil)).Elem(), &Function{})
	pulumi.RegisterOutputType(FunctionOutput{})
}
