// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package lambda

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::Lambda::CodeSigningConfig.
type CodeSigningConfig struct {
	pulumi.CustomResourceState

	// When the CodeSigningConfig is later on attached to a function, the function code will be expected to be signed by profiles from this list
	AllowedPublishers CodeSigningConfigAllowedPublishersOutput `pulumi:"allowedPublishers"`
	// A unique Arn for CodeSigningConfig resource
	CodeSigningConfigArn pulumi.StringOutput `pulumi:"codeSigningConfigArn"`
	// A unique identifier for CodeSigningConfig resource
	CodeSigningConfigId pulumi.StringOutput `pulumi:"codeSigningConfigId"`
	// Policies to control how to act if a signature is invalid
	CodeSigningPolicies CodeSigningConfigCodeSigningPoliciesPtrOutput `pulumi:"codeSigningPolicies"`
	// A description of the CodeSigningConfig
	Description pulumi.StringPtrOutput `pulumi:"description"`
}

// NewCodeSigningConfig registers a new resource with the given unique name, arguments, and options.
func NewCodeSigningConfig(ctx *pulumi.Context,
	name string, args *CodeSigningConfigArgs, opts ...pulumi.ResourceOption) (*CodeSigningConfig, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AllowedPublishers == nil {
		return nil, errors.New("invalid value for required argument 'AllowedPublishers'")
	}
	var resource CodeSigningConfig
	err := ctx.RegisterResource("aws-native:lambda:CodeSigningConfig", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCodeSigningConfig gets an existing CodeSigningConfig resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCodeSigningConfig(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CodeSigningConfigState, opts ...pulumi.ResourceOption) (*CodeSigningConfig, error) {
	var resource CodeSigningConfig
	err := ctx.ReadResource("aws-native:lambda:CodeSigningConfig", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering CodeSigningConfig resources.
type codeSigningConfigState struct {
}

type CodeSigningConfigState struct {
}

func (CodeSigningConfigState) ElementType() reflect.Type {
	return reflect.TypeOf((*codeSigningConfigState)(nil)).Elem()
}

type codeSigningConfigArgs struct {
	// When the CodeSigningConfig is later on attached to a function, the function code will be expected to be signed by profiles from this list
	AllowedPublishers CodeSigningConfigAllowedPublishers `pulumi:"allowedPublishers"`
	// Policies to control how to act if a signature is invalid
	CodeSigningPolicies *CodeSigningConfigCodeSigningPolicies `pulumi:"codeSigningPolicies"`
	// A description of the CodeSigningConfig
	Description *string `pulumi:"description"`
}

// The set of arguments for constructing a CodeSigningConfig resource.
type CodeSigningConfigArgs struct {
	// When the CodeSigningConfig is later on attached to a function, the function code will be expected to be signed by profiles from this list
	AllowedPublishers CodeSigningConfigAllowedPublishersInput
	// Policies to control how to act if a signature is invalid
	CodeSigningPolicies CodeSigningConfigCodeSigningPoliciesPtrInput
	// A description of the CodeSigningConfig
	Description pulumi.StringPtrInput
}

func (CodeSigningConfigArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*codeSigningConfigArgs)(nil)).Elem()
}

type CodeSigningConfigInput interface {
	pulumi.Input

	ToCodeSigningConfigOutput() CodeSigningConfigOutput
	ToCodeSigningConfigOutputWithContext(ctx context.Context) CodeSigningConfigOutput
}

func (*CodeSigningConfig) ElementType() reflect.Type {
	return reflect.TypeOf((*CodeSigningConfig)(nil))
}

func (i *CodeSigningConfig) ToCodeSigningConfigOutput() CodeSigningConfigOutput {
	return i.ToCodeSigningConfigOutputWithContext(context.Background())
}

func (i *CodeSigningConfig) ToCodeSigningConfigOutputWithContext(ctx context.Context) CodeSigningConfigOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CodeSigningConfigOutput)
}

type CodeSigningConfigOutput struct{ *pulumi.OutputState }

func (CodeSigningConfigOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*CodeSigningConfig)(nil))
}

func (o CodeSigningConfigOutput) ToCodeSigningConfigOutput() CodeSigningConfigOutput {
	return o
}

func (o CodeSigningConfigOutput) ToCodeSigningConfigOutputWithContext(ctx context.Context) CodeSigningConfigOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*CodeSigningConfigInput)(nil)).Elem(), &CodeSigningConfig{})
	pulumi.RegisterOutputType(CodeSigningConfigOutput{})
}
