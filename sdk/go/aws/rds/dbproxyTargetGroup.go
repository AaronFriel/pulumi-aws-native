// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package rds

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource schema for AWS::RDS::DBProxyTargetGroup
type DBProxyTargetGroup struct {
	pulumi.CustomResourceState

	ConnectionPoolConfigurationInfo DBProxyTargetGroupConnectionPoolConfigurationInfoFormatPtrOutput `pulumi:"connectionPoolConfigurationInfo"`
	DBClusterIdentifiers            pulumi.StringArrayOutput                                         `pulumi:"dBClusterIdentifiers"`
	DBInstanceIdentifiers           pulumi.StringArrayOutput                                         `pulumi:"dBInstanceIdentifiers"`
	// The identifier for the proxy.
	DBProxyName pulumi.StringOutput `pulumi:"dBProxyName"`
	// The Amazon Resource Name (ARN) representing the target group.
	TargetGroupArn pulumi.StringOutput `pulumi:"targetGroupArn"`
	// The identifier for the DBProxyTargetGroup
	TargetGroupName pulumi.StringOutput `pulumi:"targetGroupName"`
}

// NewDBProxyTargetGroup registers a new resource with the given unique name, arguments, and options.
func NewDBProxyTargetGroup(ctx *pulumi.Context,
	name string, args *DBProxyTargetGroupArgs, opts ...pulumi.ResourceOption) (*DBProxyTargetGroup, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DBProxyName == nil {
		return nil, errors.New("invalid value for required argument 'DBProxyName'")
	}
	if args.TargetGroupName == nil {
		return nil, errors.New("invalid value for required argument 'TargetGroupName'")
	}
	var resource DBProxyTargetGroup
	err := ctx.RegisterResource("aws-native:rds:DBProxyTargetGroup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDBProxyTargetGroup gets an existing DBProxyTargetGroup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDBProxyTargetGroup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DBProxyTargetGroupState, opts ...pulumi.ResourceOption) (*DBProxyTargetGroup, error) {
	var resource DBProxyTargetGroup
	err := ctx.ReadResource("aws-native:rds:DBProxyTargetGroup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DBProxyTargetGroup resources.
type dbproxyTargetGroupState struct {
}

type DBProxyTargetGroupState struct {
}

func (DBProxyTargetGroupState) ElementType() reflect.Type {
	return reflect.TypeOf((*dbproxyTargetGroupState)(nil)).Elem()
}

type dbproxyTargetGroupArgs struct {
	ConnectionPoolConfigurationInfo *DBProxyTargetGroupConnectionPoolConfigurationInfoFormat `pulumi:"connectionPoolConfigurationInfo"`
	DBClusterIdentifiers            []string                                                 `pulumi:"dBClusterIdentifiers"`
	DBInstanceIdentifiers           []string                                                 `pulumi:"dBInstanceIdentifiers"`
	// The identifier for the proxy.
	DBProxyName string `pulumi:"dBProxyName"`
	// The identifier for the DBProxyTargetGroup
	TargetGroupName string `pulumi:"targetGroupName"`
}

// The set of arguments for constructing a DBProxyTargetGroup resource.
type DBProxyTargetGroupArgs struct {
	ConnectionPoolConfigurationInfo DBProxyTargetGroupConnectionPoolConfigurationInfoFormatPtrInput
	DBClusterIdentifiers            pulumi.StringArrayInput
	DBInstanceIdentifiers           pulumi.StringArrayInput
	// The identifier for the proxy.
	DBProxyName pulumi.StringInput
	// The identifier for the DBProxyTargetGroup
	TargetGroupName pulumi.StringInput
}

func (DBProxyTargetGroupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*dbproxyTargetGroupArgs)(nil)).Elem()
}

type DBProxyTargetGroupInput interface {
	pulumi.Input

	ToDBProxyTargetGroupOutput() DBProxyTargetGroupOutput
	ToDBProxyTargetGroupOutputWithContext(ctx context.Context) DBProxyTargetGroupOutput
}

func (*DBProxyTargetGroup) ElementType() reflect.Type {
	return reflect.TypeOf((*DBProxyTargetGroup)(nil))
}

func (i *DBProxyTargetGroup) ToDBProxyTargetGroupOutput() DBProxyTargetGroupOutput {
	return i.ToDBProxyTargetGroupOutputWithContext(context.Background())
}

func (i *DBProxyTargetGroup) ToDBProxyTargetGroupOutputWithContext(ctx context.Context) DBProxyTargetGroupOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DBProxyTargetGroupOutput)
}

type DBProxyTargetGroupOutput struct{ *pulumi.OutputState }

func (DBProxyTargetGroupOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*DBProxyTargetGroup)(nil))
}

func (o DBProxyTargetGroupOutput) ToDBProxyTargetGroupOutput() DBProxyTargetGroupOutput {
	return o
}

func (o DBProxyTargetGroupOutput) ToDBProxyTargetGroupOutputWithContext(ctx context.Context) DBProxyTargetGroupOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(DBProxyTargetGroupOutput{})
}
