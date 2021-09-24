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

__all__ = ['MicrosoftADArgs', 'MicrosoftAD']

@pulumi.input_type
class MicrosoftADArgs:
    def __init__(__self__, *,
                 name: pulumi.Input[str],
                 password: pulumi.Input[str],
                 vpc_settings: pulumi.Input['MicrosoftADVpcSettingsArgs'],
                 create_alias: Optional[pulumi.Input[bool]] = None,
                 edition: Optional[pulumi.Input[str]] = None,
                 enable_sso: Optional[pulumi.Input[bool]] = None,
                 short_name: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a MicrosoftAD resource.
        """
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "password", password)
        pulumi.set(__self__, "vpc_settings", vpc_settings)
        if create_alias is not None:
            pulumi.set(__self__, "create_alias", create_alias)
        if edition is not None:
            pulumi.set(__self__, "edition", edition)
        if enable_sso is not None:
            pulumi.set(__self__, "enable_sso", enable_sso)
        if short_name is not None:
            pulumi.set(__self__, "short_name", short_name)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: pulumi.Input[str]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def password(self) -> pulumi.Input[str]:
        return pulumi.get(self, "password")

    @password.setter
    def password(self, value: pulumi.Input[str]):
        pulumi.set(self, "password", value)

    @property
    @pulumi.getter(name="vpcSettings")
    def vpc_settings(self) -> pulumi.Input['MicrosoftADVpcSettingsArgs']:
        return pulumi.get(self, "vpc_settings")

    @vpc_settings.setter
    def vpc_settings(self, value: pulumi.Input['MicrosoftADVpcSettingsArgs']):
        pulumi.set(self, "vpc_settings", value)

    @property
    @pulumi.getter(name="createAlias")
    def create_alias(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "create_alias")

    @create_alias.setter
    def create_alias(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "create_alias", value)

    @property
    @pulumi.getter
    def edition(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "edition")

    @edition.setter
    def edition(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "edition", value)

    @property
    @pulumi.getter(name="enableSso")
    def enable_sso(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "enable_sso")

    @enable_sso.setter
    def enable_sso(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enable_sso", value)

    @property
    @pulumi.getter(name="shortName")
    def short_name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "short_name")

    @short_name.setter
    def short_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "short_name", value)


warnings.warn("""MicrosoftAD is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)


class MicrosoftAD(pulumi.CustomResource):
    warnings.warn("""MicrosoftAD is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 create_alias: Optional[pulumi.Input[bool]] = None,
                 edition: Optional[pulumi.Input[str]] = None,
                 enable_sso: Optional[pulumi.Input[bool]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 password: Optional[pulumi.Input[str]] = None,
                 short_name: Optional[pulumi.Input[str]] = None,
                 vpc_settings: Optional[pulumi.Input[pulumi.InputType['MicrosoftADVpcSettingsArgs']]] = None,
                 __props__=None):
        """
        Resource Type definition for AWS::DirectoryService::MicrosoftAD

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: MicrosoftADArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource Type definition for AWS::DirectoryService::MicrosoftAD

        :param str resource_name: The name of the resource.
        :param MicrosoftADArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(MicrosoftADArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 create_alias: Optional[pulumi.Input[bool]] = None,
                 edition: Optional[pulumi.Input[str]] = None,
                 enable_sso: Optional[pulumi.Input[bool]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 password: Optional[pulumi.Input[str]] = None,
                 short_name: Optional[pulumi.Input[str]] = None,
                 vpc_settings: Optional[pulumi.Input[pulumi.InputType['MicrosoftADVpcSettingsArgs']]] = None,
                 __props__=None):
        pulumi.log.warn("""MicrosoftAD is deprecated: MicrosoftAD is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = MicrosoftADArgs.__new__(MicrosoftADArgs)

            __props__.__dict__["create_alias"] = create_alias
            __props__.__dict__["edition"] = edition
            __props__.__dict__["enable_sso"] = enable_sso
            if name is None and not opts.urn:
                raise TypeError("Missing required property 'name'")
            __props__.__dict__["name"] = name
            if password is None and not opts.urn:
                raise TypeError("Missing required property 'password'")
            __props__.__dict__["password"] = password
            __props__.__dict__["short_name"] = short_name
            if vpc_settings is None and not opts.urn:
                raise TypeError("Missing required property 'vpc_settings'")
            __props__.__dict__["vpc_settings"] = vpc_settings
            __props__.__dict__["alias"] = None
            __props__.__dict__["dns_ip_addresses"] = None
        super(MicrosoftAD, __self__).__init__(
            'aws-native:directoryservice:MicrosoftAD',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'MicrosoftAD':
        """
        Get an existing MicrosoftAD resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = MicrosoftADArgs.__new__(MicrosoftADArgs)

        __props__.__dict__["alias"] = None
        __props__.__dict__["create_alias"] = None
        __props__.__dict__["dns_ip_addresses"] = None
        __props__.__dict__["edition"] = None
        __props__.__dict__["enable_sso"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["password"] = None
        __props__.__dict__["short_name"] = None
        __props__.__dict__["vpc_settings"] = None
        return MicrosoftAD(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def alias(self) -> pulumi.Output[str]:
        return pulumi.get(self, "alias")

    @property
    @pulumi.getter(name="createAlias")
    def create_alias(self) -> pulumi.Output[Optional[bool]]:
        return pulumi.get(self, "create_alias")

    @property
    @pulumi.getter(name="dnsIpAddresses")
    def dns_ip_addresses(self) -> pulumi.Output[Sequence[str]]:
        return pulumi.get(self, "dns_ip_addresses")

    @property
    @pulumi.getter
    def edition(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "edition")

    @property
    @pulumi.getter(name="enableSso")
    def enable_sso(self) -> pulumi.Output[Optional[bool]]:
        return pulumi.get(self, "enable_sso")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def password(self) -> pulumi.Output[str]:
        return pulumi.get(self, "password")

    @property
    @pulumi.getter(name="shortName")
    def short_name(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "short_name")

    @property
    @pulumi.getter(name="vpcSettings")
    def vpc_settings(self) -> pulumi.Output['outputs.MicrosoftADVpcSettings']:
        return pulumi.get(self, "vpc_settings")

