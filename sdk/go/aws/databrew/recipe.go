// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package databrew

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi-aws-native/sdk/go/aws"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-recipe.html
type Recipe struct {
	pulumi.CustomResourceState

	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-recipe.html#cfn-databrew-recipe-description
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-recipe.html#cfn-databrew-recipe-name
	Name pulumi.StringOutput `pulumi:"name"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-recipe.html#cfn-databrew-recipe-steps
	Steps RecipeRecipeStepArrayOutput `pulumi:"steps"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-recipe.html#cfn-databrew-recipe-tags
	Tags aws.TagArrayOutput `pulumi:"tags"`
}

// NewRecipe registers a new resource with the given unique name, arguments, and options.
func NewRecipe(ctx *pulumi.Context,
	name string, args *RecipeArgs, opts ...pulumi.ResourceOption) (*Recipe, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Name == nil {
		return nil, errors.New("invalid value for required argument 'Name'")
	}
	if args.Steps == nil {
		return nil, errors.New("invalid value for required argument 'Steps'")
	}
	var resource Recipe
	err := ctx.RegisterResource("aws-native:DataBrew:Recipe", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRecipe gets an existing Recipe resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRecipe(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RecipeState, opts ...pulumi.ResourceOption) (*Recipe, error) {
	var resource Recipe
	err := ctx.ReadResource("aws-native:DataBrew:Recipe", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Recipe resources.
type recipeState struct {
}

type RecipeState struct {
}

func (RecipeState) ElementType() reflect.Type {
	return reflect.TypeOf((*recipeState)(nil)).Elem()
}

type recipeArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-recipe.html#cfn-databrew-recipe-description
	Description *string `pulumi:"description"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-recipe.html#cfn-databrew-recipe-name
	Name string `pulumi:"name"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-recipe.html#cfn-databrew-recipe-steps
	Steps []RecipeRecipeStep `pulumi:"steps"`
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-recipe.html#cfn-databrew-recipe-tags
	Tags []aws.Tag `pulumi:"tags"`
}

// The set of arguments for constructing a Recipe resource.
type RecipeArgs struct {
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-recipe.html#cfn-databrew-recipe-description
	Description pulumi.StringPtrInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-recipe.html#cfn-databrew-recipe-name
	Name pulumi.StringInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-recipe.html#cfn-databrew-recipe-steps
	Steps RecipeRecipeStepArrayInput
	// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-recipe.html#cfn-databrew-recipe-tags
	Tags aws.TagArrayInput
}

func (RecipeArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*recipeArgs)(nil)).Elem()
}

type RecipeInput interface {
	pulumi.Input

	ToRecipeOutput() RecipeOutput
	ToRecipeOutputWithContext(ctx context.Context) RecipeOutput
}

func (*Recipe) ElementType() reflect.Type {
	return reflect.TypeOf((*Recipe)(nil))
}

func (i *Recipe) ToRecipeOutput() RecipeOutput {
	return i.ToRecipeOutputWithContext(context.Background())
}

func (i *Recipe) ToRecipeOutputWithContext(ctx context.Context) RecipeOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RecipeOutput)
}

type RecipeOutput struct{ *pulumi.OutputState }

func (RecipeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Recipe)(nil))
}

func (o RecipeOutput) ToRecipeOutput() RecipeOutput {
	return o
}

func (o RecipeOutput) ToRecipeOutputWithContext(ctx context.Context) RecipeOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(RecipeOutput{})
}