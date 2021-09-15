// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package budgets

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type BudgetsActionActionThreshold struct {
	Type  string  `pulumi:"type"`
	Value float64 `pulumi:"value"`
}

// BudgetsActionActionThresholdInput is an input type that accepts BudgetsActionActionThresholdArgs and BudgetsActionActionThresholdOutput values.
// You can construct a concrete instance of `BudgetsActionActionThresholdInput` via:
//
//          BudgetsActionActionThresholdArgs{...}
type BudgetsActionActionThresholdInput interface {
	pulumi.Input

	ToBudgetsActionActionThresholdOutput() BudgetsActionActionThresholdOutput
	ToBudgetsActionActionThresholdOutputWithContext(context.Context) BudgetsActionActionThresholdOutput
}

type BudgetsActionActionThresholdArgs struct {
	Type  pulumi.StringInput  `pulumi:"type"`
	Value pulumi.Float64Input `pulumi:"value"`
}

func (BudgetsActionActionThresholdArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*BudgetsActionActionThreshold)(nil)).Elem()
}

func (i BudgetsActionActionThresholdArgs) ToBudgetsActionActionThresholdOutput() BudgetsActionActionThresholdOutput {
	return i.ToBudgetsActionActionThresholdOutputWithContext(context.Background())
}

func (i BudgetsActionActionThresholdArgs) ToBudgetsActionActionThresholdOutputWithContext(ctx context.Context) BudgetsActionActionThresholdOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BudgetsActionActionThresholdOutput)
}

func (i BudgetsActionActionThresholdArgs) ToBudgetsActionActionThresholdPtrOutput() BudgetsActionActionThresholdPtrOutput {
	return i.ToBudgetsActionActionThresholdPtrOutputWithContext(context.Background())
}

func (i BudgetsActionActionThresholdArgs) ToBudgetsActionActionThresholdPtrOutputWithContext(ctx context.Context) BudgetsActionActionThresholdPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BudgetsActionActionThresholdOutput).ToBudgetsActionActionThresholdPtrOutputWithContext(ctx)
}

// BudgetsActionActionThresholdPtrInput is an input type that accepts BudgetsActionActionThresholdArgs, BudgetsActionActionThresholdPtr and BudgetsActionActionThresholdPtrOutput values.
// You can construct a concrete instance of `BudgetsActionActionThresholdPtrInput` via:
//
//          BudgetsActionActionThresholdArgs{...}
//
//  or:
//
//          nil
type BudgetsActionActionThresholdPtrInput interface {
	pulumi.Input

	ToBudgetsActionActionThresholdPtrOutput() BudgetsActionActionThresholdPtrOutput
	ToBudgetsActionActionThresholdPtrOutputWithContext(context.Context) BudgetsActionActionThresholdPtrOutput
}

type budgetsActionActionThresholdPtrType BudgetsActionActionThresholdArgs

func BudgetsActionActionThresholdPtr(v *BudgetsActionActionThresholdArgs) BudgetsActionActionThresholdPtrInput {
	return (*budgetsActionActionThresholdPtrType)(v)
}

func (*budgetsActionActionThresholdPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**BudgetsActionActionThreshold)(nil)).Elem()
}

func (i *budgetsActionActionThresholdPtrType) ToBudgetsActionActionThresholdPtrOutput() BudgetsActionActionThresholdPtrOutput {
	return i.ToBudgetsActionActionThresholdPtrOutputWithContext(context.Background())
}

func (i *budgetsActionActionThresholdPtrType) ToBudgetsActionActionThresholdPtrOutputWithContext(ctx context.Context) BudgetsActionActionThresholdPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BudgetsActionActionThresholdPtrOutput)
}

type BudgetsActionActionThresholdOutput struct{ *pulumi.OutputState }

func (BudgetsActionActionThresholdOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*BudgetsActionActionThreshold)(nil)).Elem()
}

func (o BudgetsActionActionThresholdOutput) ToBudgetsActionActionThresholdOutput() BudgetsActionActionThresholdOutput {
	return o
}

func (o BudgetsActionActionThresholdOutput) ToBudgetsActionActionThresholdOutputWithContext(ctx context.Context) BudgetsActionActionThresholdOutput {
	return o
}

func (o BudgetsActionActionThresholdOutput) ToBudgetsActionActionThresholdPtrOutput() BudgetsActionActionThresholdPtrOutput {
	return o.ToBudgetsActionActionThresholdPtrOutputWithContext(context.Background())
}

func (o BudgetsActionActionThresholdOutput) ToBudgetsActionActionThresholdPtrOutputWithContext(ctx context.Context) BudgetsActionActionThresholdPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v BudgetsActionActionThreshold) *BudgetsActionActionThreshold {
		return &v
	}).(BudgetsActionActionThresholdPtrOutput)
}

func (o BudgetsActionActionThresholdOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v BudgetsActionActionThreshold) string { return v.Type }).(pulumi.StringOutput)
}

func (o BudgetsActionActionThresholdOutput) Value() pulumi.Float64Output {
	return o.ApplyT(func(v BudgetsActionActionThreshold) float64 { return v.Value }).(pulumi.Float64Output)
}

type BudgetsActionActionThresholdPtrOutput struct{ *pulumi.OutputState }

func (BudgetsActionActionThresholdPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**BudgetsActionActionThreshold)(nil)).Elem()
}

func (o BudgetsActionActionThresholdPtrOutput) ToBudgetsActionActionThresholdPtrOutput() BudgetsActionActionThresholdPtrOutput {
	return o
}

func (o BudgetsActionActionThresholdPtrOutput) ToBudgetsActionActionThresholdPtrOutputWithContext(ctx context.Context) BudgetsActionActionThresholdPtrOutput {
	return o
}

func (o BudgetsActionActionThresholdPtrOutput) Elem() BudgetsActionActionThresholdOutput {
	return o.ApplyT(func(v *BudgetsActionActionThreshold) BudgetsActionActionThreshold {
		if v != nil {
			return *v
		}
		var ret BudgetsActionActionThreshold
		return ret
	}).(BudgetsActionActionThresholdOutput)
}

func (o BudgetsActionActionThresholdPtrOutput) Type() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *BudgetsActionActionThreshold) *string {
		if v == nil {
			return nil
		}
		return &v.Type
	}).(pulumi.StringPtrOutput)
}

func (o BudgetsActionActionThresholdPtrOutput) Value() pulumi.Float64PtrOutput {
	return o.ApplyT(func(v *BudgetsActionActionThreshold) *float64 {
		if v == nil {
			return nil
		}
		return &v.Value
	}).(pulumi.Float64PtrOutput)
}

type BudgetsActionDefinition struct {
	IamActionDefinition *BudgetsActionIamActionDefinition `pulumi:"iamActionDefinition"`
	ScpActionDefinition *BudgetsActionScpActionDefinition `pulumi:"scpActionDefinition"`
	SsmActionDefinition *BudgetsActionSsmActionDefinition `pulumi:"ssmActionDefinition"`
}

// BudgetsActionDefinitionInput is an input type that accepts BudgetsActionDefinitionArgs and BudgetsActionDefinitionOutput values.
// You can construct a concrete instance of `BudgetsActionDefinitionInput` via:
//
//          BudgetsActionDefinitionArgs{...}
type BudgetsActionDefinitionInput interface {
	pulumi.Input

	ToBudgetsActionDefinitionOutput() BudgetsActionDefinitionOutput
	ToBudgetsActionDefinitionOutputWithContext(context.Context) BudgetsActionDefinitionOutput
}

type BudgetsActionDefinitionArgs struct {
	IamActionDefinition BudgetsActionIamActionDefinitionPtrInput `pulumi:"iamActionDefinition"`
	ScpActionDefinition BudgetsActionScpActionDefinitionPtrInput `pulumi:"scpActionDefinition"`
	SsmActionDefinition BudgetsActionSsmActionDefinitionPtrInput `pulumi:"ssmActionDefinition"`
}

func (BudgetsActionDefinitionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*BudgetsActionDefinition)(nil)).Elem()
}

func (i BudgetsActionDefinitionArgs) ToBudgetsActionDefinitionOutput() BudgetsActionDefinitionOutput {
	return i.ToBudgetsActionDefinitionOutputWithContext(context.Background())
}

func (i BudgetsActionDefinitionArgs) ToBudgetsActionDefinitionOutputWithContext(ctx context.Context) BudgetsActionDefinitionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BudgetsActionDefinitionOutput)
}

func (i BudgetsActionDefinitionArgs) ToBudgetsActionDefinitionPtrOutput() BudgetsActionDefinitionPtrOutput {
	return i.ToBudgetsActionDefinitionPtrOutputWithContext(context.Background())
}

func (i BudgetsActionDefinitionArgs) ToBudgetsActionDefinitionPtrOutputWithContext(ctx context.Context) BudgetsActionDefinitionPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BudgetsActionDefinitionOutput).ToBudgetsActionDefinitionPtrOutputWithContext(ctx)
}

// BudgetsActionDefinitionPtrInput is an input type that accepts BudgetsActionDefinitionArgs, BudgetsActionDefinitionPtr and BudgetsActionDefinitionPtrOutput values.
// You can construct a concrete instance of `BudgetsActionDefinitionPtrInput` via:
//
//          BudgetsActionDefinitionArgs{...}
//
//  or:
//
//          nil
type BudgetsActionDefinitionPtrInput interface {
	pulumi.Input

	ToBudgetsActionDefinitionPtrOutput() BudgetsActionDefinitionPtrOutput
	ToBudgetsActionDefinitionPtrOutputWithContext(context.Context) BudgetsActionDefinitionPtrOutput
}

type budgetsActionDefinitionPtrType BudgetsActionDefinitionArgs

func BudgetsActionDefinitionPtr(v *BudgetsActionDefinitionArgs) BudgetsActionDefinitionPtrInput {
	return (*budgetsActionDefinitionPtrType)(v)
}

func (*budgetsActionDefinitionPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**BudgetsActionDefinition)(nil)).Elem()
}

func (i *budgetsActionDefinitionPtrType) ToBudgetsActionDefinitionPtrOutput() BudgetsActionDefinitionPtrOutput {
	return i.ToBudgetsActionDefinitionPtrOutputWithContext(context.Background())
}

func (i *budgetsActionDefinitionPtrType) ToBudgetsActionDefinitionPtrOutputWithContext(ctx context.Context) BudgetsActionDefinitionPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BudgetsActionDefinitionPtrOutput)
}

type BudgetsActionDefinitionOutput struct{ *pulumi.OutputState }

func (BudgetsActionDefinitionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*BudgetsActionDefinition)(nil)).Elem()
}

func (o BudgetsActionDefinitionOutput) ToBudgetsActionDefinitionOutput() BudgetsActionDefinitionOutput {
	return o
}

func (o BudgetsActionDefinitionOutput) ToBudgetsActionDefinitionOutputWithContext(ctx context.Context) BudgetsActionDefinitionOutput {
	return o
}

func (o BudgetsActionDefinitionOutput) ToBudgetsActionDefinitionPtrOutput() BudgetsActionDefinitionPtrOutput {
	return o.ToBudgetsActionDefinitionPtrOutputWithContext(context.Background())
}

func (o BudgetsActionDefinitionOutput) ToBudgetsActionDefinitionPtrOutputWithContext(ctx context.Context) BudgetsActionDefinitionPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v BudgetsActionDefinition) *BudgetsActionDefinition {
		return &v
	}).(BudgetsActionDefinitionPtrOutput)
}

func (o BudgetsActionDefinitionOutput) IamActionDefinition() BudgetsActionIamActionDefinitionPtrOutput {
	return o.ApplyT(func(v BudgetsActionDefinition) *BudgetsActionIamActionDefinition { return v.IamActionDefinition }).(BudgetsActionIamActionDefinitionPtrOutput)
}

func (o BudgetsActionDefinitionOutput) ScpActionDefinition() BudgetsActionScpActionDefinitionPtrOutput {
	return o.ApplyT(func(v BudgetsActionDefinition) *BudgetsActionScpActionDefinition { return v.ScpActionDefinition }).(BudgetsActionScpActionDefinitionPtrOutput)
}

func (o BudgetsActionDefinitionOutput) SsmActionDefinition() BudgetsActionSsmActionDefinitionPtrOutput {
	return o.ApplyT(func(v BudgetsActionDefinition) *BudgetsActionSsmActionDefinition { return v.SsmActionDefinition }).(BudgetsActionSsmActionDefinitionPtrOutput)
}

type BudgetsActionDefinitionPtrOutput struct{ *pulumi.OutputState }

func (BudgetsActionDefinitionPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**BudgetsActionDefinition)(nil)).Elem()
}

func (o BudgetsActionDefinitionPtrOutput) ToBudgetsActionDefinitionPtrOutput() BudgetsActionDefinitionPtrOutput {
	return o
}

func (o BudgetsActionDefinitionPtrOutput) ToBudgetsActionDefinitionPtrOutputWithContext(ctx context.Context) BudgetsActionDefinitionPtrOutput {
	return o
}

func (o BudgetsActionDefinitionPtrOutput) Elem() BudgetsActionDefinitionOutput {
	return o.ApplyT(func(v *BudgetsActionDefinition) BudgetsActionDefinition {
		if v != nil {
			return *v
		}
		var ret BudgetsActionDefinition
		return ret
	}).(BudgetsActionDefinitionOutput)
}

func (o BudgetsActionDefinitionPtrOutput) IamActionDefinition() BudgetsActionIamActionDefinitionPtrOutput {
	return o.ApplyT(func(v *BudgetsActionDefinition) *BudgetsActionIamActionDefinition {
		if v == nil {
			return nil
		}
		return v.IamActionDefinition
	}).(BudgetsActionIamActionDefinitionPtrOutput)
}

func (o BudgetsActionDefinitionPtrOutput) ScpActionDefinition() BudgetsActionScpActionDefinitionPtrOutput {
	return o.ApplyT(func(v *BudgetsActionDefinition) *BudgetsActionScpActionDefinition {
		if v == nil {
			return nil
		}
		return v.ScpActionDefinition
	}).(BudgetsActionScpActionDefinitionPtrOutput)
}

func (o BudgetsActionDefinitionPtrOutput) SsmActionDefinition() BudgetsActionSsmActionDefinitionPtrOutput {
	return o.ApplyT(func(v *BudgetsActionDefinition) *BudgetsActionSsmActionDefinition {
		if v == nil {
			return nil
		}
		return v.SsmActionDefinition
	}).(BudgetsActionSsmActionDefinitionPtrOutput)
}

type BudgetsActionIamActionDefinition struct {
	Groups    []string `pulumi:"groups"`
	PolicyArn string   `pulumi:"policyArn"`
	Roles     []string `pulumi:"roles"`
	Users     []string `pulumi:"users"`
}

// BudgetsActionIamActionDefinitionInput is an input type that accepts BudgetsActionIamActionDefinitionArgs and BudgetsActionIamActionDefinitionOutput values.
// You can construct a concrete instance of `BudgetsActionIamActionDefinitionInput` via:
//
//          BudgetsActionIamActionDefinitionArgs{...}
type BudgetsActionIamActionDefinitionInput interface {
	pulumi.Input

	ToBudgetsActionIamActionDefinitionOutput() BudgetsActionIamActionDefinitionOutput
	ToBudgetsActionIamActionDefinitionOutputWithContext(context.Context) BudgetsActionIamActionDefinitionOutput
}

type BudgetsActionIamActionDefinitionArgs struct {
	Groups    pulumi.StringArrayInput `pulumi:"groups"`
	PolicyArn pulumi.StringInput      `pulumi:"policyArn"`
	Roles     pulumi.StringArrayInput `pulumi:"roles"`
	Users     pulumi.StringArrayInput `pulumi:"users"`
}

func (BudgetsActionIamActionDefinitionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*BudgetsActionIamActionDefinition)(nil)).Elem()
}

func (i BudgetsActionIamActionDefinitionArgs) ToBudgetsActionIamActionDefinitionOutput() BudgetsActionIamActionDefinitionOutput {
	return i.ToBudgetsActionIamActionDefinitionOutputWithContext(context.Background())
}

func (i BudgetsActionIamActionDefinitionArgs) ToBudgetsActionIamActionDefinitionOutputWithContext(ctx context.Context) BudgetsActionIamActionDefinitionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BudgetsActionIamActionDefinitionOutput)
}

func (i BudgetsActionIamActionDefinitionArgs) ToBudgetsActionIamActionDefinitionPtrOutput() BudgetsActionIamActionDefinitionPtrOutput {
	return i.ToBudgetsActionIamActionDefinitionPtrOutputWithContext(context.Background())
}

func (i BudgetsActionIamActionDefinitionArgs) ToBudgetsActionIamActionDefinitionPtrOutputWithContext(ctx context.Context) BudgetsActionIamActionDefinitionPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BudgetsActionIamActionDefinitionOutput).ToBudgetsActionIamActionDefinitionPtrOutputWithContext(ctx)
}

// BudgetsActionIamActionDefinitionPtrInput is an input type that accepts BudgetsActionIamActionDefinitionArgs, BudgetsActionIamActionDefinitionPtr and BudgetsActionIamActionDefinitionPtrOutput values.
// You can construct a concrete instance of `BudgetsActionIamActionDefinitionPtrInput` via:
//
//          BudgetsActionIamActionDefinitionArgs{...}
//
//  or:
//
//          nil
type BudgetsActionIamActionDefinitionPtrInput interface {
	pulumi.Input

	ToBudgetsActionIamActionDefinitionPtrOutput() BudgetsActionIamActionDefinitionPtrOutput
	ToBudgetsActionIamActionDefinitionPtrOutputWithContext(context.Context) BudgetsActionIamActionDefinitionPtrOutput
}

type budgetsActionIamActionDefinitionPtrType BudgetsActionIamActionDefinitionArgs

func BudgetsActionIamActionDefinitionPtr(v *BudgetsActionIamActionDefinitionArgs) BudgetsActionIamActionDefinitionPtrInput {
	return (*budgetsActionIamActionDefinitionPtrType)(v)
}

func (*budgetsActionIamActionDefinitionPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**BudgetsActionIamActionDefinition)(nil)).Elem()
}

func (i *budgetsActionIamActionDefinitionPtrType) ToBudgetsActionIamActionDefinitionPtrOutput() BudgetsActionIamActionDefinitionPtrOutput {
	return i.ToBudgetsActionIamActionDefinitionPtrOutputWithContext(context.Background())
}

func (i *budgetsActionIamActionDefinitionPtrType) ToBudgetsActionIamActionDefinitionPtrOutputWithContext(ctx context.Context) BudgetsActionIamActionDefinitionPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BudgetsActionIamActionDefinitionPtrOutput)
}

type BudgetsActionIamActionDefinitionOutput struct{ *pulumi.OutputState }

func (BudgetsActionIamActionDefinitionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*BudgetsActionIamActionDefinition)(nil)).Elem()
}

func (o BudgetsActionIamActionDefinitionOutput) ToBudgetsActionIamActionDefinitionOutput() BudgetsActionIamActionDefinitionOutput {
	return o
}

func (o BudgetsActionIamActionDefinitionOutput) ToBudgetsActionIamActionDefinitionOutputWithContext(ctx context.Context) BudgetsActionIamActionDefinitionOutput {
	return o
}

func (o BudgetsActionIamActionDefinitionOutput) ToBudgetsActionIamActionDefinitionPtrOutput() BudgetsActionIamActionDefinitionPtrOutput {
	return o.ToBudgetsActionIamActionDefinitionPtrOutputWithContext(context.Background())
}

func (o BudgetsActionIamActionDefinitionOutput) ToBudgetsActionIamActionDefinitionPtrOutputWithContext(ctx context.Context) BudgetsActionIamActionDefinitionPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v BudgetsActionIamActionDefinition) *BudgetsActionIamActionDefinition {
		return &v
	}).(BudgetsActionIamActionDefinitionPtrOutput)
}

func (o BudgetsActionIamActionDefinitionOutput) Groups() pulumi.StringArrayOutput {
	return o.ApplyT(func(v BudgetsActionIamActionDefinition) []string { return v.Groups }).(pulumi.StringArrayOutput)
}

func (o BudgetsActionIamActionDefinitionOutput) PolicyArn() pulumi.StringOutput {
	return o.ApplyT(func(v BudgetsActionIamActionDefinition) string { return v.PolicyArn }).(pulumi.StringOutput)
}

func (o BudgetsActionIamActionDefinitionOutput) Roles() pulumi.StringArrayOutput {
	return o.ApplyT(func(v BudgetsActionIamActionDefinition) []string { return v.Roles }).(pulumi.StringArrayOutput)
}

func (o BudgetsActionIamActionDefinitionOutput) Users() pulumi.StringArrayOutput {
	return o.ApplyT(func(v BudgetsActionIamActionDefinition) []string { return v.Users }).(pulumi.StringArrayOutput)
}

type BudgetsActionIamActionDefinitionPtrOutput struct{ *pulumi.OutputState }

func (BudgetsActionIamActionDefinitionPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**BudgetsActionIamActionDefinition)(nil)).Elem()
}

func (o BudgetsActionIamActionDefinitionPtrOutput) ToBudgetsActionIamActionDefinitionPtrOutput() BudgetsActionIamActionDefinitionPtrOutput {
	return o
}

func (o BudgetsActionIamActionDefinitionPtrOutput) ToBudgetsActionIamActionDefinitionPtrOutputWithContext(ctx context.Context) BudgetsActionIamActionDefinitionPtrOutput {
	return o
}

func (o BudgetsActionIamActionDefinitionPtrOutput) Elem() BudgetsActionIamActionDefinitionOutput {
	return o.ApplyT(func(v *BudgetsActionIamActionDefinition) BudgetsActionIamActionDefinition {
		if v != nil {
			return *v
		}
		var ret BudgetsActionIamActionDefinition
		return ret
	}).(BudgetsActionIamActionDefinitionOutput)
}

func (o BudgetsActionIamActionDefinitionPtrOutput) Groups() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *BudgetsActionIamActionDefinition) []string {
		if v == nil {
			return nil
		}
		return v.Groups
	}).(pulumi.StringArrayOutput)
}

func (o BudgetsActionIamActionDefinitionPtrOutput) PolicyArn() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *BudgetsActionIamActionDefinition) *string {
		if v == nil {
			return nil
		}
		return &v.PolicyArn
	}).(pulumi.StringPtrOutput)
}

func (o BudgetsActionIamActionDefinitionPtrOutput) Roles() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *BudgetsActionIamActionDefinition) []string {
		if v == nil {
			return nil
		}
		return v.Roles
	}).(pulumi.StringArrayOutput)
}

func (o BudgetsActionIamActionDefinitionPtrOutput) Users() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *BudgetsActionIamActionDefinition) []string {
		if v == nil {
			return nil
		}
		return v.Users
	}).(pulumi.StringArrayOutput)
}

type BudgetsActionScpActionDefinition struct {
	PolicyId  string   `pulumi:"policyId"`
	TargetIds []string `pulumi:"targetIds"`
}

// BudgetsActionScpActionDefinitionInput is an input type that accepts BudgetsActionScpActionDefinitionArgs and BudgetsActionScpActionDefinitionOutput values.
// You can construct a concrete instance of `BudgetsActionScpActionDefinitionInput` via:
//
//          BudgetsActionScpActionDefinitionArgs{...}
type BudgetsActionScpActionDefinitionInput interface {
	pulumi.Input

	ToBudgetsActionScpActionDefinitionOutput() BudgetsActionScpActionDefinitionOutput
	ToBudgetsActionScpActionDefinitionOutputWithContext(context.Context) BudgetsActionScpActionDefinitionOutput
}

type BudgetsActionScpActionDefinitionArgs struct {
	PolicyId  pulumi.StringInput      `pulumi:"policyId"`
	TargetIds pulumi.StringArrayInput `pulumi:"targetIds"`
}

func (BudgetsActionScpActionDefinitionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*BudgetsActionScpActionDefinition)(nil)).Elem()
}

func (i BudgetsActionScpActionDefinitionArgs) ToBudgetsActionScpActionDefinitionOutput() BudgetsActionScpActionDefinitionOutput {
	return i.ToBudgetsActionScpActionDefinitionOutputWithContext(context.Background())
}

func (i BudgetsActionScpActionDefinitionArgs) ToBudgetsActionScpActionDefinitionOutputWithContext(ctx context.Context) BudgetsActionScpActionDefinitionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BudgetsActionScpActionDefinitionOutput)
}

func (i BudgetsActionScpActionDefinitionArgs) ToBudgetsActionScpActionDefinitionPtrOutput() BudgetsActionScpActionDefinitionPtrOutput {
	return i.ToBudgetsActionScpActionDefinitionPtrOutputWithContext(context.Background())
}

func (i BudgetsActionScpActionDefinitionArgs) ToBudgetsActionScpActionDefinitionPtrOutputWithContext(ctx context.Context) BudgetsActionScpActionDefinitionPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BudgetsActionScpActionDefinitionOutput).ToBudgetsActionScpActionDefinitionPtrOutputWithContext(ctx)
}

// BudgetsActionScpActionDefinitionPtrInput is an input type that accepts BudgetsActionScpActionDefinitionArgs, BudgetsActionScpActionDefinitionPtr and BudgetsActionScpActionDefinitionPtrOutput values.
// You can construct a concrete instance of `BudgetsActionScpActionDefinitionPtrInput` via:
//
//          BudgetsActionScpActionDefinitionArgs{...}
//
//  or:
//
//          nil
type BudgetsActionScpActionDefinitionPtrInput interface {
	pulumi.Input

	ToBudgetsActionScpActionDefinitionPtrOutput() BudgetsActionScpActionDefinitionPtrOutput
	ToBudgetsActionScpActionDefinitionPtrOutputWithContext(context.Context) BudgetsActionScpActionDefinitionPtrOutput
}

type budgetsActionScpActionDefinitionPtrType BudgetsActionScpActionDefinitionArgs

func BudgetsActionScpActionDefinitionPtr(v *BudgetsActionScpActionDefinitionArgs) BudgetsActionScpActionDefinitionPtrInput {
	return (*budgetsActionScpActionDefinitionPtrType)(v)
}

func (*budgetsActionScpActionDefinitionPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**BudgetsActionScpActionDefinition)(nil)).Elem()
}

func (i *budgetsActionScpActionDefinitionPtrType) ToBudgetsActionScpActionDefinitionPtrOutput() BudgetsActionScpActionDefinitionPtrOutput {
	return i.ToBudgetsActionScpActionDefinitionPtrOutputWithContext(context.Background())
}

func (i *budgetsActionScpActionDefinitionPtrType) ToBudgetsActionScpActionDefinitionPtrOutputWithContext(ctx context.Context) BudgetsActionScpActionDefinitionPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BudgetsActionScpActionDefinitionPtrOutput)
}

type BudgetsActionScpActionDefinitionOutput struct{ *pulumi.OutputState }

func (BudgetsActionScpActionDefinitionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*BudgetsActionScpActionDefinition)(nil)).Elem()
}

func (o BudgetsActionScpActionDefinitionOutput) ToBudgetsActionScpActionDefinitionOutput() BudgetsActionScpActionDefinitionOutput {
	return o
}

func (o BudgetsActionScpActionDefinitionOutput) ToBudgetsActionScpActionDefinitionOutputWithContext(ctx context.Context) BudgetsActionScpActionDefinitionOutput {
	return o
}

func (o BudgetsActionScpActionDefinitionOutput) ToBudgetsActionScpActionDefinitionPtrOutput() BudgetsActionScpActionDefinitionPtrOutput {
	return o.ToBudgetsActionScpActionDefinitionPtrOutputWithContext(context.Background())
}

func (o BudgetsActionScpActionDefinitionOutput) ToBudgetsActionScpActionDefinitionPtrOutputWithContext(ctx context.Context) BudgetsActionScpActionDefinitionPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v BudgetsActionScpActionDefinition) *BudgetsActionScpActionDefinition {
		return &v
	}).(BudgetsActionScpActionDefinitionPtrOutput)
}

func (o BudgetsActionScpActionDefinitionOutput) PolicyId() pulumi.StringOutput {
	return o.ApplyT(func(v BudgetsActionScpActionDefinition) string { return v.PolicyId }).(pulumi.StringOutput)
}

func (o BudgetsActionScpActionDefinitionOutput) TargetIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v BudgetsActionScpActionDefinition) []string { return v.TargetIds }).(pulumi.StringArrayOutput)
}

type BudgetsActionScpActionDefinitionPtrOutput struct{ *pulumi.OutputState }

func (BudgetsActionScpActionDefinitionPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**BudgetsActionScpActionDefinition)(nil)).Elem()
}

func (o BudgetsActionScpActionDefinitionPtrOutput) ToBudgetsActionScpActionDefinitionPtrOutput() BudgetsActionScpActionDefinitionPtrOutput {
	return o
}

func (o BudgetsActionScpActionDefinitionPtrOutput) ToBudgetsActionScpActionDefinitionPtrOutputWithContext(ctx context.Context) BudgetsActionScpActionDefinitionPtrOutput {
	return o
}

func (o BudgetsActionScpActionDefinitionPtrOutput) Elem() BudgetsActionScpActionDefinitionOutput {
	return o.ApplyT(func(v *BudgetsActionScpActionDefinition) BudgetsActionScpActionDefinition {
		if v != nil {
			return *v
		}
		var ret BudgetsActionScpActionDefinition
		return ret
	}).(BudgetsActionScpActionDefinitionOutput)
}

func (o BudgetsActionScpActionDefinitionPtrOutput) PolicyId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *BudgetsActionScpActionDefinition) *string {
		if v == nil {
			return nil
		}
		return &v.PolicyId
	}).(pulumi.StringPtrOutput)
}

func (o BudgetsActionScpActionDefinitionPtrOutput) TargetIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *BudgetsActionScpActionDefinition) []string {
		if v == nil {
			return nil
		}
		return v.TargetIds
	}).(pulumi.StringArrayOutput)
}

type BudgetsActionSsmActionDefinition struct {
	InstanceIds []string `pulumi:"instanceIds"`
	Region      string   `pulumi:"region"`
	Subtype     string   `pulumi:"subtype"`
}

// BudgetsActionSsmActionDefinitionInput is an input type that accepts BudgetsActionSsmActionDefinitionArgs and BudgetsActionSsmActionDefinitionOutput values.
// You can construct a concrete instance of `BudgetsActionSsmActionDefinitionInput` via:
//
//          BudgetsActionSsmActionDefinitionArgs{...}
type BudgetsActionSsmActionDefinitionInput interface {
	pulumi.Input

	ToBudgetsActionSsmActionDefinitionOutput() BudgetsActionSsmActionDefinitionOutput
	ToBudgetsActionSsmActionDefinitionOutputWithContext(context.Context) BudgetsActionSsmActionDefinitionOutput
}

type BudgetsActionSsmActionDefinitionArgs struct {
	InstanceIds pulumi.StringArrayInput `pulumi:"instanceIds"`
	Region      pulumi.StringInput      `pulumi:"region"`
	Subtype     pulumi.StringInput      `pulumi:"subtype"`
}

func (BudgetsActionSsmActionDefinitionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*BudgetsActionSsmActionDefinition)(nil)).Elem()
}

func (i BudgetsActionSsmActionDefinitionArgs) ToBudgetsActionSsmActionDefinitionOutput() BudgetsActionSsmActionDefinitionOutput {
	return i.ToBudgetsActionSsmActionDefinitionOutputWithContext(context.Background())
}

func (i BudgetsActionSsmActionDefinitionArgs) ToBudgetsActionSsmActionDefinitionOutputWithContext(ctx context.Context) BudgetsActionSsmActionDefinitionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BudgetsActionSsmActionDefinitionOutput)
}

func (i BudgetsActionSsmActionDefinitionArgs) ToBudgetsActionSsmActionDefinitionPtrOutput() BudgetsActionSsmActionDefinitionPtrOutput {
	return i.ToBudgetsActionSsmActionDefinitionPtrOutputWithContext(context.Background())
}

func (i BudgetsActionSsmActionDefinitionArgs) ToBudgetsActionSsmActionDefinitionPtrOutputWithContext(ctx context.Context) BudgetsActionSsmActionDefinitionPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BudgetsActionSsmActionDefinitionOutput).ToBudgetsActionSsmActionDefinitionPtrOutputWithContext(ctx)
}

// BudgetsActionSsmActionDefinitionPtrInput is an input type that accepts BudgetsActionSsmActionDefinitionArgs, BudgetsActionSsmActionDefinitionPtr and BudgetsActionSsmActionDefinitionPtrOutput values.
// You can construct a concrete instance of `BudgetsActionSsmActionDefinitionPtrInput` via:
//
//          BudgetsActionSsmActionDefinitionArgs{...}
//
//  or:
//
//          nil
type BudgetsActionSsmActionDefinitionPtrInput interface {
	pulumi.Input

	ToBudgetsActionSsmActionDefinitionPtrOutput() BudgetsActionSsmActionDefinitionPtrOutput
	ToBudgetsActionSsmActionDefinitionPtrOutputWithContext(context.Context) BudgetsActionSsmActionDefinitionPtrOutput
}

type budgetsActionSsmActionDefinitionPtrType BudgetsActionSsmActionDefinitionArgs

func BudgetsActionSsmActionDefinitionPtr(v *BudgetsActionSsmActionDefinitionArgs) BudgetsActionSsmActionDefinitionPtrInput {
	return (*budgetsActionSsmActionDefinitionPtrType)(v)
}

func (*budgetsActionSsmActionDefinitionPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**BudgetsActionSsmActionDefinition)(nil)).Elem()
}

func (i *budgetsActionSsmActionDefinitionPtrType) ToBudgetsActionSsmActionDefinitionPtrOutput() BudgetsActionSsmActionDefinitionPtrOutput {
	return i.ToBudgetsActionSsmActionDefinitionPtrOutputWithContext(context.Background())
}

func (i *budgetsActionSsmActionDefinitionPtrType) ToBudgetsActionSsmActionDefinitionPtrOutputWithContext(ctx context.Context) BudgetsActionSsmActionDefinitionPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BudgetsActionSsmActionDefinitionPtrOutput)
}

type BudgetsActionSsmActionDefinitionOutput struct{ *pulumi.OutputState }

func (BudgetsActionSsmActionDefinitionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*BudgetsActionSsmActionDefinition)(nil)).Elem()
}

func (o BudgetsActionSsmActionDefinitionOutput) ToBudgetsActionSsmActionDefinitionOutput() BudgetsActionSsmActionDefinitionOutput {
	return o
}

func (o BudgetsActionSsmActionDefinitionOutput) ToBudgetsActionSsmActionDefinitionOutputWithContext(ctx context.Context) BudgetsActionSsmActionDefinitionOutput {
	return o
}

func (o BudgetsActionSsmActionDefinitionOutput) ToBudgetsActionSsmActionDefinitionPtrOutput() BudgetsActionSsmActionDefinitionPtrOutput {
	return o.ToBudgetsActionSsmActionDefinitionPtrOutputWithContext(context.Background())
}

func (o BudgetsActionSsmActionDefinitionOutput) ToBudgetsActionSsmActionDefinitionPtrOutputWithContext(ctx context.Context) BudgetsActionSsmActionDefinitionPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v BudgetsActionSsmActionDefinition) *BudgetsActionSsmActionDefinition {
		return &v
	}).(BudgetsActionSsmActionDefinitionPtrOutput)
}

func (o BudgetsActionSsmActionDefinitionOutput) InstanceIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v BudgetsActionSsmActionDefinition) []string { return v.InstanceIds }).(pulumi.StringArrayOutput)
}

func (o BudgetsActionSsmActionDefinitionOutput) Region() pulumi.StringOutput {
	return o.ApplyT(func(v BudgetsActionSsmActionDefinition) string { return v.Region }).(pulumi.StringOutput)
}

func (o BudgetsActionSsmActionDefinitionOutput) Subtype() pulumi.StringOutput {
	return o.ApplyT(func(v BudgetsActionSsmActionDefinition) string { return v.Subtype }).(pulumi.StringOutput)
}

type BudgetsActionSsmActionDefinitionPtrOutput struct{ *pulumi.OutputState }

func (BudgetsActionSsmActionDefinitionPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**BudgetsActionSsmActionDefinition)(nil)).Elem()
}

func (o BudgetsActionSsmActionDefinitionPtrOutput) ToBudgetsActionSsmActionDefinitionPtrOutput() BudgetsActionSsmActionDefinitionPtrOutput {
	return o
}

func (o BudgetsActionSsmActionDefinitionPtrOutput) ToBudgetsActionSsmActionDefinitionPtrOutputWithContext(ctx context.Context) BudgetsActionSsmActionDefinitionPtrOutput {
	return o
}

func (o BudgetsActionSsmActionDefinitionPtrOutput) Elem() BudgetsActionSsmActionDefinitionOutput {
	return o.ApplyT(func(v *BudgetsActionSsmActionDefinition) BudgetsActionSsmActionDefinition {
		if v != nil {
			return *v
		}
		var ret BudgetsActionSsmActionDefinition
		return ret
	}).(BudgetsActionSsmActionDefinitionOutput)
}

func (o BudgetsActionSsmActionDefinitionPtrOutput) InstanceIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *BudgetsActionSsmActionDefinition) []string {
		if v == nil {
			return nil
		}
		return v.InstanceIds
	}).(pulumi.StringArrayOutput)
}

func (o BudgetsActionSsmActionDefinitionPtrOutput) Region() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *BudgetsActionSsmActionDefinition) *string {
		if v == nil {
			return nil
		}
		return &v.Region
	}).(pulumi.StringPtrOutput)
}

func (o BudgetsActionSsmActionDefinitionPtrOutput) Subtype() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *BudgetsActionSsmActionDefinition) *string {
		if v == nil {
			return nil
		}
		return &v.Subtype
	}).(pulumi.StringPtrOutput)
}

type BudgetsActionSubscriber struct {
	Address string `pulumi:"address"`
	Type    string `pulumi:"type"`
}

// BudgetsActionSubscriberInput is an input type that accepts BudgetsActionSubscriberArgs and BudgetsActionSubscriberOutput values.
// You can construct a concrete instance of `BudgetsActionSubscriberInput` via:
//
//          BudgetsActionSubscriberArgs{...}
type BudgetsActionSubscriberInput interface {
	pulumi.Input

	ToBudgetsActionSubscriberOutput() BudgetsActionSubscriberOutput
	ToBudgetsActionSubscriberOutputWithContext(context.Context) BudgetsActionSubscriberOutput
}

type BudgetsActionSubscriberArgs struct {
	Address pulumi.StringInput `pulumi:"address"`
	Type    pulumi.StringInput `pulumi:"type"`
}

func (BudgetsActionSubscriberArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*BudgetsActionSubscriber)(nil)).Elem()
}

func (i BudgetsActionSubscriberArgs) ToBudgetsActionSubscriberOutput() BudgetsActionSubscriberOutput {
	return i.ToBudgetsActionSubscriberOutputWithContext(context.Background())
}

func (i BudgetsActionSubscriberArgs) ToBudgetsActionSubscriberOutputWithContext(ctx context.Context) BudgetsActionSubscriberOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BudgetsActionSubscriberOutput)
}

// BudgetsActionSubscriberArrayInput is an input type that accepts BudgetsActionSubscriberArray and BudgetsActionSubscriberArrayOutput values.
// You can construct a concrete instance of `BudgetsActionSubscriberArrayInput` via:
//
//          BudgetsActionSubscriberArray{ BudgetsActionSubscriberArgs{...} }
type BudgetsActionSubscriberArrayInput interface {
	pulumi.Input

	ToBudgetsActionSubscriberArrayOutput() BudgetsActionSubscriberArrayOutput
	ToBudgetsActionSubscriberArrayOutputWithContext(context.Context) BudgetsActionSubscriberArrayOutput
}

type BudgetsActionSubscriberArray []BudgetsActionSubscriberInput

func (BudgetsActionSubscriberArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]BudgetsActionSubscriber)(nil)).Elem()
}

func (i BudgetsActionSubscriberArray) ToBudgetsActionSubscriberArrayOutput() BudgetsActionSubscriberArrayOutput {
	return i.ToBudgetsActionSubscriberArrayOutputWithContext(context.Background())
}

func (i BudgetsActionSubscriberArray) ToBudgetsActionSubscriberArrayOutputWithContext(ctx context.Context) BudgetsActionSubscriberArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BudgetsActionSubscriberArrayOutput)
}

type BudgetsActionSubscriberOutput struct{ *pulumi.OutputState }

func (BudgetsActionSubscriberOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*BudgetsActionSubscriber)(nil)).Elem()
}

func (o BudgetsActionSubscriberOutput) ToBudgetsActionSubscriberOutput() BudgetsActionSubscriberOutput {
	return o
}

func (o BudgetsActionSubscriberOutput) ToBudgetsActionSubscriberOutputWithContext(ctx context.Context) BudgetsActionSubscriberOutput {
	return o
}

func (o BudgetsActionSubscriberOutput) Address() pulumi.StringOutput {
	return o.ApplyT(func(v BudgetsActionSubscriber) string { return v.Address }).(pulumi.StringOutput)
}

func (o BudgetsActionSubscriberOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v BudgetsActionSubscriber) string { return v.Type }).(pulumi.StringOutput)
}

type BudgetsActionSubscriberArrayOutput struct{ *pulumi.OutputState }

func (BudgetsActionSubscriberArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]BudgetsActionSubscriber)(nil)).Elem()
}

func (o BudgetsActionSubscriberArrayOutput) ToBudgetsActionSubscriberArrayOutput() BudgetsActionSubscriberArrayOutput {
	return o
}

func (o BudgetsActionSubscriberArrayOutput) ToBudgetsActionSubscriberArrayOutputWithContext(ctx context.Context) BudgetsActionSubscriberArrayOutput {
	return o
}

func (o BudgetsActionSubscriberArrayOutput) Index(i pulumi.IntInput) BudgetsActionSubscriberOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) BudgetsActionSubscriber {
		return vs[0].([]BudgetsActionSubscriber)[vs[1].(int)]
	}).(BudgetsActionSubscriberOutput)
}

func init() {
	pulumi.RegisterOutputType(BudgetsActionActionThresholdOutput{})
	pulumi.RegisterOutputType(BudgetsActionActionThresholdPtrOutput{})
	pulumi.RegisterOutputType(BudgetsActionDefinitionOutput{})
	pulumi.RegisterOutputType(BudgetsActionDefinitionPtrOutput{})
	pulumi.RegisterOutputType(BudgetsActionIamActionDefinitionOutput{})
	pulumi.RegisterOutputType(BudgetsActionIamActionDefinitionPtrOutput{})
	pulumi.RegisterOutputType(BudgetsActionScpActionDefinitionOutput{})
	pulumi.RegisterOutputType(BudgetsActionScpActionDefinitionPtrOutput{})
	pulumi.RegisterOutputType(BudgetsActionSsmActionDefinitionOutput{})
	pulumi.RegisterOutputType(BudgetsActionSsmActionDefinitionPtrOutput{})
	pulumi.RegisterOutputType(BudgetsActionSubscriberOutput{})
	pulumi.RegisterOutputType(BudgetsActionSubscriberArrayOutput{})
}
