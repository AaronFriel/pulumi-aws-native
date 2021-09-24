// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package codepipeline

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::CodePipeline::Webhook
//
// Deprecated: Webhook is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type Webhook struct {
	pulumi.CustomResourceState

	Authentication              pulumi.StringOutput                   `pulumi:"authentication"`
	AuthenticationConfiguration WebhookWebhookAuthConfigurationOutput `pulumi:"authenticationConfiguration"`
	Filters                     WebhookWebhookFilterRuleArrayOutput   `pulumi:"filters"`
	Name                        pulumi.StringPtrOutput                `pulumi:"name"`
	RegisterWithThirdParty      pulumi.BoolPtrOutput                  `pulumi:"registerWithThirdParty"`
	TargetAction                pulumi.StringOutput                   `pulumi:"targetAction"`
	TargetPipeline              pulumi.StringOutput                   `pulumi:"targetPipeline"`
	TargetPipelineVersion       pulumi.IntOutput                      `pulumi:"targetPipelineVersion"`
	Url                         pulumi.StringOutput                   `pulumi:"url"`
}

// NewWebhook registers a new resource with the given unique name, arguments, and options.
func NewWebhook(ctx *pulumi.Context,
	name string, args *WebhookArgs, opts ...pulumi.ResourceOption) (*Webhook, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Authentication == nil {
		return nil, errors.New("invalid value for required argument 'Authentication'")
	}
	if args.AuthenticationConfiguration == nil {
		return nil, errors.New("invalid value for required argument 'AuthenticationConfiguration'")
	}
	if args.Filters == nil {
		return nil, errors.New("invalid value for required argument 'Filters'")
	}
	if args.TargetAction == nil {
		return nil, errors.New("invalid value for required argument 'TargetAction'")
	}
	if args.TargetPipeline == nil {
		return nil, errors.New("invalid value for required argument 'TargetPipeline'")
	}
	if args.TargetPipelineVersion == nil {
		return nil, errors.New("invalid value for required argument 'TargetPipelineVersion'")
	}
	var resource Webhook
	err := ctx.RegisterResource("aws-native:codepipeline:Webhook", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWebhook gets an existing Webhook resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWebhook(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WebhookState, opts ...pulumi.ResourceOption) (*Webhook, error) {
	var resource Webhook
	err := ctx.ReadResource("aws-native:codepipeline:Webhook", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Webhook resources.
type webhookState struct {
}

type WebhookState struct {
}

func (WebhookState) ElementType() reflect.Type {
	return reflect.TypeOf((*webhookState)(nil)).Elem()
}

type webhookArgs struct {
	Authentication              string                          `pulumi:"authentication"`
	AuthenticationConfiguration WebhookWebhookAuthConfiguration `pulumi:"authenticationConfiguration"`
	Filters                     []WebhookWebhookFilterRule      `pulumi:"filters"`
	Name                        *string                         `pulumi:"name"`
	RegisterWithThirdParty      *bool                           `pulumi:"registerWithThirdParty"`
	TargetAction                string                          `pulumi:"targetAction"`
	TargetPipeline              string                          `pulumi:"targetPipeline"`
	TargetPipelineVersion       int                             `pulumi:"targetPipelineVersion"`
}

// The set of arguments for constructing a Webhook resource.
type WebhookArgs struct {
	Authentication              pulumi.StringInput
	AuthenticationConfiguration WebhookWebhookAuthConfigurationInput
	Filters                     WebhookWebhookFilterRuleArrayInput
	Name                        pulumi.StringPtrInput
	RegisterWithThirdParty      pulumi.BoolPtrInput
	TargetAction                pulumi.StringInput
	TargetPipeline              pulumi.StringInput
	TargetPipelineVersion       pulumi.IntInput
}

func (WebhookArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*webhookArgs)(nil)).Elem()
}

type WebhookInput interface {
	pulumi.Input

	ToWebhookOutput() WebhookOutput
	ToWebhookOutputWithContext(ctx context.Context) WebhookOutput
}

func (*Webhook) ElementType() reflect.Type {
	return reflect.TypeOf((*Webhook)(nil))
}

func (i *Webhook) ToWebhookOutput() WebhookOutput {
	return i.ToWebhookOutputWithContext(context.Background())
}

func (i *Webhook) ToWebhookOutputWithContext(ctx context.Context) WebhookOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WebhookOutput)
}

type WebhookOutput struct{ *pulumi.OutputState }

func (WebhookOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Webhook)(nil))
}

func (o WebhookOutput) ToWebhookOutput() WebhookOutput {
	return o
}

func (o WebhookOutput) ToWebhookOutputWithContext(ctx context.Context) WebhookOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(WebhookOutput{})
}
