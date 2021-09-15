// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package sagemaker

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::SageMaker::ModelBiasJobDefinition
type ModelBiasJobDefinition struct {
	pulumi.CustomResourceState

	// The time at which the job definition was created.
	CreationTime pulumi.StringOutput `pulumi:"creationTime"`
	// The Amazon Resource Name (ARN) of job definition.
	JobDefinitionArn          pulumi.StringOutput                                    `pulumi:"jobDefinitionArn"`
	JobDefinitionName         pulumi.StringPtrOutput                                 `pulumi:"jobDefinitionName"`
	JobResources              ModelBiasJobDefinitionMonitoringResourcesOutput        `pulumi:"jobResources"`
	ModelBiasAppSpecification ModelBiasJobDefinitionModelBiasAppSpecificationOutput  `pulumi:"modelBiasAppSpecification"`
	ModelBiasBaselineConfig   ModelBiasJobDefinitionModelBiasBaselineConfigPtrOutput `pulumi:"modelBiasBaselineConfig"`
	ModelBiasJobInput         ModelBiasJobDefinitionModelBiasJobInputOutput          `pulumi:"modelBiasJobInput"`
	ModelBiasJobOutputConfig  ModelBiasJobDefinitionMonitoringOutputConfigOutput     `pulumi:"modelBiasJobOutputConfig"`
	NetworkConfig             ModelBiasJobDefinitionNetworkConfigPtrOutput           `pulumi:"networkConfig"`
	// The Amazon Resource Name (ARN) of an IAM role that Amazon SageMaker can assume to perform tasks on your behalf.
	RoleArn           pulumi.StringOutput                              `pulumi:"roleArn"`
	StoppingCondition ModelBiasJobDefinitionStoppingConditionPtrOutput `pulumi:"stoppingCondition"`
	// An array of key-value pairs to apply to this resource.
	Tags ModelBiasJobDefinitionTagArrayOutput `pulumi:"tags"`
}

// NewModelBiasJobDefinition registers a new resource with the given unique name, arguments, and options.
func NewModelBiasJobDefinition(ctx *pulumi.Context,
	name string, args *ModelBiasJobDefinitionArgs, opts ...pulumi.ResourceOption) (*ModelBiasJobDefinition, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.JobResources == nil {
		return nil, errors.New("invalid value for required argument 'JobResources'")
	}
	if args.ModelBiasAppSpecification == nil {
		return nil, errors.New("invalid value for required argument 'ModelBiasAppSpecification'")
	}
	if args.ModelBiasJobInput == nil {
		return nil, errors.New("invalid value for required argument 'ModelBiasJobInput'")
	}
	if args.ModelBiasJobOutputConfig == nil {
		return nil, errors.New("invalid value for required argument 'ModelBiasJobOutputConfig'")
	}
	if args.RoleArn == nil {
		return nil, errors.New("invalid value for required argument 'RoleArn'")
	}
	var resource ModelBiasJobDefinition
	err := ctx.RegisterResource("aws-native:sagemaker:ModelBiasJobDefinition", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetModelBiasJobDefinition gets an existing ModelBiasJobDefinition resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetModelBiasJobDefinition(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ModelBiasJobDefinitionState, opts ...pulumi.ResourceOption) (*ModelBiasJobDefinition, error) {
	var resource ModelBiasJobDefinition
	err := ctx.ReadResource("aws-native:sagemaker:ModelBiasJobDefinition", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ModelBiasJobDefinition resources.
type modelBiasJobDefinitionState struct {
}

type ModelBiasJobDefinitionState struct {
}

func (ModelBiasJobDefinitionState) ElementType() reflect.Type {
	return reflect.TypeOf((*modelBiasJobDefinitionState)(nil)).Elem()
}

type modelBiasJobDefinitionArgs struct {
	JobDefinitionName         *string                                         `pulumi:"jobDefinitionName"`
	JobResources              ModelBiasJobDefinitionMonitoringResources       `pulumi:"jobResources"`
	ModelBiasAppSpecification ModelBiasJobDefinitionModelBiasAppSpecification `pulumi:"modelBiasAppSpecification"`
	ModelBiasBaselineConfig   *ModelBiasJobDefinitionModelBiasBaselineConfig  `pulumi:"modelBiasBaselineConfig"`
	ModelBiasJobInput         ModelBiasJobDefinitionModelBiasJobInput         `pulumi:"modelBiasJobInput"`
	ModelBiasJobOutputConfig  ModelBiasJobDefinitionMonitoringOutputConfig    `pulumi:"modelBiasJobOutputConfig"`
	NetworkConfig             *ModelBiasJobDefinitionNetworkConfig            `pulumi:"networkConfig"`
	// The Amazon Resource Name (ARN) of an IAM role that Amazon SageMaker can assume to perform tasks on your behalf.
	RoleArn           string                                   `pulumi:"roleArn"`
	StoppingCondition *ModelBiasJobDefinitionStoppingCondition `pulumi:"stoppingCondition"`
	// An array of key-value pairs to apply to this resource.
	Tags []ModelBiasJobDefinitionTag `pulumi:"tags"`
}

// The set of arguments for constructing a ModelBiasJobDefinition resource.
type ModelBiasJobDefinitionArgs struct {
	JobDefinitionName         pulumi.StringPtrInput
	JobResources              ModelBiasJobDefinitionMonitoringResourcesInput
	ModelBiasAppSpecification ModelBiasJobDefinitionModelBiasAppSpecificationInput
	ModelBiasBaselineConfig   ModelBiasJobDefinitionModelBiasBaselineConfigPtrInput
	ModelBiasJobInput         ModelBiasJobDefinitionModelBiasJobInputInput
	ModelBiasJobOutputConfig  ModelBiasJobDefinitionMonitoringOutputConfigInput
	NetworkConfig             ModelBiasJobDefinitionNetworkConfigPtrInput
	// The Amazon Resource Name (ARN) of an IAM role that Amazon SageMaker can assume to perform tasks on your behalf.
	RoleArn           pulumi.StringInput
	StoppingCondition ModelBiasJobDefinitionStoppingConditionPtrInput
	// An array of key-value pairs to apply to this resource.
	Tags ModelBiasJobDefinitionTagArrayInput
}

func (ModelBiasJobDefinitionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*modelBiasJobDefinitionArgs)(nil)).Elem()
}

type ModelBiasJobDefinitionInput interface {
	pulumi.Input

	ToModelBiasJobDefinitionOutput() ModelBiasJobDefinitionOutput
	ToModelBiasJobDefinitionOutputWithContext(ctx context.Context) ModelBiasJobDefinitionOutput
}

func (*ModelBiasJobDefinition) ElementType() reflect.Type {
	return reflect.TypeOf((*ModelBiasJobDefinition)(nil))
}

func (i *ModelBiasJobDefinition) ToModelBiasJobDefinitionOutput() ModelBiasJobDefinitionOutput {
	return i.ToModelBiasJobDefinitionOutputWithContext(context.Background())
}

func (i *ModelBiasJobDefinition) ToModelBiasJobDefinitionOutputWithContext(ctx context.Context) ModelBiasJobDefinitionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ModelBiasJobDefinitionOutput)
}

type ModelBiasJobDefinitionOutput struct{ *pulumi.OutputState }

func (ModelBiasJobDefinitionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ModelBiasJobDefinition)(nil))
}

func (o ModelBiasJobDefinitionOutput) ToModelBiasJobDefinitionOutput() ModelBiasJobDefinitionOutput {
	return o
}

func (o ModelBiasJobDefinitionOutput) ToModelBiasJobDefinitionOutputWithContext(ctx context.Context) ModelBiasJobDefinitionOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ModelBiasJobDefinitionOutput{})
}
