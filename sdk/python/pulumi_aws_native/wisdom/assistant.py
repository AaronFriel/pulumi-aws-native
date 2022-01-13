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

__all__ = ['AssistantArgs', 'Assistant']

@pulumi.input_type
class AssistantArgs:
    def __init__(__self__, *,
                 type: pulumi.Input['AssistantType'],
                 description: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 server_side_encryption_configuration: Optional[pulumi.Input['AssistantServerSideEncryptionConfigurationArgs']] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input['AssistantTagArgs']]]] = None):
        """
        The set of arguments for constructing a Assistant resource.
        """
        pulumi.set(__self__, "type", type)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if server_side_encryption_configuration is not None:
            pulumi.set(__self__, "server_side_encryption_configuration", server_side_encryption_configuration)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter
    def type(self) -> pulumi.Input['AssistantType']:
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: pulumi.Input['AssistantType']):
        pulumi.set(self, "type", value)

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
    @pulumi.getter(name="serverSideEncryptionConfiguration")
    def server_side_encryption_configuration(self) -> Optional[pulumi.Input['AssistantServerSideEncryptionConfigurationArgs']]:
        return pulumi.get(self, "server_side_encryption_configuration")

    @server_side_encryption_configuration.setter
    def server_side_encryption_configuration(self, value: Optional[pulumi.Input['AssistantServerSideEncryptionConfigurationArgs']]):
        pulumi.set(self, "server_side_encryption_configuration", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['AssistantTagArgs']]]]:
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['AssistantTagArgs']]]]):
        pulumi.set(self, "tags", value)


class Assistant(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 server_side_encryption_configuration: Optional[pulumi.Input[pulumi.InputType['AssistantServerSideEncryptionConfigurationArgs']]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AssistantTagArgs']]]]] = None,
                 type: Optional[pulumi.Input['AssistantType']] = None,
                 __props__=None):
        """
        Definition of AWS::Wisdom::Assistant Resource Type

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: AssistantArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Definition of AWS::Wisdom::Assistant Resource Type

        :param str resource_name: The name of the resource.
        :param AssistantArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(AssistantArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 server_side_encryption_configuration: Optional[pulumi.Input[pulumi.InputType['AssistantServerSideEncryptionConfigurationArgs']]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AssistantTagArgs']]]]] = None,
                 type: Optional[pulumi.Input['AssistantType']] = None,
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
            __props__ = AssistantArgs.__new__(AssistantArgs)

            __props__.__dict__["description"] = description
            __props__.__dict__["name"] = name
            __props__.__dict__["server_side_encryption_configuration"] = server_side_encryption_configuration
            __props__.__dict__["tags"] = tags
            if type is None and not opts.urn:
                raise TypeError("Missing required property 'type'")
            __props__.__dict__["type"] = type
            __props__.__dict__["assistant_arn"] = None
            __props__.__dict__["assistant_id"] = None
        super(Assistant, __self__).__init__(
            'aws-native:wisdom:Assistant',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Assistant':
        """
        Get an existing Assistant resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = AssistantArgs.__new__(AssistantArgs)

        __props__.__dict__["assistant_arn"] = None
        __props__.__dict__["assistant_id"] = None
        __props__.__dict__["description"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["server_side_encryption_configuration"] = None
        __props__.__dict__["tags"] = None
        __props__.__dict__["type"] = None
        return Assistant(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="assistantArn")
    def assistant_arn(self) -> pulumi.Output[str]:
        return pulumi.get(self, "assistant_arn")

    @property
    @pulumi.getter(name="assistantId")
    def assistant_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "assistant_id")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="serverSideEncryptionConfiguration")
    def server_side_encryption_configuration(self) -> pulumi.Output[Optional['outputs.AssistantServerSideEncryptionConfiguration']]:
        return pulumi.get(self, "server_side_encryption_configuration")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence['outputs.AssistantTag']]]:
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output['AssistantType']:
        return pulumi.get(self, "type")

