// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ec2

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi-aws-native/sdk/go/aws"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypeeringattachment.html
type TransitGatewayPeeringAttachment struct {
	pulumi.CustomResourceState

	CreationTime pulumi.StringOutput `pulumi:"creationTime"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypeeringattachment.html#cfn-ec2-transitgatewaypeeringattachment-peeraccountid
	PeerAccountId pulumi.StringOutput `pulumi:"peerAccountId"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypeeringattachment.html#cfn-ec2-transitgatewaypeeringattachment-peerregion
	PeerRegion pulumi.StringOutput `pulumi:"peerRegion"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypeeringattachment.html#cfn-ec2-transitgatewaypeeringattachment-peertransitgatewayid
	PeerTransitGatewayId pulumi.StringOutput `pulumi:"peerTransitGatewayId"`
	State                pulumi.StringOutput `pulumi:"state"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypeeringattachment.html#cfn-ec2-transitgatewaypeeringattachment-tags
	Tags                       aws.TagArrayOutput  `pulumi:"tags"`
	TransitGatewayAttachmentId pulumi.StringOutput `pulumi:"transitGatewayAttachmentId"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypeeringattachment.html#cfn-ec2-transitgatewaypeeringattachment-transitgatewayid
	TransitGatewayId pulumi.StringOutput `pulumi:"transitGatewayId"`
}

// NewTransitGatewayPeeringAttachment registers a new resource with the given unique name, arguments, and options.
func NewTransitGatewayPeeringAttachment(ctx *pulumi.Context,
	name string, args *TransitGatewayPeeringAttachmentArgs, opts ...pulumi.ResourceOption) (*TransitGatewayPeeringAttachment, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.PeerAccountId == nil {
		return nil, errors.New("invalid value for required argument 'PeerAccountId'")
	}
	if args.PeerRegion == nil {
		return nil, errors.New("invalid value for required argument 'PeerRegion'")
	}
	if args.PeerTransitGatewayId == nil {
		return nil, errors.New("invalid value for required argument 'PeerTransitGatewayId'")
	}
	if args.TransitGatewayId == nil {
		return nil, errors.New("invalid value for required argument 'TransitGatewayId'")
	}
	var resource TransitGatewayPeeringAttachment
	err := ctx.RegisterResource("aws-native:EC2:TransitGatewayPeeringAttachment", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetTransitGatewayPeeringAttachment gets an existing TransitGatewayPeeringAttachment resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTransitGatewayPeeringAttachment(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TransitGatewayPeeringAttachmentState, opts ...pulumi.ResourceOption) (*TransitGatewayPeeringAttachment, error) {
	var resource TransitGatewayPeeringAttachment
	err := ctx.ReadResource("aws-native:EC2:TransitGatewayPeeringAttachment", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering TransitGatewayPeeringAttachment resources.
type transitGatewayPeeringAttachmentState struct {
}

type TransitGatewayPeeringAttachmentState struct {
}

func (TransitGatewayPeeringAttachmentState) ElementType() reflect.Type {
	return reflect.TypeOf((*transitGatewayPeeringAttachmentState)(nil)).Elem()
}

type transitGatewayPeeringAttachmentArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypeeringattachment.html#cfn-ec2-transitgatewaypeeringattachment-peeraccountid
	PeerAccountId string `pulumi:"peerAccountId"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypeeringattachment.html#cfn-ec2-transitgatewaypeeringattachment-peerregion
	PeerRegion string `pulumi:"peerRegion"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypeeringattachment.html#cfn-ec2-transitgatewaypeeringattachment-peertransitgatewayid
	PeerTransitGatewayId string `pulumi:"peerTransitGatewayId"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypeeringattachment.html#cfn-ec2-transitgatewaypeeringattachment-tags
	Tags []aws.Tag `pulumi:"tags"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypeeringattachment.html#cfn-ec2-transitgatewaypeeringattachment-transitgatewayid
	TransitGatewayId string `pulumi:"transitGatewayId"`
}

// The set of arguments for constructing a TransitGatewayPeeringAttachment resource.
type TransitGatewayPeeringAttachmentArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypeeringattachment.html#cfn-ec2-transitgatewaypeeringattachment-peeraccountid
	PeerAccountId pulumi.StringInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypeeringattachment.html#cfn-ec2-transitgatewaypeeringattachment-peerregion
	PeerRegion pulumi.StringInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypeeringattachment.html#cfn-ec2-transitgatewaypeeringattachment-peertransitgatewayid
	PeerTransitGatewayId pulumi.StringInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypeeringattachment.html#cfn-ec2-transitgatewaypeeringattachment-tags
	Tags aws.TagArrayInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypeeringattachment.html#cfn-ec2-transitgatewaypeeringattachment-transitgatewayid
	TransitGatewayId pulumi.StringInput
}

func (TransitGatewayPeeringAttachmentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*transitGatewayPeeringAttachmentArgs)(nil)).Elem()
}

type TransitGatewayPeeringAttachmentInput interface {
	pulumi.Input

	ToTransitGatewayPeeringAttachmentOutput() TransitGatewayPeeringAttachmentOutput
	ToTransitGatewayPeeringAttachmentOutputWithContext(ctx context.Context) TransitGatewayPeeringAttachmentOutput
}

func (*TransitGatewayPeeringAttachment) ElementType() reflect.Type {
	return reflect.TypeOf((*TransitGatewayPeeringAttachment)(nil))
}

func (i *TransitGatewayPeeringAttachment) ToTransitGatewayPeeringAttachmentOutput() TransitGatewayPeeringAttachmentOutput {
	return i.ToTransitGatewayPeeringAttachmentOutputWithContext(context.Background())
}

func (i *TransitGatewayPeeringAttachment) ToTransitGatewayPeeringAttachmentOutputWithContext(ctx context.Context) TransitGatewayPeeringAttachmentOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TransitGatewayPeeringAttachmentOutput)
}

type TransitGatewayPeeringAttachmentOutput struct{ *pulumi.OutputState }

func (TransitGatewayPeeringAttachmentOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*TransitGatewayPeeringAttachment)(nil))
}

func (o TransitGatewayPeeringAttachmentOutput) ToTransitGatewayPeeringAttachmentOutput() TransitGatewayPeeringAttachmentOutput {
	return o
}

func (o TransitGatewayPeeringAttachmentOutput) ToTransitGatewayPeeringAttachmentOutputWithContext(ctx context.Context) TransitGatewayPeeringAttachmentOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(TransitGatewayPeeringAttachmentOutput{})
}