# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from enum import Enum

__all__ = [
    'ChannelLatencyMode',
    'ChannelType',
    'RecordingConfigurationState',
]


class ChannelLatencyMode(str, Enum):
    """
    Channel latency mode.
    """
    NORMAL = "NORMAL"
    LOW = "LOW"


class ChannelType(str, Enum):
    """
    Channel type, which determines the allowable resolution and bitrate. If you exceed the allowable resolution or bitrate, the stream probably will disconnect immediately.
    """
    STANDARD = "STANDARD"
    BASIC = "BASIC"


class RecordingConfigurationState(str, Enum):
    """
    Recording Configuration State.
    """
    CREATING = "CREATING"
    CREATE_FAILED = "CREATE_FAILED"
    ACTIVE = "ACTIVE"
