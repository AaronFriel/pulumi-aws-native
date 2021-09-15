// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package accessanalyzer

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// An Access Analyzer archive rule. Archive rules automatically archive new findings that meet the criteria you define when you create the rule.
type AnalyzerArchiveRule struct {
	Filter []AnalyzerFilter `pulumi:"filter"`
	// The archive rule name
	RuleName string `pulumi:"ruleName"`
}

// AnalyzerArchiveRuleInput is an input type that accepts AnalyzerArchiveRuleArgs and AnalyzerArchiveRuleOutput values.
// You can construct a concrete instance of `AnalyzerArchiveRuleInput` via:
//
//          AnalyzerArchiveRuleArgs{...}
type AnalyzerArchiveRuleInput interface {
	pulumi.Input

	ToAnalyzerArchiveRuleOutput() AnalyzerArchiveRuleOutput
	ToAnalyzerArchiveRuleOutputWithContext(context.Context) AnalyzerArchiveRuleOutput
}

// An Access Analyzer archive rule. Archive rules automatically archive new findings that meet the criteria you define when you create the rule.
type AnalyzerArchiveRuleArgs struct {
	Filter AnalyzerFilterArrayInput `pulumi:"filter"`
	// The archive rule name
	RuleName pulumi.StringInput `pulumi:"ruleName"`
}

func (AnalyzerArchiveRuleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*AnalyzerArchiveRule)(nil)).Elem()
}

func (i AnalyzerArchiveRuleArgs) ToAnalyzerArchiveRuleOutput() AnalyzerArchiveRuleOutput {
	return i.ToAnalyzerArchiveRuleOutputWithContext(context.Background())
}

func (i AnalyzerArchiveRuleArgs) ToAnalyzerArchiveRuleOutputWithContext(ctx context.Context) AnalyzerArchiveRuleOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AnalyzerArchiveRuleOutput)
}

// AnalyzerArchiveRuleArrayInput is an input type that accepts AnalyzerArchiveRuleArray and AnalyzerArchiveRuleArrayOutput values.
// You can construct a concrete instance of `AnalyzerArchiveRuleArrayInput` via:
//
//          AnalyzerArchiveRuleArray{ AnalyzerArchiveRuleArgs{...} }
type AnalyzerArchiveRuleArrayInput interface {
	pulumi.Input

	ToAnalyzerArchiveRuleArrayOutput() AnalyzerArchiveRuleArrayOutput
	ToAnalyzerArchiveRuleArrayOutputWithContext(context.Context) AnalyzerArchiveRuleArrayOutput
}

type AnalyzerArchiveRuleArray []AnalyzerArchiveRuleInput

func (AnalyzerArchiveRuleArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]AnalyzerArchiveRule)(nil)).Elem()
}

func (i AnalyzerArchiveRuleArray) ToAnalyzerArchiveRuleArrayOutput() AnalyzerArchiveRuleArrayOutput {
	return i.ToAnalyzerArchiveRuleArrayOutputWithContext(context.Background())
}

func (i AnalyzerArchiveRuleArray) ToAnalyzerArchiveRuleArrayOutputWithContext(ctx context.Context) AnalyzerArchiveRuleArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AnalyzerArchiveRuleArrayOutput)
}

// An Access Analyzer archive rule. Archive rules automatically archive new findings that meet the criteria you define when you create the rule.
type AnalyzerArchiveRuleOutput struct{ *pulumi.OutputState }

func (AnalyzerArchiveRuleOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*AnalyzerArchiveRule)(nil)).Elem()
}

func (o AnalyzerArchiveRuleOutput) ToAnalyzerArchiveRuleOutput() AnalyzerArchiveRuleOutput {
	return o
}

func (o AnalyzerArchiveRuleOutput) ToAnalyzerArchiveRuleOutputWithContext(ctx context.Context) AnalyzerArchiveRuleOutput {
	return o
}

func (o AnalyzerArchiveRuleOutput) Filter() AnalyzerFilterArrayOutput {
	return o.ApplyT(func(v AnalyzerArchiveRule) []AnalyzerFilter { return v.Filter }).(AnalyzerFilterArrayOutput)
}

// The archive rule name
func (o AnalyzerArchiveRuleOutput) RuleName() pulumi.StringOutput {
	return o.ApplyT(func(v AnalyzerArchiveRule) string { return v.RuleName }).(pulumi.StringOutput)
}

type AnalyzerArchiveRuleArrayOutput struct{ *pulumi.OutputState }

func (AnalyzerArchiveRuleArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]AnalyzerArchiveRule)(nil)).Elem()
}

func (o AnalyzerArchiveRuleArrayOutput) ToAnalyzerArchiveRuleArrayOutput() AnalyzerArchiveRuleArrayOutput {
	return o
}

func (o AnalyzerArchiveRuleArrayOutput) ToAnalyzerArchiveRuleArrayOutputWithContext(ctx context.Context) AnalyzerArchiveRuleArrayOutput {
	return o
}

func (o AnalyzerArchiveRuleArrayOutput) Index(i pulumi.IntInput) AnalyzerArchiveRuleOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) AnalyzerArchiveRule {
		return vs[0].([]AnalyzerArchiveRule)[vs[1].(int)]
	}).(AnalyzerArchiveRuleOutput)
}

type AnalyzerFilter struct {
	Contains []string `pulumi:"contains"`
	Eq       []string `pulumi:"eq"`
	Exists   *bool    `pulumi:"exists"`
	Neq      []string `pulumi:"neq"`
	Property string   `pulumi:"property"`
}

// AnalyzerFilterInput is an input type that accepts AnalyzerFilterArgs and AnalyzerFilterOutput values.
// You can construct a concrete instance of `AnalyzerFilterInput` via:
//
//          AnalyzerFilterArgs{...}
type AnalyzerFilterInput interface {
	pulumi.Input

	ToAnalyzerFilterOutput() AnalyzerFilterOutput
	ToAnalyzerFilterOutputWithContext(context.Context) AnalyzerFilterOutput
}

type AnalyzerFilterArgs struct {
	Contains pulumi.StringArrayInput `pulumi:"contains"`
	Eq       pulumi.StringArrayInput `pulumi:"eq"`
	Exists   pulumi.BoolPtrInput     `pulumi:"exists"`
	Neq      pulumi.StringArrayInput `pulumi:"neq"`
	Property pulumi.StringInput      `pulumi:"property"`
}

func (AnalyzerFilterArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*AnalyzerFilter)(nil)).Elem()
}

func (i AnalyzerFilterArgs) ToAnalyzerFilterOutput() AnalyzerFilterOutput {
	return i.ToAnalyzerFilterOutputWithContext(context.Background())
}

func (i AnalyzerFilterArgs) ToAnalyzerFilterOutputWithContext(ctx context.Context) AnalyzerFilterOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AnalyzerFilterOutput)
}

// AnalyzerFilterArrayInput is an input type that accepts AnalyzerFilterArray and AnalyzerFilterArrayOutput values.
// You can construct a concrete instance of `AnalyzerFilterArrayInput` via:
//
//          AnalyzerFilterArray{ AnalyzerFilterArgs{...} }
type AnalyzerFilterArrayInput interface {
	pulumi.Input

	ToAnalyzerFilterArrayOutput() AnalyzerFilterArrayOutput
	ToAnalyzerFilterArrayOutputWithContext(context.Context) AnalyzerFilterArrayOutput
}

type AnalyzerFilterArray []AnalyzerFilterInput

func (AnalyzerFilterArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]AnalyzerFilter)(nil)).Elem()
}

func (i AnalyzerFilterArray) ToAnalyzerFilterArrayOutput() AnalyzerFilterArrayOutput {
	return i.ToAnalyzerFilterArrayOutputWithContext(context.Background())
}

func (i AnalyzerFilterArray) ToAnalyzerFilterArrayOutputWithContext(ctx context.Context) AnalyzerFilterArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AnalyzerFilterArrayOutput)
}

type AnalyzerFilterOutput struct{ *pulumi.OutputState }

func (AnalyzerFilterOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*AnalyzerFilter)(nil)).Elem()
}

func (o AnalyzerFilterOutput) ToAnalyzerFilterOutput() AnalyzerFilterOutput {
	return o
}

func (o AnalyzerFilterOutput) ToAnalyzerFilterOutputWithContext(ctx context.Context) AnalyzerFilterOutput {
	return o
}

func (o AnalyzerFilterOutput) Contains() pulumi.StringArrayOutput {
	return o.ApplyT(func(v AnalyzerFilter) []string { return v.Contains }).(pulumi.StringArrayOutput)
}

func (o AnalyzerFilterOutput) Eq() pulumi.StringArrayOutput {
	return o.ApplyT(func(v AnalyzerFilter) []string { return v.Eq }).(pulumi.StringArrayOutput)
}

func (o AnalyzerFilterOutput) Exists() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v AnalyzerFilter) *bool { return v.Exists }).(pulumi.BoolPtrOutput)
}

func (o AnalyzerFilterOutput) Neq() pulumi.StringArrayOutput {
	return o.ApplyT(func(v AnalyzerFilter) []string { return v.Neq }).(pulumi.StringArrayOutput)
}

func (o AnalyzerFilterOutput) Property() pulumi.StringOutput {
	return o.ApplyT(func(v AnalyzerFilter) string { return v.Property }).(pulumi.StringOutput)
}

type AnalyzerFilterArrayOutput struct{ *pulumi.OutputState }

func (AnalyzerFilterArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]AnalyzerFilter)(nil)).Elem()
}

func (o AnalyzerFilterArrayOutput) ToAnalyzerFilterArrayOutput() AnalyzerFilterArrayOutput {
	return o
}

func (o AnalyzerFilterArrayOutput) ToAnalyzerFilterArrayOutputWithContext(ctx context.Context) AnalyzerFilterArrayOutput {
	return o
}

func (o AnalyzerFilterArrayOutput) Index(i pulumi.IntInput) AnalyzerFilterOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) AnalyzerFilter {
		return vs[0].([]AnalyzerFilter)[vs[1].(int)]
	}).(AnalyzerFilterOutput)
}

// A key-value pair to associate with a resource.
type AnalyzerTag struct {
	// The key name of the tag. You can specify a value that is 1 to 127 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
	Key string `pulumi:"key"`
	// The value for the tag. You can specify a value that is 1 to 255 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
	Value string `pulumi:"value"`
}

// AnalyzerTagInput is an input type that accepts AnalyzerTagArgs and AnalyzerTagOutput values.
// You can construct a concrete instance of `AnalyzerTagInput` via:
//
//          AnalyzerTagArgs{...}
type AnalyzerTagInput interface {
	pulumi.Input

	ToAnalyzerTagOutput() AnalyzerTagOutput
	ToAnalyzerTagOutputWithContext(context.Context) AnalyzerTagOutput
}

// A key-value pair to associate with a resource.
type AnalyzerTagArgs struct {
	// The key name of the tag. You can specify a value that is 1 to 127 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
	Key pulumi.StringInput `pulumi:"key"`
	// The value for the tag. You can specify a value that is 1 to 255 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
	Value pulumi.StringInput `pulumi:"value"`
}

func (AnalyzerTagArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*AnalyzerTag)(nil)).Elem()
}

func (i AnalyzerTagArgs) ToAnalyzerTagOutput() AnalyzerTagOutput {
	return i.ToAnalyzerTagOutputWithContext(context.Background())
}

func (i AnalyzerTagArgs) ToAnalyzerTagOutputWithContext(ctx context.Context) AnalyzerTagOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AnalyzerTagOutput)
}

// AnalyzerTagArrayInput is an input type that accepts AnalyzerTagArray and AnalyzerTagArrayOutput values.
// You can construct a concrete instance of `AnalyzerTagArrayInput` via:
//
//          AnalyzerTagArray{ AnalyzerTagArgs{...} }
type AnalyzerTagArrayInput interface {
	pulumi.Input

	ToAnalyzerTagArrayOutput() AnalyzerTagArrayOutput
	ToAnalyzerTagArrayOutputWithContext(context.Context) AnalyzerTagArrayOutput
}

type AnalyzerTagArray []AnalyzerTagInput

func (AnalyzerTagArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]AnalyzerTag)(nil)).Elem()
}

func (i AnalyzerTagArray) ToAnalyzerTagArrayOutput() AnalyzerTagArrayOutput {
	return i.ToAnalyzerTagArrayOutputWithContext(context.Background())
}

func (i AnalyzerTagArray) ToAnalyzerTagArrayOutputWithContext(ctx context.Context) AnalyzerTagArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AnalyzerTagArrayOutput)
}

// A key-value pair to associate with a resource.
type AnalyzerTagOutput struct{ *pulumi.OutputState }

func (AnalyzerTagOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*AnalyzerTag)(nil)).Elem()
}

func (o AnalyzerTagOutput) ToAnalyzerTagOutput() AnalyzerTagOutput {
	return o
}

func (o AnalyzerTagOutput) ToAnalyzerTagOutputWithContext(ctx context.Context) AnalyzerTagOutput {
	return o
}

// The key name of the tag. You can specify a value that is 1 to 127 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
func (o AnalyzerTagOutput) Key() pulumi.StringOutput {
	return o.ApplyT(func(v AnalyzerTag) string { return v.Key }).(pulumi.StringOutput)
}

// The value for the tag. You can specify a value that is 1 to 255 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
func (o AnalyzerTagOutput) Value() pulumi.StringOutput {
	return o.ApplyT(func(v AnalyzerTag) string { return v.Value }).(pulumi.StringOutput)
}

type AnalyzerTagArrayOutput struct{ *pulumi.OutputState }

func (AnalyzerTagArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]AnalyzerTag)(nil)).Elem()
}

func (o AnalyzerTagArrayOutput) ToAnalyzerTagArrayOutput() AnalyzerTagArrayOutput {
	return o
}

func (o AnalyzerTagArrayOutput) ToAnalyzerTagArrayOutputWithContext(ctx context.Context) AnalyzerTagArrayOutput {
	return o
}

func (o AnalyzerTagArrayOutput) Index(i pulumi.IntInput) AnalyzerTagOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) AnalyzerTag {
		return vs[0].([]AnalyzerTag)[vs[1].(int)]
	}).(AnalyzerTagOutput)
}

func init() {
	pulumi.RegisterOutputType(AnalyzerArchiveRuleOutput{})
	pulumi.RegisterOutputType(AnalyzerArchiveRuleArrayOutput{})
	pulumi.RegisterOutputType(AnalyzerFilterOutput{})
	pulumi.RegisterOutputType(AnalyzerFilterArrayOutput{})
	pulumi.RegisterOutputType(AnalyzerTagOutput{})
	pulumi.RegisterOutputType(AnalyzerTagArrayOutput{})
}
