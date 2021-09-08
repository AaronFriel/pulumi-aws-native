// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package cloudformation

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-macro.html
type Macro struct {
	pulumi.CustomResourceState

	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-macro.html#cfn-cloudformation-macro-description
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-macro.html#cfn-cloudformation-macro-functionname
	FunctionName pulumi.StringOutput `pulumi:"functionName"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-macro.html#cfn-cloudformation-macro-loggroupname
	LogGroupName pulumi.StringPtrOutput `pulumi:"logGroupName"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-macro.html#cfn-cloudformation-macro-logrolearn
	LogRoleARN pulumi.StringPtrOutput `pulumi:"logRoleARN"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-macro.html#cfn-cloudformation-macro-name
	Name pulumi.StringOutput `pulumi:"name"`
}

// NewMacro registers a new resource with the given unique name, arguments, and options.
func NewMacro(ctx *pulumi.Context,
	name string, args *MacroArgs, opts ...pulumi.ResourceOption) (*Macro, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.FunctionName == nil {
		return nil, errors.New("invalid value for required argument 'FunctionName'")
	}
	if args.Name == nil {
		return nil, errors.New("invalid value for required argument 'Name'")
	}
	var resource Macro
	err := ctx.RegisterResource("aws-native:cloudformation:Macro", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetMacro gets an existing Macro resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMacro(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *MacroState, opts ...pulumi.ResourceOption) (*Macro, error) {
	var resource Macro
	err := ctx.ReadResource("aws-native:cloudformation:Macro", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Macro resources.
type macroState struct {
}

type MacroState struct {
}

func (MacroState) ElementType() reflect.Type {
	return reflect.TypeOf((*macroState)(nil)).Elem()
}

type macroArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-macro.html#cfn-cloudformation-macro-description
	Description *string `pulumi:"description"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-macro.html#cfn-cloudformation-macro-functionname
	FunctionName string `pulumi:"functionName"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-macro.html#cfn-cloudformation-macro-loggroupname
	LogGroupName *string `pulumi:"logGroupName"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-macro.html#cfn-cloudformation-macro-logrolearn
	LogRoleARN *string `pulumi:"logRoleARN"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-macro.html#cfn-cloudformation-macro-name
	Name string `pulumi:"name"`
}

// The set of arguments for constructing a Macro resource.
type MacroArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-macro.html#cfn-cloudformation-macro-description
	Description pulumi.StringPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-macro.html#cfn-cloudformation-macro-functionname
	FunctionName pulumi.StringInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-macro.html#cfn-cloudformation-macro-loggroupname
	LogGroupName pulumi.StringPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-macro.html#cfn-cloudformation-macro-logrolearn
	LogRoleARN pulumi.StringPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-macro.html#cfn-cloudformation-macro-name
	Name pulumi.StringInput
}

func (MacroArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*macroArgs)(nil)).Elem()
}

type MacroInput interface {
	pulumi.Input

	ToMacroOutput() MacroOutput
	ToMacroOutputWithContext(ctx context.Context) MacroOutput
}

func (*Macro) ElementType() reflect.Type {
	return reflect.TypeOf((*Macro)(nil))
}

func (i *Macro) ToMacroOutput() MacroOutput {
	return i.ToMacroOutputWithContext(context.Background())
}

func (i *Macro) ToMacroOutputWithContext(ctx context.Context) MacroOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MacroOutput)
}

type MacroOutput struct{ *pulumi.OutputState }

func (MacroOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Macro)(nil))
}

func (o MacroOutput) ToMacroOutput() MacroOutput {
	return o
}

func (o MacroOutput) ToMacroOutputWithContext(ctx context.Context) MacroOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(MacroOutput{})
}