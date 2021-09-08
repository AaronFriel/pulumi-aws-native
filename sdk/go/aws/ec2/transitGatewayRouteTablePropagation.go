// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ec2

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayroutetablepropagation.html
type TransitGatewayRouteTablePropagation struct {
	pulumi.CustomResourceState

	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayroutetablepropagation.html#cfn-ec2-transitgatewayroutetablepropagation-transitgatewayattachmentid
	TransitGatewayAttachmentId pulumi.StringOutput `pulumi:"transitGatewayAttachmentId"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayroutetablepropagation.html#cfn-ec2-transitgatewayroutetablepropagation-transitgatewayroutetableid
	TransitGatewayRouteTableId pulumi.StringOutput `pulumi:"transitGatewayRouteTableId"`
}

// NewTransitGatewayRouteTablePropagation registers a new resource with the given unique name, arguments, and options.
func NewTransitGatewayRouteTablePropagation(ctx *pulumi.Context,
	name string, args *TransitGatewayRouteTablePropagationArgs, opts ...pulumi.ResourceOption) (*TransitGatewayRouteTablePropagation, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.TransitGatewayAttachmentId == nil {
		return nil, errors.New("invalid value for required argument 'TransitGatewayAttachmentId'")
	}
	if args.TransitGatewayRouteTableId == nil {
		return nil, errors.New("invalid value for required argument 'TransitGatewayRouteTableId'")
	}
	var resource TransitGatewayRouteTablePropagation
	err := ctx.RegisterResource("aws-native:ec2:TransitGatewayRouteTablePropagation", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetTransitGatewayRouteTablePropagation gets an existing TransitGatewayRouteTablePropagation resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTransitGatewayRouteTablePropagation(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TransitGatewayRouteTablePropagationState, opts ...pulumi.ResourceOption) (*TransitGatewayRouteTablePropagation, error) {
	var resource TransitGatewayRouteTablePropagation
	err := ctx.ReadResource("aws-native:ec2:TransitGatewayRouteTablePropagation", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering TransitGatewayRouteTablePropagation resources.
type transitGatewayRouteTablePropagationState struct {
}

type TransitGatewayRouteTablePropagationState struct {
}

func (TransitGatewayRouteTablePropagationState) ElementType() reflect.Type {
	return reflect.TypeOf((*transitGatewayRouteTablePropagationState)(nil)).Elem()
}

type transitGatewayRouteTablePropagationArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayroutetablepropagation.html#cfn-ec2-transitgatewayroutetablepropagation-transitgatewayattachmentid
	TransitGatewayAttachmentId string `pulumi:"transitGatewayAttachmentId"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayroutetablepropagation.html#cfn-ec2-transitgatewayroutetablepropagation-transitgatewayroutetableid
	TransitGatewayRouteTableId string `pulumi:"transitGatewayRouteTableId"`
}

// The set of arguments for constructing a TransitGatewayRouteTablePropagation resource.
type TransitGatewayRouteTablePropagationArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayroutetablepropagation.html#cfn-ec2-transitgatewayroutetablepropagation-transitgatewayattachmentid
	TransitGatewayAttachmentId pulumi.StringInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayroutetablepropagation.html#cfn-ec2-transitgatewayroutetablepropagation-transitgatewayroutetableid
	TransitGatewayRouteTableId pulumi.StringInput
}

func (TransitGatewayRouteTablePropagationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*transitGatewayRouteTablePropagationArgs)(nil)).Elem()
}

type TransitGatewayRouteTablePropagationInput interface {
	pulumi.Input

	ToTransitGatewayRouteTablePropagationOutput() TransitGatewayRouteTablePropagationOutput
	ToTransitGatewayRouteTablePropagationOutputWithContext(ctx context.Context) TransitGatewayRouteTablePropagationOutput
}

func (*TransitGatewayRouteTablePropagation) ElementType() reflect.Type {
	return reflect.TypeOf((*TransitGatewayRouteTablePropagation)(nil))
}

func (i *TransitGatewayRouteTablePropagation) ToTransitGatewayRouteTablePropagationOutput() TransitGatewayRouteTablePropagationOutput {
	return i.ToTransitGatewayRouteTablePropagationOutputWithContext(context.Background())
}

func (i *TransitGatewayRouteTablePropagation) ToTransitGatewayRouteTablePropagationOutputWithContext(ctx context.Context) TransitGatewayRouteTablePropagationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TransitGatewayRouteTablePropagationOutput)
}

type TransitGatewayRouteTablePropagationOutput struct{ *pulumi.OutputState }

func (TransitGatewayRouteTablePropagationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*TransitGatewayRouteTablePropagation)(nil))
}

func (o TransitGatewayRouteTablePropagationOutput) ToTransitGatewayRouteTablePropagationOutput() TransitGatewayRouteTablePropagationOutput {
	return o
}

func (o TransitGatewayRouteTablePropagationOutput) ToTransitGatewayRouteTablePropagationOutputWithContext(ctx context.Context) TransitGatewayRouteTablePropagationOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(TransitGatewayRouteTablePropagationOutput{})
}