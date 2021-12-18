// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package mwaa

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource schema for AWS::MWAA::Environment
type Environment struct {
	pulumi.CustomResourceState

	// Key/value pairs representing Airflow configuration variables.
	//     Keys are prefixed by their section:
	//
	//     [core]
	//     dags_folder={AIRFLOW_HOME}/dags
	//
	//     Would be represented as
	//
	//     "core.dags_folder": "{AIRFLOW_HOME}/dags"
	AirflowConfigurationOptions pulumi.AnyOutput                         `pulumi:"airflowConfigurationOptions"`
	AirflowVersion              pulumi.StringPtrOutput                   `pulumi:"airflowVersion"`
	Arn                         pulumi.StringOutput                      `pulumi:"arn"`
	DagS3Path                   pulumi.StringPtrOutput                   `pulumi:"dagS3Path"`
	EnvironmentClass            pulumi.StringPtrOutput                   `pulumi:"environmentClass"`
	ExecutionRoleArn            pulumi.StringPtrOutput                   `pulumi:"executionRoleArn"`
	KmsKey                      pulumi.StringPtrOutput                   `pulumi:"kmsKey"`
	LoggingConfiguration        EnvironmentLoggingConfigurationPtrOutput `pulumi:"loggingConfiguration"`
	MaxWorkers                  pulumi.IntPtrOutput                      `pulumi:"maxWorkers"`
	MinWorkers                  pulumi.IntPtrOutput                      `pulumi:"minWorkers"`
	Name                        pulumi.StringOutput                      `pulumi:"name"`
	NetworkConfiguration        EnvironmentNetworkConfigurationPtrOutput `pulumi:"networkConfiguration"`
	PluginsS3ObjectVersion      pulumi.StringPtrOutput                   `pulumi:"pluginsS3ObjectVersion"`
	PluginsS3Path               pulumi.StringPtrOutput                   `pulumi:"pluginsS3Path"`
	RequirementsS3ObjectVersion pulumi.StringPtrOutput                   `pulumi:"requirementsS3ObjectVersion"`
	RequirementsS3Path          pulumi.StringPtrOutput                   `pulumi:"requirementsS3Path"`
	Schedulers                  pulumi.IntPtrOutput                      `pulumi:"schedulers"`
	SourceBucketArn             pulumi.StringPtrOutput                   `pulumi:"sourceBucketArn"`
	// A map of tags for the environment.
	Tags                         pulumi.AnyOutput                        `pulumi:"tags"`
	WebserverAccessMode          EnvironmentWebserverAccessModePtrOutput `pulumi:"webserverAccessMode"`
	WebserverUrl                 pulumi.StringOutput                     `pulumi:"webserverUrl"`
	WeeklyMaintenanceWindowStart pulumi.StringPtrOutput                  `pulumi:"weeklyMaintenanceWindowStart"`
}

// NewEnvironment registers a new resource with the given unique name, arguments, and options.
func NewEnvironment(ctx *pulumi.Context,
	name string, args *EnvironmentArgs, opts ...pulumi.ResourceOption) (*Environment, error) {
	if args == nil {
		args = &EnvironmentArgs{}
	}

	var resource Environment
	err := ctx.RegisterResource("aws-native:mwaa:Environment", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetEnvironment gets an existing Environment resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetEnvironment(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *EnvironmentState, opts ...pulumi.ResourceOption) (*Environment, error) {
	var resource Environment
	err := ctx.ReadResource("aws-native:mwaa:Environment", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Environment resources.
type environmentState struct {
}

type EnvironmentState struct {
}

func (EnvironmentState) ElementType() reflect.Type {
	return reflect.TypeOf((*environmentState)(nil)).Elem()
}

type environmentArgs struct {
	// Key/value pairs representing Airflow configuration variables.
	//     Keys are prefixed by their section:
	//
	//     [core]
	//     dags_folder={AIRFLOW_HOME}/dags
	//
	//     Would be represented as
	//
	//     "core.dags_folder": "{AIRFLOW_HOME}/dags"
	AirflowConfigurationOptions interface{}                      `pulumi:"airflowConfigurationOptions"`
	AirflowVersion              *string                          `pulumi:"airflowVersion"`
	DagS3Path                   *string                          `pulumi:"dagS3Path"`
	EnvironmentClass            *string                          `pulumi:"environmentClass"`
	ExecutionRoleArn            *string                          `pulumi:"executionRoleArn"`
	KmsKey                      *string                          `pulumi:"kmsKey"`
	LoggingConfiguration        *EnvironmentLoggingConfiguration `pulumi:"loggingConfiguration"`
	MaxWorkers                  *int                             `pulumi:"maxWorkers"`
	MinWorkers                  *int                             `pulumi:"minWorkers"`
	Name                        *string                          `pulumi:"name"`
	NetworkConfiguration        *EnvironmentNetworkConfiguration `pulumi:"networkConfiguration"`
	PluginsS3ObjectVersion      *string                          `pulumi:"pluginsS3ObjectVersion"`
	PluginsS3Path               *string                          `pulumi:"pluginsS3Path"`
	RequirementsS3ObjectVersion *string                          `pulumi:"requirementsS3ObjectVersion"`
	RequirementsS3Path          *string                          `pulumi:"requirementsS3Path"`
	Schedulers                  *int                             `pulumi:"schedulers"`
	SourceBucketArn             *string                          `pulumi:"sourceBucketArn"`
	// A map of tags for the environment.
	Tags                         interface{}                     `pulumi:"tags"`
	WebserverAccessMode          *EnvironmentWebserverAccessMode `pulumi:"webserverAccessMode"`
	WeeklyMaintenanceWindowStart *string                         `pulumi:"weeklyMaintenanceWindowStart"`
}

// The set of arguments for constructing a Environment resource.
type EnvironmentArgs struct {
	// Key/value pairs representing Airflow configuration variables.
	//     Keys are prefixed by their section:
	//
	//     [core]
	//     dags_folder={AIRFLOW_HOME}/dags
	//
	//     Would be represented as
	//
	//     "core.dags_folder": "{AIRFLOW_HOME}/dags"
	AirflowConfigurationOptions pulumi.Input
	AirflowVersion              pulumi.StringPtrInput
	DagS3Path                   pulumi.StringPtrInput
	EnvironmentClass            pulumi.StringPtrInput
	ExecutionRoleArn            pulumi.StringPtrInput
	KmsKey                      pulumi.StringPtrInput
	LoggingConfiguration        EnvironmentLoggingConfigurationPtrInput
	MaxWorkers                  pulumi.IntPtrInput
	MinWorkers                  pulumi.IntPtrInput
	Name                        pulumi.StringPtrInput
	NetworkConfiguration        EnvironmentNetworkConfigurationPtrInput
	PluginsS3ObjectVersion      pulumi.StringPtrInput
	PluginsS3Path               pulumi.StringPtrInput
	RequirementsS3ObjectVersion pulumi.StringPtrInput
	RequirementsS3Path          pulumi.StringPtrInput
	Schedulers                  pulumi.IntPtrInput
	SourceBucketArn             pulumi.StringPtrInput
	// A map of tags for the environment.
	Tags                         pulumi.Input
	WebserverAccessMode          EnvironmentWebserverAccessModePtrInput
	WeeklyMaintenanceWindowStart pulumi.StringPtrInput
}

func (EnvironmentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*environmentArgs)(nil)).Elem()
}

type EnvironmentInput interface {
	pulumi.Input

	ToEnvironmentOutput() EnvironmentOutput
	ToEnvironmentOutputWithContext(ctx context.Context) EnvironmentOutput
}

func (*Environment) ElementType() reflect.Type {
	return reflect.TypeOf((*Environment)(nil))
}

func (i *Environment) ToEnvironmentOutput() EnvironmentOutput {
	return i.ToEnvironmentOutputWithContext(context.Background())
}

func (i *Environment) ToEnvironmentOutputWithContext(ctx context.Context) EnvironmentOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EnvironmentOutput)
}

type EnvironmentOutput struct{ *pulumi.OutputState }

func (EnvironmentOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Environment)(nil))
}

func (o EnvironmentOutput) ToEnvironmentOutput() EnvironmentOutput {
	return o
}

func (o EnvironmentOutput) ToEnvironmentOutputWithContext(ctx context.Context) EnvironmentOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*EnvironmentInput)(nil)).Elem(), &Environment{})
	pulumi.RegisterOutputType(EnvironmentOutput{})
}
