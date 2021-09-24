// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package iot

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::IoT::PolicyPrincipalAttachment
//
// Deprecated: PolicyPrincipalAttachment is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.
type PolicyPrincipalAttachment struct {
	pulumi.CustomResourceState

	PolicyName pulumi.StringOutput `pulumi:"policyName"`
	Principal  pulumi.StringOutput `pulumi:"principal"`
}

// NewPolicyPrincipalAttachment registers a new resource with the given unique name, arguments, and options.
func NewPolicyPrincipalAttachment(ctx *pulumi.Context,
	name string, args *PolicyPrincipalAttachmentArgs, opts ...pulumi.ResourceOption) (*PolicyPrincipalAttachment, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.PolicyName == nil {
		return nil, errors.New("invalid value for required argument 'PolicyName'")
	}
	if args.Principal == nil {
		return nil, errors.New("invalid value for required argument 'Principal'")
	}
	var resource PolicyPrincipalAttachment
	err := ctx.RegisterResource("aws-native:iot:PolicyPrincipalAttachment", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPolicyPrincipalAttachment gets an existing PolicyPrincipalAttachment resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPolicyPrincipalAttachment(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PolicyPrincipalAttachmentState, opts ...pulumi.ResourceOption) (*PolicyPrincipalAttachment, error) {
	var resource PolicyPrincipalAttachment
	err := ctx.ReadResource("aws-native:iot:PolicyPrincipalAttachment", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering PolicyPrincipalAttachment resources.
type policyPrincipalAttachmentState struct {
}

type PolicyPrincipalAttachmentState struct {
}

func (PolicyPrincipalAttachmentState) ElementType() reflect.Type {
	return reflect.TypeOf((*policyPrincipalAttachmentState)(nil)).Elem()
}

type policyPrincipalAttachmentArgs struct {
	PolicyName string `pulumi:"policyName"`
	Principal  string `pulumi:"principal"`
}

// The set of arguments for constructing a PolicyPrincipalAttachment resource.
type PolicyPrincipalAttachmentArgs struct {
	PolicyName pulumi.StringInput
	Principal  pulumi.StringInput
}

func (PolicyPrincipalAttachmentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*policyPrincipalAttachmentArgs)(nil)).Elem()
}

type PolicyPrincipalAttachmentInput interface {
	pulumi.Input

	ToPolicyPrincipalAttachmentOutput() PolicyPrincipalAttachmentOutput
	ToPolicyPrincipalAttachmentOutputWithContext(ctx context.Context) PolicyPrincipalAttachmentOutput
}

func (*PolicyPrincipalAttachment) ElementType() reflect.Type {
	return reflect.TypeOf((*PolicyPrincipalAttachment)(nil))
}

func (i *PolicyPrincipalAttachment) ToPolicyPrincipalAttachmentOutput() PolicyPrincipalAttachmentOutput {
	return i.ToPolicyPrincipalAttachmentOutputWithContext(context.Background())
}

func (i *PolicyPrincipalAttachment) ToPolicyPrincipalAttachmentOutputWithContext(ctx context.Context) PolicyPrincipalAttachmentOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PolicyPrincipalAttachmentOutput)
}

type PolicyPrincipalAttachmentOutput struct{ *pulumi.OutputState }

func (PolicyPrincipalAttachmentOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*PolicyPrincipalAttachment)(nil))
}

func (o PolicyPrincipalAttachmentOutput) ToPolicyPrincipalAttachmentOutput() PolicyPrincipalAttachmentOutput {
	return o
}

func (o PolicyPrincipalAttachmentOutput) ToPolicyPrincipalAttachmentOutputWithContext(ctx context.Context) PolicyPrincipalAttachmentOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(PolicyPrincipalAttachmentOutput{})
}