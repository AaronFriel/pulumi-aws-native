// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package iot

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// A security profile defines a set of expected behaviors for devices in your account.
type SecurityProfile struct {
	pulumi.CustomResourceState

	// A list of metrics whose data is retained (stored). By default, data is retained for any metric used in the profile's behaviors, but it is also retained for any metric specified here.
	AdditionalMetricsToRetainV2 SecurityProfileMetricToRetainArrayOutput `pulumi:"additionalMetricsToRetainV2"`
	// Specifies the destinations to which alerts are sent.
	AlertTargets pulumi.AnyOutput `pulumi:"alertTargets"`
	// Specifies the behaviors that, when violated by a device (thing), cause an alert.
	Behaviors SecurityProfileBehaviorArrayOutput `pulumi:"behaviors"`
	// The ARN (Amazon resource name) of the created security profile.
	SecurityProfileArn pulumi.StringOutput `pulumi:"securityProfileArn"`
	// A description of the security profile.
	SecurityProfileDescription pulumi.StringPtrOutput `pulumi:"securityProfileDescription"`
	// A unique identifier for the security profile.
	SecurityProfileName pulumi.StringPtrOutput `pulumi:"securityProfileName"`
	// Metadata that can be used to manage the security profile.
	Tags SecurityProfileTagArrayOutput `pulumi:"tags"`
	// A set of target ARNs that the security profile is attached to.
	TargetArns pulumi.StringArrayOutput `pulumi:"targetArns"`
}

// NewSecurityProfile registers a new resource with the given unique name, arguments, and options.
func NewSecurityProfile(ctx *pulumi.Context,
	name string, args *SecurityProfileArgs, opts ...pulumi.ResourceOption) (*SecurityProfile, error) {
	if args == nil {
		args = &SecurityProfileArgs{}
	}

	var resource SecurityProfile
	err := ctx.RegisterResource("aws-native:iot:SecurityProfile", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSecurityProfile gets an existing SecurityProfile resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSecurityProfile(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SecurityProfileState, opts ...pulumi.ResourceOption) (*SecurityProfile, error) {
	var resource SecurityProfile
	err := ctx.ReadResource("aws-native:iot:SecurityProfile", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SecurityProfile resources.
type securityProfileState struct {
}

type SecurityProfileState struct {
}

func (SecurityProfileState) ElementType() reflect.Type {
	return reflect.TypeOf((*securityProfileState)(nil)).Elem()
}

type securityProfileArgs struct {
	// A list of metrics whose data is retained (stored). By default, data is retained for any metric used in the profile's behaviors, but it is also retained for any metric specified here.
	AdditionalMetricsToRetainV2 []SecurityProfileMetricToRetain `pulumi:"additionalMetricsToRetainV2"`
	// Specifies the destinations to which alerts are sent.
	AlertTargets interface{} `pulumi:"alertTargets"`
	// Specifies the behaviors that, when violated by a device (thing), cause an alert.
	Behaviors []SecurityProfileBehavior `pulumi:"behaviors"`
	// A description of the security profile.
	SecurityProfileDescription *string `pulumi:"securityProfileDescription"`
	// A unique identifier for the security profile.
	SecurityProfileName *string `pulumi:"securityProfileName"`
	// Metadata that can be used to manage the security profile.
	Tags []SecurityProfileTag `pulumi:"tags"`
	// A set of target ARNs that the security profile is attached to.
	TargetArns []string `pulumi:"targetArns"`
}

// The set of arguments for constructing a SecurityProfile resource.
type SecurityProfileArgs struct {
	// A list of metrics whose data is retained (stored). By default, data is retained for any metric used in the profile's behaviors, but it is also retained for any metric specified here.
	AdditionalMetricsToRetainV2 SecurityProfileMetricToRetainArrayInput
	// Specifies the destinations to which alerts are sent.
	AlertTargets pulumi.Input
	// Specifies the behaviors that, when violated by a device (thing), cause an alert.
	Behaviors SecurityProfileBehaviorArrayInput
	// A description of the security profile.
	SecurityProfileDescription pulumi.StringPtrInput
	// A unique identifier for the security profile.
	SecurityProfileName pulumi.StringPtrInput
	// Metadata that can be used to manage the security profile.
	Tags SecurityProfileTagArrayInput
	// A set of target ARNs that the security profile is attached to.
	TargetArns pulumi.StringArrayInput
}

func (SecurityProfileArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*securityProfileArgs)(nil)).Elem()
}

type SecurityProfileInput interface {
	pulumi.Input

	ToSecurityProfileOutput() SecurityProfileOutput
	ToSecurityProfileOutputWithContext(ctx context.Context) SecurityProfileOutput
}

func (*SecurityProfile) ElementType() reflect.Type {
	return reflect.TypeOf((*SecurityProfile)(nil))
}

func (i *SecurityProfile) ToSecurityProfileOutput() SecurityProfileOutput {
	return i.ToSecurityProfileOutputWithContext(context.Background())
}

func (i *SecurityProfile) ToSecurityProfileOutputWithContext(ctx context.Context) SecurityProfileOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SecurityProfileOutput)
}

type SecurityProfileOutput struct{ *pulumi.OutputState }

func (SecurityProfileOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SecurityProfile)(nil))
}

func (o SecurityProfileOutput) ToSecurityProfileOutput() SecurityProfileOutput {
	return o
}

func (o SecurityProfileOutput) ToSecurityProfileOutputWithContext(ctx context.Context) SecurityProfileOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*SecurityProfileInput)(nil)).Elem(), &SecurityProfile{})
	pulumi.RegisterOutputType(SecurityProfileOutput{})
}
