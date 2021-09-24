// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package secretsmanager

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::SecretsManager::RotationSchedule
//
// Deprecated: RotationSchedule is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type RotationSchedule struct {
	pulumi.CustomResourceState

	HostedRotationLambda RotationScheduleHostedRotationLambdaPtrOutput `pulumi:"hostedRotationLambda"`
	RotationLambdaARN    pulumi.StringPtrOutput                        `pulumi:"rotationLambdaARN"`
	RotationRules        RotationScheduleRotationRulesPtrOutput        `pulumi:"rotationRules"`
	SecretId             pulumi.StringOutput                           `pulumi:"secretId"`
}

// NewRotationSchedule registers a new resource with the given unique name, arguments, and options.
func NewRotationSchedule(ctx *pulumi.Context,
	name string, args *RotationScheduleArgs, opts ...pulumi.ResourceOption) (*RotationSchedule, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.SecretId == nil {
		return nil, errors.New("invalid value for required argument 'SecretId'")
	}
	var resource RotationSchedule
	err := ctx.RegisterResource("aws-native:secretsmanager:RotationSchedule", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRotationSchedule gets an existing RotationSchedule resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRotationSchedule(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RotationScheduleState, opts ...pulumi.ResourceOption) (*RotationSchedule, error) {
	var resource RotationSchedule
	err := ctx.ReadResource("aws-native:secretsmanager:RotationSchedule", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering RotationSchedule resources.
type rotationScheduleState struct {
}

type RotationScheduleState struct {
}

func (RotationScheduleState) ElementType() reflect.Type {
	return reflect.TypeOf((*rotationScheduleState)(nil)).Elem()
}

type rotationScheduleArgs struct {
	HostedRotationLambda *RotationScheduleHostedRotationLambda `pulumi:"hostedRotationLambda"`
	RotationLambdaARN    *string                               `pulumi:"rotationLambdaARN"`
	RotationRules        *RotationScheduleRotationRules        `pulumi:"rotationRules"`
	SecretId             string                                `pulumi:"secretId"`
}

// The set of arguments for constructing a RotationSchedule resource.
type RotationScheduleArgs struct {
	HostedRotationLambda RotationScheduleHostedRotationLambdaPtrInput
	RotationLambdaARN    pulumi.StringPtrInput
	RotationRules        RotationScheduleRotationRulesPtrInput
	SecretId             pulumi.StringInput
}

func (RotationScheduleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*rotationScheduleArgs)(nil)).Elem()
}

type RotationScheduleInput interface {
	pulumi.Input

	ToRotationScheduleOutput() RotationScheduleOutput
	ToRotationScheduleOutputWithContext(ctx context.Context) RotationScheduleOutput
}

func (*RotationSchedule) ElementType() reflect.Type {
	return reflect.TypeOf((*RotationSchedule)(nil))
}

func (i *RotationSchedule) ToRotationScheduleOutput() RotationScheduleOutput {
	return i.ToRotationScheduleOutputWithContext(context.Background())
}

func (i *RotationSchedule) ToRotationScheduleOutputWithContext(ctx context.Context) RotationScheduleOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RotationScheduleOutput)
}

type RotationScheduleOutput struct{ *pulumi.OutputState }

func (RotationScheduleOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*RotationSchedule)(nil))
}

func (o RotationScheduleOutput) ToRotationScheduleOutput() RotationScheduleOutput {
	return o
}

func (o RotationScheduleOutput) ToRotationScheduleOutputWithContext(ctx context.Context) RotationScheduleOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(RotationScheduleOutput{})
}
