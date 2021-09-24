// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ec2

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::EC2::ClientVpnEndpoint
//
// Deprecated: ClientVpnEndpoint is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.
type ClientVpnEndpoint struct {
	pulumi.CustomResourceState

	AuthenticationOptions ClientVpnEndpointClientAuthenticationRequestArrayOutput `pulumi:"authenticationOptions"`
	ClientCidrBlock       pulumi.StringOutput                                     `pulumi:"clientCidrBlock"`
	ClientConnectOptions  ClientVpnEndpointClientConnectOptionsPtrOutput          `pulumi:"clientConnectOptions"`
	ConnectionLogOptions  ClientVpnEndpointConnectionLogOptionsOutput             `pulumi:"connectionLogOptions"`
	Description           pulumi.StringPtrOutput                                  `pulumi:"description"`
	DnsServers            pulumi.StringArrayOutput                                `pulumi:"dnsServers"`
	SecurityGroupIds      pulumi.StringArrayOutput                                `pulumi:"securityGroupIds"`
	SelfServicePortal     pulumi.StringPtrOutput                                  `pulumi:"selfServicePortal"`
	ServerCertificateArn  pulumi.StringOutput                                     `pulumi:"serverCertificateArn"`
	SplitTunnel           pulumi.BoolPtrOutput                                    `pulumi:"splitTunnel"`
	TagSpecifications     ClientVpnEndpointTagSpecificationArrayOutput            `pulumi:"tagSpecifications"`
	TransportProtocol     pulumi.StringPtrOutput                                  `pulumi:"transportProtocol"`
	VpcId                 pulumi.StringPtrOutput                                  `pulumi:"vpcId"`
	VpnPort               pulumi.IntPtrOutput                                     `pulumi:"vpnPort"`
}

// NewClientVpnEndpoint registers a new resource with the given unique name, arguments, and options.
func NewClientVpnEndpoint(ctx *pulumi.Context,
	name string, args *ClientVpnEndpointArgs, opts ...pulumi.ResourceOption) (*ClientVpnEndpoint, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AuthenticationOptions == nil {
		return nil, errors.New("invalid value for required argument 'AuthenticationOptions'")
	}
	if args.ClientCidrBlock == nil {
		return nil, errors.New("invalid value for required argument 'ClientCidrBlock'")
	}
	if args.ConnectionLogOptions == nil {
		return nil, errors.New("invalid value for required argument 'ConnectionLogOptions'")
	}
	if args.ServerCertificateArn == nil {
		return nil, errors.New("invalid value for required argument 'ServerCertificateArn'")
	}
	var resource ClientVpnEndpoint
	err := ctx.RegisterResource("aws-native:ec2:ClientVpnEndpoint", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetClientVpnEndpoint gets an existing ClientVpnEndpoint resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetClientVpnEndpoint(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ClientVpnEndpointState, opts ...pulumi.ResourceOption) (*ClientVpnEndpoint, error) {
	var resource ClientVpnEndpoint
	err := ctx.ReadResource("aws-native:ec2:ClientVpnEndpoint", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ClientVpnEndpoint resources.
type clientVpnEndpointState struct {
}

type ClientVpnEndpointState struct {
}

func (ClientVpnEndpointState) ElementType() reflect.Type {
	return reflect.TypeOf((*clientVpnEndpointState)(nil)).Elem()
}

type clientVpnEndpointArgs struct {
	AuthenticationOptions []ClientVpnEndpointClientAuthenticationRequest `pulumi:"authenticationOptions"`
	ClientCidrBlock       string                                         `pulumi:"clientCidrBlock"`
	ClientConnectOptions  *ClientVpnEndpointClientConnectOptions         `pulumi:"clientConnectOptions"`
	ConnectionLogOptions  ClientVpnEndpointConnectionLogOptions          `pulumi:"connectionLogOptions"`
	Description           *string                                        `pulumi:"description"`
	DnsServers            []string                                       `pulumi:"dnsServers"`
	SecurityGroupIds      []string                                       `pulumi:"securityGroupIds"`
	SelfServicePortal     *string                                        `pulumi:"selfServicePortal"`
	ServerCertificateArn  string                                         `pulumi:"serverCertificateArn"`
	SplitTunnel           *bool                                          `pulumi:"splitTunnel"`
	TagSpecifications     []ClientVpnEndpointTagSpecification            `pulumi:"tagSpecifications"`
	TransportProtocol     *string                                        `pulumi:"transportProtocol"`
	VpcId                 *string                                        `pulumi:"vpcId"`
	VpnPort               *int                                           `pulumi:"vpnPort"`
}

// The set of arguments for constructing a ClientVpnEndpoint resource.
type ClientVpnEndpointArgs struct {
	AuthenticationOptions ClientVpnEndpointClientAuthenticationRequestArrayInput
	ClientCidrBlock       pulumi.StringInput
	ClientConnectOptions  ClientVpnEndpointClientConnectOptionsPtrInput
	ConnectionLogOptions  ClientVpnEndpointConnectionLogOptionsInput
	Description           pulumi.StringPtrInput
	DnsServers            pulumi.StringArrayInput
	SecurityGroupIds      pulumi.StringArrayInput
	SelfServicePortal     pulumi.StringPtrInput
	ServerCertificateArn  pulumi.StringInput
	SplitTunnel           pulumi.BoolPtrInput
	TagSpecifications     ClientVpnEndpointTagSpecificationArrayInput
	TransportProtocol     pulumi.StringPtrInput
	VpcId                 pulumi.StringPtrInput
	VpnPort               pulumi.IntPtrInput
}

func (ClientVpnEndpointArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*clientVpnEndpointArgs)(nil)).Elem()
}

type ClientVpnEndpointInput interface {
	pulumi.Input

	ToClientVpnEndpointOutput() ClientVpnEndpointOutput
	ToClientVpnEndpointOutputWithContext(ctx context.Context) ClientVpnEndpointOutput
}

func (*ClientVpnEndpoint) ElementType() reflect.Type {
	return reflect.TypeOf((*ClientVpnEndpoint)(nil))
}

func (i *ClientVpnEndpoint) ToClientVpnEndpointOutput() ClientVpnEndpointOutput {
	return i.ToClientVpnEndpointOutputWithContext(context.Background())
}

func (i *ClientVpnEndpoint) ToClientVpnEndpointOutputWithContext(ctx context.Context) ClientVpnEndpointOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ClientVpnEndpointOutput)
}

type ClientVpnEndpointOutput struct{ *pulumi.OutputState }

func (ClientVpnEndpointOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ClientVpnEndpoint)(nil))
}

func (o ClientVpnEndpointOutput) ToClientVpnEndpointOutput() ClientVpnEndpointOutput {
	return o
}

func (o ClientVpnEndpointOutput) ToClientVpnEndpointOutputWithContext(ctx context.Context) ClientVpnEndpointOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ClientVpnEndpointOutput{})
}