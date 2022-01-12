// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package workspaces

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::WorkSpaces::ConnectionAlias
type ConnectionAlias struct {
	pulumi.CustomResourceState

	AliasId              pulumi.StringOutput                   `pulumi:"aliasId"`
	Associations         ConnectionAliasAssociationArrayOutput `pulumi:"associations"`
	ConnectionAliasState ConnectionAliasStateEnumOutput        `pulumi:"connectionAliasState"`
	ConnectionString     pulumi.StringOutput                   `pulumi:"connectionString"`
	Tags                 ConnectionAliasTagArrayOutput         `pulumi:"tags"`
}

// NewConnectionAlias registers a new resource with the given unique name, arguments, and options.
func NewConnectionAlias(ctx *pulumi.Context,
	name string, args *ConnectionAliasArgs, opts ...pulumi.ResourceOption) (*ConnectionAlias, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ConnectionString == nil {
		return nil, errors.New("invalid value for required argument 'ConnectionString'")
	}
	var resource ConnectionAlias
	err := ctx.RegisterResource("aws-native:workspaces:ConnectionAlias", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetConnectionAlias gets an existing ConnectionAlias resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetConnectionAlias(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ConnectionAliasState, opts ...pulumi.ResourceOption) (*ConnectionAlias, error) {
	var resource ConnectionAlias
	err := ctx.ReadResource("aws-native:workspaces:ConnectionAlias", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ConnectionAlias resources.
type connectionAliasState struct {
}

type ConnectionAliasState struct {
}

func (ConnectionAliasState) ElementType() reflect.Type {
	return reflect.TypeOf((*connectionAliasState)(nil)).Elem()
}

type connectionAliasArgs struct {
	ConnectionString string               `pulumi:"connectionString"`
	Tags             []ConnectionAliasTag `pulumi:"tags"`
}

// The set of arguments for constructing a ConnectionAlias resource.
type ConnectionAliasArgs struct {
	ConnectionString pulumi.StringInput
	Tags             ConnectionAliasTagArrayInput
}

func (ConnectionAliasArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*connectionAliasArgs)(nil)).Elem()
}

type ConnectionAliasInput interface {
	pulumi.Input

	ToConnectionAliasOutput() ConnectionAliasOutput
	ToConnectionAliasOutputWithContext(ctx context.Context) ConnectionAliasOutput
}

func (*ConnectionAlias) ElementType() reflect.Type {
	return reflect.TypeOf((*ConnectionAlias)(nil))
}

func (i *ConnectionAlias) ToConnectionAliasOutput() ConnectionAliasOutput {
	return i.ToConnectionAliasOutputWithContext(context.Background())
}

func (i *ConnectionAlias) ToConnectionAliasOutputWithContext(ctx context.Context) ConnectionAliasOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ConnectionAliasOutput)
}

type ConnectionAliasOutput struct{ *pulumi.OutputState }

func (ConnectionAliasOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ConnectionAlias)(nil))
}

func (o ConnectionAliasOutput) ToConnectionAliasOutput() ConnectionAliasOutput {
	return o
}

func (o ConnectionAliasOutput) ToConnectionAliasOutputWithContext(ctx context.Context) ConnectionAliasOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ConnectionAliasInput)(nil)).Elem(), &ConnectionAlias{})
	pulumi.RegisterOutputType(ConnectionAliasOutput{})
}
