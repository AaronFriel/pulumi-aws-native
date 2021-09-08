// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ec2

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc-dhcp-options-assoc.html
type VPCDHCPOptionsAssociation struct {
	pulumi.CustomResourceState

	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc-dhcp-options-assoc.html#cfn-ec2-vpcdhcpoptionsassociation-dhcpoptionsid
	DhcpOptionsId pulumi.StringOutput `pulumi:"dhcpOptionsId"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc-dhcp-options-assoc.html#cfn-ec2-vpcdhcpoptionsassociation-vpcid
	VpcId pulumi.StringOutput `pulumi:"vpcId"`
}

// NewVPCDHCPOptionsAssociation registers a new resource with the given unique name, arguments, and options.
func NewVPCDHCPOptionsAssociation(ctx *pulumi.Context,
	name string, args *VPCDHCPOptionsAssociationArgs, opts ...pulumi.ResourceOption) (*VPCDHCPOptionsAssociation, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DhcpOptionsId == nil {
		return nil, errors.New("invalid value for required argument 'DhcpOptionsId'")
	}
	if args.VpcId == nil {
		return nil, errors.New("invalid value for required argument 'VpcId'")
	}
	var resource VPCDHCPOptionsAssociation
	err := ctx.RegisterResource("aws-native:ec2:VPCDHCPOptionsAssociation", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetVPCDHCPOptionsAssociation gets an existing VPCDHCPOptionsAssociation resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVPCDHCPOptionsAssociation(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *VPCDHCPOptionsAssociationState, opts ...pulumi.ResourceOption) (*VPCDHCPOptionsAssociation, error) {
	var resource VPCDHCPOptionsAssociation
	err := ctx.ReadResource("aws-native:ec2:VPCDHCPOptionsAssociation", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering VPCDHCPOptionsAssociation resources.
type vpcdhcpoptionsAssociationState struct {
}

type VPCDHCPOptionsAssociationState struct {
}

func (VPCDHCPOptionsAssociationState) ElementType() reflect.Type {
	return reflect.TypeOf((*vpcdhcpoptionsAssociationState)(nil)).Elem()
}

type vpcdhcpoptionsAssociationArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc-dhcp-options-assoc.html#cfn-ec2-vpcdhcpoptionsassociation-dhcpoptionsid
	DhcpOptionsId string `pulumi:"dhcpOptionsId"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc-dhcp-options-assoc.html#cfn-ec2-vpcdhcpoptionsassociation-vpcid
	VpcId string `pulumi:"vpcId"`
}

// The set of arguments for constructing a VPCDHCPOptionsAssociation resource.
type VPCDHCPOptionsAssociationArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc-dhcp-options-assoc.html#cfn-ec2-vpcdhcpoptionsassociation-dhcpoptionsid
	DhcpOptionsId pulumi.StringInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc-dhcp-options-assoc.html#cfn-ec2-vpcdhcpoptionsassociation-vpcid
	VpcId pulumi.StringInput
}

func (VPCDHCPOptionsAssociationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*vpcdhcpoptionsAssociationArgs)(nil)).Elem()
}

type VPCDHCPOptionsAssociationInput interface {
	pulumi.Input

	ToVPCDHCPOptionsAssociationOutput() VPCDHCPOptionsAssociationOutput
	ToVPCDHCPOptionsAssociationOutputWithContext(ctx context.Context) VPCDHCPOptionsAssociationOutput
}

func (*VPCDHCPOptionsAssociation) ElementType() reflect.Type {
	return reflect.TypeOf((*VPCDHCPOptionsAssociation)(nil))
}

func (i *VPCDHCPOptionsAssociation) ToVPCDHCPOptionsAssociationOutput() VPCDHCPOptionsAssociationOutput {
	return i.ToVPCDHCPOptionsAssociationOutputWithContext(context.Background())
}

func (i *VPCDHCPOptionsAssociation) ToVPCDHCPOptionsAssociationOutputWithContext(ctx context.Context) VPCDHCPOptionsAssociationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VPCDHCPOptionsAssociationOutput)
}

type VPCDHCPOptionsAssociationOutput struct{ *pulumi.OutputState }

func (VPCDHCPOptionsAssociationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*VPCDHCPOptionsAssociation)(nil))
}

func (o VPCDHCPOptionsAssociationOutput) ToVPCDHCPOptionsAssociationOutput() VPCDHCPOptionsAssociationOutput {
	return o
}

func (o VPCDHCPOptionsAssociationOutput) ToVPCDHCPOptionsAssociationOutputWithContext(ctx context.Context) VPCDHCPOptionsAssociationOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(VPCDHCPOptionsAssociationOutput{})
}