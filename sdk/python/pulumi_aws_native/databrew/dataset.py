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

__all__ = ['DatasetArgs', 'Dataset']

@pulumi.input_type
class DatasetArgs:
    def __init__(__self__, *,
                 input: pulumi.Input['DatasetInputArgs'],
                 name: pulumi.Input[str],
                 format: Optional[pulumi.Input[str]] = None,
                 format_options: Optional[pulumi.Input['DatasetFormatOptionsArgs']] = None,
                 path_options: Optional[pulumi.Input['DatasetPathOptionsArgs']] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input['DatasetTagArgs']]]] = None):
        """
        The set of arguments for constructing a Dataset resource.
        :param pulumi.Input['DatasetInputArgs'] input: Input
        :param pulumi.Input[str] name: Dataset name
        :param pulumi.Input[str] format: Dataset format
        :param pulumi.Input['DatasetFormatOptionsArgs'] format_options: Format options for dataset
        :param pulumi.Input['DatasetPathOptionsArgs'] path_options: PathOptions
        """
        pulumi.set(__self__, "input", input)
        pulumi.set(__self__, "name", name)
        if format is not None:
            pulumi.set(__self__, "format", format)
        if format_options is not None:
            pulumi.set(__self__, "format_options", format_options)
        if path_options is not None:
            pulumi.set(__self__, "path_options", path_options)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter
    def input(self) -> pulumi.Input['DatasetInputArgs']:
        """
        Input
        """
        return pulumi.get(self, "input")

    @input.setter
    def input(self, value: pulumi.Input['DatasetInputArgs']):
        pulumi.set(self, "input", value)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Input[str]:
        """
        Dataset name
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: pulumi.Input[str]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def format(self) -> Optional[pulumi.Input[str]]:
        """
        Dataset format
        """
        return pulumi.get(self, "format")

    @format.setter
    def format(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "format", value)

    @property
    @pulumi.getter(name="formatOptions")
    def format_options(self) -> Optional[pulumi.Input['DatasetFormatOptionsArgs']]:
        """
        Format options for dataset
        """
        return pulumi.get(self, "format_options")

    @format_options.setter
    def format_options(self, value: Optional[pulumi.Input['DatasetFormatOptionsArgs']]):
        pulumi.set(self, "format_options", value)

    @property
    @pulumi.getter(name="pathOptions")
    def path_options(self) -> Optional[pulumi.Input['DatasetPathOptionsArgs']]:
        """
        PathOptions
        """
        return pulumi.get(self, "path_options")

    @path_options.setter
    def path_options(self, value: Optional[pulumi.Input['DatasetPathOptionsArgs']]):
        pulumi.set(self, "path_options", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['DatasetTagArgs']]]]:
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['DatasetTagArgs']]]]):
        pulumi.set(self, "tags", value)


class Dataset(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 format: Optional[pulumi.Input[str]] = None,
                 format_options: Optional[pulumi.Input[pulumi.InputType['DatasetFormatOptionsArgs']]] = None,
                 input: Optional[pulumi.Input[pulumi.InputType['DatasetInputArgs']]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 path_options: Optional[pulumi.Input[pulumi.InputType['DatasetPathOptionsArgs']]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DatasetTagArgs']]]]] = None,
                 __props__=None):
        """
        Resource schema for AWS::DataBrew::Dataset.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] format: Dataset format
        :param pulumi.Input[pulumi.InputType['DatasetFormatOptionsArgs']] format_options: Format options for dataset
        :param pulumi.Input[pulumi.InputType['DatasetInputArgs']] input: Input
        :param pulumi.Input[str] name: Dataset name
        :param pulumi.Input[pulumi.InputType['DatasetPathOptionsArgs']] path_options: PathOptions
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: DatasetArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource schema for AWS::DataBrew::Dataset.

        :param str resource_name: The name of the resource.
        :param DatasetArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(DatasetArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 format: Optional[pulumi.Input[str]] = None,
                 format_options: Optional[pulumi.Input[pulumi.InputType['DatasetFormatOptionsArgs']]] = None,
                 input: Optional[pulumi.Input[pulumi.InputType['DatasetInputArgs']]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 path_options: Optional[pulumi.Input[pulumi.InputType['DatasetPathOptionsArgs']]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DatasetTagArgs']]]]] = None,
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
            __props__ = DatasetArgs.__new__(DatasetArgs)

            __props__.__dict__["format"] = format
            __props__.__dict__["format_options"] = format_options
            if input is None and not opts.urn:
                raise TypeError("Missing required property 'input'")
            __props__.__dict__["input"] = input
            if name is None and not opts.urn:
                raise TypeError("Missing required property 'name'")
            __props__.__dict__["name"] = name
            __props__.__dict__["path_options"] = path_options
            __props__.__dict__["tags"] = tags
        super(Dataset, __self__).__init__(
            'aws-native:databrew:Dataset',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Dataset':
        """
        Get an existing Dataset resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = DatasetArgs.__new__(DatasetArgs)

        __props__.__dict__["format"] = None
        __props__.__dict__["format_options"] = None
        __props__.__dict__["input"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["path_options"] = None
        __props__.__dict__["tags"] = None
        return Dataset(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def format(self) -> pulumi.Output[Optional[str]]:
        """
        Dataset format
        """
        return pulumi.get(self, "format")

    @property
    @pulumi.getter(name="formatOptions")
    def format_options(self) -> pulumi.Output[Optional['outputs.DatasetFormatOptions']]:
        """
        Format options for dataset
        """
        return pulumi.get(self, "format_options")

    @property
    @pulumi.getter
    def input(self) -> pulumi.Output['outputs.DatasetInput']:
        """
        Input
        """
        return pulumi.get(self, "input")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Dataset name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="pathOptions")
    def path_options(self) -> pulumi.Output[Optional['outputs.DatasetPathOptions']]:
        """
        PathOptions
        """
        return pulumi.get(self, "path_options")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence['outputs.DatasetTag']]]:
        return pulumi.get(self, "tags")

