// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package servicecatalogappregistry

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalogappregistry-resourceassociation.html
type ResourceAssociation struct {
	pulumi.CustomResourceState

	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalogappregistry-resourceassociation.html#cfn-servicecatalogappregistry-resourceassociation-application
	Application    pulumi.StringOutput `pulumi:"application"`
	ApplicationArn pulumi.StringOutput `pulumi:"applicationArn"`
	Id             pulumi.StringOutput `pulumi:"id"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalogappregistry-resourceassociation.html#cfn-servicecatalogappregistry-resourceassociation-resource
	Resource    pulumi.StringOutput `pulumi:"resource"`
	ResourceArn pulumi.StringOutput `pulumi:"resourceArn"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalogappregistry-resourceassociation.html#cfn-servicecatalogappregistry-resourceassociation-resourcetype
	ResourceType pulumi.StringOutput `pulumi:"resourceType"`
}

// NewResourceAssociation registers a new resource with the given unique name, arguments, and options.
func NewResourceAssociation(ctx *pulumi.Context,
	name string, args *ResourceAssociationArgs, opts ...pulumi.ResourceOption) (*ResourceAssociation, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Application == nil {
		return nil, errors.New("invalid value for required argument 'Application'")
	}
	if args.Resource == nil {
		return nil, errors.New("invalid value for required argument 'Resource'")
	}
	if args.ResourceType == nil {
		return nil, errors.New("invalid value for required argument 'ResourceType'")
	}
	var resource ResourceAssociation
	err := ctx.RegisterResource("aws-native:ServiceCatalogAppRegistry:ResourceAssociation", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetResourceAssociation gets an existing ResourceAssociation resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetResourceAssociation(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ResourceAssociationState, opts ...pulumi.ResourceOption) (*ResourceAssociation, error) {
	var resource ResourceAssociation
	err := ctx.ReadResource("aws-native:ServiceCatalogAppRegistry:ResourceAssociation", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ResourceAssociation resources.
type resourceAssociationState struct {
}

type ResourceAssociationState struct {
}

func (ResourceAssociationState) ElementType() reflect.Type {
	return reflect.TypeOf((*resourceAssociationState)(nil)).Elem()
}

type resourceAssociationArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalogappregistry-resourceassociation.html#cfn-servicecatalogappregistry-resourceassociation-application
	Application string `pulumi:"application"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalogappregistry-resourceassociation.html#cfn-servicecatalogappregistry-resourceassociation-resource
	Resource string `pulumi:"resource"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalogappregistry-resourceassociation.html#cfn-servicecatalogappregistry-resourceassociation-resourcetype
	ResourceType string `pulumi:"resourceType"`
}

// The set of arguments for constructing a ResourceAssociation resource.
type ResourceAssociationArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalogappregistry-resourceassociation.html#cfn-servicecatalogappregistry-resourceassociation-application
	Application pulumi.StringInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalogappregistry-resourceassociation.html#cfn-servicecatalogappregistry-resourceassociation-resource
	Resource pulumi.StringInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalogappregistry-resourceassociation.html#cfn-servicecatalogappregistry-resourceassociation-resourcetype
	ResourceType pulumi.StringInput
}

func (ResourceAssociationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*resourceAssociationArgs)(nil)).Elem()
}

type ResourceAssociationInput interface {
	pulumi.Input

	ToResourceAssociationOutput() ResourceAssociationOutput
	ToResourceAssociationOutputWithContext(ctx context.Context) ResourceAssociationOutput
}

func (*ResourceAssociation) ElementType() reflect.Type {
	return reflect.TypeOf((*ResourceAssociation)(nil))
}

func (i *ResourceAssociation) ToResourceAssociationOutput() ResourceAssociationOutput {
	return i.ToResourceAssociationOutputWithContext(context.Background())
}

func (i *ResourceAssociation) ToResourceAssociationOutputWithContext(ctx context.Context) ResourceAssociationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ResourceAssociationOutput)
}

type ResourceAssociationOutput struct{ *pulumi.OutputState }

func (ResourceAssociationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ResourceAssociation)(nil))
}

func (o ResourceAssociationOutput) ToResourceAssociationOutput() ResourceAssociationOutput {
	return o
}

func (o ResourceAssociationOutput) ToResourceAssociationOutputWithContext(ctx context.Context) ResourceAssociationOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ResourceAssociationOutput{})
}