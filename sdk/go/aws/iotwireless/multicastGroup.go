// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package iotwireless

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Create and manage Multicast groups.
type MulticastGroup struct {
	pulumi.CustomResourceState

	// Multicast group arn. Returned after successful create.
	Arn pulumi.StringOutput `pulumi:"arn"`
	// Wireless device to associate. Only for update request.
	AssociateWirelessDevice pulumi.StringPtrOutput `pulumi:"associateWirelessDevice"`
	// Multicast group description
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Wireless device to disassociate. Only for update request.
	DisassociateWirelessDevice pulumi.StringPtrOutput `pulumi:"disassociateWirelessDevice"`
	// Multicast group LoRaWAN
	LoRaWAN MulticastGroupLoRaWANOutput `pulumi:"loRaWAN"`
	// Name of Multicast group
	Name pulumi.StringPtrOutput `pulumi:"name"`
	// Multicast group status. Returned after successful read.
	Status pulumi.StringOutput `pulumi:"status"`
	// A list of key-value pairs that contain metadata for the Multicast group.
	Tags MulticastGroupTagArrayOutput `pulumi:"tags"`
}

// NewMulticastGroup registers a new resource with the given unique name, arguments, and options.
func NewMulticastGroup(ctx *pulumi.Context,
	name string, args *MulticastGroupArgs, opts ...pulumi.ResourceOption) (*MulticastGroup, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.LoRaWAN == nil {
		return nil, errors.New("invalid value for required argument 'LoRaWAN'")
	}
	var resource MulticastGroup
	err := ctx.RegisterResource("aws-native:iotwireless:MulticastGroup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetMulticastGroup gets an existing MulticastGroup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMulticastGroup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *MulticastGroupState, opts ...pulumi.ResourceOption) (*MulticastGroup, error) {
	var resource MulticastGroup
	err := ctx.ReadResource("aws-native:iotwireless:MulticastGroup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering MulticastGroup resources.
type multicastGroupState struct {
}

type MulticastGroupState struct {
}

func (MulticastGroupState) ElementType() reflect.Type {
	return reflect.TypeOf((*multicastGroupState)(nil)).Elem()
}

type multicastGroupArgs struct {
	// Wireless device to associate. Only for update request.
	AssociateWirelessDevice *string `pulumi:"associateWirelessDevice"`
	// Multicast group description
	Description *string `pulumi:"description"`
	// Wireless device to disassociate. Only for update request.
	DisassociateWirelessDevice *string `pulumi:"disassociateWirelessDevice"`
	// Multicast group LoRaWAN
	LoRaWAN MulticastGroupLoRaWAN `pulumi:"loRaWAN"`
	// Name of Multicast group
	Name *string `pulumi:"name"`
	// A list of key-value pairs that contain metadata for the Multicast group.
	Tags []MulticastGroupTag `pulumi:"tags"`
}

// The set of arguments for constructing a MulticastGroup resource.
type MulticastGroupArgs struct {
	// Wireless device to associate. Only for update request.
	AssociateWirelessDevice pulumi.StringPtrInput
	// Multicast group description
	Description pulumi.StringPtrInput
	// Wireless device to disassociate. Only for update request.
	DisassociateWirelessDevice pulumi.StringPtrInput
	// Multicast group LoRaWAN
	LoRaWAN MulticastGroupLoRaWANInput
	// Name of Multicast group
	Name pulumi.StringPtrInput
	// A list of key-value pairs that contain metadata for the Multicast group.
	Tags MulticastGroupTagArrayInput
}

func (MulticastGroupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*multicastGroupArgs)(nil)).Elem()
}

type MulticastGroupInput interface {
	pulumi.Input

	ToMulticastGroupOutput() MulticastGroupOutput
	ToMulticastGroupOutputWithContext(ctx context.Context) MulticastGroupOutput
}

func (*MulticastGroup) ElementType() reflect.Type {
	return reflect.TypeOf((*MulticastGroup)(nil))
}

func (i *MulticastGroup) ToMulticastGroupOutput() MulticastGroupOutput {
	return i.ToMulticastGroupOutputWithContext(context.Background())
}

func (i *MulticastGroup) ToMulticastGroupOutputWithContext(ctx context.Context) MulticastGroupOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MulticastGroupOutput)
}

type MulticastGroupOutput struct{ *pulumi.OutputState }

func (MulticastGroupOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*MulticastGroup)(nil))
}

func (o MulticastGroupOutput) ToMulticastGroupOutput() MulticastGroupOutput {
	return o
}

func (o MulticastGroupOutput) ToMulticastGroupOutputWithContext(ctx context.Context) MulticastGroupOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*MulticastGroupInput)(nil)).Elem(), &MulticastGroup{})
	pulumi.RegisterOutputType(MulticastGroupOutput{})
}
