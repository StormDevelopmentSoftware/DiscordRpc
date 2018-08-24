using System;
using System.Text;

namespace DiscordRpc.Entities
{
	public class RpcPacket
	{
		/// <summary>
		/// Operation Code
		/// </summary>
		public RpcOpCode OpCode { get; internal set; }

		/// <summary>
		/// Buffer Data
		/// </summary>
		public byte[] Data { get; private set; }

		/// <summary>
		/// Buffer Length
		/// </summary>
		public int Length => Data.Length;

		/// <summary>
		/// Set data from string.
		/// </summary>
		/// <param name="data">Content to set</param>
		public void SetData(string data)
			=> Data = Encoding.UTF8.GetBytes(data);

		/// <summary>
		/// Get data as string.
		/// </summary>
		/// <returns>String content</returns>
		public string GetData()
			=> Encoding.UTF8.GetString(Data);

		/// <summary>
		/// Get RpcPacket as byte array.
		/// </summary>
		public byte[] GetBytes()
		{
			var op = BitConverter.GetBytes((int)OpCode);
			var len = BitConverter.GetBytes(Length);
			var buffer = new byte[(sizeof(int) * 2) + Data.Length];
			{
				op.CopyTo(buffer, 0);
				len.CopyTo(buffer, 4);
				Data.CopyTo(buffer, 8);
			}
			return buffer;
		}

		/// <summary>
		/// Cast explicit from byte array to <see cref="RpcPacket"/>
		/// </summary>
		/// <param name="buffer">Byte array input buffer</param>
		public static explicit operator RpcPacket(byte[] buffer)
		{
			if (buffer == null)
				throw new ArgumentNullException(nameof(buffer), "Buffer cannot be null!");

			var packet = new RpcPacket();
			{
				byte[] opcode = new byte[4],
					length = new byte[4],
					data = new byte[buffer.Length - 8];

				Array.Copy(buffer, 0, opcode, 0, 4);
				Array.Copy(buffer, 4, opcode, 0, 4);
				Array.Copy(buffer, 8, data, 0, data.Length);

				packet.OpCode = (RpcOpCode)BitConverter.ToInt32(opcode, 0);
				packet.Data = data;
			}
			return packet;
		}
	}
}