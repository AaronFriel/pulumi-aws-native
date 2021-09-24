// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package mediaconvert

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::MediaConvert::JobTemplate
//
// Deprecated: JobTemplate is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type JobTemplate struct {
	pulumi.CustomResourceState

	AccelerationSettings JobTemplateAccelerationSettingsPtrOutput `pulumi:"accelerationSettings"`
	Arn                  pulumi.StringOutput                      `pulumi:"arn"`
	Category             pulumi.StringPtrOutput                   `pulumi:"category"`
	Description          pulumi.StringPtrOutput                   `pulumi:"description"`
	HopDestinations      JobTemplateHopDestinationArrayOutput     `pulumi:"hopDestinations"`
	Name                 pulumi.StringPtrOutput                   `pulumi:"name"`
	Priority             pulumi.IntPtrOutput                      `pulumi:"priority"`
	Queue                pulumi.StringPtrOutput                   `pulumi:"queue"`
	SettingsJson         pulumi.AnyOutput                         `pulumi:"settingsJson"`
	StatusUpdateInterval pulumi.StringPtrOutput                   `pulumi:"statusUpdateInterval"`
	Tags                 pulumi.AnyOutput                         `pulumi:"tags"`
}

// NewJobTemplate registers a new resource with the given unique name, arguments, and options.
func NewJobTemplate(ctx *pulumi.Context,
	name string, args *JobTemplateArgs, opts ...pulumi.ResourceOption) (*JobTemplate, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.SettingsJson == nil {
		return nil, errors.New("invalid value for required argument 'SettingsJson'")
	}
	var resource JobTemplate
	err := ctx.RegisterResource("aws-native:mediaconvert:JobTemplate", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetJobTemplate gets an existing JobTemplate resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetJobTemplate(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *JobTemplateState, opts ...pulumi.ResourceOption) (*JobTemplate, error) {
	var resource JobTemplate
	err := ctx.ReadResource("aws-native:mediaconvert:JobTemplate", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering JobTemplate resources.
type jobTemplateState struct {
}

type JobTemplateState struct {
}

func (JobTemplateState) ElementType() reflect.Type {
	return reflect.TypeOf((*jobTemplateState)(nil)).Elem()
}

type jobTemplateArgs struct {
	AccelerationSettings *JobTemplateAccelerationSettings `pulumi:"accelerationSettings"`
	Category             *string                          `pulumi:"category"`
	Description          *string                          `pulumi:"description"`
	HopDestinations      []JobTemplateHopDestination      `pulumi:"hopDestinations"`
	Name                 *string                          `pulumi:"name"`
	Priority             *int                             `pulumi:"priority"`
	Queue                *string                          `pulumi:"queue"`
	SettingsJson         interface{}                      `pulumi:"settingsJson"`
	StatusUpdateInterval *string                          `pulumi:"statusUpdateInterval"`
	Tags                 interface{}                      `pulumi:"tags"`
}

// The set of arguments for constructing a JobTemplate resource.
type JobTemplateArgs struct {
	AccelerationSettings JobTemplateAccelerationSettingsPtrInput
	Category             pulumi.StringPtrInput
	Description          pulumi.StringPtrInput
	HopDestinations      JobTemplateHopDestinationArrayInput
	Name                 pulumi.StringPtrInput
	Priority             pulumi.IntPtrInput
	Queue                pulumi.StringPtrInput
	SettingsJson         pulumi.Input
	StatusUpdateInterval pulumi.StringPtrInput
	Tags                 pulumi.Input
}

func (JobTemplateArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*jobTemplateArgs)(nil)).Elem()
}

type JobTemplateInput interface {
	pulumi.Input

	ToJobTemplateOutput() JobTemplateOutput
	ToJobTemplateOutputWithContext(ctx context.Context) JobTemplateOutput
}

func (*JobTemplate) ElementType() reflect.Type {
	return reflect.TypeOf((*JobTemplate)(nil))
}

func (i *JobTemplate) ToJobTemplateOutput() JobTemplateOutput {
	return i.ToJobTemplateOutputWithContext(context.Background())
}

func (i *JobTemplate) ToJobTemplateOutputWithContext(ctx context.Context) JobTemplateOutput {
	return pulumi.ToOutputWithContext(ctx, i).(JobTemplateOutput)
}

type JobTemplateOutput struct{ *pulumi.OutputState }

func (JobTemplateOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*JobTemplate)(nil))
}

func (o JobTemplateOutput) ToJobTemplateOutput() JobTemplateOutput {
	return o
}

func (o JobTemplateOutput) ToJobTemplateOutputWithContext(ctx context.Context) JobTemplateOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(JobTemplateOutput{})
}
