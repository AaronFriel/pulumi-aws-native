// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package macie

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// The AWS::Macie::Session resource specifies a new Amazon Macie session. A session is an object that represents the Amazon Macie service. A session is required for Amazon Macie to become operational.
type Session struct {
	pulumi.CustomResourceState

	// AWS account ID of customer
	AwsAccountId pulumi.StringOutput `pulumi:"awsAccountId"`
	// A enumeration value that specifies how frequently finding updates are published.
	FindingPublishingFrequency pulumi.StringPtrOutput `pulumi:"findingPublishingFrequency"`
	// Service role used by Macie
	ServiceRole pulumi.StringOutput `pulumi:"serviceRole"`
	// A enumeration value that specifies the status of the Macie Session.
	Status pulumi.StringPtrOutput `pulumi:"status"`
}

// NewSession registers a new resource with the given unique name, arguments, and options.
func NewSession(ctx *pulumi.Context,
	name string, args *SessionArgs, opts ...pulumi.ResourceOption) (*Session, error) {
	if args == nil {
		args = &SessionArgs{}
	}

	var resource Session
	err := ctx.RegisterResource("aws-native:macie:Session", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSession gets an existing Session resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSession(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SessionState, opts ...pulumi.ResourceOption) (*Session, error) {
	var resource Session
	err := ctx.ReadResource("aws-native:macie:Session", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Session resources.
type sessionState struct {
}

type SessionState struct {
}

func (SessionState) ElementType() reflect.Type {
	return reflect.TypeOf((*sessionState)(nil)).Elem()
}

type sessionArgs struct {
	// A enumeration value that specifies how frequently finding updates are published.
	FindingPublishingFrequency *string `pulumi:"findingPublishingFrequency"`
	// A enumeration value that specifies the status of the Macie Session.
	Status *string `pulumi:"status"`
}

// The set of arguments for constructing a Session resource.
type SessionArgs struct {
	// A enumeration value that specifies how frequently finding updates are published.
	FindingPublishingFrequency pulumi.StringPtrInput
	// A enumeration value that specifies the status of the Macie Session.
	Status pulumi.StringPtrInput
}

func (SessionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*sessionArgs)(nil)).Elem()
}

type SessionInput interface {
	pulumi.Input

	ToSessionOutput() SessionOutput
	ToSessionOutputWithContext(ctx context.Context) SessionOutput
}

func (*Session) ElementType() reflect.Type {
	return reflect.TypeOf((*Session)(nil))
}

func (i *Session) ToSessionOutput() SessionOutput {
	return i.ToSessionOutputWithContext(context.Background())
}

func (i *Session) ToSessionOutputWithContext(ctx context.Context) SessionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SessionOutput)
}

type SessionOutput struct{ *pulumi.OutputState }

func (SessionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Session)(nil))
}

func (o SessionOutput) ToSessionOutput() SessionOutput {
	return o
}

func (o SessionOutput) ToSessionOutputWithContext(ctx context.Context) SessionOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(SessionOutput{})
}
