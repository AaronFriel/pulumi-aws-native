# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs
from ._enums import *
from ._inputs import *

__all__ = ['DataSourceArgs', 'DataSource']

@pulumi.input_type
class DataSourceArgs:
    def __init__(__self__, *,
                 index_id: pulumi.Input[str],
                 type: pulumi.Input['DataSourceType'],
                 data_source_configuration: Optional[pulumi.Input['DataSourceConfigurationArgs']] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 role_arn: Optional[pulumi.Input[str]] = None,
                 schedule: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input['DataSourceTagArgs']]]] = None):
        """
        The set of arguments for constructing a DataSource resource.
        :param pulumi.Input[Sequence[pulumi.Input['DataSourceTagArgs']]] tags: Tags for labeling the data source
        """
        pulumi.set(__self__, "index_id", index_id)
        pulumi.set(__self__, "type", type)
        if data_source_configuration is not None:
            pulumi.set(__self__, "data_source_configuration", data_source_configuration)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if role_arn is not None:
            pulumi.set(__self__, "role_arn", role_arn)
        if schedule is not None:
            pulumi.set(__self__, "schedule", schedule)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter(name="indexId")
    def index_id(self) -> pulumi.Input[str]:
        return pulumi.get(self, "index_id")

    @index_id.setter
    def index_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "index_id", value)

    @property
    @pulumi.getter
    def type(self) -> pulumi.Input['DataSourceType']:
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: pulumi.Input['DataSourceType']):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter(name="dataSourceConfiguration")
    def data_source_configuration(self) -> Optional[pulumi.Input['DataSourceConfigurationArgs']]:
        return pulumi.get(self, "data_source_configuration")

    @data_source_configuration.setter
    def data_source_configuration(self, value: Optional[pulumi.Input['DataSourceConfigurationArgs']]):
        pulumi.set(self, "data_source_configuration", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="roleArn")
    def role_arn(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "role_arn")

    @role_arn.setter
    def role_arn(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "role_arn", value)

    @property
    @pulumi.getter
    def schedule(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "schedule")

    @schedule.setter
    def schedule(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "schedule", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['DataSourceTagArgs']]]]:
        """
        Tags for labeling the data source
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['DataSourceTagArgs']]]]):
        pulumi.set(self, "tags", value)


class DataSource(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 data_source_configuration: Optional[pulumi.Input[pulumi.InputType['DataSourceConfigurationArgs']]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 index_id: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 role_arn: Optional[pulumi.Input[str]] = None,
                 schedule: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DataSourceTagArgs']]]]] = None,
                 type: Optional[pulumi.Input['DataSourceType']] = None,
                 __props__=None):
        """
        Kendra DataSource

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DataSourceTagArgs']]]] tags: Tags for labeling the data source
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: DataSourceArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Kendra DataSource

        :param str resource_name: The name of the resource.
        :param DataSourceArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(DataSourceArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 data_source_configuration: Optional[pulumi.Input[pulumi.InputType['DataSourceConfigurationArgs']]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 index_id: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 role_arn: Optional[pulumi.Input[str]] = None,
                 schedule: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DataSourceTagArgs']]]]] = None,
                 type: Optional[pulumi.Input['DataSourceType']] = None,
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
            __props__ = DataSourceArgs.__new__(DataSourceArgs)

            __props__.__dict__["data_source_configuration"] = data_source_configuration
            __props__.__dict__["description"] = description
            if index_id is None and not opts.urn:
                raise TypeError("Missing required property 'index_id'")
            __props__.__dict__["index_id"] = index_id
            __props__.__dict__["name"] = name
            __props__.__dict__["role_arn"] = role_arn
            __props__.__dict__["schedule"] = schedule
            __props__.__dict__["tags"] = tags
            if type is None and not opts.urn:
                raise TypeError("Missing required property 'type'")
            __props__.__dict__["type"] = type
            __props__.__dict__["arn"] = None
        super(DataSource, __self__).__init__(
            'aws-native:kendra:DataSource',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'DataSource':
        """
        Get an existing DataSource resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = DataSourceArgs.__new__(DataSourceArgs)

        __props__.__dict__["arn"] = None
        __props__.__dict__["data_source_configuration"] = None
        __props__.__dict__["description"] = None
        __props__.__dict__["index_id"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["role_arn"] = None
        __props__.__dict__["schedule"] = None
        __props__.__dict__["tags"] = None
        __props__.__dict__["type"] = None
        return DataSource(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def arn(self) -> pulumi.Output[str]:
        return pulumi.get(self, "arn")

    @property
    @pulumi.getter(name="dataSourceConfiguration")
    def data_source_configuration(self) -> pulumi.Output[Optional['outputs.DataSourceConfiguration']]:
        return pulumi.get(self, "data_source_configuration")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="indexId")
    def index_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "index_id")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="roleArn")
    def role_arn(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "role_arn")

    @property
    @pulumi.getter
    def schedule(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "schedule")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence['outputs.DataSourceTag']]]:
        """
        Tags for labeling the data source
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output['DataSourceType']:
        return pulumi.get(self, "type")

