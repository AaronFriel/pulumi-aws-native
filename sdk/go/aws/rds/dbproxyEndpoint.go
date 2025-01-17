// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package rds

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource schema for AWS::RDS::DBProxyEndpoint.
type DBProxyEndpoint struct {
	pulumi.CustomResourceState

	// The Amazon Resource Name (ARN) for the DB proxy endpoint.
	DBProxyEndpointArn pulumi.StringOutput `pulumi:"dBProxyEndpointArn"`
	// The identifier for the DB proxy endpoint. This name must be unique for all DB proxy endpoints owned by your AWS account in the specified AWS Region.
	DBProxyEndpointName pulumi.StringOutput `pulumi:"dBProxyEndpointName"`
	// The identifier for the proxy. This name must be unique for all proxies owned by your AWS account in the specified AWS Region.
	DBProxyName pulumi.StringOutput `pulumi:"dBProxyName"`
	// The endpoint that you can use to connect to the DB proxy. You include the endpoint value in the connection string for a database client application.
	Endpoint pulumi.StringOutput `pulumi:"endpoint"`
	// A value that indicates whether this endpoint is the default endpoint for the associated DB proxy. Default DB proxy endpoints always have read/write capability. Other endpoints that you associate with the DB proxy can be either read/write or read-only.
	IsDefault pulumi.BoolOutput `pulumi:"isDefault"`
	// An optional set of key-value pairs to associate arbitrary data of your choosing with the DB proxy endpoint.
	Tags DBProxyEndpointTagFormatArrayOutput `pulumi:"tags"`
	// A value that indicates whether the DB proxy endpoint can be used for read/write or read-only operations.
	TargetRole DBProxyEndpointTargetRolePtrOutput `pulumi:"targetRole"`
	// VPC ID to associate with the new DB proxy endpoint.
	VpcId pulumi.StringOutput `pulumi:"vpcId"`
	// VPC security group IDs to associate with the new DB proxy endpoint.
	VpcSecurityGroupIds pulumi.StringArrayOutput `pulumi:"vpcSecurityGroupIds"`
	// VPC subnet IDs to associate with the new DB proxy endpoint.
	VpcSubnetIds pulumi.StringArrayOutput `pulumi:"vpcSubnetIds"`
}

// NewDBProxyEndpoint registers a new resource with the given unique name, arguments, and options.
func NewDBProxyEndpoint(ctx *pulumi.Context,
	name string, args *DBProxyEndpointArgs, opts ...pulumi.ResourceOption) (*DBProxyEndpoint, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DBProxyName == nil {
		return nil, errors.New("invalid value for required argument 'DBProxyName'")
	}
	if args.VpcSubnetIds == nil {
		return nil, errors.New("invalid value for required argument 'VpcSubnetIds'")
	}
	var resource DBProxyEndpoint
	err := ctx.RegisterResource("aws-native:rds:DBProxyEndpoint", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDBProxyEndpoint gets an existing DBProxyEndpoint resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDBProxyEndpoint(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DBProxyEndpointState, opts ...pulumi.ResourceOption) (*DBProxyEndpoint, error) {
	var resource DBProxyEndpoint
	err := ctx.ReadResource("aws-native:rds:DBProxyEndpoint", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DBProxyEndpoint resources.
type dbproxyEndpointState struct {
}

type DBProxyEndpointState struct {
}

func (DBProxyEndpointState) ElementType() reflect.Type {
	return reflect.TypeOf((*dbproxyEndpointState)(nil)).Elem()
}

type dbproxyEndpointArgs struct {
	// The identifier for the DB proxy endpoint. This name must be unique for all DB proxy endpoints owned by your AWS account in the specified AWS Region.
	DBProxyEndpointName *string `pulumi:"dBProxyEndpointName"`
	// The identifier for the proxy. This name must be unique for all proxies owned by your AWS account in the specified AWS Region.
	DBProxyName string `pulumi:"dBProxyName"`
	// An optional set of key-value pairs to associate arbitrary data of your choosing with the DB proxy endpoint.
	Tags []DBProxyEndpointTagFormat `pulumi:"tags"`
	// A value that indicates whether the DB proxy endpoint can be used for read/write or read-only operations.
	TargetRole *DBProxyEndpointTargetRole `pulumi:"targetRole"`
	// VPC security group IDs to associate with the new DB proxy endpoint.
	VpcSecurityGroupIds []string `pulumi:"vpcSecurityGroupIds"`
	// VPC subnet IDs to associate with the new DB proxy endpoint.
	VpcSubnetIds []string `pulumi:"vpcSubnetIds"`
}

// The set of arguments for constructing a DBProxyEndpoint resource.
type DBProxyEndpointArgs struct {
	// The identifier for the DB proxy endpoint. This name must be unique for all DB proxy endpoints owned by your AWS account in the specified AWS Region.
	DBProxyEndpointName pulumi.StringPtrInput
	// The identifier for the proxy. This name must be unique for all proxies owned by your AWS account in the specified AWS Region.
	DBProxyName pulumi.StringInput
	// An optional set of key-value pairs to associate arbitrary data of your choosing with the DB proxy endpoint.
	Tags DBProxyEndpointTagFormatArrayInput
	// A value that indicates whether the DB proxy endpoint can be used for read/write or read-only operations.
	TargetRole DBProxyEndpointTargetRolePtrInput
	// VPC security group IDs to associate with the new DB proxy endpoint.
	VpcSecurityGroupIds pulumi.StringArrayInput
	// VPC subnet IDs to associate with the new DB proxy endpoint.
	VpcSubnetIds pulumi.StringArrayInput
}

func (DBProxyEndpointArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*dbproxyEndpointArgs)(nil)).Elem()
}

type DBProxyEndpointInput interface {
	pulumi.Input

	ToDBProxyEndpointOutput() DBProxyEndpointOutput
	ToDBProxyEndpointOutputWithContext(ctx context.Context) DBProxyEndpointOutput
}

func (*DBProxyEndpoint) ElementType() reflect.Type {
	return reflect.TypeOf((*DBProxyEndpoint)(nil))
}

func (i *DBProxyEndpoint) ToDBProxyEndpointOutput() DBProxyEndpointOutput {
	return i.ToDBProxyEndpointOutputWithContext(context.Background())
}

func (i *DBProxyEndpoint) ToDBProxyEndpointOutputWithContext(ctx context.Context) DBProxyEndpointOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DBProxyEndpointOutput)
}

type DBProxyEndpointOutput struct{ *pulumi.OutputState }

func (DBProxyEndpointOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*DBProxyEndpoint)(nil))
}

func (o DBProxyEndpointOutput) ToDBProxyEndpointOutput() DBProxyEndpointOutput {
	return o
}

func (o DBProxyEndpointOutput) ToDBProxyEndpointOutputWithContext(ctx context.Context) DBProxyEndpointOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*DBProxyEndpointInput)(nil)).Elem(), &DBProxyEndpoint{})
	pulumi.RegisterOutputType(DBProxyEndpointOutput{})
}
