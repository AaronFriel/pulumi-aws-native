// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package gamelift

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-alias.html
type Alias struct {
	pulumi.CustomResourceState

	AliasId pulumi.StringOutput `pulumi:"aliasId"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-alias.html#cfn-gamelift-alias-description
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-alias.html#cfn-gamelift-alias-name
	Name pulumi.StringOutput `pulumi:"name"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-alias.html#cfn-gamelift-alias-routingstrategy
	RoutingStrategy AliasRoutingStrategyOutput `pulumi:"routingStrategy"`
}

// NewAlias registers a new resource with the given unique name, arguments, and options.
func NewAlias(ctx *pulumi.Context,
	name string, args *AliasArgs, opts ...pulumi.ResourceOption) (*Alias, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Name == nil {
		return nil, errors.New("invalid value for required argument 'Name'")
	}
	if args.RoutingStrategy == nil {
		return nil, errors.New("invalid value for required argument 'RoutingStrategy'")
	}
	var resource Alias
	err := ctx.RegisterResource("aws-native:GameLift:Alias", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAlias gets an existing Alias resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAlias(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AliasState, opts ...pulumi.ResourceOption) (*Alias, error) {
	var resource Alias
	err := ctx.ReadResource("aws-native:GameLift:Alias", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Alias resources.
type aliasState struct {
}

type AliasState struct {
}

func (AliasState) ElementType() reflect.Type {
	return reflect.TypeOf((*aliasState)(nil)).Elem()
}

type aliasArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-alias.html#cfn-gamelift-alias-description
	Description *string `pulumi:"description"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-alias.html#cfn-gamelift-alias-name
	Name string `pulumi:"name"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-alias.html#cfn-gamelift-alias-routingstrategy
	RoutingStrategy AliasRoutingStrategy `pulumi:"routingStrategy"`
}

// The set of arguments for constructing a Alias resource.
type AliasArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-alias.html#cfn-gamelift-alias-description
	Description pulumi.StringPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-alias.html#cfn-gamelift-alias-name
	Name pulumi.StringInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-alias.html#cfn-gamelift-alias-routingstrategy
	RoutingStrategy AliasRoutingStrategyInput
}

func (AliasArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*aliasArgs)(nil)).Elem()
}

type AliasInput interface {
	pulumi.Input

	ToAliasOutput() AliasOutput
	ToAliasOutputWithContext(ctx context.Context) AliasOutput
}

func (*Alias) ElementType() reflect.Type {
	return reflect.TypeOf((*Alias)(nil))
}

func (i *Alias) ToAliasOutput() AliasOutput {
	return i.ToAliasOutputWithContext(context.Background())
}

func (i *Alias) ToAliasOutputWithContext(ctx context.Context) AliasOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AliasOutput)
}

type AliasOutput struct{ *pulumi.OutputState }

func (AliasOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Alias)(nil))
}

func (o AliasOutput) ToAliasOutput() AliasOutput {
	return o
}

func (o AliasOutput) ToAliasOutputWithContext(ctx context.Context) AliasOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(AliasOutput{})
}