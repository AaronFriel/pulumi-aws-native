# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['HostedConfigurationVersionArgs', 'HostedConfigurationVersion']

@pulumi.input_type
class HostedConfigurationVersionArgs:
    def __init__(__self__, *,
                 application_id: pulumi.Input[str],
                 configuration_profile_id: pulumi.Input[str],
                 content: pulumi.Input[str],
                 content_type: pulumi.Input[str],
                 description: Optional[pulumi.Input[str]] = None,
                 latest_version_number: Optional[pulumi.Input[float]] = None):
        """
        The set of arguments for constructing a HostedConfigurationVersion resource.
        """
        pulumi.set(__self__, "application_id", application_id)
        pulumi.set(__self__, "configuration_profile_id", configuration_profile_id)
        pulumi.set(__self__, "content", content)
        pulumi.set(__self__, "content_type", content_type)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if latest_version_number is not None:
            pulumi.set(__self__, "latest_version_number", latest_version_number)

    @property
    @pulumi.getter(name="applicationId")
    def application_id(self) -> pulumi.Input[str]:
        return pulumi.get(self, "application_id")

    @application_id.setter
    def application_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "application_id", value)

    @property
    @pulumi.getter(name="configurationProfileId")
    def configuration_profile_id(self) -> pulumi.Input[str]:
        return pulumi.get(self, "configuration_profile_id")

    @configuration_profile_id.setter
    def configuration_profile_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "configuration_profile_id", value)

    @property
    @pulumi.getter
    def content(self) -> pulumi.Input[str]:
        return pulumi.get(self, "content")

    @content.setter
    def content(self, value: pulumi.Input[str]):
        pulumi.set(self, "content", value)

    @property
    @pulumi.getter(name="contentType")
    def content_type(self) -> pulumi.Input[str]:
        return pulumi.get(self, "content_type")

    @content_type.setter
    def content_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "content_type", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="latestVersionNumber")
    def latest_version_number(self) -> Optional[pulumi.Input[float]]:
        return pulumi.get(self, "latest_version_number")

    @latest_version_number.setter
    def latest_version_number(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "latest_version_number", value)


warnings.warn("""HostedConfigurationVersion is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)


class HostedConfigurationVersion(pulumi.CustomResource):
    warnings.warn("""HostedConfigurationVersion is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 application_id: Optional[pulumi.Input[str]] = None,
                 configuration_profile_id: Optional[pulumi.Input[str]] = None,
                 content: Optional[pulumi.Input[str]] = None,
                 content_type: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 latest_version_number: Optional[pulumi.Input[float]] = None,
                 __props__=None):
        """
        Resource Type definition for AWS::AppConfig::HostedConfigurationVersion

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: HostedConfigurationVersionArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource Type definition for AWS::AppConfig::HostedConfigurationVersion

        :param str resource_name: The name of the resource.
        :param HostedConfigurationVersionArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(HostedConfigurationVersionArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 application_id: Optional[pulumi.Input[str]] = None,
                 configuration_profile_id: Optional[pulumi.Input[str]] = None,
                 content: Optional[pulumi.Input[str]] = None,
                 content_type: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 latest_version_number: Optional[pulumi.Input[float]] = None,
                 __props__=None):
        pulumi.log.warn("""HostedConfigurationVersion is deprecated: HostedConfigurationVersion is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = HostedConfigurationVersionArgs.__new__(HostedConfigurationVersionArgs)

            if application_id is None and not opts.urn:
                raise TypeError("Missing required property 'application_id'")
            __props__.__dict__["application_id"] = application_id
            if configuration_profile_id is None and not opts.urn:
                raise TypeError("Missing required property 'configuration_profile_id'")
            __props__.__dict__["configuration_profile_id"] = configuration_profile_id
            if content is None and not opts.urn:
                raise TypeError("Missing required property 'content'")
            __props__.__dict__["content"] = content
            if content_type is None and not opts.urn:
                raise TypeError("Missing required property 'content_type'")
            __props__.__dict__["content_type"] = content_type
            __props__.__dict__["description"] = description
            __props__.__dict__["latest_version_number"] = latest_version_number
        super(HostedConfigurationVersion, __self__).__init__(
            'aws-native:appconfig:HostedConfigurationVersion',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'HostedConfigurationVersion':
        """
        Get an existing HostedConfigurationVersion resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = HostedConfigurationVersionArgs.__new__(HostedConfigurationVersionArgs)

        __props__.__dict__["application_id"] = None
        __props__.__dict__["configuration_profile_id"] = None
        __props__.__dict__["content"] = None
        __props__.__dict__["content_type"] = None
        __props__.__dict__["description"] = None
        __props__.__dict__["latest_version_number"] = None
        return HostedConfigurationVersion(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="applicationId")
    def application_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "application_id")

    @property
    @pulumi.getter(name="configurationProfileId")
    def configuration_profile_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "configuration_profile_id")

    @property
    @pulumi.getter
    def content(self) -> pulumi.Output[str]:
        return pulumi.get(self, "content")

    @property
    @pulumi.getter(name="contentType")
    def content_type(self) -> pulumi.Output[str]:
        return pulumi.get(self, "content_type")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="latestVersionNumber")
    def latest_version_number(self) -> pulumi.Output[Optional[float]]:
        return pulumi.get(self, "latest_version_number")

