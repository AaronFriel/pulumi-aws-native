// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package servicecatalog

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::ServiceCatalog::PortfolioShare
//
// Deprecated: PortfolioShare is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type PortfolioShare struct {
	pulumi.CustomResourceState

	AcceptLanguage  pulumi.StringPtrOutput `pulumi:"acceptLanguage"`
	AccountId       pulumi.StringOutput    `pulumi:"accountId"`
	PortfolioId     pulumi.StringOutput    `pulumi:"portfolioId"`
	ShareTagOptions pulumi.BoolPtrOutput   `pulumi:"shareTagOptions"`
}

// NewPortfolioShare registers a new resource with the given unique name, arguments, and options.
func NewPortfolioShare(ctx *pulumi.Context,
	name string, args *PortfolioShareArgs, opts ...pulumi.ResourceOption) (*PortfolioShare, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AccountId == nil {
		return nil, errors.New("invalid value for required argument 'AccountId'")
	}
	if args.PortfolioId == nil {
		return nil, errors.New("invalid value for required argument 'PortfolioId'")
	}
	var resource PortfolioShare
	err := ctx.RegisterResource("aws-native:servicecatalog:PortfolioShare", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPortfolioShare gets an existing PortfolioShare resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPortfolioShare(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PortfolioShareState, opts ...pulumi.ResourceOption) (*PortfolioShare, error) {
	var resource PortfolioShare
	err := ctx.ReadResource("aws-native:servicecatalog:PortfolioShare", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering PortfolioShare resources.
type portfolioShareState struct {
}

type PortfolioShareState struct {
}

func (PortfolioShareState) ElementType() reflect.Type {
	return reflect.TypeOf((*portfolioShareState)(nil)).Elem()
}

type portfolioShareArgs struct {
	AcceptLanguage  *string `pulumi:"acceptLanguage"`
	AccountId       string  `pulumi:"accountId"`
	PortfolioId     string  `pulumi:"portfolioId"`
	ShareTagOptions *bool   `pulumi:"shareTagOptions"`
}

// The set of arguments for constructing a PortfolioShare resource.
type PortfolioShareArgs struct {
	AcceptLanguage  pulumi.StringPtrInput
	AccountId       pulumi.StringInput
	PortfolioId     pulumi.StringInput
	ShareTagOptions pulumi.BoolPtrInput
}

func (PortfolioShareArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*portfolioShareArgs)(nil)).Elem()
}

type PortfolioShareInput interface {
	pulumi.Input

	ToPortfolioShareOutput() PortfolioShareOutput
	ToPortfolioShareOutputWithContext(ctx context.Context) PortfolioShareOutput
}

func (*PortfolioShare) ElementType() reflect.Type {
	return reflect.TypeOf((*PortfolioShare)(nil))
}

func (i *PortfolioShare) ToPortfolioShareOutput() PortfolioShareOutput {
	return i.ToPortfolioShareOutputWithContext(context.Background())
}

func (i *PortfolioShare) ToPortfolioShareOutputWithContext(ctx context.Context) PortfolioShareOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PortfolioShareOutput)
}

type PortfolioShareOutput struct{ *pulumi.OutputState }

func (PortfolioShareOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*PortfolioShare)(nil))
}

func (o PortfolioShareOutput) ToPortfolioShareOutput() PortfolioShareOutput {
	return o
}

func (o PortfolioShareOutput) ToPortfolioShareOutputWithContext(ctx context.Context) PortfolioShareOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*PortfolioShareInput)(nil)).Elem(), &PortfolioShare{})
	pulumi.RegisterOutputType(PortfolioShareOutput{})
}
