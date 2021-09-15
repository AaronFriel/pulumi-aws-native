// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package route53recoveryreadiness

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// AWS Route53 Recovery Readiness Recovery Group Schema and API specifications.
type RecoveryGroup struct {
	pulumi.CustomResourceState

	// A list of the cell Amazon Resource Names (ARNs) in the recovery group.
	Cells pulumi.StringArrayOutput `pulumi:"cells"`
	// A collection of tags associated with a resource.
	RecoveryGroupArn pulumi.StringOutput `pulumi:"recoveryGroupArn"`
	// The name of the recovery group to create.
	RecoveryGroupName pulumi.StringOutput `pulumi:"recoveryGroupName"`
	// A collection of tags associated with a resource.
	Tags RecoveryGroupTagArrayOutput `pulumi:"tags"`
}

// NewRecoveryGroup registers a new resource with the given unique name, arguments, and options.
func NewRecoveryGroup(ctx *pulumi.Context,
	name string, args *RecoveryGroupArgs, opts ...pulumi.ResourceOption) (*RecoveryGroup, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.RecoveryGroupName == nil {
		return nil, errors.New("invalid value for required argument 'RecoveryGroupName'")
	}
	var resource RecoveryGroup
	err := ctx.RegisterResource("aws-native:route53recoveryreadiness:RecoveryGroup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRecoveryGroup gets an existing RecoveryGroup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRecoveryGroup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RecoveryGroupState, opts ...pulumi.ResourceOption) (*RecoveryGroup, error) {
	var resource RecoveryGroup
	err := ctx.ReadResource("aws-native:route53recoveryreadiness:RecoveryGroup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering RecoveryGroup resources.
type recoveryGroupState struct {
}

type RecoveryGroupState struct {
}

func (RecoveryGroupState) ElementType() reflect.Type {
	return reflect.TypeOf((*recoveryGroupState)(nil)).Elem()
}

type recoveryGroupArgs struct {
	// A list of the cell Amazon Resource Names (ARNs) in the recovery group.
	Cells []string `pulumi:"cells"`
	// The name of the recovery group to create.
	RecoveryGroupName string `pulumi:"recoveryGroupName"`
	// A collection of tags associated with a resource.
	Tags []RecoveryGroupTag `pulumi:"tags"`
}

// The set of arguments for constructing a RecoveryGroup resource.
type RecoveryGroupArgs struct {
	// A list of the cell Amazon Resource Names (ARNs) in the recovery group.
	Cells pulumi.StringArrayInput
	// The name of the recovery group to create.
	RecoveryGroupName pulumi.StringInput
	// A collection of tags associated with a resource.
	Tags RecoveryGroupTagArrayInput
}

func (RecoveryGroupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*recoveryGroupArgs)(nil)).Elem()
}

type RecoveryGroupInput interface {
	pulumi.Input

	ToRecoveryGroupOutput() RecoveryGroupOutput
	ToRecoveryGroupOutputWithContext(ctx context.Context) RecoveryGroupOutput
}

func (*RecoveryGroup) ElementType() reflect.Type {
	return reflect.TypeOf((*RecoveryGroup)(nil))
}

func (i *RecoveryGroup) ToRecoveryGroupOutput() RecoveryGroupOutput {
	return i.ToRecoveryGroupOutputWithContext(context.Background())
}

func (i *RecoveryGroup) ToRecoveryGroupOutputWithContext(ctx context.Context) RecoveryGroupOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RecoveryGroupOutput)
}

type RecoveryGroupOutput struct{ *pulumi.OutputState }

func (RecoveryGroupOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*RecoveryGroup)(nil))
}

func (o RecoveryGroupOutput) ToRecoveryGroupOutput() RecoveryGroupOutput {
	return o
}

func (o RecoveryGroupOutput) ToRecoveryGroupOutputWithContext(ctx context.Context) RecoveryGroupOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(RecoveryGroupOutput{})
}
