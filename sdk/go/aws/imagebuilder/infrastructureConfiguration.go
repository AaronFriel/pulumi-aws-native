// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package imagebuilder

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource schema for AWS::ImageBuilder::InfrastructureConfiguration
type InfrastructureConfiguration struct {
	pulumi.CustomResourceState

	// The Amazon Resource Name (ARN) of the infrastructure configuration.
	Arn pulumi.StringOutput `pulumi:"arn"`
	// The description of the infrastructure configuration.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The instance profile of the infrastructure configuration.
	InstanceProfileName pulumi.StringOutput `pulumi:"instanceProfileName"`
	// The instance types of the infrastructure configuration.
	InstanceTypes pulumi.StringArrayOutput `pulumi:"instanceTypes"`
	// The EC2 key pair of the infrastructure configuration..
	KeyPair pulumi.StringPtrOutput `pulumi:"keyPair"`
	// The logging configuration of the infrastructure configuration.
	Logging InfrastructureConfigurationLoggingPtrOutput `pulumi:"logging"`
	// The name of the infrastructure configuration.
	Name pulumi.StringOutput `pulumi:"name"`
	// The tags attached to the resource created by Image Builder.
	ResourceTags pulumi.AnyOutput `pulumi:"resourceTags"`
	// The security group IDs of the infrastructure configuration.
	SecurityGroupIds pulumi.StringArrayOutput `pulumi:"securityGroupIds"`
	// The SNS Topic Amazon Resource Name (ARN) of the infrastructure configuration.
	SnsTopicArn pulumi.StringPtrOutput `pulumi:"snsTopicArn"`
	// The subnet ID of the infrastructure configuration.
	SubnetId pulumi.StringPtrOutput `pulumi:"subnetId"`
	// The tags associated with the component.
	Tags pulumi.AnyOutput `pulumi:"tags"`
	// The terminate instance on failure configuration of the infrastructure configuration.
	TerminateInstanceOnFailure pulumi.BoolPtrOutput `pulumi:"terminateInstanceOnFailure"`
}

// NewInfrastructureConfiguration registers a new resource with the given unique name, arguments, and options.
func NewInfrastructureConfiguration(ctx *pulumi.Context,
	name string, args *InfrastructureConfigurationArgs, opts ...pulumi.ResourceOption) (*InfrastructureConfiguration, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.InstanceProfileName == nil {
		return nil, errors.New("invalid value for required argument 'InstanceProfileName'")
	}
	if args.Name == nil {
		return nil, errors.New("invalid value for required argument 'Name'")
	}
	var resource InfrastructureConfiguration
	err := ctx.RegisterResource("aws-native:imagebuilder:InfrastructureConfiguration", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetInfrastructureConfiguration gets an existing InfrastructureConfiguration resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetInfrastructureConfiguration(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *InfrastructureConfigurationState, opts ...pulumi.ResourceOption) (*InfrastructureConfiguration, error) {
	var resource InfrastructureConfiguration
	err := ctx.ReadResource("aws-native:imagebuilder:InfrastructureConfiguration", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering InfrastructureConfiguration resources.
type infrastructureConfigurationState struct {
}

type InfrastructureConfigurationState struct {
}

func (InfrastructureConfigurationState) ElementType() reflect.Type {
	return reflect.TypeOf((*infrastructureConfigurationState)(nil)).Elem()
}

type infrastructureConfigurationArgs struct {
	// The description of the infrastructure configuration.
	Description *string `pulumi:"description"`
	// The instance profile of the infrastructure configuration.
	InstanceProfileName string `pulumi:"instanceProfileName"`
	// The instance types of the infrastructure configuration.
	InstanceTypes []string `pulumi:"instanceTypes"`
	// The EC2 key pair of the infrastructure configuration..
	KeyPair *string `pulumi:"keyPair"`
	// The logging configuration of the infrastructure configuration.
	Logging *InfrastructureConfigurationLogging `pulumi:"logging"`
	// The name of the infrastructure configuration.
	Name string `pulumi:"name"`
	// The tags attached to the resource created by Image Builder.
	ResourceTags interface{} `pulumi:"resourceTags"`
	// The security group IDs of the infrastructure configuration.
	SecurityGroupIds []string `pulumi:"securityGroupIds"`
	// The SNS Topic Amazon Resource Name (ARN) of the infrastructure configuration.
	SnsTopicArn *string `pulumi:"snsTopicArn"`
	// The subnet ID of the infrastructure configuration.
	SubnetId *string `pulumi:"subnetId"`
	// The tags associated with the component.
	Tags interface{} `pulumi:"tags"`
	// The terminate instance on failure configuration of the infrastructure configuration.
	TerminateInstanceOnFailure *bool `pulumi:"terminateInstanceOnFailure"`
}

// The set of arguments for constructing a InfrastructureConfiguration resource.
type InfrastructureConfigurationArgs struct {
	// The description of the infrastructure configuration.
	Description pulumi.StringPtrInput
	// The instance profile of the infrastructure configuration.
	InstanceProfileName pulumi.StringInput
	// The instance types of the infrastructure configuration.
	InstanceTypes pulumi.StringArrayInput
	// The EC2 key pair of the infrastructure configuration..
	KeyPair pulumi.StringPtrInput
	// The logging configuration of the infrastructure configuration.
	Logging InfrastructureConfigurationLoggingPtrInput
	// The name of the infrastructure configuration.
	Name pulumi.StringInput
	// The tags attached to the resource created by Image Builder.
	ResourceTags pulumi.Input
	// The security group IDs of the infrastructure configuration.
	SecurityGroupIds pulumi.StringArrayInput
	// The SNS Topic Amazon Resource Name (ARN) of the infrastructure configuration.
	SnsTopicArn pulumi.StringPtrInput
	// The subnet ID of the infrastructure configuration.
	SubnetId pulumi.StringPtrInput
	// The tags associated with the component.
	Tags pulumi.Input
	// The terminate instance on failure configuration of the infrastructure configuration.
	TerminateInstanceOnFailure pulumi.BoolPtrInput
}

func (InfrastructureConfigurationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*infrastructureConfigurationArgs)(nil)).Elem()
}

type InfrastructureConfigurationInput interface {
	pulumi.Input

	ToInfrastructureConfigurationOutput() InfrastructureConfigurationOutput
	ToInfrastructureConfigurationOutputWithContext(ctx context.Context) InfrastructureConfigurationOutput
}

func (*InfrastructureConfiguration) ElementType() reflect.Type {
	return reflect.TypeOf((*InfrastructureConfiguration)(nil))
}

func (i *InfrastructureConfiguration) ToInfrastructureConfigurationOutput() InfrastructureConfigurationOutput {
	return i.ToInfrastructureConfigurationOutputWithContext(context.Background())
}

func (i *InfrastructureConfiguration) ToInfrastructureConfigurationOutputWithContext(ctx context.Context) InfrastructureConfigurationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(InfrastructureConfigurationOutput)
}

type InfrastructureConfigurationOutput struct{ *pulumi.OutputState }

func (InfrastructureConfigurationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*InfrastructureConfiguration)(nil))
}

func (o InfrastructureConfigurationOutput) ToInfrastructureConfigurationOutput() InfrastructureConfigurationOutput {
	return o
}

func (o InfrastructureConfigurationOutput) ToInfrastructureConfigurationOutputWithContext(ctx context.Context) InfrastructureConfigurationOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(InfrastructureConfigurationOutput{})
}
