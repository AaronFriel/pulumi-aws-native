// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ec2

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::EC2::ClientVpnAuthorizationRule
//
// Deprecated: ClientVpnAuthorizationRule is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type ClientVpnAuthorizationRule struct {
	pulumi.CustomResourceState

	AccessGroupId       pulumi.StringPtrOutput `pulumi:"accessGroupId"`
	AuthorizeAllGroups  pulumi.BoolPtrOutput   `pulumi:"authorizeAllGroups"`
	ClientVpnEndpointId pulumi.StringOutput    `pulumi:"clientVpnEndpointId"`
	Description         pulumi.StringPtrOutput `pulumi:"description"`
	TargetNetworkCidr   pulumi.StringOutput    `pulumi:"targetNetworkCidr"`
}

// NewClientVpnAuthorizationRule registers a new resource with the given unique name, arguments, and options.
func NewClientVpnAuthorizationRule(ctx *pulumi.Context,
	name string, args *ClientVpnAuthorizationRuleArgs, opts ...pulumi.ResourceOption) (*ClientVpnAuthorizationRule, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ClientVpnEndpointId == nil {
		return nil, errors.New("invalid value for required argument 'ClientVpnEndpointId'")
	}
	if args.TargetNetworkCidr == nil {
		return nil, errors.New("invalid value for required argument 'TargetNetworkCidr'")
	}
	var resource ClientVpnAuthorizationRule
	err := ctx.RegisterResource("aws-native:ec2:ClientVpnAuthorizationRule", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetClientVpnAuthorizationRule gets an existing ClientVpnAuthorizationRule resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetClientVpnAuthorizationRule(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ClientVpnAuthorizationRuleState, opts ...pulumi.ResourceOption) (*ClientVpnAuthorizationRule, error) {
	var resource ClientVpnAuthorizationRule
	err := ctx.ReadResource("aws-native:ec2:ClientVpnAuthorizationRule", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ClientVpnAuthorizationRule resources.
type clientVpnAuthorizationRuleState struct {
}

type ClientVpnAuthorizationRuleState struct {
}

func (ClientVpnAuthorizationRuleState) ElementType() reflect.Type {
	return reflect.TypeOf((*clientVpnAuthorizationRuleState)(nil)).Elem()
}

type clientVpnAuthorizationRuleArgs struct {
	AccessGroupId       *string `pulumi:"accessGroupId"`
	AuthorizeAllGroups  *bool   `pulumi:"authorizeAllGroups"`
	ClientVpnEndpointId string  `pulumi:"clientVpnEndpointId"`
	Description         *string `pulumi:"description"`
	TargetNetworkCidr   string  `pulumi:"targetNetworkCidr"`
}

// The set of arguments for constructing a ClientVpnAuthorizationRule resource.
type ClientVpnAuthorizationRuleArgs struct {
	AccessGroupId       pulumi.StringPtrInput
	AuthorizeAllGroups  pulumi.BoolPtrInput
	ClientVpnEndpointId pulumi.StringInput
	Description         pulumi.StringPtrInput
	TargetNetworkCidr   pulumi.StringInput
}

func (ClientVpnAuthorizationRuleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*clientVpnAuthorizationRuleArgs)(nil)).Elem()
}

type ClientVpnAuthorizationRuleInput interface {
	pulumi.Input

	ToClientVpnAuthorizationRuleOutput() ClientVpnAuthorizationRuleOutput
	ToClientVpnAuthorizationRuleOutputWithContext(ctx context.Context) ClientVpnAuthorizationRuleOutput
}

func (*ClientVpnAuthorizationRule) ElementType() reflect.Type {
	return reflect.TypeOf((*ClientVpnAuthorizationRule)(nil))
}

func (i *ClientVpnAuthorizationRule) ToClientVpnAuthorizationRuleOutput() ClientVpnAuthorizationRuleOutput {
	return i.ToClientVpnAuthorizationRuleOutputWithContext(context.Background())
}

func (i *ClientVpnAuthorizationRule) ToClientVpnAuthorizationRuleOutputWithContext(ctx context.Context) ClientVpnAuthorizationRuleOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ClientVpnAuthorizationRuleOutput)
}

type ClientVpnAuthorizationRuleOutput struct{ *pulumi.OutputState }

func (ClientVpnAuthorizationRuleOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ClientVpnAuthorizationRule)(nil))
}

func (o ClientVpnAuthorizationRuleOutput) ToClientVpnAuthorizationRuleOutput() ClientVpnAuthorizationRuleOutput {
	return o
}

func (o ClientVpnAuthorizationRuleOutput) ToClientVpnAuthorizationRuleOutputWithContext(ctx context.Context) ClientVpnAuthorizationRuleOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ClientVpnAuthorizationRuleOutput{})
}
