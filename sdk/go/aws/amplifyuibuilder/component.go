// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package amplifyuibuilder

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Definition of AWS::AmplifyUIBuilder::Component Resource Type
type Component struct {
	pulumi.CustomResourceState

	AppId                pulumi.StringOutput                    `pulumi:"appId"`
	BindingProperties    ComponentBindingPropertiesPtrOutput    `pulumi:"bindingProperties"`
	Children             ComponentChildArrayOutput              `pulumi:"children"`
	CollectionProperties ComponentCollectionPropertiesPtrOutput `pulumi:"collectionProperties"`
	ComponentType        pulumi.StringPtrOutput                 `pulumi:"componentType"`
	CreatedAt            pulumi.StringOutput                    `pulumi:"createdAt"`
	EnvironmentName      pulumi.StringOutput                    `pulumi:"environmentName"`
	ModifiedAt           pulumi.StringOutput                    `pulumi:"modifiedAt"`
	Name                 pulumi.StringPtrOutput                 `pulumi:"name"`
	Overrides            ComponentOverridesPtrOutput            `pulumi:"overrides"`
	Properties           ComponentPropertiesPtrOutput           `pulumi:"properties"`
	SourceId             pulumi.StringPtrOutput                 `pulumi:"sourceId"`
	Tags                 ComponentTagsPtrOutput                 `pulumi:"tags"`
	Variants             ComponentVariantArrayOutput            `pulumi:"variants"`
}

// NewComponent registers a new resource with the given unique name, arguments, and options.
func NewComponent(ctx *pulumi.Context,
	name string, args *ComponentArgs, opts ...pulumi.ResourceOption) (*Component, error) {
	if args == nil {
		args = &ComponentArgs{}
	}

	var resource Component
	err := ctx.RegisterResource("aws-native:amplifyuibuilder:Component", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetComponent gets an existing Component resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetComponent(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ComponentState, opts ...pulumi.ResourceOption) (*Component, error) {
	var resource Component
	err := ctx.ReadResource("aws-native:amplifyuibuilder:Component", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Component resources.
type componentState struct {
}

type ComponentState struct {
}

func (ComponentState) ElementType() reflect.Type {
	return reflect.TypeOf((*componentState)(nil)).Elem()
}

type componentArgs struct {
	BindingProperties    *ComponentBindingProperties    `pulumi:"bindingProperties"`
	Children             []ComponentChild               `pulumi:"children"`
	CollectionProperties *ComponentCollectionProperties `pulumi:"collectionProperties"`
	ComponentType        *string                        `pulumi:"componentType"`
	Name                 *string                        `pulumi:"name"`
	Overrides            *ComponentOverrides            `pulumi:"overrides"`
	Properties           *ComponentProperties           `pulumi:"properties"`
	SourceId             *string                        `pulumi:"sourceId"`
	Tags                 *ComponentTags                 `pulumi:"tags"`
	Variants             []ComponentVariant             `pulumi:"variants"`
}

// The set of arguments for constructing a Component resource.
type ComponentArgs struct {
	BindingProperties    ComponentBindingPropertiesPtrInput
	Children             ComponentChildArrayInput
	CollectionProperties ComponentCollectionPropertiesPtrInput
	ComponentType        pulumi.StringPtrInput
	Name                 pulumi.StringPtrInput
	Overrides            ComponentOverridesPtrInput
	Properties           ComponentPropertiesPtrInput
	SourceId             pulumi.StringPtrInput
	Tags                 ComponentTagsPtrInput
	Variants             ComponentVariantArrayInput
}

func (ComponentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*componentArgs)(nil)).Elem()
}

type ComponentInput interface {
	pulumi.Input

	ToComponentOutput() ComponentOutput
	ToComponentOutputWithContext(ctx context.Context) ComponentOutput
}

func (*Component) ElementType() reflect.Type {
	return reflect.TypeOf((*Component)(nil))
}

func (i *Component) ToComponentOutput() ComponentOutput {
	return i.ToComponentOutputWithContext(context.Background())
}

func (i *Component) ToComponentOutputWithContext(ctx context.Context) ComponentOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ComponentOutput)
}

type ComponentOutput struct{ *pulumi.OutputState }

func (ComponentOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Component)(nil))
}

func (o ComponentOutput) ToComponentOutput() ComponentOutput {
	return o
}

func (o ComponentOutput) ToComponentOutputWithContext(ctx context.Context) ComponentOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ComponentInput)(nil)).Elem(), &Component{})
	pulumi.RegisterOutputType(ComponentOutput{})
}
