// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package glue

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type RegistryTag struct {
	// A key to identify the tag.
	Key string `pulumi:"key"`
	// Corresponding tag value for the key.
	Value string `pulumi:"value"`
}

// RegistryTagInput is an input type that accepts RegistryTagArgs and RegistryTagOutput values.
// You can construct a concrete instance of `RegistryTagInput` via:
//
//          RegistryTagArgs{...}
type RegistryTagInput interface {
	pulumi.Input

	ToRegistryTagOutput() RegistryTagOutput
	ToRegistryTagOutputWithContext(context.Context) RegistryTagOutput
}

type RegistryTagArgs struct {
	// A key to identify the tag.
	Key pulumi.StringInput `pulumi:"key"`
	// Corresponding tag value for the key.
	Value pulumi.StringInput `pulumi:"value"`
}

func (RegistryTagArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*RegistryTag)(nil)).Elem()
}

func (i RegistryTagArgs) ToRegistryTagOutput() RegistryTagOutput {
	return i.ToRegistryTagOutputWithContext(context.Background())
}

func (i RegistryTagArgs) ToRegistryTagOutputWithContext(ctx context.Context) RegistryTagOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RegistryTagOutput)
}

// RegistryTagArrayInput is an input type that accepts RegistryTagArray and RegistryTagArrayOutput values.
// You can construct a concrete instance of `RegistryTagArrayInput` via:
//
//          RegistryTagArray{ RegistryTagArgs{...} }
type RegistryTagArrayInput interface {
	pulumi.Input

	ToRegistryTagArrayOutput() RegistryTagArrayOutput
	ToRegistryTagArrayOutputWithContext(context.Context) RegistryTagArrayOutput
}

type RegistryTagArray []RegistryTagInput

func (RegistryTagArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]RegistryTag)(nil)).Elem()
}

func (i RegistryTagArray) ToRegistryTagArrayOutput() RegistryTagArrayOutput {
	return i.ToRegistryTagArrayOutputWithContext(context.Background())
}

func (i RegistryTagArray) ToRegistryTagArrayOutputWithContext(ctx context.Context) RegistryTagArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RegistryTagArrayOutput)
}

type RegistryTagOutput struct{ *pulumi.OutputState }

func (RegistryTagOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*RegistryTag)(nil)).Elem()
}

func (o RegistryTagOutput) ToRegistryTagOutput() RegistryTagOutput {
	return o
}

func (o RegistryTagOutput) ToRegistryTagOutputWithContext(ctx context.Context) RegistryTagOutput {
	return o
}

// A key to identify the tag.
func (o RegistryTagOutput) Key() pulumi.StringOutput {
	return o.ApplyT(func(v RegistryTag) string { return v.Key }).(pulumi.StringOutput)
}

// Corresponding tag value for the key.
func (o RegistryTagOutput) Value() pulumi.StringOutput {
	return o.ApplyT(func(v RegistryTag) string { return v.Value }).(pulumi.StringOutput)
}

type RegistryTagArrayOutput struct{ *pulumi.OutputState }

func (RegistryTagArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]RegistryTag)(nil)).Elem()
}

func (o RegistryTagArrayOutput) ToRegistryTagArrayOutput() RegistryTagArrayOutput {
	return o
}

func (o RegistryTagArrayOutput) ToRegistryTagArrayOutputWithContext(ctx context.Context) RegistryTagArrayOutput {
	return o
}

func (o RegistryTagArrayOutput) Index(i pulumi.IntInput) RegistryTagOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) RegistryTag {
		return vs[0].([]RegistryTag)[vs[1].(int)]
	}).(RegistryTagOutput)
}

// Identifier for the registry which the schema is part of.
type SchemaRegistry struct {
	// Amazon Resource Name for the Registry.
	Arn *string `pulumi:"arn"`
	// Name of the registry in which the schema will be created.
	Name *string `pulumi:"name"`
}

// SchemaRegistryInput is an input type that accepts SchemaRegistryArgs and SchemaRegistryOutput values.
// You can construct a concrete instance of `SchemaRegistryInput` via:
//
//          SchemaRegistryArgs{...}
type SchemaRegistryInput interface {
	pulumi.Input

	ToSchemaRegistryOutput() SchemaRegistryOutput
	ToSchemaRegistryOutputWithContext(context.Context) SchemaRegistryOutput
}

// Identifier for the registry which the schema is part of.
type SchemaRegistryArgs struct {
	// Amazon Resource Name for the Registry.
	Arn pulumi.StringPtrInput `pulumi:"arn"`
	// Name of the registry in which the schema will be created.
	Name pulumi.StringPtrInput `pulumi:"name"`
}

func (SchemaRegistryArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*SchemaRegistry)(nil)).Elem()
}

func (i SchemaRegistryArgs) ToSchemaRegistryOutput() SchemaRegistryOutput {
	return i.ToSchemaRegistryOutputWithContext(context.Background())
}

func (i SchemaRegistryArgs) ToSchemaRegistryOutputWithContext(ctx context.Context) SchemaRegistryOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SchemaRegistryOutput)
}

func (i SchemaRegistryArgs) ToSchemaRegistryPtrOutput() SchemaRegistryPtrOutput {
	return i.ToSchemaRegistryPtrOutputWithContext(context.Background())
}

func (i SchemaRegistryArgs) ToSchemaRegistryPtrOutputWithContext(ctx context.Context) SchemaRegistryPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SchemaRegistryOutput).ToSchemaRegistryPtrOutputWithContext(ctx)
}

// SchemaRegistryPtrInput is an input type that accepts SchemaRegistryArgs, SchemaRegistryPtr and SchemaRegistryPtrOutput values.
// You can construct a concrete instance of `SchemaRegistryPtrInput` via:
//
//          SchemaRegistryArgs{...}
//
//  or:
//
//          nil
type SchemaRegistryPtrInput interface {
	pulumi.Input

	ToSchemaRegistryPtrOutput() SchemaRegistryPtrOutput
	ToSchemaRegistryPtrOutputWithContext(context.Context) SchemaRegistryPtrOutput
}

type schemaRegistryPtrType SchemaRegistryArgs

func SchemaRegistryPtr(v *SchemaRegistryArgs) SchemaRegistryPtrInput {
	return (*schemaRegistryPtrType)(v)
}

func (*schemaRegistryPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**SchemaRegistry)(nil)).Elem()
}

func (i *schemaRegistryPtrType) ToSchemaRegistryPtrOutput() SchemaRegistryPtrOutput {
	return i.ToSchemaRegistryPtrOutputWithContext(context.Background())
}

func (i *schemaRegistryPtrType) ToSchemaRegistryPtrOutputWithContext(ctx context.Context) SchemaRegistryPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SchemaRegistryPtrOutput)
}

// Identifier for the registry which the schema is part of.
type SchemaRegistryOutput struct{ *pulumi.OutputState }

func (SchemaRegistryOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SchemaRegistry)(nil)).Elem()
}

func (o SchemaRegistryOutput) ToSchemaRegistryOutput() SchemaRegistryOutput {
	return o
}

func (o SchemaRegistryOutput) ToSchemaRegistryOutputWithContext(ctx context.Context) SchemaRegistryOutput {
	return o
}

func (o SchemaRegistryOutput) ToSchemaRegistryPtrOutput() SchemaRegistryPtrOutput {
	return o.ToSchemaRegistryPtrOutputWithContext(context.Background())
}

func (o SchemaRegistryOutput) ToSchemaRegistryPtrOutputWithContext(ctx context.Context) SchemaRegistryPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v SchemaRegistry) *SchemaRegistry {
		return &v
	}).(SchemaRegistryPtrOutput)
}

// Amazon Resource Name for the Registry.
func (o SchemaRegistryOutput) Arn() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SchemaRegistry) *string { return v.Arn }).(pulumi.StringPtrOutput)
}

// Name of the registry in which the schema will be created.
func (o SchemaRegistryOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SchemaRegistry) *string { return v.Name }).(pulumi.StringPtrOutput)
}

type SchemaRegistryPtrOutput struct{ *pulumi.OutputState }

func (SchemaRegistryPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**SchemaRegistry)(nil)).Elem()
}

func (o SchemaRegistryPtrOutput) ToSchemaRegistryPtrOutput() SchemaRegistryPtrOutput {
	return o
}

func (o SchemaRegistryPtrOutput) ToSchemaRegistryPtrOutputWithContext(ctx context.Context) SchemaRegistryPtrOutput {
	return o
}

func (o SchemaRegistryPtrOutput) Elem() SchemaRegistryOutput {
	return o.ApplyT(func(v *SchemaRegistry) SchemaRegistry {
		if v != nil {
			return *v
		}
		var ret SchemaRegistry
		return ret
	}).(SchemaRegistryOutput)
}

// Amazon Resource Name for the Registry.
func (o SchemaRegistryPtrOutput) Arn() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SchemaRegistry) *string {
		if v == nil {
			return nil
		}
		return v.Arn
	}).(pulumi.StringPtrOutput)
}

// Name of the registry in which the schema will be created.
func (o SchemaRegistryPtrOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SchemaRegistry) *string {
		if v == nil {
			return nil
		}
		return v.Name
	}).(pulumi.StringPtrOutput)
}

// Specify checkpoint version for update. This is only required to update the Compatibility.
type SchemaSchemaVersion struct {
	// Indicates if the latest version needs to be updated.
	IsLatest *bool `pulumi:"isLatest"`
	// Indicates the version number in the schema to update.
	VersionNumber *int `pulumi:"versionNumber"`
}

// SchemaSchemaVersionInput is an input type that accepts SchemaSchemaVersionArgs and SchemaSchemaVersionOutput values.
// You can construct a concrete instance of `SchemaSchemaVersionInput` via:
//
//          SchemaSchemaVersionArgs{...}
type SchemaSchemaVersionInput interface {
	pulumi.Input

	ToSchemaSchemaVersionOutput() SchemaSchemaVersionOutput
	ToSchemaSchemaVersionOutputWithContext(context.Context) SchemaSchemaVersionOutput
}

// Specify checkpoint version for update. This is only required to update the Compatibility.
type SchemaSchemaVersionArgs struct {
	// Indicates if the latest version needs to be updated.
	IsLatest pulumi.BoolPtrInput `pulumi:"isLatest"`
	// Indicates the version number in the schema to update.
	VersionNumber pulumi.IntPtrInput `pulumi:"versionNumber"`
}

func (SchemaSchemaVersionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*SchemaSchemaVersion)(nil)).Elem()
}

func (i SchemaSchemaVersionArgs) ToSchemaSchemaVersionOutput() SchemaSchemaVersionOutput {
	return i.ToSchemaSchemaVersionOutputWithContext(context.Background())
}

func (i SchemaSchemaVersionArgs) ToSchemaSchemaVersionOutputWithContext(ctx context.Context) SchemaSchemaVersionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SchemaSchemaVersionOutput)
}

func (i SchemaSchemaVersionArgs) ToSchemaSchemaVersionPtrOutput() SchemaSchemaVersionPtrOutput {
	return i.ToSchemaSchemaVersionPtrOutputWithContext(context.Background())
}

func (i SchemaSchemaVersionArgs) ToSchemaSchemaVersionPtrOutputWithContext(ctx context.Context) SchemaSchemaVersionPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SchemaSchemaVersionOutput).ToSchemaSchemaVersionPtrOutputWithContext(ctx)
}

// SchemaSchemaVersionPtrInput is an input type that accepts SchemaSchemaVersionArgs, SchemaSchemaVersionPtr and SchemaSchemaVersionPtrOutput values.
// You can construct a concrete instance of `SchemaSchemaVersionPtrInput` via:
//
//          SchemaSchemaVersionArgs{...}
//
//  or:
//
//          nil
type SchemaSchemaVersionPtrInput interface {
	pulumi.Input

	ToSchemaSchemaVersionPtrOutput() SchemaSchemaVersionPtrOutput
	ToSchemaSchemaVersionPtrOutputWithContext(context.Context) SchemaSchemaVersionPtrOutput
}

type schemaSchemaVersionPtrType SchemaSchemaVersionArgs

func SchemaSchemaVersionPtr(v *SchemaSchemaVersionArgs) SchemaSchemaVersionPtrInput {
	return (*schemaSchemaVersionPtrType)(v)
}

func (*schemaSchemaVersionPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**SchemaSchemaVersion)(nil)).Elem()
}

func (i *schemaSchemaVersionPtrType) ToSchemaSchemaVersionPtrOutput() SchemaSchemaVersionPtrOutput {
	return i.ToSchemaSchemaVersionPtrOutputWithContext(context.Background())
}

func (i *schemaSchemaVersionPtrType) ToSchemaSchemaVersionPtrOutputWithContext(ctx context.Context) SchemaSchemaVersionPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SchemaSchemaVersionPtrOutput)
}

// Specify checkpoint version for update. This is only required to update the Compatibility.
type SchemaSchemaVersionOutput struct{ *pulumi.OutputState }

func (SchemaSchemaVersionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SchemaSchemaVersion)(nil)).Elem()
}

func (o SchemaSchemaVersionOutput) ToSchemaSchemaVersionOutput() SchemaSchemaVersionOutput {
	return o
}

func (o SchemaSchemaVersionOutput) ToSchemaSchemaVersionOutputWithContext(ctx context.Context) SchemaSchemaVersionOutput {
	return o
}

func (o SchemaSchemaVersionOutput) ToSchemaSchemaVersionPtrOutput() SchemaSchemaVersionPtrOutput {
	return o.ToSchemaSchemaVersionPtrOutputWithContext(context.Background())
}

func (o SchemaSchemaVersionOutput) ToSchemaSchemaVersionPtrOutputWithContext(ctx context.Context) SchemaSchemaVersionPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v SchemaSchemaVersion) *SchemaSchemaVersion {
		return &v
	}).(SchemaSchemaVersionPtrOutput)
}

// Indicates if the latest version needs to be updated.
func (o SchemaSchemaVersionOutput) IsLatest() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v SchemaSchemaVersion) *bool { return v.IsLatest }).(pulumi.BoolPtrOutput)
}

// Indicates the version number in the schema to update.
func (o SchemaSchemaVersionOutput) VersionNumber() pulumi.IntPtrOutput {
	return o.ApplyT(func(v SchemaSchemaVersion) *int { return v.VersionNumber }).(pulumi.IntPtrOutput)
}

type SchemaSchemaVersionPtrOutput struct{ *pulumi.OutputState }

func (SchemaSchemaVersionPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**SchemaSchemaVersion)(nil)).Elem()
}

func (o SchemaSchemaVersionPtrOutput) ToSchemaSchemaVersionPtrOutput() SchemaSchemaVersionPtrOutput {
	return o
}

func (o SchemaSchemaVersionPtrOutput) ToSchemaSchemaVersionPtrOutputWithContext(ctx context.Context) SchemaSchemaVersionPtrOutput {
	return o
}

func (o SchemaSchemaVersionPtrOutput) Elem() SchemaSchemaVersionOutput {
	return o.ApplyT(func(v *SchemaSchemaVersion) SchemaSchemaVersion {
		if v != nil {
			return *v
		}
		var ret SchemaSchemaVersion
		return ret
	}).(SchemaSchemaVersionOutput)
}

// Indicates if the latest version needs to be updated.
func (o SchemaSchemaVersionPtrOutput) IsLatest() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *SchemaSchemaVersion) *bool {
		if v == nil {
			return nil
		}
		return v.IsLatest
	}).(pulumi.BoolPtrOutput)
}

// Indicates the version number in the schema to update.
func (o SchemaSchemaVersionPtrOutput) VersionNumber() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *SchemaSchemaVersion) *int {
		if v == nil {
			return nil
		}
		return v.VersionNumber
	}).(pulumi.IntPtrOutput)
}

type SchemaTag struct {
	// A key to identify the tag.
	Key string `pulumi:"key"`
	// Corresponding tag value for the key.
	Value string `pulumi:"value"`
}

// SchemaTagInput is an input type that accepts SchemaTagArgs and SchemaTagOutput values.
// You can construct a concrete instance of `SchemaTagInput` via:
//
//          SchemaTagArgs{...}
type SchemaTagInput interface {
	pulumi.Input

	ToSchemaTagOutput() SchemaTagOutput
	ToSchemaTagOutputWithContext(context.Context) SchemaTagOutput
}

type SchemaTagArgs struct {
	// A key to identify the tag.
	Key pulumi.StringInput `pulumi:"key"`
	// Corresponding tag value for the key.
	Value pulumi.StringInput `pulumi:"value"`
}

func (SchemaTagArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*SchemaTag)(nil)).Elem()
}

func (i SchemaTagArgs) ToSchemaTagOutput() SchemaTagOutput {
	return i.ToSchemaTagOutputWithContext(context.Background())
}

func (i SchemaTagArgs) ToSchemaTagOutputWithContext(ctx context.Context) SchemaTagOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SchemaTagOutput)
}

// SchemaTagArrayInput is an input type that accepts SchemaTagArray and SchemaTagArrayOutput values.
// You can construct a concrete instance of `SchemaTagArrayInput` via:
//
//          SchemaTagArray{ SchemaTagArgs{...} }
type SchemaTagArrayInput interface {
	pulumi.Input

	ToSchemaTagArrayOutput() SchemaTagArrayOutput
	ToSchemaTagArrayOutputWithContext(context.Context) SchemaTagArrayOutput
}

type SchemaTagArray []SchemaTagInput

func (SchemaTagArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]SchemaTag)(nil)).Elem()
}

func (i SchemaTagArray) ToSchemaTagArrayOutput() SchemaTagArrayOutput {
	return i.ToSchemaTagArrayOutputWithContext(context.Background())
}

func (i SchemaTagArray) ToSchemaTagArrayOutputWithContext(ctx context.Context) SchemaTagArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SchemaTagArrayOutput)
}

type SchemaTagOutput struct{ *pulumi.OutputState }

func (SchemaTagOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SchemaTag)(nil)).Elem()
}

func (o SchemaTagOutput) ToSchemaTagOutput() SchemaTagOutput {
	return o
}

func (o SchemaTagOutput) ToSchemaTagOutputWithContext(ctx context.Context) SchemaTagOutput {
	return o
}

// A key to identify the tag.
func (o SchemaTagOutput) Key() pulumi.StringOutput {
	return o.ApplyT(func(v SchemaTag) string { return v.Key }).(pulumi.StringOutput)
}

// Corresponding tag value for the key.
func (o SchemaTagOutput) Value() pulumi.StringOutput {
	return o.ApplyT(func(v SchemaTag) string { return v.Value }).(pulumi.StringOutput)
}

type SchemaTagArrayOutput struct{ *pulumi.OutputState }

func (SchemaTagArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]SchemaTag)(nil)).Elem()
}

func (o SchemaTagArrayOutput) ToSchemaTagArrayOutput() SchemaTagArrayOutput {
	return o
}

func (o SchemaTagArrayOutput) ToSchemaTagArrayOutputWithContext(ctx context.Context) SchemaTagArrayOutput {
	return o
}

func (o SchemaTagArrayOutput) Index(i pulumi.IntInput) SchemaTagOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) SchemaTag {
		return vs[0].([]SchemaTag)[vs[1].(int)]
	}).(SchemaTagOutput)
}

// Identifier for the schema where the schema version will be created.
type SchemaVersionSchema struct {
	// Name of the registry to identify where the Schema is located.
	RegistryName *string `pulumi:"registryName"`
	// Amazon Resource Name for the Schema. This attribute can be used to uniquely represent the Schema.
	SchemaArn *string `pulumi:"schemaArn"`
	// Name of the schema. This parameter requires RegistryName to be provided.
	SchemaName *string `pulumi:"schemaName"`
}

// SchemaVersionSchemaInput is an input type that accepts SchemaVersionSchemaArgs and SchemaVersionSchemaOutput values.
// You can construct a concrete instance of `SchemaVersionSchemaInput` via:
//
//          SchemaVersionSchemaArgs{...}
type SchemaVersionSchemaInput interface {
	pulumi.Input

	ToSchemaVersionSchemaOutput() SchemaVersionSchemaOutput
	ToSchemaVersionSchemaOutputWithContext(context.Context) SchemaVersionSchemaOutput
}

// Identifier for the schema where the schema version will be created.
type SchemaVersionSchemaArgs struct {
	// Name of the registry to identify where the Schema is located.
	RegistryName pulumi.StringPtrInput `pulumi:"registryName"`
	// Amazon Resource Name for the Schema. This attribute can be used to uniquely represent the Schema.
	SchemaArn pulumi.StringPtrInput `pulumi:"schemaArn"`
	// Name of the schema. This parameter requires RegistryName to be provided.
	SchemaName pulumi.StringPtrInput `pulumi:"schemaName"`
}

func (SchemaVersionSchemaArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*SchemaVersionSchema)(nil)).Elem()
}

func (i SchemaVersionSchemaArgs) ToSchemaVersionSchemaOutput() SchemaVersionSchemaOutput {
	return i.ToSchemaVersionSchemaOutputWithContext(context.Background())
}

func (i SchemaVersionSchemaArgs) ToSchemaVersionSchemaOutputWithContext(ctx context.Context) SchemaVersionSchemaOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SchemaVersionSchemaOutput)
}

func (i SchemaVersionSchemaArgs) ToSchemaVersionSchemaPtrOutput() SchemaVersionSchemaPtrOutput {
	return i.ToSchemaVersionSchemaPtrOutputWithContext(context.Background())
}

func (i SchemaVersionSchemaArgs) ToSchemaVersionSchemaPtrOutputWithContext(ctx context.Context) SchemaVersionSchemaPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SchemaVersionSchemaOutput).ToSchemaVersionSchemaPtrOutputWithContext(ctx)
}

// SchemaVersionSchemaPtrInput is an input type that accepts SchemaVersionSchemaArgs, SchemaVersionSchemaPtr and SchemaVersionSchemaPtrOutput values.
// You can construct a concrete instance of `SchemaVersionSchemaPtrInput` via:
//
//          SchemaVersionSchemaArgs{...}
//
//  or:
//
//          nil
type SchemaVersionSchemaPtrInput interface {
	pulumi.Input

	ToSchemaVersionSchemaPtrOutput() SchemaVersionSchemaPtrOutput
	ToSchemaVersionSchemaPtrOutputWithContext(context.Context) SchemaVersionSchemaPtrOutput
}

type schemaVersionSchemaPtrType SchemaVersionSchemaArgs

func SchemaVersionSchemaPtr(v *SchemaVersionSchemaArgs) SchemaVersionSchemaPtrInput {
	return (*schemaVersionSchemaPtrType)(v)
}

func (*schemaVersionSchemaPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**SchemaVersionSchema)(nil)).Elem()
}

func (i *schemaVersionSchemaPtrType) ToSchemaVersionSchemaPtrOutput() SchemaVersionSchemaPtrOutput {
	return i.ToSchemaVersionSchemaPtrOutputWithContext(context.Background())
}

func (i *schemaVersionSchemaPtrType) ToSchemaVersionSchemaPtrOutputWithContext(ctx context.Context) SchemaVersionSchemaPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SchemaVersionSchemaPtrOutput)
}

// Identifier for the schema where the schema version will be created.
type SchemaVersionSchemaOutput struct{ *pulumi.OutputState }

func (SchemaVersionSchemaOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SchemaVersionSchema)(nil)).Elem()
}

func (o SchemaVersionSchemaOutput) ToSchemaVersionSchemaOutput() SchemaVersionSchemaOutput {
	return o
}

func (o SchemaVersionSchemaOutput) ToSchemaVersionSchemaOutputWithContext(ctx context.Context) SchemaVersionSchemaOutput {
	return o
}

func (o SchemaVersionSchemaOutput) ToSchemaVersionSchemaPtrOutput() SchemaVersionSchemaPtrOutput {
	return o.ToSchemaVersionSchemaPtrOutputWithContext(context.Background())
}

func (o SchemaVersionSchemaOutput) ToSchemaVersionSchemaPtrOutputWithContext(ctx context.Context) SchemaVersionSchemaPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v SchemaVersionSchema) *SchemaVersionSchema {
		return &v
	}).(SchemaVersionSchemaPtrOutput)
}

// Name of the registry to identify where the Schema is located.
func (o SchemaVersionSchemaOutput) RegistryName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SchemaVersionSchema) *string { return v.RegistryName }).(pulumi.StringPtrOutput)
}

// Amazon Resource Name for the Schema. This attribute can be used to uniquely represent the Schema.
func (o SchemaVersionSchemaOutput) SchemaArn() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SchemaVersionSchema) *string { return v.SchemaArn }).(pulumi.StringPtrOutput)
}

// Name of the schema. This parameter requires RegistryName to be provided.
func (o SchemaVersionSchemaOutput) SchemaName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SchemaVersionSchema) *string { return v.SchemaName }).(pulumi.StringPtrOutput)
}

type SchemaVersionSchemaPtrOutput struct{ *pulumi.OutputState }

func (SchemaVersionSchemaPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**SchemaVersionSchema)(nil)).Elem()
}

func (o SchemaVersionSchemaPtrOutput) ToSchemaVersionSchemaPtrOutput() SchemaVersionSchemaPtrOutput {
	return o
}

func (o SchemaVersionSchemaPtrOutput) ToSchemaVersionSchemaPtrOutputWithContext(ctx context.Context) SchemaVersionSchemaPtrOutput {
	return o
}

func (o SchemaVersionSchemaPtrOutput) Elem() SchemaVersionSchemaOutput {
	return o.ApplyT(func(v *SchemaVersionSchema) SchemaVersionSchema {
		if v != nil {
			return *v
		}
		var ret SchemaVersionSchema
		return ret
	}).(SchemaVersionSchemaOutput)
}

// Name of the registry to identify where the Schema is located.
func (o SchemaVersionSchemaPtrOutput) RegistryName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SchemaVersionSchema) *string {
		if v == nil {
			return nil
		}
		return v.RegistryName
	}).(pulumi.StringPtrOutput)
}

// Amazon Resource Name for the Schema. This attribute can be used to uniquely represent the Schema.
func (o SchemaVersionSchemaPtrOutput) SchemaArn() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SchemaVersionSchema) *string {
		if v == nil {
			return nil
		}
		return v.SchemaArn
	}).(pulumi.StringPtrOutput)
}

// Name of the schema. This parameter requires RegistryName to be provided.
func (o SchemaVersionSchemaPtrOutput) SchemaName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SchemaVersionSchema) *string {
		if v == nil {
			return nil
		}
		return v.SchemaName
	}).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(RegistryTagOutput{})
	pulumi.RegisterOutputType(RegistryTagArrayOutput{})
	pulumi.RegisterOutputType(SchemaRegistryOutput{})
	pulumi.RegisterOutputType(SchemaRegistryPtrOutput{})
	pulumi.RegisterOutputType(SchemaSchemaVersionOutput{})
	pulumi.RegisterOutputType(SchemaSchemaVersionPtrOutput{})
	pulumi.RegisterOutputType(SchemaTagOutput{})
	pulumi.RegisterOutputType(SchemaTagArrayOutput{})
	pulumi.RegisterOutputType(SchemaVersionSchemaOutput{})
	pulumi.RegisterOutputType(SchemaVersionSchemaPtrOutput{})
}
