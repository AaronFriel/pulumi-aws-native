// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package codeartifact

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// The resource schema to create a CodeArtifact repository.
type Repository struct {
	pulumi.CustomResourceState

	// The ARN of the repository.
	Arn pulumi.StringOutput `pulumi:"arn"`
	// A text description of the repository.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The name of the domain that contains the repository.
	DomainName pulumi.StringOutput `pulumi:"domainName"`
	// The 12-digit account ID of the AWS account that owns the domain.
	DomainOwner pulumi.StringOutput `pulumi:"domainOwner"`
	// A list of external connections associated with the repository.
	ExternalConnections pulumi.StringArrayOutput `pulumi:"externalConnections"`
	// The name of the repository. This is used for GetAtt
	Name pulumi.StringOutput `pulumi:"name"`
	// The access control resource policy on the provided repository.
	PermissionsPolicyDocument pulumi.AnyOutput `pulumi:"permissionsPolicyDocument"`
	// The name of the repository.
	RepositoryName pulumi.StringOutput `pulumi:"repositoryName"`
	// An array of key-value pairs to apply to this resource.
	Tags RepositoryTagArrayOutput `pulumi:"tags"`
	// A list of upstream repositories associated with the repository.
	Upstreams pulumi.StringArrayOutput `pulumi:"upstreams"`
}

// NewRepository registers a new resource with the given unique name, arguments, and options.
func NewRepository(ctx *pulumi.Context,
	name string, args *RepositoryArgs, opts ...pulumi.ResourceOption) (*Repository, error) {
	if args == nil {
		args = &RepositoryArgs{}
	}

	var resource Repository
	err := ctx.RegisterResource("aws-native:codeartifact:Repository", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRepository gets an existing Repository resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRepository(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RepositoryState, opts ...pulumi.ResourceOption) (*Repository, error) {
	var resource Repository
	err := ctx.ReadResource("aws-native:codeartifact:Repository", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Repository resources.
type repositoryState struct {
}

type RepositoryState struct {
}

func (RepositoryState) ElementType() reflect.Type {
	return reflect.TypeOf((*repositoryState)(nil)).Elem()
}

type repositoryArgs struct {
	// A text description of the repository.
	Description *string `pulumi:"description"`
	// A list of external connections associated with the repository.
	ExternalConnections []string `pulumi:"externalConnections"`
	// The access control resource policy on the provided repository.
	PermissionsPolicyDocument interface{} `pulumi:"permissionsPolicyDocument"`
	// The name of the repository.
	RepositoryName *string `pulumi:"repositoryName"`
	// An array of key-value pairs to apply to this resource.
	Tags []RepositoryTag `pulumi:"tags"`
	// A list of upstream repositories associated with the repository.
	Upstreams []string `pulumi:"upstreams"`
}

// The set of arguments for constructing a Repository resource.
type RepositoryArgs struct {
	// A text description of the repository.
	Description pulumi.StringPtrInput
	// A list of external connections associated with the repository.
	ExternalConnections pulumi.StringArrayInput
	// The access control resource policy on the provided repository.
	PermissionsPolicyDocument pulumi.Input
	// The name of the repository.
	RepositoryName pulumi.StringPtrInput
	// An array of key-value pairs to apply to this resource.
	Tags RepositoryTagArrayInput
	// A list of upstream repositories associated with the repository.
	Upstreams pulumi.StringArrayInput
}

func (RepositoryArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*repositoryArgs)(nil)).Elem()
}

type RepositoryInput interface {
	pulumi.Input

	ToRepositoryOutput() RepositoryOutput
	ToRepositoryOutputWithContext(ctx context.Context) RepositoryOutput
}

func (*Repository) ElementType() reflect.Type {
	return reflect.TypeOf((*Repository)(nil))
}

func (i *Repository) ToRepositoryOutput() RepositoryOutput {
	return i.ToRepositoryOutputWithContext(context.Background())
}

func (i *Repository) ToRepositoryOutputWithContext(ctx context.Context) RepositoryOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RepositoryOutput)
}

type RepositoryOutput struct{ *pulumi.OutputState }

func (RepositoryOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Repository)(nil))
}

func (o RepositoryOutput) ToRepositoryOutput() RepositoryOutput {
	return o
}

func (o RepositoryOutput) ToRepositoryOutputWithContext(ctx context.Context) RepositoryOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*RepositoryInput)(nil)).Elem(), &Repository{})
	pulumi.RegisterOutputType(RepositoryOutput{})
}
