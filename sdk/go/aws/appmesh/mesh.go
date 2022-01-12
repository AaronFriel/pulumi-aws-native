// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package appmesh

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::AppMesh::Mesh
//
// Deprecated: Mesh is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type Mesh struct {
	pulumi.CustomResourceState

	Arn           pulumi.StringOutput    `pulumi:"arn"`
	MeshName      pulumi.StringPtrOutput `pulumi:"meshName"`
	MeshOwner     pulumi.StringOutput    `pulumi:"meshOwner"`
	ResourceOwner pulumi.StringOutput    `pulumi:"resourceOwner"`
	Spec          MeshSpecPtrOutput      `pulumi:"spec"`
	Tags          MeshTagArrayOutput     `pulumi:"tags"`
	Uid           pulumi.StringOutput    `pulumi:"uid"`
}

// NewMesh registers a new resource with the given unique name, arguments, and options.
func NewMesh(ctx *pulumi.Context,
	name string, args *MeshArgs, opts ...pulumi.ResourceOption) (*Mesh, error) {
	if args == nil {
		args = &MeshArgs{}
	}

	var resource Mesh
	err := ctx.RegisterResource("aws-native:appmesh:Mesh", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetMesh gets an existing Mesh resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMesh(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *MeshState, opts ...pulumi.ResourceOption) (*Mesh, error) {
	var resource Mesh
	err := ctx.ReadResource("aws-native:appmesh:Mesh", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Mesh resources.
type meshState struct {
}

type MeshState struct {
}

func (MeshState) ElementType() reflect.Type {
	return reflect.TypeOf((*meshState)(nil)).Elem()
}

type meshArgs struct {
	MeshName *string   `pulumi:"meshName"`
	Spec     *MeshSpec `pulumi:"spec"`
	Tags     []MeshTag `pulumi:"tags"`
}

// The set of arguments for constructing a Mesh resource.
type MeshArgs struct {
	MeshName pulumi.StringPtrInput
	Spec     MeshSpecPtrInput
	Tags     MeshTagArrayInput
}

func (MeshArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*meshArgs)(nil)).Elem()
}

type MeshInput interface {
	pulumi.Input

	ToMeshOutput() MeshOutput
	ToMeshOutputWithContext(ctx context.Context) MeshOutput
}

func (*Mesh) ElementType() reflect.Type {
	return reflect.TypeOf((*Mesh)(nil))
}

func (i *Mesh) ToMeshOutput() MeshOutput {
	return i.ToMeshOutputWithContext(context.Background())
}

func (i *Mesh) ToMeshOutputWithContext(ctx context.Context) MeshOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MeshOutput)
}

type MeshOutput struct{ *pulumi.OutputState }

func (MeshOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Mesh)(nil))
}

func (o MeshOutput) ToMeshOutput() MeshOutput {
	return o
}

func (o MeshOutput) ToMeshOutputWithContext(ctx context.Context) MeshOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*MeshInput)(nil)).Elem(), &Mesh{})
	pulumi.RegisterOutputType(MeshOutput{})
}
