// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package codeguruprofiler

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeguruprofiler-profilinggroup-channel.html
type ProfilingGroupChannel struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeguruprofiler-profilinggroup-channel.html#cfn-codeguruprofiler-profilinggroup-channel-channelid
	ChannelId *string `pulumi:"channelId"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeguruprofiler-profilinggroup-channel.html#cfn-codeguruprofiler-profilinggroup-channel-channeluri
	ChannelUri string `pulumi:"channelUri"`
}

// ProfilingGroupChannelInput is an input type that accepts ProfilingGroupChannelArgs and ProfilingGroupChannelOutput values.
// You can construct a concrete instance of `ProfilingGroupChannelInput` via:
//
//          ProfilingGroupChannelArgs{...}
type ProfilingGroupChannelInput interface {
	pulumi.Input

	ToProfilingGroupChannelOutput() ProfilingGroupChannelOutput
	ToProfilingGroupChannelOutputWithContext(context.Context) ProfilingGroupChannelOutput
}

// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeguruprofiler-profilinggroup-channel.html
type ProfilingGroupChannelArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeguruprofiler-profilinggroup-channel.html#cfn-codeguruprofiler-profilinggroup-channel-channelid
	ChannelId pulumi.StringPtrInput `pulumi:"channelId"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeguruprofiler-profilinggroup-channel.html#cfn-codeguruprofiler-profilinggroup-channel-channeluri
	ChannelUri pulumi.StringInput `pulumi:"channelUri"`
}

func (ProfilingGroupChannelArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ProfilingGroupChannel)(nil)).Elem()
}

func (i ProfilingGroupChannelArgs) ToProfilingGroupChannelOutput() ProfilingGroupChannelOutput {
	return i.ToProfilingGroupChannelOutputWithContext(context.Background())
}

func (i ProfilingGroupChannelArgs) ToProfilingGroupChannelOutputWithContext(ctx context.Context) ProfilingGroupChannelOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProfilingGroupChannelOutput)
}

// ProfilingGroupChannelArrayInput is an input type that accepts ProfilingGroupChannelArray and ProfilingGroupChannelArrayOutput values.
// You can construct a concrete instance of `ProfilingGroupChannelArrayInput` via:
//
//          ProfilingGroupChannelArray{ ProfilingGroupChannelArgs{...} }
type ProfilingGroupChannelArrayInput interface {
	pulumi.Input

	ToProfilingGroupChannelArrayOutput() ProfilingGroupChannelArrayOutput
	ToProfilingGroupChannelArrayOutputWithContext(context.Context) ProfilingGroupChannelArrayOutput
}

type ProfilingGroupChannelArray []ProfilingGroupChannelInput

func (ProfilingGroupChannelArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ProfilingGroupChannel)(nil)).Elem()
}

func (i ProfilingGroupChannelArray) ToProfilingGroupChannelArrayOutput() ProfilingGroupChannelArrayOutput {
	return i.ToProfilingGroupChannelArrayOutputWithContext(context.Background())
}

func (i ProfilingGroupChannelArray) ToProfilingGroupChannelArrayOutputWithContext(ctx context.Context) ProfilingGroupChannelArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProfilingGroupChannelArrayOutput)
}

// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeguruprofiler-profilinggroup-channel.html
type ProfilingGroupChannelOutput struct{ *pulumi.OutputState }

func (ProfilingGroupChannelOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ProfilingGroupChannel)(nil)).Elem()
}

func (o ProfilingGroupChannelOutput) ToProfilingGroupChannelOutput() ProfilingGroupChannelOutput {
	return o
}

func (o ProfilingGroupChannelOutput) ToProfilingGroupChannelOutputWithContext(ctx context.Context) ProfilingGroupChannelOutput {
	return o
}

// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeguruprofiler-profilinggroup-channel.html#cfn-codeguruprofiler-profilinggroup-channel-channelid
func (o ProfilingGroupChannelOutput) ChannelId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ProfilingGroupChannel) *string { return v.ChannelId }).(pulumi.StringPtrOutput)
}

// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codeguruprofiler-profilinggroup-channel.html#cfn-codeguruprofiler-profilinggroup-channel-channeluri
func (o ProfilingGroupChannelOutput) ChannelUri() pulumi.StringOutput {
	return o.ApplyT(func(v ProfilingGroupChannel) string { return v.ChannelUri }).(pulumi.StringOutput)
}

type ProfilingGroupChannelArrayOutput struct{ *pulumi.OutputState }

func (ProfilingGroupChannelArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ProfilingGroupChannel)(nil)).Elem()
}

func (o ProfilingGroupChannelArrayOutput) ToProfilingGroupChannelArrayOutput() ProfilingGroupChannelArrayOutput {
	return o
}

func (o ProfilingGroupChannelArrayOutput) ToProfilingGroupChannelArrayOutputWithContext(ctx context.Context) ProfilingGroupChannelArrayOutput {
	return o
}

func (o ProfilingGroupChannelArrayOutput) Index(i pulumi.IntInput) ProfilingGroupChannelOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) ProfilingGroupChannel {
		return vs[0].([]ProfilingGroupChannel)[vs[1].(int)]
	}).(ProfilingGroupChannelOutput)
}

func init() {
	pulumi.RegisterOutputType(ProfilingGroupChannelOutput{})
	pulumi.RegisterOutputType(ProfilingGroupChannelArrayOutput{})
}