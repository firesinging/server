using System;
using System.IO;

using SuperSocket.SocketBase.Protocol;

using Libraries.enums;
using Libraries.helpers.general;


namespace Libraries.helpers.package
{

    /// <summary>
    /// Chat package content interface
    /// </summary>
    public class PackageChat : IRequestInfo
    {

        public int HeaderUnk0 { get; }
        public int HeaderContentLength { get; }
        
        public long HeaderXuid { get; }

        public byte[] Content { get; }

        public PacketTypesChat HeaderPacketType { get; }

        // SuperSocket required
        public string Key => Enum.GetName(typeof(PacketTypesChat), HeaderPacketType);

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="unknown">Unknown in header.</param>
        /// <param name="xuid">Xuid in header.</param>
        /// <param name="packetType">PacketType in header.</param>
        /// <param name="content">Package content.</param>
        public PackageChat(int unknown, long xuid, PacketTypesChat packetType, byte[] content)
        {

            HeaderUnk0 = unknown;
            HeaderContentLength = content.Length;
            HeaderXuid = xuid;
            HeaderPacketType = packetType;

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

                    writer.Write(Convert.ToInt16(HeaderUnk0));
                    writer.Write(Convert.ToInt16(PackageChatParser.headerSize + HeaderContentLength));
                    writer.Write(HeaderXuid);
                    writer.Write(Convert.ToByte(HeaderPacketType));

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
                "PackageChat\r\n" +
                "Unk0 = {0}\r\n" +
                "Xuid = 0x{1:X}\r\n" +
                "PlayerId = {2}\r\n" +
                "Command = {3}\r\n" +
                "Content = {4}",
                HeaderUnk0,
                HeaderXuid,
                0,
                Key, 
                Helper.PrintBytes(Content)
            );

        }

    }

}
