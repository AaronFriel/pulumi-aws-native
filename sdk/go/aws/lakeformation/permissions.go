// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package lakeformation

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::LakeFormation::Permissions
//
// Deprecated: Permissions is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type Permissions struct {
	pulumi.CustomResourceState

	DataLakePrincipal          PermissionsDataLakePrincipalOutput `pulumi:"dataLakePrincipal"`
	Permissions                pulumi.StringArrayOutput           `pulumi:"permissions"`
	PermissionsWithGrantOption pulumi.StringArrayOutput           `pulumi:"permissionsWithGrantOption"`
	Resource                   PermissionsResourceOutput          `pulumi:"resource"`
}

// NewPermissions registers a new resource with the given unique name, arguments, and options.
func NewPermissions(ctx *pulumi.Context,
	name string, args *PermissionsArgs, opts ...pulumi.ResourceOption) (*Permissions, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DataLakePrincipal == nil {
		return nil, errors.New("invalid value for required argument 'DataLakePrincipal'")
	}
	if args.Resource == nil {
		return nil, errors.New("invalid value for required argument 'Resource'")
	}
	var resource Permissions
	err := ctx.RegisterResource("aws-native:lakeformation:Permissions", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPermissions gets an existing Permissions resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPermissions(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PermissionsState, opts ...pulumi.ResourceOption) (*Permissions, error) {
	var resource Permissions
	err := ctx.ReadResource("aws-native:lakeformation:Permissions", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Permissions resources.
type permissionsState struct {
}

type PermissionsState struct {
}

func (PermissionsState) ElementType() reflect.Type {
	return reflect.TypeOf((*permissionsState)(nil)).Elem()
}

type permissionsArgs struct {
	DataLakePrincipal          PermissionsDataLakePrincipal `pulumi:"dataLakePrincipal"`
	Permissions                []string                     `pulumi:"permissions"`
	PermissionsWithGrantOption []string                     `pulumi:"permissionsWithGrantOption"`
	Resource                   PermissionsResource          `pulumi:"resource"`
}

// The set of arguments for constructing a Permissions resource.
type PermissionsArgs struct {
	DataLakePrincipal          PermissionsDataLakePrincipalInput
	Permissions                pulumi.StringArrayInput
	PermissionsWithGrantOption pulumi.StringArrayInput
	Resource                   PermissionsResourceInput
}

func (PermissionsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*permissionsArgs)(nil)).Elem()
}

type PermissionsInput interface {
	pulumi.Input

	ToPermissionsOutput() PermissionsOutput
	ToPermissionsOutputWithContext(ctx context.Context) PermissionsOutput
}

func (*Permissions) ElementType() reflect.Type {
	return reflect.TypeOf((*Permissions)(nil))
}

func (i *Permissions) ToPermissionsOutput() PermissionsOutput {
	return i.ToPermissionsOutputWithContext(context.Background())
}

func (i *Permissions) ToPermissionsOutputWithContext(ctx context.Context) PermissionsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PermissionsOutput)
}

type PermissionsOutput struct{ *pulumi.OutputState }

func (PermissionsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Permissions)(nil))
}

func (o PermissionsOutput) ToPermissionsOutput() PermissionsOutput {
	return o
}

func (o PermissionsOutput) ToPermissionsOutputWithContext(ctx context.Context) PermissionsOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(PermissionsOutput{})
}
