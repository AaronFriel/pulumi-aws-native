// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package signer

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type SigningProfileSignatureValidityPeriod struct {
	Type  *SigningProfileSignatureValidityPeriodType `pulumi:"type"`
	Value *int                                       `pulumi:"value"`
}

// SigningProfileSignatureValidityPeriodInput is an input type that accepts SigningProfileSignatureValidityPeriodArgs and SigningProfileSignatureValidityPeriodOutput values.
// You can construct a concrete instance of `SigningProfileSignatureValidityPeriodInput` via:
//
//          SigningProfileSignatureValidityPeriodArgs{...}
type SigningProfileSignatureValidityPeriodInput interface {
	pulumi.Input

	ToSigningProfileSignatureValidityPeriodOutput() SigningProfileSignatureValidityPeriodOutput
	ToSigningProfileSignatureValidityPeriodOutputWithContext(context.Context) SigningProfileSignatureValidityPeriodOutput
}

type SigningProfileSignatureValidityPeriodArgs struct {
	Type  SigningProfileSignatureValidityPeriodTypePtrInput `pulumi:"type"`
	Value pulumi.IntPtrInput                                `pulumi:"value"`
}

func (SigningProfileSignatureValidityPeriodArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*SigningProfileSignatureValidityPeriod)(nil)).Elem()
}

func (i SigningProfileSignatureValidityPeriodArgs) ToSigningProfileSignatureValidityPeriodOutput() SigningProfileSignatureValidityPeriodOutput {
	return i.ToSigningProfileSignatureValidityPeriodOutputWithContext(context.Background())
}

func (i SigningProfileSignatureValidityPeriodArgs) ToSigningProfileSignatureValidityPeriodOutputWithContext(ctx context.Context) SigningProfileSignatureValidityPeriodOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SigningProfileSignatureValidityPeriodOutput)
}

func (i SigningProfileSignatureValidityPeriodArgs) ToSigningProfileSignatureValidityPeriodPtrOutput() SigningProfileSignatureValidityPeriodPtrOutput {
	return i.ToSigningProfileSignatureValidityPeriodPtrOutputWithContext(context.Background())
}

func (i SigningProfileSignatureValidityPeriodArgs) ToSigningProfileSignatureValidityPeriodPtrOutputWithContext(ctx context.Context) SigningProfileSignatureValidityPeriodPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SigningProfileSignatureValidityPeriodOutput).ToSigningProfileSignatureValidityPeriodPtrOutputWithContext(ctx)
}

// SigningProfileSignatureValidityPeriodPtrInput is an input type that accepts SigningProfileSignatureValidityPeriodArgs, SigningProfileSignatureValidityPeriodPtr and SigningProfileSignatureValidityPeriodPtrOutput values.
// You can construct a concrete instance of `SigningProfileSignatureValidityPeriodPtrInput` via:
//
//          SigningProfileSignatureValidityPeriodArgs{...}
//
//  or:
//
//          nil
type SigningProfileSignatureValidityPeriodPtrInput interface {
	pulumi.Input

	ToSigningProfileSignatureValidityPeriodPtrOutput() SigningProfileSignatureValidityPeriodPtrOutput
	ToSigningProfileSignatureValidityPeriodPtrOutputWithContext(context.Context) SigningProfileSignatureValidityPeriodPtrOutput
}

type signingProfileSignatureValidityPeriodPtrType SigningProfileSignatureValidityPeriodArgs

func SigningProfileSignatureValidityPeriodPtr(v *SigningProfileSignatureValidityPeriodArgs) SigningProfileSignatureValidityPeriodPtrInput {
	return (*signingProfileSignatureValidityPeriodPtrType)(v)
}

func (*signingProfileSignatureValidityPeriodPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**SigningProfileSignatureValidityPeriod)(nil)).Elem()
}

func (i *signingProfileSignatureValidityPeriodPtrType) ToSigningProfileSignatureValidityPeriodPtrOutput() SigningProfileSignatureValidityPeriodPtrOutput {
	return i.ToSigningProfileSignatureValidityPeriodPtrOutputWithContext(context.Background())
}

func (i *signingProfileSignatureValidityPeriodPtrType) ToSigningProfileSignatureValidityPeriodPtrOutputWithContext(ctx context.Context) SigningProfileSignatureValidityPeriodPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SigningProfileSignatureValidityPeriodPtrOutput)
}

type SigningProfileSignatureValidityPeriodOutput struct{ *pulumi.OutputState }

func (SigningProfileSignatureValidityPeriodOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SigningProfileSignatureValidityPeriod)(nil)).Elem()
}

func (o SigningProfileSignatureValidityPeriodOutput) ToSigningProfileSignatureValidityPeriodOutput() SigningProfileSignatureValidityPeriodOutput {
	return o
}

func (o SigningProfileSignatureValidityPeriodOutput) ToSigningProfileSignatureValidityPeriodOutputWithContext(ctx context.Context) SigningProfileSignatureValidityPeriodOutput {
	return o
}

func (o SigningProfileSignatureValidityPeriodOutput) ToSigningProfileSignatureValidityPeriodPtrOutput() SigningProfileSignatureValidityPeriodPtrOutput {
	return o.ToSigningProfileSignatureValidityPeriodPtrOutputWithContext(context.Background())
}

func (o SigningProfileSignatureValidityPeriodOutput) ToSigningProfileSignatureValidityPeriodPtrOutputWithContext(ctx context.Context) SigningProfileSignatureValidityPeriodPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v SigningProfileSignatureValidityPeriod) *SigningProfileSignatureValidityPeriod {
		return &v
	}).(SigningProfileSignatureValidityPeriodPtrOutput)
}

func (o SigningProfileSignatureValidityPeriodOutput) Type() SigningProfileSignatureValidityPeriodTypePtrOutput {
	return o.ApplyT(func(v SigningProfileSignatureValidityPeriod) *SigningProfileSignatureValidityPeriodType {
		return v.Type
	}).(SigningProfileSignatureValidityPeriodTypePtrOutput)
}

func (o SigningProfileSignatureValidityPeriodOutput) Value() pulumi.IntPtrOutput {
	return o.ApplyT(func(v SigningProfileSignatureValidityPeriod) *int { return v.Value }).(pulumi.IntPtrOutput)
}

type SigningProfileSignatureValidityPeriodPtrOutput struct{ *pulumi.OutputState }

func (SigningProfileSignatureValidityPeriodPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**SigningProfileSignatureValidityPeriod)(nil)).Elem()
}

func (o SigningProfileSignatureValidityPeriodPtrOutput) ToSigningProfileSignatureValidityPeriodPtrOutput() SigningProfileSignatureValidityPeriodPtrOutput {
	return o
}

func (o SigningProfileSignatureValidityPeriodPtrOutput) ToSigningProfileSignatureValidityPeriodPtrOutputWithContext(ctx context.Context) SigningProfileSignatureValidityPeriodPtrOutput {
	return o
}

func (o SigningProfileSignatureValidityPeriodPtrOutput) Elem() SigningProfileSignatureValidityPeriodOutput {
	return o.ApplyT(func(v *SigningProfileSignatureValidityPeriod) SigningProfileSignatureValidityPeriod {
		if v != nil {
			return *v
		}
		var ret SigningProfileSignatureValidityPeriod
		return ret
	}).(SigningProfileSignatureValidityPeriodOutput)
}

func (o SigningProfileSignatureValidityPeriodPtrOutput) Type() SigningProfileSignatureValidityPeriodTypePtrOutput {
	return o.ApplyT(func(v *SigningProfileSignatureValidityPeriod) *SigningProfileSignatureValidityPeriodType {
		if v == nil {
			return nil
		}
		return v.Type
	}).(SigningProfileSignatureValidityPeriodTypePtrOutput)
}

func (o SigningProfileSignatureValidityPeriodPtrOutput) Value() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *SigningProfileSignatureValidityPeriod) *int {
		if v == nil {
			return nil
		}
		return v.Value
	}).(pulumi.IntPtrOutput)
}

type SigningProfileTag struct {
	Key   *string `pulumi:"key"`
	Value *string `pulumi:"value"`
}

// SigningProfileTagInput is an input type that accepts SigningProfileTagArgs and SigningProfileTagOutput values.
// You can construct a concrete instance of `SigningProfileTagInput` via:
//
//          SigningProfileTagArgs{...}
type SigningProfileTagInput interface {
	pulumi.Input

	ToSigningProfileTagOutput() SigningProfileTagOutput
	ToSigningProfileTagOutputWithContext(context.Context) SigningProfileTagOutput
}

type SigningProfileTagArgs struct {
	Key   pulumi.StringPtrInput `pulumi:"key"`
	Value pulumi.StringPtrInput `pulumi:"value"`
}

func (SigningProfileTagArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*SigningProfileTag)(nil)).Elem()
}

func (i SigningProfileTagArgs) ToSigningProfileTagOutput() SigningProfileTagOutput {
	return i.ToSigningProfileTagOutputWithContext(context.Background())
}

func (i SigningProfileTagArgs) ToSigningProfileTagOutputWithContext(ctx context.Context) SigningProfileTagOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SigningProfileTagOutput)
}

// SigningProfileTagArrayInput is an input type that accepts SigningProfileTagArray and SigningProfileTagArrayOutput values.
// You can construct a concrete instance of `SigningProfileTagArrayInput` via:
//
//          SigningProfileTagArray{ SigningProfileTagArgs{...} }
type SigningProfileTagArrayInput interface {
	pulumi.Input

	ToSigningProfileTagArrayOutput() SigningProfileTagArrayOutput
	ToSigningProfileTagArrayOutputWithContext(context.Context) SigningProfileTagArrayOutput
}

type SigningProfileTagArray []SigningProfileTagInput

func (SigningProfileTagArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]SigningProfileTag)(nil)).Elem()
}

func (i SigningProfileTagArray) ToSigningProfileTagArrayOutput() SigningProfileTagArrayOutput {
	return i.ToSigningProfileTagArrayOutputWithContext(context.Background())
}

func (i SigningProfileTagArray) ToSigningProfileTagArrayOutputWithContext(ctx context.Context) SigningProfileTagArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SigningProfileTagArrayOutput)
}

type SigningProfileTagOutput struct{ *pulumi.OutputState }

func (SigningProfileTagOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SigningProfileTag)(nil)).Elem()
}

func (o SigningProfileTagOutput) ToSigningProfileTagOutput() SigningProfileTagOutput {
	return o
}

func (o SigningProfileTagOutput) ToSigningProfileTagOutputWithContext(ctx context.Context) SigningProfileTagOutput {
	return o
}

func (o SigningProfileTagOutput) Key() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SigningProfileTag) *string { return v.Key }).(pulumi.StringPtrOutput)
}

func (o SigningProfileTagOutput) Value() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SigningProfileTag) *string { return v.Value }).(pulumi.StringPtrOutput)
}

type SigningProfileTagArrayOutput struct{ *pulumi.OutputState }

func (SigningProfileTagArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]SigningProfileTag)(nil)).Elem()
}

func (o SigningProfileTagArrayOutput) ToSigningProfileTagArrayOutput() SigningProfileTagArrayOutput {
	return o
}

func (o SigningProfileTagArrayOutput) ToSigningProfileTagArrayOutputWithContext(ctx context.Context) SigningProfileTagArrayOutput {
	return o
}

func (o SigningProfileTagArrayOutput) Index(i pulumi.IntInput) SigningProfileTagOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) SigningProfileTag {
		return vs[0].([]SigningProfileTag)[vs[1].(int)]
	}).(SigningProfileTagOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*SigningProfileSignatureValidityPeriodInput)(nil)).Elem(), SigningProfileSignatureValidityPeriodArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*SigningProfileSignatureValidityPeriodPtrInput)(nil)).Elem(), SigningProfileSignatureValidityPeriodArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*SigningProfileTagInput)(nil)).Elem(), SigningProfileTagArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*SigningProfileTagArrayInput)(nil)).Elem(), SigningProfileTagArray{})
	pulumi.RegisterOutputType(SigningProfileSignatureValidityPeriodOutput{})
	pulumi.RegisterOutputType(SigningProfileSignatureValidityPeriodPtrOutput{})
	pulumi.RegisterOutputType(SigningProfileTagOutput{})
	pulumi.RegisterOutputType(SigningProfileTagArrayOutput{})
}
