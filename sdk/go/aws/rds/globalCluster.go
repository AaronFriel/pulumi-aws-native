// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package rds

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::RDS::GlobalCluster
type GlobalCluster struct {
	pulumi.CustomResourceState

	// The deletion protection setting for the new global database. The global database can't be deleted when deletion protection is enabled.
	DeletionProtection pulumi.BoolPtrOutput `pulumi:"deletionProtection"`
	// The name of the database engine to be used for this DB cluster. Valid Values: aurora (for MySQL 5.6-compatible Aurora), aurora-mysql (for MySQL 5.7-compatible Aurora).
	// If you specify the SourceDBClusterIdentifier property, don't specify this property. The value is inherited from the cluster.
	Engine GlobalClusterEnginePtrOutput `pulumi:"engine"`
	// The version number of the database engine to use. If you specify the SourceDBClusterIdentifier property, don't specify this property. The value is inherited from the cluster.
	EngineVersion pulumi.StringPtrOutput `pulumi:"engineVersion"`
	// The cluster identifier of the new global database cluster. This parameter is stored as a lowercase string.
	GlobalClusterIdentifier pulumi.StringPtrOutput `pulumi:"globalClusterIdentifier"`
	// The Amazon Resource Name (ARN) to use as the primary cluster of the global database. This parameter is optional. This parameter is stored as a lowercase string.
	SourceDBClusterIdentifier pulumi.StringPtrOutput `pulumi:"sourceDBClusterIdentifier"`
	//  The storage encryption setting for the new global database cluster.
	// If you specify the SourceDBClusterIdentifier property, don't specify this property. The value is inherited from the cluster.
	StorageEncrypted pulumi.BoolPtrOutput `pulumi:"storageEncrypted"`
}

// NewGlobalCluster registers a new resource with the given unique name, arguments, and options.
func NewGlobalCluster(ctx *pulumi.Context,
	name string, args *GlobalClusterArgs, opts ...pulumi.ResourceOption) (*GlobalCluster, error) {
	if args == nil {
		args = &GlobalClusterArgs{}
	}

	var resource GlobalCluster
	err := ctx.RegisterResource("aws-native:rds:GlobalCluster", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetGlobalCluster gets an existing GlobalCluster resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetGlobalCluster(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *GlobalClusterState, opts ...pulumi.ResourceOption) (*GlobalCluster, error) {
	var resource GlobalCluster
	err := ctx.ReadResource("aws-native:rds:GlobalCluster", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering GlobalCluster resources.
type globalClusterState struct {
}

type GlobalClusterState struct {
}

func (GlobalClusterState) ElementType() reflect.Type {
	return reflect.TypeOf((*globalClusterState)(nil)).Elem()
}

type globalClusterArgs struct {
	// The deletion protection setting for the new global database. The global database can't be deleted when deletion protection is enabled.
	DeletionProtection *bool `pulumi:"deletionProtection"`
	// The name of the database engine to be used for this DB cluster. Valid Values: aurora (for MySQL 5.6-compatible Aurora), aurora-mysql (for MySQL 5.7-compatible Aurora).
	// If you specify the SourceDBClusterIdentifier property, don't specify this property. The value is inherited from the cluster.
	Engine *GlobalClusterEngine `pulumi:"engine"`
	// The version number of the database engine to use. If you specify the SourceDBClusterIdentifier property, don't specify this property. The value is inherited from the cluster.
	EngineVersion *string `pulumi:"engineVersion"`
	// The cluster identifier of the new global database cluster. This parameter is stored as a lowercase string.
	GlobalClusterIdentifier *string `pulumi:"globalClusterIdentifier"`
	// The Amazon Resource Name (ARN) to use as the primary cluster of the global database. This parameter is optional. This parameter is stored as a lowercase string.
	SourceDBClusterIdentifier *string `pulumi:"sourceDBClusterIdentifier"`
	//  The storage encryption setting for the new global database cluster.
	// If you specify the SourceDBClusterIdentifier property, don't specify this property. The value is inherited from the cluster.
	StorageEncrypted *bool `pulumi:"storageEncrypted"`
}

// The set of arguments for constructing a GlobalCluster resource.
type GlobalClusterArgs struct {
	// The deletion protection setting for the new global database. The global database can't be deleted when deletion protection is enabled.
	DeletionProtection pulumi.BoolPtrInput
	// The name of the database engine to be used for this DB cluster. Valid Values: aurora (for MySQL 5.6-compatible Aurora), aurora-mysql (for MySQL 5.7-compatible Aurora).
	// If you specify the SourceDBClusterIdentifier property, don't specify this property. The value is inherited from the cluster.
	Engine GlobalClusterEnginePtrInput
	// The version number of the database engine to use. If you specify the SourceDBClusterIdentifier property, don't specify this property. The value is inherited from the cluster.
	EngineVersion pulumi.StringPtrInput
	// The cluster identifier of the new global database cluster. This parameter is stored as a lowercase string.
	GlobalClusterIdentifier pulumi.StringPtrInput
	// The Amazon Resource Name (ARN) to use as the primary cluster of the global database. This parameter is optional. This parameter is stored as a lowercase string.
	SourceDBClusterIdentifier pulumi.StringPtrInput
	//  The storage encryption setting for the new global database cluster.
	// If you specify the SourceDBClusterIdentifier property, don't specify this property. The value is inherited from the cluster.
	StorageEncrypted pulumi.BoolPtrInput
}

func (GlobalClusterArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*globalClusterArgs)(nil)).Elem()
}

type GlobalClusterInput interface {
	pulumi.Input

	ToGlobalClusterOutput() GlobalClusterOutput
	ToGlobalClusterOutputWithContext(ctx context.Context) GlobalClusterOutput
}

func (*GlobalCluster) ElementType() reflect.Type {
	return reflect.TypeOf((*GlobalCluster)(nil))
}

func (i *GlobalCluster) ToGlobalClusterOutput() GlobalClusterOutput {
	return i.ToGlobalClusterOutputWithContext(context.Background())
}

func (i *GlobalCluster) ToGlobalClusterOutputWithContext(ctx context.Context) GlobalClusterOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GlobalClusterOutput)
}

type GlobalClusterOutput struct{ *pulumi.OutputState }

func (GlobalClusterOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GlobalCluster)(nil))
}

func (o GlobalClusterOutput) ToGlobalClusterOutput() GlobalClusterOutput {
	return o
}

func (o GlobalClusterOutput) ToGlobalClusterOutputWithContext(ctx context.Context) GlobalClusterOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*GlobalClusterInput)(nil)).Elem(), &GlobalCluster{})
	pulumi.RegisterOutputType(GlobalClusterOutput{})
}
