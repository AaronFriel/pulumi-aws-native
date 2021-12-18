// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package emr

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::EMR::Cluster
//
// Deprecated: Cluster is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type Cluster struct {
	pulumi.CustomResourceState

	AdditionalInfo        pulumi.AnyOutput                        `pulumi:"additionalInfo"`
	Applications          ClusterApplicationArrayOutput           `pulumi:"applications"`
	AutoScalingRole       pulumi.StringPtrOutput                  `pulumi:"autoScalingRole"`
	BootstrapActions      ClusterBootstrapActionConfigArrayOutput `pulumi:"bootstrapActions"`
	Configurations        ClusterConfigurationArrayOutput         `pulumi:"configurations"`
	CustomAmiId           pulumi.StringPtrOutput                  `pulumi:"customAmiId"`
	EbsRootVolumeSize     pulumi.IntPtrOutput                     `pulumi:"ebsRootVolumeSize"`
	Instances             ClusterJobFlowInstancesConfigOutput     `pulumi:"instances"`
	JobFlowRole           pulumi.StringOutput                     `pulumi:"jobFlowRole"`
	KerberosAttributes    ClusterKerberosAttributesPtrOutput      `pulumi:"kerberosAttributes"`
	LogEncryptionKmsKeyId pulumi.StringPtrOutput                  `pulumi:"logEncryptionKmsKeyId"`
	LogUri                pulumi.StringPtrOutput                  `pulumi:"logUri"`
	ManagedScalingPolicy  ClusterManagedScalingPolicyPtrOutput    `pulumi:"managedScalingPolicy"`
	MasterPublicDNS       pulumi.StringOutput                     `pulumi:"masterPublicDNS"`
	Name                  pulumi.StringOutput                     `pulumi:"name"`
	ReleaseLabel          pulumi.StringPtrOutput                  `pulumi:"releaseLabel"`
	ScaleDownBehavior     pulumi.StringPtrOutput                  `pulumi:"scaleDownBehavior"`
	SecurityConfiguration pulumi.StringPtrOutput                  `pulumi:"securityConfiguration"`
	ServiceRole           pulumi.StringOutput                     `pulumi:"serviceRole"`
	StepConcurrencyLevel  pulumi.IntPtrOutput                     `pulumi:"stepConcurrencyLevel"`
	Steps                 ClusterStepConfigArrayOutput            `pulumi:"steps"`
	Tags                  ClusterTagArrayOutput                   `pulumi:"tags"`
	VisibleToAllUsers     pulumi.BoolPtrOutput                    `pulumi:"visibleToAllUsers"`
}

// NewCluster registers a new resource with the given unique name, arguments, and options.
func NewCluster(ctx *pulumi.Context,
	name string, args *ClusterArgs, opts ...pulumi.ResourceOption) (*Cluster, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Instances == nil {
		return nil, errors.New("invalid value for required argument 'Instances'")
	}
	if args.JobFlowRole == nil {
		return nil, errors.New("invalid value for required argument 'JobFlowRole'")
	}
	if args.ServiceRole == nil {
		return nil, errors.New("invalid value for required argument 'ServiceRole'")
	}
	var resource Cluster
	err := ctx.RegisterResource("aws-native:emr:Cluster", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCluster gets an existing Cluster resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCluster(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ClusterState, opts ...pulumi.ResourceOption) (*Cluster, error) {
	var resource Cluster
	err := ctx.ReadResource("aws-native:emr:Cluster", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Cluster resources.
type clusterState struct {
}

type ClusterState struct {
}

func (ClusterState) ElementType() reflect.Type {
	return reflect.TypeOf((*clusterState)(nil)).Elem()
}

type clusterArgs struct {
	AdditionalInfo        interface{}                    `pulumi:"additionalInfo"`
	Applications          []ClusterApplication           `pulumi:"applications"`
	AutoScalingRole       *string                        `pulumi:"autoScalingRole"`
	BootstrapActions      []ClusterBootstrapActionConfig `pulumi:"bootstrapActions"`
	Configurations        []ClusterConfiguration         `pulumi:"configurations"`
	CustomAmiId           *string                        `pulumi:"customAmiId"`
	EbsRootVolumeSize     *int                           `pulumi:"ebsRootVolumeSize"`
	Instances             ClusterJobFlowInstancesConfig  `pulumi:"instances"`
	JobFlowRole           string                         `pulumi:"jobFlowRole"`
	KerberosAttributes    *ClusterKerberosAttributes     `pulumi:"kerberosAttributes"`
	LogEncryptionKmsKeyId *string                        `pulumi:"logEncryptionKmsKeyId"`
	LogUri                *string                        `pulumi:"logUri"`
	ManagedScalingPolicy  *ClusterManagedScalingPolicy   `pulumi:"managedScalingPolicy"`
	Name                  *string                        `pulumi:"name"`
	ReleaseLabel          *string                        `pulumi:"releaseLabel"`
	ScaleDownBehavior     *string                        `pulumi:"scaleDownBehavior"`
	SecurityConfiguration *string                        `pulumi:"securityConfiguration"`
	ServiceRole           string                         `pulumi:"serviceRole"`
	StepConcurrencyLevel  *int                           `pulumi:"stepConcurrencyLevel"`
	Steps                 []ClusterStepConfig            `pulumi:"steps"`
	Tags                  []ClusterTag                   `pulumi:"tags"`
	VisibleToAllUsers     *bool                          `pulumi:"visibleToAllUsers"`
}

// The set of arguments for constructing a Cluster resource.
type ClusterArgs struct {
	AdditionalInfo        pulumi.Input
	Applications          ClusterApplicationArrayInput
	AutoScalingRole       pulumi.StringPtrInput
	BootstrapActions      ClusterBootstrapActionConfigArrayInput
	Configurations        ClusterConfigurationArrayInput
	CustomAmiId           pulumi.StringPtrInput
	EbsRootVolumeSize     pulumi.IntPtrInput
	Instances             ClusterJobFlowInstancesConfigInput
	JobFlowRole           pulumi.StringInput
	KerberosAttributes    ClusterKerberosAttributesPtrInput
	LogEncryptionKmsKeyId pulumi.StringPtrInput
	LogUri                pulumi.StringPtrInput
	ManagedScalingPolicy  ClusterManagedScalingPolicyPtrInput
	Name                  pulumi.StringPtrInput
	ReleaseLabel          pulumi.StringPtrInput
	ScaleDownBehavior     pulumi.StringPtrInput
	SecurityConfiguration pulumi.StringPtrInput
	ServiceRole           pulumi.StringInput
	StepConcurrencyLevel  pulumi.IntPtrInput
	Steps                 ClusterStepConfigArrayInput
	Tags                  ClusterTagArrayInput
	VisibleToAllUsers     pulumi.BoolPtrInput
}

func (ClusterArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*clusterArgs)(nil)).Elem()
}

type ClusterInput interface {
	pulumi.Input

	ToClusterOutput() ClusterOutput
	ToClusterOutputWithContext(ctx context.Context) ClusterOutput
}

func (*Cluster) ElementType() reflect.Type {
	return reflect.TypeOf((*Cluster)(nil))
}

func (i *Cluster) ToClusterOutput() ClusterOutput {
	return i.ToClusterOutputWithContext(context.Background())
}

func (i *Cluster) ToClusterOutputWithContext(ctx context.Context) ClusterOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ClusterOutput)
}

type ClusterOutput struct{ *pulumi.OutputState }

func (ClusterOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Cluster)(nil))
}

func (o ClusterOutput) ToClusterOutput() ClusterOutput {
	return o
}

func (o ClusterOutput) ToClusterOutputWithContext(ctx context.Context) ClusterOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ClusterInput)(nil)).Elem(), &Cluster{})
	pulumi.RegisterOutputType(ClusterOutput{})
}
