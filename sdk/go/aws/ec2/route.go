// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ec2

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::EC2::Route
//
// Deprecated: Route is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type Route struct {
	pulumi.CustomResourceState

	CarrierGatewayId            pulumi.StringPtrOutput `pulumi:"carrierGatewayId"`
	DestinationCidrBlock        pulumi.StringPtrOutput `pulumi:"destinationCidrBlock"`
	DestinationIpv6CidrBlock    pulumi.StringPtrOutput `pulumi:"destinationIpv6CidrBlock"`
	EgressOnlyInternetGatewayId pulumi.StringPtrOutput `pulumi:"egressOnlyInternetGatewayId"`
	GatewayId                   pulumi.StringPtrOutput `pulumi:"gatewayId"`
	InstanceId                  pulumi.StringPtrOutput `pulumi:"instanceId"`
	LocalGatewayId              pulumi.StringPtrOutput `pulumi:"localGatewayId"`
	NatGatewayId                pulumi.StringPtrOutput `pulumi:"natGatewayId"`
	NetworkInterfaceId          pulumi.StringPtrOutput `pulumi:"networkInterfaceId"`
	RouteTableId                pulumi.StringOutput    `pulumi:"routeTableId"`
	TransitGatewayId            pulumi.StringPtrOutput `pulumi:"transitGatewayId"`
	VpcEndpointId               pulumi.StringPtrOutput `pulumi:"vpcEndpointId"`
	VpcPeeringConnectionId      pulumi.StringPtrOutput `pulumi:"vpcPeeringConnectionId"`
}

// NewRoute registers a new resource with the given unique name, arguments, and options.
func NewRoute(ctx *pulumi.Context,
	name string, args *RouteArgs, opts ...pulumi.ResourceOption) (*Route, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.RouteTableId == nil {
		return nil, errors.New("invalid value for required argument 'RouteTableId'")
	}
	var resource Route
	err := ctx.RegisterResource("aws-native:ec2:Route", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRoute gets an existing Route resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRoute(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RouteState, opts ...pulumi.ResourceOption) (*Route, error) {
	var resource Route
	err := ctx.ReadResource("aws-native:ec2:Route", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Route resources.
type routeState struct {
}

type RouteState struct {
}

func (RouteState) ElementType() reflect.Type {
	return reflect.TypeOf((*routeState)(nil)).Elem()
}

type routeArgs struct {
	CarrierGatewayId            *string `pulumi:"carrierGatewayId"`
	DestinationCidrBlock        *string `pulumi:"destinationCidrBlock"`
	DestinationIpv6CidrBlock    *string `pulumi:"destinationIpv6CidrBlock"`
	EgressOnlyInternetGatewayId *string `pulumi:"egressOnlyInternetGatewayId"`
	GatewayId                   *string `pulumi:"gatewayId"`
	InstanceId                  *string `pulumi:"instanceId"`
	LocalGatewayId              *string `pulumi:"localGatewayId"`
	NatGatewayId                *string `pulumi:"natGatewayId"`
	NetworkInterfaceId          *string `pulumi:"networkInterfaceId"`
	RouteTableId                string  `pulumi:"routeTableId"`
	TransitGatewayId            *string `pulumi:"transitGatewayId"`
	VpcEndpointId               *string `pulumi:"vpcEndpointId"`
	VpcPeeringConnectionId      *string `pulumi:"vpcPeeringConnectionId"`
}

// The set of arguments for constructing a Route resource.
type RouteArgs struct {
	CarrierGatewayId            pulumi.StringPtrInput
	DestinationCidrBlock        pulumi.StringPtrInput
	DestinationIpv6CidrBlock    pulumi.StringPtrInput
	EgressOnlyInternetGatewayId pulumi.StringPtrInput
	GatewayId                   pulumi.StringPtrInput
	InstanceId                  pulumi.StringPtrInput
	LocalGatewayId              pulumi.StringPtrInput
	NatGatewayId                pulumi.StringPtrInput
	NetworkInterfaceId          pulumi.StringPtrInput
	RouteTableId                pulumi.StringInput
	TransitGatewayId            pulumi.StringPtrInput
	VpcEndpointId               pulumi.StringPtrInput
	VpcPeeringConnectionId      pulumi.StringPtrInput
}

func (RouteArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*routeArgs)(nil)).Elem()
}

type RouteInput interface {
	pulumi.Input

	ToRouteOutput() RouteOutput
	ToRouteOutputWithContext(ctx context.Context) RouteOutput
}

func (*Route) ElementType() reflect.Type {
	return reflect.TypeOf((*Route)(nil))
}

func (i *Route) ToRouteOutput() RouteOutput {
	return i.ToRouteOutputWithContext(context.Background())
}

func (i *Route) ToRouteOutputWithContext(ctx context.Context) RouteOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RouteOutput)
}

type RouteOutput struct{ *pulumi.OutputState }

func (RouteOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Route)(nil))
}

func (o RouteOutput) ToRouteOutput() RouteOutput {
	return o
}

func (o RouteOutput) ToRouteOutputWithContext(ctx context.Context) RouteOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(RouteOutput{})
}
