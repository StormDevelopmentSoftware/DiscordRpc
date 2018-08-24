using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DiscordRpc.Entities
{
	public enum RpcCommand
	{
		[Description("SET_ACTIVITY")]
		SetActivity,

		[Description("DISPATCH")]
		Dispatch,

		[Description("AUTHORIZE")]
		Authorize,

		[Description("AUTHENTICATE")]
		Authenticate,

		[Description("GET_GUILD")]
		GetGuild,

		[Description("GET_GUILDS")]
		GetGuilds,

		[Description("GET_CHANNEL")]
		GetChannel,

		[Description("GET_CHANNELS")]
		GetChannels,

		[Description("SUBSCRIBE")]
		Subscribe,

		[Description("UNSUBSCRIBE")]
		Unsubscribe,

		[Description("SET_USER_VOICE_SETTINGS")]
		SetUserVoiceSettings,

		[Description("SELECT_VOICE_CHANNEL")]
		SelectVoiceChannel,

		[Description("GET_SELECTED_VOICE_CHANNEL")]
		GetSelectedVoiceChannel,

		[Description("SELECT_TEXT_CHANNEL")]
		SelectTextChannel,

		[Description("GET_VOICE_SETTINGS")]
		GetVoiceSettings,

		[Description("SET_VOICE_SETTINGS")]
		SetVoiceSettings,

		[Description("CAPTURE_SHORTCUT")]
		CaptureShortcut,

		[Description("SET_CERTIFIED_DEVICES")]
		SetCertifiedDevices,

		[Description("SEND_ACTIVITY_JOIN_INVITE")]
		SendActivityJoinInvite,

		[Description("CLOSE_ACTIVITY_REQUEST")]
		CloseActivityRequest,

	}
}