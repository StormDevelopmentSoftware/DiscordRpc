using DiscordRpc.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscordRpc.Entities
{
	public enum RpcCommand
	{
		[Command("SET_ACTIVITY")]
		SetActivity,

		[Command("DISPATCH")]
		Dispatch,

		[Command("AUTHORIZE")]
		Authorize,

		[Command("AUTHENTICATE")]
		Authenticate,

		[Command("GET_GUILD")]
		GetGuild,

		[Command("GET_GUILDS")]
		GetGuilds,

		[Command("GET_CHANNEL")]
		GetChannel,

		[Command("GET_CHANNELS")]
		GetChannels,

		[Command("SUBSCRIBE")]
		Subscribe,

		[Command("UNSUBSCRIBE")]
		Unsubscribe,

		[Command("SET_USER_VOICE_SETTINGS")]
		SetUserVoiceSettings,

		[Command("SELECT_VOICE_CHANNEL")]
		SelectVoiceChannel,

		[Command("GET_SELECTED_VOICE_CHANNEL")]
		GetSelectedVoiceChannel,

		[Command("SELECT_TEXT_CHANNEL")]
		SelectTextChannel,

		[Command("GET_VOICE_SETTINGS")]
		GetVoiceSettings,

		[Command("SET_VOICE_SETTINGS")]
		SetVoiceSettings,

		[Command("CAPTURE_SHORTCUT")]
		CaptureShortcut,

		[Command("SET_CERTIFIED_DEVICES")]
		SetCertifiedDevices,

		[Command("SEND_ACTIVITY_JOIN_INVITE")]
		SendActivityJoinInvite,

		[Command("CLOSE_ACTIVITY_REQUEST")]
		CloseActivityRequest,

	}
}