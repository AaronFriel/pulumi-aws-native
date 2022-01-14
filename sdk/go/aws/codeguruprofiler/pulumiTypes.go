// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package codeguruprofiler

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// The agent permissions attached to this profiling group.
type AgentPermissionsProperties struct {
	// The principals for the agent permissions.
	Principals []string `pulumi:"principals"`
}

// AgentPermissionsPropertiesInput is an input type that accepts AgentPermissionsPropertiesArgs and AgentPermissionsPropertiesOutput values.
// You can construct a concrete instance of `AgentPermissionsPropertiesInput` via:
//
//          AgentPermissionsPropertiesArgs{...}
type AgentPermissionsPropertiesInput interface {
	pulumi.Input

	ToAgentPermissionsPropertiesOutput() AgentPermissionsPropertiesOutput
	ToAgentPermissionsPropertiesOutputWithContext(context.Context) AgentPermissionsPropertiesOutput
}

// The agent permissions attached to this profiling group.
type AgentPermissionsPropertiesArgs struct {
	// The principals for the agent permissions.
	Principals pulumi.StringArrayInput `pulumi:"principals"`
}

func (AgentPermissionsPropertiesArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*AgentPermissionsProperties)(nil)).Elem()
}

func (i AgentPermissionsPropertiesArgs) ToAgentPermissionsPropertiesOutput() AgentPermissionsPropertiesOutput {
	return i.ToAgentPermissionsPropertiesOutputWithContext(context.Background())
}

func (i AgentPermissionsPropertiesArgs) ToAgentPermissionsPropertiesOutputWithContext(ctx context.Context) AgentPermissionsPropertiesOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AgentPermissionsPropertiesOutput)
}

func (i AgentPermissionsPropertiesArgs) ToAgentPermissionsPropertiesPtrOutput() AgentPermissionsPropertiesPtrOutput {
	return i.ToAgentPermissionsPropertiesPtrOutputWithContext(context.Background())
}

func (i AgentPermissionsPropertiesArgs) ToAgentPermissionsPropertiesPtrOutputWithContext(ctx context.Context) AgentPermissionsPropertiesPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AgentPermissionsPropertiesOutput).ToAgentPermissionsPropertiesPtrOutputWithContext(ctx)
}

// AgentPermissionsPropertiesPtrInput is an input type that accepts AgentPermissionsPropertiesArgs, AgentPermissionsPropertiesPtr and AgentPermissionsPropertiesPtrOutput values.
// You can construct a concrete instance of `AgentPermissionsPropertiesPtrInput` via:
//
//          AgentPermissionsPropertiesArgs{...}
//
//  or:
//
//          nil
type AgentPermissionsPropertiesPtrInput interface {
	pulumi.Input

	ToAgentPermissionsPropertiesPtrOutput() AgentPermissionsPropertiesPtrOutput
	ToAgentPermissionsPropertiesPtrOutputWithContext(context.Context) AgentPermissionsPropertiesPtrOutput
}

type agentPermissionsPropertiesPtrType AgentPermissionsPropertiesArgs

func AgentPermissionsPropertiesPtr(v *AgentPermissionsPropertiesArgs) AgentPermissionsPropertiesPtrInput {
	return (*agentPermissionsPropertiesPtrType)(v)
}

func (*agentPermissionsPropertiesPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**AgentPermissionsProperties)(nil)).Elem()
}

func (i *agentPermissionsPropertiesPtrType) ToAgentPermissionsPropertiesPtrOutput() AgentPermissionsPropertiesPtrOutput {
	return i.ToAgentPermissionsPropertiesPtrOutputWithContext(context.Background())
}

func (i *agentPermissionsPropertiesPtrType) ToAgentPermissionsPropertiesPtrOutputWithContext(ctx context.Context) AgentPermissionsPropertiesPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AgentPermissionsPropertiesPtrOutput)
}

// The agent permissions attached to this profiling group.
type AgentPermissionsPropertiesOutput struct{ *pulumi.OutputState }

func (AgentPermissionsPropertiesOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*AgentPermissionsProperties)(nil)).Elem()
}

func (o AgentPermissionsPropertiesOutput) ToAgentPermissionsPropertiesOutput() AgentPermissionsPropertiesOutput {
	return o
}

func (o AgentPermissionsPropertiesOutput) ToAgentPermissionsPropertiesOutputWithContext(ctx context.Context) AgentPermissionsPropertiesOutput {
	return o
}

func (o AgentPermissionsPropertiesOutput) ToAgentPermissionsPropertiesPtrOutput() AgentPermissionsPropertiesPtrOutput {
	return o.ToAgentPermissionsPropertiesPtrOutputWithContext(context.Background())
}

func (o AgentPermissionsPropertiesOutput) ToAgentPermissionsPropertiesPtrOutputWithContext(ctx context.Context) AgentPermissionsPropertiesPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v AgentPermissionsProperties) *AgentPermissionsProperties {
		return &v
	}).(AgentPermissionsPropertiesPtrOutput)
}

// The principals for the agent permissions.
func (o AgentPermissionsPropertiesOutput) Principals() pulumi.StringArrayOutput {
	return o.ApplyT(func(v AgentPermissionsProperties) []string { return v.Principals }).(pulumi.StringArrayOutput)
}

type AgentPermissionsPropertiesPtrOutput struct{ *pulumi.OutputState }

func (AgentPermissionsPropertiesPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**AgentPermissionsProperties)(nil)).Elem()
}

func (o AgentPermissionsPropertiesPtrOutput) ToAgentPermissionsPropertiesPtrOutput() AgentPermissionsPropertiesPtrOutput {
	return o
}

func (o AgentPermissionsPropertiesPtrOutput) ToAgentPermissionsPropertiesPtrOutputWithContext(ctx context.Context) AgentPermissionsPropertiesPtrOutput {
	return o
}

func (o AgentPermissionsPropertiesPtrOutput) Elem() AgentPermissionsPropertiesOutput {
	return o.ApplyT(func(v *AgentPermissionsProperties) AgentPermissionsProperties {
		if v != nil {
			return *v
		}
		var ret AgentPermissionsProperties
		return ret
	}).(AgentPermissionsPropertiesOutput)
}

// The principals for the agent permissions.
func (o AgentPermissionsPropertiesPtrOutput) Principals() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *AgentPermissionsProperties) []string {
		if v == nil {
			return nil
		}
		return v.Principals
	}).(pulumi.StringArrayOutput)
}

// Notification medium for users to get alerted for events that occur in application profile. We support SNS topic as a notification channel.
type ProfilingGroupChannel struct {
	ChannelId  *string `pulumi:"channelId"`
	ChannelUri string  `pulumi:"channelUri"`
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

// Notification medium for users to get alerted for events that occur in application profile. We support SNS topic as a notification channel.
type ProfilingGroupChannelArgs struct {
	ChannelId  pulumi.StringPtrInput `pulumi:"channelId"`
	ChannelUri pulumi.StringInput    `pulumi:"channelUri"`
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

// Notification medium for users to get alerted for events that occur in application profile. We support SNS topic as a notification channel.
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

func (o ProfilingGroupChannelOutput) ChannelId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ProfilingGroupChannel) *string { return v.ChannelId }).(pulumi.StringPtrOutput)
}

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

// A key-value pair to associate with a resource.
type ProfilingGroupTag struct {
	// The key name of the tag. You can specify a value that is 1 to 128 Unicode characters in length and cannot be prefixed with aws:. The allowed characters across services are: letters, numbers, and spaces representable in UTF-8, and the following characters: + - = . _ : / @.
	Key string `pulumi:"key"`
	// The value for the tag. You can specify a value that is 0 to 256 Unicode characters in length. The allowed characters across services are: letters, numbers, and spaces representable in UTF-8, and the following characters: + - = . _ : / @.
	Value string `pulumi:"value"`
}

// ProfilingGroupTagInput is an input type that accepts ProfilingGroupTagArgs and ProfilingGroupTagOutput values.
// You can construct a concrete instance of `ProfilingGroupTagInput` via:
//
//          ProfilingGroupTagArgs{...}
type ProfilingGroupTagInput interface {
	pulumi.Input

	ToProfilingGroupTagOutput() ProfilingGroupTagOutput
	ToProfilingGroupTagOutputWithContext(context.Context) ProfilingGroupTagOutput
}

// A key-value pair to associate with a resource.
type ProfilingGroupTagArgs struct {
	// The key name of the tag. You can specify a value that is 1 to 128 Unicode characters in length and cannot be prefixed with aws:. The allowed characters across services are: letters, numbers, and spaces representable in UTF-8, and the following characters: + - = . _ : / @.
	Key pulumi.StringInput `pulumi:"key"`
	// The value for the tag. You can specify a value that is 0 to 256 Unicode characters in length. The allowed characters across services are: letters, numbers, and spaces representable in UTF-8, and the following characters: + - = . _ : / @.
	Value pulumi.StringInput `pulumi:"value"`
}

func (ProfilingGroupTagArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ProfilingGroupTag)(nil)).Elem()
}

func (i ProfilingGroupTagArgs) ToProfilingGroupTagOutput() ProfilingGroupTagOutput {
	return i.ToProfilingGroupTagOutputWithContext(context.Background())
}

func (i ProfilingGroupTagArgs) ToProfilingGroupTagOutputWithContext(ctx context.Context) ProfilingGroupTagOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProfilingGroupTagOutput)
}

// ProfilingGroupTagArrayInput is an input type that accepts ProfilingGroupTagArray and ProfilingGroupTagArrayOutput values.
// You can construct a concrete instance of `ProfilingGroupTagArrayInput` via:
//
//          ProfilingGroupTagArray{ ProfilingGroupTagArgs{...} }
type ProfilingGroupTagArrayInput interface {
	pulumi.Input

	ToProfilingGroupTagArrayOutput() ProfilingGroupTagArrayOutput
	ToProfilingGroupTagArrayOutputWithContext(context.Context) ProfilingGroupTagArrayOutput
}

type ProfilingGroupTagArray []ProfilingGroupTagInput

func (ProfilingGroupTagArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ProfilingGroupTag)(nil)).Elem()
}

func (i ProfilingGroupTagArray) ToProfilingGroupTagArrayOutput() ProfilingGroupTagArrayOutput {
	return i.ToProfilingGroupTagArrayOutputWithContext(context.Background())
}

func (i ProfilingGroupTagArray) ToProfilingGroupTagArrayOutputWithContext(ctx context.Context) ProfilingGroupTagArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProfilingGroupTagArrayOutput)
}

// A key-value pair to associate with a resource.
type ProfilingGroupTagOutput struct{ *pulumi.OutputState }

func (ProfilingGroupTagOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ProfilingGroupTag)(nil)).Elem()
}

func (o ProfilingGroupTagOutput) ToProfilingGroupTagOutput() ProfilingGroupTagOutput {
	return o
}

func (o ProfilingGroupTagOutput) ToProfilingGroupTagOutputWithContext(ctx context.Context) ProfilingGroupTagOutput {
	return o
}

// The key name of the tag. You can specify a value that is 1 to 128 Unicode characters in length and cannot be prefixed with aws:. The allowed characters across services are: letters, numbers, and spaces representable in UTF-8, and the following characters: + - = . _ : / @.
func (o ProfilingGroupTagOutput) Key() pulumi.StringOutput {
	return o.ApplyT(func(v ProfilingGroupTag) string { return v.Key }).(pulumi.StringOutput)
}

// The value for the tag. You can specify a value that is 0 to 256 Unicode characters in length. The allowed characters across services are: letters, numbers, and spaces representable in UTF-8, and the following characters: + - = . _ : / @.
func (o ProfilingGroupTagOutput) Value() pulumi.StringOutput {
	return o.ApplyT(func(v ProfilingGroupTag) string { return v.Value }).(pulumi.StringOutput)
}

type ProfilingGroupTagArrayOutput struct{ *pulumi.OutputState }

func (ProfilingGroupTagArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ProfilingGroupTag)(nil)).Elem()
}

func (o ProfilingGroupTagArrayOutput) ToProfilingGroupTagArrayOutput() ProfilingGroupTagArrayOutput {
	return o
}

func (o ProfilingGroupTagArrayOutput) ToProfilingGroupTagArrayOutputWithContext(ctx context.Context) ProfilingGroupTagArrayOutput {
	return o
}

func (o ProfilingGroupTagArrayOutput) Index(i pulumi.IntInput) ProfilingGroupTagOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) ProfilingGroupTag {
		return vs[0].([]ProfilingGroupTag)[vs[1].(int)]
	}).(ProfilingGroupTagOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*AgentPermissionsPropertiesInput)(nil)).Elem(), AgentPermissionsPropertiesArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*AgentPermissionsPropertiesPtrInput)(nil)).Elem(), AgentPermissionsPropertiesArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*ProfilingGroupChannelInput)(nil)).Elem(), ProfilingGroupChannelArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*ProfilingGroupChannelArrayInput)(nil)).Elem(), ProfilingGroupChannelArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ProfilingGroupTagInput)(nil)).Elem(), ProfilingGroupTagArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*ProfilingGroupTagArrayInput)(nil)).Elem(), ProfilingGroupTagArray{})
	pulumi.RegisterOutputType(AgentPermissionsPropertiesOutput{})
	pulumi.RegisterOutputType(AgentPermissionsPropertiesPtrOutput{})
	pulumi.RegisterOutputType(ProfilingGroupChannelOutput{})
	pulumi.RegisterOutputType(ProfilingGroupChannelArrayOutput{})
	pulumi.RegisterOutputType(ProfilingGroupTagOutput{})
	pulumi.RegisterOutputType(ProfilingGroupTagArrayOutput{})
}
