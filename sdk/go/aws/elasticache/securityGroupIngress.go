// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package elasticache

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-security-group-ingress.html
type SecurityGroupIngress struct {
	pulumi.CustomResourceState

	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-security-group-ingress.html#cfn-elasticache-securitygroupingress-cachesecuritygroupname
	CacheSecurityGroupName pulumi.StringOutput `pulumi:"cacheSecurityGroupName"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-security-group-ingress.html#cfn-elasticache-securitygroupingress-ec2securitygroupname
	EC2SecurityGroupName pulumi.StringOutput `pulumi:"eC2SecurityGroupName"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-security-group-ingress.html#cfn-elasticache-securitygroupingress-ec2securitygroupownerid
	EC2SecurityGroupOwnerId pulumi.StringPtrOutput `pulumi:"eC2SecurityGroupOwnerId"`
}

// NewSecurityGroupIngress registers a new resource with the given unique name, arguments, and options.
func NewSecurityGroupIngress(ctx *pulumi.Context,
	name string, args *SecurityGroupIngressArgs, opts ...pulumi.ResourceOption) (*SecurityGroupIngress, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.CacheSecurityGroupName == nil {
		return nil, errors.New("invalid value for required argument 'CacheSecurityGroupName'")
	}
	if args.EC2SecurityGroupName == nil {
		return nil, errors.New("invalid value for required argument 'EC2SecurityGroupName'")
	}
	var resource SecurityGroupIngress
	err := ctx.RegisterResource("aws-native:elasticache:SecurityGroupIngress", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSecurityGroupIngress gets an existing SecurityGroupIngress resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSecurityGroupIngress(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SecurityGroupIngressState, opts ...pulumi.ResourceOption) (*SecurityGroupIngress, error) {
	var resource SecurityGroupIngress
	err := ctx.ReadResource("aws-native:elasticache:SecurityGroupIngress", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SecurityGroupIngress resources.
type securityGroupIngressState struct {
}

type SecurityGroupIngressState struct {
}

func (SecurityGroupIngressState) ElementType() reflect.Type {
	return reflect.TypeOf((*securityGroupIngressState)(nil)).Elem()
}

type securityGroupIngressArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-security-group-ingress.html#cfn-elasticache-securitygroupingress-cachesecuritygroupname
	CacheSecurityGroupName string `pulumi:"cacheSecurityGroupName"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-security-group-ingress.html#cfn-elasticache-securitygroupingress-ec2securitygroupname
	EC2SecurityGroupName string `pulumi:"eC2SecurityGroupName"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-security-group-ingress.html#cfn-elasticache-securitygroupingress-ec2securitygroupownerid
	EC2SecurityGroupOwnerId *string `pulumi:"eC2SecurityGroupOwnerId"`
}

// The set of arguments for constructing a SecurityGroupIngress resource.
type SecurityGroupIngressArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-security-group-ingress.html#cfn-elasticache-securitygroupingress-cachesecuritygroupname
	CacheSecurityGroupName pulumi.StringInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-security-group-ingress.html#cfn-elasticache-securitygroupingress-ec2securitygroupname
	EC2SecurityGroupName pulumi.StringInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-security-group-ingress.html#cfn-elasticache-securitygroupingress-ec2securitygroupownerid
	EC2SecurityGroupOwnerId pulumi.StringPtrInput
}

func (SecurityGroupIngressArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*securityGroupIngressArgs)(nil)).Elem()
}

type SecurityGroupIngressInput interface {
	pulumi.Input

	ToSecurityGroupIngressOutput() SecurityGroupIngressOutput
	ToSecurityGroupIngressOutputWithContext(ctx context.Context) SecurityGroupIngressOutput
}

func (*SecurityGroupIngress) ElementType() reflect.Type {
	return reflect.TypeOf((*SecurityGroupIngress)(nil))
}

func (i *SecurityGroupIngress) ToSecurityGroupIngressOutput() SecurityGroupIngressOutput {
	return i.ToSecurityGroupIngressOutputWithContext(context.Background())
}

func (i *SecurityGroupIngress) ToSecurityGroupIngressOutputWithContext(ctx context.Context) SecurityGroupIngressOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SecurityGroupIngressOutput)
}

type SecurityGroupIngressOutput struct{ *pulumi.OutputState }

func (SecurityGroupIngressOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SecurityGroupIngress)(nil))
}

func (o SecurityGroupIngressOutput) ToSecurityGroupIngressOutput() SecurityGroupIngressOutput {
	return o
}

func (o SecurityGroupIngressOutput) ToSecurityGroupIngressOutputWithContext(ctx context.Context) SecurityGroupIngressOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(SecurityGroupIngressOutput{})
}