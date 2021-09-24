// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package appmesh

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::AppMesh::VirtualRouter
//
// Deprecated: VirtualRouter is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type VirtualRouter struct {
	pulumi.CustomResourceState

	Arn               pulumi.StringOutput                  `pulumi:"arn"`
	MeshName          pulumi.StringOutput                  `pulumi:"meshName"`
	MeshOwner         pulumi.StringPtrOutput               `pulumi:"meshOwner"`
	ResourceOwner     pulumi.StringOutput                  `pulumi:"resourceOwner"`
	Spec              VirtualRouterVirtualRouterSpecOutput `pulumi:"spec"`
	Tags              VirtualRouterTagArrayOutput          `pulumi:"tags"`
	Uid               pulumi.StringOutput                  `pulumi:"uid"`
	VirtualRouterName pulumi.StringPtrOutput               `pulumi:"virtualRouterName"`
}

// NewVirtualRouter registers a new resource with the given unique name, arguments, and options.
func NewVirtualRouter(ctx *pulumi.Context,
	name string, args *VirtualRouterArgs, opts ...pulumi.ResourceOption) (*VirtualRouter, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.MeshName == nil {
		return nil, errors.New("invalid value for required argument 'MeshName'")
	}
	if args.Spec == nil {
		return nil, errors.New("invalid value for required argument 'Spec'")
	}
	var resource VirtualRouter
	err := ctx.RegisterResource("aws-native:appmesh:VirtualRouter", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetVirtualRouter gets an existing VirtualRouter resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVirtualRouter(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *VirtualRouterState, opts ...pulumi.ResourceOption) (*VirtualRouter, error) {
	var resource VirtualRouter
	err := ctx.ReadResource("aws-native:appmesh:VirtualRouter", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering VirtualRouter resources.
type virtualRouterState struct {
}

type VirtualRouterState struct {
}

func (VirtualRouterState) ElementType() reflect.Type {
	return reflect.TypeOf((*virtualRouterState)(nil)).Elem()
}

type virtualRouterArgs struct {
	MeshName          string                         `pulumi:"meshName"`
	MeshOwner         *string                        `pulumi:"meshOwner"`
	Spec              VirtualRouterVirtualRouterSpec `pulumi:"spec"`
	Tags              []VirtualRouterTag             `pulumi:"tags"`
	VirtualRouterName *string                        `pulumi:"virtualRouterName"`
}

// The set of arguments for constructing a VirtualRouter resource.
type VirtualRouterArgs struct {
	MeshName          pulumi.StringInput
	MeshOwner         pulumi.StringPtrInput
	Spec              VirtualRouterVirtualRouterSpecInput
	Tags              VirtualRouterTagArrayInput
	VirtualRouterName pulumi.StringPtrInput
}

func (VirtualRouterArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*virtualRouterArgs)(nil)).Elem()
}

type VirtualRouterInput interface {
	pulumi.Input

	ToVirtualRouterOutput() VirtualRouterOutput
	ToVirtualRouterOutputWithContext(ctx context.Context) VirtualRouterOutput
}

func (*VirtualRouter) ElementType() reflect.Type {
	return reflect.TypeOf((*VirtualRouter)(nil))
}

func (i *VirtualRouter) ToVirtualRouterOutput() VirtualRouterOutput {
	return i.ToVirtualRouterOutputWithContext(context.Background())
}

func (i *VirtualRouter) ToVirtualRouterOutputWithContext(ctx context.Context) VirtualRouterOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VirtualRouterOutput)
}

type VirtualRouterOutput struct{ *pulumi.OutputState }

func (VirtualRouterOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*VirtualRouter)(nil))
}

func (o VirtualRouterOutput) ToVirtualRouterOutput() VirtualRouterOutput {
	return o
}

func (o VirtualRouterOutput) ToVirtualRouterOutputWithContext(ctx context.Context) VirtualRouterOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(VirtualRouterOutput{})
}
