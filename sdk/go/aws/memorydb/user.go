// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package memorydb

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::MemoryDB::User
//
// Deprecated: User is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type User struct {
	pulumi.CustomResourceState

	// Access permissions string used for this user account.
	AccessString pulumi.StringOutput `pulumi:"accessString"`
	// The Amazon Resource Name (ARN) of the user account.
	Arn                pulumi.StringOutput                `pulumi:"arn"`
	AuthenticationMode AuthenticationModePropertiesOutput `pulumi:"authenticationMode"`
	// Indicates the user status. Can be "active", "modifying" or "deleting".
	Status pulumi.StringOutput `pulumi:"status"`
	// An array of key-value pairs to apply to this user.
	Tags UserTagArrayOutput `pulumi:"tags"`
	// The name of the user.
	UserName pulumi.StringOutput `pulumi:"userName"`
}

// NewUser registers a new resource with the given unique name, arguments, and options.
func NewUser(ctx *pulumi.Context,
	name string, args *UserArgs, opts ...pulumi.ResourceOption) (*User, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AccessString == nil {
		return nil, errors.New("invalid value for required argument 'AccessString'")
	}
	if args.AuthenticationMode == nil {
		return nil, errors.New("invalid value for required argument 'AuthenticationMode'")
	}
	if args.UserName == nil {
		return nil, errors.New("invalid value for required argument 'UserName'")
	}
	var resource User
	err := ctx.RegisterResource("aws-native:memorydb:User", name, args, &resource, opts...)
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
	err := ctx.ReadResource("aws-native:memorydb:User", name, id, state, &resource, opts...)
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
	// Access permissions string used for this user account.
	AccessString       string                       `pulumi:"accessString"`
	AuthenticationMode AuthenticationModeProperties `pulumi:"authenticationMode"`
	// An array of key-value pairs to apply to this user.
	Tags []UserTag `pulumi:"tags"`
	// The name of the user.
	UserName string `pulumi:"userName"`
}

// The set of arguments for constructing a User resource.
type UserArgs struct {
	// Access permissions string used for this user account.
	AccessString       pulumi.StringInput
	AuthenticationMode AuthenticationModePropertiesInput
	// An array of key-value pairs to apply to this user.
	Tags UserTagArrayInput
	// The name of the user.
	UserName pulumi.StringInput
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
