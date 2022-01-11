// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ssmcontacts

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Information about the contact channel that SSM Incident Manager uses to engage the contact.
type ContactChannelTargetInfo struct {
	// The Amazon Resource Name (ARN) of the contact channel.
	ChannelId string `pulumi:"channelId"`
	// The number of minutes to wait to retry sending engagement in the case the engagement initially fails.
	RetryIntervalInMinutes int `pulumi:"retryIntervalInMinutes"`
}

// ContactChannelTargetInfoInput is an input type that accepts ContactChannelTargetInfoArgs and ContactChannelTargetInfoOutput values.
// You can construct a concrete instance of `ContactChannelTargetInfoInput` via:
//
//          ContactChannelTargetInfoArgs{...}
type ContactChannelTargetInfoInput interface {
	pulumi.Input

	ToContactChannelTargetInfoOutput() ContactChannelTargetInfoOutput
	ToContactChannelTargetInfoOutputWithContext(context.Context) ContactChannelTargetInfoOutput
}

// Information about the contact channel that SSM Incident Manager uses to engage the contact.
type ContactChannelTargetInfoArgs struct {
	// The Amazon Resource Name (ARN) of the contact channel.
	ChannelId pulumi.StringInput `pulumi:"channelId"`
	// The number of minutes to wait to retry sending engagement in the case the engagement initially fails.
	RetryIntervalInMinutes pulumi.IntInput `pulumi:"retryIntervalInMinutes"`
}

func (ContactChannelTargetInfoArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ContactChannelTargetInfo)(nil)).Elem()
}

func (i ContactChannelTargetInfoArgs) ToContactChannelTargetInfoOutput() ContactChannelTargetInfoOutput {
	return i.ToContactChannelTargetInfoOutputWithContext(context.Background())
}

func (i ContactChannelTargetInfoArgs) ToContactChannelTargetInfoOutputWithContext(ctx context.Context) ContactChannelTargetInfoOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ContactChannelTargetInfoOutput)
}

func (i ContactChannelTargetInfoArgs) ToContactChannelTargetInfoPtrOutput() ContactChannelTargetInfoPtrOutput {
	return i.ToContactChannelTargetInfoPtrOutputWithContext(context.Background())
}

func (i ContactChannelTargetInfoArgs) ToContactChannelTargetInfoPtrOutputWithContext(ctx context.Context) ContactChannelTargetInfoPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ContactChannelTargetInfoOutput).ToContactChannelTargetInfoPtrOutputWithContext(ctx)
}

// ContactChannelTargetInfoPtrInput is an input type that accepts ContactChannelTargetInfoArgs, ContactChannelTargetInfoPtr and ContactChannelTargetInfoPtrOutput values.
// You can construct a concrete instance of `ContactChannelTargetInfoPtrInput` via:
//
//          ContactChannelTargetInfoArgs{...}
//
//  or:
//
//          nil
type ContactChannelTargetInfoPtrInput interface {
	pulumi.Input

	ToContactChannelTargetInfoPtrOutput() ContactChannelTargetInfoPtrOutput
	ToContactChannelTargetInfoPtrOutputWithContext(context.Context) ContactChannelTargetInfoPtrOutput
}

type contactChannelTargetInfoPtrType ContactChannelTargetInfoArgs

func ContactChannelTargetInfoPtr(v *ContactChannelTargetInfoArgs) ContactChannelTargetInfoPtrInput {
	return (*contactChannelTargetInfoPtrType)(v)
}

func (*contactChannelTargetInfoPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**ContactChannelTargetInfo)(nil)).Elem()
}

func (i *contactChannelTargetInfoPtrType) ToContactChannelTargetInfoPtrOutput() ContactChannelTargetInfoPtrOutput {
	return i.ToContactChannelTargetInfoPtrOutputWithContext(context.Background())
}

func (i *contactChannelTargetInfoPtrType) ToContactChannelTargetInfoPtrOutputWithContext(ctx context.Context) ContactChannelTargetInfoPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ContactChannelTargetInfoPtrOutput)
}

// Information about the contact channel that SSM Incident Manager uses to engage the contact.
type ContactChannelTargetInfoOutput struct{ *pulumi.OutputState }

func (ContactChannelTargetInfoOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ContactChannelTargetInfo)(nil)).Elem()
}

func (o ContactChannelTargetInfoOutput) ToContactChannelTargetInfoOutput() ContactChannelTargetInfoOutput {
	return o
}

func (o ContactChannelTargetInfoOutput) ToContactChannelTargetInfoOutputWithContext(ctx context.Context) ContactChannelTargetInfoOutput {
	return o
}

func (o ContactChannelTargetInfoOutput) ToContactChannelTargetInfoPtrOutput() ContactChannelTargetInfoPtrOutput {
	return o.ToContactChannelTargetInfoPtrOutputWithContext(context.Background())
}

func (o ContactChannelTargetInfoOutput) ToContactChannelTargetInfoPtrOutputWithContext(ctx context.Context) ContactChannelTargetInfoPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v ContactChannelTargetInfo) *ContactChannelTargetInfo {
		return &v
	}).(ContactChannelTargetInfoPtrOutput)
}

// The Amazon Resource Name (ARN) of the contact channel.
func (o ContactChannelTargetInfoOutput) ChannelId() pulumi.StringOutput {
	return o.ApplyT(func(v ContactChannelTargetInfo) string { return v.ChannelId }).(pulumi.StringOutput)
}

// The number of minutes to wait to retry sending engagement in the case the engagement initially fails.
func (o ContactChannelTargetInfoOutput) RetryIntervalInMinutes() pulumi.IntOutput {
	return o.ApplyT(func(v ContactChannelTargetInfo) int { return v.RetryIntervalInMinutes }).(pulumi.IntOutput)
}

type ContactChannelTargetInfoPtrOutput struct{ *pulumi.OutputState }

func (ContactChannelTargetInfoPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ContactChannelTargetInfo)(nil)).Elem()
}

func (o ContactChannelTargetInfoPtrOutput) ToContactChannelTargetInfoPtrOutput() ContactChannelTargetInfoPtrOutput {
	return o
}

func (o ContactChannelTargetInfoPtrOutput) ToContactChannelTargetInfoPtrOutputWithContext(ctx context.Context) ContactChannelTargetInfoPtrOutput {
	return o
}

func (o ContactChannelTargetInfoPtrOutput) Elem() ContactChannelTargetInfoOutput {
	return o.ApplyT(func(v *ContactChannelTargetInfo) ContactChannelTargetInfo {
		if v != nil {
			return *v
		}
		var ret ContactChannelTargetInfo
		return ret
	}).(ContactChannelTargetInfoOutput)
}

// The Amazon Resource Name (ARN) of the contact channel.
func (o ContactChannelTargetInfoPtrOutput) ChannelId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ContactChannelTargetInfo) *string {
		if v == nil {
			return nil
		}
		return &v.ChannelId
	}).(pulumi.StringPtrOutput)
}

// The number of minutes to wait to retry sending engagement in the case the engagement initially fails.
func (o ContactChannelTargetInfoPtrOutput) RetryIntervalInMinutes() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *ContactChannelTargetInfo) *int {
		if v == nil {
			return nil
		}
		return &v.RetryIntervalInMinutes
	}).(pulumi.IntPtrOutput)
}

// A set amount of time that an escalation plan or engagement plan engages the specified contacts or contact methods.
type ContactStage struct {
	// The time to wait until beginning the next stage.
	DurationInMinutes int `pulumi:"durationInMinutes"`
	// The contacts or contact methods that the escalation plan or engagement plan is engaging.
	Targets []ContactTargets `pulumi:"targets"`
}

// ContactStageInput is an input type that accepts ContactStageArgs and ContactStageOutput values.
// You can construct a concrete instance of `ContactStageInput` via:
//
//          ContactStageArgs{...}
type ContactStageInput interface {
	pulumi.Input

	ToContactStageOutput() ContactStageOutput
	ToContactStageOutputWithContext(context.Context) ContactStageOutput
}

// A set amount of time that an escalation plan or engagement plan engages the specified contacts or contact methods.
type ContactStageArgs struct {
	// The time to wait until beginning the next stage.
	DurationInMinutes pulumi.IntInput `pulumi:"durationInMinutes"`
	// The contacts or contact methods that the escalation plan or engagement plan is engaging.
	Targets ContactTargetsArrayInput `pulumi:"targets"`
}

func (ContactStageArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ContactStage)(nil)).Elem()
}

func (i ContactStageArgs) ToContactStageOutput() ContactStageOutput {
	return i.ToContactStageOutputWithContext(context.Background())
}

func (i ContactStageArgs) ToContactStageOutputWithContext(ctx context.Context) ContactStageOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ContactStageOutput)
}

// ContactStageArrayInput is an input type that accepts ContactStageArray and ContactStageArrayOutput values.
// You can construct a concrete instance of `ContactStageArrayInput` via:
//
//          ContactStageArray{ ContactStageArgs{...} }
type ContactStageArrayInput interface {
	pulumi.Input

	ToContactStageArrayOutput() ContactStageArrayOutput
	ToContactStageArrayOutputWithContext(context.Context) ContactStageArrayOutput
}

type ContactStageArray []ContactStageInput

func (ContactStageArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ContactStage)(nil)).Elem()
}

func (i ContactStageArray) ToContactStageArrayOutput() ContactStageArrayOutput {
	return i.ToContactStageArrayOutputWithContext(context.Background())
}

func (i ContactStageArray) ToContactStageArrayOutputWithContext(ctx context.Context) ContactStageArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ContactStageArrayOutput)
}

// A set amount of time that an escalation plan or engagement plan engages the specified contacts or contact methods.
type ContactStageOutput struct{ *pulumi.OutputState }

func (ContactStageOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ContactStage)(nil)).Elem()
}

func (o ContactStageOutput) ToContactStageOutput() ContactStageOutput {
	return o
}

func (o ContactStageOutput) ToContactStageOutputWithContext(ctx context.Context) ContactStageOutput {
	return o
}

// The time to wait until beginning the next stage.
func (o ContactStageOutput) DurationInMinutes() pulumi.IntOutput {
	return o.ApplyT(func(v ContactStage) int { return v.DurationInMinutes }).(pulumi.IntOutput)
}

// The contacts or contact methods that the escalation plan or engagement plan is engaging.
func (o ContactStageOutput) Targets() ContactTargetsArrayOutput {
	return o.ApplyT(func(v ContactStage) []ContactTargets { return v.Targets }).(ContactTargetsArrayOutput)
}

type ContactStageArrayOutput struct{ *pulumi.OutputState }

func (ContactStageArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ContactStage)(nil)).Elem()
}

func (o ContactStageArrayOutput) ToContactStageArrayOutput() ContactStageArrayOutput {
	return o
}

func (o ContactStageArrayOutput) ToContactStageArrayOutputWithContext(ctx context.Context) ContactStageArrayOutput {
	return o
}

func (o ContactStageArrayOutput) Index(i pulumi.IntInput) ContactStageOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) ContactStage {
		return vs[0].([]ContactStage)[vs[1].(int)]
	}).(ContactStageOutput)
}

// The contact that SSM Incident Manager is engaging during an incident.
type ContactTargetInfo struct {
	// The Amazon Resource Name (ARN) of the contact.
	ContactId string `pulumi:"contactId"`
	// A Boolean value determining if the contact's acknowledgement stops the progress of stages in the plan.
	IsEssential bool `pulumi:"isEssential"`
}

// ContactTargetInfoInput is an input type that accepts ContactTargetInfoArgs and ContactTargetInfoOutput values.
// You can construct a concrete instance of `ContactTargetInfoInput` via:
//
//          ContactTargetInfoArgs{...}
type ContactTargetInfoInput interface {
	pulumi.Input

	ToContactTargetInfoOutput() ContactTargetInfoOutput
	ToContactTargetInfoOutputWithContext(context.Context) ContactTargetInfoOutput
}

// The contact that SSM Incident Manager is engaging during an incident.
type ContactTargetInfoArgs struct {
	// The Amazon Resource Name (ARN) of the contact.
	ContactId pulumi.StringInput `pulumi:"contactId"`
	// A Boolean value determining if the contact's acknowledgement stops the progress of stages in the plan.
	IsEssential pulumi.BoolInput `pulumi:"isEssential"`
}

func (ContactTargetInfoArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ContactTargetInfo)(nil)).Elem()
}

func (i ContactTargetInfoArgs) ToContactTargetInfoOutput() ContactTargetInfoOutput {
	return i.ToContactTargetInfoOutputWithContext(context.Background())
}

func (i ContactTargetInfoArgs) ToContactTargetInfoOutputWithContext(ctx context.Context) ContactTargetInfoOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ContactTargetInfoOutput)
}

func (i ContactTargetInfoArgs) ToContactTargetInfoPtrOutput() ContactTargetInfoPtrOutput {
	return i.ToContactTargetInfoPtrOutputWithContext(context.Background())
}

func (i ContactTargetInfoArgs) ToContactTargetInfoPtrOutputWithContext(ctx context.Context) ContactTargetInfoPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ContactTargetInfoOutput).ToContactTargetInfoPtrOutputWithContext(ctx)
}

// ContactTargetInfoPtrInput is an input type that accepts ContactTargetInfoArgs, ContactTargetInfoPtr and ContactTargetInfoPtrOutput values.
// You can construct a concrete instance of `ContactTargetInfoPtrInput` via:
//
//          ContactTargetInfoArgs{...}
//
//  or:
//
//          nil
type ContactTargetInfoPtrInput interface {
	pulumi.Input

	ToContactTargetInfoPtrOutput() ContactTargetInfoPtrOutput
	ToContactTargetInfoPtrOutputWithContext(context.Context) ContactTargetInfoPtrOutput
}

type contactTargetInfoPtrType ContactTargetInfoArgs

func ContactTargetInfoPtr(v *ContactTargetInfoArgs) ContactTargetInfoPtrInput {
	return (*contactTargetInfoPtrType)(v)
}

func (*contactTargetInfoPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**ContactTargetInfo)(nil)).Elem()
}

func (i *contactTargetInfoPtrType) ToContactTargetInfoPtrOutput() ContactTargetInfoPtrOutput {
	return i.ToContactTargetInfoPtrOutputWithContext(context.Background())
}

func (i *contactTargetInfoPtrType) ToContactTargetInfoPtrOutputWithContext(ctx context.Context) ContactTargetInfoPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ContactTargetInfoPtrOutput)
}

// The contact that SSM Incident Manager is engaging during an incident.
type ContactTargetInfoOutput struct{ *pulumi.OutputState }

func (ContactTargetInfoOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ContactTargetInfo)(nil)).Elem()
}

func (o ContactTargetInfoOutput) ToContactTargetInfoOutput() ContactTargetInfoOutput {
	return o
}

func (o ContactTargetInfoOutput) ToContactTargetInfoOutputWithContext(ctx context.Context) ContactTargetInfoOutput {
	return o
}

func (o ContactTargetInfoOutput) ToContactTargetInfoPtrOutput() ContactTargetInfoPtrOutput {
	return o.ToContactTargetInfoPtrOutputWithContext(context.Background())
}

func (o ContactTargetInfoOutput) ToContactTargetInfoPtrOutputWithContext(ctx context.Context) ContactTargetInfoPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v ContactTargetInfo) *ContactTargetInfo {
		return &v
	}).(ContactTargetInfoPtrOutput)
}

// The Amazon Resource Name (ARN) of the contact.
func (o ContactTargetInfoOutput) ContactId() pulumi.StringOutput {
	return o.ApplyT(func(v ContactTargetInfo) string { return v.ContactId }).(pulumi.StringOutput)
}

// A Boolean value determining if the contact's acknowledgement stops the progress of stages in the plan.
func (o ContactTargetInfoOutput) IsEssential() pulumi.BoolOutput {
	return o.ApplyT(func(v ContactTargetInfo) bool { return v.IsEssential }).(pulumi.BoolOutput)
}

type ContactTargetInfoPtrOutput struct{ *pulumi.OutputState }

func (ContactTargetInfoPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ContactTargetInfo)(nil)).Elem()
}

func (o ContactTargetInfoPtrOutput) ToContactTargetInfoPtrOutput() ContactTargetInfoPtrOutput {
	return o
}

func (o ContactTargetInfoPtrOutput) ToContactTargetInfoPtrOutputWithContext(ctx context.Context) ContactTargetInfoPtrOutput {
	return o
}

func (o ContactTargetInfoPtrOutput) Elem() ContactTargetInfoOutput {
	return o.ApplyT(func(v *ContactTargetInfo) ContactTargetInfo {
		if v != nil {
			return *v
		}
		var ret ContactTargetInfo
		return ret
	}).(ContactTargetInfoOutput)
}

// The Amazon Resource Name (ARN) of the contact.
func (o ContactTargetInfoPtrOutput) ContactId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ContactTargetInfo) *string {
		if v == nil {
			return nil
		}
		return &v.ContactId
	}).(pulumi.StringPtrOutput)
}

// A Boolean value determining if the contact's acknowledgement stops the progress of stages in the plan.
func (o ContactTargetInfoPtrOutput) IsEssential() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *ContactTargetInfo) *bool {
		if v == nil {
			return nil
		}
		return &v.IsEssential
	}).(pulumi.BoolPtrOutput)
}

// The contacts or contact methods that the escalation plan or engagement plan is engaging.
type ContactTargets struct {
	ChannelTargetInfo *ContactChannelTargetInfo `pulumi:"channelTargetInfo"`
	ContactTargetInfo *ContactTargetInfo        `pulumi:"contactTargetInfo"`
}

// ContactTargetsInput is an input type that accepts ContactTargetsArgs and ContactTargetsOutput values.
// You can construct a concrete instance of `ContactTargetsInput` via:
//
//          ContactTargetsArgs{...}
type ContactTargetsInput interface {
	pulumi.Input

	ToContactTargetsOutput() ContactTargetsOutput
	ToContactTargetsOutputWithContext(context.Context) ContactTargetsOutput
}

// The contacts or contact methods that the escalation plan or engagement plan is engaging.
type ContactTargetsArgs struct {
	ChannelTargetInfo ContactChannelTargetInfoPtrInput `pulumi:"channelTargetInfo"`
	ContactTargetInfo ContactTargetInfoPtrInput        `pulumi:"contactTargetInfo"`
}

func (ContactTargetsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ContactTargets)(nil)).Elem()
}

func (i ContactTargetsArgs) ToContactTargetsOutput() ContactTargetsOutput {
	return i.ToContactTargetsOutputWithContext(context.Background())
}

func (i ContactTargetsArgs) ToContactTargetsOutputWithContext(ctx context.Context) ContactTargetsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ContactTargetsOutput)
}

// ContactTargetsArrayInput is an input type that accepts ContactTargetsArray and ContactTargetsArrayOutput values.
// You can construct a concrete instance of `ContactTargetsArrayInput` via:
//
//          ContactTargetsArray{ ContactTargetsArgs{...} }
type ContactTargetsArrayInput interface {
	pulumi.Input

	ToContactTargetsArrayOutput() ContactTargetsArrayOutput
	ToContactTargetsArrayOutputWithContext(context.Context) ContactTargetsArrayOutput
}

type ContactTargetsArray []ContactTargetsInput

func (ContactTargetsArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ContactTargets)(nil)).Elem()
}

func (i ContactTargetsArray) ToContactTargetsArrayOutput() ContactTargetsArrayOutput {
	return i.ToContactTargetsArrayOutputWithContext(context.Background())
}

func (i ContactTargetsArray) ToContactTargetsArrayOutputWithContext(ctx context.Context) ContactTargetsArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ContactTargetsArrayOutput)
}

// The contacts or contact methods that the escalation plan or engagement plan is engaging.
type ContactTargetsOutput struct{ *pulumi.OutputState }

func (ContactTargetsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ContactTargets)(nil)).Elem()
}

func (o ContactTargetsOutput) ToContactTargetsOutput() ContactTargetsOutput {
	return o
}

func (o ContactTargetsOutput) ToContactTargetsOutputWithContext(ctx context.Context) ContactTargetsOutput {
	return o
}

func (o ContactTargetsOutput) ChannelTargetInfo() ContactChannelTargetInfoPtrOutput {
	return o.ApplyT(func(v ContactTargets) *ContactChannelTargetInfo { return v.ChannelTargetInfo }).(ContactChannelTargetInfoPtrOutput)
}

func (o ContactTargetsOutput) ContactTargetInfo() ContactTargetInfoPtrOutput {
	return o.ApplyT(func(v ContactTargets) *ContactTargetInfo { return v.ContactTargetInfo }).(ContactTargetInfoPtrOutput)
}

type ContactTargetsArrayOutput struct{ *pulumi.OutputState }

func (ContactTargetsArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ContactTargets)(nil)).Elem()
}

func (o ContactTargetsArrayOutput) ToContactTargetsArrayOutput() ContactTargetsArrayOutput {
	return o
}

func (o ContactTargetsArrayOutput) ToContactTargetsArrayOutputWithContext(ctx context.Context) ContactTargetsArrayOutput {
	return o
}

func (o ContactTargetsArrayOutput) Index(i pulumi.IntInput) ContactTargetsOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) ContactTargets {
		return vs[0].([]ContactTargets)[vs[1].(int)]
	}).(ContactTargetsOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ContactChannelTargetInfoInput)(nil)).Elem(), ContactChannelTargetInfoArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*ContactChannelTargetInfoPtrInput)(nil)).Elem(), ContactChannelTargetInfoArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*ContactStageInput)(nil)).Elem(), ContactStageArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*ContactStageArrayInput)(nil)).Elem(), ContactStageArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ContactTargetInfoInput)(nil)).Elem(), ContactTargetInfoArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*ContactTargetInfoPtrInput)(nil)).Elem(), ContactTargetInfoArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*ContactTargetsInput)(nil)).Elem(), ContactTargetsArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*ContactTargetsArrayInput)(nil)).Elem(), ContactTargetsArray{})
	pulumi.RegisterOutputType(ContactChannelTargetInfoOutput{})
	pulumi.RegisterOutputType(ContactChannelTargetInfoPtrOutput{})
	pulumi.RegisterOutputType(ContactStageOutput{})
	pulumi.RegisterOutputType(ContactStageArrayOutput{})
	pulumi.RegisterOutputType(ContactTargetInfoOutput{})
	pulumi.RegisterOutputType(ContactTargetInfoPtrOutput{})
	pulumi.RegisterOutputType(ContactTargetsOutput{})
	pulumi.RegisterOutputType(ContactTargetsArrayOutput{})
}
