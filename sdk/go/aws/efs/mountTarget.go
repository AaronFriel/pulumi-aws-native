// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package efs

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::EFS::MountTarget
type MountTarget struct {
	pulumi.CustomResourceState

	FileSystemId   pulumi.StringOutput      `pulumi:"fileSystemId"`
	IpAddress      pulumi.StringPtrOutput   `pulumi:"ipAddress"`
	SecurityGroups pulumi.StringArrayOutput `pulumi:"securityGroups"`
	SubnetId       pulumi.StringOutput      `pulumi:"subnetId"`
}

// NewMountTarget registers a new resource with the given unique name, arguments, and options.
func NewMountTarget(ctx *pulumi.Context,
	name string, args *MountTargetArgs, opts ...pulumi.ResourceOption) (*MountTarget, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.FileSystemId == nil {
		return nil, errors.New("invalid value for required argument 'FileSystemId'")
	}
	if args.SecurityGroups == nil {
		return nil, errors.New("invalid value for required argument 'SecurityGroups'")
	}
	if args.SubnetId == nil {
		return nil, errors.New("invalid value for required argument 'SubnetId'")
	}
	var resource MountTarget
	err := ctx.RegisterResource("aws-native:efs:MountTarget", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetMountTarget gets an existing MountTarget resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMountTarget(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *MountTargetState, opts ...pulumi.ResourceOption) (*MountTarget, error) {
	var resource MountTarget
	err := ctx.ReadResource("aws-native:efs:MountTarget", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering MountTarget resources.
type mountTargetState struct {
}

type MountTargetState struct {
}

func (MountTargetState) ElementType() reflect.Type {
	return reflect.TypeOf((*mountTargetState)(nil)).Elem()
}

type mountTargetArgs struct {
	FileSystemId   string   `pulumi:"fileSystemId"`
	IpAddress      *string  `pulumi:"ipAddress"`
	SecurityGroups []string `pulumi:"securityGroups"`
	SubnetId       string   `pulumi:"subnetId"`
}

// The set of arguments for constructing a MountTarget resource.
type MountTargetArgs struct {
	FileSystemId   pulumi.StringInput
	IpAddress      pulumi.StringPtrInput
	SecurityGroups pulumi.StringArrayInput
	SubnetId       pulumi.StringInput
}

func (MountTargetArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*mountTargetArgs)(nil)).Elem()
}

type MountTargetInput interface {
	pulumi.Input

	ToMountTargetOutput() MountTargetOutput
	ToMountTargetOutputWithContext(ctx context.Context) MountTargetOutput
}

func (*MountTarget) ElementType() reflect.Type {
	return reflect.TypeOf((*MountTarget)(nil))
}

func (i *MountTarget) ToMountTargetOutput() MountTargetOutput {
	return i.ToMountTargetOutputWithContext(context.Background())
}

func (i *MountTarget) ToMountTargetOutputWithContext(ctx context.Context) MountTargetOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MountTargetOutput)
}

type MountTargetOutput struct{ *pulumi.OutputState }

func (MountTargetOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*MountTarget)(nil))
}

func (o MountTargetOutput) ToMountTargetOutput() MountTargetOutput {
	return o
}

func (o MountTargetOutput) ToMountTargetOutputWithContext(ctx context.Context) MountTargetOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*MountTargetInput)(nil)).Elem(), &MountTarget{})
	pulumi.RegisterOutputType(MountTargetOutput{})
}
