// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package iotsitewise

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource schema for AWS::IoTSiteWise::Project
type Project struct {
	pulumi.CustomResourceState

	// The IDs of the assets to be associated to the project.
	AssetIds pulumi.StringArrayOutput `pulumi:"assetIds"`
	// The ID of the portal in which to create the project.
	PortalId pulumi.StringOutput `pulumi:"portalId"`
	// The ARN of the project.
	ProjectArn pulumi.StringOutput `pulumi:"projectArn"`
	// A description for the project.
	ProjectDescription pulumi.StringPtrOutput `pulumi:"projectDescription"`
	// The ID of the project.
	ProjectId pulumi.StringOutput `pulumi:"projectId"`
	// A friendly name for the project.
	ProjectName pulumi.StringOutput `pulumi:"projectName"`
	// A list of key-value pairs that contain metadata for the project.
	Tags ProjectTagArrayOutput `pulumi:"tags"`
}

// NewProject registers a new resource with the given unique name, arguments, and options.
func NewProject(ctx *pulumi.Context,
	name string, args *ProjectArgs, opts ...pulumi.ResourceOption) (*Project, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.PortalId == nil {
		return nil, errors.New("invalid value for required argument 'PortalId'")
	}
	var resource Project
	err := ctx.RegisterResource("aws-native:iotsitewise:Project", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetProject gets an existing Project resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetProject(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ProjectState, opts ...pulumi.ResourceOption) (*Project, error) {
	var resource Project
	err := ctx.ReadResource("aws-native:iotsitewise:Project", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Project resources.
type projectState struct {
}

type ProjectState struct {
}

func (ProjectState) ElementType() reflect.Type {
	return reflect.TypeOf((*projectState)(nil)).Elem()
}

type projectArgs struct {
	// The IDs of the assets to be associated to the project.
	AssetIds []string `pulumi:"assetIds"`
	// The ID of the portal in which to create the project.
	PortalId string `pulumi:"portalId"`
	// A description for the project.
	ProjectDescription *string `pulumi:"projectDescription"`
	// A friendly name for the project.
	ProjectName *string `pulumi:"projectName"`
	// A list of key-value pairs that contain metadata for the project.
	Tags []ProjectTag `pulumi:"tags"`
}

// The set of arguments for constructing a Project resource.
type ProjectArgs struct {
	// The IDs of the assets to be associated to the project.
	AssetIds pulumi.StringArrayInput
	// The ID of the portal in which to create the project.
	PortalId pulumi.StringInput
	// A description for the project.
	ProjectDescription pulumi.StringPtrInput
	// A friendly name for the project.
	ProjectName pulumi.StringPtrInput
	// A list of key-value pairs that contain metadata for the project.
	Tags ProjectTagArrayInput
}

func (ProjectArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*projectArgs)(nil)).Elem()
}

type ProjectInput interface {
	pulumi.Input

	ToProjectOutput() ProjectOutput
	ToProjectOutputWithContext(ctx context.Context) ProjectOutput
}

func (*Project) ElementType() reflect.Type {
	return reflect.TypeOf((*Project)(nil))
}

func (i *Project) ToProjectOutput() ProjectOutput {
	return i.ToProjectOutputWithContext(context.Background())
}

func (i *Project) ToProjectOutputWithContext(ctx context.Context) ProjectOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProjectOutput)
}

type ProjectOutput struct{ *pulumi.OutputState }

func (ProjectOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Project)(nil))
}

func (o ProjectOutput) ToProjectOutput() ProjectOutput {
	return o
}

func (o ProjectOutput) ToProjectOutputWithContext(ctx context.Context) ProjectOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ProjectInput)(nil)).Elem(), &Project{})
	pulumi.RegisterOutputType(ProjectOutput{})
}
