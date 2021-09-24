// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ec2

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::EC2::NetworkAcl
//
// Deprecated: NetworkAcl is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type NetworkAcl struct {
	pulumi.CustomResourceState

	// The tags to assign to the network ACL.
	Tags NetworkAclTagArrayOutput `pulumi:"tags"`
	// The ID of the VPC.
	VpcId pulumi.StringOutput `pulumi:"vpcId"`
}

// NewNetworkAcl registers a new resource with the given unique name, arguments, and options.
func NewNetworkAcl(ctx *pulumi.Context,
	name string, args *NetworkAclArgs, opts ...pulumi.ResourceOption) (*NetworkAcl, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.VpcId == nil {
		return nil, errors.New("invalid value for required argument 'VpcId'")
	}
	var resource NetworkAcl
	err := ctx.RegisterResource("aws-native:ec2:NetworkAcl", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetNetworkAcl gets an existing NetworkAcl resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetNetworkAcl(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *NetworkAclState, opts ...pulumi.ResourceOption) (*NetworkAcl, error) {
	var resource NetworkAcl
	err := ctx.ReadResource("aws-native:ec2:NetworkAcl", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering NetworkAcl resources.
type networkAclState struct {
}

type NetworkAclState struct {
}

func (NetworkAclState) ElementType() reflect.Type {
	return reflect.TypeOf((*networkAclState)(nil)).Elem()
}

type networkAclArgs struct {
	// The tags to assign to the network ACL.
	Tags []NetworkAclTag `pulumi:"tags"`
	// The ID of the VPC.
	VpcId string `pulumi:"vpcId"`
}

// The set of arguments for constructing a NetworkAcl resource.
type NetworkAclArgs struct {
	// The tags to assign to the network ACL.
	Tags NetworkAclTagArrayInput
	// The ID of the VPC.
	VpcId pulumi.StringInput
}

func (NetworkAclArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*networkAclArgs)(nil)).Elem()
}

type NetworkAclInput interface {
	pulumi.Input

	ToNetworkAclOutput() NetworkAclOutput
	ToNetworkAclOutputWithContext(ctx context.Context) NetworkAclOutput
}

func (*NetworkAcl) ElementType() reflect.Type {
	return reflect.TypeOf((*NetworkAcl)(nil))
}

func (i *NetworkAcl) ToNetworkAclOutput() NetworkAclOutput {
	return i.ToNetworkAclOutputWithContext(context.Background())
}

func (i *NetworkAcl) ToNetworkAclOutputWithContext(ctx context.Context) NetworkAclOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NetworkAclOutput)
}

type NetworkAclOutput struct{ *pulumi.OutputState }

func (NetworkAclOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*NetworkAcl)(nil))
}

func (o NetworkAclOutput) ToNetworkAclOutput() NetworkAclOutput {
	return o
}

func (o NetworkAclOutput) ToNetworkAclOutputWithContext(ctx context.Context) NetworkAclOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(NetworkAclOutput{})
}
