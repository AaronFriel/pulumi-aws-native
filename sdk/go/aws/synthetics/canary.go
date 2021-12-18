// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package synthetics

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::Synthetics::Canary
type Canary struct {
	pulumi.CustomResourceState

	// Provide artifact configuration
	ArtifactConfig CanaryArtifactConfigPtrOutput `pulumi:"artifactConfig"`
	// Provide the s3 bucket output location for test results
	ArtifactS3Location pulumi.StringOutput `pulumi:"artifactS3Location"`
	// Provide the canary script source
	Code CanaryCodeOutput `pulumi:"code"`
	// Lambda Execution role used to run your canaries
	ExecutionRoleArn pulumi.StringOutput `pulumi:"executionRoleArn"`
	// Retention period of failed canary runs represented in number of days
	FailureRetentionPeriod pulumi.IntPtrOutput `pulumi:"failureRetentionPeriod"`
	// Name of the canary.
	Name pulumi.StringOutput `pulumi:"name"`
	// Provide canary run configuration
	RunConfig CanaryRunConfigPtrOutput `pulumi:"runConfig"`
	// Runtime version of Synthetics Library
	RuntimeVersion pulumi.StringOutput `pulumi:"runtimeVersion"`
	// Frequency to run your canaries
	Schedule CanaryScheduleOutput `pulumi:"schedule"`
	// Runs canary if set to True. Default is False
	StartCanaryAfterCreation pulumi.BoolOutput `pulumi:"startCanaryAfterCreation"`
	// State of the canary
	State pulumi.StringOutput `pulumi:"state"`
	// Retention period of successful canary runs represented in number of days
	SuccessRetentionPeriod pulumi.IntPtrOutput  `pulumi:"successRetentionPeriod"`
	Tags                   CanaryTagArrayOutput `pulumi:"tags"`
	// Provide VPC Configuration if enabled.
	VPCConfig CanaryVPCConfigPtrOutput `pulumi:"vPCConfig"`
	// Visual reference configuration for visual testing
	VisualReference CanaryVisualReferencePtrOutput `pulumi:"visualReference"`
}

// NewCanary registers a new resource with the given unique name, arguments, and options.
func NewCanary(ctx *pulumi.Context,
	name string, args *CanaryArgs, opts ...pulumi.ResourceOption) (*Canary, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ArtifactS3Location == nil {
		return nil, errors.New("invalid value for required argument 'ArtifactS3Location'")
	}
	if args.Code == nil {
		return nil, errors.New("invalid value for required argument 'Code'")
	}
	if args.ExecutionRoleArn == nil {
		return nil, errors.New("invalid value for required argument 'ExecutionRoleArn'")
	}
	if args.RuntimeVersion == nil {
		return nil, errors.New("invalid value for required argument 'RuntimeVersion'")
	}
	if args.Schedule == nil {
		return nil, errors.New("invalid value for required argument 'Schedule'")
	}
	if args.StartCanaryAfterCreation == nil {
		return nil, errors.New("invalid value for required argument 'StartCanaryAfterCreation'")
	}
	var resource Canary
	err := ctx.RegisterResource("aws-native:synthetics:Canary", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCanary gets an existing Canary resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCanary(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CanaryState, opts ...pulumi.ResourceOption) (*Canary, error) {
	var resource Canary
	err := ctx.ReadResource("aws-native:synthetics:Canary", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Canary resources.
type canaryState struct {
}

type CanaryState struct {
}

func (CanaryState) ElementType() reflect.Type {
	return reflect.TypeOf((*canaryState)(nil)).Elem()
}

type canaryArgs struct {
	// Provide artifact configuration
	ArtifactConfig *CanaryArtifactConfig `pulumi:"artifactConfig"`
	// Provide the s3 bucket output location for test results
	ArtifactS3Location string `pulumi:"artifactS3Location"`
	// Provide the canary script source
	Code CanaryCode `pulumi:"code"`
	// Lambda Execution role used to run your canaries
	ExecutionRoleArn string `pulumi:"executionRoleArn"`
	// Retention period of failed canary runs represented in number of days
	FailureRetentionPeriod *int `pulumi:"failureRetentionPeriod"`
	// Name of the canary.
	Name *string `pulumi:"name"`
	// Provide canary run configuration
	RunConfig *CanaryRunConfig `pulumi:"runConfig"`
	// Runtime version of Synthetics Library
	RuntimeVersion string `pulumi:"runtimeVersion"`
	// Frequency to run your canaries
	Schedule CanarySchedule `pulumi:"schedule"`
	// Runs canary if set to True. Default is False
	StartCanaryAfterCreation bool `pulumi:"startCanaryAfterCreation"`
	// Retention period of successful canary runs represented in number of days
	SuccessRetentionPeriod *int        `pulumi:"successRetentionPeriod"`
	Tags                   []CanaryTag `pulumi:"tags"`
	// Provide VPC Configuration if enabled.
	VPCConfig *CanaryVPCConfig `pulumi:"vPCConfig"`
	// Visual reference configuration for visual testing
	VisualReference *CanaryVisualReference `pulumi:"visualReference"`
}

// The set of arguments for constructing a Canary resource.
type CanaryArgs struct {
	// Provide artifact configuration
	ArtifactConfig CanaryArtifactConfigPtrInput
	// Provide the s3 bucket output location for test results
	ArtifactS3Location pulumi.StringInput
	// Provide the canary script source
	Code CanaryCodeInput
	// Lambda Execution role used to run your canaries
	ExecutionRoleArn pulumi.StringInput
	// Retention period of failed canary runs represented in number of days
	FailureRetentionPeriod pulumi.IntPtrInput
	// Name of the canary.
	Name pulumi.StringPtrInput
	// Provide canary run configuration
	RunConfig CanaryRunConfigPtrInput
	// Runtime version of Synthetics Library
	RuntimeVersion pulumi.StringInput
	// Frequency to run your canaries
	Schedule CanaryScheduleInput
	// Runs canary if set to True. Default is False
	StartCanaryAfterCreation pulumi.BoolInput
	// Retention period of successful canary runs represented in number of days
	SuccessRetentionPeriod pulumi.IntPtrInput
	Tags                   CanaryTagArrayInput
	// Provide VPC Configuration if enabled.
	VPCConfig CanaryVPCConfigPtrInput
	// Visual reference configuration for visual testing
	VisualReference CanaryVisualReferencePtrInput
}

func (CanaryArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*canaryArgs)(nil)).Elem()
}

type CanaryInput interface {
	pulumi.Input

	ToCanaryOutput() CanaryOutput
	ToCanaryOutputWithContext(ctx context.Context) CanaryOutput
}

func (*Canary) ElementType() reflect.Type {
	return reflect.TypeOf((*Canary)(nil))
}

func (i *Canary) ToCanaryOutput() CanaryOutput {
	return i.ToCanaryOutputWithContext(context.Background())
}

func (i *Canary) ToCanaryOutputWithContext(ctx context.Context) CanaryOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CanaryOutput)
}

type CanaryOutput struct{ *pulumi.OutputState }

func (CanaryOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Canary)(nil))
}

func (o CanaryOutput) ToCanaryOutput() CanaryOutput {
	return o
}

func (o CanaryOutput) ToCanaryOutputWithContext(ctx context.Context) CanaryOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*CanaryInput)(nil)).Elem(), &Canary{})
	pulumi.RegisterOutputType(CanaryOutput{})
}
