// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package mediapackage

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource schema for AWS::MediaPackage::Asset
type Asset struct {
	pulumi.CustomResourceState

	// The ARN of the Asset.
	Arn pulumi.StringOutput `pulumi:"arn"`
	// The time the Asset was initially submitted for Ingest.
	CreatedAt pulumi.StringOutput `pulumi:"createdAt"`
	// The list of egress endpoints available for the Asset.
	EgressEndpoints AssetEgressEndpointArrayOutput `pulumi:"egressEndpoints"`
	// The ID of the PackagingGroup for the Asset.
	PackagingGroupId pulumi.StringOutput `pulumi:"packagingGroupId"`
	// The resource ID to include in SPEKE key requests.
	ResourceId pulumi.StringPtrOutput `pulumi:"resourceId"`
	// ARN of the source object in S3.
	SourceArn pulumi.StringOutput `pulumi:"sourceArn"`
	// The IAM role_arn used to access the source S3 bucket.
	SourceRoleArn pulumi.StringOutput `pulumi:"sourceRoleArn"`
	// A collection of tags associated with a resource
	Tags AssetTagArrayOutput `pulumi:"tags"`
}

// NewAsset registers a new resource with the given unique name, arguments, and options.
func NewAsset(ctx *pulumi.Context,
	name string, args *AssetArgs, opts ...pulumi.ResourceOption) (*Asset, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.PackagingGroupId == nil {
		return nil, errors.New("invalid value for required argument 'PackagingGroupId'")
	}
	if args.SourceArn == nil {
		return nil, errors.New("invalid value for required argument 'SourceArn'")
	}
	if args.SourceRoleArn == nil {
		return nil, errors.New("invalid value for required argument 'SourceRoleArn'")
	}
	var resource Asset
	err := ctx.RegisterResource("aws-native:mediapackage:Asset", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAsset gets an existing Asset resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAsset(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AssetState, opts ...pulumi.ResourceOption) (*Asset, error) {
	var resource Asset
	err := ctx.ReadResource("aws-native:mediapackage:Asset", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Asset resources.
type assetState struct {
}

type AssetState struct {
}

func (AssetState) ElementType() reflect.Type {
	return reflect.TypeOf((*assetState)(nil)).Elem()
}

type assetArgs struct {
	// The ID of the PackagingGroup for the Asset.
	PackagingGroupId string `pulumi:"packagingGroupId"`
	// The resource ID to include in SPEKE key requests.
	ResourceId *string `pulumi:"resourceId"`
	// ARN of the source object in S3.
	SourceArn string `pulumi:"sourceArn"`
	// The IAM role_arn used to access the source S3 bucket.
	SourceRoleArn string `pulumi:"sourceRoleArn"`
	// A collection of tags associated with a resource
	Tags []AssetTag `pulumi:"tags"`
}

// The set of arguments for constructing a Asset resource.
type AssetArgs struct {
	// The ID of the PackagingGroup for the Asset.
	PackagingGroupId pulumi.StringInput
	// The resource ID to include in SPEKE key requests.
	ResourceId pulumi.StringPtrInput
	// ARN of the source object in S3.
	SourceArn pulumi.StringInput
	// The IAM role_arn used to access the source S3 bucket.
	SourceRoleArn pulumi.StringInput
	// A collection of tags associated with a resource
	Tags AssetTagArrayInput
}

func (AssetArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*assetArgs)(nil)).Elem()
}

type AssetInput interface {
	pulumi.Input

	ToAssetOutput() AssetOutput
	ToAssetOutputWithContext(ctx context.Context) AssetOutput
}

func (*Asset) ElementType() reflect.Type {
	return reflect.TypeOf((*Asset)(nil))
}

func (i *Asset) ToAssetOutput() AssetOutput {
	return i.ToAssetOutputWithContext(context.Background())
}

func (i *Asset) ToAssetOutputWithContext(ctx context.Context) AssetOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AssetOutput)
}

type AssetOutput struct{ *pulumi.OutputState }

func (AssetOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Asset)(nil))
}

func (o AssetOutput) ToAssetOutput() AssetOutput {
	return o
}

func (o AssetOutput) ToAssetOutputWithContext(ctx context.Context) AssetOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*AssetInput)(nil)).Elem(), &Asset{})
	pulumi.RegisterOutputType(AssetOutput{})
}
