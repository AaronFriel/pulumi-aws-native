// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package chatbot

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource schema for AWS::Chatbot::SlackChannelConfiguration.
type SlackChannelConfiguration struct {
	pulumi.CustomResourceState

	// Amazon Resource Name (ARN) of the configuration
	Arn pulumi.StringOutput `pulumi:"arn"`
	// The name of the configuration
	ConfigurationName pulumi.StringOutput `pulumi:"configurationName"`
	// The ARN of the IAM role that defines the permissions for AWS Chatbot
	IamRoleArn pulumi.StringOutput `pulumi:"iamRoleArn"`
	// Specifies the logging level for this configuration:ERROR,INFO or NONE. This property affects the log entries pushed to Amazon CloudWatch logs
	LoggingLevel pulumi.StringPtrOutput `pulumi:"loggingLevel"`
	// The id of the Slack channel
	SlackChannelId pulumi.StringOutput `pulumi:"slackChannelId"`
	// The id of the Slack workspace
	SlackWorkspaceId pulumi.StringOutput `pulumi:"slackWorkspaceId"`
	// ARNs of SNS topics which delivers notifications to AWS Chatbot, for example CloudWatch alarm notifications.
	SnsTopicArns pulumi.StringArrayOutput `pulumi:"snsTopicArns"`
}

// NewSlackChannelConfiguration registers a new resource with the given unique name, arguments, and options.
func NewSlackChannelConfiguration(ctx *pulumi.Context,
	name string, args *SlackChannelConfigurationArgs, opts ...pulumi.ResourceOption) (*SlackChannelConfiguration, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ConfigurationName == nil {
		return nil, errors.New("invalid value for required argument 'ConfigurationName'")
	}
	if args.IamRoleArn == nil {
		return nil, errors.New("invalid value for required argument 'IamRoleArn'")
	}
	if args.SlackChannelId == nil {
		return nil, errors.New("invalid value for required argument 'SlackChannelId'")
	}
	if args.SlackWorkspaceId == nil {
		return nil, errors.New("invalid value for required argument 'SlackWorkspaceId'")
	}
	var resource SlackChannelConfiguration
	err := ctx.RegisterResource("aws-native:chatbot:SlackChannelConfiguration", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSlackChannelConfiguration gets an existing SlackChannelConfiguration resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSlackChannelConfiguration(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SlackChannelConfigurationState, opts ...pulumi.ResourceOption) (*SlackChannelConfiguration, error) {
	var resource SlackChannelConfiguration
	err := ctx.ReadResource("aws-native:chatbot:SlackChannelConfiguration", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SlackChannelConfiguration resources.
type slackChannelConfigurationState struct {
}

type SlackChannelConfigurationState struct {
}

func (SlackChannelConfigurationState) ElementType() reflect.Type {
	return reflect.TypeOf((*slackChannelConfigurationState)(nil)).Elem()
}

type slackChannelConfigurationArgs struct {
	// The name of the configuration
	ConfigurationName string `pulumi:"configurationName"`
	// The ARN of the IAM role that defines the permissions for AWS Chatbot
	IamRoleArn string `pulumi:"iamRoleArn"`
	// Specifies the logging level for this configuration:ERROR,INFO or NONE. This property affects the log entries pushed to Amazon CloudWatch logs
	LoggingLevel *string `pulumi:"loggingLevel"`
	// The id of the Slack channel
	SlackChannelId string `pulumi:"slackChannelId"`
	// The id of the Slack workspace
	SlackWorkspaceId string `pulumi:"slackWorkspaceId"`
	// ARNs of SNS topics which delivers notifications to AWS Chatbot, for example CloudWatch alarm notifications.
	SnsTopicArns []string `pulumi:"snsTopicArns"`
}

// The set of arguments for constructing a SlackChannelConfiguration resource.
type SlackChannelConfigurationArgs struct {
	// The name of the configuration
	ConfigurationName pulumi.StringInput
	// The ARN of the IAM role that defines the permissions for AWS Chatbot
	IamRoleArn pulumi.StringInput
	// Specifies the logging level for this configuration:ERROR,INFO or NONE. This property affects the log entries pushed to Amazon CloudWatch logs
	LoggingLevel pulumi.StringPtrInput
	// The id of the Slack channel
	SlackChannelId pulumi.StringInput
	// The id of the Slack workspace
	SlackWorkspaceId pulumi.StringInput
	// ARNs of SNS topics which delivers notifications to AWS Chatbot, for example CloudWatch alarm notifications.
	SnsTopicArns pulumi.StringArrayInput
}

func (SlackChannelConfigurationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*slackChannelConfigurationArgs)(nil)).Elem()
}

type SlackChannelConfigurationInput interface {
	pulumi.Input

	ToSlackChannelConfigurationOutput() SlackChannelConfigurationOutput
	ToSlackChannelConfigurationOutputWithContext(ctx context.Context) SlackChannelConfigurationOutput
}

func (*SlackChannelConfiguration) ElementType() reflect.Type {
	return reflect.TypeOf((*SlackChannelConfiguration)(nil))
}

func (i *SlackChannelConfiguration) ToSlackChannelConfigurationOutput() SlackChannelConfigurationOutput {
	return i.ToSlackChannelConfigurationOutputWithContext(context.Background())
}

func (i *SlackChannelConfiguration) ToSlackChannelConfigurationOutputWithContext(ctx context.Context) SlackChannelConfigurationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SlackChannelConfigurationOutput)
}

type SlackChannelConfigurationOutput struct{ *pulumi.OutputState }

func (SlackChannelConfigurationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SlackChannelConfiguration)(nil))
}

func (o SlackChannelConfigurationOutput) ToSlackChannelConfigurationOutput() SlackChannelConfigurationOutput {
	return o
}

func (o SlackChannelConfigurationOutput) ToSlackChannelConfigurationOutputWithContext(ctx context.Context) SlackChannelConfigurationOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(SlackChannelConfigurationOutput{})
}
