// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package pinpoint

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-smstemplate.html
type SmsTemplate struct {
	pulumi.CustomResourceState

	Arn pulumi.StringOutput `pulumi:"arn"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-smstemplate.html#cfn-pinpoint-smstemplate-body
	Body pulumi.StringOutput `pulumi:"body"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-smstemplate.html#cfn-pinpoint-smstemplate-defaultsubstitutions
	DefaultSubstitutions pulumi.StringPtrOutput `pulumi:"defaultSubstitutions"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-smstemplate.html#cfn-pinpoint-smstemplate-tags
	Tags pulumi.AnyOutput `pulumi:"tags"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-smstemplate.html#cfn-pinpoint-smstemplate-templatedescription
	TemplateDescription pulumi.StringPtrOutput `pulumi:"templateDescription"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-smstemplate.html#cfn-pinpoint-smstemplate-templatename
	TemplateName pulumi.StringOutput `pulumi:"templateName"`
}

// NewSmsTemplate registers a new resource with the given unique name, arguments, and options.
func NewSmsTemplate(ctx *pulumi.Context,
	name string, args *SmsTemplateArgs, opts ...pulumi.ResourceOption) (*SmsTemplate, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Body == nil {
		return nil, errors.New("invalid value for required argument 'Body'")
	}
	if args.TemplateName == nil {
		return nil, errors.New("invalid value for required argument 'TemplateName'")
	}
	var resource SmsTemplate
	err := ctx.RegisterResource("aws-native:pinpoint:SmsTemplate", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSmsTemplate gets an existing SmsTemplate resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSmsTemplate(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SmsTemplateState, opts ...pulumi.ResourceOption) (*SmsTemplate, error) {
	var resource SmsTemplate
	err := ctx.ReadResource("aws-native:pinpoint:SmsTemplate", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SmsTemplate resources.
type smsTemplateState struct {
}

type SmsTemplateState struct {
}

func (SmsTemplateState) ElementType() reflect.Type {
	return reflect.TypeOf((*smsTemplateState)(nil)).Elem()
}

type smsTemplateArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-smstemplate.html#cfn-pinpoint-smstemplate-body
	Body string `pulumi:"body"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-smstemplate.html#cfn-pinpoint-smstemplate-defaultsubstitutions
	DefaultSubstitutions *string `pulumi:"defaultSubstitutions"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-smstemplate.html#cfn-pinpoint-smstemplate-tags
	Tags interface{} `pulumi:"tags"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-smstemplate.html#cfn-pinpoint-smstemplate-templatedescription
	TemplateDescription *string `pulumi:"templateDescription"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-smstemplate.html#cfn-pinpoint-smstemplate-templatename
	TemplateName string `pulumi:"templateName"`
}

// The set of arguments for constructing a SmsTemplate resource.
type SmsTemplateArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-smstemplate.html#cfn-pinpoint-smstemplate-body
	Body pulumi.StringInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-smstemplate.html#cfn-pinpoint-smstemplate-defaultsubstitutions
	DefaultSubstitutions pulumi.StringPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-smstemplate.html#cfn-pinpoint-smstemplate-tags
	Tags pulumi.Input
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-smstemplate.html#cfn-pinpoint-smstemplate-templatedescription
	TemplateDescription pulumi.StringPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-smstemplate.html#cfn-pinpoint-smstemplate-templatename
	TemplateName pulumi.StringInput
}

func (SmsTemplateArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*smsTemplateArgs)(nil)).Elem()
}

type SmsTemplateInput interface {
	pulumi.Input

	ToSmsTemplateOutput() SmsTemplateOutput
	ToSmsTemplateOutputWithContext(ctx context.Context) SmsTemplateOutput
}

func (*SmsTemplate) ElementType() reflect.Type {
	return reflect.TypeOf((*SmsTemplate)(nil))
}

func (i *SmsTemplate) ToSmsTemplateOutput() SmsTemplateOutput {
	return i.ToSmsTemplateOutputWithContext(context.Background())
}

func (i *SmsTemplate) ToSmsTemplateOutputWithContext(ctx context.Context) SmsTemplateOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SmsTemplateOutput)
}

type SmsTemplateOutput struct{ *pulumi.OutputState }

func (SmsTemplateOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SmsTemplate)(nil))
}

func (o SmsTemplateOutput) ToSmsTemplateOutput() SmsTemplateOutput {
	return o
}

func (o SmsTemplateOutput) ToSmsTemplateOutputWithContext(ctx context.Context) SmsTemplateOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(SmsTemplateOutput{})
}