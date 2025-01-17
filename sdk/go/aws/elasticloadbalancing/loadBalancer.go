// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package elasticloadbalancing

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::ElasticLoadBalancing::LoadBalancer
//
// Deprecated: LoadBalancer is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type LoadBalancer struct {
	pulumi.CustomResourceState

	AccessLoggingPolicy           LoadBalancerAccessLoggingPolicyPtrOutput         `pulumi:"accessLoggingPolicy"`
	AppCookieStickinessPolicy     LoadBalancerAppCookieStickinessPolicyArrayOutput `pulumi:"appCookieStickinessPolicy"`
	AvailabilityZones             pulumi.StringArrayOutput                         `pulumi:"availabilityZones"`
	CanonicalHostedZoneName       pulumi.StringOutput                              `pulumi:"canonicalHostedZoneName"`
	CanonicalHostedZoneNameID     pulumi.StringOutput                              `pulumi:"canonicalHostedZoneNameID"`
	ConnectionDrainingPolicy      LoadBalancerConnectionDrainingPolicyPtrOutput    `pulumi:"connectionDrainingPolicy"`
	ConnectionSettings            LoadBalancerConnectionSettingsPtrOutput          `pulumi:"connectionSettings"`
	CrossZone                     pulumi.BoolPtrOutput                             `pulumi:"crossZone"`
	DNSName                       pulumi.StringOutput                              `pulumi:"dNSName"`
	HealthCheck                   LoadBalancerHealthCheckPtrOutput                 `pulumi:"healthCheck"`
	Instances                     pulumi.StringArrayOutput                         `pulumi:"instances"`
	LBCookieStickinessPolicy      LoadBalancerLBCookieStickinessPolicyArrayOutput  `pulumi:"lBCookieStickinessPolicy"`
	Listeners                     LoadBalancerListenersArrayOutput                 `pulumi:"listeners"`
	LoadBalancerName              pulumi.StringPtrOutput                           `pulumi:"loadBalancerName"`
	Policies                      LoadBalancerPoliciesArrayOutput                  `pulumi:"policies"`
	Scheme                        pulumi.StringPtrOutput                           `pulumi:"scheme"`
	SecurityGroups                pulumi.StringArrayOutput                         `pulumi:"securityGroups"`
	SourceSecurityGroupGroupName  pulumi.StringPtrOutput                           `pulumi:"sourceSecurityGroupGroupName"`
	SourceSecurityGroupOwnerAlias pulumi.StringPtrOutput                           `pulumi:"sourceSecurityGroupOwnerAlias"`
	Subnets                       pulumi.StringArrayOutput                         `pulumi:"subnets"`
	Tags                          LoadBalancerTagArrayOutput                       `pulumi:"tags"`
}

// NewLoadBalancer registers a new resource with the given unique name, arguments, and options.
func NewLoadBalancer(ctx *pulumi.Context,
	name string, args *LoadBalancerArgs, opts ...pulumi.ResourceOption) (*LoadBalancer, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Listeners == nil {
		return nil, errors.New("invalid value for required argument 'Listeners'")
	}
	var resource LoadBalancer
	err := ctx.RegisterResource("aws-native:elasticloadbalancing:LoadBalancer", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetLoadBalancer gets an existing LoadBalancer resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetLoadBalancer(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *LoadBalancerState, opts ...pulumi.ResourceOption) (*LoadBalancer, error) {
	var resource LoadBalancer
	err := ctx.ReadResource("aws-native:elasticloadbalancing:LoadBalancer", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering LoadBalancer resources.
type loadBalancerState struct {
}

type LoadBalancerState struct {
}

func (LoadBalancerState) ElementType() reflect.Type {
	return reflect.TypeOf((*loadBalancerState)(nil)).Elem()
}

type loadBalancerArgs struct {
	AccessLoggingPolicy           *LoadBalancerAccessLoggingPolicy        `pulumi:"accessLoggingPolicy"`
	AppCookieStickinessPolicy     []LoadBalancerAppCookieStickinessPolicy `pulumi:"appCookieStickinessPolicy"`
	AvailabilityZones             []string                                `pulumi:"availabilityZones"`
	ConnectionDrainingPolicy      *LoadBalancerConnectionDrainingPolicy   `pulumi:"connectionDrainingPolicy"`
	ConnectionSettings            *LoadBalancerConnectionSettings         `pulumi:"connectionSettings"`
	CrossZone                     *bool                                   `pulumi:"crossZone"`
	HealthCheck                   *LoadBalancerHealthCheck                `pulumi:"healthCheck"`
	Instances                     []string                                `pulumi:"instances"`
	LBCookieStickinessPolicy      []LoadBalancerLBCookieStickinessPolicy  `pulumi:"lBCookieStickinessPolicy"`
	Listeners                     []LoadBalancerListeners                 `pulumi:"listeners"`
	LoadBalancerName              *string                                 `pulumi:"loadBalancerName"`
	Policies                      []LoadBalancerPolicies                  `pulumi:"policies"`
	Scheme                        *string                                 `pulumi:"scheme"`
	SecurityGroups                []string                                `pulumi:"securityGroups"`
	SourceSecurityGroupGroupName  *string                                 `pulumi:"sourceSecurityGroupGroupName"`
	SourceSecurityGroupOwnerAlias *string                                 `pulumi:"sourceSecurityGroupOwnerAlias"`
	Subnets                       []string                                `pulumi:"subnets"`
	Tags                          []LoadBalancerTag                       `pulumi:"tags"`
}

// The set of arguments for constructing a LoadBalancer resource.
type LoadBalancerArgs struct {
	AccessLoggingPolicy           LoadBalancerAccessLoggingPolicyPtrInput
	AppCookieStickinessPolicy     LoadBalancerAppCookieStickinessPolicyArrayInput
	AvailabilityZones             pulumi.StringArrayInput
	ConnectionDrainingPolicy      LoadBalancerConnectionDrainingPolicyPtrInput
	ConnectionSettings            LoadBalancerConnectionSettingsPtrInput
	CrossZone                     pulumi.BoolPtrInput
	HealthCheck                   LoadBalancerHealthCheckPtrInput
	Instances                     pulumi.StringArrayInput
	LBCookieStickinessPolicy      LoadBalancerLBCookieStickinessPolicyArrayInput
	Listeners                     LoadBalancerListenersArrayInput
	LoadBalancerName              pulumi.StringPtrInput
	Policies                      LoadBalancerPoliciesArrayInput
	Scheme                        pulumi.StringPtrInput
	SecurityGroups                pulumi.StringArrayInput
	SourceSecurityGroupGroupName  pulumi.StringPtrInput
	SourceSecurityGroupOwnerAlias pulumi.StringPtrInput
	Subnets                       pulumi.StringArrayInput
	Tags                          LoadBalancerTagArrayInput
}

func (LoadBalancerArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*loadBalancerArgs)(nil)).Elem()
}

type LoadBalancerInput interface {
	pulumi.Input

	ToLoadBalancerOutput() LoadBalancerOutput
	ToLoadBalancerOutputWithContext(ctx context.Context) LoadBalancerOutput
}

func (*LoadBalancer) ElementType() reflect.Type {
	return reflect.TypeOf((*LoadBalancer)(nil))
}

func (i *LoadBalancer) ToLoadBalancerOutput() LoadBalancerOutput {
	return i.ToLoadBalancerOutputWithContext(context.Background())
}

func (i *LoadBalancer) ToLoadBalancerOutputWithContext(ctx context.Context) LoadBalancerOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LoadBalancerOutput)
}

type LoadBalancerOutput struct{ *pulumi.OutputState }

func (LoadBalancerOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LoadBalancer)(nil))
}

func (o LoadBalancerOutput) ToLoadBalancerOutput() LoadBalancerOutput {
	return o
}

func (o LoadBalancerOutput) ToLoadBalancerOutputWithContext(ctx context.Context) LoadBalancerOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*LoadBalancerInput)(nil)).Elem(), &LoadBalancer{})
	pulumi.RegisterOutputType(LoadBalancerOutput{})
}
