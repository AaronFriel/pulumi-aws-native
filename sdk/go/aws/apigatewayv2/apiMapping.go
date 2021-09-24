// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package apigatewayv2

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::ApiGatewayV2::ApiMapping
//
// Deprecated: ApiMapping is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type ApiMapping struct {
	pulumi.CustomResourceState

	ApiId         pulumi.StringOutput    `pulumi:"apiId"`
	ApiMappingKey pulumi.StringPtrOutput `pulumi:"apiMappingKey"`
	DomainName    pulumi.StringOutput    `pulumi:"domainName"`
	Stage         pulumi.StringOutput    `pulumi:"stage"`
}

// NewApiMapping registers a new resource with the given unique name, arguments, and options.
func NewApiMapping(ctx *pulumi.Context,
	name string, args *ApiMappingArgs, opts ...pulumi.ResourceOption) (*ApiMapping, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ApiId == nil {
		return nil, errors.New("invalid value for required argument 'ApiId'")
	}
	if args.DomainName == nil {
		return nil, errors.New("invalid value for required argument 'DomainName'")
	}
	if args.Stage == nil {
		return nil, errors.New("invalid value for required argument 'Stage'")
	}
	var resource ApiMapping
	err := ctx.RegisterResource("aws-native:apigatewayv2:ApiMapping", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetApiMapping gets an existing ApiMapping resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetApiMapping(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ApiMappingState, opts ...pulumi.ResourceOption) (*ApiMapping, error) {
	var resource ApiMapping
	err := ctx.ReadResource("aws-native:apigatewayv2:ApiMapping", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ApiMapping resources.
type apiMappingState struct {
}

type ApiMappingState struct {
}

func (ApiMappingState) ElementType() reflect.Type {
	return reflect.TypeOf((*apiMappingState)(nil)).Elem()
}

type apiMappingArgs struct {
	ApiId         string  `pulumi:"apiId"`
	ApiMappingKey *string `pulumi:"apiMappingKey"`
	DomainName    string  `pulumi:"domainName"`
	Stage         string  `pulumi:"stage"`
}

// The set of arguments for constructing a ApiMapping resource.
type ApiMappingArgs struct {
	ApiId         pulumi.StringInput
	ApiMappingKey pulumi.StringPtrInput
	DomainName    pulumi.StringInput
	Stage         pulumi.StringInput
}

func (ApiMappingArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*apiMappingArgs)(nil)).Elem()
}

type ApiMappingInput interface {
	pulumi.Input

	ToApiMappingOutput() ApiMappingOutput
	ToApiMappingOutputWithContext(ctx context.Context) ApiMappingOutput
}

func (*ApiMapping) ElementType() reflect.Type {
	return reflect.TypeOf((*ApiMapping)(nil))
}

func (i *ApiMapping) ToApiMappingOutput() ApiMappingOutput {
	return i.ToApiMappingOutputWithContext(context.Background())
}

func (i *ApiMapping) ToApiMappingOutputWithContext(ctx context.Context) ApiMappingOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ApiMappingOutput)
}

type ApiMappingOutput struct{ *pulumi.OutputState }

func (ApiMappingOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ApiMapping)(nil))
}

func (o ApiMappingOutput) ToApiMappingOutput() ApiMappingOutput {
	return o
}

func (o ApiMappingOutput) ToApiMappingOutputWithContext(ctx context.Context) ApiMappingOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ApiMappingOutput{})
}
