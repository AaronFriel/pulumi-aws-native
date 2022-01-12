// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package emrcontainers

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type VirtualClusterContainerInfo struct {
	EksInfo VirtualClusterEksInfo `pulumi:"eksInfo"`
}

// VirtualClusterContainerInfoInput is an input type that accepts VirtualClusterContainerInfoArgs and VirtualClusterContainerInfoOutput values.
// You can construct a concrete instance of `VirtualClusterContainerInfoInput` via:
//
//          VirtualClusterContainerInfoArgs{...}
type VirtualClusterContainerInfoInput interface {
	pulumi.Input

	ToVirtualClusterContainerInfoOutput() VirtualClusterContainerInfoOutput
	ToVirtualClusterContainerInfoOutputWithContext(context.Context) VirtualClusterContainerInfoOutput
}

type VirtualClusterContainerInfoArgs struct {
	EksInfo VirtualClusterEksInfoInput `pulumi:"eksInfo"`
}

func (VirtualClusterContainerInfoArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*VirtualClusterContainerInfo)(nil)).Elem()
}

func (i VirtualClusterContainerInfoArgs) ToVirtualClusterContainerInfoOutput() VirtualClusterContainerInfoOutput {
	return i.ToVirtualClusterContainerInfoOutputWithContext(context.Background())
}

func (i VirtualClusterContainerInfoArgs) ToVirtualClusterContainerInfoOutputWithContext(ctx context.Context) VirtualClusterContainerInfoOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VirtualClusterContainerInfoOutput)
}

func (i VirtualClusterContainerInfoArgs) ToVirtualClusterContainerInfoPtrOutput() VirtualClusterContainerInfoPtrOutput {
	return i.ToVirtualClusterContainerInfoPtrOutputWithContext(context.Background())
}

func (i VirtualClusterContainerInfoArgs) ToVirtualClusterContainerInfoPtrOutputWithContext(ctx context.Context) VirtualClusterContainerInfoPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VirtualClusterContainerInfoOutput).ToVirtualClusterContainerInfoPtrOutputWithContext(ctx)
}

// VirtualClusterContainerInfoPtrInput is an input type that accepts VirtualClusterContainerInfoArgs, VirtualClusterContainerInfoPtr and VirtualClusterContainerInfoPtrOutput values.
// You can construct a concrete instance of `VirtualClusterContainerInfoPtrInput` via:
//
//          VirtualClusterContainerInfoArgs{...}
//
//  or:
//
//          nil
type VirtualClusterContainerInfoPtrInput interface {
	pulumi.Input

	ToVirtualClusterContainerInfoPtrOutput() VirtualClusterContainerInfoPtrOutput
	ToVirtualClusterContainerInfoPtrOutputWithContext(context.Context) VirtualClusterContainerInfoPtrOutput
}

type virtualClusterContainerInfoPtrType VirtualClusterContainerInfoArgs

func VirtualClusterContainerInfoPtr(v *VirtualClusterContainerInfoArgs) VirtualClusterContainerInfoPtrInput {
	return (*virtualClusterContainerInfoPtrType)(v)
}

func (*virtualClusterContainerInfoPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**VirtualClusterContainerInfo)(nil)).Elem()
}

func (i *virtualClusterContainerInfoPtrType) ToVirtualClusterContainerInfoPtrOutput() VirtualClusterContainerInfoPtrOutput {
	return i.ToVirtualClusterContainerInfoPtrOutputWithContext(context.Background())
}

func (i *virtualClusterContainerInfoPtrType) ToVirtualClusterContainerInfoPtrOutputWithContext(ctx context.Context) VirtualClusterContainerInfoPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VirtualClusterContainerInfoPtrOutput)
}

type VirtualClusterContainerInfoOutput struct{ *pulumi.OutputState }

func (VirtualClusterContainerInfoOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*VirtualClusterContainerInfo)(nil)).Elem()
}

func (o VirtualClusterContainerInfoOutput) ToVirtualClusterContainerInfoOutput() VirtualClusterContainerInfoOutput {
	return o
}

func (o VirtualClusterContainerInfoOutput) ToVirtualClusterContainerInfoOutputWithContext(ctx context.Context) VirtualClusterContainerInfoOutput {
	return o
}

func (o VirtualClusterContainerInfoOutput) ToVirtualClusterContainerInfoPtrOutput() VirtualClusterContainerInfoPtrOutput {
	return o.ToVirtualClusterContainerInfoPtrOutputWithContext(context.Background())
}

func (o VirtualClusterContainerInfoOutput) ToVirtualClusterContainerInfoPtrOutputWithContext(ctx context.Context) VirtualClusterContainerInfoPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v VirtualClusterContainerInfo) *VirtualClusterContainerInfo {
		return &v
	}).(VirtualClusterContainerInfoPtrOutput)
}

func (o VirtualClusterContainerInfoOutput) EksInfo() VirtualClusterEksInfoOutput {
	return o.ApplyT(func(v VirtualClusterContainerInfo) VirtualClusterEksInfo { return v.EksInfo }).(VirtualClusterEksInfoOutput)
}

type VirtualClusterContainerInfoPtrOutput struct{ *pulumi.OutputState }

func (VirtualClusterContainerInfoPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**VirtualClusterContainerInfo)(nil)).Elem()
}

func (o VirtualClusterContainerInfoPtrOutput) ToVirtualClusterContainerInfoPtrOutput() VirtualClusterContainerInfoPtrOutput {
	return o
}

func (o VirtualClusterContainerInfoPtrOutput) ToVirtualClusterContainerInfoPtrOutputWithContext(ctx context.Context) VirtualClusterContainerInfoPtrOutput {
	return o
}

func (o VirtualClusterContainerInfoPtrOutput) Elem() VirtualClusterContainerInfoOutput {
	return o.ApplyT(func(v *VirtualClusterContainerInfo) VirtualClusterContainerInfo {
		if v != nil {
			return *v
		}
		var ret VirtualClusterContainerInfo
		return ret
	}).(VirtualClusterContainerInfoOutput)
}

func (o VirtualClusterContainerInfoPtrOutput) EksInfo() VirtualClusterEksInfoPtrOutput {
	return o.ApplyT(func(v *VirtualClusterContainerInfo) *VirtualClusterEksInfo {
		if v == nil {
			return nil
		}
		return &v.EksInfo
	}).(VirtualClusterEksInfoPtrOutput)
}

type VirtualClusterContainerProvider struct {
	// The ID of the container cluster
	Id   string                      `pulumi:"id"`
	Info VirtualClusterContainerInfo `pulumi:"info"`
	// The type of the container provider
	Type string `pulumi:"type"`
}

// VirtualClusterContainerProviderInput is an input type that accepts VirtualClusterContainerProviderArgs and VirtualClusterContainerProviderOutput values.
// You can construct a concrete instance of `VirtualClusterContainerProviderInput` via:
//
//          VirtualClusterContainerProviderArgs{...}
type VirtualClusterContainerProviderInput interface {
	pulumi.Input

	ToVirtualClusterContainerProviderOutput() VirtualClusterContainerProviderOutput
	ToVirtualClusterContainerProviderOutputWithContext(context.Context) VirtualClusterContainerProviderOutput
}

type VirtualClusterContainerProviderArgs struct {
	// The ID of the container cluster
	Id   pulumi.StringInput               `pulumi:"id"`
	Info VirtualClusterContainerInfoInput `pulumi:"info"`
	// The type of the container provider
	Type pulumi.StringInput `pulumi:"type"`
}

func (VirtualClusterContainerProviderArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*VirtualClusterContainerProvider)(nil)).Elem()
}

func (i VirtualClusterContainerProviderArgs) ToVirtualClusterContainerProviderOutput() VirtualClusterContainerProviderOutput {
	return i.ToVirtualClusterContainerProviderOutputWithContext(context.Background())
}

func (i VirtualClusterContainerProviderArgs) ToVirtualClusterContainerProviderOutputWithContext(ctx context.Context) VirtualClusterContainerProviderOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VirtualClusterContainerProviderOutput)
}

func (i VirtualClusterContainerProviderArgs) ToVirtualClusterContainerProviderPtrOutput() VirtualClusterContainerProviderPtrOutput {
	return i.ToVirtualClusterContainerProviderPtrOutputWithContext(context.Background())
}

func (i VirtualClusterContainerProviderArgs) ToVirtualClusterContainerProviderPtrOutputWithContext(ctx context.Context) VirtualClusterContainerProviderPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VirtualClusterContainerProviderOutput).ToVirtualClusterContainerProviderPtrOutputWithContext(ctx)
}

// VirtualClusterContainerProviderPtrInput is an input type that accepts VirtualClusterContainerProviderArgs, VirtualClusterContainerProviderPtr and VirtualClusterContainerProviderPtrOutput values.
// You can construct a concrete instance of `VirtualClusterContainerProviderPtrInput` via:
//
//          VirtualClusterContainerProviderArgs{...}
//
//  or:
//
//          nil
type VirtualClusterContainerProviderPtrInput interface {
	pulumi.Input

	ToVirtualClusterContainerProviderPtrOutput() VirtualClusterContainerProviderPtrOutput
	ToVirtualClusterContainerProviderPtrOutputWithContext(context.Context) VirtualClusterContainerProviderPtrOutput
}

type virtualClusterContainerProviderPtrType VirtualClusterContainerProviderArgs

func VirtualClusterContainerProviderPtr(v *VirtualClusterContainerProviderArgs) VirtualClusterContainerProviderPtrInput {
	return (*virtualClusterContainerProviderPtrType)(v)
}

func (*virtualClusterContainerProviderPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**VirtualClusterContainerProvider)(nil)).Elem()
}

func (i *virtualClusterContainerProviderPtrType) ToVirtualClusterContainerProviderPtrOutput() VirtualClusterContainerProviderPtrOutput {
	return i.ToVirtualClusterContainerProviderPtrOutputWithContext(context.Background())
}

func (i *virtualClusterContainerProviderPtrType) ToVirtualClusterContainerProviderPtrOutputWithContext(ctx context.Context) VirtualClusterContainerProviderPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VirtualClusterContainerProviderPtrOutput)
}

type VirtualClusterContainerProviderOutput struct{ *pulumi.OutputState }

func (VirtualClusterContainerProviderOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*VirtualClusterContainerProvider)(nil)).Elem()
}

func (o VirtualClusterContainerProviderOutput) ToVirtualClusterContainerProviderOutput() VirtualClusterContainerProviderOutput {
	return o
}

func (o VirtualClusterContainerProviderOutput) ToVirtualClusterContainerProviderOutputWithContext(ctx context.Context) VirtualClusterContainerProviderOutput {
	return o
}

func (o VirtualClusterContainerProviderOutput) ToVirtualClusterContainerProviderPtrOutput() VirtualClusterContainerProviderPtrOutput {
	return o.ToVirtualClusterContainerProviderPtrOutputWithContext(context.Background())
}

func (o VirtualClusterContainerProviderOutput) ToVirtualClusterContainerProviderPtrOutputWithContext(ctx context.Context) VirtualClusterContainerProviderPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v VirtualClusterContainerProvider) *VirtualClusterContainerProvider {
		return &v
	}).(VirtualClusterContainerProviderPtrOutput)
}

// The ID of the container cluster
func (o VirtualClusterContainerProviderOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v VirtualClusterContainerProvider) string { return v.Id }).(pulumi.StringOutput)
}

func (o VirtualClusterContainerProviderOutput) Info() VirtualClusterContainerInfoOutput {
	return o.ApplyT(func(v VirtualClusterContainerProvider) VirtualClusterContainerInfo { return v.Info }).(VirtualClusterContainerInfoOutput)
}

// The type of the container provider
func (o VirtualClusterContainerProviderOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v VirtualClusterContainerProvider) string { return v.Type }).(pulumi.StringOutput)
}

type VirtualClusterContainerProviderPtrOutput struct{ *pulumi.OutputState }

func (VirtualClusterContainerProviderPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**VirtualClusterContainerProvider)(nil)).Elem()
}

func (o VirtualClusterContainerProviderPtrOutput) ToVirtualClusterContainerProviderPtrOutput() VirtualClusterContainerProviderPtrOutput {
	return o
}

func (o VirtualClusterContainerProviderPtrOutput) ToVirtualClusterContainerProviderPtrOutputWithContext(ctx context.Context) VirtualClusterContainerProviderPtrOutput {
	return o
}

func (o VirtualClusterContainerProviderPtrOutput) Elem() VirtualClusterContainerProviderOutput {
	return o.ApplyT(func(v *VirtualClusterContainerProvider) VirtualClusterContainerProvider {
		if v != nil {
			return *v
		}
		var ret VirtualClusterContainerProvider
		return ret
	}).(VirtualClusterContainerProviderOutput)
}

// The ID of the container cluster
func (o VirtualClusterContainerProviderPtrOutput) Id() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *VirtualClusterContainerProvider) *string {
		if v == nil {
			return nil
		}
		return &v.Id
	}).(pulumi.StringPtrOutput)
}

func (o VirtualClusterContainerProviderPtrOutput) Info() VirtualClusterContainerInfoPtrOutput {
	return o.ApplyT(func(v *VirtualClusterContainerProvider) *VirtualClusterContainerInfo {
		if v == nil {
			return nil
		}
		return &v.Info
	}).(VirtualClusterContainerInfoPtrOutput)
}

// The type of the container provider
func (o VirtualClusterContainerProviderPtrOutput) Type() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *VirtualClusterContainerProvider) *string {
		if v == nil {
			return nil
		}
		return &v.Type
	}).(pulumi.StringPtrOutput)
}

type VirtualClusterEksInfo struct {
	Namespace string `pulumi:"namespace"`
}

// VirtualClusterEksInfoInput is an input type that accepts VirtualClusterEksInfoArgs and VirtualClusterEksInfoOutput values.
// You can construct a concrete instance of `VirtualClusterEksInfoInput` via:
//
//          VirtualClusterEksInfoArgs{...}
type VirtualClusterEksInfoInput interface {
	pulumi.Input

	ToVirtualClusterEksInfoOutput() VirtualClusterEksInfoOutput
	ToVirtualClusterEksInfoOutputWithContext(context.Context) VirtualClusterEksInfoOutput
}

type VirtualClusterEksInfoArgs struct {
	Namespace pulumi.StringInput `pulumi:"namespace"`
}

func (VirtualClusterEksInfoArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*VirtualClusterEksInfo)(nil)).Elem()
}

func (i VirtualClusterEksInfoArgs) ToVirtualClusterEksInfoOutput() VirtualClusterEksInfoOutput {
	return i.ToVirtualClusterEksInfoOutputWithContext(context.Background())
}

func (i VirtualClusterEksInfoArgs) ToVirtualClusterEksInfoOutputWithContext(ctx context.Context) VirtualClusterEksInfoOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VirtualClusterEksInfoOutput)
}

func (i VirtualClusterEksInfoArgs) ToVirtualClusterEksInfoPtrOutput() VirtualClusterEksInfoPtrOutput {
	return i.ToVirtualClusterEksInfoPtrOutputWithContext(context.Background())
}

func (i VirtualClusterEksInfoArgs) ToVirtualClusterEksInfoPtrOutputWithContext(ctx context.Context) VirtualClusterEksInfoPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VirtualClusterEksInfoOutput).ToVirtualClusterEksInfoPtrOutputWithContext(ctx)
}

// VirtualClusterEksInfoPtrInput is an input type that accepts VirtualClusterEksInfoArgs, VirtualClusterEksInfoPtr and VirtualClusterEksInfoPtrOutput values.
// You can construct a concrete instance of `VirtualClusterEksInfoPtrInput` via:
//
//          VirtualClusterEksInfoArgs{...}
//
//  or:
//
//          nil
type VirtualClusterEksInfoPtrInput interface {
	pulumi.Input

	ToVirtualClusterEksInfoPtrOutput() VirtualClusterEksInfoPtrOutput
	ToVirtualClusterEksInfoPtrOutputWithContext(context.Context) VirtualClusterEksInfoPtrOutput
}

type virtualClusterEksInfoPtrType VirtualClusterEksInfoArgs

func VirtualClusterEksInfoPtr(v *VirtualClusterEksInfoArgs) VirtualClusterEksInfoPtrInput {
	return (*virtualClusterEksInfoPtrType)(v)
}

func (*virtualClusterEksInfoPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**VirtualClusterEksInfo)(nil)).Elem()
}

func (i *virtualClusterEksInfoPtrType) ToVirtualClusterEksInfoPtrOutput() VirtualClusterEksInfoPtrOutput {
	return i.ToVirtualClusterEksInfoPtrOutputWithContext(context.Background())
}

func (i *virtualClusterEksInfoPtrType) ToVirtualClusterEksInfoPtrOutputWithContext(ctx context.Context) VirtualClusterEksInfoPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VirtualClusterEksInfoPtrOutput)
}

type VirtualClusterEksInfoOutput struct{ *pulumi.OutputState }

func (VirtualClusterEksInfoOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*VirtualClusterEksInfo)(nil)).Elem()
}

func (o VirtualClusterEksInfoOutput) ToVirtualClusterEksInfoOutput() VirtualClusterEksInfoOutput {
	return o
}

func (o VirtualClusterEksInfoOutput) ToVirtualClusterEksInfoOutputWithContext(ctx context.Context) VirtualClusterEksInfoOutput {
	return o
}

func (o VirtualClusterEksInfoOutput) ToVirtualClusterEksInfoPtrOutput() VirtualClusterEksInfoPtrOutput {
	return o.ToVirtualClusterEksInfoPtrOutputWithContext(context.Background())
}

func (o VirtualClusterEksInfoOutput) ToVirtualClusterEksInfoPtrOutputWithContext(ctx context.Context) VirtualClusterEksInfoPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v VirtualClusterEksInfo) *VirtualClusterEksInfo {
		return &v
	}).(VirtualClusterEksInfoPtrOutput)
}

func (o VirtualClusterEksInfoOutput) Namespace() pulumi.StringOutput {
	return o.ApplyT(func(v VirtualClusterEksInfo) string { return v.Namespace }).(pulumi.StringOutput)
}

type VirtualClusterEksInfoPtrOutput struct{ *pulumi.OutputState }

func (VirtualClusterEksInfoPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**VirtualClusterEksInfo)(nil)).Elem()
}

func (o VirtualClusterEksInfoPtrOutput) ToVirtualClusterEksInfoPtrOutput() VirtualClusterEksInfoPtrOutput {
	return o
}

func (o VirtualClusterEksInfoPtrOutput) ToVirtualClusterEksInfoPtrOutputWithContext(ctx context.Context) VirtualClusterEksInfoPtrOutput {
	return o
}

func (o VirtualClusterEksInfoPtrOutput) Elem() VirtualClusterEksInfoOutput {
	return o.ApplyT(func(v *VirtualClusterEksInfo) VirtualClusterEksInfo {
		if v != nil {
			return *v
		}
		var ret VirtualClusterEksInfo
		return ret
	}).(VirtualClusterEksInfoOutput)
}

func (o VirtualClusterEksInfoPtrOutput) Namespace() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *VirtualClusterEksInfo) *string {
		if v == nil {
			return nil
		}
		return &v.Namespace
	}).(pulumi.StringPtrOutput)
}

// An arbitrary set of tags (key-value pairs) for this virtual cluster.
type VirtualClusterTag struct {
	// The key name of the tag. You can specify a value that is 1 to 127 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
	Key string `pulumi:"key"`
	// The value for the tag. You can specify a value that is 1 to 255 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
	Value string `pulumi:"value"`
}

// VirtualClusterTagInput is an input type that accepts VirtualClusterTagArgs and VirtualClusterTagOutput values.
// You can construct a concrete instance of `VirtualClusterTagInput` via:
//
//          VirtualClusterTagArgs{...}
type VirtualClusterTagInput interface {
	pulumi.Input

	ToVirtualClusterTagOutput() VirtualClusterTagOutput
	ToVirtualClusterTagOutputWithContext(context.Context) VirtualClusterTagOutput
}

// An arbitrary set of tags (key-value pairs) for this virtual cluster.
type VirtualClusterTagArgs struct {
	// The key name of the tag. You can specify a value that is 1 to 127 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
	Key pulumi.StringInput `pulumi:"key"`
	// The value for the tag. You can specify a value that is 1 to 255 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
	Value pulumi.StringInput `pulumi:"value"`
}

func (VirtualClusterTagArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*VirtualClusterTag)(nil)).Elem()
}

func (i VirtualClusterTagArgs) ToVirtualClusterTagOutput() VirtualClusterTagOutput {
	return i.ToVirtualClusterTagOutputWithContext(context.Background())
}

func (i VirtualClusterTagArgs) ToVirtualClusterTagOutputWithContext(ctx context.Context) VirtualClusterTagOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VirtualClusterTagOutput)
}

// VirtualClusterTagArrayInput is an input type that accepts VirtualClusterTagArray and VirtualClusterTagArrayOutput values.
// You can construct a concrete instance of `VirtualClusterTagArrayInput` via:
//
//          VirtualClusterTagArray{ VirtualClusterTagArgs{...} }
type VirtualClusterTagArrayInput interface {
	pulumi.Input

	ToVirtualClusterTagArrayOutput() VirtualClusterTagArrayOutput
	ToVirtualClusterTagArrayOutputWithContext(context.Context) VirtualClusterTagArrayOutput
}

type VirtualClusterTagArray []VirtualClusterTagInput

func (VirtualClusterTagArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]VirtualClusterTag)(nil)).Elem()
}

func (i VirtualClusterTagArray) ToVirtualClusterTagArrayOutput() VirtualClusterTagArrayOutput {
	return i.ToVirtualClusterTagArrayOutputWithContext(context.Background())
}

func (i VirtualClusterTagArray) ToVirtualClusterTagArrayOutputWithContext(ctx context.Context) VirtualClusterTagArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VirtualClusterTagArrayOutput)
}

// An arbitrary set of tags (key-value pairs) for this virtual cluster.
type VirtualClusterTagOutput struct{ *pulumi.OutputState }

func (VirtualClusterTagOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*VirtualClusterTag)(nil)).Elem()
}

func (o VirtualClusterTagOutput) ToVirtualClusterTagOutput() VirtualClusterTagOutput {
	return o
}

func (o VirtualClusterTagOutput) ToVirtualClusterTagOutputWithContext(ctx context.Context) VirtualClusterTagOutput {
	return o
}

// The key name of the tag. You can specify a value that is 1 to 127 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
func (o VirtualClusterTagOutput) Key() pulumi.StringOutput {
	return o.ApplyT(func(v VirtualClusterTag) string { return v.Key }).(pulumi.StringOutput)
}

// The value for the tag. You can specify a value that is 1 to 255 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
func (o VirtualClusterTagOutput) Value() pulumi.StringOutput {
	return o.ApplyT(func(v VirtualClusterTag) string { return v.Value }).(pulumi.StringOutput)
}

type VirtualClusterTagArrayOutput struct{ *pulumi.OutputState }

func (VirtualClusterTagArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]VirtualClusterTag)(nil)).Elem()
}

func (o VirtualClusterTagArrayOutput) ToVirtualClusterTagArrayOutput() VirtualClusterTagArrayOutput {
	return o
}

func (o VirtualClusterTagArrayOutput) ToVirtualClusterTagArrayOutputWithContext(ctx context.Context) VirtualClusterTagArrayOutput {
	return o
}

func (o VirtualClusterTagArrayOutput) Index(i pulumi.IntInput) VirtualClusterTagOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) VirtualClusterTag {
		return vs[0].([]VirtualClusterTag)[vs[1].(int)]
	}).(VirtualClusterTagOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*VirtualClusterContainerInfoInput)(nil)).Elem(), VirtualClusterContainerInfoArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*VirtualClusterContainerInfoPtrInput)(nil)).Elem(), VirtualClusterContainerInfoArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*VirtualClusterContainerProviderInput)(nil)).Elem(), VirtualClusterContainerProviderArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*VirtualClusterContainerProviderPtrInput)(nil)).Elem(), VirtualClusterContainerProviderArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*VirtualClusterEksInfoInput)(nil)).Elem(), VirtualClusterEksInfoArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*VirtualClusterEksInfoPtrInput)(nil)).Elem(), VirtualClusterEksInfoArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*VirtualClusterTagInput)(nil)).Elem(), VirtualClusterTagArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*VirtualClusterTagArrayInput)(nil)).Elem(), VirtualClusterTagArray{})
	pulumi.RegisterOutputType(VirtualClusterContainerInfoOutput{})
	pulumi.RegisterOutputType(VirtualClusterContainerInfoPtrOutput{})
	pulumi.RegisterOutputType(VirtualClusterContainerProviderOutput{})
	pulumi.RegisterOutputType(VirtualClusterContainerProviderPtrOutput{})
	pulumi.RegisterOutputType(VirtualClusterEksInfoOutput{})
	pulumi.RegisterOutputType(VirtualClusterEksInfoPtrOutput{})
	pulumi.RegisterOutputType(VirtualClusterTagOutput{})
	pulumi.RegisterOutputType(VirtualClusterTagArrayOutput{})
}
