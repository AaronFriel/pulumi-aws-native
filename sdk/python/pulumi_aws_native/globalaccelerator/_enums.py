# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from enum import Enum

__all__ = [
    'AcceleratorIpAddressType',
    'EndpointGroupHealthCheckProtocol',
    'ListenerClientAffinity',
    'ListenerProtocol',
]


class AcceleratorIpAddressType(str, Enum):
    """
    IP Address type.
    """
    IPV4 = "IPV4"
    IPV6 = "IPV6"


class EndpointGroupHealthCheckProtocol(str, Enum):
    """
    The protocol that AWS Global Accelerator uses to check the health of endpoints in this endpoint group.
    """
    TCP = "TCP"
    HTTP = "HTTP"
    HTTPS = "HTTPS"


class ListenerClientAffinity(str, Enum):
    """
    Client affinity lets you direct all requests from a user to the same endpoint.
    """
    NONE = "NONE"
    SOURCE_IP = "SOURCE_IP"


class ListenerProtocol(str, Enum):
    """
    The protocol for the listener.
    """
    TCP = "TCP"
    UDP = "UDP"
