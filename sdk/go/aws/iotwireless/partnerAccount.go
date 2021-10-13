// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package iotwireless

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Create and manage partner account
//
// Deprecated: PartnerAccount is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type PartnerAccount struct {
	pulumi.CustomResourceState

	// Whether the partner account is linked to the AWS account.
	AccountLinked pulumi.BoolPtrOutput `pulumi:"accountLinked"`
	// PartnerAccount arn. Returned after successful create.
	Arn pulumi.StringOutput `pulumi:"arn"`
	// The fingerprint of the Sidewalk application server private key.
	Fingerprint pulumi.StringPtrOutput `pulumi:"fingerprint"`
	// The partner account ID to disassociate from the AWS account
	PartnerAccountId pulumi.StringPtrOutput `pulumi:"partnerAccountId"`
	// The partner type
	PartnerType PartnerAccountPartnerTypePtrOutput `pulumi:"partnerType"`
	// The Sidewalk account credentials.
	Sidewalk PartnerAccountSidewalkAccountInfoPtrOutput `pulumi:"sidewalk"`
	// The Sidewalk account credentials.
	SidewalkResponse PartnerAccountSidewalkAccountInfoWithFingerprintOutput `pulumi:"sidewalkResponse"`
	// The Sidewalk account credentials.
	SidewalkUpdate PartnerAccountSidewalkUpdateAccountPtrOutput `pulumi:"sidewalkUpdate"`
	// A list of key-value pairs that contain metadata for the destination.
	Tags PartnerAccountTagArrayOutput `pulumi:"tags"`
}

// NewPartnerAccount registers a new resource with the given unique name, arguments, and options.
func NewPartnerAccount(ctx *pulumi.Context,
	name string, args *PartnerAccountArgs, opts ...pulumi.ResourceOption) (*PartnerAccount, error) {
	if args == nil {
		args = &PartnerAccountArgs{}
	}

	var resource PartnerAccount
	err := ctx.RegisterResource("aws-native:iotwireless:PartnerAccount", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPartnerAccount gets an existing PartnerAccount resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPartnerAccount(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PartnerAccountState, opts ...pulumi.ResourceOption) (*PartnerAccount, error) {
	var resource PartnerAccount
	err := ctx.ReadResource("aws-native:iotwireless:PartnerAccount", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering PartnerAccount resources.
type partnerAccountState struct {
}

type PartnerAccountState struct {
}

func (PartnerAccountState) ElementType() reflect.Type {
	return reflect.TypeOf((*partnerAccountState)(nil)).Elem()
}

type partnerAccountArgs struct {
	// Whether the partner account is linked to the AWS account.
	AccountLinked *bool `pulumi:"accountLinked"`
	// The fingerprint of the Sidewalk application server private key.
	Fingerprint *string `pulumi:"fingerprint"`
	// The partner account ID to disassociate from the AWS account
	PartnerAccountId *string `pulumi:"partnerAccountId"`
	// The partner type
	PartnerType *PartnerAccountPartnerType `pulumi:"partnerType"`
	// The Sidewalk account credentials.
	Sidewalk *PartnerAccountSidewalkAccountInfo `pulumi:"sidewalk"`
	// The Sidewalk account credentials.
	SidewalkUpdate *PartnerAccountSidewalkUpdateAccount `pulumi:"sidewalkUpdate"`
	// A list of key-value pairs that contain metadata for the destination.
	Tags []PartnerAccountTag `pulumi:"tags"`
}

// The set of arguments for constructing a PartnerAccount resource.
type PartnerAccountArgs struct {
	// Whether the partner account is linked to the AWS account.
	AccountLinked pulumi.BoolPtrInput
	// The fingerprint of the Sidewalk application server private key.
	Fingerprint pulumi.StringPtrInput
	// The partner account ID to disassociate from the AWS account
	PartnerAccountId pulumi.StringPtrInput
	// The partner type
	PartnerType PartnerAccountPartnerTypePtrInput
	// The Sidewalk account credentials.
	Sidewalk PartnerAccountSidewalkAccountInfoPtrInput
	// The Sidewalk account credentials.
	SidewalkUpdate PartnerAccountSidewalkUpdateAccountPtrInput
	// A list of key-value pairs that contain metadata for the destination.
	Tags PartnerAccountTagArrayInput
}

func (PartnerAccountArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*partnerAccountArgs)(nil)).Elem()
}

type PartnerAccountInput interface {
	pulumi.Input

	ToPartnerAccountOutput() PartnerAccountOutput
	ToPartnerAccountOutputWithContext(ctx context.Context) PartnerAccountOutput
}

func (*PartnerAccount) ElementType() reflect.Type {
	return reflect.TypeOf((*PartnerAccount)(nil))
}

func (i *PartnerAccount) ToPartnerAccountOutput() PartnerAccountOutput {
	return i.ToPartnerAccountOutputWithContext(context.Background())
}

func (i *PartnerAccount) ToPartnerAccountOutputWithContext(ctx context.Context) PartnerAccountOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PartnerAccountOutput)
}

type PartnerAccountOutput struct{ *pulumi.OutputState }

func (PartnerAccountOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*PartnerAccount)(nil))
}

func (o PartnerAccountOutput) ToPartnerAccountOutput() PartnerAccountOutput {
	return o
}

func (o PartnerAccountOutput) ToPartnerAccountOutputWithContext(ctx context.Context) PartnerAccountOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(PartnerAccountOutput{})
}
