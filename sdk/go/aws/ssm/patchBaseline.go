// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ssm

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::SSM::PatchBaseline
//
// Deprecated: PatchBaseline is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type PatchBaseline struct {
	pulumi.CustomResourceState

	ApprovalRules                    PatchBaselineRuleGroupPtrOutput        `pulumi:"approvalRules"`
	ApprovedPatches                  pulumi.StringArrayOutput               `pulumi:"approvedPatches"`
	ApprovedPatchesComplianceLevel   pulumi.StringPtrOutput                 `pulumi:"approvedPatchesComplianceLevel"`
	ApprovedPatchesEnableNonSecurity pulumi.BoolPtrOutput                   `pulumi:"approvedPatchesEnableNonSecurity"`
	Description                      pulumi.StringPtrOutput                 `pulumi:"description"`
	GlobalFilters                    PatchBaselinePatchFilterGroupPtrOutput `pulumi:"globalFilters"`
	Name                             pulumi.StringOutput                    `pulumi:"name"`
	OperatingSystem                  pulumi.StringPtrOutput                 `pulumi:"operatingSystem"`
	PatchGroups                      pulumi.StringArrayOutput               `pulumi:"patchGroups"`
	RejectedPatches                  pulumi.StringArrayOutput               `pulumi:"rejectedPatches"`
	RejectedPatchesAction            pulumi.StringPtrOutput                 `pulumi:"rejectedPatchesAction"`
	Sources                          PatchBaselinePatchSourceArrayOutput    `pulumi:"sources"`
	Tags                             PatchBaselineTagArrayOutput            `pulumi:"tags"`
}

// NewPatchBaseline registers a new resource with the given unique name, arguments, and options.
func NewPatchBaseline(ctx *pulumi.Context,
	name string, args *PatchBaselineArgs, opts ...pulumi.ResourceOption) (*PatchBaseline, error) {
	if args == nil {
		args = &PatchBaselineArgs{}
	}

	var resource PatchBaseline
	err := ctx.RegisterResource("aws-native:ssm:PatchBaseline", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPatchBaseline gets an existing PatchBaseline resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPatchBaseline(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PatchBaselineState, opts ...pulumi.ResourceOption) (*PatchBaseline, error) {
	var resource PatchBaseline
	err := ctx.ReadResource("aws-native:ssm:PatchBaseline", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering PatchBaseline resources.
type patchBaselineState struct {
}

type PatchBaselineState struct {
}

func (PatchBaselineState) ElementType() reflect.Type {
	return reflect.TypeOf((*patchBaselineState)(nil)).Elem()
}

type patchBaselineArgs struct {
	ApprovalRules                    *PatchBaselineRuleGroup        `pulumi:"approvalRules"`
	ApprovedPatches                  []string                       `pulumi:"approvedPatches"`
	ApprovedPatchesComplianceLevel   *string                        `pulumi:"approvedPatchesComplianceLevel"`
	ApprovedPatchesEnableNonSecurity *bool                          `pulumi:"approvedPatchesEnableNonSecurity"`
	Description                      *string                        `pulumi:"description"`
	GlobalFilters                    *PatchBaselinePatchFilterGroup `pulumi:"globalFilters"`
	Name                             *string                        `pulumi:"name"`
	OperatingSystem                  *string                        `pulumi:"operatingSystem"`
	PatchGroups                      []string                       `pulumi:"patchGroups"`
	RejectedPatches                  []string                       `pulumi:"rejectedPatches"`
	RejectedPatchesAction            *string                        `pulumi:"rejectedPatchesAction"`
	Sources                          []PatchBaselinePatchSource     `pulumi:"sources"`
	Tags                             []PatchBaselineTag             `pulumi:"tags"`
}

// The set of arguments for constructing a PatchBaseline resource.
type PatchBaselineArgs struct {
	ApprovalRules                    PatchBaselineRuleGroupPtrInput
	ApprovedPatches                  pulumi.StringArrayInput
	ApprovedPatchesComplianceLevel   pulumi.StringPtrInput
	ApprovedPatchesEnableNonSecurity pulumi.BoolPtrInput
	Description                      pulumi.StringPtrInput
	GlobalFilters                    PatchBaselinePatchFilterGroupPtrInput
	Name                             pulumi.StringPtrInput
	OperatingSystem                  pulumi.StringPtrInput
	PatchGroups                      pulumi.StringArrayInput
	RejectedPatches                  pulumi.StringArrayInput
	RejectedPatchesAction            pulumi.StringPtrInput
	Sources                          PatchBaselinePatchSourceArrayInput
	Tags                             PatchBaselineTagArrayInput
}

func (PatchBaselineArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*patchBaselineArgs)(nil)).Elem()
}

type PatchBaselineInput interface {
	pulumi.Input

	ToPatchBaselineOutput() PatchBaselineOutput
	ToPatchBaselineOutputWithContext(ctx context.Context) PatchBaselineOutput
}

func (*PatchBaseline) ElementType() reflect.Type {
	return reflect.TypeOf((*PatchBaseline)(nil))
}

func (i *PatchBaseline) ToPatchBaselineOutput() PatchBaselineOutput {
	return i.ToPatchBaselineOutputWithContext(context.Background())
}

func (i *PatchBaseline) ToPatchBaselineOutputWithContext(ctx context.Context) PatchBaselineOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PatchBaselineOutput)
}

type PatchBaselineOutput struct{ *pulumi.OutputState }

func (PatchBaselineOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*PatchBaseline)(nil))
}

func (o PatchBaselineOutput) ToPatchBaselineOutput() PatchBaselineOutput {
	return o
}

func (o PatchBaselineOutput) ToPatchBaselineOutputWithContext(ctx context.Context) PatchBaselineOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*PatchBaselineInput)(nil)).Elem(), &PatchBaseline{})
	pulumi.RegisterOutputType(PatchBaselineOutput{})
}
