// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package wafregional

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::WAFRegional::GeoMatchSet
//
// Deprecated: GeoMatchSet is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.
type GeoMatchSet struct {
	pulumi.CustomResourceState

	GeoMatchConstraints GeoMatchSetGeoMatchConstraintArrayOutput `pulumi:"geoMatchConstraints"`
	Name                pulumi.StringOutput                      `pulumi:"name"`
}

// NewGeoMatchSet registers a new resource with the given unique name, arguments, and options.
func NewGeoMatchSet(ctx *pulumi.Context,
	name string, args *GeoMatchSetArgs, opts ...pulumi.ResourceOption) (*GeoMatchSet, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Name == nil {
		return nil, errors.New("invalid value for required argument 'Name'")
	}
	var resource GeoMatchSet
	err := ctx.RegisterResource("aws-native:wafregional:GeoMatchSet", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetGeoMatchSet gets an existing GeoMatchSet resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetGeoMatchSet(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *GeoMatchSetState, opts ...pulumi.ResourceOption) (*GeoMatchSet, error) {
	var resource GeoMatchSet
	err := ctx.ReadResource("aws-native:wafregional:GeoMatchSet", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering GeoMatchSet resources.
type geoMatchSetState struct {
}

type GeoMatchSetState struct {
}

func (GeoMatchSetState) ElementType() reflect.Type {
	return reflect.TypeOf((*geoMatchSetState)(nil)).Elem()
}

type geoMatchSetArgs struct {
	GeoMatchConstraints []GeoMatchSetGeoMatchConstraint `pulumi:"geoMatchConstraints"`
	Name                string                          `pulumi:"name"`
}

// The set of arguments for constructing a GeoMatchSet resource.
type GeoMatchSetArgs struct {
	GeoMatchConstraints GeoMatchSetGeoMatchConstraintArrayInput
	Name                pulumi.StringInput
}

func (GeoMatchSetArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*geoMatchSetArgs)(nil)).Elem()
}

type GeoMatchSetInput interface {
	pulumi.Input

	ToGeoMatchSetOutput() GeoMatchSetOutput
	ToGeoMatchSetOutputWithContext(ctx context.Context) GeoMatchSetOutput
}

func (*GeoMatchSet) ElementType() reflect.Type {
	return reflect.TypeOf((*GeoMatchSet)(nil))
}

func (i *GeoMatchSet) ToGeoMatchSetOutput() GeoMatchSetOutput {
	return i.ToGeoMatchSetOutputWithContext(context.Background())
}

func (i *GeoMatchSet) ToGeoMatchSetOutputWithContext(ctx context.Context) GeoMatchSetOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GeoMatchSetOutput)
}

type GeoMatchSetOutput struct{ *pulumi.OutputState }

func (GeoMatchSetOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GeoMatchSet)(nil))
}

func (o GeoMatchSetOutput) ToGeoMatchSetOutput() GeoMatchSetOutput {
	return o
}

func (o GeoMatchSetOutput) ToGeoMatchSetOutputWithContext(ctx context.Context) GeoMatchSetOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(GeoMatchSetOutput{})
}