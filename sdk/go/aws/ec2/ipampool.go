// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ec2

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Schema of AWS::EC2::IPAMPool Type
type IPAMPool struct {
	pulumi.CustomResourceState

	// The address family of the address space in this pool. Either IPv4 or IPv6.
	AddressFamily IPAMPoolAddressFamilyOutput `pulumi:"addressFamily"`
	// The default netmask length for allocations made from this pool. This value is used when the netmask length of an allocation isn't specified.
	AllocationDefaultNetmaskLength pulumi.IntPtrOutput `pulumi:"allocationDefaultNetmaskLength"`
	// The maximum allowed netmask length for allocations made from this pool.
	AllocationMaxNetmaskLength pulumi.IntPtrOutput `pulumi:"allocationMaxNetmaskLength"`
	// The minimum allowed netmask length for allocations made from this pool.
	AllocationMinNetmaskLength pulumi.IntPtrOutput `pulumi:"allocationMinNetmaskLength"`
	// When specified, an allocation will not be allowed unless a resource has a matching set of tags.
	AllocationResourceTags IPAMPoolTagArrayOutput `pulumi:"allocationResourceTags"`
	// The Amazon Resource Name (ARN) of the IPAM Pool.
	Arn pulumi.StringOutput `pulumi:"arn"`
	// Determines what to do if IPAM discovers resources that haven't been assigned an allocation. If set to true, an allocation will be made automatically.
	AutoImport  pulumi.BoolPtrOutput   `pulumi:"autoImport"`
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The Amazon Resource Name (ARN) of the IPAM this pool is a part of.
	IpamArn pulumi.StringOutput `pulumi:"ipamArn"`
	// Id of the IPAM Pool.
	IpamPoolId pulumi.StringOutput `pulumi:"ipamPoolId"`
	// The Amazon Resource Name (ARN) of the scope this pool is a part of.
	IpamScopeArn pulumi.StringOutput `pulumi:"ipamScopeArn"`
	// The Id of the scope this pool is a part of.
	IpamScopeId pulumi.StringOutput `pulumi:"ipamScopeId"`
	// Determines whether this scope contains publicly routable space or space for a private network
	IpamScopeType IPAMPoolIpamScopeTypeOutput `pulumi:"ipamScopeType"`
	// The region of this pool. If not set, this will default to "None" which will disable non-custom allocations. If the locale has been specified for the source pool, this value must match.
	Locale pulumi.StringPtrOutput `pulumi:"locale"`
	// The depth of this pool in the source pool hierarchy.
	PoolDepth pulumi.IntOutput `pulumi:"poolDepth"`
	// A list of cidrs representing the address space available for allocation in this pool.
	ProvisionedCidrs IPAMPoolProvisionedCidrArrayOutput `pulumi:"provisionedCidrs"`
	// Determines whether or not address space from this pool is publicly advertised. Must be set if and only if the pool is IPv6.
	PubliclyAdvertisable pulumi.BoolPtrOutput `pulumi:"publiclyAdvertisable"`
	// The Id of this pool's source. If set, all space provisioned in this pool must be free space provisioned in the parent pool.
	SourceIpamPoolId pulumi.StringPtrOutput `pulumi:"sourceIpamPoolId"`
	// The state of this pool. This can be one of the following values: "create-in-progress", "create-complete", "modify-in-progress", "modify-complete", "delete-in-progress", or "delete-complete"
	State IPAMPoolStateEnumOutput `pulumi:"state"`
	// An explanation of how the pool arrived at it current state.
	StateMessage pulumi.StringOutput `pulumi:"stateMessage"`
	// An array of key-value pairs to apply to this resource.
	Tags IPAMPoolTagArrayOutput `pulumi:"tags"`
}

// NewIPAMPool registers a new resource with the given unique name, arguments, and options.
func NewIPAMPool(ctx *pulumi.Context,
	name string, args *IPAMPoolArgs, opts ...pulumi.ResourceOption) (*IPAMPool, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AddressFamily == nil {
		return nil, errors.New("invalid value for required argument 'AddressFamily'")
	}
	if args.IpamScopeId == nil {
		return nil, errors.New("invalid value for required argument 'IpamScopeId'")
	}
	var resource IPAMPool
	err := ctx.RegisterResource("aws-native:ec2:IPAMPool", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetIPAMPool gets an existing IPAMPool resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetIPAMPool(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *IPAMPoolState, opts ...pulumi.ResourceOption) (*IPAMPool, error) {
	var resource IPAMPool
	err := ctx.ReadResource("aws-native:ec2:IPAMPool", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering IPAMPool resources.
type ipampoolState struct {
}

type IPAMPoolState struct {
}

func (IPAMPoolState) ElementType() reflect.Type {
	return reflect.TypeOf((*ipampoolState)(nil)).Elem()
}

type ipampoolArgs struct {
	// The address family of the address space in this pool. Either IPv4 or IPv6.
	AddressFamily IPAMPoolAddressFamily `pulumi:"addressFamily"`
	// The default netmask length for allocations made from this pool. This value is used when the netmask length of an allocation isn't specified.
	AllocationDefaultNetmaskLength *int `pulumi:"allocationDefaultNetmaskLength"`
	// The maximum allowed netmask length for allocations made from this pool.
	AllocationMaxNetmaskLength *int `pulumi:"allocationMaxNetmaskLength"`
	// The minimum allowed netmask length for allocations made from this pool.
	AllocationMinNetmaskLength *int `pulumi:"allocationMinNetmaskLength"`
	// When specified, an allocation will not be allowed unless a resource has a matching set of tags.
	AllocationResourceTags []IPAMPoolTag `pulumi:"allocationResourceTags"`
	// Determines what to do if IPAM discovers resources that haven't been assigned an allocation. If set to true, an allocation will be made automatically.
	AutoImport  *bool   `pulumi:"autoImport"`
	Description *string `pulumi:"description"`
	// The Id of the scope this pool is a part of.
	IpamScopeId string `pulumi:"ipamScopeId"`
	// The region of this pool. If not set, this will default to "None" which will disable non-custom allocations. If the locale has been specified for the source pool, this value must match.
	Locale *string `pulumi:"locale"`
	// A list of cidrs representing the address space available for allocation in this pool.
	ProvisionedCidrs []IPAMPoolProvisionedCidr `pulumi:"provisionedCidrs"`
	// Determines whether or not address space from this pool is publicly advertised. Must be set if and only if the pool is IPv6.
	PubliclyAdvertisable *bool `pulumi:"publiclyAdvertisable"`
	// The Id of this pool's source. If set, all space provisioned in this pool must be free space provisioned in the parent pool.
	SourceIpamPoolId *string `pulumi:"sourceIpamPoolId"`
	// An array of key-value pairs to apply to this resource.
	Tags []IPAMPoolTag `pulumi:"tags"`
}

// The set of arguments for constructing a IPAMPool resource.
type IPAMPoolArgs struct {
	// The address family of the address space in this pool. Either IPv4 or IPv6.
	AddressFamily IPAMPoolAddressFamilyInput
	// The default netmask length for allocations made from this pool. This value is used when the netmask length of an allocation isn't specified.
	AllocationDefaultNetmaskLength pulumi.IntPtrInput
	// The maximum allowed netmask length for allocations made from this pool.
	AllocationMaxNetmaskLength pulumi.IntPtrInput
	// The minimum allowed netmask length for allocations made from this pool.
	AllocationMinNetmaskLength pulumi.IntPtrInput
	// When specified, an allocation will not be allowed unless a resource has a matching set of tags.
	AllocationResourceTags IPAMPoolTagArrayInput
	// Determines what to do if IPAM discovers resources that haven't been assigned an allocation. If set to true, an allocation will be made automatically.
	AutoImport  pulumi.BoolPtrInput
	Description pulumi.StringPtrInput
	// The Id of the scope this pool is a part of.
	IpamScopeId pulumi.StringInput
	// The region of this pool. If not set, this will default to "None" which will disable non-custom allocations. If the locale has been specified for the source pool, this value must match.
	Locale pulumi.StringPtrInput
	// A list of cidrs representing the address space available for allocation in this pool.
	ProvisionedCidrs IPAMPoolProvisionedCidrArrayInput
	// Determines whether or not address space from this pool is publicly advertised. Must be set if and only if the pool is IPv6.
	PubliclyAdvertisable pulumi.BoolPtrInput
	// The Id of this pool's source. If set, all space provisioned in this pool must be free space provisioned in the parent pool.
	SourceIpamPoolId pulumi.StringPtrInput
	// An array of key-value pairs to apply to this resource.
	Tags IPAMPoolTagArrayInput
}

func (IPAMPoolArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ipampoolArgs)(nil)).Elem()
}

type IPAMPoolInput interface {
	pulumi.Input

	ToIPAMPoolOutput() IPAMPoolOutput
	ToIPAMPoolOutputWithContext(ctx context.Context) IPAMPoolOutput
}

func (*IPAMPool) ElementType() reflect.Type {
	return reflect.TypeOf((*IPAMPool)(nil))
}

func (i *IPAMPool) ToIPAMPoolOutput() IPAMPoolOutput {
	return i.ToIPAMPoolOutputWithContext(context.Background())
}

func (i *IPAMPool) ToIPAMPoolOutputWithContext(ctx context.Context) IPAMPoolOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IPAMPoolOutput)
}

type IPAMPoolOutput struct{ *pulumi.OutputState }

func (IPAMPoolOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*IPAMPool)(nil))
}

func (o IPAMPoolOutput) ToIPAMPoolOutput() IPAMPoolOutput {
	return o
}

func (o IPAMPoolOutput) ToIPAMPoolOutputWithContext(ctx context.Context) IPAMPoolOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*IPAMPoolInput)(nil)).Elem(), &IPAMPool{})
	pulumi.RegisterOutputType(IPAMPoolOutput{})
}
