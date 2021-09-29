// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package aws

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// A special resource that enables deploying CloudFormation Extensions (third-party resources). An extension has to be pre-registered in your AWS account in order to use this resource.
type ExtensionResource struct {
	pulumi.CustomResourceState

	// Dictionary of the extension resource attributes.
	Outputs pulumi.MapOutput `pulumi:"outputs"`
}

// NewExtensionResource registers a new resource with the given unique name, arguments, and options.
func NewExtensionResource(ctx *pulumi.Context,
	name string, args *ExtensionResourceArgs, opts ...pulumi.ResourceOption) (*ExtensionResource, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Properties == nil {
		return nil, errors.New("invalid value for required argument 'Properties'")
	}
	if args.Type == nil {
		return nil, errors.New("invalid value for required argument 'Type'")
	}
	var resource ExtensionResource
	err := ctx.RegisterResource("aws-native:index:ExtensionResource", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetExtensionResource gets an existing ExtensionResource resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetExtensionResource(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ExtensionResourceState, opts ...pulumi.ResourceOption) (*ExtensionResource, error) {
	var resource ExtensionResource
	err := ctx.ReadResource("aws-native:index:ExtensionResource", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ExtensionResource resources.
type extensionResourceState struct {
}

type ExtensionResourceState struct {
}

func (ExtensionResourceState) ElementType() reflect.Type {
	return reflect.TypeOf((*extensionResourceState)(nil)).Elem()
}

type extensionResourceArgs struct {
	// Dictionary of the extension resource properties.
	Properties map[string]interface{} `pulumi:"properties"`
	// CloudFormation type name.
	Type string `pulumi:"type"`
}

// The set of arguments for constructing a ExtensionResource resource.
type ExtensionResourceArgs struct {
	// Dictionary of the extension resource properties.
	Properties pulumi.MapInput
	// CloudFormation type name.
	Type pulumi.StringInput
}

func (ExtensionResourceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*extensionResourceArgs)(nil)).Elem()
}

type ExtensionResourceInput interface {
	pulumi.Input

	ToExtensionResourceOutput() ExtensionResourceOutput
	ToExtensionResourceOutputWithContext(ctx context.Context) ExtensionResourceOutput
}

func (*ExtensionResource) ElementType() reflect.Type {
	return reflect.TypeOf((*ExtensionResource)(nil))
}

func (i *ExtensionResource) ToExtensionResourceOutput() ExtensionResourceOutput {
	return i.ToExtensionResourceOutputWithContext(context.Background())
}

func (i *ExtensionResource) ToExtensionResourceOutputWithContext(ctx context.Context) ExtensionResourceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ExtensionResourceOutput)
}

type ExtensionResourceOutput struct{ *pulumi.OutputState }

func (ExtensionResourceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ExtensionResource)(nil))
}

func (o ExtensionResourceOutput) ToExtensionResourceOutput() ExtensionResourceOutput {
	return o
}

func (o ExtensionResourceOutput) ToExtensionResourceOutputWithContext(ctx context.Context) ExtensionResourceOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ExtensionResourceOutput{})
}
