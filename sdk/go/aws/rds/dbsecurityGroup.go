// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package rds

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi-aws-native/sdk/go/aws"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-security-group.html
type DBSecurityGroup struct {
	pulumi.CustomResourceState

	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-security-group.html#cfn-rds-dbsecuritygroup-dbsecuritygroupingress
	DBSecurityGroupIngress DBSecurityGroupIngressTypeArrayOutput `pulumi:"dBSecurityGroupIngress"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-security-group.html#cfn-rds-dbsecuritygroup-ec2vpcid
	EC2VpcId pulumi.StringPtrOutput `pulumi:"eC2VpcId"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-security-group.html#cfn-rds-dbsecuritygroup-groupdescription
	GroupDescription pulumi.StringOutput `pulumi:"groupDescription"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-security-group.html#cfn-rds-dbsecuritygroup-tags
	Tags aws.TagArrayOutput `pulumi:"tags"`
}

// NewDBSecurityGroup registers a new resource with the given unique name, arguments, and options.
func NewDBSecurityGroup(ctx *pulumi.Context,
	name string, args *DBSecurityGroupArgs, opts ...pulumi.ResourceOption) (*DBSecurityGroup, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DBSecurityGroupIngress == nil {
		return nil, errors.New("invalid value for required argument 'DBSecurityGroupIngress'")
	}
	if args.GroupDescription == nil {
		return nil, errors.New("invalid value for required argument 'GroupDescription'")
	}
	var resource DBSecurityGroup
	err := ctx.RegisterResource("aws-native:rds:DBSecurityGroup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDBSecurityGroup gets an existing DBSecurityGroup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDBSecurityGroup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DBSecurityGroupState, opts ...pulumi.ResourceOption) (*DBSecurityGroup, error) {
	var resource DBSecurityGroup
	err := ctx.ReadResource("aws-native:rds:DBSecurityGroup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DBSecurityGroup resources.
type dbsecurityGroupState struct {
}

type DBSecurityGroupState struct {
}

func (DBSecurityGroupState) ElementType() reflect.Type {
	return reflect.TypeOf((*dbsecurityGroupState)(nil)).Elem()
}

type dbsecurityGroupArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-security-group.html#cfn-rds-dbsecuritygroup-dbsecuritygroupingress
	DBSecurityGroupIngress []DBSecurityGroupIngressType `pulumi:"dBSecurityGroupIngress"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-security-group.html#cfn-rds-dbsecuritygroup-ec2vpcid
	EC2VpcId *string `pulumi:"eC2VpcId"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-security-group.html#cfn-rds-dbsecuritygroup-groupdescription
	GroupDescription string `pulumi:"groupDescription"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-security-group.html#cfn-rds-dbsecuritygroup-tags
	Tags []aws.Tag `pulumi:"tags"`
}

// The set of arguments for constructing a DBSecurityGroup resource.
type DBSecurityGroupArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-security-group.html#cfn-rds-dbsecuritygroup-dbsecuritygroupingress
	DBSecurityGroupIngress DBSecurityGroupIngressTypeArrayInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-security-group.html#cfn-rds-dbsecuritygroup-ec2vpcid
	EC2VpcId pulumi.StringPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-security-group.html#cfn-rds-dbsecuritygroup-groupdescription
	GroupDescription pulumi.StringInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-security-group.html#cfn-rds-dbsecuritygroup-tags
	Tags aws.TagArrayInput
}

func (DBSecurityGroupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*dbsecurityGroupArgs)(nil)).Elem()
}

type DBSecurityGroupInput interface {
	pulumi.Input

	ToDBSecurityGroupOutput() DBSecurityGroupOutput
	ToDBSecurityGroupOutputWithContext(ctx context.Context) DBSecurityGroupOutput
}

func (*DBSecurityGroup) ElementType() reflect.Type {
	return reflect.TypeOf((*DBSecurityGroup)(nil))
}

func (i *DBSecurityGroup) ToDBSecurityGroupOutput() DBSecurityGroupOutput {
	return i.ToDBSecurityGroupOutputWithContext(context.Background())
}

func (i *DBSecurityGroup) ToDBSecurityGroupOutputWithContext(ctx context.Context) DBSecurityGroupOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DBSecurityGroupOutput)
}

type DBSecurityGroupOutput struct{ *pulumi.OutputState }

func (DBSecurityGroupOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*DBSecurityGroup)(nil))
}

func (o DBSecurityGroupOutput) ToDBSecurityGroupOutput() DBSecurityGroupOutput {
	return o
}

func (o DBSecurityGroupOutput) ToDBSecurityGroupOutputWithContext(ctx context.Context) DBSecurityGroupOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(DBSecurityGroupOutput{})
}