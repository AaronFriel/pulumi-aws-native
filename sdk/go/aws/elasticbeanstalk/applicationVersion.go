// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package elasticbeanstalk

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::ElasticBeanstalk::ApplicationVersion
//
// Deprecated: ApplicationVersion is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type ApplicationVersion struct {
	pulumi.CustomResourceState

	ApplicationName pulumi.StringOutput                  `pulumi:"applicationName"`
	Description     pulumi.StringPtrOutput               `pulumi:"description"`
	SourceBundle    ApplicationVersionSourceBundleOutput `pulumi:"sourceBundle"`
}

// NewApplicationVersion registers a new resource with the given unique name, arguments, and options.
func NewApplicationVersion(ctx *pulumi.Context,
	name string, args *ApplicationVersionArgs, opts ...pulumi.ResourceOption) (*ApplicationVersion, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ApplicationName == nil {
		return nil, errors.New("invalid value for required argument 'ApplicationName'")
	}
	if args.SourceBundle == nil {
		return nil, errors.New("invalid value for required argument 'SourceBundle'")
	}
	var resource ApplicationVersion
	err := ctx.RegisterResource("aws-native:elasticbeanstalk:ApplicationVersion", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetApplicationVersion gets an existing ApplicationVersion resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetApplicationVersion(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ApplicationVersionState, opts ...pulumi.ResourceOption) (*ApplicationVersion, error) {
	var resource ApplicationVersion
	err := ctx.ReadResource("aws-native:elasticbeanstalk:ApplicationVersion", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ApplicationVersion resources.
type applicationVersionState struct {
}

type ApplicationVersionState struct {
}

func (ApplicationVersionState) ElementType() reflect.Type {
	return reflect.TypeOf((*applicationVersionState)(nil)).Elem()
}

type applicationVersionArgs struct {
	ApplicationName string                         `pulumi:"applicationName"`
	Description     *string                        `pulumi:"description"`
	SourceBundle    ApplicationVersionSourceBundle `pulumi:"sourceBundle"`
}

// The set of arguments for constructing a ApplicationVersion resource.
type ApplicationVersionArgs struct {
	ApplicationName pulumi.StringInput
	Description     pulumi.StringPtrInput
	SourceBundle    ApplicationVersionSourceBundleInput
}

func (ApplicationVersionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*applicationVersionArgs)(nil)).Elem()
}

type ApplicationVersionInput interface {
	pulumi.Input

	ToApplicationVersionOutput() ApplicationVersionOutput
	ToApplicationVersionOutputWithContext(ctx context.Context) ApplicationVersionOutput
}

func (*ApplicationVersion) ElementType() reflect.Type {
	return reflect.TypeOf((*ApplicationVersion)(nil))
}

func (i *ApplicationVersion) ToApplicationVersionOutput() ApplicationVersionOutput {
	return i.ToApplicationVersionOutputWithContext(context.Background())
}

func (i *ApplicationVersion) ToApplicationVersionOutputWithContext(ctx context.Context) ApplicationVersionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ApplicationVersionOutput)
}

type ApplicationVersionOutput struct{ *pulumi.OutputState }

func (ApplicationVersionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ApplicationVersion)(nil))
}

func (o ApplicationVersionOutput) ToApplicationVersionOutput() ApplicationVersionOutput {
	return o
}

func (o ApplicationVersionOutput) ToApplicationVersionOutputWithContext(ctx context.Context) ApplicationVersionOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ApplicationVersionOutput{})
}
