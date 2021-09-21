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

__all__ = ['ChannelArgs', 'Channel']

@pulumi.input_type
class ChannelArgs:
    def __init__(__self__, *,
                 cdi_input_specification: Optional[pulumi.Input['ChannelCdiInputSpecificationArgs']] = None,
                 channel_class: Optional[pulumi.Input[str]] = None,
                 destinations: Optional[pulumi.Input[Sequence[pulumi.Input['ChannelOutputDestinationArgs']]]] = None,
                 encoder_settings: Optional[pulumi.Input['ChannelEncoderSettingsArgs']] = None,
                 input_attachments: Optional[pulumi.Input[Sequence[pulumi.Input['ChannelInputAttachmentArgs']]]] = None,
                 input_specification: Optional[pulumi.Input['ChannelInputSpecificationArgs']] = None,
                 log_level: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 role_arn: Optional[pulumi.Input[str]] = None,
                 tags: Optional[Any] = None,
                 vpc: Optional[pulumi.Input['ChannelVpcOutputSettingsArgs']] = None):
        """
        The set of arguments for constructing a Channel resource.
        """
        if cdi_input_specification is not None:
            pulumi.set(__self__, "cdi_input_specification", cdi_input_specification)
        if channel_class is not None:
            pulumi.set(__self__, "channel_class", channel_class)
        if destinations is not None:
            pulumi.set(__self__, "destinations", destinations)
        if encoder_settings is not None:
            pulumi.set(__self__, "encoder_settings", encoder_settings)
        if input_attachments is not None:
            pulumi.set(__self__, "input_attachments", input_attachments)
        if input_specification is not None:
            pulumi.set(__self__, "input_specification", input_specification)
        if log_level is not None:
            pulumi.set(__self__, "log_level", log_level)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if role_arn is not None:
            pulumi.set(__self__, "role_arn", role_arn)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)
        if vpc is not None:
            pulumi.set(__self__, "vpc", vpc)

    @property
    @pulumi.getter(name="cdiInputSpecification")
    def cdi_input_specification(self) -> Optional[pulumi.Input['ChannelCdiInputSpecificationArgs']]:
        return pulumi.get(self, "cdi_input_specification")

    @cdi_input_specification.setter
    def cdi_input_specification(self, value: Optional[pulumi.Input['ChannelCdiInputSpecificationArgs']]):
        pulumi.set(self, "cdi_input_specification", value)

    @property
    @pulumi.getter(name="channelClass")
    def channel_class(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "channel_class")

    @channel_class.setter
    def channel_class(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "channel_class", value)

    @property
    @pulumi.getter
    def destinations(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['ChannelOutputDestinationArgs']]]]:
        return pulumi.get(self, "destinations")

    @destinations.setter
    def destinations(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['ChannelOutputDestinationArgs']]]]):
        pulumi.set(self, "destinations", value)

    @property
    @pulumi.getter(name="encoderSettings")
    def encoder_settings(self) -> Optional[pulumi.Input['ChannelEncoderSettingsArgs']]:
        return pulumi.get(self, "encoder_settings")

    @encoder_settings.setter
    def encoder_settings(self, value: Optional[pulumi.Input['ChannelEncoderSettingsArgs']]):
        pulumi.set(self, "encoder_settings", value)

    @property
    @pulumi.getter(name="inputAttachments")
    def input_attachments(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['ChannelInputAttachmentArgs']]]]:
        return pulumi.get(self, "input_attachments")

    @input_attachments.setter
    def input_attachments(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['ChannelInputAttachmentArgs']]]]):
        pulumi.set(self, "input_attachments", value)

    @property
    @pulumi.getter(name="inputSpecification")
    def input_specification(self) -> Optional[pulumi.Input['ChannelInputSpecificationArgs']]:
        return pulumi.get(self, "input_specification")

    @input_specification.setter
    def input_specification(self, value: Optional[pulumi.Input['ChannelInputSpecificationArgs']]):
        pulumi.set(self, "input_specification", value)

    @property
    @pulumi.getter(name="logLevel")
    def log_level(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "log_level")

    @log_level.setter
    def log_level(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "log_level", value)

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
    def tags(self) -> Optional[Any]:
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[Any]):
        pulumi.set(self, "tags", value)

    @property
    @pulumi.getter
    def vpc(self) -> Optional[pulumi.Input['ChannelVpcOutputSettingsArgs']]:
        return pulumi.get(self, "vpc")

    @vpc.setter
    def vpc(self, value: Optional[pulumi.Input['ChannelVpcOutputSettingsArgs']]):
        pulumi.set(self, "vpc", value)


warnings.warn("""Channel is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)


class Channel(pulumi.CustomResource):
    warnings.warn("""Channel is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cdi_input_specification: Optional[pulumi.Input[pulumi.InputType['ChannelCdiInputSpecificationArgs']]] = None,
                 channel_class: Optional[pulumi.Input[str]] = None,
                 destinations: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ChannelOutputDestinationArgs']]]]] = None,
                 encoder_settings: Optional[pulumi.Input[pulumi.InputType['ChannelEncoderSettingsArgs']]] = None,
                 input_attachments: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ChannelInputAttachmentArgs']]]]] = None,
                 input_specification: Optional[pulumi.Input[pulumi.InputType['ChannelInputSpecificationArgs']]] = None,
                 log_level: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 role_arn: Optional[pulumi.Input[str]] = None,
                 tags: Optional[Any] = None,
                 vpc: Optional[pulumi.Input[pulumi.InputType['ChannelVpcOutputSettingsArgs']]] = None,
                 __props__=None):
        """
        Resource Type definition for AWS::MediaLive::Channel

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[ChannelArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource Type definition for AWS::MediaLive::Channel

        :param str resource_name: The name of the resource.
        :param ChannelArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ChannelArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cdi_input_specification: Optional[pulumi.Input[pulumi.InputType['ChannelCdiInputSpecificationArgs']]] = None,
                 channel_class: Optional[pulumi.Input[str]] = None,
                 destinations: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ChannelOutputDestinationArgs']]]]] = None,
                 encoder_settings: Optional[pulumi.Input[pulumi.InputType['ChannelEncoderSettingsArgs']]] = None,
                 input_attachments: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ChannelInputAttachmentArgs']]]]] = None,
                 input_specification: Optional[pulumi.Input[pulumi.InputType['ChannelInputSpecificationArgs']]] = None,
                 log_level: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 role_arn: Optional[pulumi.Input[str]] = None,
                 tags: Optional[Any] = None,
                 vpc: Optional[pulumi.Input[pulumi.InputType['ChannelVpcOutputSettingsArgs']]] = None,
                 __props__=None):
        pulumi.log.warn("""Channel is deprecated: Channel is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ChannelArgs.__new__(ChannelArgs)

            __props__.__dict__["cdi_input_specification"] = cdi_input_specification
            __props__.__dict__["channel_class"] = channel_class
            __props__.__dict__["destinations"] = destinations
            __props__.__dict__["encoder_settings"] = encoder_settings
            __props__.__dict__["input_attachments"] = input_attachments
            __props__.__dict__["input_specification"] = input_specification
            __props__.__dict__["log_level"] = log_level
            __props__.__dict__["name"] = name
            __props__.__dict__["role_arn"] = role_arn
            __props__.__dict__["tags"] = tags
            __props__.__dict__["vpc"] = vpc
            __props__.__dict__["arn"] = None
            __props__.__dict__["inputs"] = None
        super(Channel, __self__).__init__(
            'aws-native:medialive:Channel',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Channel':
        """
        Get an existing Channel resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = ChannelArgs.__new__(ChannelArgs)

        __props__.__dict__["arn"] = None
        __props__.__dict__["cdi_input_specification"] = None
        __props__.__dict__["channel_class"] = None
        __props__.__dict__["destinations"] = None
        __props__.__dict__["encoder_settings"] = None
        __props__.__dict__["input_attachments"] = None
        __props__.__dict__["input_specification"] = None
        __props__.__dict__["inputs"] = None
        __props__.__dict__["log_level"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["role_arn"] = None
        __props__.__dict__["tags"] = None
        __props__.__dict__["vpc"] = None
        return Channel(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def arn(self) -> pulumi.Output[str]:
        return pulumi.get(self, "arn")

    @property
    @pulumi.getter(name="cdiInputSpecification")
    def cdi_input_specification(self) -> pulumi.Output[Optional['outputs.ChannelCdiInputSpecification']]:
        return pulumi.get(self, "cdi_input_specification")

    @property
    @pulumi.getter(name="channelClass")
    def channel_class(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "channel_class")

    @property
    @pulumi.getter
    def destinations(self) -> pulumi.Output[Optional[Sequence['outputs.ChannelOutputDestination']]]:
        return pulumi.get(self, "destinations")

    @property
    @pulumi.getter(name="encoderSettings")
    def encoder_settings(self) -> pulumi.Output[Optional['outputs.ChannelEncoderSettings']]:
        return pulumi.get(self, "encoder_settings")

    @property
    @pulumi.getter(name="inputAttachments")
    def input_attachments(self) -> pulumi.Output[Optional[Sequence['outputs.ChannelInputAttachment']]]:
        return pulumi.get(self, "input_attachments")

    @property
    @pulumi.getter(name="inputSpecification")
    def input_specification(self) -> pulumi.Output[Optional['outputs.ChannelInputSpecification']]:
        return pulumi.get(self, "input_specification")

    @property
    @pulumi.getter
    def inputs(self) -> pulumi.Output[Sequence[str]]:
        return pulumi.get(self, "inputs")

    @property
    @pulumi.getter(name="logLevel")
    def log_level(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "log_level")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="roleArn")
    def role_arn(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "role_arn")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Any]]:
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def vpc(self) -> pulumi.Output[Optional['outputs.ChannelVpcOutputSettings']]:
        return pulumi.get(self, "vpc")

