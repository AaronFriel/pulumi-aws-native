// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package servicecatalog

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Schema for AWS::ServiceCatalog::CloudFormationProvisionedProduct
type CloudFormationProvisionedProduct struct {
	pulumi.CustomResourceState

	AcceptLanguage         CloudFormationProvisionedProductAcceptLanguagePtrOutput `pulumi:"acceptLanguage"`
	CloudformationStackArn pulumi.StringOutput                                     `pulumi:"cloudformationStackArn"`
	NotificationArns       pulumi.StringArrayOutput                                `pulumi:"notificationArns"`
	// List of key-value pair outputs.
	Outputs                  pulumi.AnyOutput                                                 `pulumi:"outputs"`
	PathId                   pulumi.StringPtrOutput                                           `pulumi:"pathId"`
	PathName                 pulumi.StringPtrOutput                                           `pulumi:"pathName"`
	ProductId                pulumi.StringPtrOutput                                           `pulumi:"productId"`
	ProductName              pulumi.StringPtrOutput                                           `pulumi:"productName"`
	ProvisionedProductId     pulumi.StringOutput                                              `pulumi:"provisionedProductId"`
	ProvisionedProductName   pulumi.StringPtrOutput                                           `pulumi:"provisionedProductName"`
	ProvisioningArtifactId   pulumi.StringPtrOutput                                           `pulumi:"provisioningArtifactId"`
	ProvisioningArtifactName pulumi.StringPtrOutput                                           `pulumi:"provisioningArtifactName"`
	ProvisioningParameters   CloudFormationProvisionedProductProvisioningParameterArrayOutput `pulumi:"provisioningParameters"`
	ProvisioningPreferences  CloudFormationProvisionedProductProvisioningPreferencesPtrOutput `pulumi:"provisioningPreferences"`
	RecordId                 pulumi.StringOutput                                              `pulumi:"recordId"`
	Tags                     CloudFormationProvisionedProductTagArrayOutput                   `pulumi:"tags"`
}

// NewCloudFormationProvisionedProduct registers a new resource with the given unique name, arguments, and options.
func NewCloudFormationProvisionedProduct(ctx *pulumi.Context,
	name string, args *CloudFormationProvisionedProductArgs, opts ...pulumi.ResourceOption) (*CloudFormationProvisionedProduct, error) {
	if args == nil {
		args = &CloudFormationProvisionedProductArgs{}
	}

	var resource CloudFormationProvisionedProduct
	err := ctx.RegisterResource("aws-native:servicecatalog:CloudFormationProvisionedProduct", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCloudFormationProvisionedProduct gets an existing CloudFormationProvisionedProduct resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCloudFormationProvisionedProduct(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CloudFormationProvisionedProductState, opts ...pulumi.ResourceOption) (*CloudFormationProvisionedProduct, error) {
	var resource CloudFormationProvisionedProduct
	err := ctx.ReadResource("aws-native:servicecatalog:CloudFormationProvisionedProduct", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering CloudFormationProvisionedProduct resources.
type cloudFormationProvisionedProductState struct {
}

type CloudFormationProvisionedProductState struct {
}

func (CloudFormationProvisionedProductState) ElementType() reflect.Type {
	return reflect.TypeOf((*cloudFormationProvisionedProductState)(nil)).Elem()
}

type cloudFormationProvisionedProductArgs struct {
	AcceptLanguage           *CloudFormationProvisionedProductAcceptLanguage          `pulumi:"acceptLanguage"`
	NotificationArns         []string                                                 `pulumi:"notificationArns"`
	PathId                   *string                                                  `pulumi:"pathId"`
	PathName                 *string                                                  `pulumi:"pathName"`
	ProductId                *string                                                  `pulumi:"productId"`
	ProductName              *string                                                  `pulumi:"productName"`
	ProvisionedProductName   *string                                                  `pulumi:"provisionedProductName"`
	ProvisioningArtifactId   *string                                                  `pulumi:"provisioningArtifactId"`
	ProvisioningArtifactName *string                                                  `pulumi:"provisioningArtifactName"`
	ProvisioningParameters   []CloudFormationProvisionedProductProvisioningParameter  `pulumi:"provisioningParameters"`
	ProvisioningPreferences  *CloudFormationProvisionedProductProvisioningPreferences `pulumi:"provisioningPreferences"`
	Tags                     []CloudFormationProvisionedProductTag                    `pulumi:"tags"`
}

// The set of arguments for constructing a CloudFormationProvisionedProduct resource.
type CloudFormationProvisionedProductArgs struct {
	AcceptLanguage           CloudFormationProvisionedProductAcceptLanguagePtrInput
	NotificationArns         pulumi.StringArrayInput
	PathId                   pulumi.StringPtrInput
	PathName                 pulumi.StringPtrInput
	ProductId                pulumi.StringPtrInput
	ProductName              pulumi.StringPtrInput
	ProvisionedProductName   pulumi.StringPtrInput
	ProvisioningArtifactId   pulumi.StringPtrInput
	ProvisioningArtifactName pulumi.StringPtrInput
	ProvisioningParameters   CloudFormationProvisionedProductProvisioningParameterArrayInput
	ProvisioningPreferences  CloudFormationProvisionedProductProvisioningPreferencesPtrInput
	Tags                     CloudFormationProvisionedProductTagArrayInput
}

func (CloudFormationProvisionedProductArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*cloudFormationProvisionedProductArgs)(nil)).Elem()
}

type CloudFormationProvisionedProductInput interface {
	pulumi.Input

	ToCloudFormationProvisionedProductOutput() CloudFormationProvisionedProductOutput
	ToCloudFormationProvisionedProductOutputWithContext(ctx context.Context) CloudFormationProvisionedProductOutput
}

func (*CloudFormationProvisionedProduct) ElementType() reflect.Type {
	return reflect.TypeOf((*CloudFormationProvisionedProduct)(nil))
}

func (i *CloudFormationProvisionedProduct) ToCloudFormationProvisionedProductOutput() CloudFormationProvisionedProductOutput {
	return i.ToCloudFormationProvisionedProductOutputWithContext(context.Background())
}

func (i *CloudFormationProvisionedProduct) ToCloudFormationProvisionedProductOutputWithContext(ctx context.Context) CloudFormationProvisionedProductOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CloudFormationProvisionedProductOutput)
}

type CloudFormationProvisionedProductOutput struct{ *pulumi.OutputState }

func (CloudFormationProvisionedProductOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*CloudFormationProvisionedProduct)(nil))
}

func (o CloudFormationProvisionedProductOutput) ToCloudFormationProvisionedProductOutput() CloudFormationProvisionedProductOutput {
	return o
}

func (o CloudFormationProvisionedProductOutput) ToCloudFormationProvisionedProductOutputWithContext(ctx context.Context) CloudFormationProvisionedProductOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*CloudFormationProvisionedProductInput)(nil)).Elem(), &CloudFormationProvisionedProduct{})
	pulumi.RegisterOutputType(CloudFormationProvisionedProductOutput{})
}
