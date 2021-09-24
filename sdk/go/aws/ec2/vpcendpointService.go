// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ec2

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::EC2::VPCEndpointService
//
// Deprecated: VPCEndpointService is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type VPCEndpointService struct {
	pulumi.CustomResourceState

	AcceptanceRequired      pulumi.BoolPtrOutput     `pulumi:"acceptanceRequired"`
	GatewayLoadBalancerArns pulumi.StringArrayOutput `pulumi:"gatewayLoadBalancerArns"`
	NetworkLoadBalancerArns pulumi.StringArrayOutput `pulumi:"networkLoadBalancerArns"`
}

// NewVPCEndpointService registers a new resource with the given unique name, arguments, and options.
func NewVPCEndpointService(ctx *pulumi.Context,
	name string, args *VPCEndpointServiceArgs, opts ...pulumi.ResourceOption) (*VPCEndpointService, error) {
	if args == nil {
		args = &VPCEndpointServiceArgs{}
	}

	var resource VPCEndpointService
	err := ctx.RegisterResource("aws-native:ec2:VPCEndpointService", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetVPCEndpointService gets an existing VPCEndpointService resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVPCEndpointService(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *VPCEndpointServiceState, opts ...pulumi.ResourceOption) (*VPCEndpointService, error) {
	var resource VPCEndpointService
	err := ctx.ReadResource("aws-native:ec2:VPCEndpointService", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering VPCEndpointService resources.
type vpcendpointServiceState struct {
}

type VPCEndpointServiceState struct {
}

func (VPCEndpointServiceState) ElementType() reflect.Type {
	return reflect.TypeOf((*vpcendpointServiceState)(nil)).Elem()
}

type vpcendpointServiceArgs struct {
	AcceptanceRequired      *bool    `pulumi:"acceptanceRequired"`
	GatewayLoadBalancerArns []string `pulumi:"gatewayLoadBalancerArns"`
	NetworkLoadBalancerArns []string `pulumi:"networkLoadBalancerArns"`
}

// The set of arguments for constructing a VPCEndpointService resource.
type VPCEndpointServiceArgs struct {
	AcceptanceRequired      pulumi.BoolPtrInput
	GatewayLoadBalancerArns pulumi.StringArrayInput
	NetworkLoadBalancerArns pulumi.StringArrayInput
}

func (VPCEndpointServiceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*vpcendpointServiceArgs)(nil)).Elem()
}

type VPCEndpointServiceInput interface {
	pulumi.Input

	ToVPCEndpointServiceOutput() VPCEndpointServiceOutput
	ToVPCEndpointServiceOutputWithContext(ctx context.Context) VPCEndpointServiceOutput
}

func (*VPCEndpointService) ElementType() reflect.Type {
	return reflect.TypeOf((*VPCEndpointService)(nil))
}

func (i *VPCEndpointService) ToVPCEndpointServiceOutput() VPCEndpointServiceOutput {
	return i.ToVPCEndpointServiceOutputWithContext(context.Background())
}

func (i *VPCEndpointService) ToVPCEndpointServiceOutputWithContext(ctx context.Context) VPCEndpointServiceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VPCEndpointServiceOutput)
}

type VPCEndpointServiceOutput struct{ *pulumi.OutputState }

func (VPCEndpointServiceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*VPCEndpointService)(nil))
}

func (o VPCEndpointServiceOutput) ToVPCEndpointServiceOutput() VPCEndpointServiceOutput {
	return o
}

func (o VPCEndpointServiceOutput) ToVPCEndpointServiceOutputWithContext(ctx context.Context) VPCEndpointServiceOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(VPCEndpointServiceOutput{})
}
