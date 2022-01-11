// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package dms

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::DMS::ReplicationInstance
//
// Deprecated: ReplicationInstance is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type ReplicationInstance struct {
	pulumi.CustomResourceState

	AllocatedStorage                      pulumi.IntPtrOutput               `pulumi:"allocatedStorage"`
	AllowMajorVersionUpgrade              pulumi.BoolPtrOutput              `pulumi:"allowMajorVersionUpgrade"`
	AutoMinorVersionUpgrade               pulumi.BoolPtrOutput              `pulumi:"autoMinorVersionUpgrade"`
	AvailabilityZone                      pulumi.StringPtrOutput            `pulumi:"availabilityZone"`
	EngineVersion                         pulumi.StringPtrOutput            `pulumi:"engineVersion"`
	KmsKeyId                              pulumi.StringPtrOutput            `pulumi:"kmsKeyId"`
	MultiAZ                               pulumi.BoolPtrOutput              `pulumi:"multiAZ"`
	PreferredMaintenanceWindow            pulumi.StringPtrOutput            `pulumi:"preferredMaintenanceWindow"`
	PubliclyAccessible                    pulumi.BoolPtrOutput              `pulumi:"publiclyAccessible"`
	ReplicationInstanceClass              pulumi.StringOutput               `pulumi:"replicationInstanceClass"`
	ReplicationInstanceIdentifier         pulumi.StringPtrOutput            `pulumi:"replicationInstanceIdentifier"`
	ReplicationInstancePrivateIpAddresses pulumi.StringArrayOutput          `pulumi:"replicationInstancePrivateIpAddresses"`
	ReplicationInstancePublicIpAddresses  pulumi.StringArrayOutput          `pulumi:"replicationInstancePublicIpAddresses"`
	ReplicationSubnetGroupIdentifier      pulumi.StringPtrOutput            `pulumi:"replicationSubnetGroupIdentifier"`
	ResourceIdentifier                    pulumi.StringPtrOutput            `pulumi:"resourceIdentifier"`
	Tags                                  ReplicationInstanceTagArrayOutput `pulumi:"tags"`
	VpcSecurityGroupIds                   pulumi.StringArrayOutput          `pulumi:"vpcSecurityGroupIds"`
}

// NewReplicationInstance registers a new resource with the given unique name, arguments, and options.
func NewReplicationInstance(ctx *pulumi.Context,
	name string, args *ReplicationInstanceArgs, opts ...pulumi.ResourceOption) (*ReplicationInstance, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ReplicationInstanceClass == nil {
		return nil, errors.New("invalid value for required argument 'ReplicationInstanceClass'")
	}
	var resource ReplicationInstance
	err := ctx.RegisterResource("aws-native:dms:ReplicationInstance", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetReplicationInstance gets an existing ReplicationInstance resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetReplicationInstance(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ReplicationInstanceState, opts ...pulumi.ResourceOption) (*ReplicationInstance, error) {
	var resource ReplicationInstance
	err := ctx.ReadResource("aws-native:dms:ReplicationInstance", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ReplicationInstance resources.
type replicationInstanceState struct {
}

type ReplicationInstanceState struct {
}

func (ReplicationInstanceState) ElementType() reflect.Type {
	return reflect.TypeOf((*replicationInstanceState)(nil)).Elem()
}

type replicationInstanceArgs struct {
	AllocatedStorage                 *int                     `pulumi:"allocatedStorage"`
	AllowMajorVersionUpgrade         *bool                    `pulumi:"allowMajorVersionUpgrade"`
	AutoMinorVersionUpgrade          *bool                    `pulumi:"autoMinorVersionUpgrade"`
	AvailabilityZone                 *string                  `pulumi:"availabilityZone"`
	EngineVersion                    *string                  `pulumi:"engineVersion"`
	KmsKeyId                         *string                  `pulumi:"kmsKeyId"`
	MultiAZ                          *bool                    `pulumi:"multiAZ"`
	PreferredMaintenanceWindow       *string                  `pulumi:"preferredMaintenanceWindow"`
	PubliclyAccessible               *bool                    `pulumi:"publiclyAccessible"`
	ReplicationInstanceClass         string                   `pulumi:"replicationInstanceClass"`
	ReplicationInstanceIdentifier    *string                  `pulumi:"replicationInstanceIdentifier"`
	ReplicationSubnetGroupIdentifier *string                  `pulumi:"replicationSubnetGroupIdentifier"`
	ResourceIdentifier               *string                  `pulumi:"resourceIdentifier"`
	Tags                             []ReplicationInstanceTag `pulumi:"tags"`
	VpcSecurityGroupIds              []string                 `pulumi:"vpcSecurityGroupIds"`
}

// The set of arguments for constructing a ReplicationInstance resource.
type ReplicationInstanceArgs struct {
	AllocatedStorage                 pulumi.IntPtrInput
	AllowMajorVersionUpgrade         pulumi.BoolPtrInput
	AutoMinorVersionUpgrade          pulumi.BoolPtrInput
	AvailabilityZone                 pulumi.StringPtrInput
	EngineVersion                    pulumi.StringPtrInput
	KmsKeyId                         pulumi.StringPtrInput
	MultiAZ                          pulumi.BoolPtrInput
	PreferredMaintenanceWindow       pulumi.StringPtrInput
	PubliclyAccessible               pulumi.BoolPtrInput
	ReplicationInstanceClass         pulumi.StringInput
	ReplicationInstanceIdentifier    pulumi.StringPtrInput
	ReplicationSubnetGroupIdentifier pulumi.StringPtrInput
	ResourceIdentifier               pulumi.StringPtrInput
	Tags                             ReplicationInstanceTagArrayInput
	VpcSecurityGroupIds              pulumi.StringArrayInput
}

func (ReplicationInstanceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*replicationInstanceArgs)(nil)).Elem()
}

type ReplicationInstanceInput interface {
	pulumi.Input

	ToReplicationInstanceOutput() ReplicationInstanceOutput
	ToReplicationInstanceOutputWithContext(ctx context.Context) ReplicationInstanceOutput
}

func (*ReplicationInstance) ElementType() reflect.Type {
	return reflect.TypeOf((*ReplicationInstance)(nil))
}

func (i *ReplicationInstance) ToReplicationInstanceOutput() ReplicationInstanceOutput {
	return i.ToReplicationInstanceOutputWithContext(context.Background())
}

func (i *ReplicationInstance) ToReplicationInstanceOutputWithContext(ctx context.Context) ReplicationInstanceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ReplicationInstanceOutput)
}

type ReplicationInstanceOutput struct{ *pulumi.OutputState }

func (ReplicationInstanceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ReplicationInstance)(nil))
}

func (o ReplicationInstanceOutput) ToReplicationInstanceOutput() ReplicationInstanceOutput {
	return o
}

func (o ReplicationInstanceOutput) ToReplicationInstanceOutputWithContext(ctx context.Context) ReplicationInstanceOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ReplicationInstanceInput)(nil)).Elem(), &ReplicationInstance{})
	pulumi.RegisterOutputType(ReplicationInstanceOutput{})
}
