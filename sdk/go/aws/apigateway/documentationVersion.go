// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package apigateway

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-documentationversion.html
type DocumentationVersion struct {
	pulumi.CustomResourceState

	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-documentationversion.html#cfn-apigateway-documentationversion-description
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-documentationversion.html#cfn-apigateway-documentationversion-documentationversion
	DocumentationVersion pulumi.StringOutput `pulumi:"documentationVersion"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-documentationversion.html#cfn-apigateway-documentationversion-restapiid
	RestApiId pulumi.StringOutput `pulumi:"restApiId"`
}

// NewDocumentationVersion registers a new resource with the given unique name, arguments, and options.
func NewDocumentationVersion(ctx *pulumi.Context,
	name string, args *DocumentationVersionArgs, opts ...pulumi.ResourceOption) (*DocumentationVersion, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DocumentationVersion == nil {
		return nil, errors.New("invalid value for required argument 'DocumentationVersion'")
	}
	if args.RestApiId == nil {
		return nil, errors.New("invalid value for required argument 'RestApiId'")
	}
	var resource DocumentationVersion
	err := ctx.RegisterResource("aws-native:ApiGateway:DocumentationVersion", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDocumentationVersion gets an existing DocumentationVersion resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDocumentationVersion(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DocumentationVersionState, opts ...pulumi.ResourceOption) (*DocumentationVersion, error) {
	var resource DocumentationVersion
	err := ctx.ReadResource("aws-native:ApiGateway:DocumentationVersion", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DocumentationVersion resources.
type documentationVersionState struct {
}

type DocumentationVersionState struct {
}

func (DocumentationVersionState) ElementType() reflect.Type {
	return reflect.TypeOf((*documentationVersionState)(nil)).Elem()
}

type documentationVersionArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-documentationversion.html#cfn-apigateway-documentationversion-description
	Description *string `pulumi:"description"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-documentationversion.html#cfn-apigateway-documentationversion-documentationversion
	DocumentationVersion string `pulumi:"documentationVersion"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-documentationversion.html#cfn-apigateway-documentationversion-restapiid
	RestApiId string `pulumi:"restApiId"`
}

// The set of arguments for constructing a DocumentationVersion resource.
type DocumentationVersionArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-documentationversion.html#cfn-apigateway-documentationversion-description
	Description pulumi.StringPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-documentationversion.html#cfn-apigateway-documentationversion-documentationversion
	DocumentationVersion pulumi.StringInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-documentationversion.html#cfn-apigateway-documentationversion-restapiid
	RestApiId pulumi.StringInput
}

func (DocumentationVersionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*documentationVersionArgs)(nil)).Elem()
}

type DocumentationVersionInput interface {
	pulumi.Input

	ToDocumentationVersionOutput() DocumentationVersionOutput
	ToDocumentationVersionOutputWithContext(ctx context.Context) DocumentationVersionOutput
}

func (*DocumentationVersion) ElementType() reflect.Type {
	return reflect.TypeOf((*DocumentationVersion)(nil))
}

func (i *DocumentationVersion) ToDocumentationVersionOutput() DocumentationVersionOutput {
	return i.ToDocumentationVersionOutputWithContext(context.Background())
}

func (i *DocumentationVersion) ToDocumentationVersionOutputWithContext(ctx context.Context) DocumentationVersionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DocumentationVersionOutput)
}

type DocumentationVersionOutput struct{ *pulumi.OutputState }

func (DocumentationVersionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*DocumentationVersion)(nil))
}

func (o DocumentationVersionOutput) ToDocumentationVersionOutput() DocumentationVersionOutput {
	return o
}

func (o DocumentationVersionOutput) ToDocumentationVersionOutputWithContext(ctx context.Context) DocumentationVersionOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(DocumentationVersionOutput{})
}