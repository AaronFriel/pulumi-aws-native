# coding=utf-8
# *** WARNING: this file was generated by pulumigen. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = [
    'FirewallDomainListTag',
    'FirewallRuleGroupAssociationTag',
    'FirewallRuleGroupFirewallRule',
    'FirewallRuleGroupTag',
]

@pulumi.output_type
class FirewallDomainListTag(dict):
    """
    A key-value pair to associate with a resource.
    """
    def __init__(__self__, *,
                 key: str,
                 value: str):
        """
        A key-value pair to associate with a resource.
        :param str key: The key name of the tag. You can specify a value that is 1 to 127 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
        :param str value: The value for the tag. You can specify a value that is 1 to 255 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
        """
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> str:
        """
        The key name of the tag. You can specify a value that is 1 to 127 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
        """
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def value(self) -> str:
        """
        The value for the tag. You can specify a value that is 1 to 255 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
        """
        return pulumi.get(self, "value")


@pulumi.output_type
class FirewallRuleGroupAssociationTag(dict):
    """
    A key-value pair to associate with a resource.
    """
    def __init__(__self__, *,
                 key: str,
                 value: str):
        """
        A key-value pair to associate with a resource.
        :param str key: The key name of the tag. You can specify a value that is 1 to 127 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
        :param str value: The value for the tag. You can specify a value that is 1 to 255 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
        """
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> str:
        """
        The key name of the tag. You can specify a value that is 1 to 127 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
        """
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def value(self) -> str:
        """
        The value for the tag. You can specify a value that is 1 to 255 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
        """
        return pulumi.get(self, "value")


@pulumi.output_type
class FirewallRuleGroupFirewallRule(dict):
    """
    Firewall Rule associating the Rule Group to a Domain List
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "firewallDomainListId":
            suggest = "firewall_domain_list_id"
        elif key == "blockOverrideDnsType":
            suggest = "block_override_dns_type"
        elif key == "blockOverrideDomain":
            suggest = "block_override_domain"
        elif key == "blockOverrideTtl":
            suggest = "block_override_ttl"
        elif key == "blockResponse":
            suggest = "block_response"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in FirewallRuleGroupFirewallRule. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        FirewallRuleGroupFirewallRule.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        FirewallRuleGroupFirewallRule.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 action: str,
                 firewall_domain_list_id: str,
                 priority: int,
                 block_override_dns_type: Optional[str] = None,
                 block_override_domain: Optional[str] = None,
                 block_override_ttl: Optional[int] = None,
                 block_response: Optional[str] = None):
        """
        Firewall Rule associating the Rule Group to a Domain List
        :param str action: Rule Action
        :param str firewall_domain_list_id: ResourceId
        :param int priority: Rule Priority
        :param str block_override_dns_type: BlockOverrideDnsType
        :param str block_override_domain: BlockOverrideDomain
        :param int block_override_ttl: BlockOverrideTtl
        :param str block_response: BlockResponse
        """
        pulumi.set(__self__, "action", action)
        pulumi.set(__self__, "firewall_domain_list_id", firewall_domain_list_id)
        pulumi.set(__self__, "priority", priority)
        if block_override_dns_type is not None:
            pulumi.set(__self__, "block_override_dns_type", block_override_dns_type)
        if block_override_domain is not None:
            pulumi.set(__self__, "block_override_domain", block_override_domain)
        if block_override_ttl is not None:
            pulumi.set(__self__, "block_override_ttl", block_override_ttl)
        if block_response is not None:
            pulumi.set(__self__, "block_response", block_response)

    @property
    @pulumi.getter
    def action(self) -> str:
        """
        Rule Action
        """
        return pulumi.get(self, "action")

    @property
    @pulumi.getter(name="firewallDomainListId")
    def firewall_domain_list_id(self) -> str:
        """
        ResourceId
        """
        return pulumi.get(self, "firewall_domain_list_id")

    @property
    @pulumi.getter
    def priority(self) -> int:
        """
        Rule Priority
        """
        return pulumi.get(self, "priority")

    @property
    @pulumi.getter(name="blockOverrideDnsType")
    def block_override_dns_type(self) -> Optional[str]:
        """
        BlockOverrideDnsType
        """
        return pulumi.get(self, "block_override_dns_type")

    @property
    @pulumi.getter(name="blockOverrideDomain")
    def block_override_domain(self) -> Optional[str]:
        """
        BlockOverrideDomain
        """
        return pulumi.get(self, "block_override_domain")

    @property
    @pulumi.getter(name="blockOverrideTtl")
    def block_override_ttl(self) -> Optional[int]:
        """
        BlockOverrideTtl
        """
        return pulumi.get(self, "block_override_ttl")

    @property
    @pulumi.getter(name="blockResponse")
    def block_response(self) -> Optional[str]:
        """
        BlockResponse
        """
        return pulumi.get(self, "block_response")


@pulumi.output_type
class FirewallRuleGroupTag(dict):
    """
    A key-value pair to associate with a resource.
    """
    def __init__(__self__, *,
                 key: str,
                 value: str):
        """
        A key-value pair to associate with a resource.
        :param str key: The key name of the tag. You can specify a value that is 1 to 127 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
        :param str value: The value for the tag. You can specify a value that is 1 to 255 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
        """
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> str:
        """
        The key name of the tag. You can specify a value that is 1 to 127 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
        """
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def value(self) -> str:
        """
        The value for the tag. You can specify a value that is 1 to 255 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
        """
        return pulumi.get(self, "value")


