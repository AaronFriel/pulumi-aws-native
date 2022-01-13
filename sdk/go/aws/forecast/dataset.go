// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package forecast

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type Definition for AWS::Forecast::Dataset
type Dataset struct {
	pulumi.CustomResourceState

	Arn pulumi.StringOutput `pulumi:"arn"`
	// Frequency of data collection. This parameter is required for RELATED_TIME_SERIES
	DataFrequency pulumi.StringPtrOutput `pulumi:"dataFrequency"`
	// A name for the dataset
	DatasetName pulumi.StringOutput `pulumi:"datasetName"`
	// The dataset type
	DatasetType DatasetTypeOutput `pulumi:"datasetType"`
	// The domain associated with the dataset
	Domain           DatasetDomainOutput                 `pulumi:"domain"`
	EncryptionConfig EncryptionConfigPropertiesPtrOutput `pulumi:"encryptionConfig"`
	Schema           SchemaPropertiesOutput              `pulumi:"schema"`
	Tags             TagsItemPropertiesArrayOutput       `pulumi:"tags"`
}

// NewDataset registers a new resource with the given unique name, arguments, and options.
func NewDataset(ctx *pulumi.Context,
	name string, args *DatasetArgs, opts ...pulumi.ResourceOption) (*Dataset, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DatasetType == nil {
		return nil, errors.New("invalid value for required argument 'DatasetType'")
	}
	if args.Domain == nil {
		return nil, errors.New("invalid value for required argument 'Domain'")
	}
	if args.Schema == nil {
		return nil, errors.New("invalid value for required argument 'Schema'")
	}
	var resource Dataset
	err := ctx.RegisterResource("aws-native:forecast:Dataset", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDataset gets an existing Dataset resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDataset(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DatasetState, opts ...pulumi.ResourceOption) (*Dataset, error) {
	var resource Dataset
	err := ctx.ReadResource("aws-native:forecast:Dataset", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Dataset resources.
type datasetState struct {
}

type DatasetState struct {
}

func (DatasetState) ElementType() reflect.Type {
	return reflect.TypeOf((*datasetState)(nil)).Elem()
}

type datasetArgs struct {
	// Frequency of data collection. This parameter is required for RELATED_TIME_SERIES
	DataFrequency *string `pulumi:"dataFrequency"`
	// A name for the dataset
	DatasetName *string `pulumi:"datasetName"`
	// The dataset type
	DatasetType DatasetType `pulumi:"datasetType"`
	// The domain associated with the dataset
	Domain           DatasetDomain               `pulumi:"domain"`
	EncryptionConfig *EncryptionConfigProperties `pulumi:"encryptionConfig"`
	Schema           SchemaProperties            `pulumi:"schema"`
	Tags             []TagsItemProperties        `pulumi:"tags"`
}

// The set of arguments for constructing a Dataset resource.
type DatasetArgs struct {
	// Frequency of data collection. This parameter is required for RELATED_TIME_SERIES
	DataFrequency pulumi.StringPtrInput
	// A name for the dataset
	DatasetName pulumi.StringPtrInput
	// The dataset type
	DatasetType DatasetTypeInput
	// The domain associated with the dataset
	Domain           DatasetDomainInput
	EncryptionConfig EncryptionConfigPropertiesPtrInput
	Schema           SchemaPropertiesInput
	Tags             TagsItemPropertiesArrayInput
}

func (DatasetArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*datasetArgs)(nil)).Elem()
}

type DatasetInput interface {
	pulumi.Input

	ToDatasetOutput() DatasetOutput
	ToDatasetOutputWithContext(ctx context.Context) DatasetOutput
}

func (*Dataset) ElementType() reflect.Type {
	return reflect.TypeOf((*Dataset)(nil))
}

func (i *Dataset) ToDatasetOutput() DatasetOutput {
	return i.ToDatasetOutputWithContext(context.Background())
}

func (i *Dataset) ToDatasetOutputWithContext(ctx context.Context) DatasetOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DatasetOutput)
}

type DatasetOutput struct{ *pulumi.OutputState }

func (DatasetOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Dataset)(nil))
}

func (o DatasetOutput) ToDatasetOutput() DatasetOutput {
	return o
}

func (o DatasetOutput) ToDatasetOutputWithContext(ctx context.Context) DatasetOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*DatasetInput)(nil)).Elem(), &Dataset{})
	pulumi.RegisterOutputType(DatasetOutput{})
}
