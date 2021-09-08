// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package configuration

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html
type ConfigRule struct {
	pulumi.CustomResourceState

	Arn            pulumi.StringOutput `pulumi:"arn"`
	ComplianceType pulumi.StringOutput `pulumi:"complianceType"`
	ConfigRuleId   pulumi.StringOutput `pulumi:"configRuleId"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html#cfn-config-configrule-configrulename
	ConfigRuleName pulumi.StringPtrOutput `pulumi:"configRuleName"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html#cfn-config-configrule-description
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html#cfn-config-configrule-inputparameters
	InputParameters pulumi.AnyOutput `pulumi:"inputParameters"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html#cfn-config-configrule-maximumexecutionfrequency
	MaximumExecutionFrequency pulumi.StringPtrOutput `pulumi:"maximumExecutionFrequency"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html#cfn-config-configrule-scope
	Scope ConfigRuleScopePtrOutput `pulumi:"scope"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html#cfn-config-configrule-source
	Source ConfigRuleSourceOutput `pulumi:"source"`
}

// NewConfigRule registers a new resource with the given unique name, arguments, and options.
func NewConfigRule(ctx *pulumi.Context,
	name string, args *ConfigRuleArgs, opts ...pulumi.ResourceOption) (*ConfigRule, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Source == nil {
		return nil, errors.New("invalid value for required argument 'Source'")
	}
	var resource ConfigRule
	err := ctx.RegisterResource("aws-native:configuration:ConfigRule", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetConfigRule gets an existing ConfigRule resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetConfigRule(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ConfigRuleState, opts ...pulumi.ResourceOption) (*ConfigRule, error) {
	var resource ConfigRule
	err := ctx.ReadResource("aws-native:configuration:ConfigRule", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ConfigRule resources.
type configRuleState struct {
}

type ConfigRuleState struct {
}

func (ConfigRuleState) ElementType() reflect.Type {
	return reflect.TypeOf((*configRuleState)(nil)).Elem()
}

type configRuleArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html#cfn-config-configrule-configrulename
	ConfigRuleName *string `pulumi:"configRuleName"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html#cfn-config-configrule-description
	Description *string `pulumi:"description"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html#cfn-config-configrule-inputparameters
	InputParameters interface{} `pulumi:"inputParameters"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html#cfn-config-configrule-maximumexecutionfrequency
	MaximumExecutionFrequency *string `pulumi:"maximumExecutionFrequency"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html#cfn-config-configrule-scope
	Scope *ConfigRuleScope `pulumi:"scope"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html#cfn-config-configrule-source
	Source ConfigRuleSource `pulumi:"source"`
}

// The set of arguments for constructing a ConfigRule resource.
type ConfigRuleArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html#cfn-config-configrule-configrulename
	ConfigRuleName pulumi.StringPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html#cfn-config-configrule-description
	Description pulumi.StringPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html#cfn-config-configrule-inputparameters
	InputParameters pulumi.Input
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html#cfn-config-configrule-maximumexecutionfrequency
	MaximumExecutionFrequency pulumi.StringPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html#cfn-config-configrule-scope
	Scope ConfigRuleScopePtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configrule.html#cfn-config-configrule-source
	Source ConfigRuleSourceInput
}

func (ConfigRuleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*configRuleArgs)(nil)).Elem()
}

type ConfigRuleInput interface {
	pulumi.Input

	ToConfigRuleOutput() ConfigRuleOutput
	ToConfigRuleOutputWithContext(ctx context.Context) ConfigRuleOutput
}

func (*ConfigRule) ElementType() reflect.Type {
	return reflect.TypeOf((*ConfigRule)(nil))
}

func (i *ConfigRule) ToConfigRuleOutput() ConfigRuleOutput {
	return i.ToConfigRuleOutputWithContext(context.Background())
}

func (i *ConfigRule) ToConfigRuleOutputWithContext(ctx context.Context) ConfigRuleOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ConfigRuleOutput)
}

type ConfigRuleOutput struct{ *pulumi.OutputState }

func (ConfigRuleOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ConfigRule)(nil))
}

func (o ConfigRuleOutput) ToConfigRuleOutput() ConfigRuleOutput {
	return o
}

func (o ConfigRuleOutput) ToConfigRuleOutputWithContext(ctx context.Context) ConfigRuleOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ConfigRuleOutput{})
}