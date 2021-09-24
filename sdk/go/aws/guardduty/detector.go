// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package guardduty

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::GuardDuty::Detector
//
// Deprecated: Detector is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type Detector struct {
	pulumi.CustomResourceState

	DataSources                DetectorCFNDataSourceConfigurationsPtrOutput `pulumi:"dataSources"`
	Enable                     pulumi.BoolOutput                            `pulumi:"enable"`
	FindingPublishingFrequency pulumi.StringPtrOutput                       `pulumi:"findingPublishingFrequency"`
}

// NewDetector registers a new resource with the given unique name, arguments, and options.
func NewDetector(ctx *pulumi.Context,
	name string, args *DetectorArgs, opts ...pulumi.ResourceOption) (*Detector, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Enable == nil {
		return nil, errors.New("invalid value for required argument 'Enable'")
	}
	var resource Detector
	err := ctx.RegisterResource("aws-native:guardduty:Detector", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDetector gets an existing Detector resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDetector(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DetectorState, opts ...pulumi.ResourceOption) (*Detector, error) {
	var resource Detector
	err := ctx.ReadResource("aws-native:guardduty:Detector", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Detector resources.
type detectorState struct {
}

type DetectorState struct {
}

func (DetectorState) ElementType() reflect.Type {
	return reflect.TypeOf((*detectorState)(nil)).Elem()
}

type detectorArgs struct {
	DataSources                *DetectorCFNDataSourceConfigurations `pulumi:"dataSources"`
	Enable                     bool                                 `pulumi:"enable"`
	FindingPublishingFrequency *string                              `pulumi:"findingPublishingFrequency"`
}

// The set of arguments for constructing a Detector resource.
type DetectorArgs struct {
	DataSources                DetectorCFNDataSourceConfigurationsPtrInput
	Enable                     pulumi.BoolInput
	FindingPublishingFrequency pulumi.StringPtrInput
}

func (DetectorArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*detectorArgs)(nil)).Elem()
}

type DetectorInput interface {
	pulumi.Input

	ToDetectorOutput() DetectorOutput
	ToDetectorOutputWithContext(ctx context.Context) DetectorOutput
}

func (*Detector) ElementType() reflect.Type {
	return reflect.TypeOf((*Detector)(nil))
}

func (i *Detector) ToDetectorOutput() DetectorOutput {
	return i.ToDetectorOutputWithContext(context.Background())
}

func (i *Detector) ToDetectorOutputWithContext(ctx context.Context) DetectorOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DetectorOutput)
}

type DetectorOutput struct{ *pulumi.OutputState }

func (DetectorOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Detector)(nil))
}

func (o DetectorOutput) ToDetectorOutput() DetectorOutput {
	return o
}

func (o DetectorOutput) ToDetectorOutputWithContext(ctx context.Context) DetectorOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(DetectorOutput{})
}
