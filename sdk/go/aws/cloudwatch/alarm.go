// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package cloudwatch

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::CloudWatch::Alarm
//
// Deprecated: Alarm is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type Alarm struct {
	pulumi.CustomResourceState

	ActionsEnabled                   pulumi.BoolPtrOutput            `pulumi:"actionsEnabled"`
	AlarmActions                     pulumi.StringArrayOutput        `pulumi:"alarmActions"`
	AlarmDescription                 pulumi.StringPtrOutput          `pulumi:"alarmDescription"`
	AlarmName                        pulumi.StringPtrOutput          `pulumi:"alarmName"`
	Arn                              pulumi.StringOutput             `pulumi:"arn"`
	ComparisonOperator               pulumi.StringOutput             `pulumi:"comparisonOperator"`
	DatapointsToAlarm                pulumi.IntPtrOutput             `pulumi:"datapointsToAlarm"`
	Dimensions                       AlarmDimensionArrayOutput       `pulumi:"dimensions"`
	EvaluateLowSampleCountPercentile pulumi.StringPtrOutput          `pulumi:"evaluateLowSampleCountPercentile"`
	EvaluationPeriods                pulumi.IntOutput                `pulumi:"evaluationPeriods"`
	ExtendedStatistic                pulumi.StringPtrOutput          `pulumi:"extendedStatistic"`
	InsufficientDataActions          pulumi.StringArrayOutput        `pulumi:"insufficientDataActions"`
	MetricName                       pulumi.StringPtrOutput          `pulumi:"metricName"`
	Metrics                          AlarmMetricDataQueryArrayOutput `pulumi:"metrics"`
	Namespace                        pulumi.StringPtrOutput          `pulumi:"namespace"`
	OKActions                        pulumi.StringArrayOutput        `pulumi:"oKActions"`
	Period                           pulumi.IntPtrOutput             `pulumi:"period"`
	Statistic                        pulumi.StringPtrOutput          `pulumi:"statistic"`
	Threshold                        pulumi.Float64PtrOutput         `pulumi:"threshold"`
	ThresholdMetricId                pulumi.StringPtrOutput          `pulumi:"thresholdMetricId"`
	TreatMissingData                 pulumi.StringPtrOutput          `pulumi:"treatMissingData"`
	Unit                             pulumi.StringPtrOutput          `pulumi:"unit"`
}

// NewAlarm registers a new resource with the given unique name, arguments, and options.
func NewAlarm(ctx *pulumi.Context,
	name string, args *AlarmArgs, opts ...pulumi.ResourceOption) (*Alarm, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ComparisonOperator == nil {
		return nil, errors.New("invalid value for required argument 'ComparisonOperator'")
	}
	if args.EvaluationPeriods == nil {
		return nil, errors.New("invalid value for required argument 'EvaluationPeriods'")
	}
	var resource Alarm
	err := ctx.RegisterResource("aws-native:cloudwatch:Alarm", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAlarm gets an existing Alarm resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAlarm(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AlarmState, opts ...pulumi.ResourceOption) (*Alarm, error) {
	var resource Alarm
	err := ctx.ReadResource("aws-native:cloudwatch:Alarm", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Alarm resources.
type alarmState struct {
}

type AlarmState struct {
}

func (AlarmState) ElementType() reflect.Type {
	return reflect.TypeOf((*alarmState)(nil)).Elem()
}

type alarmArgs struct {
	ActionsEnabled                   *bool                  `pulumi:"actionsEnabled"`
	AlarmActions                     []string               `pulumi:"alarmActions"`
	AlarmDescription                 *string                `pulumi:"alarmDescription"`
	AlarmName                        *string                `pulumi:"alarmName"`
	ComparisonOperator               string                 `pulumi:"comparisonOperator"`
	DatapointsToAlarm                *int                   `pulumi:"datapointsToAlarm"`
	Dimensions                       []AlarmDimension       `pulumi:"dimensions"`
	EvaluateLowSampleCountPercentile *string                `pulumi:"evaluateLowSampleCountPercentile"`
	EvaluationPeriods                int                    `pulumi:"evaluationPeriods"`
	ExtendedStatistic                *string                `pulumi:"extendedStatistic"`
	InsufficientDataActions          []string               `pulumi:"insufficientDataActions"`
	MetricName                       *string                `pulumi:"metricName"`
	Metrics                          []AlarmMetricDataQuery `pulumi:"metrics"`
	Namespace                        *string                `pulumi:"namespace"`
	OKActions                        []string               `pulumi:"oKActions"`
	Period                           *int                   `pulumi:"period"`
	Statistic                        *string                `pulumi:"statistic"`
	Threshold                        *float64               `pulumi:"threshold"`
	ThresholdMetricId                *string                `pulumi:"thresholdMetricId"`
	TreatMissingData                 *string                `pulumi:"treatMissingData"`
	Unit                             *string                `pulumi:"unit"`
}

// The set of arguments for constructing a Alarm resource.
type AlarmArgs struct {
	ActionsEnabled                   pulumi.BoolPtrInput
	AlarmActions                     pulumi.StringArrayInput
	AlarmDescription                 pulumi.StringPtrInput
	AlarmName                        pulumi.StringPtrInput
	ComparisonOperator               pulumi.StringInput
	DatapointsToAlarm                pulumi.IntPtrInput
	Dimensions                       AlarmDimensionArrayInput
	EvaluateLowSampleCountPercentile pulumi.StringPtrInput
	EvaluationPeriods                pulumi.IntInput
	ExtendedStatistic                pulumi.StringPtrInput
	InsufficientDataActions          pulumi.StringArrayInput
	MetricName                       pulumi.StringPtrInput
	Metrics                          AlarmMetricDataQueryArrayInput
	Namespace                        pulumi.StringPtrInput
	OKActions                        pulumi.StringArrayInput
	Period                           pulumi.IntPtrInput
	Statistic                        pulumi.StringPtrInput
	Threshold                        pulumi.Float64PtrInput
	ThresholdMetricId                pulumi.StringPtrInput
	TreatMissingData                 pulumi.StringPtrInput
	Unit                             pulumi.StringPtrInput
}

func (AlarmArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*alarmArgs)(nil)).Elem()
}

type AlarmInput interface {
	pulumi.Input

	ToAlarmOutput() AlarmOutput
	ToAlarmOutputWithContext(ctx context.Context) AlarmOutput
}

func (*Alarm) ElementType() reflect.Type {
	return reflect.TypeOf((*Alarm)(nil))
}

func (i *Alarm) ToAlarmOutput() AlarmOutput {
	return i.ToAlarmOutputWithContext(context.Background())
}

func (i *Alarm) ToAlarmOutputWithContext(ctx context.Context) AlarmOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AlarmOutput)
}

type AlarmOutput struct{ *pulumi.OutputState }

func (AlarmOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Alarm)(nil))
}

func (o AlarmOutput) ToAlarmOutput() AlarmOutput {
	return o
}

func (o AlarmOutput) ToAlarmOutputWithContext(ctx context.Context) AlarmOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*AlarmInput)(nil)).Elem(), &Alarm{})
	pulumi.RegisterOutputType(AlarmOutput{})
}
