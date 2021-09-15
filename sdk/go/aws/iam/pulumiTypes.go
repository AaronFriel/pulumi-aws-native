// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package iam

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// A key-value pair to associate with a resource.
type OIDCProviderTag struct {
	// The key name of the tag. You can specify a value that is 1 to 128 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
	Key string `pulumi:"key"`
	// The value for the tag. You can specify a value that is 0 to 256 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
	Value string `pulumi:"value"`
}

// OIDCProviderTagInput is an input type that accepts OIDCProviderTagArgs and OIDCProviderTagOutput values.
// You can construct a concrete instance of `OIDCProviderTagInput` via:
//
//          OIDCProviderTagArgs{...}
type OIDCProviderTagInput interface {
	pulumi.Input

	ToOIDCProviderTagOutput() OIDCProviderTagOutput
	ToOIDCProviderTagOutputWithContext(context.Context) OIDCProviderTagOutput
}

// A key-value pair to associate with a resource.
type OIDCProviderTagArgs struct {
	// The key name of the tag. You can specify a value that is 1 to 128 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
	Key pulumi.StringInput `pulumi:"key"`
	// The value for the tag. You can specify a value that is 0 to 256 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
	Value pulumi.StringInput `pulumi:"value"`
}

func (OIDCProviderTagArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*OIDCProviderTag)(nil)).Elem()
}

func (i OIDCProviderTagArgs) ToOIDCProviderTagOutput() OIDCProviderTagOutput {
	return i.ToOIDCProviderTagOutputWithContext(context.Background())
}

func (i OIDCProviderTagArgs) ToOIDCProviderTagOutputWithContext(ctx context.Context) OIDCProviderTagOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OIDCProviderTagOutput)
}

// OIDCProviderTagArrayInput is an input type that accepts OIDCProviderTagArray and OIDCProviderTagArrayOutput values.
// You can construct a concrete instance of `OIDCProviderTagArrayInput` via:
//
//          OIDCProviderTagArray{ OIDCProviderTagArgs{...} }
type OIDCProviderTagArrayInput interface {
	pulumi.Input

	ToOIDCProviderTagArrayOutput() OIDCProviderTagArrayOutput
	ToOIDCProviderTagArrayOutputWithContext(context.Context) OIDCProviderTagArrayOutput
}

type OIDCProviderTagArray []OIDCProviderTagInput

func (OIDCProviderTagArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]OIDCProviderTag)(nil)).Elem()
}

func (i OIDCProviderTagArray) ToOIDCProviderTagArrayOutput() OIDCProviderTagArrayOutput {
	return i.ToOIDCProviderTagArrayOutputWithContext(context.Background())
}

func (i OIDCProviderTagArray) ToOIDCProviderTagArrayOutputWithContext(ctx context.Context) OIDCProviderTagArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OIDCProviderTagArrayOutput)
}

// A key-value pair to associate with a resource.
type OIDCProviderTagOutput struct{ *pulumi.OutputState }

func (OIDCProviderTagOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*OIDCProviderTag)(nil)).Elem()
}

func (o OIDCProviderTagOutput) ToOIDCProviderTagOutput() OIDCProviderTagOutput {
	return o
}

func (o OIDCProviderTagOutput) ToOIDCProviderTagOutputWithContext(ctx context.Context) OIDCProviderTagOutput {
	return o
}

// The key name of the tag. You can specify a value that is 1 to 128 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
func (o OIDCProviderTagOutput) Key() pulumi.StringOutput {
	return o.ApplyT(func(v OIDCProviderTag) string { return v.Key }).(pulumi.StringOutput)
}

// The value for the tag. You can specify a value that is 0 to 256 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
func (o OIDCProviderTagOutput) Value() pulumi.StringOutput {
	return o.ApplyT(func(v OIDCProviderTag) string { return v.Value }).(pulumi.StringOutput)
}

type OIDCProviderTagArrayOutput struct{ *pulumi.OutputState }

func (OIDCProviderTagArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]OIDCProviderTag)(nil)).Elem()
}

func (o OIDCProviderTagArrayOutput) ToOIDCProviderTagArrayOutput() OIDCProviderTagArrayOutput {
	return o
}

func (o OIDCProviderTagArrayOutput) ToOIDCProviderTagArrayOutputWithContext(ctx context.Context) OIDCProviderTagArrayOutput {
	return o
}

func (o OIDCProviderTagArrayOutput) Index(i pulumi.IntInput) OIDCProviderTagOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) OIDCProviderTag {
		return vs[0].([]OIDCProviderTag)[vs[1].(int)]
	}).(OIDCProviderTagOutput)
}

// A key-value pair to associate with a resource.
type SAMLProviderTag struct {
	// The key name of the tag. You can specify a value that is 1 to 128 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
	Key string `pulumi:"key"`
	// The value for the tag. You can specify a value that is 0 to 256 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
	Value string `pulumi:"value"`
}

// SAMLProviderTagInput is an input type that accepts SAMLProviderTagArgs and SAMLProviderTagOutput values.
// You can construct a concrete instance of `SAMLProviderTagInput` via:
//
//          SAMLProviderTagArgs{...}
type SAMLProviderTagInput interface {
	pulumi.Input

	ToSAMLProviderTagOutput() SAMLProviderTagOutput
	ToSAMLProviderTagOutputWithContext(context.Context) SAMLProviderTagOutput
}

// A key-value pair to associate with a resource.
type SAMLProviderTagArgs struct {
	// The key name of the tag. You can specify a value that is 1 to 128 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
	Key pulumi.StringInput `pulumi:"key"`
	// The value for the tag. You can specify a value that is 0 to 256 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
	Value pulumi.StringInput `pulumi:"value"`
}

func (SAMLProviderTagArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*SAMLProviderTag)(nil)).Elem()
}

func (i SAMLProviderTagArgs) ToSAMLProviderTagOutput() SAMLProviderTagOutput {
	return i.ToSAMLProviderTagOutputWithContext(context.Background())
}

func (i SAMLProviderTagArgs) ToSAMLProviderTagOutputWithContext(ctx context.Context) SAMLProviderTagOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SAMLProviderTagOutput)
}

// SAMLProviderTagArrayInput is an input type that accepts SAMLProviderTagArray and SAMLProviderTagArrayOutput values.
// You can construct a concrete instance of `SAMLProviderTagArrayInput` via:
//
//          SAMLProviderTagArray{ SAMLProviderTagArgs{...} }
type SAMLProviderTagArrayInput interface {
	pulumi.Input

	ToSAMLProviderTagArrayOutput() SAMLProviderTagArrayOutput
	ToSAMLProviderTagArrayOutputWithContext(context.Context) SAMLProviderTagArrayOutput
}

type SAMLProviderTagArray []SAMLProviderTagInput

func (SAMLProviderTagArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]SAMLProviderTag)(nil)).Elem()
}

func (i SAMLProviderTagArray) ToSAMLProviderTagArrayOutput() SAMLProviderTagArrayOutput {
	return i.ToSAMLProviderTagArrayOutputWithContext(context.Background())
}

func (i SAMLProviderTagArray) ToSAMLProviderTagArrayOutputWithContext(ctx context.Context) SAMLProviderTagArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SAMLProviderTagArrayOutput)
}

// A key-value pair to associate with a resource.
type SAMLProviderTagOutput struct{ *pulumi.OutputState }

func (SAMLProviderTagOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SAMLProviderTag)(nil)).Elem()
}

func (o SAMLProviderTagOutput) ToSAMLProviderTagOutput() SAMLProviderTagOutput {
	return o
}

func (o SAMLProviderTagOutput) ToSAMLProviderTagOutputWithContext(ctx context.Context) SAMLProviderTagOutput {
	return o
}

// The key name of the tag. You can specify a value that is 1 to 128 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
func (o SAMLProviderTagOutput) Key() pulumi.StringOutput {
	return o.ApplyT(func(v SAMLProviderTag) string { return v.Key }).(pulumi.StringOutput)
}

// The value for the tag. You can specify a value that is 0 to 256 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
func (o SAMLProviderTagOutput) Value() pulumi.StringOutput {
	return o.ApplyT(func(v SAMLProviderTag) string { return v.Value }).(pulumi.StringOutput)
}

type SAMLProviderTagArrayOutput struct{ *pulumi.OutputState }

func (SAMLProviderTagArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]SAMLProviderTag)(nil)).Elem()
}

func (o SAMLProviderTagArrayOutput) ToSAMLProviderTagArrayOutput() SAMLProviderTagArrayOutput {
	return o
}

func (o SAMLProviderTagArrayOutput) ToSAMLProviderTagArrayOutputWithContext(ctx context.Context) SAMLProviderTagArrayOutput {
	return o
}

func (o SAMLProviderTagArrayOutput) Index(i pulumi.IntInput) SAMLProviderTagOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) SAMLProviderTag {
		return vs[0].([]SAMLProviderTag)[vs[1].(int)]
	}).(SAMLProviderTagOutput)
}

// A key-value pair to associate with a resource.
type ServerCertificateTag struct {
	// The key name of the tag. You can specify a value that is 1 to 128 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
	Key string `pulumi:"key"`
	// The value for the tag. You can specify a value that is 0 to 256 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
	Value string `pulumi:"value"`
}

// ServerCertificateTagInput is an input type that accepts ServerCertificateTagArgs and ServerCertificateTagOutput values.
// You can construct a concrete instance of `ServerCertificateTagInput` via:
//
//          ServerCertificateTagArgs{...}
type ServerCertificateTagInput interface {
	pulumi.Input

	ToServerCertificateTagOutput() ServerCertificateTagOutput
	ToServerCertificateTagOutputWithContext(context.Context) ServerCertificateTagOutput
}

// A key-value pair to associate with a resource.
type ServerCertificateTagArgs struct {
	// The key name of the tag. You can specify a value that is 1 to 128 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
	Key pulumi.StringInput `pulumi:"key"`
	// The value for the tag. You can specify a value that is 0 to 256 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
	Value pulumi.StringInput `pulumi:"value"`
}

func (ServerCertificateTagArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ServerCertificateTag)(nil)).Elem()
}

func (i ServerCertificateTagArgs) ToServerCertificateTagOutput() ServerCertificateTagOutput {
	return i.ToServerCertificateTagOutputWithContext(context.Background())
}

func (i ServerCertificateTagArgs) ToServerCertificateTagOutputWithContext(ctx context.Context) ServerCertificateTagOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServerCertificateTagOutput)
}

// ServerCertificateTagArrayInput is an input type that accepts ServerCertificateTagArray and ServerCertificateTagArrayOutput values.
// You can construct a concrete instance of `ServerCertificateTagArrayInput` via:
//
//          ServerCertificateTagArray{ ServerCertificateTagArgs{...} }
type ServerCertificateTagArrayInput interface {
	pulumi.Input

	ToServerCertificateTagArrayOutput() ServerCertificateTagArrayOutput
	ToServerCertificateTagArrayOutputWithContext(context.Context) ServerCertificateTagArrayOutput
}

type ServerCertificateTagArray []ServerCertificateTagInput

func (ServerCertificateTagArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ServerCertificateTag)(nil)).Elem()
}

func (i ServerCertificateTagArray) ToServerCertificateTagArrayOutput() ServerCertificateTagArrayOutput {
	return i.ToServerCertificateTagArrayOutputWithContext(context.Background())
}

func (i ServerCertificateTagArray) ToServerCertificateTagArrayOutputWithContext(ctx context.Context) ServerCertificateTagArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServerCertificateTagArrayOutput)
}

// A key-value pair to associate with a resource.
type ServerCertificateTagOutput struct{ *pulumi.OutputState }

func (ServerCertificateTagOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ServerCertificateTag)(nil)).Elem()
}

func (o ServerCertificateTagOutput) ToServerCertificateTagOutput() ServerCertificateTagOutput {
	return o
}

func (o ServerCertificateTagOutput) ToServerCertificateTagOutputWithContext(ctx context.Context) ServerCertificateTagOutput {
	return o
}

// The key name of the tag. You can specify a value that is 1 to 128 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
func (o ServerCertificateTagOutput) Key() pulumi.StringOutput {
	return o.ApplyT(func(v ServerCertificateTag) string { return v.Key }).(pulumi.StringOutput)
}

// The value for the tag. You can specify a value that is 0 to 256 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
func (o ServerCertificateTagOutput) Value() pulumi.StringOutput {
	return o.ApplyT(func(v ServerCertificateTag) string { return v.Value }).(pulumi.StringOutput)
}

type ServerCertificateTagArrayOutput struct{ *pulumi.OutputState }

func (ServerCertificateTagArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ServerCertificateTag)(nil)).Elem()
}

func (o ServerCertificateTagArrayOutput) ToServerCertificateTagArrayOutput() ServerCertificateTagArrayOutput {
	return o
}

func (o ServerCertificateTagArrayOutput) ToServerCertificateTagArrayOutputWithContext(ctx context.Context) ServerCertificateTagArrayOutput {
	return o
}

func (o ServerCertificateTagArrayOutput) Index(i pulumi.IntInput) ServerCertificateTagOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) ServerCertificateTag {
		return vs[0].([]ServerCertificateTag)[vs[1].(int)]
	}).(ServerCertificateTagOutput)
}

// A key-value pair to associate with a resource.
type VirtualMFADeviceTag struct {
	// The key name of the tag. You can specify a value that is 1 to 128 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
	Key string `pulumi:"key"`
	// The value for the tag. You can specify a value that is 0 to 256 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
	Value string `pulumi:"value"`
}

// VirtualMFADeviceTagInput is an input type that accepts VirtualMFADeviceTagArgs and VirtualMFADeviceTagOutput values.
// You can construct a concrete instance of `VirtualMFADeviceTagInput` via:
//
//          VirtualMFADeviceTagArgs{...}
type VirtualMFADeviceTagInput interface {
	pulumi.Input

	ToVirtualMFADeviceTagOutput() VirtualMFADeviceTagOutput
	ToVirtualMFADeviceTagOutputWithContext(context.Context) VirtualMFADeviceTagOutput
}

// A key-value pair to associate with a resource.
type VirtualMFADeviceTagArgs struct {
	// The key name of the tag. You can specify a value that is 1 to 128 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
	Key pulumi.StringInput `pulumi:"key"`
	// The value for the tag. You can specify a value that is 0 to 256 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
	Value pulumi.StringInput `pulumi:"value"`
}

func (VirtualMFADeviceTagArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*VirtualMFADeviceTag)(nil)).Elem()
}

func (i VirtualMFADeviceTagArgs) ToVirtualMFADeviceTagOutput() VirtualMFADeviceTagOutput {
	return i.ToVirtualMFADeviceTagOutputWithContext(context.Background())
}

func (i VirtualMFADeviceTagArgs) ToVirtualMFADeviceTagOutputWithContext(ctx context.Context) VirtualMFADeviceTagOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VirtualMFADeviceTagOutput)
}

// VirtualMFADeviceTagArrayInput is an input type that accepts VirtualMFADeviceTagArray and VirtualMFADeviceTagArrayOutput values.
// You can construct a concrete instance of `VirtualMFADeviceTagArrayInput` via:
//
//          VirtualMFADeviceTagArray{ VirtualMFADeviceTagArgs{...} }
type VirtualMFADeviceTagArrayInput interface {
	pulumi.Input

	ToVirtualMFADeviceTagArrayOutput() VirtualMFADeviceTagArrayOutput
	ToVirtualMFADeviceTagArrayOutputWithContext(context.Context) VirtualMFADeviceTagArrayOutput
}

type VirtualMFADeviceTagArray []VirtualMFADeviceTagInput

func (VirtualMFADeviceTagArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]VirtualMFADeviceTag)(nil)).Elem()
}

func (i VirtualMFADeviceTagArray) ToVirtualMFADeviceTagArrayOutput() VirtualMFADeviceTagArrayOutput {
	return i.ToVirtualMFADeviceTagArrayOutputWithContext(context.Background())
}

func (i VirtualMFADeviceTagArray) ToVirtualMFADeviceTagArrayOutputWithContext(ctx context.Context) VirtualMFADeviceTagArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VirtualMFADeviceTagArrayOutput)
}

// A key-value pair to associate with a resource.
type VirtualMFADeviceTagOutput struct{ *pulumi.OutputState }

func (VirtualMFADeviceTagOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*VirtualMFADeviceTag)(nil)).Elem()
}

func (o VirtualMFADeviceTagOutput) ToVirtualMFADeviceTagOutput() VirtualMFADeviceTagOutput {
	return o
}

func (o VirtualMFADeviceTagOutput) ToVirtualMFADeviceTagOutputWithContext(ctx context.Context) VirtualMFADeviceTagOutput {
	return o
}

// The key name of the tag. You can specify a value that is 1 to 128 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
func (o VirtualMFADeviceTagOutput) Key() pulumi.StringOutput {
	return o.ApplyT(func(v VirtualMFADeviceTag) string { return v.Key }).(pulumi.StringOutput)
}

// The value for the tag. You can specify a value that is 0 to 256 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
func (o VirtualMFADeviceTagOutput) Value() pulumi.StringOutput {
	return o.ApplyT(func(v VirtualMFADeviceTag) string { return v.Value }).(pulumi.StringOutput)
}

type VirtualMFADeviceTagArrayOutput struct{ *pulumi.OutputState }

func (VirtualMFADeviceTagArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]VirtualMFADeviceTag)(nil)).Elem()
}

func (o VirtualMFADeviceTagArrayOutput) ToVirtualMFADeviceTagArrayOutput() VirtualMFADeviceTagArrayOutput {
	return o
}

func (o VirtualMFADeviceTagArrayOutput) ToVirtualMFADeviceTagArrayOutputWithContext(ctx context.Context) VirtualMFADeviceTagArrayOutput {
	return o
}

func (o VirtualMFADeviceTagArrayOutput) Index(i pulumi.IntInput) VirtualMFADeviceTagOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) VirtualMFADeviceTag {
		return vs[0].([]VirtualMFADeviceTag)[vs[1].(int)]
	}).(VirtualMFADeviceTagOutput)
}

func init() {
	pulumi.RegisterOutputType(OIDCProviderTagOutput{})
	pulumi.RegisterOutputType(OIDCProviderTagArrayOutput{})
	pulumi.RegisterOutputType(SAMLProviderTagOutput{})
	pulumi.RegisterOutputType(SAMLProviderTagArrayOutput{})
	pulumi.RegisterOutputType(ServerCertificateTagOutput{})
	pulumi.RegisterOutputType(ServerCertificateTagArrayOutput{})
	pulumi.RegisterOutputType(VirtualMFADeviceTagOutput{})
	pulumi.RegisterOutputType(VirtualMFADeviceTagArrayOutput{})
}
