// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package gamelift

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::GameLift::MatchmakingRuleSet
//
// Deprecated: MatchmakingRuleSet is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type MatchmakingRuleSet struct {
	pulumi.CustomResourceState

	Arn         pulumi.StringOutput              `pulumi:"arn"`
	Name        pulumi.StringOutput              `pulumi:"name"`
	RuleSetBody pulumi.StringOutput              `pulumi:"ruleSetBody"`
	Tags        MatchmakingRuleSetTagArrayOutput `pulumi:"tags"`
}

// NewMatchmakingRuleSet registers a new resource with the given unique name, arguments, and options.
func NewMatchmakingRuleSet(ctx *pulumi.Context,
	name string, args *MatchmakingRuleSetArgs, opts ...pulumi.ResourceOption) (*MatchmakingRuleSet, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.RuleSetBody == nil {
		return nil, errors.New("invalid value for required argument 'RuleSetBody'")
	}
	var resource MatchmakingRuleSet
	err := ctx.RegisterResource("aws-native:gamelift:MatchmakingRuleSet", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetMatchmakingRuleSet gets an existing MatchmakingRuleSet resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMatchmakingRuleSet(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *MatchmakingRuleSetState, opts ...pulumi.ResourceOption) (*MatchmakingRuleSet, error) {
	var resource MatchmakingRuleSet
	err := ctx.ReadResource("aws-native:gamelift:MatchmakingRuleSet", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering MatchmakingRuleSet resources.
type matchmakingRuleSetState struct {
}

type MatchmakingRuleSetState struct {
}

func (MatchmakingRuleSetState) ElementType() reflect.Type {
	return reflect.TypeOf((*matchmakingRuleSetState)(nil)).Elem()
}

type matchmakingRuleSetArgs struct {
	Name        *string                 `pulumi:"name"`
	RuleSetBody string                  `pulumi:"ruleSetBody"`
	Tags        []MatchmakingRuleSetTag `pulumi:"tags"`
}

// The set of arguments for constructing a MatchmakingRuleSet resource.
type MatchmakingRuleSetArgs struct {
	Name        pulumi.StringPtrInput
	RuleSetBody pulumi.StringInput
	Tags        MatchmakingRuleSetTagArrayInput
}

func (MatchmakingRuleSetArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*matchmakingRuleSetArgs)(nil)).Elem()
}

type MatchmakingRuleSetInput interface {
	pulumi.Input

	ToMatchmakingRuleSetOutput() MatchmakingRuleSetOutput
	ToMatchmakingRuleSetOutputWithContext(ctx context.Context) MatchmakingRuleSetOutput
}

func (*MatchmakingRuleSet) ElementType() reflect.Type {
	return reflect.TypeOf((*MatchmakingRuleSet)(nil))
}

func (i *MatchmakingRuleSet) ToMatchmakingRuleSetOutput() MatchmakingRuleSetOutput {
	return i.ToMatchmakingRuleSetOutputWithContext(context.Background())
}

func (i *MatchmakingRuleSet) ToMatchmakingRuleSetOutputWithContext(ctx context.Context) MatchmakingRuleSetOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MatchmakingRuleSetOutput)
}

type MatchmakingRuleSetOutput struct{ *pulumi.OutputState }

func (MatchmakingRuleSetOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*MatchmakingRuleSet)(nil))
}

func (o MatchmakingRuleSetOutput) ToMatchmakingRuleSetOutput() MatchmakingRuleSetOutput {
	return o
}

func (o MatchmakingRuleSetOutput) ToMatchmakingRuleSetOutputWithContext(ctx context.Context) MatchmakingRuleSetOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*MatchmakingRuleSetInput)(nil)).Elem(), &MatchmakingRuleSet{})
	pulumi.RegisterOutputType(MatchmakingRuleSetOutput{})
}
