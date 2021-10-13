// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ecr

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// The AWS::ECR::PublicRepository resource specifies an Amazon Elastic Container Public Registry (Amazon Public ECR) repository, where users can push and pull Docker images. For more information, see https://docs.aws.amazon.com/AmazonECR
//
// Deprecated: PublicRepository is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type PublicRepository struct {
	pulumi.CustomResourceState

	Arn pulumi.StringOutput `pulumi:"arn"`
	// The CatalogData property type specifies Catalog data for ECR Public Repository. For information about Catalog Data, see <link>
	RepositoryCatalogData RepositoryCatalogDataPropertiesPtrOutput `pulumi:"repositoryCatalogData"`
	// The name to use for the repository. The repository name may be specified on its own (such as nginx-web-app) or it can be prepended with a namespace to group the repository into a category (such as project-a/nginx-web-app). If you don't specify a name, AWS CloudFormation generates a unique physical ID and uses that ID for the repository name. For more information, see https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-name.html.
	RepositoryName pulumi.StringPtrOutput `pulumi:"repositoryName"`
	// The JSON repository policy text to apply to the repository. For more information, see https://docs.aws.amazon.com/AmazonECR/latest/userguide/RepositoryPolicyExamples.html in the Amazon Elastic Container Registry User Guide.
	RepositoryPolicyText pulumi.AnyOutput `pulumi:"repositoryPolicyText"`
	// An array of key-value pairs to apply to this resource.
	Tags PublicRepositoryTagArrayOutput `pulumi:"tags"`
}

// NewPublicRepository registers a new resource with the given unique name, arguments, and options.
func NewPublicRepository(ctx *pulumi.Context,
	name string, args *PublicRepositoryArgs, opts ...pulumi.ResourceOption) (*PublicRepository, error) {
	if args == nil {
		args = &PublicRepositoryArgs{}
	}

	var resource PublicRepository
	err := ctx.RegisterResource("aws-native:ecr:PublicRepository", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPublicRepository gets an existing PublicRepository resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPublicRepository(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PublicRepositoryState, opts ...pulumi.ResourceOption) (*PublicRepository, error) {
	var resource PublicRepository
	err := ctx.ReadResource("aws-native:ecr:PublicRepository", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering PublicRepository resources.
type publicRepositoryState struct {
}

type PublicRepositoryState struct {
}

func (PublicRepositoryState) ElementType() reflect.Type {
	return reflect.TypeOf((*publicRepositoryState)(nil)).Elem()
}

type publicRepositoryArgs struct {
	// The CatalogData property type specifies Catalog data for ECR Public Repository. For information about Catalog Data, see <link>
	RepositoryCatalogData *RepositoryCatalogDataProperties `pulumi:"repositoryCatalogData"`
	// The name to use for the repository. The repository name may be specified on its own (such as nginx-web-app) or it can be prepended with a namespace to group the repository into a category (such as project-a/nginx-web-app). If you don't specify a name, AWS CloudFormation generates a unique physical ID and uses that ID for the repository name. For more information, see https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-name.html.
	RepositoryName *string `pulumi:"repositoryName"`
	// The JSON repository policy text to apply to the repository. For more information, see https://docs.aws.amazon.com/AmazonECR/latest/userguide/RepositoryPolicyExamples.html in the Amazon Elastic Container Registry User Guide.
	RepositoryPolicyText interface{} `pulumi:"repositoryPolicyText"`
	// An array of key-value pairs to apply to this resource.
	Tags []PublicRepositoryTag `pulumi:"tags"`
}

// The set of arguments for constructing a PublicRepository resource.
type PublicRepositoryArgs struct {
	// The CatalogData property type specifies Catalog data for ECR Public Repository. For information about Catalog Data, see <link>
	RepositoryCatalogData RepositoryCatalogDataPropertiesPtrInput
	// The name to use for the repository. The repository name may be specified on its own (such as nginx-web-app) or it can be prepended with a namespace to group the repository into a category (such as project-a/nginx-web-app). If you don't specify a name, AWS CloudFormation generates a unique physical ID and uses that ID for the repository name. For more information, see https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-name.html.
	RepositoryName pulumi.StringPtrInput
	// The JSON repository policy text to apply to the repository. For more information, see https://docs.aws.amazon.com/AmazonECR/latest/userguide/RepositoryPolicyExamples.html in the Amazon Elastic Container Registry User Guide.
	RepositoryPolicyText pulumi.Input
	// An array of key-value pairs to apply to this resource.
	Tags PublicRepositoryTagArrayInput
}

func (PublicRepositoryArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*publicRepositoryArgs)(nil)).Elem()
}

type PublicRepositoryInput interface {
	pulumi.Input

	ToPublicRepositoryOutput() PublicRepositoryOutput
	ToPublicRepositoryOutputWithContext(ctx context.Context) PublicRepositoryOutput
}

func (*PublicRepository) ElementType() reflect.Type {
	return reflect.TypeOf((*PublicRepository)(nil))
}

func (i *PublicRepository) ToPublicRepositoryOutput() PublicRepositoryOutput {
	return i.ToPublicRepositoryOutputWithContext(context.Background())
}

func (i *PublicRepository) ToPublicRepositoryOutputWithContext(ctx context.Context) PublicRepositoryOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PublicRepositoryOutput)
}

type PublicRepositoryOutput struct{ *pulumi.OutputState }

func (PublicRepositoryOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*PublicRepository)(nil))
}

func (o PublicRepositoryOutput) ToPublicRepositoryOutput() PublicRepositoryOutput {
	return o
}

func (o PublicRepositoryOutput) ToPublicRepositoryOutputWithContext(ctx context.Context) PublicRepositoryOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(PublicRepositoryOutput{})
}
