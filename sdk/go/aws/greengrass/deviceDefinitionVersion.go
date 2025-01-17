// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package greengrass

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::Greengrass::DeviceDefinitionVersion
//
// Deprecated: DeviceDefinitionVersion is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type DeviceDefinitionVersion struct {
	pulumi.CustomResourceState

	DeviceDefinitionId pulumi.StringOutput                      `pulumi:"deviceDefinitionId"`
	Devices            DeviceDefinitionVersionDeviceArrayOutput `pulumi:"devices"`
}

// NewDeviceDefinitionVersion registers a new resource with the given unique name, arguments, and options.
func NewDeviceDefinitionVersion(ctx *pulumi.Context,
	name string, args *DeviceDefinitionVersionArgs, opts ...pulumi.ResourceOption) (*DeviceDefinitionVersion, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DeviceDefinitionId == nil {
		return nil, errors.New("invalid value for required argument 'DeviceDefinitionId'")
	}
	if args.Devices == nil {
		return nil, errors.New("invalid value for required argument 'Devices'")
	}
	var resource DeviceDefinitionVersion
	err := ctx.RegisterResource("aws-native:greengrass:DeviceDefinitionVersion", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDeviceDefinitionVersion gets an existing DeviceDefinitionVersion resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDeviceDefinitionVersion(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DeviceDefinitionVersionState, opts ...pulumi.ResourceOption) (*DeviceDefinitionVersion, error) {
	var resource DeviceDefinitionVersion
	err := ctx.ReadResource("aws-native:greengrass:DeviceDefinitionVersion", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DeviceDefinitionVersion resources.
type deviceDefinitionVersionState struct {
}

type DeviceDefinitionVersionState struct {
}

func (DeviceDefinitionVersionState) ElementType() reflect.Type {
	return reflect.TypeOf((*deviceDefinitionVersionState)(nil)).Elem()
}

type deviceDefinitionVersionArgs struct {
	DeviceDefinitionId string                          `pulumi:"deviceDefinitionId"`
	Devices            []DeviceDefinitionVersionDevice `pulumi:"devices"`
}

// The set of arguments for constructing a DeviceDefinitionVersion resource.
type DeviceDefinitionVersionArgs struct {
	DeviceDefinitionId pulumi.StringInput
	Devices            DeviceDefinitionVersionDeviceArrayInput
}

func (DeviceDefinitionVersionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*deviceDefinitionVersionArgs)(nil)).Elem()
}

type DeviceDefinitionVersionInput interface {
	pulumi.Input

	ToDeviceDefinitionVersionOutput() DeviceDefinitionVersionOutput
	ToDeviceDefinitionVersionOutputWithContext(ctx context.Context) DeviceDefinitionVersionOutput
}

func (*DeviceDefinitionVersion) ElementType() reflect.Type {
	return reflect.TypeOf((*DeviceDefinitionVersion)(nil))
}

func (i *DeviceDefinitionVersion) ToDeviceDefinitionVersionOutput() DeviceDefinitionVersionOutput {
	return i.ToDeviceDefinitionVersionOutputWithContext(context.Background())
}

func (i *DeviceDefinitionVersion) ToDeviceDefinitionVersionOutputWithContext(ctx context.Context) DeviceDefinitionVersionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DeviceDefinitionVersionOutput)
}

type DeviceDefinitionVersionOutput struct{ *pulumi.OutputState }

func (DeviceDefinitionVersionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*DeviceDefinitionVersion)(nil))
}

func (o DeviceDefinitionVersionOutput) ToDeviceDefinitionVersionOutput() DeviceDefinitionVersionOutput {
	return o
}

func (o DeviceDefinitionVersionOutput) ToDeviceDefinitionVersionOutputWithContext(ctx context.Context) DeviceDefinitionVersionOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*DeviceDefinitionVersionInput)(nil)).Elem(), &DeviceDefinitionVersion{})
	pulumi.RegisterOutputType(DeviceDefinitionVersionOutput{})
}
