// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package refactorspaces

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Definition of AWS::RefactorSpaces::Environment Resource Type
type Environment struct {
	pulumi.CustomResourceState

	Arn                   pulumi.StringOutput                   `pulumi:"arn"`
	Description           pulumi.StringPtrOutput                `pulumi:"description"`
	EnvironmentIdentifier pulumi.StringOutput                   `pulumi:"environmentIdentifier"`
	Name                  pulumi.StringPtrOutput                `pulumi:"name"`
	NetworkFabricType     EnvironmentNetworkFabricTypePtrOutput `pulumi:"networkFabricType"`
	// Metadata that you can assign to help organize the frameworks that you create. Each tag is a key-value pair.
	Tags             EnvironmentTagArrayOutput `pulumi:"tags"`
	TransitGatewayId pulumi.StringOutput       `pulumi:"transitGatewayId"`
}

// NewEnvironment registers a new resource with the given unique name, arguments, and options.
func NewEnvironment(ctx *pulumi.Context,
	name string, args *EnvironmentArgs, opts ...pulumi.ResourceOption) (*Environment, error) {
	if args == nil {
		args = &EnvironmentArgs{}
	}

	var resource Environment
	err := ctx.RegisterResource("aws-native:refactorspaces:Environment", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetEnvironment gets an existing Environment resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetEnvironment(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *EnvironmentState, opts ...pulumi.ResourceOption) (*Environment, error) {
	var resource Environment
	err := ctx.ReadResource("aws-native:refactorspaces:Environment", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Environment resources.
type environmentState struct {
}

type EnvironmentState struct {
}

func (EnvironmentState) ElementType() reflect.Type {
	return reflect.TypeOf((*environmentState)(nil)).Elem()
}

type environmentArgs struct {
	Description       *string                       `pulumi:"description"`
	Name              *string                       `pulumi:"name"`
	NetworkFabricType *EnvironmentNetworkFabricType `pulumi:"networkFabricType"`
	// Metadata that you can assign to help organize the frameworks that you create. Each tag is a key-value pair.
	Tags []EnvironmentTag `pulumi:"tags"`
}

// The set of arguments for constructing a Environment resource.
type EnvironmentArgs struct {
	Description       pulumi.StringPtrInput
	Name              pulumi.StringPtrInput
	NetworkFabricType EnvironmentNetworkFabricTypePtrInput
	// Metadata that you can assign to help organize the frameworks that you create. Each tag is a key-value pair.
	Tags EnvironmentTagArrayInput
}

func (EnvironmentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*environmentArgs)(nil)).Elem()
}

type EnvironmentInput interface {
	pulumi.Input

	ToEnvironmentOutput() EnvironmentOutput
	ToEnvironmentOutputWithContext(ctx context.Context) EnvironmentOutput
}

func (*Environment) ElementType() reflect.Type {
	return reflect.TypeOf((*Environment)(nil))
}

func (i *Environment) ToEnvironmentOutput() EnvironmentOutput {
	return i.ToEnvironmentOutputWithContext(context.Background())
}

func (i *Environment) ToEnvironmentOutputWithContext(ctx context.Context) EnvironmentOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EnvironmentOutput)
}

type EnvironmentOutput struct{ *pulumi.OutputState }

func (EnvironmentOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Environment)(nil))
}

func (o EnvironmentOutput) ToEnvironmentOutput() EnvironmentOutput {
	return o
}

func (o EnvironmentOutput) ToEnvironmentOutputWithContext(ctx context.Context) EnvironmentOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*EnvironmentInput)(nil)).Elem(), &Environment{})
	pulumi.RegisterOutputType(EnvironmentOutput{})
}
