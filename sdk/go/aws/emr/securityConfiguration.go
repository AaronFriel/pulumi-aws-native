// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package emr

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::EMR::SecurityConfiguration
//
// Deprecated: SecurityConfiguration is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type SecurityConfiguration struct {
	pulumi.CustomResourceState

	Name                  pulumi.StringPtrOutput `pulumi:"name"`
	SecurityConfiguration pulumi.AnyOutput       `pulumi:"securityConfiguration"`
}

// NewSecurityConfiguration registers a new resource with the given unique name, arguments, and options.
func NewSecurityConfiguration(ctx *pulumi.Context,
	name string, args *SecurityConfigurationArgs, opts ...pulumi.ResourceOption) (*SecurityConfiguration, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.SecurityConfiguration == nil {
		return nil, errors.New("invalid value for required argument 'SecurityConfiguration'")
	}
	var resource SecurityConfiguration
	err := ctx.RegisterResource("aws-native:emr:SecurityConfiguration", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSecurityConfiguration gets an existing SecurityConfiguration resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSecurityConfiguration(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SecurityConfigurationState, opts ...pulumi.ResourceOption) (*SecurityConfiguration, error) {
	var resource SecurityConfiguration
	err := ctx.ReadResource("aws-native:emr:SecurityConfiguration", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SecurityConfiguration resources.
type securityConfigurationState struct {
}

type SecurityConfigurationState struct {
}

func (SecurityConfigurationState) ElementType() reflect.Type {
	return reflect.TypeOf((*securityConfigurationState)(nil)).Elem()
}

type securityConfigurationArgs struct {
	Name                  *string     `pulumi:"name"`
	SecurityConfiguration interface{} `pulumi:"securityConfiguration"`
}

// The set of arguments for constructing a SecurityConfiguration resource.
type SecurityConfigurationArgs struct {
	Name                  pulumi.StringPtrInput
	SecurityConfiguration pulumi.Input
}

func (SecurityConfigurationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*securityConfigurationArgs)(nil)).Elem()
}

type SecurityConfigurationInput interface {
	pulumi.Input

	ToSecurityConfigurationOutput() SecurityConfigurationOutput
	ToSecurityConfigurationOutputWithContext(ctx context.Context) SecurityConfigurationOutput
}

func (*SecurityConfiguration) ElementType() reflect.Type {
	return reflect.TypeOf((*SecurityConfiguration)(nil))
}

func (i *SecurityConfiguration) ToSecurityConfigurationOutput() SecurityConfigurationOutput {
	return i.ToSecurityConfigurationOutputWithContext(context.Background())
}

func (i *SecurityConfiguration) ToSecurityConfigurationOutputWithContext(ctx context.Context) SecurityConfigurationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SecurityConfigurationOutput)
}

type SecurityConfigurationOutput struct{ *pulumi.OutputState }

func (SecurityConfigurationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SecurityConfiguration)(nil))
}

func (o SecurityConfigurationOutput) ToSecurityConfigurationOutput() SecurityConfigurationOutput {
	return o
}

func (o SecurityConfigurationOutput) ToSecurityConfigurationOutputWithContext(ctx context.Context) SecurityConfigurationOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*SecurityConfigurationInput)(nil)).Elem(), &SecurityConfiguration{})
	pulumi.RegisterOutputType(SecurityConfigurationOutput{})
}
