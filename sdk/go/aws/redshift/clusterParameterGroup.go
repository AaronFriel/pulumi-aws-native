// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package redshift

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::Redshift::ClusterParameterGroup
//
// Deprecated: ClusterParameterGroup is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type ClusterParameterGroup struct {
	pulumi.CustomResourceState

	Description          pulumi.StringOutput                       `pulumi:"description"`
	ParameterGroupFamily pulumi.StringOutput                       `pulumi:"parameterGroupFamily"`
	Parameters           ClusterParameterGroupParameterArrayOutput `pulumi:"parameters"`
	Tags                 ClusterParameterGroupTagArrayOutput       `pulumi:"tags"`
}

// NewClusterParameterGroup registers a new resource with the given unique name, arguments, and options.
func NewClusterParameterGroup(ctx *pulumi.Context,
	name string, args *ClusterParameterGroupArgs, opts ...pulumi.ResourceOption) (*ClusterParameterGroup, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Description == nil {
		return nil, errors.New("invalid value for required argument 'Description'")
	}
	if args.ParameterGroupFamily == nil {
		return nil, errors.New("invalid value for required argument 'ParameterGroupFamily'")
	}
	var resource ClusterParameterGroup
	err := ctx.RegisterResource("aws-native:redshift:ClusterParameterGroup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetClusterParameterGroup gets an existing ClusterParameterGroup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetClusterParameterGroup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ClusterParameterGroupState, opts ...pulumi.ResourceOption) (*ClusterParameterGroup, error) {
	var resource ClusterParameterGroup
	err := ctx.ReadResource("aws-native:redshift:ClusterParameterGroup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ClusterParameterGroup resources.
type clusterParameterGroupState struct {
}

type ClusterParameterGroupState struct {
}

func (ClusterParameterGroupState) ElementType() reflect.Type {
	return reflect.TypeOf((*clusterParameterGroupState)(nil)).Elem()
}

type clusterParameterGroupArgs struct {
	Description          string                           `pulumi:"description"`
	ParameterGroupFamily string                           `pulumi:"parameterGroupFamily"`
	Parameters           []ClusterParameterGroupParameter `pulumi:"parameters"`
	Tags                 []ClusterParameterGroupTag       `pulumi:"tags"`
}

// The set of arguments for constructing a ClusterParameterGroup resource.
type ClusterParameterGroupArgs struct {
	Description          pulumi.StringInput
	ParameterGroupFamily pulumi.StringInput
	Parameters           ClusterParameterGroupParameterArrayInput
	Tags                 ClusterParameterGroupTagArrayInput
}

func (ClusterParameterGroupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*clusterParameterGroupArgs)(nil)).Elem()
}

type ClusterParameterGroupInput interface {
	pulumi.Input

	ToClusterParameterGroupOutput() ClusterParameterGroupOutput
	ToClusterParameterGroupOutputWithContext(ctx context.Context) ClusterParameterGroupOutput
}

func (*ClusterParameterGroup) ElementType() reflect.Type {
	return reflect.TypeOf((*ClusterParameterGroup)(nil))
}

func (i *ClusterParameterGroup) ToClusterParameterGroupOutput() ClusterParameterGroupOutput {
	return i.ToClusterParameterGroupOutputWithContext(context.Background())
}

func (i *ClusterParameterGroup) ToClusterParameterGroupOutputWithContext(ctx context.Context) ClusterParameterGroupOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ClusterParameterGroupOutput)
}

type ClusterParameterGroupOutput struct{ *pulumi.OutputState }

func (ClusterParameterGroupOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ClusterParameterGroup)(nil))
}

func (o ClusterParameterGroupOutput) ToClusterParameterGroupOutput() ClusterParameterGroupOutput {
	return o
}

func (o ClusterParameterGroupOutput) ToClusterParameterGroupOutputWithContext(ctx context.Context) ClusterParameterGroupOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ClusterParameterGroupInput)(nil)).Elem(), &ClusterParameterGroup{})
	pulumi.RegisterOutputType(ClusterParameterGroupOutput{})
}
