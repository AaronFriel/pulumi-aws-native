// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package opsworks

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::OpsWorks::Layer
//
// Deprecated: Layer is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type Layer struct {
	pulumi.CustomResourceState

	Attributes                  pulumi.AnyOutput                          `pulumi:"attributes"`
	AutoAssignElasticIps        pulumi.BoolOutput                         `pulumi:"autoAssignElasticIps"`
	AutoAssignPublicIps         pulumi.BoolOutput                         `pulumi:"autoAssignPublicIps"`
	CustomInstanceProfileArn    pulumi.StringPtrOutput                    `pulumi:"customInstanceProfileArn"`
	CustomJson                  pulumi.AnyOutput                          `pulumi:"customJson"`
	CustomRecipes               LayerRecipesPtrOutput                     `pulumi:"customRecipes"`
	CustomSecurityGroupIds      pulumi.StringArrayOutput                  `pulumi:"customSecurityGroupIds"`
	EnableAutoHealing           pulumi.BoolOutput                         `pulumi:"enableAutoHealing"`
	InstallUpdatesOnBoot        pulumi.BoolPtrOutput                      `pulumi:"installUpdatesOnBoot"`
	LifecycleEventConfiguration LayerLifecycleEventConfigurationPtrOutput `pulumi:"lifecycleEventConfiguration"`
	LoadBasedAutoScaling        LayerLoadBasedAutoScalingPtrOutput        `pulumi:"loadBasedAutoScaling"`
	Name                        pulumi.StringOutput                       `pulumi:"name"`
	Packages                    pulumi.StringArrayOutput                  `pulumi:"packages"`
	Shortname                   pulumi.StringOutput                       `pulumi:"shortname"`
	StackId                     pulumi.StringOutput                       `pulumi:"stackId"`
	Tags                        LayerTagArrayOutput                       `pulumi:"tags"`
	Type                        pulumi.StringOutput                       `pulumi:"type"`
	UseEbsOptimizedInstances    pulumi.BoolPtrOutput                      `pulumi:"useEbsOptimizedInstances"`
	VolumeConfigurations        LayerVolumeConfigurationArrayOutput       `pulumi:"volumeConfigurations"`
}

// NewLayer registers a new resource with the given unique name, arguments, and options.
func NewLayer(ctx *pulumi.Context,
	name string, args *LayerArgs, opts ...pulumi.ResourceOption) (*Layer, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AutoAssignElasticIps == nil {
		return nil, errors.New("invalid value for required argument 'AutoAssignElasticIps'")
	}
	if args.AutoAssignPublicIps == nil {
		return nil, errors.New("invalid value for required argument 'AutoAssignPublicIps'")
	}
	if args.EnableAutoHealing == nil {
		return nil, errors.New("invalid value for required argument 'EnableAutoHealing'")
	}
	if args.Shortname == nil {
		return nil, errors.New("invalid value for required argument 'Shortname'")
	}
	if args.StackId == nil {
		return nil, errors.New("invalid value for required argument 'StackId'")
	}
	if args.Type == nil {
		return nil, errors.New("invalid value for required argument 'Type'")
	}
	var resource Layer
	err := ctx.RegisterResource("aws-native:opsworks:Layer", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetLayer gets an existing Layer resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetLayer(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *LayerState, opts ...pulumi.ResourceOption) (*Layer, error) {
	var resource Layer
	err := ctx.ReadResource("aws-native:opsworks:Layer", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Layer resources.
type layerState struct {
}

type LayerState struct {
}

func (LayerState) ElementType() reflect.Type {
	return reflect.TypeOf((*layerState)(nil)).Elem()
}

type layerArgs struct {
	Attributes                  interface{}                       `pulumi:"attributes"`
	AutoAssignElasticIps        bool                              `pulumi:"autoAssignElasticIps"`
	AutoAssignPublicIps         bool                              `pulumi:"autoAssignPublicIps"`
	CustomInstanceProfileArn    *string                           `pulumi:"customInstanceProfileArn"`
	CustomJson                  interface{}                       `pulumi:"customJson"`
	CustomRecipes               *LayerRecipes                     `pulumi:"customRecipes"`
	CustomSecurityGroupIds      []string                          `pulumi:"customSecurityGroupIds"`
	EnableAutoHealing           bool                              `pulumi:"enableAutoHealing"`
	InstallUpdatesOnBoot        *bool                             `pulumi:"installUpdatesOnBoot"`
	LifecycleEventConfiguration *LayerLifecycleEventConfiguration `pulumi:"lifecycleEventConfiguration"`
	LoadBasedAutoScaling        *LayerLoadBasedAutoScaling        `pulumi:"loadBasedAutoScaling"`
	Name                        *string                           `pulumi:"name"`
	Packages                    []string                          `pulumi:"packages"`
	Shortname                   string                            `pulumi:"shortname"`
	StackId                     string                            `pulumi:"stackId"`
	Tags                        []LayerTag                        `pulumi:"tags"`
	Type                        string                            `pulumi:"type"`
	UseEbsOptimizedInstances    *bool                             `pulumi:"useEbsOptimizedInstances"`
	VolumeConfigurations        []LayerVolumeConfiguration        `pulumi:"volumeConfigurations"`
}

// The set of arguments for constructing a Layer resource.
type LayerArgs struct {
	Attributes                  pulumi.Input
	AutoAssignElasticIps        pulumi.BoolInput
	AutoAssignPublicIps         pulumi.BoolInput
	CustomInstanceProfileArn    pulumi.StringPtrInput
	CustomJson                  pulumi.Input
	CustomRecipes               LayerRecipesPtrInput
	CustomSecurityGroupIds      pulumi.StringArrayInput
	EnableAutoHealing           pulumi.BoolInput
	InstallUpdatesOnBoot        pulumi.BoolPtrInput
	LifecycleEventConfiguration LayerLifecycleEventConfigurationPtrInput
	LoadBasedAutoScaling        LayerLoadBasedAutoScalingPtrInput
	Name                        pulumi.StringPtrInput
	Packages                    pulumi.StringArrayInput
	Shortname                   pulumi.StringInput
	StackId                     pulumi.StringInput
	Tags                        LayerTagArrayInput
	Type                        pulumi.StringInput
	UseEbsOptimizedInstances    pulumi.BoolPtrInput
	VolumeConfigurations        LayerVolumeConfigurationArrayInput
}

func (LayerArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*layerArgs)(nil)).Elem()
}

type LayerInput interface {
	pulumi.Input

	ToLayerOutput() LayerOutput
	ToLayerOutputWithContext(ctx context.Context) LayerOutput
}

func (*Layer) ElementType() reflect.Type {
	return reflect.TypeOf((*Layer)(nil))
}

func (i *Layer) ToLayerOutput() LayerOutput {
	return i.ToLayerOutputWithContext(context.Background())
}

func (i *Layer) ToLayerOutputWithContext(ctx context.Context) LayerOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LayerOutput)
}

type LayerOutput struct{ *pulumi.OutputState }

func (LayerOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Layer)(nil))
}

func (o LayerOutput) ToLayerOutput() LayerOutput {
	return o
}

func (o LayerOutput) ToLayerOutputWithContext(ctx context.Context) LayerOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*LayerInput)(nil)).Elem(), &Layer{})
	pulumi.RegisterOutputType(LayerOutput{})
}
