// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package sagemaker

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::SageMaker::DataQualityJobDefinition
type DataQualityJobDefinition struct {
	pulumi.CustomResourceState

	// The time at which the job definition was created.
	CreationTime                pulumi.StringOutput                                        `pulumi:"creationTime"`
	DataQualityAppSpecification DataQualityJobDefinitionDataQualityAppSpecificationOutput  `pulumi:"dataQualityAppSpecification"`
	DataQualityBaselineConfig   DataQualityJobDefinitionDataQualityBaselineConfigPtrOutput `pulumi:"dataQualityBaselineConfig"`
	DataQualityJobInput         DataQualityJobDefinitionDataQualityJobInputOutput          `pulumi:"dataQualityJobInput"`
	DataQualityJobOutputConfig  DataQualityJobDefinitionMonitoringOutputConfigOutput       `pulumi:"dataQualityJobOutputConfig"`
	// The Amazon Resource Name (ARN) of job definition.
	JobDefinitionArn  pulumi.StringOutput                               `pulumi:"jobDefinitionArn"`
	JobDefinitionName pulumi.StringPtrOutput                            `pulumi:"jobDefinitionName"`
	JobResources      DataQualityJobDefinitionMonitoringResourcesOutput `pulumi:"jobResources"`
	NetworkConfig     DataQualityJobDefinitionNetworkConfigPtrOutput    `pulumi:"networkConfig"`
	// The Amazon Resource Name (ARN) of an IAM role that Amazon SageMaker can assume to perform tasks on your behalf.
	RoleArn           pulumi.StringOutput                                `pulumi:"roleArn"`
	StoppingCondition DataQualityJobDefinitionStoppingConditionPtrOutput `pulumi:"stoppingCondition"`
	// An array of key-value pairs to apply to this resource.
	Tags DataQualityJobDefinitionTagArrayOutput `pulumi:"tags"`
}

// NewDataQualityJobDefinition registers a new resource with the given unique name, arguments, and options.
func NewDataQualityJobDefinition(ctx *pulumi.Context,
	name string, args *DataQualityJobDefinitionArgs, opts ...pulumi.ResourceOption) (*DataQualityJobDefinition, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DataQualityAppSpecification == nil {
		return nil, errors.New("invalid value for required argument 'DataQualityAppSpecification'")
	}
	if args.DataQualityJobInput == nil {
		return nil, errors.New("invalid value for required argument 'DataQualityJobInput'")
	}
	if args.DataQualityJobOutputConfig == nil {
		return nil, errors.New("invalid value for required argument 'DataQualityJobOutputConfig'")
	}
	if args.JobResources == nil {
		return nil, errors.New("invalid value for required argument 'JobResources'")
	}
	if args.RoleArn == nil {
		return nil, errors.New("invalid value for required argument 'RoleArn'")
	}
	var resource DataQualityJobDefinition
	err := ctx.RegisterResource("aws-native:sagemaker:DataQualityJobDefinition", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDataQualityJobDefinition gets an existing DataQualityJobDefinition resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDataQualityJobDefinition(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DataQualityJobDefinitionState, opts ...pulumi.ResourceOption) (*DataQualityJobDefinition, error) {
	var resource DataQualityJobDefinition
	err := ctx.ReadResource("aws-native:sagemaker:DataQualityJobDefinition", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DataQualityJobDefinition resources.
type dataQualityJobDefinitionState struct {
}

type DataQualityJobDefinitionState struct {
}

func (DataQualityJobDefinitionState) ElementType() reflect.Type {
	return reflect.TypeOf((*dataQualityJobDefinitionState)(nil)).Elem()
}

type dataQualityJobDefinitionArgs struct {
	DataQualityAppSpecification DataQualityJobDefinitionDataQualityAppSpecification `pulumi:"dataQualityAppSpecification"`
	DataQualityBaselineConfig   *DataQualityJobDefinitionDataQualityBaselineConfig  `pulumi:"dataQualityBaselineConfig"`
	DataQualityJobInput         DataQualityJobDefinitionDataQualityJobInput         `pulumi:"dataQualityJobInput"`
	DataQualityJobOutputConfig  DataQualityJobDefinitionMonitoringOutputConfig      `pulumi:"dataQualityJobOutputConfig"`
	JobDefinitionName           *string                                             `pulumi:"jobDefinitionName"`
	JobResources                DataQualityJobDefinitionMonitoringResources         `pulumi:"jobResources"`
	NetworkConfig               *DataQualityJobDefinitionNetworkConfig              `pulumi:"networkConfig"`
	// The Amazon Resource Name (ARN) of an IAM role that Amazon SageMaker can assume to perform tasks on your behalf.
	RoleArn           string                                     `pulumi:"roleArn"`
	StoppingCondition *DataQualityJobDefinitionStoppingCondition `pulumi:"stoppingCondition"`
	// An array of key-value pairs to apply to this resource.
	Tags []DataQualityJobDefinitionTag `pulumi:"tags"`
}

// The set of arguments for constructing a DataQualityJobDefinition resource.
type DataQualityJobDefinitionArgs struct {
	DataQualityAppSpecification DataQualityJobDefinitionDataQualityAppSpecificationInput
	DataQualityBaselineConfig   DataQualityJobDefinitionDataQualityBaselineConfigPtrInput
	DataQualityJobInput         DataQualityJobDefinitionDataQualityJobInputInput
	DataQualityJobOutputConfig  DataQualityJobDefinitionMonitoringOutputConfigInput
	JobDefinitionName           pulumi.StringPtrInput
	JobResources                DataQualityJobDefinitionMonitoringResourcesInput
	NetworkConfig               DataQualityJobDefinitionNetworkConfigPtrInput
	// The Amazon Resource Name (ARN) of an IAM role that Amazon SageMaker can assume to perform tasks on your behalf.
	RoleArn           pulumi.StringInput
	StoppingCondition DataQualityJobDefinitionStoppingConditionPtrInput
	// An array of key-value pairs to apply to this resource.
	Tags DataQualityJobDefinitionTagArrayInput
}

func (DataQualityJobDefinitionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*dataQualityJobDefinitionArgs)(nil)).Elem()
}

type DataQualityJobDefinitionInput interface {
	pulumi.Input

	ToDataQualityJobDefinitionOutput() DataQualityJobDefinitionOutput
	ToDataQualityJobDefinitionOutputWithContext(ctx context.Context) DataQualityJobDefinitionOutput
}

func (*DataQualityJobDefinition) ElementType() reflect.Type {
	return reflect.TypeOf((*DataQualityJobDefinition)(nil))
}

func (i *DataQualityJobDefinition) ToDataQualityJobDefinitionOutput() DataQualityJobDefinitionOutput {
	return i.ToDataQualityJobDefinitionOutputWithContext(context.Background())
}

func (i *DataQualityJobDefinition) ToDataQualityJobDefinitionOutputWithContext(ctx context.Context) DataQualityJobDefinitionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DataQualityJobDefinitionOutput)
}

type DataQualityJobDefinitionOutput struct{ *pulumi.OutputState }

func (DataQualityJobDefinitionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*DataQualityJobDefinition)(nil))
}

func (o DataQualityJobDefinitionOutput) ToDataQualityJobDefinitionOutput() DataQualityJobDefinitionOutput {
	return o
}

func (o DataQualityJobDefinitionOutput) ToDataQualityJobDefinitionOutputWithContext(ctx context.Context) DataQualityJobDefinitionOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(DataQualityJobDefinitionOutput{})
}
