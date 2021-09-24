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

__all__ = ['IdentityArgs', 'Identity']

@pulumi.input_type
class IdentityArgs:
    def __init__(__self__, *,
                 name: pulumi.Input[str],
                 dkim_signing_enabled: Optional[pulumi.Input[bool]] = None,
                 feedback_forwarding_enabled: Optional[pulumi.Input[bool]] = None,
                 mail_from_attributes: Optional[pulumi.Input['IdentityMailFromAttributesArgs']] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input['IdentityTagsArgs']]]] = None):
        """
        The set of arguments for constructing a Identity resource.
        """
        pulumi.set(__self__, "name", name)
        if dkim_signing_enabled is not None:
            pulumi.set(__self__, "dkim_signing_enabled", dkim_signing_enabled)
        if feedback_forwarding_enabled is not None:
            pulumi.set(__self__, "feedback_forwarding_enabled", feedback_forwarding_enabled)
        if mail_from_attributes is not None:
            pulumi.set(__self__, "mail_from_attributes", mail_from_attributes)
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
    @pulumi.getter(name="dkimSigningEnabled")
    def dkim_signing_enabled(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "dkim_signing_enabled")

    @dkim_signing_enabled.setter
    def dkim_signing_enabled(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "dkim_signing_enabled", value)

    @property
    @pulumi.getter(name="feedbackForwardingEnabled")
    def feedback_forwarding_enabled(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "feedback_forwarding_enabled")

    @feedback_forwarding_enabled.setter
    def feedback_forwarding_enabled(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "feedback_forwarding_enabled", value)

    @property
    @pulumi.getter(name="mailFromAttributes")
    def mail_from_attributes(self) -> Optional[pulumi.Input['IdentityMailFromAttributesArgs']]:
        return pulumi.get(self, "mail_from_attributes")

    @mail_from_attributes.setter
    def mail_from_attributes(self, value: Optional[pulumi.Input['IdentityMailFromAttributesArgs']]):
        pulumi.set(self, "mail_from_attributes", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['IdentityTagsArgs']]]]:
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['IdentityTagsArgs']]]]):
        pulumi.set(self, "tags", value)


warnings.warn("""Identity is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)


class Identity(pulumi.CustomResource):
    warnings.warn("""Identity is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 dkim_signing_enabled: Optional[pulumi.Input[bool]] = None,
                 feedback_forwarding_enabled: Optional[pulumi.Input[bool]] = None,
                 mail_from_attributes: Optional[pulumi.Input[pulumi.InputType['IdentityMailFromAttributesArgs']]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['IdentityTagsArgs']]]]] = None,
                 __props__=None):
        """
        Resource Type definition for AWS::PinpointEmail::Identity

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: IdentityArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource Type definition for AWS::PinpointEmail::Identity

        :param str resource_name: The name of the resource.
        :param IdentityArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(IdentityArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 dkim_signing_enabled: Optional[pulumi.Input[bool]] = None,
                 feedback_forwarding_enabled: Optional[pulumi.Input[bool]] = None,
                 mail_from_attributes: Optional[pulumi.Input[pulumi.InputType['IdentityMailFromAttributesArgs']]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['IdentityTagsArgs']]]]] = None,
                 __props__=None):
        pulumi.log.warn("""Identity is deprecated: Identity is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = IdentityArgs.__new__(IdentityArgs)

            __props__.__dict__["dkim_signing_enabled"] = dkim_signing_enabled
            __props__.__dict__["feedback_forwarding_enabled"] = feedback_forwarding_enabled
            __props__.__dict__["mail_from_attributes"] = mail_from_attributes
            if name is None and not opts.urn:
                raise TypeError("Missing required property 'name'")
            __props__.__dict__["name"] = name
            __props__.__dict__["tags"] = tags
            __props__.__dict__["identity_dns_record_name1"] = None
            __props__.__dict__["identity_dns_record_name2"] = None
            __props__.__dict__["identity_dns_record_name3"] = None
            __props__.__dict__["identity_dns_record_value1"] = None
            __props__.__dict__["identity_dns_record_value2"] = None
            __props__.__dict__["identity_dns_record_value3"] = None
        super(Identity, __self__).__init__(
            'aws-native:pinpointemail:Identity',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Identity':
        """
        Get an existing Identity resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = IdentityArgs.__new__(IdentityArgs)

        __props__.__dict__["dkim_signing_enabled"] = None
        __props__.__dict__["feedback_forwarding_enabled"] = None
        __props__.__dict__["identity_dns_record_name1"] = None
        __props__.__dict__["identity_dns_record_name2"] = None
        __props__.__dict__["identity_dns_record_name3"] = None
        __props__.__dict__["identity_dns_record_value1"] = None
        __props__.__dict__["identity_dns_record_value2"] = None
        __props__.__dict__["identity_dns_record_value3"] = None
        __props__.__dict__["mail_from_attributes"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["tags"] = None
        return Identity(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="dkimSigningEnabled")
    def dkim_signing_enabled(self) -> pulumi.Output[Optional[bool]]:
        return pulumi.get(self, "dkim_signing_enabled")

    @property
    @pulumi.getter(name="feedbackForwardingEnabled")
    def feedback_forwarding_enabled(self) -> pulumi.Output[Optional[bool]]:
        return pulumi.get(self, "feedback_forwarding_enabled")

    @property
    @pulumi.getter(name="identityDNSRecordName1")
    def identity_dns_record_name1(self) -> pulumi.Output[str]:
        return pulumi.get(self, "identity_dns_record_name1")

    @property
    @pulumi.getter(name="identityDNSRecordName2")
    def identity_dns_record_name2(self) -> pulumi.Output[str]:
        return pulumi.get(self, "identity_dns_record_name2")

    @property
    @pulumi.getter(name="identityDNSRecordName3")
    def identity_dns_record_name3(self) -> pulumi.Output[str]:
        return pulumi.get(self, "identity_dns_record_name3")

    @property
    @pulumi.getter(name="identityDNSRecordValue1")
    def identity_dns_record_value1(self) -> pulumi.Output[str]:
        return pulumi.get(self, "identity_dns_record_value1")

    @property
    @pulumi.getter(name="identityDNSRecordValue2")
    def identity_dns_record_value2(self) -> pulumi.Output[str]:
        return pulumi.get(self, "identity_dns_record_value2")

    @property
    @pulumi.getter(name="identityDNSRecordValue3")
    def identity_dns_record_value3(self) -> pulumi.Output[str]:
        return pulumi.get(self, "identity_dns_record_value3")

    @property
    @pulumi.getter(name="mailFromAttributes")
    def mail_from_attributes(self) -> pulumi.Output[Optional['outputs.IdentityMailFromAttributes']]:
        return pulumi.get(self, "mail_from_attributes")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence['outputs.IdentityTags']]]:
        return pulumi.get(self, "tags")

