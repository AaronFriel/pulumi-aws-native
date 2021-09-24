// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package rds

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::RDS::DBCluster
//
// Deprecated: DBCluster is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type DBCluster struct {
	pulumi.CustomResourceState

	AssociatedRoles                 DBClusterDBClusterRoleArrayOutput      `pulumi:"associatedRoles"`
	AvailabilityZones               pulumi.StringArrayOutput               `pulumi:"availabilityZones"`
	BacktrackWindow                 pulumi.IntPtrOutput                    `pulumi:"backtrackWindow"`
	BackupRetentionPeriod           pulumi.IntPtrOutput                    `pulumi:"backupRetentionPeriod"`
	CopyTagsToSnapshot              pulumi.BoolPtrOutput                   `pulumi:"copyTagsToSnapshot"`
	DBClusterIdentifier             pulumi.StringPtrOutput                 `pulumi:"dBClusterIdentifier"`
	DBClusterParameterGroupName     pulumi.StringPtrOutput                 `pulumi:"dBClusterParameterGroupName"`
	DBSubnetGroupName               pulumi.StringPtrOutput                 `pulumi:"dBSubnetGroupName"`
	DatabaseName                    pulumi.StringPtrOutput                 `pulumi:"databaseName"`
	DeletionProtection              pulumi.BoolPtrOutput                   `pulumi:"deletionProtection"`
	EnableCloudwatchLogsExports     pulumi.StringArrayOutput               `pulumi:"enableCloudwatchLogsExports"`
	EnableHttpEndpoint              pulumi.BoolPtrOutput                   `pulumi:"enableHttpEndpoint"`
	EnableIAMDatabaseAuthentication pulumi.BoolPtrOutput                   `pulumi:"enableIAMDatabaseAuthentication"`
	EndpointAddress                 pulumi.StringPtrOutput                 `pulumi:"endpointAddress"`
	EndpointPort                    pulumi.StringPtrOutput                 `pulumi:"endpointPort"`
	Engine                          pulumi.StringOutput                    `pulumi:"engine"`
	EngineMode                      pulumi.StringPtrOutput                 `pulumi:"engineMode"`
	EngineVersion                   pulumi.StringPtrOutput                 `pulumi:"engineVersion"`
	GlobalClusterIdentifier         pulumi.StringPtrOutput                 `pulumi:"globalClusterIdentifier"`
	KmsKeyId                        pulumi.StringPtrOutput                 `pulumi:"kmsKeyId"`
	MasterUserPassword              pulumi.StringPtrOutput                 `pulumi:"masterUserPassword"`
	MasterUsername                  pulumi.StringPtrOutput                 `pulumi:"masterUsername"`
	Port                            pulumi.IntPtrOutput                    `pulumi:"port"`
	PreferredBackupWindow           pulumi.StringPtrOutput                 `pulumi:"preferredBackupWindow"`
	PreferredMaintenanceWindow      pulumi.StringPtrOutput                 `pulumi:"preferredMaintenanceWindow"`
	ReadEndpointAddress             pulumi.StringPtrOutput                 `pulumi:"readEndpointAddress"`
	ReplicationSourceIdentifier     pulumi.StringPtrOutput                 `pulumi:"replicationSourceIdentifier"`
	RestoreType                     pulumi.StringPtrOutput                 `pulumi:"restoreType"`
	ScalingConfiguration            DBClusterScalingConfigurationPtrOutput `pulumi:"scalingConfiguration"`
	SnapshotIdentifier              pulumi.StringPtrOutput                 `pulumi:"snapshotIdentifier"`
	SourceDBClusterIdentifier       pulumi.StringPtrOutput                 `pulumi:"sourceDBClusterIdentifier"`
	SourceRegion                    pulumi.StringPtrOutput                 `pulumi:"sourceRegion"`
	StorageEncrypted                pulumi.BoolPtrOutput                   `pulumi:"storageEncrypted"`
	Tags                            DBClusterTagArrayOutput                `pulumi:"tags"`
	UseLatestRestorableTime         pulumi.BoolPtrOutput                   `pulumi:"useLatestRestorableTime"`
	VpcSecurityGroupIds             pulumi.StringArrayOutput               `pulumi:"vpcSecurityGroupIds"`
}

// NewDBCluster registers a new resource with the given unique name, arguments, and options.
func NewDBCluster(ctx *pulumi.Context,
	name string, args *DBClusterArgs, opts ...pulumi.ResourceOption) (*DBCluster, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Engine == nil {
		return nil, errors.New("invalid value for required argument 'Engine'")
	}
	var resource DBCluster
	err := ctx.RegisterResource("aws-native:rds:DBCluster", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDBCluster gets an existing DBCluster resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDBCluster(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DBClusterState, opts ...pulumi.ResourceOption) (*DBCluster, error) {
	var resource DBCluster
	err := ctx.ReadResource("aws-native:rds:DBCluster", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DBCluster resources.
type dbclusterState struct {
}

type DBClusterState struct {
}

func (DBClusterState) ElementType() reflect.Type {
	return reflect.TypeOf((*dbclusterState)(nil)).Elem()
}

type dbclusterArgs struct {
	AssociatedRoles                 []DBClusterDBClusterRole       `pulumi:"associatedRoles"`
	AvailabilityZones               []string                       `pulumi:"availabilityZones"`
	BacktrackWindow                 *int                           `pulumi:"backtrackWindow"`
	BackupRetentionPeriod           *int                           `pulumi:"backupRetentionPeriod"`
	CopyTagsToSnapshot              *bool                          `pulumi:"copyTagsToSnapshot"`
	DBClusterIdentifier             *string                        `pulumi:"dBClusterIdentifier"`
	DBClusterParameterGroupName     *string                        `pulumi:"dBClusterParameterGroupName"`
	DBSubnetGroupName               *string                        `pulumi:"dBSubnetGroupName"`
	DatabaseName                    *string                        `pulumi:"databaseName"`
	DeletionProtection              *bool                          `pulumi:"deletionProtection"`
	EnableCloudwatchLogsExports     []string                       `pulumi:"enableCloudwatchLogsExports"`
	EnableHttpEndpoint              *bool                          `pulumi:"enableHttpEndpoint"`
	EnableIAMDatabaseAuthentication *bool                          `pulumi:"enableIAMDatabaseAuthentication"`
	EndpointAddress                 *string                        `pulumi:"endpointAddress"`
	EndpointPort                    *string                        `pulumi:"endpointPort"`
	Engine                          string                         `pulumi:"engine"`
	EngineMode                      *string                        `pulumi:"engineMode"`
	EngineVersion                   *string                        `pulumi:"engineVersion"`
	GlobalClusterIdentifier         *string                        `pulumi:"globalClusterIdentifier"`
	KmsKeyId                        *string                        `pulumi:"kmsKeyId"`
	MasterUserPassword              *string                        `pulumi:"masterUserPassword"`
	MasterUsername                  *string                        `pulumi:"masterUsername"`
	Port                            *int                           `pulumi:"port"`
	PreferredBackupWindow           *string                        `pulumi:"preferredBackupWindow"`
	PreferredMaintenanceWindow      *string                        `pulumi:"preferredMaintenanceWindow"`
	ReadEndpointAddress             *string                        `pulumi:"readEndpointAddress"`
	ReplicationSourceIdentifier     *string                        `pulumi:"replicationSourceIdentifier"`
	RestoreType                     *string                        `pulumi:"restoreType"`
	ScalingConfiguration            *DBClusterScalingConfiguration `pulumi:"scalingConfiguration"`
	SnapshotIdentifier              *string                        `pulumi:"snapshotIdentifier"`
	SourceDBClusterIdentifier       *string                        `pulumi:"sourceDBClusterIdentifier"`
	SourceRegion                    *string                        `pulumi:"sourceRegion"`
	StorageEncrypted                *bool                          `pulumi:"storageEncrypted"`
	Tags                            []DBClusterTag                 `pulumi:"tags"`
	UseLatestRestorableTime         *bool                          `pulumi:"useLatestRestorableTime"`
	VpcSecurityGroupIds             []string                       `pulumi:"vpcSecurityGroupIds"`
}

// The set of arguments for constructing a DBCluster resource.
type DBClusterArgs struct {
	AssociatedRoles                 DBClusterDBClusterRoleArrayInput
	AvailabilityZones               pulumi.StringArrayInput
	BacktrackWindow                 pulumi.IntPtrInput
	BackupRetentionPeriod           pulumi.IntPtrInput
	CopyTagsToSnapshot              pulumi.BoolPtrInput
	DBClusterIdentifier             pulumi.StringPtrInput
	DBClusterParameterGroupName     pulumi.StringPtrInput
	DBSubnetGroupName               pulumi.StringPtrInput
	DatabaseName                    pulumi.StringPtrInput
	DeletionProtection              pulumi.BoolPtrInput
	EnableCloudwatchLogsExports     pulumi.StringArrayInput
	EnableHttpEndpoint              pulumi.BoolPtrInput
	EnableIAMDatabaseAuthentication pulumi.BoolPtrInput
	EndpointAddress                 pulumi.StringPtrInput
	EndpointPort                    pulumi.StringPtrInput
	Engine                          pulumi.StringInput
	EngineMode                      pulumi.StringPtrInput
	EngineVersion                   pulumi.StringPtrInput
	GlobalClusterIdentifier         pulumi.StringPtrInput
	KmsKeyId                        pulumi.StringPtrInput
	MasterUserPassword              pulumi.StringPtrInput
	MasterUsername                  pulumi.StringPtrInput
	Port                            pulumi.IntPtrInput
	PreferredBackupWindow           pulumi.StringPtrInput
	PreferredMaintenanceWindow      pulumi.StringPtrInput
	ReadEndpointAddress             pulumi.StringPtrInput
	ReplicationSourceIdentifier     pulumi.StringPtrInput
	RestoreType                     pulumi.StringPtrInput
	ScalingConfiguration            DBClusterScalingConfigurationPtrInput
	SnapshotIdentifier              pulumi.StringPtrInput
	SourceDBClusterIdentifier       pulumi.StringPtrInput
	SourceRegion                    pulumi.StringPtrInput
	StorageEncrypted                pulumi.BoolPtrInput
	Tags                            DBClusterTagArrayInput
	UseLatestRestorableTime         pulumi.BoolPtrInput
	VpcSecurityGroupIds             pulumi.StringArrayInput
}

func (DBClusterArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*dbclusterArgs)(nil)).Elem()
}

type DBClusterInput interface {
	pulumi.Input

	ToDBClusterOutput() DBClusterOutput
	ToDBClusterOutputWithContext(ctx context.Context) DBClusterOutput
}

func (*DBCluster) ElementType() reflect.Type {
	return reflect.TypeOf((*DBCluster)(nil))
}

func (i *DBCluster) ToDBClusterOutput() DBClusterOutput {
	return i.ToDBClusterOutputWithContext(context.Background())
}

func (i *DBCluster) ToDBClusterOutputWithContext(ctx context.Context) DBClusterOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DBClusterOutput)
}

type DBClusterOutput struct{ *pulumi.OutputState }

func (DBClusterOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*DBCluster)(nil))
}

func (o DBClusterOutput) ToDBClusterOutput() DBClusterOutput {
	return o
}

func (o DBClusterOutput) ToDBClusterOutputWithContext(ctx context.Context) DBClusterOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(DBClusterOutput{})
}
