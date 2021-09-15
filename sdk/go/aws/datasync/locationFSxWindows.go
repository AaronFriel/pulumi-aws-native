// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package datasync

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource schema for AWS::DataSync::LocationFSxWindows.
type LocationFSxWindows struct {
	pulumi.CustomResourceState

	// The name of the Windows domain that the FSx for Windows server belongs to.
	Domain pulumi.StringPtrOutput `pulumi:"domain"`
	// The Amazon Resource Name (ARN) for the FSx for Windows file system.
	FsxFilesystemArn pulumi.StringOutput `pulumi:"fsxFilesystemArn"`
	// The Amazon Resource Name (ARN) of the Amazon FSx for Windows file system location that is created.
	LocationArn pulumi.StringOutput `pulumi:"locationArn"`
	// The URL of the FSx for Windows location that was described.
	LocationUri pulumi.StringOutput `pulumi:"locationUri"`
	// The password of the user who has the permissions to access files and folders in the FSx for Windows file system.
	Password pulumi.StringOutput `pulumi:"password"`
	// The ARNs of the security groups that are to use to configure the FSx for Windows file system.
	SecurityGroupArns pulumi.StringArrayOutput `pulumi:"securityGroupArns"`
	// A subdirectory in the location's path.
	Subdirectory pulumi.StringPtrOutput `pulumi:"subdirectory"`
	// An array of key-value pairs to apply to this resource.
	Tags LocationFSxWindowsTagArrayOutput `pulumi:"tags"`
	// The user who has the permissions to access files and folders in the FSx for Windows file system.
	User pulumi.StringOutput `pulumi:"user"`
}

// NewLocationFSxWindows registers a new resource with the given unique name, arguments, and options.
func NewLocationFSxWindows(ctx *pulumi.Context,
	name string, args *LocationFSxWindowsArgs, opts ...pulumi.ResourceOption) (*LocationFSxWindows, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.FsxFilesystemArn == nil {
		return nil, errors.New("invalid value for required argument 'FsxFilesystemArn'")
	}
	if args.Password == nil {
		return nil, errors.New("invalid value for required argument 'Password'")
	}
	if args.SecurityGroupArns == nil {
		return nil, errors.New("invalid value for required argument 'SecurityGroupArns'")
	}
	if args.User == nil {
		return nil, errors.New("invalid value for required argument 'User'")
	}
	var resource LocationFSxWindows
	err := ctx.RegisterResource("aws-native:datasync:LocationFSxWindows", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetLocationFSxWindows gets an existing LocationFSxWindows resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetLocationFSxWindows(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *LocationFSxWindowsState, opts ...pulumi.ResourceOption) (*LocationFSxWindows, error) {
	var resource LocationFSxWindows
	err := ctx.ReadResource("aws-native:datasync:LocationFSxWindows", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering LocationFSxWindows resources.
type locationFSxWindowsState struct {
}

type LocationFSxWindowsState struct {
}

func (LocationFSxWindowsState) ElementType() reflect.Type {
	return reflect.TypeOf((*locationFSxWindowsState)(nil)).Elem()
}

type locationFSxWindowsArgs struct {
	// The name of the Windows domain that the FSx for Windows server belongs to.
	Domain *string `pulumi:"domain"`
	// The Amazon Resource Name (ARN) for the FSx for Windows file system.
	FsxFilesystemArn string `pulumi:"fsxFilesystemArn"`
	// The password of the user who has the permissions to access files and folders in the FSx for Windows file system.
	Password string `pulumi:"password"`
	// The ARNs of the security groups that are to use to configure the FSx for Windows file system.
	SecurityGroupArns []string `pulumi:"securityGroupArns"`
	// A subdirectory in the location's path.
	Subdirectory *string `pulumi:"subdirectory"`
	// An array of key-value pairs to apply to this resource.
	Tags []LocationFSxWindowsTag `pulumi:"tags"`
	// The user who has the permissions to access files and folders in the FSx for Windows file system.
	User string `pulumi:"user"`
}

// The set of arguments for constructing a LocationFSxWindows resource.
type LocationFSxWindowsArgs struct {
	// The name of the Windows domain that the FSx for Windows server belongs to.
	Domain pulumi.StringPtrInput
	// The Amazon Resource Name (ARN) for the FSx for Windows file system.
	FsxFilesystemArn pulumi.StringInput
	// The password of the user who has the permissions to access files and folders in the FSx for Windows file system.
	Password pulumi.StringInput
	// The ARNs of the security groups that are to use to configure the FSx for Windows file system.
	SecurityGroupArns pulumi.StringArrayInput
	// A subdirectory in the location's path.
	Subdirectory pulumi.StringPtrInput
	// An array of key-value pairs to apply to this resource.
	Tags LocationFSxWindowsTagArrayInput
	// The user who has the permissions to access files and folders in the FSx for Windows file system.
	User pulumi.StringInput
}

func (LocationFSxWindowsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*locationFSxWindowsArgs)(nil)).Elem()
}

type LocationFSxWindowsInput interface {
	pulumi.Input

	ToLocationFSxWindowsOutput() LocationFSxWindowsOutput
	ToLocationFSxWindowsOutputWithContext(ctx context.Context) LocationFSxWindowsOutput
}

func (*LocationFSxWindows) ElementType() reflect.Type {
	return reflect.TypeOf((*LocationFSxWindows)(nil))
}

func (i *LocationFSxWindows) ToLocationFSxWindowsOutput() LocationFSxWindowsOutput {
	return i.ToLocationFSxWindowsOutputWithContext(context.Background())
}

func (i *LocationFSxWindows) ToLocationFSxWindowsOutputWithContext(ctx context.Context) LocationFSxWindowsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LocationFSxWindowsOutput)
}

type LocationFSxWindowsOutput struct{ *pulumi.OutputState }

func (LocationFSxWindowsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LocationFSxWindows)(nil))
}

func (o LocationFSxWindowsOutput) ToLocationFSxWindowsOutput() LocationFSxWindowsOutput {
	return o
}

func (o LocationFSxWindowsOutput) ToLocationFSxWindowsOutputWithContext(ctx context.Context) LocationFSxWindowsOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(LocationFSxWindowsOutput{})
}
