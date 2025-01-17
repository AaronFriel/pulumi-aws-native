// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package greengrassv2

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource for Greengrass component version.
type ComponentVersion struct {
	pulumi.CustomResourceState

	Arn              pulumi.StringOutput                                 `pulumi:"arn"`
	ComponentName    pulumi.StringOutput                                 `pulumi:"componentName"`
	ComponentVersion pulumi.StringOutput                                 `pulumi:"componentVersion"`
	InlineRecipe     pulumi.StringPtrOutput                              `pulumi:"inlineRecipe"`
	LambdaFunction   ComponentVersionLambdaFunctionRecipeSourcePtrOutput `pulumi:"lambdaFunction"`
	Tags             pulumi.AnyOutput                                    `pulumi:"tags"`
}

// NewComponentVersion registers a new resource with the given unique name, arguments, and options.
func NewComponentVersion(ctx *pulumi.Context,
	name string, args *ComponentVersionArgs, opts ...pulumi.ResourceOption) (*ComponentVersion, error) {
	if args == nil {
		args = &ComponentVersionArgs{}
	}

	var resource ComponentVersion
	err := ctx.RegisterResource("aws-native:greengrassv2:ComponentVersion", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetComponentVersion gets an existing ComponentVersion resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetComponentVersion(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ComponentVersionState, opts ...pulumi.ResourceOption) (*ComponentVersion, error) {
	var resource ComponentVersion
	err := ctx.ReadResource("aws-native:greengrassv2:ComponentVersion", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ComponentVersion resources.
type componentVersionState struct {
}

type ComponentVersionState struct {
}

func (ComponentVersionState) ElementType() reflect.Type {
	return reflect.TypeOf((*componentVersionState)(nil)).Elem()
}

type componentVersionArgs struct {
	InlineRecipe   *string                                     `pulumi:"inlineRecipe"`
	LambdaFunction *ComponentVersionLambdaFunctionRecipeSource `pulumi:"lambdaFunction"`
	Tags           interface{}                                 `pulumi:"tags"`
}

// The set of arguments for constructing a ComponentVersion resource.
type ComponentVersionArgs struct {
	InlineRecipe   pulumi.StringPtrInput
	LambdaFunction ComponentVersionLambdaFunctionRecipeSourcePtrInput
	Tags           pulumi.Input
}

func (ComponentVersionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*componentVersionArgs)(nil)).Elem()
}

type ComponentVersionInput interface {
	pulumi.Input

	ToComponentVersionOutput() ComponentVersionOutput
	ToComponentVersionOutputWithContext(ctx context.Context) ComponentVersionOutput
}

func (*ComponentVersion) ElementType() reflect.Type {
	return reflect.TypeOf((*ComponentVersion)(nil))
}

func (i *ComponentVersion) ToComponentVersionOutput() ComponentVersionOutput {
	return i.ToComponentVersionOutputWithContext(context.Background())
}

func (i *ComponentVersion) ToComponentVersionOutputWithContext(ctx context.Context) ComponentVersionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ComponentVersionOutput)
}

type ComponentVersionOutput struct{ *pulumi.OutputState }

func (ComponentVersionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ComponentVersion)(nil))
}

func (o ComponentVersionOutput) ToComponentVersionOutput() ComponentVersionOutput {
	return o
}

func (o ComponentVersionOutput) ToComponentVersionOutputWithContext(ctx context.Context) ComponentVersionOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ComponentVersionInput)(nil)).Elem(), &ComponentVersion{})
	pulumi.RegisterOutputType(ComponentVersionOutput{})
}
