// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package customerprofiles

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// A domain defined for 3rd party data source in Profile Service
type Domain struct {
	pulumi.CustomResourceState

	// The time of this integration got created
	CreatedAt pulumi.StringOutput `pulumi:"createdAt"`
	// The URL of the SQS dead letter queue
	DeadLetterQueueUrl pulumi.StringPtrOutput `pulumi:"deadLetterQueueUrl"`
	// The default encryption key
	DefaultEncryptionKey pulumi.StringPtrOutput `pulumi:"defaultEncryptionKey"`
	// The default number of days until the data within the domain expires.
	DefaultExpirationDays pulumi.IntPtrOutput `pulumi:"defaultExpirationDays"`
	// The unique name of the domain.
	DomainName pulumi.StringOutput `pulumi:"domainName"`
	// The time of this integration got last updated at
	LastUpdatedAt pulumi.StringOutput `pulumi:"lastUpdatedAt"`
	// The tags (keys and values) associated with the domain
	Tags DomainTagArrayOutput `pulumi:"tags"`
}

// NewDomain registers a new resource with the given unique name, arguments, and options.
func NewDomain(ctx *pulumi.Context,
	name string, args *DomainArgs, opts ...pulumi.ResourceOption) (*Domain, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DomainName == nil {
		return nil, errors.New("invalid value for required argument 'DomainName'")
	}
	var resource Domain
	err := ctx.RegisterResource("aws-native:customerprofiles:Domain", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDomain gets an existing Domain resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDomain(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DomainState, opts ...pulumi.ResourceOption) (*Domain, error) {
	var resource Domain
	err := ctx.ReadResource("aws-native:customerprofiles:Domain", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Domain resources.
type domainState struct {
}

type DomainState struct {
}

func (DomainState) ElementType() reflect.Type {
	return reflect.TypeOf((*domainState)(nil)).Elem()
}

type domainArgs struct {
	// The URL of the SQS dead letter queue
	DeadLetterQueueUrl *string `pulumi:"deadLetterQueueUrl"`
	// The default encryption key
	DefaultEncryptionKey *string `pulumi:"defaultEncryptionKey"`
	// The default number of days until the data within the domain expires.
	DefaultExpirationDays *int `pulumi:"defaultExpirationDays"`
	// The unique name of the domain.
	DomainName string `pulumi:"domainName"`
	// The tags (keys and values) associated with the domain
	Tags []DomainTag `pulumi:"tags"`
}

// The set of arguments for constructing a Domain resource.
type DomainArgs struct {
	// The URL of the SQS dead letter queue
	DeadLetterQueueUrl pulumi.StringPtrInput
	// The default encryption key
	DefaultEncryptionKey pulumi.StringPtrInput
	// The default number of days until the data within the domain expires.
	DefaultExpirationDays pulumi.IntPtrInput
	// The unique name of the domain.
	DomainName pulumi.StringInput
	// The tags (keys and values) associated with the domain
	Tags DomainTagArrayInput
}

func (DomainArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*domainArgs)(nil)).Elem()
}

type DomainInput interface {
	pulumi.Input

	ToDomainOutput() DomainOutput
	ToDomainOutputWithContext(ctx context.Context) DomainOutput
}

func (*Domain) ElementType() reflect.Type {
	return reflect.TypeOf((*Domain)(nil))
}

func (i *Domain) ToDomainOutput() DomainOutput {
	return i.ToDomainOutputWithContext(context.Background())
}

func (i *Domain) ToDomainOutputWithContext(ctx context.Context) DomainOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DomainOutput)
}

type DomainOutput struct{ *pulumi.OutputState }

func (DomainOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Domain)(nil))
}

func (o DomainOutput) ToDomainOutput() DomainOutput {
	return o
}

func (o DomainOutput) ToDomainOutputWithContext(ctx context.Context) DomainOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(DomainOutput{})
}
