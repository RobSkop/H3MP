using LiteNetLib.Utils;

namespace H3MP.Common.Messages
{
	public struct PingMessage : INetSerializable
	{
		/// <summary>
		///		The client's time at the instant the message was sent.
		/// </summary>
		public double Time { get; private set; }

		public PingMessage(double time)
		{
			Time = time;
		}

		public void Deserialize(NetDataReader reader)
		{
			Time = reader.GetDouble();
		}

		public void Serialize(NetDataWriter writer)
		{
			writer.Put(Time);
		}
	}
}
