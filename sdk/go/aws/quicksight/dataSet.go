// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package quicksight

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi-aws-native/sdk/go/aws"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html
type DataSet struct {
	pulumi.CustomResourceState

	Arn pulumi.StringOutput `pulumi:"arn"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-awsaccountid
	AwsAccountId pulumi.StringPtrOutput `pulumi:"awsAccountId"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-columngroups
	ColumnGroups DataSetColumnGroupArrayOutput `pulumi:"columnGroups"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-columnlevelpermissionrules
	ColumnLevelPermissionRules   DataSetColumnLevelPermissionRuleArrayOutput `pulumi:"columnLevelPermissionRules"`
	ConsumedSpiceCapacityInBytes pulumi.Float64Output                        `pulumi:"consumedSpiceCapacityInBytes"`
	CreatedTime                  pulumi.StringOutput                         `pulumi:"createdTime"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-datasetid
	DataSetId pulumi.StringPtrOutput `pulumi:"dataSetId"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-fieldfolders
	FieldFolders DataSetFieldFolderMapOutput `pulumi:"fieldFolders"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-importmode
	ImportMode pulumi.StringPtrOutput `pulumi:"importMode"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-ingestionwaitpolicy
	IngestionWaitPolicy DataSetIngestionWaitPolicyPtrOutput `pulumi:"ingestionWaitPolicy"`
	LastUpdatedTime     pulumi.StringOutput                 `pulumi:"lastUpdatedTime"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-logicaltablemap
	LogicalTableMap DataSetLogicalTableMapOutput `pulumi:"logicalTableMap"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-name
	Name          pulumi.StringPtrOutput         `pulumi:"name"`
	OutputColumns DataSetOutputColumnArrayOutput `pulumi:"outputColumns"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-permissions
	Permissions DataSetResourcePermissionArrayOutput `pulumi:"permissions"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-physicaltablemap
	PhysicalTableMap DataSetPhysicalTableMapOutput `pulumi:"physicalTableMap"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-rowlevelpermissiondataset
	RowLevelPermissionDataSet DataSetRowLevelPermissionDataSetPtrOutput `pulumi:"rowLevelPermissionDataSet"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-tags
	Tags aws.TagArrayOutput `pulumi:"tags"`
}

// NewDataSet registers a new resource with the given unique name, arguments, and options.
func NewDataSet(ctx *pulumi.Context,
	name string, args *DataSetArgs, opts ...pulumi.ResourceOption) (*DataSet, error) {
	if args == nil {
		args = &DataSetArgs{}
	}

	var resource DataSet
	err := ctx.RegisterResource("aws-native:QuickSight:DataSet", name, args, &resource, opts...)
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
	err := ctx.ReadResource("aws-native:QuickSight:DataSet", name, id, state, &resource, opts...)
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
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-awsaccountid
	AwsAccountId *string `pulumi:"awsAccountId"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-columngroups
	ColumnGroups []DataSetColumnGroup `pulumi:"columnGroups"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-columnlevelpermissionrules
	ColumnLevelPermissionRules []DataSetColumnLevelPermissionRule `pulumi:"columnLevelPermissionRules"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-datasetid
	DataSetId *string `pulumi:"dataSetId"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-fieldfolders
	FieldFolders map[string]DataSetFieldFolder `pulumi:"fieldFolders"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-importmode
	ImportMode *string `pulumi:"importMode"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-ingestionwaitpolicy
	IngestionWaitPolicy *DataSetIngestionWaitPolicy `pulumi:"ingestionWaitPolicy"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-logicaltablemap
	LogicalTableMap map[string]DataSetLogicalTable `pulumi:"logicalTableMap"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-name
	Name *string `pulumi:"name"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-permissions
	Permissions []DataSetResourcePermission `pulumi:"permissions"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-physicaltablemap
	PhysicalTableMap map[string]DataSetPhysicalTable `pulumi:"physicalTableMap"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-rowlevelpermissiondataset
	RowLevelPermissionDataSet *DataSetRowLevelPermissionDataSet `pulumi:"rowLevelPermissionDataSet"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-tags
	Tags []aws.Tag `pulumi:"tags"`
}

// The set of arguments for constructing a DataSet resource.
type DataSetArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-awsaccountid
	AwsAccountId pulumi.StringPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-columngroups
	ColumnGroups DataSetColumnGroupArrayInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-columnlevelpermissionrules
	ColumnLevelPermissionRules DataSetColumnLevelPermissionRuleArrayInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-datasetid
	DataSetId pulumi.StringPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-fieldfolders
	FieldFolders DataSetFieldFolderMapInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-importmode
	ImportMode pulumi.StringPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-ingestionwaitpolicy
	IngestionWaitPolicy DataSetIngestionWaitPolicyPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-logicaltablemap
	LogicalTableMap DataSetLogicalTableMapInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-name
	Name pulumi.StringPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-permissions
	Permissions DataSetResourcePermissionArrayInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-physicaltablemap
	PhysicalTableMap DataSetPhysicalTableMapInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-rowlevelpermissiondataset
	RowLevelPermissionDataSet DataSetRowLevelPermissionDataSetPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dataset.html#cfn-quicksight-dataset-tags
	Tags aws.TagArrayInput
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
	pulumi.RegisterOutputType(DataSetOutput{})
}