// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ec2

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html
type NetworkAclEntry struct {
	pulumi.CustomResourceState

	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-cidrblock
	CidrBlock pulumi.StringPtrOutput `pulumi:"cidrBlock"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-egress
	Egress pulumi.BoolPtrOutput `pulumi:"egress"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-icmp
	Icmp NetworkAclEntryIcmpPtrOutput `pulumi:"icmp"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-ipv6cidrblock
	Ipv6CidrBlock pulumi.StringPtrOutput `pulumi:"ipv6CidrBlock"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-networkaclid
	NetworkAclId pulumi.StringOutput `pulumi:"networkAclId"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-portrange
	PortRange NetworkAclEntryPortRangePtrOutput `pulumi:"portRange"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-protocol
	Protocol pulumi.IntOutput `pulumi:"protocol"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-ruleaction
	RuleAction pulumi.StringOutput `pulumi:"ruleAction"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-rulenumber
	RuleNumber pulumi.IntOutput `pulumi:"ruleNumber"`
}

// NewNetworkAclEntry registers a new resource with the given unique name, arguments, and options.
func NewNetworkAclEntry(ctx *pulumi.Context,
	name string, args *NetworkAclEntryArgs, opts ...pulumi.ResourceOption) (*NetworkAclEntry, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.NetworkAclId == nil {
		return nil, errors.New("invalid value for required argument 'NetworkAclId'")
	}
	if args.Protocol == nil {
		return nil, errors.New("invalid value for required argument 'Protocol'")
	}
	if args.RuleAction == nil {
		return nil, errors.New("invalid value for required argument 'RuleAction'")
	}
	if args.RuleNumber == nil {
		return nil, errors.New("invalid value for required argument 'RuleNumber'")
	}
	var resource NetworkAclEntry
	err := ctx.RegisterResource("aws-native:ec2:NetworkAclEntry", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetNetworkAclEntry gets an existing NetworkAclEntry resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetNetworkAclEntry(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *NetworkAclEntryState, opts ...pulumi.ResourceOption) (*NetworkAclEntry, error) {
	var resource NetworkAclEntry
	err := ctx.ReadResource("aws-native:ec2:NetworkAclEntry", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering NetworkAclEntry resources.
type networkAclEntryState struct {
}

type NetworkAclEntryState struct {
}

func (NetworkAclEntryState) ElementType() reflect.Type {
	return reflect.TypeOf((*networkAclEntryState)(nil)).Elem()
}

type networkAclEntryArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-cidrblock
	CidrBlock *string `pulumi:"cidrBlock"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-egress
	Egress *bool `pulumi:"egress"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-icmp
	Icmp *NetworkAclEntryIcmp `pulumi:"icmp"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-ipv6cidrblock
	Ipv6CidrBlock *string `pulumi:"ipv6CidrBlock"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-networkaclid
	NetworkAclId string `pulumi:"networkAclId"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-portrange
	PortRange *NetworkAclEntryPortRange `pulumi:"portRange"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-protocol
	Protocol int `pulumi:"protocol"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-ruleaction
	RuleAction string `pulumi:"ruleAction"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-rulenumber
	RuleNumber int `pulumi:"ruleNumber"`
}

// The set of arguments for constructing a NetworkAclEntry resource.
type NetworkAclEntryArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-cidrblock
	CidrBlock pulumi.StringPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-egress
	Egress pulumi.BoolPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-icmp
	Icmp NetworkAclEntryIcmpPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-ipv6cidrblock
	Ipv6CidrBlock pulumi.StringPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-networkaclid
	NetworkAclId pulumi.StringInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-portrange
	PortRange NetworkAclEntryPortRangePtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-protocol
	Protocol pulumi.IntInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-ruleaction
	RuleAction pulumi.StringInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl-entry.html#cfn-ec2-networkaclentry-rulenumber
	RuleNumber pulumi.IntInput
}

func (NetworkAclEntryArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*networkAclEntryArgs)(nil)).Elem()
}

type NetworkAclEntryInput interface {
	pulumi.Input

	ToNetworkAclEntryOutput() NetworkAclEntryOutput
	ToNetworkAclEntryOutputWithContext(ctx context.Context) NetworkAclEntryOutput
}

func (*NetworkAclEntry) ElementType() reflect.Type {
	return reflect.TypeOf((*NetworkAclEntry)(nil))
}

func (i *NetworkAclEntry) ToNetworkAclEntryOutput() NetworkAclEntryOutput {
	return i.ToNetworkAclEntryOutputWithContext(context.Background())
}

func (i *NetworkAclEntry) ToNetworkAclEntryOutputWithContext(ctx context.Context) NetworkAclEntryOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NetworkAclEntryOutput)
}

type NetworkAclEntryOutput struct{ *pulumi.OutputState }

func (NetworkAclEntryOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*NetworkAclEntry)(nil))
}

func (o NetworkAclEntryOutput) ToNetworkAclEntryOutput() NetworkAclEntryOutput {
	return o
}

func (o NetworkAclEntryOutput) ToNetworkAclEntryOutputWithContext(ctx context.Context) NetworkAclEntryOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(NetworkAclEntryOutput{})
}