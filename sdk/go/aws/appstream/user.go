// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package appstream

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::AppStream::User
//
// Deprecated: User is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type User struct {
	pulumi.CustomResourceState

	AuthenticationType pulumi.StringOutput    `pulumi:"authenticationType"`
	FirstName          pulumi.StringPtrOutput `pulumi:"firstName"`
	LastName           pulumi.StringPtrOutput `pulumi:"lastName"`
	MessageAction      pulumi.StringPtrOutput `pulumi:"messageAction"`
	UserName           pulumi.StringOutput    `pulumi:"userName"`
}

// NewUser registers a new resource with the given unique name, arguments, and options.
func NewUser(ctx *pulumi.Context,
	name string, args *UserArgs, opts ...pulumi.ResourceOption) (*User, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AuthenticationType == nil {
		return nil, errors.New("invalid value for required argument 'AuthenticationType'")
	}
	if args.UserName == nil {
		return nil, errors.New("invalid value for required argument 'UserName'")
	}
	var resource User
	err := ctx.RegisterResource("aws-native:appstream:User", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetUser gets an existing User resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetUser(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *UserState, opts ...pulumi.ResourceOption) (*User, error) {
	var resource User
	err := ctx.ReadResource("aws-native:appstream:User", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering User resources.
type userState struct {
}

type UserState struct {
}

func (UserState) ElementType() reflect.Type {
	return reflect.TypeOf((*userState)(nil)).Elem()
}

type userArgs struct {
	AuthenticationType string  `pulumi:"authenticationType"`
	FirstName          *string `pulumi:"firstName"`
	LastName           *string `pulumi:"lastName"`
	MessageAction      *string `pulumi:"messageAction"`
	UserName           string  `pulumi:"userName"`
}

// The set of arguments for constructing a User resource.
type UserArgs struct {
	AuthenticationType pulumi.StringInput
	FirstName          pulumi.StringPtrInput
	LastName           pulumi.StringPtrInput
	MessageAction      pulumi.StringPtrInput
	UserName           pulumi.StringInput
}

func (UserArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*userArgs)(nil)).Elem()
}

type UserInput interface {
	pulumi.Input

	ToUserOutput() UserOutput
	ToUserOutputWithContext(ctx context.Context) UserOutput
}

func (*User) ElementType() reflect.Type {
	return reflect.TypeOf((*User)(nil))
}

func (i *User) ToUserOutput() UserOutput {
	return i.ToUserOutputWithContext(context.Background())
}

func (i *User) ToUserOutputWithContext(ctx context.Context) UserOutput {
	return pulumi.ToOutputWithContext(ctx, i).(UserOutput)
}

type UserOutput struct{ *pulumi.OutputState }

func (UserOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*User)(nil))
}

func (o UserOutput) ToUserOutput() UserOutput {
	return o
}

func (o UserOutput) ToUserOutputWithContext(ctx context.Context) UserOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(UserOutput{})
}
