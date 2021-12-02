// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package lex

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type BotAliasStatus string

const (
	BotAliasStatusCreating  = BotAliasStatus("Creating")
	BotAliasStatusAvailable = BotAliasStatus("Available")
	BotAliasStatusDeleting  = BotAliasStatus("Deleting")
	BotAliasStatusFailed    = BotAliasStatus("Failed")
)

func (BotAliasStatus) ElementType() reflect.Type {
	return reflect.TypeOf((*BotAliasStatus)(nil)).Elem()
}

func (e BotAliasStatus) ToBotAliasStatusOutput() BotAliasStatusOutput {
	return pulumi.ToOutput(e).(BotAliasStatusOutput)
}

func (e BotAliasStatus) ToBotAliasStatusOutputWithContext(ctx context.Context) BotAliasStatusOutput {
	return pulumi.ToOutputWithContext(ctx, e).(BotAliasStatusOutput)
}

func (e BotAliasStatus) ToBotAliasStatusPtrOutput() BotAliasStatusPtrOutput {
	return e.ToBotAliasStatusPtrOutputWithContext(context.Background())
}

func (e BotAliasStatus) ToBotAliasStatusPtrOutputWithContext(ctx context.Context) BotAliasStatusPtrOutput {
	return BotAliasStatus(e).ToBotAliasStatusOutputWithContext(ctx).ToBotAliasStatusPtrOutputWithContext(ctx)
}

func (e BotAliasStatus) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e BotAliasStatus) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e BotAliasStatus) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e BotAliasStatus) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type BotAliasStatusOutput struct{ *pulumi.OutputState }

func (BotAliasStatusOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*BotAliasStatus)(nil)).Elem()
}

func (o BotAliasStatusOutput) ToBotAliasStatusOutput() BotAliasStatusOutput {
	return o
}

func (o BotAliasStatusOutput) ToBotAliasStatusOutputWithContext(ctx context.Context) BotAliasStatusOutput {
	return o
}

func (o BotAliasStatusOutput) ToBotAliasStatusPtrOutput() BotAliasStatusPtrOutput {
	return o.ToBotAliasStatusPtrOutputWithContext(context.Background())
}

func (o BotAliasStatusOutput) ToBotAliasStatusPtrOutputWithContext(ctx context.Context) BotAliasStatusPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v BotAliasStatus) *BotAliasStatus {
		return &v
	}).(BotAliasStatusPtrOutput)
}

func (o BotAliasStatusOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o BotAliasStatusOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e BotAliasStatus) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o BotAliasStatusOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o BotAliasStatusOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e BotAliasStatus) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type BotAliasStatusPtrOutput struct{ *pulumi.OutputState }

func (BotAliasStatusPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**BotAliasStatus)(nil)).Elem()
}

func (o BotAliasStatusPtrOutput) ToBotAliasStatusPtrOutput() BotAliasStatusPtrOutput {
	return o
}

func (o BotAliasStatusPtrOutput) ToBotAliasStatusPtrOutputWithContext(ctx context.Context) BotAliasStatusPtrOutput {
	return o
}

func (o BotAliasStatusPtrOutput) Elem() BotAliasStatusOutput {
	return o.ApplyT(func(v *BotAliasStatus) BotAliasStatus {
		if v != nil {
			return *v
		}
		var ret BotAliasStatus
		return ret
	}).(BotAliasStatusOutput)
}

func (o BotAliasStatusPtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o BotAliasStatusPtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *BotAliasStatus) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// BotAliasStatusInput is an input type that accepts BotAliasStatusArgs and BotAliasStatusOutput values.
// You can construct a concrete instance of `BotAliasStatusInput` via:
//
//          BotAliasStatusArgs{...}
type BotAliasStatusInput interface {
	pulumi.Input

	ToBotAliasStatusOutput() BotAliasStatusOutput
	ToBotAliasStatusOutputWithContext(context.Context) BotAliasStatusOutput
}

var botAliasStatusPtrType = reflect.TypeOf((**BotAliasStatus)(nil)).Elem()

type BotAliasStatusPtrInput interface {
	pulumi.Input

	ToBotAliasStatusPtrOutput() BotAliasStatusPtrOutput
	ToBotAliasStatusPtrOutputWithContext(context.Context) BotAliasStatusPtrOutput
}

type botAliasStatusPtr string

func BotAliasStatusPtr(v string) BotAliasStatusPtrInput {
	return (*botAliasStatusPtr)(&v)
}

func (*botAliasStatusPtr) ElementType() reflect.Type {
	return botAliasStatusPtrType
}

func (in *botAliasStatusPtr) ToBotAliasStatusPtrOutput() BotAliasStatusPtrOutput {
	return pulumi.ToOutput(in).(BotAliasStatusPtrOutput)
}

func (in *botAliasStatusPtr) ToBotAliasStatusPtrOutputWithContext(ctx context.Context) BotAliasStatusPtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(BotAliasStatusPtrOutput)
}

// Value that determines whether Amazon Lex obscures slot values in conversation logs. The default is to obscure the values.
type BotObfuscationSettingObfuscationSettingType string

const (
	BotObfuscationSettingObfuscationSettingTypeNone               = BotObfuscationSettingObfuscationSettingType("None")
	BotObfuscationSettingObfuscationSettingTypeDefaultObfuscation = BotObfuscationSettingObfuscationSettingType("DefaultObfuscation")
)

func (BotObfuscationSettingObfuscationSettingType) ElementType() reflect.Type {
	return reflect.TypeOf((*BotObfuscationSettingObfuscationSettingType)(nil)).Elem()
}

func (e BotObfuscationSettingObfuscationSettingType) ToBotObfuscationSettingObfuscationSettingTypeOutput() BotObfuscationSettingObfuscationSettingTypeOutput {
	return pulumi.ToOutput(e).(BotObfuscationSettingObfuscationSettingTypeOutput)
}

func (e BotObfuscationSettingObfuscationSettingType) ToBotObfuscationSettingObfuscationSettingTypeOutputWithContext(ctx context.Context) BotObfuscationSettingObfuscationSettingTypeOutput {
	return pulumi.ToOutputWithContext(ctx, e).(BotObfuscationSettingObfuscationSettingTypeOutput)
}

func (e BotObfuscationSettingObfuscationSettingType) ToBotObfuscationSettingObfuscationSettingTypePtrOutput() BotObfuscationSettingObfuscationSettingTypePtrOutput {
	return e.ToBotObfuscationSettingObfuscationSettingTypePtrOutputWithContext(context.Background())
}

func (e BotObfuscationSettingObfuscationSettingType) ToBotObfuscationSettingObfuscationSettingTypePtrOutputWithContext(ctx context.Context) BotObfuscationSettingObfuscationSettingTypePtrOutput {
	return BotObfuscationSettingObfuscationSettingType(e).ToBotObfuscationSettingObfuscationSettingTypeOutputWithContext(ctx).ToBotObfuscationSettingObfuscationSettingTypePtrOutputWithContext(ctx)
}

func (e BotObfuscationSettingObfuscationSettingType) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e BotObfuscationSettingObfuscationSettingType) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e BotObfuscationSettingObfuscationSettingType) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e BotObfuscationSettingObfuscationSettingType) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type BotObfuscationSettingObfuscationSettingTypeOutput struct{ *pulumi.OutputState }

func (BotObfuscationSettingObfuscationSettingTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*BotObfuscationSettingObfuscationSettingType)(nil)).Elem()
}

func (o BotObfuscationSettingObfuscationSettingTypeOutput) ToBotObfuscationSettingObfuscationSettingTypeOutput() BotObfuscationSettingObfuscationSettingTypeOutput {
	return o
}

func (o BotObfuscationSettingObfuscationSettingTypeOutput) ToBotObfuscationSettingObfuscationSettingTypeOutputWithContext(ctx context.Context) BotObfuscationSettingObfuscationSettingTypeOutput {
	return o
}

func (o BotObfuscationSettingObfuscationSettingTypeOutput) ToBotObfuscationSettingObfuscationSettingTypePtrOutput() BotObfuscationSettingObfuscationSettingTypePtrOutput {
	return o.ToBotObfuscationSettingObfuscationSettingTypePtrOutputWithContext(context.Background())
}

func (o BotObfuscationSettingObfuscationSettingTypeOutput) ToBotObfuscationSettingObfuscationSettingTypePtrOutputWithContext(ctx context.Context) BotObfuscationSettingObfuscationSettingTypePtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v BotObfuscationSettingObfuscationSettingType) *BotObfuscationSettingObfuscationSettingType {
		return &v
	}).(BotObfuscationSettingObfuscationSettingTypePtrOutput)
}

func (o BotObfuscationSettingObfuscationSettingTypeOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o BotObfuscationSettingObfuscationSettingTypeOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e BotObfuscationSettingObfuscationSettingType) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o BotObfuscationSettingObfuscationSettingTypeOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o BotObfuscationSettingObfuscationSettingTypeOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e BotObfuscationSettingObfuscationSettingType) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type BotObfuscationSettingObfuscationSettingTypePtrOutput struct{ *pulumi.OutputState }

func (BotObfuscationSettingObfuscationSettingTypePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**BotObfuscationSettingObfuscationSettingType)(nil)).Elem()
}

func (o BotObfuscationSettingObfuscationSettingTypePtrOutput) ToBotObfuscationSettingObfuscationSettingTypePtrOutput() BotObfuscationSettingObfuscationSettingTypePtrOutput {
	return o
}

func (o BotObfuscationSettingObfuscationSettingTypePtrOutput) ToBotObfuscationSettingObfuscationSettingTypePtrOutputWithContext(ctx context.Context) BotObfuscationSettingObfuscationSettingTypePtrOutput {
	return o
}

func (o BotObfuscationSettingObfuscationSettingTypePtrOutput) Elem() BotObfuscationSettingObfuscationSettingTypeOutput {
	return o.ApplyT(func(v *BotObfuscationSettingObfuscationSettingType) BotObfuscationSettingObfuscationSettingType {
		if v != nil {
			return *v
		}
		var ret BotObfuscationSettingObfuscationSettingType
		return ret
	}).(BotObfuscationSettingObfuscationSettingTypeOutput)
}

func (o BotObfuscationSettingObfuscationSettingTypePtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o BotObfuscationSettingObfuscationSettingTypePtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *BotObfuscationSettingObfuscationSettingType) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// BotObfuscationSettingObfuscationSettingTypeInput is an input type that accepts BotObfuscationSettingObfuscationSettingTypeArgs and BotObfuscationSettingObfuscationSettingTypeOutput values.
// You can construct a concrete instance of `BotObfuscationSettingObfuscationSettingTypeInput` via:
//
//          BotObfuscationSettingObfuscationSettingTypeArgs{...}
type BotObfuscationSettingObfuscationSettingTypeInput interface {
	pulumi.Input

	ToBotObfuscationSettingObfuscationSettingTypeOutput() BotObfuscationSettingObfuscationSettingTypeOutput
	ToBotObfuscationSettingObfuscationSettingTypeOutputWithContext(context.Context) BotObfuscationSettingObfuscationSettingTypeOutput
}

var botObfuscationSettingObfuscationSettingTypePtrType = reflect.TypeOf((**BotObfuscationSettingObfuscationSettingType)(nil)).Elem()

type BotObfuscationSettingObfuscationSettingTypePtrInput interface {
	pulumi.Input

	ToBotObfuscationSettingObfuscationSettingTypePtrOutput() BotObfuscationSettingObfuscationSettingTypePtrOutput
	ToBotObfuscationSettingObfuscationSettingTypePtrOutputWithContext(context.Context) BotObfuscationSettingObfuscationSettingTypePtrOutput
}

type botObfuscationSettingObfuscationSettingTypePtr string

func BotObfuscationSettingObfuscationSettingTypePtr(v string) BotObfuscationSettingObfuscationSettingTypePtrInput {
	return (*botObfuscationSettingObfuscationSettingTypePtr)(&v)
}

func (*botObfuscationSettingObfuscationSettingTypePtr) ElementType() reflect.Type {
	return botObfuscationSettingObfuscationSettingTypePtrType
}

func (in *botObfuscationSettingObfuscationSettingTypePtr) ToBotObfuscationSettingObfuscationSettingTypePtrOutput() BotObfuscationSettingObfuscationSettingTypePtrOutput {
	return pulumi.ToOutput(in).(BotObfuscationSettingObfuscationSettingTypePtrOutput)
}

func (in *botObfuscationSettingObfuscationSettingTypePtr) ToBotObfuscationSettingObfuscationSettingTypePtrOutputWithContext(ctx context.Context) BotObfuscationSettingObfuscationSettingTypePtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(BotObfuscationSettingObfuscationSettingTypePtrOutput)
}

type BotSlotConstraint string

const (
	BotSlotConstraintRequired = BotSlotConstraint("Required")
	BotSlotConstraintOptional = BotSlotConstraint("Optional")
)

func (BotSlotConstraint) ElementType() reflect.Type {
	return reflect.TypeOf((*BotSlotConstraint)(nil)).Elem()
}

func (e BotSlotConstraint) ToBotSlotConstraintOutput() BotSlotConstraintOutput {
	return pulumi.ToOutput(e).(BotSlotConstraintOutput)
}

func (e BotSlotConstraint) ToBotSlotConstraintOutputWithContext(ctx context.Context) BotSlotConstraintOutput {
	return pulumi.ToOutputWithContext(ctx, e).(BotSlotConstraintOutput)
}

func (e BotSlotConstraint) ToBotSlotConstraintPtrOutput() BotSlotConstraintPtrOutput {
	return e.ToBotSlotConstraintPtrOutputWithContext(context.Background())
}

func (e BotSlotConstraint) ToBotSlotConstraintPtrOutputWithContext(ctx context.Context) BotSlotConstraintPtrOutput {
	return BotSlotConstraint(e).ToBotSlotConstraintOutputWithContext(ctx).ToBotSlotConstraintPtrOutputWithContext(ctx)
}

func (e BotSlotConstraint) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e BotSlotConstraint) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e BotSlotConstraint) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e BotSlotConstraint) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type BotSlotConstraintOutput struct{ *pulumi.OutputState }

func (BotSlotConstraintOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*BotSlotConstraint)(nil)).Elem()
}

func (o BotSlotConstraintOutput) ToBotSlotConstraintOutput() BotSlotConstraintOutput {
	return o
}

func (o BotSlotConstraintOutput) ToBotSlotConstraintOutputWithContext(ctx context.Context) BotSlotConstraintOutput {
	return o
}

func (o BotSlotConstraintOutput) ToBotSlotConstraintPtrOutput() BotSlotConstraintPtrOutput {
	return o.ToBotSlotConstraintPtrOutputWithContext(context.Background())
}

func (o BotSlotConstraintOutput) ToBotSlotConstraintPtrOutputWithContext(ctx context.Context) BotSlotConstraintPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v BotSlotConstraint) *BotSlotConstraint {
		return &v
	}).(BotSlotConstraintPtrOutput)
}

func (o BotSlotConstraintOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o BotSlotConstraintOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e BotSlotConstraint) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o BotSlotConstraintOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o BotSlotConstraintOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e BotSlotConstraint) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type BotSlotConstraintPtrOutput struct{ *pulumi.OutputState }

func (BotSlotConstraintPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**BotSlotConstraint)(nil)).Elem()
}

func (o BotSlotConstraintPtrOutput) ToBotSlotConstraintPtrOutput() BotSlotConstraintPtrOutput {
	return o
}

func (o BotSlotConstraintPtrOutput) ToBotSlotConstraintPtrOutputWithContext(ctx context.Context) BotSlotConstraintPtrOutput {
	return o
}

func (o BotSlotConstraintPtrOutput) Elem() BotSlotConstraintOutput {
	return o.ApplyT(func(v *BotSlotConstraint) BotSlotConstraint {
		if v != nil {
			return *v
		}
		var ret BotSlotConstraint
		return ret
	}).(BotSlotConstraintOutput)
}

func (o BotSlotConstraintPtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o BotSlotConstraintPtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *BotSlotConstraint) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// BotSlotConstraintInput is an input type that accepts BotSlotConstraintArgs and BotSlotConstraintOutput values.
// You can construct a concrete instance of `BotSlotConstraintInput` via:
//
//          BotSlotConstraintArgs{...}
type BotSlotConstraintInput interface {
	pulumi.Input

	ToBotSlotConstraintOutput() BotSlotConstraintOutput
	ToBotSlotConstraintOutputWithContext(context.Context) BotSlotConstraintOutput
}

var botSlotConstraintPtrType = reflect.TypeOf((**BotSlotConstraint)(nil)).Elem()

type BotSlotConstraintPtrInput interface {
	pulumi.Input

	ToBotSlotConstraintPtrOutput() BotSlotConstraintPtrOutput
	ToBotSlotConstraintPtrOutputWithContext(context.Context) BotSlotConstraintPtrOutput
}

type botSlotConstraintPtr string

func BotSlotConstraintPtr(v string) BotSlotConstraintPtrInput {
	return (*botSlotConstraintPtr)(&v)
}

func (*botSlotConstraintPtr) ElementType() reflect.Type {
	return botSlotConstraintPtrType
}

func (in *botSlotConstraintPtr) ToBotSlotConstraintPtrOutput() BotSlotConstraintPtrOutput {
	return pulumi.ToOutput(in).(BotSlotConstraintPtrOutput)
}

func (in *botSlotConstraintPtr) ToBotSlotConstraintPtrOutputWithContext(ctx context.Context) BotSlotConstraintPtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(BotSlotConstraintPtrOutput)
}

type BotSlotValueResolutionStrategy string

const (
	BotSlotValueResolutionStrategyOriginalValue = BotSlotValueResolutionStrategy("ORIGINAL_VALUE")
	BotSlotValueResolutionStrategyTopResolution = BotSlotValueResolutionStrategy("TOP_RESOLUTION")
)

func (BotSlotValueResolutionStrategy) ElementType() reflect.Type {
	return reflect.TypeOf((*BotSlotValueResolutionStrategy)(nil)).Elem()
}

func (e BotSlotValueResolutionStrategy) ToBotSlotValueResolutionStrategyOutput() BotSlotValueResolutionStrategyOutput {
	return pulumi.ToOutput(e).(BotSlotValueResolutionStrategyOutput)
}

func (e BotSlotValueResolutionStrategy) ToBotSlotValueResolutionStrategyOutputWithContext(ctx context.Context) BotSlotValueResolutionStrategyOutput {
	return pulumi.ToOutputWithContext(ctx, e).(BotSlotValueResolutionStrategyOutput)
}

func (e BotSlotValueResolutionStrategy) ToBotSlotValueResolutionStrategyPtrOutput() BotSlotValueResolutionStrategyPtrOutput {
	return e.ToBotSlotValueResolutionStrategyPtrOutputWithContext(context.Background())
}

func (e BotSlotValueResolutionStrategy) ToBotSlotValueResolutionStrategyPtrOutputWithContext(ctx context.Context) BotSlotValueResolutionStrategyPtrOutput {
	return BotSlotValueResolutionStrategy(e).ToBotSlotValueResolutionStrategyOutputWithContext(ctx).ToBotSlotValueResolutionStrategyPtrOutputWithContext(ctx)
}

func (e BotSlotValueResolutionStrategy) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e BotSlotValueResolutionStrategy) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e BotSlotValueResolutionStrategy) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e BotSlotValueResolutionStrategy) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type BotSlotValueResolutionStrategyOutput struct{ *pulumi.OutputState }

func (BotSlotValueResolutionStrategyOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*BotSlotValueResolutionStrategy)(nil)).Elem()
}

func (o BotSlotValueResolutionStrategyOutput) ToBotSlotValueResolutionStrategyOutput() BotSlotValueResolutionStrategyOutput {
	return o
}

func (o BotSlotValueResolutionStrategyOutput) ToBotSlotValueResolutionStrategyOutputWithContext(ctx context.Context) BotSlotValueResolutionStrategyOutput {
	return o
}

func (o BotSlotValueResolutionStrategyOutput) ToBotSlotValueResolutionStrategyPtrOutput() BotSlotValueResolutionStrategyPtrOutput {
	return o.ToBotSlotValueResolutionStrategyPtrOutputWithContext(context.Background())
}

func (o BotSlotValueResolutionStrategyOutput) ToBotSlotValueResolutionStrategyPtrOutputWithContext(ctx context.Context) BotSlotValueResolutionStrategyPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v BotSlotValueResolutionStrategy) *BotSlotValueResolutionStrategy {
		return &v
	}).(BotSlotValueResolutionStrategyPtrOutput)
}

func (o BotSlotValueResolutionStrategyOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o BotSlotValueResolutionStrategyOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e BotSlotValueResolutionStrategy) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o BotSlotValueResolutionStrategyOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o BotSlotValueResolutionStrategyOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e BotSlotValueResolutionStrategy) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type BotSlotValueResolutionStrategyPtrOutput struct{ *pulumi.OutputState }

func (BotSlotValueResolutionStrategyPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**BotSlotValueResolutionStrategy)(nil)).Elem()
}

func (o BotSlotValueResolutionStrategyPtrOutput) ToBotSlotValueResolutionStrategyPtrOutput() BotSlotValueResolutionStrategyPtrOutput {
	return o
}

func (o BotSlotValueResolutionStrategyPtrOutput) ToBotSlotValueResolutionStrategyPtrOutputWithContext(ctx context.Context) BotSlotValueResolutionStrategyPtrOutput {
	return o
}

func (o BotSlotValueResolutionStrategyPtrOutput) Elem() BotSlotValueResolutionStrategyOutput {
	return o.ApplyT(func(v *BotSlotValueResolutionStrategy) BotSlotValueResolutionStrategy {
		if v != nil {
			return *v
		}
		var ret BotSlotValueResolutionStrategy
		return ret
	}).(BotSlotValueResolutionStrategyOutput)
}

func (o BotSlotValueResolutionStrategyPtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o BotSlotValueResolutionStrategyPtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *BotSlotValueResolutionStrategy) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// BotSlotValueResolutionStrategyInput is an input type that accepts BotSlotValueResolutionStrategyArgs and BotSlotValueResolutionStrategyOutput values.
// You can construct a concrete instance of `BotSlotValueResolutionStrategyInput` via:
//
//          BotSlotValueResolutionStrategyArgs{...}
type BotSlotValueResolutionStrategyInput interface {
	pulumi.Input

	ToBotSlotValueResolutionStrategyOutput() BotSlotValueResolutionStrategyOutput
	ToBotSlotValueResolutionStrategyOutputWithContext(context.Context) BotSlotValueResolutionStrategyOutput
}

var botSlotValueResolutionStrategyPtrType = reflect.TypeOf((**BotSlotValueResolutionStrategy)(nil)).Elem()

type BotSlotValueResolutionStrategyPtrInput interface {
	pulumi.Input

	ToBotSlotValueResolutionStrategyPtrOutput() BotSlotValueResolutionStrategyPtrOutput
	ToBotSlotValueResolutionStrategyPtrOutputWithContext(context.Context) BotSlotValueResolutionStrategyPtrOutput
}

type botSlotValueResolutionStrategyPtr string

func BotSlotValueResolutionStrategyPtr(v string) BotSlotValueResolutionStrategyPtrInput {
	return (*botSlotValueResolutionStrategyPtr)(&v)
}

func (*botSlotValueResolutionStrategyPtr) ElementType() reflect.Type {
	return botSlotValueResolutionStrategyPtrType
}

func (in *botSlotValueResolutionStrategyPtr) ToBotSlotValueResolutionStrategyPtrOutput() BotSlotValueResolutionStrategyPtrOutput {
	return pulumi.ToOutput(in).(BotSlotValueResolutionStrategyPtrOutput)
}

func (in *botSlotValueResolutionStrategyPtr) ToBotSlotValueResolutionStrategyPtrOutputWithContext(ctx context.Context) BotSlotValueResolutionStrategyPtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(BotSlotValueResolutionStrategyPtrOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*BotAliasStatusInput)(nil)).Elem(), BotAliasStatus("Creating"))
	pulumi.RegisterInputType(reflect.TypeOf((*BotAliasStatusPtrInput)(nil)).Elem(), BotAliasStatus("Creating"))
	pulumi.RegisterInputType(reflect.TypeOf((*BotObfuscationSettingObfuscationSettingTypeInput)(nil)).Elem(), BotObfuscationSettingObfuscationSettingType("None"))
	pulumi.RegisterInputType(reflect.TypeOf((*BotObfuscationSettingObfuscationSettingTypePtrInput)(nil)).Elem(), BotObfuscationSettingObfuscationSettingType("None"))
	pulumi.RegisterInputType(reflect.TypeOf((*BotSlotConstraintInput)(nil)).Elem(), BotSlotConstraint("Required"))
	pulumi.RegisterInputType(reflect.TypeOf((*BotSlotConstraintPtrInput)(nil)).Elem(), BotSlotConstraint("Required"))
	pulumi.RegisterInputType(reflect.TypeOf((*BotSlotValueResolutionStrategyInput)(nil)).Elem(), BotSlotValueResolutionStrategy("ORIGINAL_VALUE"))
	pulumi.RegisterInputType(reflect.TypeOf((*BotSlotValueResolutionStrategyPtrInput)(nil)).Elem(), BotSlotValueResolutionStrategy("ORIGINAL_VALUE"))
	pulumi.RegisterOutputType(BotAliasStatusOutput{})
	pulumi.RegisterOutputType(BotAliasStatusPtrOutput{})
	pulumi.RegisterOutputType(BotObfuscationSettingObfuscationSettingTypeOutput{})
	pulumi.RegisterOutputType(BotObfuscationSettingObfuscationSettingTypePtrOutput{})
	pulumi.RegisterOutputType(BotSlotConstraintOutput{})
	pulumi.RegisterOutputType(BotSlotConstraintPtrOutput{})
	pulumi.RegisterOutputType(BotSlotValueResolutionStrategyOutput{})
	pulumi.RegisterOutputType(BotSlotValueResolutionStrategyPtrOutput{})
}