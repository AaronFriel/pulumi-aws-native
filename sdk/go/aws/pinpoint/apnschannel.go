// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package pinpoint

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::Pinpoint::APNSChannel
//
// Deprecated: APNSChannel is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type APNSChannel struct {
	pulumi.CustomResourceState

	ApplicationId               pulumi.StringOutput    `pulumi:"applicationId"`
	BundleId                    pulumi.StringPtrOutput `pulumi:"bundleId"`
	Certificate                 pulumi.StringPtrOutput `pulumi:"certificate"`
	DefaultAuthenticationMethod pulumi.StringPtrOutput `pulumi:"defaultAuthenticationMethod"`
	Enabled                     pulumi.BoolPtrOutput   `pulumi:"enabled"`
	PrivateKey                  pulumi.StringPtrOutput `pulumi:"privateKey"`
	TeamId                      pulumi.StringPtrOutput `pulumi:"teamId"`
	TokenKey                    pulumi.StringPtrOutput `pulumi:"tokenKey"`
	TokenKeyId                  pulumi.StringPtrOutput `pulumi:"tokenKeyId"`
}

// NewAPNSChannel registers a new resource with the given unique name, arguments, and options.
func NewAPNSChannel(ctx *pulumi.Context,
	name string, args *APNSChannelArgs, opts ...pulumi.ResourceOption) (*APNSChannel, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ApplicationId == nil {
		return nil, errors.New("invalid value for required argument 'ApplicationId'")
	}
	var resource APNSChannel
	err := ctx.RegisterResource("aws-native:pinpoint:APNSChannel", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAPNSChannel gets an existing APNSChannel resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAPNSChannel(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *APNSChannelState, opts ...pulumi.ResourceOption) (*APNSChannel, error) {
	var resource APNSChannel
	err := ctx.ReadResource("aws-native:pinpoint:APNSChannel", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering APNSChannel resources.
type apnschannelState struct {
}

type APNSChannelState struct {
}

func (APNSChannelState) ElementType() reflect.Type {
	return reflect.TypeOf((*apnschannelState)(nil)).Elem()
}

type apnschannelArgs struct {
	ApplicationId               string  `pulumi:"applicationId"`
	BundleId                    *string `pulumi:"bundleId"`
	Certificate                 *string `pulumi:"certificate"`
	DefaultAuthenticationMethod *string `pulumi:"defaultAuthenticationMethod"`
	Enabled                     *bool   `pulumi:"enabled"`
	PrivateKey                  *string `pulumi:"privateKey"`
	TeamId                      *string `pulumi:"teamId"`
	TokenKey                    *string `pulumi:"tokenKey"`
	TokenKeyId                  *string `pulumi:"tokenKeyId"`
}

// The set of arguments for constructing a APNSChannel resource.
type APNSChannelArgs struct {
	ApplicationId               pulumi.StringInput
	BundleId                    pulumi.StringPtrInput
	Certificate                 pulumi.StringPtrInput
	DefaultAuthenticationMethod pulumi.StringPtrInput
	Enabled                     pulumi.BoolPtrInput
	PrivateKey                  pulumi.StringPtrInput
	TeamId                      pulumi.StringPtrInput
	TokenKey                    pulumi.StringPtrInput
	TokenKeyId                  pulumi.StringPtrInput
}

func (APNSChannelArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*apnschannelArgs)(nil)).Elem()
}

type APNSChannelInput interface {
	pulumi.Input

	ToAPNSChannelOutput() APNSChannelOutput
	ToAPNSChannelOutputWithContext(ctx context.Context) APNSChannelOutput
}

func (*APNSChannel) ElementType() reflect.Type {
	return reflect.TypeOf((*APNSChannel)(nil))
}

func (i *APNSChannel) ToAPNSChannelOutput() APNSChannelOutput {
	return i.ToAPNSChannelOutputWithContext(context.Background())
}

func (i *APNSChannel) ToAPNSChannelOutputWithContext(ctx context.Context) APNSChannelOutput {
	return pulumi.ToOutputWithContext(ctx, i).(APNSChannelOutput)
}

type APNSChannelOutput struct{ *pulumi.OutputState }

func (APNSChannelOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*APNSChannel)(nil))
}

func (o APNSChannelOutput) ToAPNSChannelOutput() APNSChannelOutput {
	return o
}

func (o APNSChannelOutput) ToAPNSChannelOutputWithContext(ctx context.Context) APNSChannelOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(APNSChannelOutput{})
}
