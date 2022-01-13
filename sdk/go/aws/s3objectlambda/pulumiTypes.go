// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package s3objectlambda

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Configuration to be applied to this Object lambda Access Point. It specifies Supporting Access Point, Transformation Configurations. Customers can also set if they like to enable Cloudwatch metrics for accesses to this Object lambda Access Point. Default setting for Cloudwatch metrics is disable.
type AccessPointObjectLambdaConfiguration struct {
	AllowedFeatures              []string                                 `pulumi:"allowedFeatures"`
	CloudWatchMetricsEnabled     *bool                                    `pulumi:"cloudWatchMetricsEnabled"`
	SupportingAccessPoint        string                                   `pulumi:"supportingAccessPoint"`
	TransformationConfigurations []AccessPointTransformationConfiguration `pulumi:"transformationConfigurations"`
}

// AccessPointObjectLambdaConfigurationInput is an input type that accepts AccessPointObjectLambdaConfigurationArgs and AccessPointObjectLambdaConfigurationOutput values.
// You can construct a concrete instance of `AccessPointObjectLambdaConfigurationInput` via:
//
//          AccessPointObjectLambdaConfigurationArgs{...}
type AccessPointObjectLambdaConfigurationInput interface {
	pulumi.Input

	ToAccessPointObjectLambdaConfigurationOutput() AccessPointObjectLambdaConfigurationOutput
	ToAccessPointObjectLambdaConfigurationOutputWithContext(context.Context) AccessPointObjectLambdaConfigurationOutput
}

// Configuration to be applied to this Object lambda Access Point. It specifies Supporting Access Point, Transformation Configurations. Customers can also set if they like to enable Cloudwatch metrics for accesses to this Object lambda Access Point. Default setting for Cloudwatch metrics is disable.
type AccessPointObjectLambdaConfigurationArgs struct {
	AllowedFeatures              pulumi.StringArrayInput                          `pulumi:"allowedFeatures"`
	CloudWatchMetricsEnabled     pulumi.BoolPtrInput                              `pulumi:"cloudWatchMetricsEnabled"`
	SupportingAccessPoint        pulumi.StringInput                               `pulumi:"supportingAccessPoint"`
	TransformationConfigurations AccessPointTransformationConfigurationArrayInput `pulumi:"transformationConfigurations"`
}

func (AccessPointObjectLambdaConfigurationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*AccessPointObjectLambdaConfiguration)(nil)).Elem()
}

func (i AccessPointObjectLambdaConfigurationArgs) ToAccessPointObjectLambdaConfigurationOutput() AccessPointObjectLambdaConfigurationOutput {
	return i.ToAccessPointObjectLambdaConfigurationOutputWithContext(context.Background())
}

func (i AccessPointObjectLambdaConfigurationArgs) ToAccessPointObjectLambdaConfigurationOutputWithContext(ctx context.Context) AccessPointObjectLambdaConfigurationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AccessPointObjectLambdaConfigurationOutput)
}

func (i AccessPointObjectLambdaConfigurationArgs) ToAccessPointObjectLambdaConfigurationPtrOutput() AccessPointObjectLambdaConfigurationPtrOutput {
	return i.ToAccessPointObjectLambdaConfigurationPtrOutputWithContext(context.Background())
}

func (i AccessPointObjectLambdaConfigurationArgs) ToAccessPointObjectLambdaConfigurationPtrOutputWithContext(ctx context.Context) AccessPointObjectLambdaConfigurationPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AccessPointObjectLambdaConfigurationOutput).ToAccessPointObjectLambdaConfigurationPtrOutputWithContext(ctx)
}

// AccessPointObjectLambdaConfigurationPtrInput is an input type that accepts AccessPointObjectLambdaConfigurationArgs, AccessPointObjectLambdaConfigurationPtr and AccessPointObjectLambdaConfigurationPtrOutput values.
// You can construct a concrete instance of `AccessPointObjectLambdaConfigurationPtrInput` via:
//
//          AccessPointObjectLambdaConfigurationArgs{...}
//
//  or:
//
//          nil
type AccessPointObjectLambdaConfigurationPtrInput interface {
	pulumi.Input

	ToAccessPointObjectLambdaConfigurationPtrOutput() AccessPointObjectLambdaConfigurationPtrOutput
	ToAccessPointObjectLambdaConfigurationPtrOutputWithContext(context.Context) AccessPointObjectLambdaConfigurationPtrOutput
}

type accessPointObjectLambdaConfigurationPtrType AccessPointObjectLambdaConfigurationArgs

func AccessPointObjectLambdaConfigurationPtr(v *AccessPointObjectLambdaConfigurationArgs) AccessPointObjectLambdaConfigurationPtrInput {
	return (*accessPointObjectLambdaConfigurationPtrType)(v)
}

func (*accessPointObjectLambdaConfigurationPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**AccessPointObjectLambdaConfiguration)(nil)).Elem()
}

func (i *accessPointObjectLambdaConfigurationPtrType) ToAccessPointObjectLambdaConfigurationPtrOutput() AccessPointObjectLambdaConfigurationPtrOutput {
	return i.ToAccessPointObjectLambdaConfigurationPtrOutputWithContext(context.Background())
}

func (i *accessPointObjectLambdaConfigurationPtrType) ToAccessPointObjectLambdaConfigurationPtrOutputWithContext(ctx context.Context) AccessPointObjectLambdaConfigurationPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AccessPointObjectLambdaConfigurationPtrOutput)
}

// Configuration to be applied to this Object lambda Access Point. It specifies Supporting Access Point, Transformation Configurations. Customers can also set if they like to enable Cloudwatch metrics for accesses to this Object lambda Access Point. Default setting for Cloudwatch metrics is disable.
type AccessPointObjectLambdaConfigurationOutput struct{ *pulumi.OutputState }

func (AccessPointObjectLambdaConfigurationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*AccessPointObjectLambdaConfiguration)(nil)).Elem()
}

func (o AccessPointObjectLambdaConfigurationOutput) ToAccessPointObjectLambdaConfigurationOutput() AccessPointObjectLambdaConfigurationOutput {
	return o
}

func (o AccessPointObjectLambdaConfigurationOutput) ToAccessPointObjectLambdaConfigurationOutputWithContext(ctx context.Context) AccessPointObjectLambdaConfigurationOutput {
	return o
}

func (o AccessPointObjectLambdaConfigurationOutput) ToAccessPointObjectLambdaConfigurationPtrOutput() AccessPointObjectLambdaConfigurationPtrOutput {
	return o.ToAccessPointObjectLambdaConfigurationPtrOutputWithContext(context.Background())
}

func (o AccessPointObjectLambdaConfigurationOutput) ToAccessPointObjectLambdaConfigurationPtrOutputWithContext(ctx context.Context) AccessPointObjectLambdaConfigurationPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v AccessPointObjectLambdaConfiguration) *AccessPointObjectLambdaConfiguration {
		return &v
	}).(AccessPointObjectLambdaConfigurationPtrOutput)
}

func (o AccessPointObjectLambdaConfigurationOutput) AllowedFeatures() pulumi.StringArrayOutput {
	return o.ApplyT(func(v AccessPointObjectLambdaConfiguration) []string { return v.AllowedFeatures }).(pulumi.StringArrayOutput)
}

func (o AccessPointObjectLambdaConfigurationOutput) CloudWatchMetricsEnabled() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v AccessPointObjectLambdaConfiguration) *bool { return v.CloudWatchMetricsEnabled }).(pulumi.BoolPtrOutput)
}

func (o AccessPointObjectLambdaConfigurationOutput) SupportingAccessPoint() pulumi.StringOutput {
	return o.ApplyT(func(v AccessPointObjectLambdaConfiguration) string { return v.SupportingAccessPoint }).(pulumi.StringOutput)
}

func (o AccessPointObjectLambdaConfigurationOutput) TransformationConfigurations() AccessPointTransformationConfigurationArrayOutput {
	return o.ApplyT(func(v AccessPointObjectLambdaConfiguration) []AccessPointTransformationConfiguration {
		return v.TransformationConfigurations
	}).(AccessPointTransformationConfigurationArrayOutput)
}

type AccessPointObjectLambdaConfigurationPtrOutput struct{ *pulumi.OutputState }

func (AccessPointObjectLambdaConfigurationPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**AccessPointObjectLambdaConfiguration)(nil)).Elem()
}

func (o AccessPointObjectLambdaConfigurationPtrOutput) ToAccessPointObjectLambdaConfigurationPtrOutput() AccessPointObjectLambdaConfigurationPtrOutput {
	return o
}

func (o AccessPointObjectLambdaConfigurationPtrOutput) ToAccessPointObjectLambdaConfigurationPtrOutputWithContext(ctx context.Context) AccessPointObjectLambdaConfigurationPtrOutput {
	return o
}

func (o AccessPointObjectLambdaConfigurationPtrOutput) Elem() AccessPointObjectLambdaConfigurationOutput {
	return o.ApplyT(func(v *AccessPointObjectLambdaConfiguration) AccessPointObjectLambdaConfiguration {
		if v != nil {
			return *v
		}
		var ret AccessPointObjectLambdaConfiguration
		return ret
	}).(AccessPointObjectLambdaConfigurationOutput)
}

func (o AccessPointObjectLambdaConfigurationPtrOutput) AllowedFeatures() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *AccessPointObjectLambdaConfiguration) []string {
		if v == nil {
			return nil
		}
		return v.AllowedFeatures
	}).(pulumi.StringArrayOutput)
}

func (o AccessPointObjectLambdaConfigurationPtrOutput) CloudWatchMetricsEnabled() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *AccessPointObjectLambdaConfiguration) *bool {
		if v == nil {
			return nil
		}
		return v.CloudWatchMetricsEnabled
	}).(pulumi.BoolPtrOutput)
}

func (o AccessPointObjectLambdaConfigurationPtrOutput) SupportingAccessPoint() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AccessPointObjectLambdaConfiguration) *string {
		if v == nil {
			return nil
		}
		return &v.SupportingAccessPoint
	}).(pulumi.StringPtrOutput)
}

func (o AccessPointObjectLambdaConfigurationPtrOutput) TransformationConfigurations() AccessPointTransformationConfigurationArrayOutput {
	return o.ApplyT(func(v *AccessPointObjectLambdaConfiguration) []AccessPointTransformationConfiguration {
		if v == nil {
			return nil
		}
		return v.TransformationConfigurations
	}).(AccessPointTransformationConfigurationArrayOutput)
}

// The Public Access Block Configuration is used to block policies that would allow public access to this Object lambda Access Point. All public access to Object lambda Access Points are blocked by default, and any policy that would give public access to them will be also blocked. This behavior cannot be changed for Object lambda Access Points.
type AccessPointPublicAccessBlockConfiguration struct {
	// Specifies whether Amazon S3 should block public access control lists (ACLs) to this object lambda access point. Setting this element to TRUE causes the following behavior:
	// - PUT Bucket acl and PUT Object acl calls fail if the specified ACL is public.
	//  - PUT Object calls fail if the request includes a public ACL.
	//    . - PUT Bucket calls fail if the request includes a public ACL.
	//    Enabling this setting doesn't affect existing policies or ACLs.
	BlockPublicAcls *bool `pulumi:"blockPublicAcls"`
	// Specifies whether Amazon S3 should block public bucket policies for buckets in this account. Setting this element to TRUE causes Amazon S3 to reject calls to PUT Bucket policy if the specified bucket policy allows public access. Enabling this setting doesn't affect existing bucket policies.
	BlockPublicPolicy *bool `pulumi:"blockPublicPolicy"`
	// Specifies whether Amazon S3 should ignore public ACLs for buckets in this account. Setting this element to TRUE causes Amazon S3 to ignore all public ACLs on buckets in this account and any objects that they contain. Enabling this setting doesn't affect the persistence of any existing ACLs and doesn't prevent new public ACLs from being set.
	IgnorePublicAcls *bool `pulumi:"ignorePublicAcls"`
	// Specifies whether Amazon S3 should restrict public bucket policies for this bucket. Setting this element to TRUE restricts access to this bucket to only AWS services and authorized users within this account if the bucket has a public policy.
	// Enabling this setting doesn't affect previously stored bucket policies, except that public and cross-account access within any public bucket policy, including non-public delegation to specific accounts, is blocked.
	RestrictPublicBuckets *bool `pulumi:"restrictPublicBuckets"`
}

// AccessPointPublicAccessBlockConfigurationInput is an input type that accepts AccessPointPublicAccessBlockConfigurationArgs and AccessPointPublicAccessBlockConfigurationOutput values.
// You can construct a concrete instance of `AccessPointPublicAccessBlockConfigurationInput` via:
//
//          AccessPointPublicAccessBlockConfigurationArgs{...}
type AccessPointPublicAccessBlockConfigurationInput interface {
	pulumi.Input

	ToAccessPointPublicAccessBlockConfigurationOutput() AccessPointPublicAccessBlockConfigurationOutput
	ToAccessPointPublicAccessBlockConfigurationOutputWithContext(context.Context) AccessPointPublicAccessBlockConfigurationOutput
}

// The Public Access Block Configuration is used to block policies that would allow public access to this Object lambda Access Point. All public access to Object lambda Access Points are blocked by default, and any policy that would give public access to them will be also blocked. This behavior cannot be changed for Object lambda Access Points.
type AccessPointPublicAccessBlockConfigurationArgs struct {
	// Specifies whether Amazon S3 should block public access control lists (ACLs) to this object lambda access point. Setting this element to TRUE causes the following behavior:
	// - PUT Bucket acl and PUT Object acl calls fail if the specified ACL is public.
	//  - PUT Object calls fail if the request includes a public ACL.
	//    . - PUT Bucket calls fail if the request includes a public ACL.
	//    Enabling this setting doesn't affect existing policies or ACLs.
	BlockPublicAcls pulumi.BoolPtrInput `pulumi:"blockPublicAcls"`
	// Specifies whether Amazon S3 should block public bucket policies for buckets in this account. Setting this element to TRUE causes Amazon S3 to reject calls to PUT Bucket policy if the specified bucket policy allows public access. Enabling this setting doesn't affect existing bucket policies.
	BlockPublicPolicy pulumi.BoolPtrInput `pulumi:"blockPublicPolicy"`
	// Specifies whether Amazon S3 should ignore public ACLs for buckets in this account. Setting this element to TRUE causes Amazon S3 to ignore all public ACLs on buckets in this account and any objects that they contain. Enabling this setting doesn't affect the persistence of any existing ACLs and doesn't prevent new public ACLs from being set.
	IgnorePublicAcls pulumi.BoolPtrInput `pulumi:"ignorePublicAcls"`
	// Specifies whether Amazon S3 should restrict public bucket policies for this bucket. Setting this element to TRUE restricts access to this bucket to only AWS services and authorized users within this account if the bucket has a public policy.
	// Enabling this setting doesn't affect previously stored bucket policies, except that public and cross-account access within any public bucket policy, including non-public delegation to specific accounts, is blocked.
	RestrictPublicBuckets pulumi.BoolPtrInput `pulumi:"restrictPublicBuckets"`
}

func (AccessPointPublicAccessBlockConfigurationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*AccessPointPublicAccessBlockConfiguration)(nil)).Elem()
}

func (i AccessPointPublicAccessBlockConfigurationArgs) ToAccessPointPublicAccessBlockConfigurationOutput() AccessPointPublicAccessBlockConfigurationOutput {
	return i.ToAccessPointPublicAccessBlockConfigurationOutputWithContext(context.Background())
}

func (i AccessPointPublicAccessBlockConfigurationArgs) ToAccessPointPublicAccessBlockConfigurationOutputWithContext(ctx context.Context) AccessPointPublicAccessBlockConfigurationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AccessPointPublicAccessBlockConfigurationOutput)
}

func (i AccessPointPublicAccessBlockConfigurationArgs) ToAccessPointPublicAccessBlockConfigurationPtrOutput() AccessPointPublicAccessBlockConfigurationPtrOutput {
	return i.ToAccessPointPublicAccessBlockConfigurationPtrOutputWithContext(context.Background())
}

func (i AccessPointPublicAccessBlockConfigurationArgs) ToAccessPointPublicAccessBlockConfigurationPtrOutputWithContext(ctx context.Context) AccessPointPublicAccessBlockConfigurationPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AccessPointPublicAccessBlockConfigurationOutput).ToAccessPointPublicAccessBlockConfigurationPtrOutputWithContext(ctx)
}

// AccessPointPublicAccessBlockConfigurationPtrInput is an input type that accepts AccessPointPublicAccessBlockConfigurationArgs, AccessPointPublicAccessBlockConfigurationPtr and AccessPointPublicAccessBlockConfigurationPtrOutput values.
// You can construct a concrete instance of `AccessPointPublicAccessBlockConfigurationPtrInput` via:
//
//          AccessPointPublicAccessBlockConfigurationArgs{...}
//
//  or:
//
//          nil
type AccessPointPublicAccessBlockConfigurationPtrInput interface {
	pulumi.Input

	ToAccessPointPublicAccessBlockConfigurationPtrOutput() AccessPointPublicAccessBlockConfigurationPtrOutput
	ToAccessPointPublicAccessBlockConfigurationPtrOutputWithContext(context.Context) AccessPointPublicAccessBlockConfigurationPtrOutput
}

type accessPointPublicAccessBlockConfigurationPtrType AccessPointPublicAccessBlockConfigurationArgs

func AccessPointPublicAccessBlockConfigurationPtr(v *AccessPointPublicAccessBlockConfigurationArgs) AccessPointPublicAccessBlockConfigurationPtrInput {
	return (*accessPointPublicAccessBlockConfigurationPtrType)(v)
}

func (*accessPointPublicAccessBlockConfigurationPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**AccessPointPublicAccessBlockConfiguration)(nil)).Elem()
}

func (i *accessPointPublicAccessBlockConfigurationPtrType) ToAccessPointPublicAccessBlockConfigurationPtrOutput() AccessPointPublicAccessBlockConfigurationPtrOutput {
	return i.ToAccessPointPublicAccessBlockConfigurationPtrOutputWithContext(context.Background())
}

func (i *accessPointPublicAccessBlockConfigurationPtrType) ToAccessPointPublicAccessBlockConfigurationPtrOutputWithContext(ctx context.Context) AccessPointPublicAccessBlockConfigurationPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AccessPointPublicAccessBlockConfigurationPtrOutput)
}

// The Public Access Block Configuration is used to block policies that would allow public access to this Object lambda Access Point. All public access to Object lambda Access Points are blocked by default, and any policy that would give public access to them will be also blocked. This behavior cannot be changed for Object lambda Access Points.
type AccessPointPublicAccessBlockConfigurationOutput struct{ *pulumi.OutputState }

func (AccessPointPublicAccessBlockConfigurationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*AccessPointPublicAccessBlockConfiguration)(nil)).Elem()
}

func (o AccessPointPublicAccessBlockConfigurationOutput) ToAccessPointPublicAccessBlockConfigurationOutput() AccessPointPublicAccessBlockConfigurationOutput {
	return o
}

func (o AccessPointPublicAccessBlockConfigurationOutput) ToAccessPointPublicAccessBlockConfigurationOutputWithContext(ctx context.Context) AccessPointPublicAccessBlockConfigurationOutput {
	return o
}

func (o AccessPointPublicAccessBlockConfigurationOutput) ToAccessPointPublicAccessBlockConfigurationPtrOutput() AccessPointPublicAccessBlockConfigurationPtrOutput {
	return o.ToAccessPointPublicAccessBlockConfigurationPtrOutputWithContext(context.Background())
}

func (o AccessPointPublicAccessBlockConfigurationOutput) ToAccessPointPublicAccessBlockConfigurationPtrOutputWithContext(ctx context.Context) AccessPointPublicAccessBlockConfigurationPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v AccessPointPublicAccessBlockConfiguration) *AccessPointPublicAccessBlockConfiguration {
		return &v
	}).(AccessPointPublicAccessBlockConfigurationPtrOutput)
}

// Specifies whether Amazon S3 should block public access control lists (ACLs) to this object lambda access point. Setting this element to TRUE causes the following behavior:
// - PUT Bucket acl and PUT Object acl calls fail if the specified ACL is public.
//  - PUT Object calls fail if the request includes a public ACL.
//    . - PUT Bucket calls fail if the request includes a public ACL.
//    Enabling this setting doesn't affect existing policies or ACLs.
func (o AccessPointPublicAccessBlockConfigurationOutput) BlockPublicAcls() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v AccessPointPublicAccessBlockConfiguration) *bool { return v.BlockPublicAcls }).(pulumi.BoolPtrOutput)
}

// Specifies whether Amazon S3 should block public bucket policies for buckets in this account. Setting this element to TRUE causes Amazon S3 to reject calls to PUT Bucket policy if the specified bucket policy allows public access. Enabling this setting doesn't affect existing bucket policies.
func (o AccessPointPublicAccessBlockConfigurationOutput) BlockPublicPolicy() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v AccessPointPublicAccessBlockConfiguration) *bool { return v.BlockPublicPolicy }).(pulumi.BoolPtrOutput)
}

// Specifies whether Amazon S3 should ignore public ACLs for buckets in this account. Setting this element to TRUE causes Amazon S3 to ignore all public ACLs on buckets in this account and any objects that they contain. Enabling this setting doesn't affect the persistence of any existing ACLs and doesn't prevent new public ACLs from being set.
func (o AccessPointPublicAccessBlockConfigurationOutput) IgnorePublicAcls() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v AccessPointPublicAccessBlockConfiguration) *bool { return v.IgnorePublicAcls }).(pulumi.BoolPtrOutput)
}

// Specifies whether Amazon S3 should restrict public bucket policies for this bucket. Setting this element to TRUE restricts access to this bucket to only AWS services and authorized users within this account if the bucket has a public policy.
// Enabling this setting doesn't affect previously stored bucket policies, except that public and cross-account access within any public bucket policy, including non-public delegation to specific accounts, is blocked.
func (o AccessPointPublicAccessBlockConfigurationOutput) RestrictPublicBuckets() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v AccessPointPublicAccessBlockConfiguration) *bool { return v.RestrictPublicBuckets }).(pulumi.BoolPtrOutput)
}

type AccessPointPublicAccessBlockConfigurationPtrOutput struct{ *pulumi.OutputState }

func (AccessPointPublicAccessBlockConfigurationPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**AccessPointPublicAccessBlockConfiguration)(nil)).Elem()
}

func (o AccessPointPublicAccessBlockConfigurationPtrOutput) ToAccessPointPublicAccessBlockConfigurationPtrOutput() AccessPointPublicAccessBlockConfigurationPtrOutput {
	return o
}

func (o AccessPointPublicAccessBlockConfigurationPtrOutput) ToAccessPointPublicAccessBlockConfigurationPtrOutputWithContext(ctx context.Context) AccessPointPublicAccessBlockConfigurationPtrOutput {
	return o
}

func (o AccessPointPublicAccessBlockConfigurationPtrOutput) Elem() AccessPointPublicAccessBlockConfigurationOutput {
	return o.ApplyT(func(v *AccessPointPublicAccessBlockConfiguration) AccessPointPublicAccessBlockConfiguration {
		if v != nil {
			return *v
		}
		var ret AccessPointPublicAccessBlockConfiguration
		return ret
	}).(AccessPointPublicAccessBlockConfigurationOutput)
}

// Specifies whether Amazon S3 should block public access control lists (ACLs) to this object lambda access point. Setting this element to TRUE causes the following behavior:
// - PUT Bucket acl and PUT Object acl calls fail if the specified ACL is public.
//  - PUT Object calls fail if the request includes a public ACL.
//    . - PUT Bucket calls fail if the request includes a public ACL.
//    Enabling this setting doesn't affect existing policies or ACLs.
func (o AccessPointPublicAccessBlockConfigurationPtrOutput) BlockPublicAcls() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *AccessPointPublicAccessBlockConfiguration) *bool {
		if v == nil {
			return nil
		}
		return v.BlockPublicAcls
	}).(pulumi.BoolPtrOutput)
}

// Specifies whether Amazon S3 should block public bucket policies for buckets in this account. Setting this element to TRUE causes Amazon S3 to reject calls to PUT Bucket policy if the specified bucket policy allows public access. Enabling this setting doesn't affect existing bucket policies.
func (o AccessPointPublicAccessBlockConfigurationPtrOutput) BlockPublicPolicy() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *AccessPointPublicAccessBlockConfiguration) *bool {
		if v == nil {
			return nil
		}
		return v.BlockPublicPolicy
	}).(pulumi.BoolPtrOutput)
}

// Specifies whether Amazon S3 should ignore public ACLs for buckets in this account. Setting this element to TRUE causes Amazon S3 to ignore all public ACLs on buckets in this account and any objects that they contain. Enabling this setting doesn't affect the persistence of any existing ACLs and doesn't prevent new public ACLs from being set.
func (o AccessPointPublicAccessBlockConfigurationPtrOutput) IgnorePublicAcls() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *AccessPointPublicAccessBlockConfiguration) *bool {
		if v == nil {
			return nil
		}
		return v.IgnorePublicAcls
	}).(pulumi.BoolPtrOutput)
}

// Specifies whether Amazon S3 should restrict public bucket policies for this bucket. Setting this element to TRUE restricts access to this bucket to only AWS services and authorized users within this account if the bucket has a public policy.
// Enabling this setting doesn't affect previously stored bucket policies, except that public and cross-account access within any public bucket policy, including non-public delegation to specific accounts, is blocked.
func (o AccessPointPublicAccessBlockConfigurationPtrOutput) RestrictPublicBuckets() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *AccessPointPublicAccessBlockConfiguration) *bool {
		if v == nil {
			return nil
		}
		return v.RestrictPublicBuckets
	}).(pulumi.BoolPtrOutput)
}

// Configuration to define what content transformation will be applied on which S3 Action.
type AccessPointTransformationConfiguration struct {
	Actions               []string    `pulumi:"actions"`
	ContentTransformation interface{} `pulumi:"contentTransformation"`
}

// AccessPointTransformationConfigurationInput is an input type that accepts AccessPointTransformationConfigurationArgs and AccessPointTransformationConfigurationOutput values.
// You can construct a concrete instance of `AccessPointTransformationConfigurationInput` via:
//
//          AccessPointTransformationConfigurationArgs{...}
type AccessPointTransformationConfigurationInput interface {
	pulumi.Input

	ToAccessPointTransformationConfigurationOutput() AccessPointTransformationConfigurationOutput
	ToAccessPointTransformationConfigurationOutputWithContext(context.Context) AccessPointTransformationConfigurationOutput
}

// Configuration to define what content transformation will be applied on which S3 Action.
type AccessPointTransformationConfigurationArgs struct {
	Actions               pulumi.StringArrayInput `pulumi:"actions"`
	ContentTransformation pulumi.Input            `pulumi:"contentTransformation"`
}

func (AccessPointTransformationConfigurationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*AccessPointTransformationConfiguration)(nil)).Elem()
}

func (i AccessPointTransformationConfigurationArgs) ToAccessPointTransformationConfigurationOutput() AccessPointTransformationConfigurationOutput {
	return i.ToAccessPointTransformationConfigurationOutputWithContext(context.Background())
}

func (i AccessPointTransformationConfigurationArgs) ToAccessPointTransformationConfigurationOutputWithContext(ctx context.Context) AccessPointTransformationConfigurationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AccessPointTransformationConfigurationOutput)
}

// AccessPointTransformationConfigurationArrayInput is an input type that accepts AccessPointTransformationConfigurationArray and AccessPointTransformationConfigurationArrayOutput values.
// You can construct a concrete instance of `AccessPointTransformationConfigurationArrayInput` via:
//
//          AccessPointTransformationConfigurationArray{ AccessPointTransformationConfigurationArgs{...} }
type AccessPointTransformationConfigurationArrayInput interface {
	pulumi.Input

	ToAccessPointTransformationConfigurationArrayOutput() AccessPointTransformationConfigurationArrayOutput
	ToAccessPointTransformationConfigurationArrayOutputWithContext(context.Context) AccessPointTransformationConfigurationArrayOutput
}

type AccessPointTransformationConfigurationArray []AccessPointTransformationConfigurationInput

func (AccessPointTransformationConfigurationArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]AccessPointTransformationConfiguration)(nil)).Elem()
}

func (i AccessPointTransformationConfigurationArray) ToAccessPointTransformationConfigurationArrayOutput() AccessPointTransformationConfigurationArrayOutput {
	return i.ToAccessPointTransformationConfigurationArrayOutputWithContext(context.Background())
}

func (i AccessPointTransformationConfigurationArray) ToAccessPointTransformationConfigurationArrayOutputWithContext(ctx context.Context) AccessPointTransformationConfigurationArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AccessPointTransformationConfigurationArrayOutput)
}

// Configuration to define what content transformation will be applied on which S3 Action.
type AccessPointTransformationConfigurationOutput struct{ *pulumi.OutputState }

func (AccessPointTransformationConfigurationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*AccessPointTransformationConfiguration)(nil)).Elem()
}

func (o AccessPointTransformationConfigurationOutput) ToAccessPointTransformationConfigurationOutput() AccessPointTransformationConfigurationOutput {
	return o
}

func (o AccessPointTransformationConfigurationOutput) ToAccessPointTransformationConfigurationOutputWithContext(ctx context.Context) AccessPointTransformationConfigurationOutput {
	return o
}

func (o AccessPointTransformationConfigurationOutput) Actions() pulumi.StringArrayOutput {
	return o.ApplyT(func(v AccessPointTransformationConfiguration) []string { return v.Actions }).(pulumi.StringArrayOutput)
}

func (o AccessPointTransformationConfigurationOutput) ContentTransformation() pulumi.AnyOutput {
	return o.ApplyT(func(v AccessPointTransformationConfiguration) interface{} { return v.ContentTransformation }).(pulumi.AnyOutput)
}

type AccessPointTransformationConfigurationArrayOutput struct{ *pulumi.OutputState }

func (AccessPointTransformationConfigurationArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]AccessPointTransformationConfiguration)(nil)).Elem()
}

func (o AccessPointTransformationConfigurationArrayOutput) ToAccessPointTransformationConfigurationArrayOutput() AccessPointTransformationConfigurationArrayOutput {
	return o
}

func (o AccessPointTransformationConfigurationArrayOutput) ToAccessPointTransformationConfigurationArrayOutputWithContext(ctx context.Context) AccessPointTransformationConfigurationArrayOutput {
	return o
}

func (o AccessPointTransformationConfigurationArrayOutput) Index(i pulumi.IntInput) AccessPointTransformationConfigurationOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) AccessPointTransformationConfiguration {
		return vs[0].([]AccessPointTransformationConfiguration)[vs[1].(int)]
	}).(AccessPointTransformationConfigurationOutput)
}

type PolicyStatusProperties struct {
	// Specifies whether the Object lambda Access Point Policy is Public or not. Object lambda Access Points are private by default.
	IsPublic *bool `pulumi:"isPublic"`
}

// PolicyStatusPropertiesInput is an input type that accepts PolicyStatusPropertiesArgs and PolicyStatusPropertiesOutput values.
// You can construct a concrete instance of `PolicyStatusPropertiesInput` via:
//
//          PolicyStatusPropertiesArgs{...}
type PolicyStatusPropertiesInput interface {
	pulumi.Input

	ToPolicyStatusPropertiesOutput() PolicyStatusPropertiesOutput
	ToPolicyStatusPropertiesOutputWithContext(context.Context) PolicyStatusPropertiesOutput
}

type PolicyStatusPropertiesArgs struct {
	// Specifies whether the Object lambda Access Point Policy is Public or not. Object lambda Access Points are private by default.
	IsPublic pulumi.BoolPtrInput `pulumi:"isPublic"`
}

func (PolicyStatusPropertiesArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*PolicyStatusProperties)(nil)).Elem()
}

func (i PolicyStatusPropertiesArgs) ToPolicyStatusPropertiesOutput() PolicyStatusPropertiesOutput {
	return i.ToPolicyStatusPropertiesOutputWithContext(context.Background())
}

func (i PolicyStatusPropertiesArgs) ToPolicyStatusPropertiesOutputWithContext(ctx context.Context) PolicyStatusPropertiesOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PolicyStatusPropertiesOutput)
}

func (i PolicyStatusPropertiesArgs) ToPolicyStatusPropertiesPtrOutput() PolicyStatusPropertiesPtrOutput {
	return i.ToPolicyStatusPropertiesPtrOutputWithContext(context.Background())
}

func (i PolicyStatusPropertiesArgs) ToPolicyStatusPropertiesPtrOutputWithContext(ctx context.Context) PolicyStatusPropertiesPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PolicyStatusPropertiesOutput).ToPolicyStatusPropertiesPtrOutputWithContext(ctx)
}

// PolicyStatusPropertiesPtrInput is an input type that accepts PolicyStatusPropertiesArgs, PolicyStatusPropertiesPtr and PolicyStatusPropertiesPtrOutput values.
// You can construct a concrete instance of `PolicyStatusPropertiesPtrInput` via:
//
//          PolicyStatusPropertiesArgs{...}
//
//  or:
//
//          nil
type PolicyStatusPropertiesPtrInput interface {
	pulumi.Input

	ToPolicyStatusPropertiesPtrOutput() PolicyStatusPropertiesPtrOutput
	ToPolicyStatusPropertiesPtrOutputWithContext(context.Context) PolicyStatusPropertiesPtrOutput
}

type policyStatusPropertiesPtrType PolicyStatusPropertiesArgs

func PolicyStatusPropertiesPtr(v *PolicyStatusPropertiesArgs) PolicyStatusPropertiesPtrInput {
	return (*policyStatusPropertiesPtrType)(v)
}

func (*policyStatusPropertiesPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**PolicyStatusProperties)(nil)).Elem()
}

func (i *policyStatusPropertiesPtrType) ToPolicyStatusPropertiesPtrOutput() PolicyStatusPropertiesPtrOutput {
	return i.ToPolicyStatusPropertiesPtrOutputWithContext(context.Background())
}

func (i *policyStatusPropertiesPtrType) ToPolicyStatusPropertiesPtrOutputWithContext(ctx context.Context) PolicyStatusPropertiesPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PolicyStatusPropertiesPtrOutput)
}

type PolicyStatusPropertiesOutput struct{ *pulumi.OutputState }

func (PolicyStatusPropertiesOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*PolicyStatusProperties)(nil)).Elem()
}

func (o PolicyStatusPropertiesOutput) ToPolicyStatusPropertiesOutput() PolicyStatusPropertiesOutput {
	return o
}

func (o PolicyStatusPropertiesOutput) ToPolicyStatusPropertiesOutputWithContext(ctx context.Context) PolicyStatusPropertiesOutput {
	return o
}

func (o PolicyStatusPropertiesOutput) ToPolicyStatusPropertiesPtrOutput() PolicyStatusPropertiesPtrOutput {
	return o.ToPolicyStatusPropertiesPtrOutputWithContext(context.Background())
}

func (o PolicyStatusPropertiesOutput) ToPolicyStatusPropertiesPtrOutputWithContext(ctx context.Context) PolicyStatusPropertiesPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v PolicyStatusProperties) *PolicyStatusProperties {
		return &v
	}).(PolicyStatusPropertiesPtrOutput)
}

// Specifies whether the Object lambda Access Point Policy is Public or not. Object lambda Access Points are private by default.
func (o PolicyStatusPropertiesOutput) IsPublic() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v PolicyStatusProperties) *bool { return v.IsPublic }).(pulumi.BoolPtrOutput)
}

type PolicyStatusPropertiesPtrOutput struct{ *pulumi.OutputState }

func (PolicyStatusPropertiesPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**PolicyStatusProperties)(nil)).Elem()
}

func (o PolicyStatusPropertiesPtrOutput) ToPolicyStatusPropertiesPtrOutput() PolicyStatusPropertiesPtrOutput {
	return o
}

func (o PolicyStatusPropertiesPtrOutput) ToPolicyStatusPropertiesPtrOutputWithContext(ctx context.Context) PolicyStatusPropertiesPtrOutput {
	return o
}

func (o PolicyStatusPropertiesPtrOutput) Elem() PolicyStatusPropertiesOutput {
	return o.ApplyT(func(v *PolicyStatusProperties) PolicyStatusProperties {
		if v != nil {
			return *v
		}
		var ret PolicyStatusProperties
		return ret
	}).(PolicyStatusPropertiesOutput)
}

// Specifies whether the Object lambda Access Point Policy is Public or not. Object lambda Access Points are private by default.
func (o PolicyStatusPropertiesPtrOutput) IsPublic() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *PolicyStatusProperties) *bool {
		if v == nil {
			return nil
		}
		return v.IsPublic
	}).(pulumi.BoolPtrOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*AccessPointObjectLambdaConfigurationInput)(nil)).Elem(), AccessPointObjectLambdaConfigurationArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*AccessPointObjectLambdaConfigurationPtrInput)(nil)).Elem(), AccessPointObjectLambdaConfigurationArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*AccessPointPublicAccessBlockConfigurationInput)(nil)).Elem(), AccessPointPublicAccessBlockConfigurationArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*AccessPointPublicAccessBlockConfigurationPtrInput)(nil)).Elem(), AccessPointPublicAccessBlockConfigurationArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*AccessPointTransformationConfigurationInput)(nil)).Elem(), AccessPointTransformationConfigurationArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*AccessPointTransformationConfigurationArrayInput)(nil)).Elem(), AccessPointTransformationConfigurationArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*PolicyStatusPropertiesInput)(nil)).Elem(), PolicyStatusPropertiesArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*PolicyStatusPropertiesPtrInput)(nil)).Elem(), PolicyStatusPropertiesArgs{})
	pulumi.RegisterOutputType(AccessPointObjectLambdaConfigurationOutput{})
	pulumi.RegisterOutputType(AccessPointObjectLambdaConfigurationPtrOutput{})
	pulumi.RegisterOutputType(AccessPointPublicAccessBlockConfigurationOutput{})
	pulumi.RegisterOutputType(AccessPointPublicAccessBlockConfigurationPtrOutput{})
	pulumi.RegisterOutputType(AccessPointTransformationConfigurationOutput{})
	pulumi.RegisterOutputType(AccessPointTransformationConfigurationArrayOutput{})
	pulumi.RegisterOutputType(PolicyStatusPropertiesOutput{})
	pulumi.RegisterOutputType(PolicyStatusPropertiesPtrOutput{})
}
