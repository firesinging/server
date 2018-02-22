using System;
using System.IO;
using SuperSocket.SocketBase.Protocol;

using Libraries.enums;

using Libraries.helpers.general;


namespace Libraries.helpers.package
{

    /// <summary>
    /// Package content interface
    /// </summary>
    /// <seealso cref="https://github.com/kisonik"/>
    public class Package : IRequestInfo
    {

        public int HeaderContentLength { get; }

        public long HeaderXuid { get; }

        public byte HeaderField20 { get; }
        public byte HeaderServiceId { get; }
        public byte HeaderField22 { get; }
        public byte HeaderRequestId { get; }

        public byte[] Content { get; }

        public PacketTypes HeaderPacketType { get; }

        // SuperSocket required
        public string Key => Enum.GetName(typeof(PacketTypes), HeaderPacketType);

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="xuid">Xuid in header.</param>
        /// <param name="field20">Field20 in header.</param>
        /// <param name="serviceId">ServiceId in header.</param>
        /// <param name="field22">Field22 in header.</param>
        /// <param name="packetType">PacketType in header.</param>
        /// <param name="requestId">RequestId in header.</param>
        /// <param name="content">Package content.</param>
        public Package(long xuid, byte field20, byte serviceId, byte field22, PacketTypes packetType, byte requestId, byte[] content)
        {

            HeaderXuid = xuid;
            HeaderField20 = field20;
            HeaderServiceId = serviceId;
            HeaderField22 = field22;
            HeaderContentLength = content.Length;
            HeaderPacketType = packetType;
            HeaderRequestId = requestId;

            Content = content;

        }

        /// <summary>
        /// Write instance to byte array.
        /// </summary>
        /// <returns>Returns the instance as byte array.</returns>
        public byte[] ToByteArray()
        {

            using (MemoryStream stream = new MemoryStream())
            {

                using (BinaryWriter writer = new BinaryWriter(stream))
                {

                    byte[] package;

                    writer.Write(HeaderXuid);
                    writer.Write(HeaderField20);
                    writer.Write(HeaderServiceId);
                    writer.Write(HeaderField22);
                    writer.Write(HeaderContentLength);
                    writer.Write(Convert.ToByte(HeaderPacketType));
                    writer.Write(HeaderRequestId);

                    writer.Write(Content);

                    package = stream.ToArray();

                    return package;

                }

            }            

        }

        /// <summary>
        /// Override ToString method.
        /// </summary>
        public sealed override string ToString()
        {

            return string.Format(   
                "Package\r\n" +
                "Xuid = 0x{0:X}\r\n" +
                "PlayerId = {1}\r\n" +
                "RequestID = {2}\r\n" +
                "Command = {3}\r\n" +
                "Content = {4}", 
                HeaderXuid,
                0,
                HeaderRequestId, 
                Key, 
                Helper.PrintBytes(Content)
            );

        }

    }

}
