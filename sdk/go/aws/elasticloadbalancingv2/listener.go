// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package elasticloadbalancingv2

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::ElasticLoadBalancingV2::Listener
type Listener struct {
	pulumi.CustomResourceState

	AlpnPolicy      pulumi.StringArrayOutput           `pulumi:"alpnPolicy"`
	Certificates    ListenerCertificateTypeArrayOutput `pulumi:"certificates"`
	DefaultActions  ListenerActionArrayOutput          `pulumi:"defaultActions"`
	ListenerArn     pulumi.StringOutput                `pulumi:"listenerArn"`
	LoadBalancerArn pulumi.StringOutput                `pulumi:"loadBalancerArn"`
	Port            pulumi.IntPtrOutput                `pulumi:"port"`
	Protocol        pulumi.StringPtrOutput             `pulumi:"protocol"`
	SslPolicy       pulumi.StringPtrOutput             `pulumi:"sslPolicy"`
}

// NewListener registers a new resource with the given unique name, arguments, and options.
func NewListener(ctx *pulumi.Context,
	name string, args *ListenerArgs, opts ...pulumi.ResourceOption) (*Listener, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DefaultActions == nil {
		return nil, errors.New("invalid value for required argument 'DefaultActions'")
	}
	if args.LoadBalancerArn == nil {
		return nil, errors.New("invalid value for required argument 'LoadBalancerArn'")
	}
	var resource Listener
	err := ctx.RegisterResource("aws-native:elasticloadbalancingv2:Listener", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetListener gets an existing Listener resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetListener(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ListenerState, opts ...pulumi.ResourceOption) (*Listener, error) {
	var resource Listener
	err := ctx.ReadResource("aws-native:elasticloadbalancingv2:Listener", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Listener resources.
type listenerState struct {
}

type ListenerState struct {
}

func (ListenerState) ElementType() reflect.Type {
	return reflect.TypeOf((*listenerState)(nil)).Elem()
}

type listenerArgs struct {
	AlpnPolicy      []string                  `pulumi:"alpnPolicy"`
	Certificates    []ListenerCertificateType `pulumi:"certificates"`
	DefaultActions  []ListenerAction          `pulumi:"defaultActions"`
	LoadBalancerArn string                    `pulumi:"loadBalancerArn"`
	Port            *int                      `pulumi:"port"`
	Protocol        *string                   `pulumi:"protocol"`
	SslPolicy       *string                   `pulumi:"sslPolicy"`
}

// The set of arguments for constructing a Listener resource.
type ListenerArgs struct {
	AlpnPolicy      pulumi.StringArrayInput
	Certificates    ListenerCertificateTypeArrayInput
	DefaultActions  ListenerActionArrayInput
	LoadBalancerArn pulumi.StringInput
	Port            pulumi.IntPtrInput
	Protocol        pulumi.StringPtrInput
	SslPolicy       pulumi.StringPtrInput
}

func (ListenerArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*listenerArgs)(nil)).Elem()
}

type ListenerInput interface {
	pulumi.Input

	ToListenerOutput() ListenerOutput
	ToListenerOutputWithContext(ctx context.Context) ListenerOutput
}

func (*Listener) ElementType() reflect.Type {
	return reflect.TypeOf((*Listener)(nil))
}

func (i *Listener) ToListenerOutput() ListenerOutput {
	return i.ToListenerOutputWithContext(context.Background())
}

func (i *Listener) ToListenerOutputWithContext(ctx context.Context) ListenerOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ListenerOutput)
}

type ListenerOutput struct{ *pulumi.OutputState }

func (ListenerOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Listener)(nil))
}

func (o ListenerOutput) ToListenerOutput() ListenerOutput {
	return o
}

func (o ListenerOutput) ToListenerOutputWithContext(ctx context.Context) ListenerOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ListenerInput)(nil)).Elem(), &Listener{})
	pulumi.RegisterOutputType(ListenerOutput{})
}
