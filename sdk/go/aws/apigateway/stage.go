// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package apigateway

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::ApiGateway::Stage
//
// Deprecated: Stage is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.
type Stage struct {
	pulumi.CustomResourceState

	AccessLogSetting     StageAccessLogSettingPtrOutput `pulumi:"accessLogSetting"`
	CacheClusterEnabled  pulumi.BoolPtrOutput           `pulumi:"cacheClusterEnabled"`
	CacheClusterSize     pulumi.StringPtrOutput         `pulumi:"cacheClusterSize"`
	CanarySetting        StageCanarySettingPtrOutput    `pulumi:"canarySetting"`
	ClientCertificateId  pulumi.StringPtrOutput         `pulumi:"clientCertificateId"`
	DeploymentId         pulumi.StringPtrOutput         `pulumi:"deploymentId"`
	Description          pulumi.StringPtrOutput         `pulumi:"description"`
	DocumentationVersion pulumi.StringPtrOutput         `pulumi:"documentationVersion"`
	MethodSettings       StageMethodSettingArrayOutput  `pulumi:"methodSettings"`
	RestApiId            pulumi.StringOutput            `pulumi:"restApiId"`
	StageName            pulumi.StringPtrOutput         `pulumi:"stageName"`
	Tags                 StageTagArrayOutput            `pulumi:"tags"`
	TracingEnabled       pulumi.BoolPtrOutput           `pulumi:"tracingEnabled"`
	Variables            pulumi.AnyOutput               `pulumi:"variables"`
}

// NewStage registers a new resource with the given unique name, arguments, and options.
func NewStage(ctx *pulumi.Context,
	name string, args *StageArgs, opts ...pulumi.ResourceOption) (*Stage, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.RestApiId == nil {
		return nil, errors.New("invalid value for required argument 'RestApiId'")
	}
	var resource Stage
	err := ctx.RegisterResource("aws-native:apigateway:Stage", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetStage gets an existing Stage resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetStage(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *StageState, opts ...pulumi.ResourceOption) (*Stage, error) {
	var resource Stage
	err := ctx.ReadResource("aws-native:apigateway:Stage", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Stage resources.
type stageState struct {
}

type StageState struct {
}

func (StageState) ElementType() reflect.Type {
	return reflect.TypeOf((*stageState)(nil)).Elem()
}

type stageArgs struct {
	AccessLogSetting     *StageAccessLogSetting `pulumi:"accessLogSetting"`
	CacheClusterEnabled  *bool                  `pulumi:"cacheClusterEnabled"`
	CacheClusterSize     *string                `pulumi:"cacheClusterSize"`
	CanarySetting        *StageCanarySetting    `pulumi:"canarySetting"`
	ClientCertificateId  *string                `pulumi:"clientCertificateId"`
	DeploymentId         *string                `pulumi:"deploymentId"`
	Description          *string                `pulumi:"description"`
	DocumentationVersion *string                `pulumi:"documentationVersion"`
	MethodSettings       []StageMethodSetting   `pulumi:"methodSettings"`
	RestApiId            string                 `pulumi:"restApiId"`
	StageName            *string                `pulumi:"stageName"`
	Tags                 []StageTag             `pulumi:"tags"`
	TracingEnabled       *bool                  `pulumi:"tracingEnabled"`
	Variables            interface{}            `pulumi:"variables"`
}

// The set of arguments for constructing a Stage resource.
type StageArgs struct {
	AccessLogSetting     StageAccessLogSettingPtrInput
	CacheClusterEnabled  pulumi.BoolPtrInput
	CacheClusterSize     pulumi.StringPtrInput
	CanarySetting        StageCanarySettingPtrInput
	ClientCertificateId  pulumi.StringPtrInput
	DeploymentId         pulumi.StringPtrInput
	Description          pulumi.StringPtrInput
	DocumentationVersion pulumi.StringPtrInput
	MethodSettings       StageMethodSettingArrayInput
	RestApiId            pulumi.StringInput
	StageName            pulumi.StringPtrInput
	Tags                 StageTagArrayInput
	TracingEnabled       pulumi.BoolPtrInput
	Variables            pulumi.Input
}

func (StageArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*stageArgs)(nil)).Elem()
}

type StageInput interface {
	pulumi.Input

	ToStageOutput() StageOutput
	ToStageOutputWithContext(ctx context.Context) StageOutput
}

func (*Stage) ElementType() reflect.Type {
	return reflect.TypeOf((*Stage)(nil))
}

func (i *Stage) ToStageOutput() StageOutput {
	return i.ToStageOutputWithContext(context.Background())
}

func (i *Stage) ToStageOutputWithContext(ctx context.Context) StageOutput {
	return pulumi.ToOutputWithContext(ctx, i).(StageOutput)
}

type StageOutput struct{ *pulumi.OutputState }

func (StageOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Stage)(nil))
}

func (o StageOutput) ToStageOutput() StageOutput {
	return o
}

func (o StageOutput) ToStageOutputWithContext(ctx context.Context) StageOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(StageOutput{})
}