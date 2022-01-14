# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = [
    'DeviceLocation',
    'DeviceTag',
    'GlobalNetworkTag',
    'LinkBandwidth',
    'LinkTag',
    'SiteLocation',
    'SiteTag',
]

@pulumi.output_type
class DeviceLocation(dict):
    """
    The site location.
    """
    def __init__(__self__, *,
                 address: Optional[str] = None,
                 latitude: Optional[str] = None,
                 longitude: Optional[str] = None):
        """
        The site location.
        :param str address: The physical address.
        :param str latitude: The latitude.
        :param str longitude: The longitude.
        """
        if address is not None:
            pulumi.set(__self__, "address", address)
        if latitude is not None:
            pulumi.set(__self__, "latitude", latitude)
        if longitude is not None:
            pulumi.set(__self__, "longitude", longitude)

    @property
    @pulumi.getter
    def address(self) -> Optional[str]:
        """
        The physical address.
        """
        return pulumi.get(self, "address")

    @property
    @pulumi.getter
    def latitude(self) -> Optional[str]:
        """
        The latitude.
        """
        return pulumi.get(self, "latitude")

    @property
    @pulumi.getter
    def longitude(self) -> Optional[str]:
        """
        The longitude.
        """
        return pulumi.get(self, "longitude")


@pulumi.output_type
class DeviceTag(dict):
    """
    A key-value pair to associate with a device resource.
    """
    def __init__(__self__, *,
                 key: Optional[str] = None,
                 value: Optional[str] = None):
        """
        A key-value pair to associate with a device resource.
        """
        if key is not None:
            pulumi.set(__self__, "key", key)
        if value is not None:
            pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> Optional[str]:
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def value(self) -> Optional[str]:
        return pulumi.get(self, "value")


@pulumi.output_type
class GlobalNetworkTag(dict):
    """
    A key-value pair to associate with a global network resource.
    """
    def __init__(__self__, *,
                 key: Optional[str] = None,
                 value: Optional[str] = None):
        """
        A key-value pair to associate with a global network resource.
        """
        if key is not None:
            pulumi.set(__self__, "key", key)
        if value is not None:
            pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> Optional[str]:
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def value(self) -> Optional[str]:
        return pulumi.get(self, "value")


@pulumi.output_type
class LinkBandwidth(dict):
    """
    The bandwidth for the link.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "downloadSpeed":
            suggest = "download_speed"
        elif key == "uploadSpeed":
            suggest = "upload_speed"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in LinkBandwidth. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        LinkBandwidth.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        LinkBandwidth.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 download_speed: Optional[int] = None,
                 upload_speed: Optional[int] = None):
        """
        The bandwidth for the link.
        :param int download_speed: Download speed in Mbps.
        :param int upload_speed: Upload speed in Mbps.
        """
        if download_speed is not None:
            pulumi.set(__self__, "download_speed", download_speed)
        if upload_speed is not None:
            pulumi.set(__self__, "upload_speed", upload_speed)

    @property
    @pulumi.getter(name="downloadSpeed")
    def download_speed(self) -> Optional[int]:
        """
        Download speed in Mbps.
        """
        return pulumi.get(self, "download_speed")

    @property
    @pulumi.getter(name="uploadSpeed")
    def upload_speed(self) -> Optional[int]:
        """
        Upload speed in Mbps.
        """
        return pulumi.get(self, "upload_speed")


@pulumi.output_type
class LinkTag(dict):
    """
    A key-value pair to associate with a link resource.
    """
    def __init__(__self__, *,
                 key: Optional[str] = None,
                 value: Optional[str] = None):
        """
        A key-value pair to associate with a link resource.
        """
        if key is not None:
            pulumi.set(__self__, "key", key)
        if value is not None:
            pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> Optional[str]:
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def value(self) -> Optional[str]:
        return pulumi.get(self, "value")


@pulumi.output_type
class SiteLocation(dict):
    """
    The location of the site
    """
    def __init__(__self__, *,
                 address: Optional[str] = None,
                 latitude: Optional[str] = None,
                 longitude: Optional[str] = None):
        """
        The location of the site
        :param str address: The physical address.
        :param str latitude: The latitude.
        :param str longitude: The longitude.
        """
        if address is not None:
            pulumi.set(__self__, "address", address)
        if latitude is not None:
            pulumi.set(__self__, "latitude", latitude)
        if longitude is not None:
            pulumi.set(__self__, "longitude", longitude)

    @property
    @pulumi.getter
    def address(self) -> Optional[str]:
        """
        The physical address.
        """
        return pulumi.get(self, "address")

    @property
    @pulumi.getter
    def latitude(self) -> Optional[str]:
        """
        The latitude.
        """
        return pulumi.get(self, "latitude")

    @property
    @pulumi.getter
    def longitude(self) -> Optional[str]:
        """
        The longitude.
        """
        return pulumi.get(self, "longitude")


@pulumi.output_type
class SiteTag(dict):
    """
    A key-value pair to associate with a site resource.
    """
    def __init__(__self__, *,
                 key: Optional[str] = None,
                 value: Optional[str] = None):
        """
        A key-value pair to associate with a site resource.
        """
        if key is not None:
            pulumi.set(__self__, "key", key)
        if value is not None:
            pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> Optional[str]:
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def value(self) -> Optional[str]:
        return pulumi.get(self, "value")


