// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package networkmanager

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// The AWS::NetworkManager::TransitGatewayRegistration type registers a transit gateway in your global network. The transit gateway can be in any AWS Region, but it must be owned by the same AWS account that owns the global network. You cannot register a transit gateway in more than one global network.
type TransitGatewayRegistration struct {
	pulumi.CustomResourceState

	// The ID of the global network.
	GlobalNetworkId pulumi.StringOutput `pulumi:"globalNetworkId"`
	// The Amazon Resource Name (ARN) of the transit gateway.
	TransitGatewayArn pulumi.StringOutput `pulumi:"transitGatewayArn"`
}

// NewTransitGatewayRegistration registers a new resource with the given unique name, arguments, and options.
func NewTransitGatewayRegistration(ctx *pulumi.Context,
	name string, args *TransitGatewayRegistrationArgs, opts ...pulumi.ResourceOption) (*TransitGatewayRegistration, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.GlobalNetworkId == nil {
		return nil, errors.New("invalid value for required argument 'GlobalNetworkId'")
	}
	if args.TransitGatewayArn == nil {
		return nil, errors.New("invalid value for required argument 'TransitGatewayArn'")
	}
	var resource TransitGatewayRegistration
	err := ctx.RegisterResource("aws-native:networkmanager:TransitGatewayRegistration", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetTransitGatewayRegistration gets an existing TransitGatewayRegistration resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTransitGatewayRegistration(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TransitGatewayRegistrationState, opts ...pulumi.ResourceOption) (*TransitGatewayRegistration, error) {
	var resource TransitGatewayRegistration
	err := ctx.ReadResource("aws-native:networkmanager:TransitGatewayRegistration", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering TransitGatewayRegistration resources.
type transitGatewayRegistrationState struct {
}

type TransitGatewayRegistrationState struct {
}

func (TransitGatewayRegistrationState) ElementType() reflect.Type {
	return reflect.TypeOf((*transitGatewayRegistrationState)(nil)).Elem()
}

type transitGatewayRegistrationArgs struct {
	// The ID of the global network.
	GlobalNetworkId string `pulumi:"globalNetworkId"`
	// The Amazon Resource Name (ARN) of the transit gateway.
	TransitGatewayArn string `pulumi:"transitGatewayArn"`
}

// The set of arguments for constructing a TransitGatewayRegistration resource.
type TransitGatewayRegistrationArgs struct {
	// The ID of the global network.
	GlobalNetworkId pulumi.StringInput
	// The Amazon Resource Name (ARN) of the transit gateway.
	TransitGatewayArn pulumi.StringInput
}

func (TransitGatewayRegistrationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*transitGatewayRegistrationArgs)(nil)).Elem()
}

type TransitGatewayRegistrationInput interface {
	pulumi.Input

	ToTransitGatewayRegistrationOutput() TransitGatewayRegistrationOutput
	ToTransitGatewayRegistrationOutputWithContext(ctx context.Context) TransitGatewayRegistrationOutput
}

func (*TransitGatewayRegistration) ElementType() reflect.Type {
	return reflect.TypeOf((*TransitGatewayRegistration)(nil))
}

func (i *TransitGatewayRegistration) ToTransitGatewayRegistrationOutput() TransitGatewayRegistrationOutput {
	return i.ToTransitGatewayRegistrationOutputWithContext(context.Background())
}

func (i *TransitGatewayRegistration) ToTransitGatewayRegistrationOutputWithContext(ctx context.Context) TransitGatewayRegistrationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TransitGatewayRegistrationOutput)
}

type TransitGatewayRegistrationOutput struct{ *pulumi.OutputState }

func (TransitGatewayRegistrationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*TransitGatewayRegistration)(nil))
}

func (o TransitGatewayRegistrationOutput) ToTransitGatewayRegistrationOutput() TransitGatewayRegistrationOutput {
	return o
}

func (o TransitGatewayRegistrationOutput) ToTransitGatewayRegistrationOutputWithContext(ctx context.Context) TransitGatewayRegistrationOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(TransitGatewayRegistrationOutput{})
}
