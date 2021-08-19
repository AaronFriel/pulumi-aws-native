// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ssmcontacts

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmcontacts-contact.html
type Contact struct {
	pulumi.CustomResourceState

	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmcontacts-contact.html#cfn-ssmcontacts-contact-alias
	Alias pulumi.StringOutput `pulumi:"alias"`
	Arn   pulumi.StringOutput `pulumi:"arn"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmcontacts-contact.html#cfn-ssmcontacts-contact-displayname
	DisplayName pulumi.StringOutput `pulumi:"displayName"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmcontacts-contact.html#cfn-ssmcontacts-contact-plan
	Plan ContactStageArrayOutput `pulumi:"plan"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmcontacts-contact.html#cfn-ssmcontacts-contact-type
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewContact registers a new resource with the given unique name, arguments, and options.
func NewContact(ctx *pulumi.Context,
	name string, args *ContactArgs, opts ...pulumi.ResourceOption) (*Contact, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Alias == nil {
		return nil, errors.New("invalid value for required argument 'Alias'")
	}
	if args.DisplayName == nil {
		return nil, errors.New("invalid value for required argument 'DisplayName'")
	}
	if args.Plan == nil {
		return nil, errors.New("invalid value for required argument 'Plan'")
	}
	if args.Type == nil {
		return nil, errors.New("invalid value for required argument 'Type'")
	}
	var resource Contact
	err := ctx.RegisterResource("aws-native:SSMContacts:Contact", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetContact gets an existing Contact resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetContact(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ContactState, opts ...pulumi.ResourceOption) (*Contact, error) {
	var resource Contact
	err := ctx.ReadResource("aws-native:SSMContacts:Contact", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Contact resources.
type contactState struct {
}

type ContactState struct {
}

func (ContactState) ElementType() reflect.Type {
	return reflect.TypeOf((*contactState)(nil)).Elem()
}

type contactArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmcontacts-contact.html#cfn-ssmcontacts-contact-alias
	Alias string `pulumi:"alias"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmcontacts-contact.html#cfn-ssmcontacts-contact-displayname
	DisplayName string `pulumi:"displayName"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmcontacts-contact.html#cfn-ssmcontacts-contact-plan
	Plan []ContactStage `pulumi:"plan"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmcontacts-contact.html#cfn-ssmcontacts-contact-type
	Type string `pulumi:"type"`
}

// The set of arguments for constructing a Contact resource.
type ContactArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmcontacts-contact.html#cfn-ssmcontacts-contact-alias
	Alias pulumi.StringInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmcontacts-contact.html#cfn-ssmcontacts-contact-displayname
	DisplayName pulumi.StringInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmcontacts-contact.html#cfn-ssmcontacts-contact-plan
	Plan ContactStageArrayInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmcontacts-contact.html#cfn-ssmcontacts-contact-type
	Type pulumi.StringInput
}

func (ContactArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*contactArgs)(nil)).Elem()
}

type ContactInput interface {
	pulumi.Input

	ToContactOutput() ContactOutput
	ToContactOutputWithContext(ctx context.Context) ContactOutput
}

func (*Contact) ElementType() reflect.Type {
	return reflect.TypeOf((*Contact)(nil))
}

func (i *Contact) ToContactOutput() ContactOutput {
	return i.ToContactOutputWithContext(context.Background())
}

func (i *Contact) ToContactOutputWithContext(ctx context.Context) ContactOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ContactOutput)
}

type ContactOutput struct{ *pulumi.OutputState }

func (ContactOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Contact)(nil))
}

func (o ContactOutput) ToContactOutput() ContactOutput {
	return o
}

func (o ContactOutput) ToContactOutputWithContext(ctx context.Context) ContactOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ContactOutput{})
}