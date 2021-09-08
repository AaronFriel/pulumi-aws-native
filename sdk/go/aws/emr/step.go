// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package emr

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-step.html
type Step struct {
	pulumi.CustomResourceState

	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-step.html#cfn-elasticmapreduce-step-actiononfailure
	ActionOnFailure pulumi.StringOutput `pulumi:"actionOnFailure"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-step.html#cfn-elasticmapreduce-step-hadoopjarstep
	HadoopJarStep StepHadoopJarStepConfigOutput `pulumi:"hadoopJarStep"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-step.html#cfn-elasticmapreduce-step-jobflowid
	JobFlowId pulumi.StringOutput `pulumi:"jobFlowId"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-step.html#cfn-elasticmapreduce-step-name
	Name pulumi.StringOutput `pulumi:"name"`
}

// NewStep registers a new resource with the given unique name, arguments, and options.
func NewStep(ctx *pulumi.Context,
	name string, args *StepArgs, opts ...pulumi.ResourceOption) (*Step, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ActionOnFailure == nil {
		return nil, errors.New("invalid value for required argument 'ActionOnFailure'")
	}
	if args.HadoopJarStep == nil {
		return nil, errors.New("invalid value for required argument 'HadoopJarStep'")
	}
	if args.JobFlowId == nil {
		return nil, errors.New("invalid value for required argument 'JobFlowId'")
	}
	if args.Name == nil {
		return nil, errors.New("invalid value for required argument 'Name'")
	}
	var resource Step
	err := ctx.RegisterResource("aws-native:emr:Step", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetStep gets an existing Step resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetStep(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *StepState, opts ...pulumi.ResourceOption) (*Step, error) {
	var resource Step
	err := ctx.ReadResource("aws-native:emr:Step", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Step resources.
type stepState struct {
}

type StepState struct {
}

func (StepState) ElementType() reflect.Type {
	return reflect.TypeOf((*stepState)(nil)).Elem()
}

type stepArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-step.html#cfn-elasticmapreduce-step-actiononfailure
	ActionOnFailure string `pulumi:"actionOnFailure"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-step.html#cfn-elasticmapreduce-step-hadoopjarstep
	HadoopJarStep StepHadoopJarStepConfig `pulumi:"hadoopJarStep"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-step.html#cfn-elasticmapreduce-step-jobflowid
	JobFlowId string `pulumi:"jobFlowId"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-step.html#cfn-elasticmapreduce-step-name
	Name string `pulumi:"name"`
}

// The set of arguments for constructing a Step resource.
type StepArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-step.html#cfn-elasticmapreduce-step-actiononfailure
	ActionOnFailure pulumi.StringInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-step.html#cfn-elasticmapreduce-step-hadoopjarstep
	HadoopJarStep StepHadoopJarStepConfigInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-step.html#cfn-elasticmapreduce-step-jobflowid
	JobFlowId pulumi.StringInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-step.html#cfn-elasticmapreduce-step-name
	Name pulumi.StringInput
}

func (StepArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*stepArgs)(nil)).Elem()
}

type StepInput interface {
	pulumi.Input

	ToStepOutput() StepOutput
	ToStepOutputWithContext(ctx context.Context) StepOutput
}

func (*Step) ElementType() reflect.Type {
	return reflect.TypeOf((*Step)(nil))
}

func (i *Step) ToStepOutput() StepOutput {
	return i.ToStepOutputWithContext(context.Background())
}

func (i *Step) ToStepOutputWithContext(ctx context.Context) StepOutput {
	return pulumi.ToOutputWithContext(ctx, i).(StepOutput)
}

type StepOutput struct{ *pulumi.OutputState }

func (StepOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Step)(nil))
}

func (o StepOutput) ToStepOutput() StepOutput {
	return o
}

func (o StepOutput) ToStepOutputWithContext(ctx context.Context) StepOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(StepOutput{})
}