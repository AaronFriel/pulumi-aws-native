// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package quicksight

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Definition of the AWS::QuickSight::Dashboard Resource Type.
type Dashboard struct {
	pulumi.CustomResourceState

	// <p>The Amazon Resource Name (ARN) of the resource.</p>
	Arn          pulumi.StringOutput `pulumi:"arn"`
	AwsAccountId pulumi.StringOutput `pulumi:"awsAccountId"`
	// <p>The time that this dataset was created.</p>
	CreatedTime             pulumi.StringOutput              `pulumi:"createdTime"`
	DashboardId             pulumi.StringOutput              `pulumi:"dashboardId"`
	DashboardPublishOptions DashboardPublishOptionsPtrOutput `pulumi:"dashboardPublishOptions"`
	// <p>The last time that this dataset was published.</p>
	LastPublishedTime pulumi.StringOutput `pulumi:"lastPublishedTime"`
	// <p>The last time that this dataset was updated.</p>
	LastUpdatedTime pulumi.StringOutput `pulumi:"lastUpdatedTime"`
	// <p>The display name of the dashboard.</p>
	Name       pulumi.StringPtrOutput       `pulumi:"name"`
	Parameters DashboardParametersPtrOutput `pulumi:"parameters"`
	// <p>A structure that contains the permissions of the dashboard. You can use this structure
	//             for granting permissions by providing a list of IAM action information for each
	//             principal ARN. </p>
	//
	//         <p>To specify no permissions, omit the permissions list.</p>
	Permissions  DashboardResourcePermissionArrayOutput `pulumi:"permissions"`
	SourceEntity DashboardSourceEntityOutput            `pulumi:"sourceEntity"`
	// <p>Contains a map of the key-value pairs for the resource tag or tags assigned to the
	//             dashboard.</p>
	Tags DashboardTagArrayOutput `pulumi:"tags"`
	// <p>The Amazon Resource Name (ARN) of the theme that is being used for this dashboard. If
	//             you add a value for this field, it overrides the value that is used in the source
	//             entity. The theme ARN must exist in the same AWS account where you create the
	//             dashboard.</p>
	ThemeArn pulumi.StringPtrOutput `pulumi:"themeArn"`
	Version  DashboardVersionOutput `pulumi:"version"`
	// <p>A description for the first version of the dashboard being created.</p>
	VersionDescription pulumi.StringPtrOutput `pulumi:"versionDescription"`
}

// NewDashboard registers a new resource with the given unique name, arguments, and options.
func NewDashboard(ctx *pulumi.Context,
	name string, args *DashboardArgs, opts ...pulumi.ResourceOption) (*Dashboard, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AwsAccountId == nil {
		return nil, errors.New("invalid value for required argument 'AwsAccountId'")
	}
	if args.DashboardId == nil {
		return nil, errors.New("invalid value for required argument 'DashboardId'")
	}
	if args.SourceEntity == nil {
		return nil, errors.New("invalid value for required argument 'SourceEntity'")
	}
	var resource Dashboard
	err := ctx.RegisterResource("aws-native:quicksight:Dashboard", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDashboard gets an existing Dashboard resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDashboard(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DashboardState, opts ...pulumi.ResourceOption) (*Dashboard, error) {
	var resource Dashboard
	err := ctx.ReadResource("aws-native:quicksight:Dashboard", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Dashboard resources.
type dashboardState struct {
}

type DashboardState struct {
}

func (DashboardState) ElementType() reflect.Type {
	return reflect.TypeOf((*dashboardState)(nil)).Elem()
}

type dashboardArgs struct {
	AwsAccountId            string                   `pulumi:"awsAccountId"`
	DashboardId             string                   `pulumi:"dashboardId"`
	DashboardPublishOptions *DashboardPublishOptions `pulumi:"dashboardPublishOptions"`
	// <p>The display name of the dashboard.</p>
	Name       *string              `pulumi:"name"`
	Parameters *DashboardParameters `pulumi:"parameters"`
	// <p>A structure that contains the permissions of the dashboard. You can use this structure
	//             for granting permissions by providing a list of IAM action information for each
	//             principal ARN. </p>
	//
	//         <p>To specify no permissions, omit the permissions list.</p>
	Permissions  []DashboardResourcePermission `pulumi:"permissions"`
	SourceEntity DashboardSourceEntity         `pulumi:"sourceEntity"`
	// <p>Contains a map of the key-value pairs for the resource tag or tags assigned to the
	//             dashboard.</p>
	Tags []DashboardTag `pulumi:"tags"`
	// <p>The Amazon Resource Name (ARN) of the theme that is being used for this dashboard. If
	//             you add a value for this field, it overrides the value that is used in the source
	//             entity. The theme ARN must exist in the same AWS account where you create the
	//             dashboard.</p>
	ThemeArn *string `pulumi:"themeArn"`
	// <p>A description for the first version of the dashboard being created.</p>
	VersionDescription *string `pulumi:"versionDescription"`
}

// The set of arguments for constructing a Dashboard resource.
type DashboardArgs struct {
	AwsAccountId            pulumi.StringInput
	DashboardId             pulumi.StringInput
	DashboardPublishOptions DashboardPublishOptionsPtrInput
	// <p>The display name of the dashboard.</p>
	Name       pulumi.StringPtrInput
	Parameters DashboardParametersPtrInput
	// <p>A structure that contains the permissions of the dashboard. You can use this structure
	//             for granting permissions by providing a list of IAM action information for each
	//             principal ARN. </p>
	//
	//         <p>To specify no permissions, omit the permissions list.</p>
	Permissions  DashboardResourcePermissionArrayInput
	SourceEntity DashboardSourceEntityInput
	// <p>Contains a map of the key-value pairs for the resource tag or tags assigned to the
	//             dashboard.</p>
	Tags DashboardTagArrayInput
	// <p>The Amazon Resource Name (ARN) of the theme that is being used for this dashboard. If
	//             you add a value for this field, it overrides the value that is used in the source
	//             entity. The theme ARN must exist in the same AWS account where you create the
	//             dashboard.</p>
	ThemeArn pulumi.StringPtrInput
	// <p>A description for the first version of the dashboard being created.</p>
	VersionDescription pulumi.StringPtrInput
}

func (DashboardArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*dashboardArgs)(nil)).Elem()
}

type DashboardInput interface {
	pulumi.Input

	ToDashboardOutput() DashboardOutput
	ToDashboardOutputWithContext(ctx context.Context) DashboardOutput
}

func (*Dashboard) ElementType() reflect.Type {
	return reflect.TypeOf((*Dashboard)(nil))
}

func (i *Dashboard) ToDashboardOutput() DashboardOutput {
	return i.ToDashboardOutputWithContext(context.Background())
}

func (i *Dashboard) ToDashboardOutputWithContext(ctx context.Context) DashboardOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DashboardOutput)
}

type DashboardOutput struct{ *pulumi.OutputState }

func (DashboardOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Dashboard)(nil))
}

func (o DashboardOutput) ToDashboardOutput() DashboardOutput {
	return o
}

func (o DashboardOutput) ToDashboardOutputWithContext(ctx context.Context) DashboardOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*DashboardInput)(nil)).Elem(), &Dashboard{})
	pulumi.RegisterOutputType(DashboardOutput{})
}
