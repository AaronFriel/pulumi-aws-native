// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package waf

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::WAF::IPSet
//
// Deprecated: IPSet is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type IPSet struct {
	pulumi.CustomResourceState

	IPSetDescriptors IPSetDescriptorArrayOutput `pulumi:"iPSetDescriptors"`
	Name             pulumi.StringOutput        `pulumi:"name"`
}

// NewIPSet registers a new resource with the given unique name, arguments, and options.
func NewIPSet(ctx *pulumi.Context,
	name string, args *IPSetArgs, opts ...pulumi.ResourceOption) (*IPSet, error) {
	if args == nil {
		args = &IPSetArgs{}
	}

	var resource IPSet
	err := ctx.RegisterResource("aws-native:waf:IPSet", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetIPSet gets an existing IPSet resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetIPSet(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *IPSetState, opts ...pulumi.ResourceOption) (*IPSet, error) {
	var resource IPSet
	err := ctx.ReadResource("aws-native:waf:IPSet", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering IPSet resources.
type ipsetState struct {
}

type IPSetState struct {
}

func (IPSetState) ElementType() reflect.Type {
	return reflect.TypeOf((*ipsetState)(nil)).Elem()
}

type ipsetArgs struct {
	IPSetDescriptors []IPSetDescriptor `pulumi:"iPSetDescriptors"`
	Name             *string           `pulumi:"name"`
}

// The set of arguments for constructing a IPSet resource.
type IPSetArgs struct {
	IPSetDescriptors IPSetDescriptorArrayInput
	Name             pulumi.StringPtrInput
}

func (IPSetArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ipsetArgs)(nil)).Elem()
}

type IPSetInput interface {
	pulumi.Input

	ToIPSetOutput() IPSetOutput
	ToIPSetOutputWithContext(ctx context.Context) IPSetOutput
}

func (*IPSet) ElementType() reflect.Type {
	return reflect.TypeOf((*IPSet)(nil))
}

func (i *IPSet) ToIPSetOutput() IPSetOutput {
	return i.ToIPSetOutputWithContext(context.Background())
}

func (i *IPSet) ToIPSetOutputWithContext(ctx context.Context) IPSetOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IPSetOutput)
}

type IPSetOutput struct{ *pulumi.OutputState }

func (IPSetOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*IPSet)(nil))
}

func (o IPSetOutput) ToIPSetOutput() IPSetOutput {
	return o
}

func (o IPSetOutput) ToIPSetOutputWithContext(ctx context.Context) IPSetOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*IPSetInput)(nil)).Elem(), &IPSet{})
	pulumi.RegisterOutputType(IPSetOutput{})
}
