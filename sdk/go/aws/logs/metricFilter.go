// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package logs

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::Logs::MetricFilter
//
// Deprecated: MetricFilter is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type MetricFilter struct {
	pulumi.CustomResourceState

	FilterPattern         pulumi.StringOutput                         `pulumi:"filterPattern"`
	LogGroupName          pulumi.StringOutput                         `pulumi:"logGroupName"`
	MetricTransformations MetricFilterMetricTransformationArrayOutput `pulumi:"metricTransformations"`
}

// NewMetricFilter registers a new resource with the given unique name, arguments, and options.
func NewMetricFilter(ctx *pulumi.Context,
	name string, args *MetricFilterArgs, opts ...pulumi.ResourceOption) (*MetricFilter, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.FilterPattern == nil {
		return nil, errors.New("invalid value for required argument 'FilterPattern'")
	}
	if args.LogGroupName == nil {
		return nil, errors.New("invalid value for required argument 'LogGroupName'")
	}
	if args.MetricTransformations == nil {
		return nil, errors.New("invalid value for required argument 'MetricTransformations'")
	}
	var resource MetricFilter
	err := ctx.RegisterResource("aws-native:logs:MetricFilter", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetMetricFilter gets an existing MetricFilter resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMetricFilter(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *MetricFilterState, opts ...pulumi.ResourceOption) (*MetricFilter, error) {
	var resource MetricFilter
	err := ctx.ReadResource("aws-native:logs:MetricFilter", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering MetricFilter resources.
type metricFilterState struct {
}

type MetricFilterState struct {
}

func (MetricFilterState) ElementType() reflect.Type {
	return reflect.TypeOf((*metricFilterState)(nil)).Elem()
}

type metricFilterArgs struct {
	FilterPattern         string                             `pulumi:"filterPattern"`
	LogGroupName          string                             `pulumi:"logGroupName"`
	MetricTransformations []MetricFilterMetricTransformation `pulumi:"metricTransformations"`
}

// The set of arguments for constructing a MetricFilter resource.
type MetricFilterArgs struct {
	FilterPattern         pulumi.StringInput
	LogGroupName          pulumi.StringInput
	MetricTransformations MetricFilterMetricTransformationArrayInput
}

func (MetricFilterArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*metricFilterArgs)(nil)).Elem()
}

type MetricFilterInput interface {
	pulumi.Input

	ToMetricFilterOutput() MetricFilterOutput
	ToMetricFilterOutputWithContext(ctx context.Context) MetricFilterOutput
}

func (*MetricFilter) ElementType() reflect.Type {
	return reflect.TypeOf((*MetricFilter)(nil))
}

func (i *MetricFilter) ToMetricFilterOutput() MetricFilterOutput {
	return i.ToMetricFilterOutputWithContext(context.Background())
}

func (i *MetricFilter) ToMetricFilterOutputWithContext(ctx context.Context) MetricFilterOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MetricFilterOutput)
}

type MetricFilterOutput struct{ *pulumi.OutputState }

func (MetricFilterOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*MetricFilter)(nil))
}

func (o MetricFilterOutput) ToMetricFilterOutput() MetricFilterOutput {
	return o
}

func (o MetricFilterOutput) ToMetricFilterOutputWithContext(ctx context.Context) MetricFilterOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(MetricFilterOutput{})
}
