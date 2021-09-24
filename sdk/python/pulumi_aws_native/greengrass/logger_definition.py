# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs
from ._inputs import *

__all__ = ['LoggerDefinitionArgs', 'LoggerDefinition']

@pulumi.input_type
class LoggerDefinitionArgs:
    def __init__(__self__, *,
                 name: pulumi.Input[str],
                 initial_version: Optional[pulumi.Input['LoggerDefinitionLoggerDefinitionVersionArgs']] = None,
                 tags: Optional[Any] = None):
        """
        The set of arguments for constructing a LoggerDefinition resource.
        """
        pulumi.set(__self__, "name", name)
        if initial_version is not None:
            pulumi.set(__self__, "initial_version", initial_version)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: pulumi.Input[str]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="initialVersion")
    def initial_version(self) -> Optional[pulumi.Input['LoggerDefinitionLoggerDefinitionVersionArgs']]:
        return pulumi.get(self, "initial_version")

    @initial_version.setter
    def initial_version(self, value: Optional[pulumi.Input['LoggerDefinitionLoggerDefinitionVersionArgs']]):
        pulumi.set(self, "initial_version", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[Any]:
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[Any]):
        pulumi.set(self, "tags", value)


warnings.warn("""LoggerDefinition is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)


class LoggerDefinition(pulumi.CustomResource):
    warnings.warn("""LoggerDefinition is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 initial_version: Optional[pulumi.Input[pulumi.InputType['LoggerDefinitionLoggerDefinitionVersionArgs']]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[Any] = None,
                 __props__=None):
        """
        Resource Type definition for AWS::Greengrass::LoggerDefinition

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: LoggerDefinitionArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource Type definition for AWS::Greengrass::LoggerDefinition

        :param str resource_name: The name of the resource.
        :param LoggerDefinitionArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(LoggerDefinitionArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 initial_version: Optional[pulumi.Input[pulumi.InputType['LoggerDefinitionLoggerDefinitionVersionArgs']]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[Any] = None,
                 __props__=None):
        pulumi.log.warn("""LoggerDefinition is deprecated: LoggerDefinition is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = LoggerDefinitionArgs.__new__(LoggerDefinitionArgs)

            __props__.__dict__["initial_version"] = initial_version
            if name is None and not opts.urn:
                raise TypeError("Missing required property 'name'")
            __props__.__dict__["name"] = name
            __props__.__dict__["tags"] = tags
            __props__.__dict__["arn"] = None
            __props__.__dict__["latest_version_arn"] = None
        super(LoggerDefinition, __self__).__init__(
            'aws-native:greengrass:LoggerDefinition',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'LoggerDefinition':
        """
        Get an existing LoggerDefinition resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = LoggerDefinitionArgs.__new__(LoggerDefinitionArgs)

        __props__.__dict__["arn"] = None
        __props__.__dict__["initial_version"] = None
        __props__.__dict__["latest_version_arn"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["tags"] = None
        return LoggerDefinition(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def arn(self) -> pulumi.Output[str]:
        return pulumi.get(self, "arn")

    @property
    @pulumi.getter(name="initialVersion")
    def initial_version(self) -> pulumi.Output[Optional['outputs.LoggerDefinitionLoggerDefinitionVersion']]:
        return pulumi.get(self, "initial_version")

    @property
    @pulumi.getter(name="latestVersionArn")
    def latest_version_arn(self) -> pulumi.Output[str]:
        return pulumi.get(self, "latest_version_arn")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Any]]:
        return pulumi.get(self, "tags")
