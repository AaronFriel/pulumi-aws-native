// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package stepfunctions

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html
type StateMachine struct {
	pulumi.CustomResourceState

	Arn pulumi.StringOutput `pulumi:"arn"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-definitions3location
	DefinitionS3Location StateMachineS3LocationPtrOutput `pulumi:"definitionS3Location"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-definitionstring
	DefinitionString pulumi.StringPtrOutput `pulumi:"definitionString"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-definitionsubstitutions
	DefinitionSubstitutions StateMachineDefinitionSubstitutionsPtrOutput `pulumi:"definitionSubstitutions"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-loggingconfiguration
	LoggingConfiguration StateMachineLoggingConfigurationPtrOutput `pulumi:"loggingConfiguration"`
	Name                 pulumi.StringOutput                       `pulumi:"name"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-rolearn
	RoleArn pulumi.StringOutput `pulumi:"roleArn"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-statemachinename
	StateMachineName pulumi.StringPtrOutput `pulumi:"stateMachineName"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-statemachinetype
	StateMachineType pulumi.StringPtrOutput `pulumi:"stateMachineType"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-tags
	Tags StateMachineTagsEntryArrayOutput `pulumi:"tags"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-tracingconfiguration
	TracingConfiguration StateMachineTracingConfigurationPtrOutput `pulumi:"tracingConfiguration"`
}

// NewStateMachine registers a new resource with the given unique name, arguments, and options.
func NewStateMachine(ctx *pulumi.Context,
	name string, args *StateMachineArgs, opts ...pulumi.ResourceOption) (*StateMachine, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.RoleArn == nil {
		return nil, errors.New("invalid value for required argument 'RoleArn'")
	}
	var resource StateMachine
	err := ctx.RegisterResource("aws-native:StepFunctions:StateMachine", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetStateMachine gets an existing StateMachine resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetStateMachine(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *StateMachineState, opts ...pulumi.ResourceOption) (*StateMachine, error) {
	var resource StateMachine
	err := ctx.ReadResource("aws-native:StepFunctions:StateMachine", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering StateMachine resources.
type stateMachineState struct {
}

type StateMachineState struct {
}

func (StateMachineState) ElementType() reflect.Type {
	return reflect.TypeOf((*stateMachineState)(nil)).Elem()
}

type stateMachineArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-definitions3location
	DefinitionS3Location *StateMachineS3Location `pulumi:"definitionS3Location"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-definitionstring
	DefinitionString *string `pulumi:"definitionString"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-definitionsubstitutions
	DefinitionSubstitutions *StateMachineDefinitionSubstitutions `pulumi:"definitionSubstitutions"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-loggingconfiguration
	LoggingConfiguration *StateMachineLoggingConfiguration `pulumi:"loggingConfiguration"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-rolearn
	RoleArn string `pulumi:"roleArn"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-statemachinename
	StateMachineName *string `pulumi:"stateMachineName"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-statemachinetype
	StateMachineType *string `pulumi:"stateMachineType"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-tags
	Tags []StateMachineTagsEntry `pulumi:"tags"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-tracingconfiguration
	TracingConfiguration *StateMachineTracingConfiguration `pulumi:"tracingConfiguration"`
}

// The set of arguments for constructing a StateMachine resource.
type StateMachineArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-definitions3location
	DefinitionS3Location StateMachineS3LocationPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-definitionstring
	DefinitionString pulumi.StringPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-definitionsubstitutions
	DefinitionSubstitutions StateMachineDefinitionSubstitutionsPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-loggingconfiguration
	LoggingConfiguration StateMachineLoggingConfigurationPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-rolearn
	RoleArn pulumi.StringInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-statemachinename
	StateMachineName pulumi.StringPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-statemachinetype
	StateMachineType pulumi.StringPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-tags
	Tags StateMachineTagsEntryArrayInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-statemachine.html#cfn-stepfunctions-statemachine-tracingconfiguration
	TracingConfiguration StateMachineTracingConfigurationPtrInput
}

func (StateMachineArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*stateMachineArgs)(nil)).Elem()
}

type StateMachineInput interface {
	pulumi.Input

	ToStateMachineOutput() StateMachineOutput
	ToStateMachineOutputWithContext(ctx context.Context) StateMachineOutput
}

func (*StateMachine) ElementType() reflect.Type {
	return reflect.TypeOf((*StateMachine)(nil))
}

func (i *StateMachine) ToStateMachineOutput() StateMachineOutput {
	return i.ToStateMachineOutputWithContext(context.Background())
}

func (i *StateMachine) ToStateMachineOutputWithContext(ctx context.Context) StateMachineOutput {
	return pulumi.ToOutputWithContext(ctx, i).(StateMachineOutput)
}

type StateMachineOutput struct{ *pulumi.OutputState }

func (StateMachineOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*StateMachine)(nil))
}

func (o StateMachineOutput) ToStateMachineOutput() StateMachineOutput {
	return o
}

func (o StateMachineOutput) ToStateMachineOutputWithContext(ctx context.Context) StateMachineOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(StateMachineOutput{})
}