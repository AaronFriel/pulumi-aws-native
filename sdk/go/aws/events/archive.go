// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package events

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::Events::Archive
type Archive struct {
	pulumi.CustomResourceState

	ArchiveName   pulumi.StringOutput    `pulumi:"archiveName"`
	Arn           pulumi.StringOutput    `pulumi:"arn"`
	Description   pulumi.StringPtrOutput `pulumi:"description"`
	EventPattern  pulumi.AnyOutput       `pulumi:"eventPattern"`
	RetentionDays pulumi.IntPtrOutput    `pulumi:"retentionDays"`
	SourceArn     pulumi.StringOutput    `pulumi:"sourceArn"`
}

// NewArchive registers a new resource with the given unique name, arguments, and options.
func NewArchive(ctx *pulumi.Context,
	name string, args *ArchiveArgs, opts ...pulumi.ResourceOption) (*Archive, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.SourceArn == nil {
		return nil, errors.New("invalid value for required argument 'SourceArn'")
	}
	var resource Archive
	err := ctx.RegisterResource("aws-native:events:Archive", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetArchive gets an existing Archive resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetArchive(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ArchiveState, opts ...pulumi.ResourceOption) (*Archive, error) {
	var resource Archive
	err := ctx.ReadResource("aws-native:events:Archive", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Archive resources.
type archiveState struct {
}

type ArchiveState struct {
}

func (ArchiveState) ElementType() reflect.Type {
	return reflect.TypeOf((*archiveState)(nil)).Elem()
}

type archiveArgs struct {
	Description   *string     `pulumi:"description"`
	EventPattern  interface{} `pulumi:"eventPattern"`
	RetentionDays *int        `pulumi:"retentionDays"`
	SourceArn     string      `pulumi:"sourceArn"`
}

// The set of arguments for constructing a Archive resource.
type ArchiveArgs struct {
	Description   pulumi.StringPtrInput
	EventPattern  pulumi.Input
	RetentionDays pulumi.IntPtrInput
	SourceArn     pulumi.StringInput
}

func (ArchiveArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*archiveArgs)(nil)).Elem()
}

type ArchiveInput interface {
	pulumi.Input

	ToArchiveOutput() ArchiveOutput
	ToArchiveOutputWithContext(ctx context.Context) ArchiveOutput
}

func (*Archive) ElementType() reflect.Type {
	return reflect.TypeOf((*Archive)(nil))
}

func (i *Archive) ToArchiveOutput() ArchiveOutput {
	return i.ToArchiveOutputWithContext(context.Background())
}

func (i *Archive) ToArchiveOutputWithContext(ctx context.Context) ArchiveOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ArchiveOutput)
}

type ArchiveOutput struct{ *pulumi.OutputState }

func (ArchiveOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Archive)(nil))
}

func (o ArchiveOutput) ToArchiveOutput() ArchiveOutput {
	return o
}

func (o ArchiveOutput) ToArchiveOutputWithContext(ctx context.Context) ArchiveOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ArchiveOutput{})
}
