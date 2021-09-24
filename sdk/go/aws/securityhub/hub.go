// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package securityhub

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::SecurityHub::Hub
//
// Deprecated: Hub is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.
type Hub struct {
	pulumi.CustomResourceState

	Tags pulumi.AnyOutput `pulumi:"tags"`
}

// NewHub registers a new resource with the given unique name, arguments, and options.
func NewHub(ctx *pulumi.Context,
	name string, args *HubArgs, opts ...pulumi.ResourceOption) (*Hub, error) {
	if args == nil {
		args = &HubArgs{}
	}

	var resource Hub
	err := ctx.RegisterResource("aws-native:securityhub:Hub", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetHub gets an existing Hub resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetHub(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *HubState, opts ...pulumi.ResourceOption) (*Hub, error) {
	var resource Hub
	err := ctx.ReadResource("aws-native:securityhub:Hub", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Hub resources.
type hubState struct {
}

type HubState struct {
}

func (HubState) ElementType() reflect.Type {
	return reflect.TypeOf((*hubState)(nil)).Elem()
}

type hubArgs struct {
	Tags interface{} `pulumi:"tags"`
}

// The set of arguments for constructing a Hub resource.
type HubArgs struct {
	Tags pulumi.Input
}

func (HubArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*hubArgs)(nil)).Elem()
}

type HubInput interface {
	pulumi.Input

	ToHubOutput() HubOutput
	ToHubOutputWithContext(ctx context.Context) HubOutput
}

func (*Hub) ElementType() reflect.Type {
	return reflect.TypeOf((*Hub)(nil))
}

func (i *Hub) ToHubOutput() HubOutput {
	return i.ToHubOutputWithContext(context.Background())
}

func (i *Hub) ToHubOutputWithContext(ctx context.Context) HubOutput {
	return pulumi.ToOutputWithContext(ctx, i).(HubOutput)
}

type HubOutput struct{ *pulumi.OutputState }

func (HubOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Hub)(nil))
}

func (o HubOutput) ToHubOutput() HubOutput {
	return o
}

func (o HubOutput) ToHubOutputWithContext(ctx context.Context) HubOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(HubOutput{})
}