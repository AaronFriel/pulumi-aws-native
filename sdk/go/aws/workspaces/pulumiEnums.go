// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package workspaces

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type ConnectionAliasConnectionAliasAssociationAssociationStatus string

const (
	ConnectionAliasConnectionAliasAssociationAssociationStatusNotAssociated               = ConnectionAliasConnectionAliasAssociationAssociationStatus("NOT_ASSOCIATED")
	ConnectionAliasConnectionAliasAssociationAssociationStatusPendingAssociation          = ConnectionAliasConnectionAliasAssociationAssociationStatus("PENDING_ASSOCIATION")
	ConnectionAliasConnectionAliasAssociationAssociationStatusAssociatedWithOwnerAccount  = ConnectionAliasConnectionAliasAssociationAssociationStatus("ASSOCIATED_WITH_OWNER_ACCOUNT")
	ConnectionAliasConnectionAliasAssociationAssociationStatusAssociatedWithSharedAccount = ConnectionAliasConnectionAliasAssociationAssociationStatus("ASSOCIATED_WITH_SHARED_ACCOUNT")
	ConnectionAliasConnectionAliasAssociationAssociationStatusPendingDisassociation       = ConnectionAliasConnectionAliasAssociationAssociationStatus("PENDING_DISASSOCIATION")
)

func (ConnectionAliasConnectionAliasAssociationAssociationStatus) ElementType() reflect.Type {
	return reflect.TypeOf((*ConnectionAliasConnectionAliasAssociationAssociationStatus)(nil)).Elem()
}

func (e ConnectionAliasConnectionAliasAssociationAssociationStatus) ToConnectionAliasConnectionAliasAssociationAssociationStatusOutput() ConnectionAliasConnectionAliasAssociationAssociationStatusOutput {
	return pulumi.ToOutput(e).(ConnectionAliasConnectionAliasAssociationAssociationStatusOutput)
}

func (e ConnectionAliasConnectionAliasAssociationAssociationStatus) ToConnectionAliasConnectionAliasAssociationAssociationStatusOutputWithContext(ctx context.Context) ConnectionAliasConnectionAliasAssociationAssociationStatusOutput {
	return pulumi.ToOutputWithContext(ctx, e).(ConnectionAliasConnectionAliasAssociationAssociationStatusOutput)
}

func (e ConnectionAliasConnectionAliasAssociationAssociationStatus) ToConnectionAliasConnectionAliasAssociationAssociationStatusPtrOutput() ConnectionAliasConnectionAliasAssociationAssociationStatusPtrOutput {
	return e.ToConnectionAliasConnectionAliasAssociationAssociationStatusPtrOutputWithContext(context.Background())
}

func (e ConnectionAliasConnectionAliasAssociationAssociationStatus) ToConnectionAliasConnectionAliasAssociationAssociationStatusPtrOutputWithContext(ctx context.Context) ConnectionAliasConnectionAliasAssociationAssociationStatusPtrOutput {
	return ConnectionAliasConnectionAliasAssociationAssociationStatus(e).ToConnectionAliasConnectionAliasAssociationAssociationStatusOutputWithContext(ctx).ToConnectionAliasConnectionAliasAssociationAssociationStatusPtrOutputWithContext(ctx)
}

func (e ConnectionAliasConnectionAliasAssociationAssociationStatus) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e ConnectionAliasConnectionAliasAssociationAssociationStatus) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e ConnectionAliasConnectionAliasAssociationAssociationStatus) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e ConnectionAliasConnectionAliasAssociationAssociationStatus) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type ConnectionAliasConnectionAliasAssociationAssociationStatusOutput struct{ *pulumi.OutputState }

func (ConnectionAliasConnectionAliasAssociationAssociationStatusOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ConnectionAliasConnectionAliasAssociationAssociationStatus)(nil)).Elem()
}

func (o ConnectionAliasConnectionAliasAssociationAssociationStatusOutput) ToConnectionAliasConnectionAliasAssociationAssociationStatusOutput() ConnectionAliasConnectionAliasAssociationAssociationStatusOutput {
	return o
}

func (o ConnectionAliasConnectionAliasAssociationAssociationStatusOutput) ToConnectionAliasConnectionAliasAssociationAssociationStatusOutputWithContext(ctx context.Context) ConnectionAliasConnectionAliasAssociationAssociationStatusOutput {
	return o
}

func (o ConnectionAliasConnectionAliasAssociationAssociationStatusOutput) ToConnectionAliasConnectionAliasAssociationAssociationStatusPtrOutput() ConnectionAliasConnectionAliasAssociationAssociationStatusPtrOutput {
	return o.ToConnectionAliasConnectionAliasAssociationAssociationStatusPtrOutputWithContext(context.Background())
}

func (o ConnectionAliasConnectionAliasAssociationAssociationStatusOutput) ToConnectionAliasConnectionAliasAssociationAssociationStatusPtrOutputWithContext(ctx context.Context) ConnectionAliasConnectionAliasAssociationAssociationStatusPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v ConnectionAliasConnectionAliasAssociationAssociationStatus) *ConnectionAliasConnectionAliasAssociationAssociationStatus {
		return &v
	}).(ConnectionAliasConnectionAliasAssociationAssociationStatusPtrOutput)
}

func (o ConnectionAliasConnectionAliasAssociationAssociationStatusOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o ConnectionAliasConnectionAliasAssociationAssociationStatusOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e ConnectionAliasConnectionAliasAssociationAssociationStatus) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o ConnectionAliasConnectionAliasAssociationAssociationStatusOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o ConnectionAliasConnectionAliasAssociationAssociationStatusOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e ConnectionAliasConnectionAliasAssociationAssociationStatus) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type ConnectionAliasConnectionAliasAssociationAssociationStatusPtrOutput struct{ *pulumi.OutputState }

func (ConnectionAliasConnectionAliasAssociationAssociationStatusPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ConnectionAliasConnectionAliasAssociationAssociationStatus)(nil)).Elem()
}

func (o ConnectionAliasConnectionAliasAssociationAssociationStatusPtrOutput) ToConnectionAliasConnectionAliasAssociationAssociationStatusPtrOutput() ConnectionAliasConnectionAliasAssociationAssociationStatusPtrOutput {
	return o
}

func (o ConnectionAliasConnectionAliasAssociationAssociationStatusPtrOutput) ToConnectionAliasConnectionAliasAssociationAssociationStatusPtrOutputWithContext(ctx context.Context) ConnectionAliasConnectionAliasAssociationAssociationStatusPtrOutput {
	return o
}

func (o ConnectionAliasConnectionAliasAssociationAssociationStatusPtrOutput) Elem() ConnectionAliasConnectionAliasAssociationAssociationStatusOutput {
	return o.ApplyT(func(v *ConnectionAliasConnectionAliasAssociationAssociationStatus) ConnectionAliasConnectionAliasAssociationAssociationStatus {
		if v != nil {
			return *v
		}
		var ret ConnectionAliasConnectionAliasAssociationAssociationStatus
		return ret
	}).(ConnectionAliasConnectionAliasAssociationAssociationStatusOutput)
}

func (o ConnectionAliasConnectionAliasAssociationAssociationStatusPtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o ConnectionAliasConnectionAliasAssociationAssociationStatusPtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *ConnectionAliasConnectionAliasAssociationAssociationStatus) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// ConnectionAliasConnectionAliasAssociationAssociationStatusInput is an input type that accepts ConnectionAliasConnectionAliasAssociationAssociationStatusArgs and ConnectionAliasConnectionAliasAssociationAssociationStatusOutput values.
// You can construct a concrete instance of `ConnectionAliasConnectionAliasAssociationAssociationStatusInput` via:
//
//          ConnectionAliasConnectionAliasAssociationAssociationStatusArgs{...}
type ConnectionAliasConnectionAliasAssociationAssociationStatusInput interface {
	pulumi.Input

	ToConnectionAliasConnectionAliasAssociationAssociationStatusOutput() ConnectionAliasConnectionAliasAssociationAssociationStatusOutput
	ToConnectionAliasConnectionAliasAssociationAssociationStatusOutputWithContext(context.Context) ConnectionAliasConnectionAliasAssociationAssociationStatusOutput
}

var connectionAliasConnectionAliasAssociationAssociationStatusPtrType = reflect.TypeOf((**ConnectionAliasConnectionAliasAssociationAssociationStatus)(nil)).Elem()

type ConnectionAliasConnectionAliasAssociationAssociationStatusPtrInput interface {
	pulumi.Input

	ToConnectionAliasConnectionAliasAssociationAssociationStatusPtrOutput() ConnectionAliasConnectionAliasAssociationAssociationStatusPtrOutput
	ToConnectionAliasConnectionAliasAssociationAssociationStatusPtrOutputWithContext(context.Context) ConnectionAliasConnectionAliasAssociationAssociationStatusPtrOutput
}

type connectionAliasConnectionAliasAssociationAssociationStatusPtr string

func ConnectionAliasConnectionAliasAssociationAssociationStatusPtr(v string) ConnectionAliasConnectionAliasAssociationAssociationStatusPtrInput {
	return (*connectionAliasConnectionAliasAssociationAssociationStatusPtr)(&v)
}

func (*connectionAliasConnectionAliasAssociationAssociationStatusPtr) ElementType() reflect.Type {
	return connectionAliasConnectionAliasAssociationAssociationStatusPtrType
}

func (in *connectionAliasConnectionAliasAssociationAssociationStatusPtr) ToConnectionAliasConnectionAliasAssociationAssociationStatusPtrOutput() ConnectionAliasConnectionAliasAssociationAssociationStatusPtrOutput {
	return pulumi.ToOutput(in).(ConnectionAliasConnectionAliasAssociationAssociationStatusPtrOutput)
}

func (in *connectionAliasConnectionAliasAssociationAssociationStatusPtr) ToConnectionAliasConnectionAliasAssociationAssociationStatusPtrOutputWithContext(ctx context.Context) ConnectionAliasConnectionAliasAssociationAssociationStatusPtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(ConnectionAliasConnectionAliasAssociationAssociationStatusPtrOutput)
}

type ConnectionAliasConnectionAliasState string

const (
	ConnectionAliasConnectionAliasStateCreating = ConnectionAliasConnectionAliasState("CREATING")
	ConnectionAliasConnectionAliasStateCreated  = ConnectionAliasConnectionAliasState("CREATED")
	ConnectionAliasConnectionAliasStateDeleting = ConnectionAliasConnectionAliasState("DELETING")
)

func (ConnectionAliasConnectionAliasState) ElementType() reflect.Type {
	return reflect.TypeOf((*ConnectionAliasConnectionAliasState)(nil)).Elem()
}

func (e ConnectionAliasConnectionAliasState) ToConnectionAliasConnectionAliasStateOutput() ConnectionAliasConnectionAliasStateOutput {
	return pulumi.ToOutput(e).(ConnectionAliasConnectionAliasStateOutput)
}

func (e ConnectionAliasConnectionAliasState) ToConnectionAliasConnectionAliasStateOutputWithContext(ctx context.Context) ConnectionAliasConnectionAliasStateOutput {
	return pulumi.ToOutputWithContext(ctx, e).(ConnectionAliasConnectionAliasStateOutput)
}

func (e ConnectionAliasConnectionAliasState) ToConnectionAliasConnectionAliasStatePtrOutput() ConnectionAliasConnectionAliasStatePtrOutput {
	return e.ToConnectionAliasConnectionAliasStatePtrOutputWithContext(context.Background())
}

func (e ConnectionAliasConnectionAliasState) ToConnectionAliasConnectionAliasStatePtrOutputWithContext(ctx context.Context) ConnectionAliasConnectionAliasStatePtrOutput {
	return ConnectionAliasConnectionAliasState(e).ToConnectionAliasConnectionAliasStateOutputWithContext(ctx).ToConnectionAliasConnectionAliasStatePtrOutputWithContext(ctx)
}

func (e ConnectionAliasConnectionAliasState) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e ConnectionAliasConnectionAliasState) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e ConnectionAliasConnectionAliasState) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e ConnectionAliasConnectionAliasState) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type ConnectionAliasConnectionAliasStateOutput struct{ *pulumi.OutputState }

func (ConnectionAliasConnectionAliasStateOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ConnectionAliasConnectionAliasState)(nil)).Elem()
}

func (o ConnectionAliasConnectionAliasStateOutput) ToConnectionAliasConnectionAliasStateOutput() ConnectionAliasConnectionAliasStateOutput {
	return o
}

func (o ConnectionAliasConnectionAliasStateOutput) ToConnectionAliasConnectionAliasStateOutputWithContext(ctx context.Context) ConnectionAliasConnectionAliasStateOutput {
	return o
}

func (o ConnectionAliasConnectionAliasStateOutput) ToConnectionAliasConnectionAliasStatePtrOutput() ConnectionAliasConnectionAliasStatePtrOutput {
	return o.ToConnectionAliasConnectionAliasStatePtrOutputWithContext(context.Background())
}

func (o ConnectionAliasConnectionAliasStateOutput) ToConnectionAliasConnectionAliasStatePtrOutputWithContext(ctx context.Context) ConnectionAliasConnectionAliasStatePtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v ConnectionAliasConnectionAliasState) *ConnectionAliasConnectionAliasState {
		return &v
	}).(ConnectionAliasConnectionAliasStatePtrOutput)
}

func (o ConnectionAliasConnectionAliasStateOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o ConnectionAliasConnectionAliasStateOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e ConnectionAliasConnectionAliasState) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o ConnectionAliasConnectionAliasStateOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o ConnectionAliasConnectionAliasStateOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e ConnectionAliasConnectionAliasState) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type ConnectionAliasConnectionAliasStatePtrOutput struct{ *pulumi.OutputState }

func (ConnectionAliasConnectionAliasStatePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ConnectionAliasConnectionAliasState)(nil)).Elem()
}

func (o ConnectionAliasConnectionAliasStatePtrOutput) ToConnectionAliasConnectionAliasStatePtrOutput() ConnectionAliasConnectionAliasStatePtrOutput {
	return o
}

func (o ConnectionAliasConnectionAliasStatePtrOutput) ToConnectionAliasConnectionAliasStatePtrOutputWithContext(ctx context.Context) ConnectionAliasConnectionAliasStatePtrOutput {
	return o
}

func (o ConnectionAliasConnectionAliasStatePtrOutput) Elem() ConnectionAliasConnectionAliasStateOutput {
	return o.ApplyT(func(v *ConnectionAliasConnectionAliasState) ConnectionAliasConnectionAliasState {
		if v != nil {
			return *v
		}
		var ret ConnectionAliasConnectionAliasState
		return ret
	}).(ConnectionAliasConnectionAliasStateOutput)
}

func (o ConnectionAliasConnectionAliasStatePtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o ConnectionAliasConnectionAliasStatePtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *ConnectionAliasConnectionAliasState) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// ConnectionAliasConnectionAliasStateInput is an input type that accepts ConnectionAliasConnectionAliasStateArgs and ConnectionAliasConnectionAliasStateOutput values.
// You can construct a concrete instance of `ConnectionAliasConnectionAliasStateInput` via:
//
//          ConnectionAliasConnectionAliasStateArgs{...}
type ConnectionAliasConnectionAliasStateInput interface {
	pulumi.Input

	ToConnectionAliasConnectionAliasStateOutput() ConnectionAliasConnectionAliasStateOutput
	ToConnectionAliasConnectionAliasStateOutputWithContext(context.Context) ConnectionAliasConnectionAliasStateOutput
}

var connectionAliasConnectionAliasStatePtrType = reflect.TypeOf((**ConnectionAliasConnectionAliasState)(nil)).Elem()

type ConnectionAliasConnectionAliasStatePtrInput interface {
	pulumi.Input

	ToConnectionAliasConnectionAliasStatePtrOutput() ConnectionAliasConnectionAliasStatePtrOutput
	ToConnectionAliasConnectionAliasStatePtrOutputWithContext(context.Context) ConnectionAliasConnectionAliasStatePtrOutput
}

type connectionAliasConnectionAliasStatePtr string

func ConnectionAliasConnectionAliasStatePtr(v string) ConnectionAliasConnectionAliasStatePtrInput {
	return (*connectionAliasConnectionAliasStatePtr)(&v)
}

func (*connectionAliasConnectionAliasStatePtr) ElementType() reflect.Type {
	return connectionAliasConnectionAliasStatePtrType
}

func (in *connectionAliasConnectionAliasStatePtr) ToConnectionAliasConnectionAliasStatePtrOutput() ConnectionAliasConnectionAliasStatePtrOutput {
	return pulumi.ToOutput(in).(ConnectionAliasConnectionAliasStatePtrOutput)
}

func (in *connectionAliasConnectionAliasStatePtr) ToConnectionAliasConnectionAliasStatePtrOutputWithContext(ctx context.Context) ConnectionAliasConnectionAliasStatePtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(ConnectionAliasConnectionAliasStatePtrOutput)
}

func init() {
	pulumi.RegisterOutputType(ConnectionAliasConnectionAliasAssociationAssociationStatusOutput{})
	pulumi.RegisterOutputType(ConnectionAliasConnectionAliasAssociationAssociationStatusPtrOutput{})
	pulumi.RegisterOutputType(ConnectionAliasConnectionAliasStateOutput{})
	pulumi.RegisterOutputType(ConnectionAliasConnectionAliasStatePtrOutput{})
}