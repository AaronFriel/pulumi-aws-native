// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package quicksight

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Definition of the AWS::QuickSight::DataSet Resource Type.
type DataSet struct {
	pulumi.CustomResourceState

	// <p>The Amazon Resource Name (ARN) of the resource.</p>
	Arn          pulumi.StringOutput    `pulumi:"arn"`
	AwsAccountId pulumi.StringPtrOutput `pulumi:"awsAccountId"`
	// <p>Groupings of columns that work together in certain QuickSight features. Currently, only geospatial hierarchy is supported.</p>
	ColumnGroups               DataSetColumnGroupArrayOutput               `pulumi:"columnGroups"`
	ColumnLevelPermissionRules DataSetColumnLevelPermissionRuleArrayOutput `pulumi:"columnLevelPermissionRules"`
	// <p>The amount of SPICE capacity used by this dataset. This is 0 if the dataset isn't
	//             imported into SPICE.</p>
	ConsumedSpiceCapacityInBytes pulumi.Float64Output `pulumi:"consumedSpiceCapacityInBytes"`
	// <p>The time that this dataset was created.</p>
	CreatedTime         pulumi.StringOutput                 `pulumi:"createdTime"`
	DataSetId           pulumi.StringPtrOutput              `pulumi:"dataSetId"`
	FieldFolders        DataSetFieldFolderMapPtrOutput      `pulumi:"fieldFolders"`
	ImportMode          DataSetImportModePtrOutput          `pulumi:"importMode"`
	IngestionWaitPolicy DataSetIngestionWaitPolicyPtrOutput `pulumi:"ingestionWaitPolicy"`
	// <p>The last time that this dataset was updated.</p>
	LastUpdatedTime pulumi.StringOutput             `pulumi:"lastUpdatedTime"`
	LogicalTableMap DataSetLogicalTableMapPtrOutput `pulumi:"logicalTableMap"`
	// <p>The display name for the dataset.</p>
	Name pulumi.StringPtrOutput `pulumi:"name"`
	// <p>The list of columns after all transforms. These columns are available in templates,
	//             analyses, and dashboards.</p>
	OutputColumns DataSetOutputColumnArrayOutput `pulumi:"outputColumns"`
	// <p>A list of resource permissions on the dataset.</p>
	Permissions               DataSetResourcePermissionArrayOutput      `pulumi:"permissions"`
	PhysicalTableMap          DataSetPhysicalTableMapPtrOutput          `pulumi:"physicalTableMap"`
	RowLevelPermissionDataSet DataSetRowLevelPermissionDataSetPtrOutput `pulumi:"rowLevelPermissionDataSet"`
	// <p>Contains a map of the key-value pairs for the resource tag or tags assigned to the dataset.</p>
	Tags DataSetTagArrayOutput `pulumi:"tags"`
}

// NewDataSet registers a new resource with the given unique name, arguments, and options.
func NewDataSet(ctx *pulumi.Context,
	name string, args *DataSetArgs, opts ...pulumi.ResourceOption) (*DataSet, error) {
	if args == nil {
		args = &DataSetArgs{}
	}

	var resource DataSet
	err := ctx.RegisterResource("aws-native:quicksight:DataSet", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDataSet gets an existing DataSet resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDataSet(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DataSetState, opts ...pulumi.ResourceOption) (*DataSet, error) {
	var resource DataSet
	err := ctx.ReadResource("aws-native:quicksight:DataSet", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DataSet resources.
type dataSetState struct {
}

type DataSetState struct {
}

func (DataSetState) ElementType() reflect.Type {
	return reflect.TypeOf((*dataSetState)(nil)).Elem()
}

type dataSetArgs struct {
	AwsAccountId *string `pulumi:"awsAccountId"`
	// <p>Groupings of columns that work together in certain QuickSight features. Currently, only geospatial hierarchy is supported.</p>
	ColumnGroups               []DataSetColumnGroup               `pulumi:"columnGroups"`
	ColumnLevelPermissionRules []DataSetColumnLevelPermissionRule `pulumi:"columnLevelPermissionRules"`
	DataSetId                  *string                            `pulumi:"dataSetId"`
	FieldFolders               *DataSetFieldFolderMap             `pulumi:"fieldFolders"`
	ImportMode                 *DataSetImportMode                 `pulumi:"importMode"`
	IngestionWaitPolicy        *DataSetIngestionWaitPolicy        `pulumi:"ingestionWaitPolicy"`
	LogicalTableMap            *DataSetLogicalTableMap            `pulumi:"logicalTableMap"`
	// <p>The display name for the dataset.</p>
	Name *string `pulumi:"name"`
	// <p>A list of resource permissions on the dataset.</p>
	Permissions               []DataSetResourcePermission       `pulumi:"permissions"`
	PhysicalTableMap          *DataSetPhysicalTableMap          `pulumi:"physicalTableMap"`
	RowLevelPermissionDataSet *DataSetRowLevelPermissionDataSet `pulumi:"rowLevelPermissionDataSet"`
	// <p>Contains a map of the key-value pairs for the resource tag or tags assigned to the dataset.</p>
	Tags []DataSetTag `pulumi:"tags"`
}

// The set of arguments for constructing a DataSet resource.
type DataSetArgs struct {
	AwsAccountId pulumi.StringPtrInput
	// <p>Groupings of columns that work together in certain QuickSight features. Currently, only geospatial hierarchy is supported.</p>
	ColumnGroups               DataSetColumnGroupArrayInput
	ColumnLevelPermissionRules DataSetColumnLevelPermissionRuleArrayInput
	DataSetId                  pulumi.StringPtrInput
	FieldFolders               DataSetFieldFolderMapPtrInput
	ImportMode                 DataSetImportModePtrInput
	IngestionWaitPolicy        DataSetIngestionWaitPolicyPtrInput
	LogicalTableMap            DataSetLogicalTableMapPtrInput
	// <p>The display name for the dataset.</p>
	Name pulumi.StringPtrInput
	// <p>A list of resource permissions on the dataset.</p>
	Permissions               DataSetResourcePermissionArrayInput
	PhysicalTableMap          DataSetPhysicalTableMapPtrInput
	RowLevelPermissionDataSet DataSetRowLevelPermissionDataSetPtrInput
	// <p>Contains a map of the key-value pairs for the resource tag or tags assigned to the dataset.</p>
	Tags DataSetTagArrayInput
}

func (DataSetArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*dataSetArgs)(nil)).Elem()
}

type DataSetInput interface {
	pulumi.Input

	ToDataSetOutput() DataSetOutput
	ToDataSetOutputWithContext(ctx context.Context) DataSetOutput
}

func (*DataSet) ElementType() reflect.Type {
	return reflect.TypeOf((*DataSet)(nil))
}

func (i *DataSet) ToDataSetOutput() DataSetOutput {
	return i.ToDataSetOutputWithContext(context.Background())
}

func (i *DataSet) ToDataSetOutputWithContext(ctx context.Context) DataSetOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DataSetOutput)
}

type DataSetOutput struct{ *pulumi.OutputState }

func (DataSetOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*DataSet)(nil))
}

func (o DataSetOutput) ToDataSetOutput() DataSetOutput {
	return o
}

func (o DataSetOutput) ToDataSetOutputWithContext(ctx context.Context) DataSetOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*DataSetInput)(nil)).Elem(), &DataSet{})
	pulumi.RegisterOutputType(DataSetOutput{})
}
