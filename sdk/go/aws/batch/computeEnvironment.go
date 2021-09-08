// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package batch

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html
type ComputeEnvironment struct {
	pulumi.CustomResourceState

	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-computeenvironmentname
	ComputeEnvironmentName pulumi.StringPtrOutput `pulumi:"computeEnvironmentName"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-computeresources
	ComputeResources ComputeEnvironmentComputeResourcesPtrOutput `pulumi:"computeResources"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-servicerole
	ServiceRole pulumi.StringPtrOutput `pulumi:"serviceRole"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-state
	State pulumi.StringPtrOutput `pulumi:"state"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-tags
	Tags pulumi.AnyOutput `pulumi:"tags"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-type
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewComputeEnvironment registers a new resource with the given unique name, arguments, and options.
func NewComputeEnvironment(ctx *pulumi.Context,
	name string, args *ComputeEnvironmentArgs, opts ...pulumi.ResourceOption) (*ComputeEnvironment, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Type == nil {
		return nil, errors.New("invalid value for required argument 'Type'")
	}
	var resource ComputeEnvironment
	err := ctx.RegisterResource("aws-native:batch:ComputeEnvironment", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetComputeEnvironment gets an existing ComputeEnvironment resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetComputeEnvironment(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ComputeEnvironmentState, opts ...pulumi.ResourceOption) (*ComputeEnvironment, error) {
	var resource ComputeEnvironment
	err := ctx.ReadResource("aws-native:batch:ComputeEnvironment", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ComputeEnvironment resources.
type computeEnvironmentState struct {
}

type ComputeEnvironmentState struct {
}

func (ComputeEnvironmentState) ElementType() reflect.Type {
	return reflect.TypeOf((*computeEnvironmentState)(nil)).Elem()
}

type computeEnvironmentArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-computeenvironmentname
	ComputeEnvironmentName *string `pulumi:"computeEnvironmentName"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-computeresources
	ComputeResources *ComputeEnvironmentComputeResources `pulumi:"computeResources"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-servicerole
	ServiceRole *string `pulumi:"serviceRole"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-state
	State *string `pulumi:"state"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-tags
	Tags interface{} `pulumi:"tags"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-type
	Type string `pulumi:"type"`
}

// The set of arguments for constructing a ComputeEnvironment resource.
type ComputeEnvironmentArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-computeenvironmentname
	ComputeEnvironmentName pulumi.StringPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-computeresources
	ComputeResources ComputeEnvironmentComputeResourcesPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-servicerole
	ServiceRole pulumi.StringPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-state
	State pulumi.StringPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-tags
	Tags pulumi.Input
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-type
	Type pulumi.StringInput
}

func (ComputeEnvironmentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*computeEnvironmentArgs)(nil)).Elem()
}

type ComputeEnvironmentInput interface {
	pulumi.Input

	ToComputeEnvironmentOutput() ComputeEnvironmentOutput
	ToComputeEnvironmentOutputWithContext(ctx context.Context) ComputeEnvironmentOutput
}

func (*ComputeEnvironment) ElementType() reflect.Type {
	return reflect.TypeOf((*ComputeEnvironment)(nil))
}

func (i *ComputeEnvironment) ToComputeEnvironmentOutput() ComputeEnvironmentOutput {
	return i.ToComputeEnvironmentOutputWithContext(context.Background())
}

func (i *ComputeEnvironment) ToComputeEnvironmentOutputWithContext(ctx context.Context) ComputeEnvironmentOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ComputeEnvironmentOutput)
}

type ComputeEnvironmentOutput struct{ *pulumi.OutputState }

func (ComputeEnvironmentOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ComputeEnvironment)(nil))
}

func (o ComputeEnvironmentOutput) ToComputeEnvironmentOutput() ComputeEnvironmentOutput {
	return o
}

func (o ComputeEnvironmentOutput) ToComputeEnvironmentOutputWithContext(ctx context.Context) ComputeEnvironmentOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ComputeEnvironmentOutput{})
}