# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['VolumeAttachmentArgs', 'VolumeAttachment']

@pulumi.input_type
class VolumeAttachmentArgs:
    def __init__(__self__, *,
                 device: pulumi.Input[str],
                 instance_id: pulumi.Input[str],
                 volume_id: pulumi.Input[str]):
        """
        The set of arguments for constructing a VolumeAttachment resource.
        """
        pulumi.set(__self__, "device", device)
        pulumi.set(__self__, "instance_id", instance_id)
        pulumi.set(__self__, "volume_id", volume_id)

    @property
    @pulumi.getter
    def device(self) -> pulumi.Input[str]:
        return pulumi.get(self, "device")

    @device.setter
    def device(self, value: pulumi.Input[str]):
        pulumi.set(self, "device", value)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Input[str]:
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "instance_id", value)

    @property
    @pulumi.getter(name="volumeId")
    def volume_id(self) -> pulumi.Input[str]:
        return pulumi.get(self, "volume_id")

    @volume_id.setter
    def volume_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "volume_id", value)


warnings.warn("""VolumeAttachment is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)


class VolumeAttachment(pulumi.CustomResource):
    warnings.warn("""VolumeAttachment is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 device: Optional[pulumi.Input[str]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 volume_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Resource Type definition for AWS::EC2::VolumeAttachment

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: VolumeAttachmentArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource Type definition for AWS::EC2::VolumeAttachment

        :param str resource_name: The name of the resource.
        :param VolumeAttachmentArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(VolumeAttachmentArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 device: Optional[pulumi.Input[str]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 volume_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        pulumi.log.warn("""VolumeAttachment is deprecated: VolumeAttachment is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = VolumeAttachmentArgs.__new__(VolumeAttachmentArgs)

            if device is None and not opts.urn:
                raise TypeError("Missing required property 'device'")
            __props__.__dict__["device"] = device
            if instance_id is None and not opts.urn:
                raise TypeError("Missing required property 'instance_id'")
            __props__.__dict__["instance_id"] = instance_id
            if volume_id is None and not opts.urn:
                raise TypeError("Missing required property 'volume_id'")
            __props__.__dict__["volume_id"] = volume_id
        super(VolumeAttachment, __self__).__init__(
            'aws-native:ec2:VolumeAttachment',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'VolumeAttachment':
        """
        Get an existing VolumeAttachment resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = VolumeAttachmentArgs.__new__(VolumeAttachmentArgs)

        __props__.__dict__["device"] = None
        __props__.__dict__["instance_id"] = None
        __props__.__dict__["volume_id"] = None
        return VolumeAttachment(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def device(self) -> pulumi.Output[str]:
        return pulumi.get(self, "device")

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "instance_id")

    @property
    @pulumi.getter(name="volumeId")
    def volume_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "volume_id")

