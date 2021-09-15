# coding=utf-8
# *** WARNING: this file was generated by pulumigen. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs
from ._inputs import *

__all__ = ['ImagePipelineArgs', 'ImagePipeline']

@pulumi.input_type
class ImagePipelineArgs:
    def __init__(__self__, *,
                 container_recipe_arn: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 distribution_configuration_arn: Optional[pulumi.Input[str]] = None,
                 enhanced_image_metadata_enabled: Optional[pulumi.Input[bool]] = None,
                 image_recipe_arn: Optional[pulumi.Input[str]] = None,
                 image_tests_configuration: Optional[pulumi.Input['ImagePipelineImageTestsConfigurationArgs']] = None,
                 infrastructure_configuration_arn: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 schedule: Optional[pulumi.Input['ImagePipelineScheduleArgs']] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 tags: Optional[Any] = None):
        """
        The set of arguments for constructing a ImagePipeline resource.
        :param pulumi.Input[str] container_recipe_arn: The Amazon Resource Name (ARN) of the container recipe that defines how images are configured and tested.
        :param pulumi.Input[str] description: The description of the image pipeline.
        :param pulumi.Input[str] distribution_configuration_arn: The Amazon Resource Name (ARN) of the distribution configuration associated with this image pipeline.
        :param pulumi.Input[bool] enhanced_image_metadata_enabled: Collects additional information about the image being created, including the operating system (OS) version and package list.
        :param pulumi.Input[str] image_recipe_arn: The Amazon Resource Name (ARN) of the image recipe that defines how images are configured, tested, and assessed.
        :param pulumi.Input['ImagePipelineImageTestsConfigurationArgs'] image_tests_configuration: The image tests configuration of the image pipeline.
        :param pulumi.Input[str] infrastructure_configuration_arn: The Amazon Resource Name (ARN) of the infrastructure configuration associated with this image pipeline.
        :param pulumi.Input[str] name: The name of the image pipeline.
        :param pulumi.Input['ImagePipelineScheduleArgs'] schedule: The schedule of the image pipeline.
        :param pulumi.Input[str] status: The status of the image pipeline.
        :param Any tags: The tags of this image pipeline.
        """
        if container_recipe_arn is not None:
            pulumi.set(__self__, "container_recipe_arn", container_recipe_arn)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if distribution_configuration_arn is not None:
            pulumi.set(__self__, "distribution_configuration_arn", distribution_configuration_arn)
        if enhanced_image_metadata_enabled is not None:
            pulumi.set(__self__, "enhanced_image_metadata_enabled", enhanced_image_metadata_enabled)
        if image_recipe_arn is not None:
            pulumi.set(__self__, "image_recipe_arn", image_recipe_arn)
        if image_tests_configuration is not None:
            pulumi.set(__self__, "image_tests_configuration", image_tests_configuration)
        if infrastructure_configuration_arn is not None:
            pulumi.set(__self__, "infrastructure_configuration_arn", infrastructure_configuration_arn)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if schedule is not None:
            pulumi.set(__self__, "schedule", schedule)
        if status is not None:
            pulumi.set(__self__, "status", status)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter(name="containerRecipeArn")
    def container_recipe_arn(self) -> Optional[pulumi.Input[str]]:
        """
        The Amazon Resource Name (ARN) of the container recipe that defines how images are configured and tested.
        """
        return pulumi.get(self, "container_recipe_arn")

    @container_recipe_arn.setter
    def container_recipe_arn(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "container_recipe_arn", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        The description of the image pipeline.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="distributionConfigurationArn")
    def distribution_configuration_arn(self) -> Optional[pulumi.Input[str]]:
        """
        The Amazon Resource Name (ARN) of the distribution configuration associated with this image pipeline.
        """
        return pulumi.get(self, "distribution_configuration_arn")

    @distribution_configuration_arn.setter
    def distribution_configuration_arn(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "distribution_configuration_arn", value)

    @property
    @pulumi.getter(name="enhancedImageMetadataEnabled")
    def enhanced_image_metadata_enabled(self) -> Optional[pulumi.Input[bool]]:
        """
        Collects additional information about the image being created, including the operating system (OS) version and package list.
        """
        return pulumi.get(self, "enhanced_image_metadata_enabled")

    @enhanced_image_metadata_enabled.setter
    def enhanced_image_metadata_enabled(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enhanced_image_metadata_enabled", value)

    @property
    @pulumi.getter(name="imageRecipeArn")
    def image_recipe_arn(self) -> Optional[pulumi.Input[str]]:
        """
        The Amazon Resource Name (ARN) of the image recipe that defines how images are configured, tested, and assessed.
        """
        return pulumi.get(self, "image_recipe_arn")

    @image_recipe_arn.setter
    def image_recipe_arn(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "image_recipe_arn", value)

    @property
    @pulumi.getter(name="imageTestsConfiguration")
    def image_tests_configuration(self) -> Optional[pulumi.Input['ImagePipelineImageTestsConfigurationArgs']]:
        """
        The image tests configuration of the image pipeline.
        """
        return pulumi.get(self, "image_tests_configuration")

    @image_tests_configuration.setter
    def image_tests_configuration(self, value: Optional[pulumi.Input['ImagePipelineImageTestsConfigurationArgs']]):
        pulumi.set(self, "image_tests_configuration", value)

    @property
    @pulumi.getter(name="infrastructureConfigurationArn")
    def infrastructure_configuration_arn(self) -> Optional[pulumi.Input[str]]:
        """
        The Amazon Resource Name (ARN) of the infrastructure configuration associated with this image pipeline.
        """
        return pulumi.get(self, "infrastructure_configuration_arn")

    @infrastructure_configuration_arn.setter
    def infrastructure_configuration_arn(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "infrastructure_configuration_arn", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the image pipeline.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def schedule(self) -> Optional[pulumi.Input['ImagePipelineScheduleArgs']]:
        """
        The schedule of the image pipeline.
        """
        return pulumi.get(self, "schedule")

    @schedule.setter
    def schedule(self, value: Optional[pulumi.Input['ImagePipelineScheduleArgs']]):
        pulumi.set(self, "schedule", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[str]]:
        """
        The status of the image pipeline.
        """
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "status", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[Any]:
        """
        The tags of this image pipeline.
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[Any]):
        pulumi.set(self, "tags", value)


class ImagePipeline(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 container_recipe_arn: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 distribution_configuration_arn: Optional[pulumi.Input[str]] = None,
                 enhanced_image_metadata_enabled: Optional[pulumi.Input[bool]] = None,
                 image_recipe_arn: Optional[pulumi.Input[str]] = None,
                 image_tests_configuration: Optional[pulumi.Input[pulumi.InputType['ImagePipelineImageTestsConfigurationArgs']]] = None,
                 infrastructure_configuration_arn: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 schedule: Optional[pulumi.Input[pulumi.InputType['ImagePipelineScheduleArgs']]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 tags: Optional[Any] = None,
                 __props__=None):
        """
        Resource schema for AWS::ImageBuilder::ImagePipeline

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] container_recipe_arn: The Amazon Resource Name (ARN) of the container recipe that defines how images are configured and tested.
        :param pulumi.Input[str] description: The description of the image pipeline.
        :param pulumi.Input[str] distribution_configuration_arn: The Amazon Resource Name (ARN) of the distribution configuration associated with this image pipeline.
        :param pulumi.Input[bool] enhanced_image_metadata_enabled: Collects additional information about the image being created, including the operating system (OS) version and package list.
        :param pulumi.Input[str] image_recipe_arn: The Amazon Resource Name (ARN) of the image recipe that defines how images are configured, tested, and assessed.
        :param pulumi.Input[pulumi.InputType['ImagePipelineImageTestsConfigurationArgs']] image_tests_configuration: The image tests configuration of the image pipeline.
        :param pulumi.Input[str] infrastructure_configuration_arn: The Amazon Resource Name (ARN) of the infrastructure configuration associated with this image pipeline.
        :param pulumi.Input[str] name: The name of the image pipeline.
        :param pulumi.Input[pulumi.InputType['ImagePipelineScheduleArgs']] schedule: The schedule of the image pipeline.
        :param pulumi.Input[str] status: The status of the image pipeline.
        :param Any tags: The tags of this image pipeline.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[ImagePipelineArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource schema for AWS::ImageBuilder::ImagePipeline

        :param str resource_name: The name of the resource.
        :param ImagePipelineArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ImagePipelineArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 container_recipe_arn: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 distribution_configuration_arn: Optional[pulumi.Input[str]] = None,
                 enhanced_image_metadata_enabled: Optional[pulumi.Input[bool]] = None,
                 image_recipe_arn: Optional[pulumi.Input[str]] = None,
                 image_tests_configuration: Optional[pulumi.Input[pulumi.InputType['ImagePipelineImageTestsConfigurationArgs']]] = None,
                 infrastructure_configuration_arn: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 schedule: Optional[pulumi.Input[pulumi.InputType['ImagePipelineScheduleArgs']]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 tags: Optional[Any] = None,
                 __props__=None):
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ImagePipelineArgs.__new__(ImagePipelineArgs)

            __props__.__dict__["container_recipe_arn"] = container_recipe_arn
            __props__.__dict__["description"] = description
            __props__.__dict__["distribution_configuration_arn"] = distribution_configuration_arn
            __props__.__dict__["enhanced_image_metadata_enabled"] = enhanced_image_metadata_enabled
            __props__.__dict__["image_recipe_arn"] = image_recipe_arn
            __props__.__dict__["image_tests_configuration"] = image_tests_configuration
            __props__.__dict__["infrastructure_configuration_arn"] = infrastructure_configuration_arn
            __props__.__dict__["name"] = name
            __props__.__dict__["schedule"] = schedule
            __props__.__dict__["status"] = status
            __props__.__dict__["tags"] = tags
            __props__.__dict__["arn"] = None
        super(ImagePipeline, __self__).__init__(
            'aws-native:imagebuilder:ImagePipeline',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'ImagePipeline':
        """
        Get an existing ImagePipeline resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = ImagePipelineArgs.__new__(ImagePipelineArgs)

        __props__.__dict__["arn"] = None
        __props__.__dict__["container_recipe_arn"] = None
        __props__.__dict__["description"] = None
        __props__.__dict__["distribution_configuration_arn"] = None
        __props__.__dict__["enhanced_image_metadata_enabled"] = None
        __props__.__dict__["image_recipe_arn"] = None
        __props__.__dict__["image_tests_configuration"] = None
        __props__.__dict__["infrastructure_configuration_arn"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["schedule"] = None
        __props__.__dict__["status"] = None
        __props__.__dict__["tags"] = None
        return ImagePipeline(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def arn(self) -> pulumi.Output[str]:
        """
        The Amazon Resource Name (ARN) of the image pipeline.
        """
        return pulumi.get(self, "arn")

    @property
    @pulumi.getter(name="containerRecipeArn")
    def container_recipe_arn(self) -> pulumi.Output[Optional[str]]:
        """
        The Amazon Resource Name (ARN) of the container recipe that defines how images are configured and tested.
        """
        return pulumi.get(self, "container_recipe_arn")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        The description of the image pipeline.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="distributionConfigurationArn")
    def distribution_configuration_arn(self) -> pulumi.Output[Optional[str]]:
        """
        The Amazon Resource Name (ARN) of the distribution configuration associated with this image pipeline.
        """
        return pulumi.get(self, "distribution_configuration_arn")

    @property
    @pulumi.getter(name="enhancedImageMetadataEnabled")
    def enhanced_image_metadata_enabled(self) -> pulumi.Output[Optional[bool]]:
        """
        Collects additional information about the image being created, including the operating system (OS) version and package list.
        """
        return pulumi.get(self, "enhanced_image_metadata_enabled")

    @property
    @pulumi.getter(name="imageRecipeArn")
    def image_recipe_arn(self) -> pulumi.Output[Optional[str]]:
        """
        The Amazon Resource Name (ARN) of the image recipe that defines how images are configured, tested, and assessed.
        """
        return pulumi.get(self, "image_recipe_arn")

    @property
    @pulumi.getter(name="imageTestsConfiguration")
    def image_tests_configuration(self) -> pulumi.Output[Optional['outputs.ImagePipelineImageTestsConfiguration']]:
        """
        The image tests configuration of the image pipeline.
        """
        return pulumi.get(self, "image_tests_configuration")

    @property
    @pulumi.getter(name="infrastructureConfigurationArn")
    def infrastructure_configuration_arn(self) -> pulumi.Output[Optional[str]]:
        """
        The Amazon Resource Name (ARN) of the infrastructure configuration associated with this image pipeline.
        """
        return pulumi.get(self, "infrastructure_configuration_arn")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[Optional[str]]:
        """
        The name of the image pipeline.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def schedule(self) -> pulumi.Output[Optional['outputs.ImagePipelineSchedule']]:
        """
        The schedule of the image pipeline.
        """
        return pulumi.get(self, "schedule")

    @property
    @pulumi.getter
    def status(self) -> pulumi.Output[Optional[str]]:
        """
        The status of the image pipeline.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Any]]:
        """
        The tags of this image pipeline.
        """
        return pulumi.get(self, "tags")

