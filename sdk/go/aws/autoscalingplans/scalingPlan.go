// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package autoscalingplans

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::AutoScalingPlans::ScalingPlan
//
// Deprecated: ScalingPlan is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type ScalingPlan struct {
	pulumi.CustomResourceState

	ApplicationSource   ScalingPlanApplicationSourceOutput       `pulumi:"applicationSource"`
	ScalingInstructions ScalingPlanScalingInstructionArrayOutput `pulumi:"scalingInstructions"`
	ScalingPlanName     pulumi.StringOutput                      `pulumi:"scalingPlanName"`
	ScalingPlanVersion  pulumi.StringOutput                      `pulumi:"scalingPlanVersion"`
}

// NewScalingPlan registers a new resource with the given unique name, arguments, and options.
func NewScalingPlan(ctx *pulumi.Context,
	name string, args *ScalingPlanArgs, opts ...pulumi.ResourceOption) (*ScalingPlan, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ApplicationSource == nil {
		return nil, errors.New("invalid value for required argument 'ApplicationSource'")
	}
	if args.ScalingInstructions == nil {
		return nil, errors.New("invalid value for required argument 'ScalingInstructions'")
	}
	var resource ScalingPlan
	err := ctx.RegisterResource("aws-native:autoscalingplans:ScalingPlan", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetScalingPlan gets an existing ScalingPlan resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetScalingPlan(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ScalingPlanState, opts ...pulumi.ResourceOption) (*ScalingPlan, error) {
	var resource ScalingPlan
	err := ctx.ReadResource("aws-native:autoscalingplans:ScalingPlan", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ScalingPlan resources.
type scalingPlanState struct {
}

type ScalingPlanState struct {
}

func (ScalingPlanState) ElementType() reflect.Type {
	return reflect.TypeOf((*scalingPlanState)(nil)).Elem()
}

type scalingPlanArgs struct {
	ApplicationSource   ScalingPlanApplicationSource    `pulumi:"applicationSource"`
	ScalingInstructions []ScalingPlanScalingInstruction `pulumi:"scalingInstructions"`
}

// The set of arguments for constructing a ScalingPlan resource.
type ScalingPlanArgs struct {
	ApplicationSource   ScalingPlanApplicationSourceInput
	ScalingInstructions ScalingPlanScalingInstructionArrayInput
}

func (ScalingPlanArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*scalingPlanArgs)(nil)).Elem()
}

type ScalingPlanInput interface {
	pulumi.Input

	ToScalingPlanOutput() ScalingPlanOutput
	ToScalingPlanOutputWithContext(ctx context.Context) ScalingPlanOutput
}

func (*ScalingPlan) ElementType() reflect.Type {
	return reflect.TypeOf((*ScalingPlan)(nil))
}

func (i *ScalingPlan) ToScalingPlanOutput() ScalingPlanOutput {
	return i.ToScalingPlanOutputWithContext(context.Background())
}

func (i *ScalingPlan) ToScalingPlanOutputWithContext(ctx context.Context) ScalingPlanOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ScalingPlanOutput)
}

type ScalingPlanOutput struct{ *pulumi.OutputState }

func (ScalingPlanOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ScalingPlan)(nil))
}

func (o ScalingPlanOutput) ToScalingPlanOutput() ScalingPlanOutput {
	return o
}

func (o ScalingPlanOutput) ToScalingPlanOutputWithContext(ctx context.Context) ScalingPlanOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ScalingPlanOutput{})
}
