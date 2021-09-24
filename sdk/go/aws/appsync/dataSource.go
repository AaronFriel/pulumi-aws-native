// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package appsync

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::AppSync::DataSource
//
// Deprecated: DataSource is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type DataSource struct {
	pulumi.CustomResourceState

	ApiId                    pulumi.StringOutput                         `pulumi:"apiId"`
	DataSourceArn            pulumi.StringOutput                         `pulumi:"dataSourceArn"`
	Description              pulumi.StringPtrOutput                      `pulumi:"description"`
	DynamoDBConfig           DataSourceDynamoDBConfigPtrOutput           `pulumi:"dynamoDBConfig"`
	ElasticsearchConfig      DataSourceElasticsearchConfigPtrOutput      `pulumi:"elasticsearchConfig"`
	HttpConfig               DataSourceHttpConfigPtrOutput               `pulumi:"httpConfig"`
	LambdaConfig             DataSourceLambdaConfigPtrOutput             `pulumi:"lambdaConfig"`
	Name                     pulumi.StringOutput                         `pulumi:"name"`
	RelationalDatabaseConfig DataSourceRelationalDatabaseConfigPtrOutput `pulumi:"relationalDatabaseConfig"`
	ServiceRoleArn           pulumi.StringPtrOutput                      `pulumi:"serviceRoleArn"`
	Type                     pulumi.StringOutput                         `pulumi:"type"`
}

// NewDataSource registers a new resource with the given unique name, arguments, and options.
func NewDataSource(ctx *pulumi.Context,
	name string, args *DataSourceArgs, opts ...pulumi.ResourceOption) (*DataSource, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ApiId == nil {
		return nil, errors.New("invalid value for required argument 'ApiId'")
	}
	if args.Name == nil {
		return nil, errors.New("invalid value for required argument 'Name'")
	}
	if args.Type == nil {
		return nil, errors.New("invalid value for required argument 'Type'")
	}
	var resource DataSource
	err := ctx.RegisterResource("aws-native:appsync:DataSource", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDataSource gets an existing DataSource resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDataSource(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DataSourceState, opts ...pulumi.ResourceOption) (*DataSource, error) {
	var resource DataSource
	err := ctx.ReadResource("aws-native:appsync:DataSource", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DataSource resources.
type dataSourceState struct {
}

type DataSourceState struct {
}

func (DataSourceState) ElementType() reflect.Type {
	return reflect.TypeOf((*dataSourceState)(nil)).Elem()
}

type dataSourceArgs struct {
	ApiId                    string                              `pulumi:"apiId"`
	Description              *string                             `pulumi:"description"`
	DynamoDBConfig           *DataSourceDynamoDBConfig           `pulumi:"dynamoDBConfig"`
	ElasticsearchConfig      *DataSourceElasticsearchConfig      `pulumi:"elasticsearchConfig"`
	HttpConfig               *DataSourceHttpConfig               `pulumi:"httpConfig"`
	LambdaConfig             *DataSourceLambdaConfig             `pulumi:"lambdaConfig"`
	Name                     string                              `pulumi:"name"`
	RelationalDatabaseConfig *DataSourceRelationalDatabaseConfig `pulumi:"relationalDatabaseConfig"`
	ServiceRoleArn           *string                             `pulumi:"serviceRoleArn"`
	Type                     string                              `pulumi:"type"`
}

// The set of arguments for constructing a DataSource resource.
type DataSourceArgs struct {
	ApiId                    pulumi.StringInput
	Description              pulumi.StringPtrInput
	DynamoDBConfig           DataSourceDynamoDBConfigPtrInput
	ElasticsearchConfig      DataSourceElasticsearchConfigPtrInput
	HttpConfig               DataSourceHttpConfigPtrInput
	LambdaConfig             DataSourceLambdaConfigPtrInput
	Name                     pulumi.StringInput
	RelationalDatabaseConfig DataSourceRelationalDatabaseConfigPtrInput
	ServiceRoleArn           pulumi.StringPtrInput
	Type                     pulumi.StringInput
}

func (DataSourceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*dataSourceArgs)(nil)).Elem()
}

type DataSourceInput interface {
	pulumi.Input

	ToDataSourceOutput() DataSourceOutput
	ToDataSourceOutputWithContext(ctx context.Context) DataSourceOutput
}

func (*DataSource) ElementType() reflect.Type {
	return reflect.TypeOf((*DataSource)(nil))
}

func (i *DataSource) ToDataSourceOutput() DataSourceOutput {
	return i.ToDataSourceOutputWithContext(context.Background())
}

func (i *DataSource) ToDataSourceOutputWithContext(ctx context.Context) DataSourceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DataSourceOutput)
}

type DataSourceOutput struct{ *pulumi.OutputState }

func (DataSourceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*DataSource)(nil))
}

func (o DataSourceOutput) ToDataSourceOutput() DataSourceOutput {
	return o
}

func (o DataSourceOutput) ToDataSourceOutputWithContext(ctx context.Context) DataSourceOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(DataSourceOutput{})
}
