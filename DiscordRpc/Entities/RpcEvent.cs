using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DiscordRpc.Entities
{
    public enum RpcEvent
    {
		[Description("READY")]
		Ready,

		[Description("ERROR")]
		Error,

		[Description("GUILD_STATUS")]
		GuildStatus,

		[Description("GUILD_CREATE")]
		GuildCreate,

		[Description("CHANNEL_CREATE")]
		ChannelCreate,

		[Description("VOICE_CHANNEL_SELECT")]
		VoiceChannelSelect,

		[Description("VOICE_STATE_CREATE")]
		VoiceStateCreate,

		[Description("VOICE_STATE_UPDATE")]
		VoiceStateUpdate,

		[Description("VOICE_STATE_DELETE")]
		VoiceStateDelete,

		[Description("VOICE_SETTINGS_UPDATE")]
		VoiceSettingsUpdate,

		[Description("VOICE_CONNECTION_STATUS")]
		VoiceConnectionStatus,

		[Description("SPEAKING_START")]
		SpeakingStart,

		[Description("SPEAKING_STOP")]
		SpeakingStop,

		[Description("MESSAGE_CREATE")]
		MessageCreate,

		[Description("MESSAGE_UPDATE")]
		MessageUpdate,

		[Description("MESSAGE_DELETE")]
		MessageDelete,

		[Description("NOTIFICATION_CREATE")]
		NotificationCreate,

		[Description("CAPTURE_SHORTCUT_CHANGE")]
		CaptureShortcutChange,

		[Description("ACTIVITY_JOIN")]
		ActivityJoin,

		[Description("ACTIVITY_SPECTATE")]
		ActivitySpectate,

		[Description("ACTIVITY_JOIN_REQUEST")]
		ActivityJoinRequest,
	}
}
