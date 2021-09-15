// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package s3

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// The policy to be attached to a Multi Region Access Point
type MultiRegionAccessPointPolicy struct {
	pulumi.CustomResourceState

	// The name of the Multi Region Access Point to apply policy
	MrapName pulumi.StringOutput `pulumi:"mrapName"`
	// Policy document to apply to a Multi Region Access Point
	Policy pulumi.AnyOutput `pulumi:"policy"`
	// The Policy Status associated with this Multi Region Access Point
	PolicyStatus pulumi.AnyOutput `pulumi:"policyStatus"`
}

// NewMultiRegionAccessPointPolicy registers a new resource with the given unique name, arguments, and options.
func NewMultiRegionAccessPointPolicy(ctx *pulumi.Context,
	name string, args *MultiRegionAccessPointPolicyArgs, opts ...pulumi.ResourceOption) (*MultiRegionAccessPointPolicy, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.MrapName == nil {
		return nil, errors.New("invalid value for required argument 'MrapName'")
	}
	if args.Policy == nil {
		return nil, errors.New("invalid value for required argument 'Policy'")
	}
	var resource MultiRegionAccessPointPolicy
	err := ctx.RegisterResource("aws-native:s3:MultiRegionAccessPointPolicy", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetMultiRegionAccessPointPolicy gets an existing MultiRegionAccessPointPolicy resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMultiRegionAccessPointPolicy(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *MultiRegionAccessPointPolicyState, opts ...pulumi.ResourceOption) (*MultiRegionAccessPointPolicy, error) {
	var resource MultiRegionAccessPointPolicy
	err := ctx.ReadResource("aws-native:s3:MultiRegionAccessPointPolicy", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering MultiRegionAccessPointPolicy resources.
type multiRegionAccessPointPolicyState struct {
}

type MultiRegionAccessPointPolicyState struct {
}

func (MultiRegionAccessPointPolicyState) ElementType() reflect.Type {
	return reflect.TypeOf((*multiRegionAccessPointPolicyState)(nil)).Elem()
}

type multiRegionAccessPointPolicyArgs struct {
	// The name of the Multi Region Access Point to apply policy
	MrapName string `pulumi:"mrapName"`
	// Policy document to apply to a Multi Region Access Point
	Policy interface{} `pulumi:"policy"`
}

// The set of arguments for constructing a MultiRegionAccessPointPolicy resource.
type MultiRegionAccessPointPolicyArgs struct {
	// The name of the Multi Region Access Point to apply policy
	MrapName pulumi.StringInput
	// Policy document to apply to a Multi Region Access Point
	Policy pulumi.Input
}

func (MultiRegionAccessPointPolicyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*multiRegionAccessPointPolicyArgs)(nil)).Elem()
}

type MultiRegionAccessPointPolicyInput interface {
	pulumi.Input

	ToMultiRegionAccessPointPolicyOutput() MultiRegionAccessPointPolicyOutput
	ToMultiRegionAccessPointPolicyOutputWithContext(ctx context.Context) MultiRegionAccessPointPolicyOutput
}

func (*MultiRegionAccessPointPolicy) ElementType() reflect.Type {
	return reflect.TypeOf((*MultiRegionAccessPointPolicy)(nil))
}

func (i *MultiRegionAccessPointPolicy) ToMultiRegionAccessPointPolicyOutput() MultiRegionAccessPointPolicyOutput {
	return i.ToMultiRegionAccessPointPolicyOutputWithContext(context.Background())
}

func (i *MultiRegionAccessPointPolicy) ToMultiRegionAccessPointPolicyOutputWithContext(ctx context.Context) MultiRegionAccessPointPolicyOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MultiRegionAccessPointPolicyOutput)
}

type MultiRegionAccessPointPolicyOutput struct{ *pulumi.OutputState }

func (MultiRegionAccessPointPolicyOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*MultiRegionAccessPointPolicy)(nil))
}

func (o MultiRegionAccessPointPolicyOutput) ToMultiRegionAccessPointPolicyOutput() MultiRegionAccessPointPolicyOutput {
	return o
}

func (o MultiRegionAccessPointPolicyOutput) ToMultiRegionAccessPointPolicyOutputWithContext(ctx context.Context) MultiRegionAccessPointPolicyOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(MultiRegionAccessPointPolicyOutput{})
}
