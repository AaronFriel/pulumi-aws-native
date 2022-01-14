// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package lookoutequipment

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// How often data is uploaded to the source S3 bucket for the input data.
type InferenceSchedulerDataUploadFrequency string

const (
	InferenceSchedulerDataUploadFrequencyPt5m  = InferenceSchedulerDataUploadFrequency("PT5M")
	InferenceSchedulerDataUploadFrequencyPt10m = InferenceSchedulerDataUploadFrequency("PT10M")
	InferenceSchedulerDataUploadFrequencyPt15m = InferenceSchedulerDataUploadFrequency("PT15M")
	InferenceSchedulerDataUploadFrequencyPt30m = InferenceSchedulerDataUploadFrequency("PT30M")
	InferenceSchedulerDataUploadFrequencyPt1h  = InferenceSchedulerDataUploadFrequency("PT1H")
)

func (InferenceSchedulerDataUploadFrequency) ElementType() reflect.Type {
	return reflect.TypeOf((*InferenceSchedulerDataUploadFrequency)(nil)).Elem()
}

func (e InferenceSchedulerDataUploadFrequency) ToInferenceSchedulerDataUploadFrequencyOutput() InferenceSchedulerDataUploadFrequencyOutput {
	return pulumi.ToOutput(e).(InferenceSchedulerDataUploadFrequencyOutput)
}

func (e InferenceSchedulerDataUploadFrequency) ToInferenceSchedulerDataUploadFrequencyOutputWithContext(ctx context.Context) InferenceSchedulerDataUploadFrequencyOutput {
	return pulumi.ToOutputWithContext(ctx, e).(InferenceSchedulerDataUploadFrequencyOutput)
}

func (e InferenceSchedulerDataUploadFrequency) ToInferenceSchedulerDataUploadFrequencyPtrOutput() InferenceSchedulerDataUploadFrequencyPtrOutput {
	return e.ToInferenceSchedulerDataUploadFrequencyPtrOutputWithContext(context.Background())
}

func (e InferenceSchedulerDataUploadFrequency) ToInferenceSchedulerDataUploadFrequencyPtrOutputWithContext(ctx context.Context) InferenceSchedulerDataUploadFrequencyPtrOutput {
	return InferenceSchedulerDataUploadFrequency(e).ToInferenceSchedulerDataUploadFrequencyOutputWithContext(ctx).ToInferenceSchedulerDataUploadFrequencyPtrOutputWithContext(ctx)
}

func (e InferenceSchedulerDataUploadFrequency) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e InferenceSchedulerDataUploadFrequency) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e InferenceSchedulerDataUploadFrequency) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e InferenceSchedulerDataUploadFrequency) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type InferenceSchedulerDataUploadFrequencyOutput struct{ *pulumi.OutputState }

func (InferenceSchedulerDataUploadFrequencyOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*InferenceSchedulerDataUploadFrequency)(nil)).Elem()
}

func (o InferenceSchedulerDataUploadFrequencyOutput) ToInferenceSchedulerDataUploadFrequencyOutput() InferenceSchedulerDataUploadFrequencyOutput {
	return o
}

func (o InferenceSchedulerDataUploadFrequencyOutput) ToInferenceSchedulerDataUploadFrequencyOutputWithContext(ctx context.Context) InferenceSchedulerDataUploadFrequencyOutput {
	return o
}

func (o InferenceSchedulerDataUploadFrequencyOutput) ToInferenceSchedulerDataUploadFrequencyPtrOutput() InferenceSchedulerDataUploadFrequencyPtrOutput {
	return o.ToInferenceSchedulerDataUploadFrequencyPtrOutputWithContext(context.Background())
}

func (o InferenceSchedulerDataUploadFrequencyOutput) ToInferenceSchedulerDataUploadFrequencyPtrOutputWithContext(ctx context.Context) InferenceSchedulerDataUploadFrequencyPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v InferenceSchedulerDataUploadFrequency) *InferenceSchedulerDataUploadFrequency {
		return &v
	}).(InferenceSchedulerDataUploadFrequencyPtrOutput)
}

func (o InferenceSchedulerDataUploadFrequencyOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o InferenceSchedulerDataUploadFrequencyOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e InferenceSchedulerDataUploadFrequency) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o InferenceSchedulerDataUploadFrequencyOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o InferenceSchedulerDataUploadFrequencyOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e InferenceSchedulerDataUploadFrequency) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type InferenceSchedulerDataUploadFrequencyPtrOutput struct{ *pulumi.OutputState }

func (InferenceSchedulerDataUploadFrequencyPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**InferenceSchedulerDataUploadFrequency)(nil)).Elem()
}

func (o InferenceSchedulerDataUploadFrequencyPtrOutput) ToInferenceSchedulerDataUploadFrequencyPtrOutput() InferenceSchedulerDataUploadFrequencyPtrOutput {
	return o
}

func (o InferenceSchedulerDataUploadFrequencyPtrOutput) ToInferenceSchedulerDataUploadFrequencyPtrOutputWithContext(ctx context.Context) InferenceSchedulerDataUploadFrequencyPtrOutput {
	return o
}

func (o InferenceSchedulerDataUploadFrequencyPtrOutput) Elem() InferenceSchedulerDataUploadFrequencyOutput {
	return o.ApplyT(func(v *InferenceSchedulerDataUploadFrequency) InferenceSchedulerDataUploadFrequency {
		if v != nil {
			return *v
		}
		var ret InferenceSchedulerDataUploadFrequency
		return ret
	}).(InferenceSchedulerDataUploadFrequencyOutput)
}

func (o InferenceSchedulerDataUploadFrequencyPtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o InferenceSchedulerDataUploadFrequencyPtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *InferenceSchedulerDataUploadFrequency) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// InferenceSchedulerDataUploadFrequencyInput is an input type that accepts InferenceSchedulerDataUploadFrequencyArgs and InferenceSchedulerDataUploadFrequencyOutput values.
// You can construct a concrete instance of `InferenceSchedulerDataUploadFrequencyInput` via:
//
//          InferenceSchedulerDataUploadFrequencyArgs{...}
type InferenceSchedulerDataUploadFrequencyInput interface {
	pulumi.Input

	ToInferenceSchedulerDataUploadFrequencyOutput() InferenceSchedulerDataUploadFrequencyOutput
	ToInferenceSchedulerDataUploadFrequencyOutputWithContext(context.Context) InferenceSchedulerDataUploadFrequencyOutput
}

var inferenceSchedulerDataUploadFrequencyPtrType = reflect.TypeOf((**InferenceSchedulerDataUploadFrequency)(nil)).Elem()

type InferenceSchedulerDataUploadFrequencyPtrInput interface {
	pulumi.Input

	ToInferenceSchedulerDataUploadFrequencyPtrOutput() InferenceSchedulerDataUploadFrequencyPtrOutput
	ToInferenceSchedulerDataUploadFrequencyPtrOutputWithContext(context.Context) InferenceSchedulerDataUploadFrequencyPtrOutput
}

type inferenceSchedulerDataUploadFrequencyPtr string

func InferenceSchedulerDataUploadFrequencyPtr(v string) InferenceSchedulerDataUploadFrequencyPtrInput {
	return (*inferenceSchedulerDataUploadFrequencyPtr)(&v)
}

func (*inferenceSchedulerDataUploadFrequencyPtr) ElementType() reflect.Type {
	return inferenceSchedulerDataUploadFrequencyPtrType
}

func (in *inferenceSchedulerDataUploadFrequencyPtr) ToInferenceSchedulerDataUploadFrequencyPtrOutput() InferenceSchedulerDataUploadFrequencyPtrOutput {
	return pulumi.ToOutput(in).(InferenceSchedulerDataUploadFrequencyPtrOutput)
}

func (in *inferenceSchedulerDataUploadFrequencyPtr) ToInferenceSchedulerDataUploadFrequencyPtrOutputWithContext(ctx context.Context) InferenceSchedulerDataUploadFrequencyPtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(InferenceSchedulerDataUploadFrequencyPtrOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*InferenceSchedulerDataUploadFrequencyInput)(nil)).Elem(), InferenceSchedulerDataUploadFrequency("PT5M"))
	pulumi.RegisterInputType(reflect.TypeOf((*InferenceSchedulerDataUploadFrequencyPtrInput)(nil)).Elem(), InferenceSchedulerDataUploadFrequency("PT5M"))
	pulumi.RegisterOutputType(InferenceSchedulerDataUploadFrequencyOutput{})
	pulumi.RegisterOutputType(InferenceSchedulerDataUploadFrequencyPtrOutput{})
}
