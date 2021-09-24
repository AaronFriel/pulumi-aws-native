// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ec2

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::EC2::VPCEndpointConnectionNotification
//
// Deprecated: VPCEndpointConnectionNotification is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type VPCEndpointConnectionNotification struct {
	pulumi.CustomResourceState

	ConnectionEvents          pulumi.StringArrayOutput `pulumi:"connectionEvents"`
	ConnectionNotificationArn pulumi.StringOutput      `pulumi:"connectionNotificationArn"`
	ServiceId                 pulumi.StringPtrOutput   `pulumi:"serviceId"`
	VPCEndpointId             pulumi.StringPtrOutput   `pulumi:"vPCEndpointId"`
}

// NewVPCEndpointConnectionNotification registers a new resource with the given unique name, arguments, and options.
func NewVPCEndpointConnectionNotification(ctx *pulumi.Context,
	name string, args *VPCEndpointConnectionNotificationArgs, opts ...pulumi.ResourceOption) (*VPCEndpointConnectionNotification, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ConnectionEvents == nil {
		return nil, errors.New("invalid value for required argument 'ConnectionEvents'")
	}
	if args.ConnectionNotificationArn == nil {
		return nil, errors.New("invalid value for required argument 'ConnectionNotificationArn'")
	}
	var resource VPCEndpointConnectionNotification
	err := ctx.RegisterResource("aws-native:ec2:VPCEndpointConnectionNotification", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetVPCEndpointConnectionNotification gets an existing VPCEndpointConnectionNotification resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVPCEndpointConnectionNotification(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *VPCEndpointConnectionNotificationState, opts ...pulumi.ResourceOption) (*VPCEndpointConnectionNotification, error) {
	var resource VPCEndpointConnectionNotification
	err := ctx.ReadResource("aws-native:ec2:VPCEndpointConnectionNotification", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering VPCEndpointConnectionNotification resources.
type vpcendpointConnectionNotificationState struct {
}

type VPCEndpointConnectionNotificationState struct {
}

func (VPCEndpointConnectionNotificationState) ElementType() reflect.Type {
	return reflect.TypeOf((*vpcendpointConnectionNotificationState)(nil)).Elem()
}

type vpcendpointConnectionNotificationArgs struct {
	ConnectionEvents          []string `pulumi:"connectionEvents"`
	ConnectionNotificationArn string   `pulumi:"connectionNotificationArn"`
	ServiceId                 *string  `pulumi:"serviceId"`
	VPCEndpointId             *string  `pulumi:"vPCEndpointId"`
}

// The set of arguments for constructing a VPCEndpointConnectionNotification resource.
type VPCEndpointConnectionNotificationArgs struct {
	ConnectionEvents          pulumi.StringArrayInput
	ConnectionNotificationArn pulumi.StringInput
	ServiceId                 pulumi.StringPtrInput
	VPCEndpointId             pulumi.StringPtrInput
}

func (VPCEndpointConnectionNotificationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*vpcendpointConnectionNotificationArgs)(nil)).Elem()
}

type VPCEndpointConnectionNotificationInput interface {
	pulumi.Input

	ToVPCEndpointConnectionNotificationOutput() VPCEndpointConnectionNotificationOutput
	ToVPCEndpointConnectionNotificationOutputWithContext(ctx context.Context) VPCEndpointConnectionNotificationOutput
}

func (*VPCEndpointConnectionNotification) ElementType() reflect.Type {
	return reflect.TypeOf((*VPCEndpointConnectionNotification)(nil))
}

func (i *VPCEndpointConnectionNotification) ToVPCEndpointConnectionNotificationOutput() VPCEndpointConnectionNotificationOutput {
	return i.ToVPCEndpointConnectionNotificationOutputWithContext(context.Background())
}

func (i *VPCEndpointConnectionNotification) ToVPCEndpointConnectionNotificationOutputWithContext(ctx context.Context) VPCEndpointConnectionNotificationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VPCEndpointConnectionNotificationOutput)
}

type VPCEndpointConnectionNotificationOutput struct{ *pulumi.OutputState }

func (VPCEndpointConnectionNotificationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*VPCEndpointConnectionNotification)(nil))
}

func (o VPCEndpointConnectionNotificationOutput) ToVPCEndpointConnectionNotificationOutput() VPCEndpointConnectionNotificationOutput {
	return o
}

func (o VPCEndpointConnectionNotificationOutput) ToVPCEndpointConnectionNotificationOutputWithContext(ctx context.Context) VPCEndpointConnectionNotificationOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(VPCEndpointConnectionNotificationOutput{})
}
