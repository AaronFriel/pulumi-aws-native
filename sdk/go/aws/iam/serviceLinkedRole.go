// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package iam

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::IAM::ServiceLinkedRole
//
// Deprecated: ServiceLinkedRole is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type ServiceLinkedRole struct {
	pulumi.CustomResourceState

	AWSServiceName pulumi.StringOutput    `pulumi:"aWSServiceName"`
	CustomSuffix   pulumi.StringPtrOutput `pulumi:"customSuffix"`
	Description    pulumi.StringPtrOutput `pulumi:"description"`
}

// NewServiceLinkedRole registers a new resource with the given unique name, arguments, and options.
func NewServiceLinkedRole(ctx *pulumi.Context,
	name string, args *ServiceLinkedRoleArgs, opts ...pulumi.ResourceOption) (*ServiceLinkedRole, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AWSServiceName == nil {
		return nil, errors.New("invalid value for required argument 'AWSServiceName'")
	}
	var resource ServiceLinkedRole
	err := ctx.RegisterResource("aws-native:iam:ServiceLinkedRole", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetServiceLinkedRole gets an existing ServiceLinkedRole resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetServiceLinkedRole(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ServiceLinkedRoleState, opts ...pulumi.ResourceOption) (*ServiceLinkedRole, error) {
	var resource ServiceLinkedRole
	err := ctx.ReadResource("aws-native:iam:ServiceLinkedRole", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ServiceLinkedRole resources.
type serviceLinkedRoleState struct {
}

type ServiceLinkedRoleState struct {
}

func (ServiceLinkedRoleState) ElementType() reflect.Type {
	return reflect.TypeOf((*serviceLinkedRoleState)(nil)).Elem()
}

type serviceLinkedRoleArgs struct {
	AWSServiceName string  `pulumi:"aWSServiceName"`
	CustomSuffix   *string `pulumi:"customSuffix"`
	Description    *string `pulumi:"description"`
}

// The set of arguments for constructing a ServiceLinkedRole resource.
type ServiceLinkedRoleArgs struct {
	AWSServiceName pulumi.StringInput
	CustomSuffix   pulumi.StringPtrInput
	Description    pulumi.StringPtrInput
}

func (ServiceLinkedRoleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*serviceLinkedRoleArgs)(nil)).Elem()
}

type ServiceLinkedRoleInput interface {
	pulumi.Input

	ToServiceLinkedRoleOutput() ServiceLinkedRoleOutput
	ToServiceLinkedRoleOutputWithContext(ctx context.Context) ServiceLinkedRoleOutput
}

func (*ServiceLinkedRole) ElementType() reflect.Type {
	return reflect.TypeOf((*ServiceLinkedRole)(nil))
}

func (i *ServiceLinkedRole) ToServiceLinkedRoleOutput() ServiceLinkedRoleOutput {
	return i.ToServiceLinkedRoleOutputWithContext(context.Background())
}

func (i *ServiceLinkedRole) ToServiceLinkedRoleOutputWithContext(ctx context.Context) ServiceLinkedRoleOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServiceLinkedRoleOutput)
}

type ServiceLinkedRoleOutput struct{ *pulumi.OutputState }

func (ServiceLinkedRoleOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ServiceLinkedRole)(nil))
}

func (o ServiceLinkedRoleOutput) ToServiceLinkedRoleOutput() ServiceLinkedRoleOutput {
	return o
}

func (o ServiceLinkedRoleOutput) ToServiceLinkedRoleOutputWithContext(ctx context.Context) ServiceLinkedRoleOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ServiceLinkedRoleInput)(nil)).Elem(), &ServiceLinkedRole{})
	pulumi.RegisterOutputType(ServiceLinkedRoleOutput{})
}
