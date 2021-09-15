// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package s3outposts

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type Definition for AWS::S3Outposts::Bucket
type Bucket struct {
	pulumi.CustomResourceState

	// The Amazon Resource Name (ARN) of the specified bucket.
	Arn pulumi.StringOutput `pulumi:"arn"`
	// A name for the bucket.
	BucketName pulumi.StringOutput `pulumi:"bucketName"`
	// Rules that define how Amazon S3Outposts manages objects during their lifetime.
	LifecycleConfiguration BucketLifecycleConfigurationPtrOutput `pulumi:"lifecycleConfiguration"`
	// The id of the customer outpost on which the bucket resides.
	OutpostId pulumi.StringOutput `pulumi:"outpostId"`
	// An arbitrary set of tags (key-value pairs) for this S3Outposts bucket.
	Tags BucketTagArrayOutput `pulumi:"tags"`
}

// NewBucket registers a new resource with the given unique name, arguments, and options.
func NewBucket(ctx *pulumi.Context,
	name string, args *BucketArgs, opts ...pulumi.ResourceOption) (*Bucket, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.BucketName == nil {
		return nil, errors.New("invalid value for required argument 'BucketName'")
	}
	if args.OutpostId == nil {
		return nil, errors.New("invalid value for required argument 'OutpostId'")
	}
	var resource Bucket
	err := ctx.RegisterResource("aws-native:s3outposts:Bucket", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetBucket gets an existing Bucket resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBucket(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *BucketState, opts ...pulumi.ResourceOption) (*Bucket, error) {
	var resource Bucket
	err := ctx.ReadResource("aws-native:s3outposts:Bucket", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Bucket resources.
type bucketState struct {
}

type BucketState struct {
}

func (BucketState) ElementType() reflect.Type {
	return reflect.TypeOf((*bucketState)(nil)).Elem()
}

type bucketArgs struct {
	// A name for the bucket.
	BucketName string `pulumi:"bucketName"`
	// Rules that define how Amazon S3Outposts manages objects during their lifetime.
	LifecycleConfiguration *BucketLifecycleConfiguration `pulumi:"lifecycleConfiguration"`
	// The id of the customer outpost on which the bucket resides.
	OutpostId string `pulumi:"outpostId"`
	// An arbitrary set of tags (key-value pairs) for this S3Outposts bucket.
	Tags []BucketTag `pulumi:"tags"`
}

// The set of arguments for constructing a Bucket resource.
type BucketArgs struct {
	// A name for the bucket.
	BucketName pulumi.StringInput
	// Rules that define how Amazon S3Outposts manages objects during their lifetime.
	LifecycleConfiguration BucketLifecycleConfigurationPtrInput
	// The id of the customer outpost on which the bucket resides.
	OutpostId pulumi.StringInput
	// An arbitrary set of tags (key-value pairs) for this S3Outposts bucket.
	Tags BucketTagArrayInput
}

func (BucketArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*bucketArgs)(nil)).Elem()
}

type BucketInput interface {
	pulumi.Input

	ToBucketOutput() BucketOutput
	ToBucketOutputWithContext(ctx context.Context) BucketOutput
}

func (*Bucket) ElementType() reflect.Type {
	return reflect.TypeOf((*Bucket)(nil))
}

func (i *Bucket) ToBucketOutput() BucketOutput {
	return i.ToBucketOutputWithContext(context.Background())
}

func (i *Bucket) ToBucketOutputWithContext(ctx context.Context) BucketOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BucketOutput)
}

type BucketOutput struct{ *pulumi.OutputState }

func (BucketOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Bucket)(nil))
}

func (o BucketOutput) ToBucketOutput() BucketOutput {
	return o
}

func (o BucketOutput) ToBucketOutputWithContext(ctx context.Context) BucketOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(BucketOutput{})
}
