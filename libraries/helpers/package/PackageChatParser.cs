using System.IO;
using SuperSocket.SocketBase.Protocol;

using Libraries.enums;


namespace Libraries.helpers.package
{

    /// <summary>
    /// Receive filter base class
    /// </summary>
    /// <typeparam name="PackageChat">The chat package.</typeparam>
    public class PackageChatParser : ReceiveFilterBase<PackageChat>
    {

        /// <value>
        /// The size of the header.
        /// </value>
        public const int headerSize = 13;

        /// <value>
        /// Parsed length in buffer.
        /// </value>
        private int _parsedLengthInBuffer = 0;

        /// <summary>
        /// Filters received data of the specific session into request info.
        /// </summary>
        /// <param name="readBuffer">The read buffer.</param>
        /// <param name="offset">The offset of the current received data in this read buffer.</param>
        /// <param name="length">The length of the current received data.</param>
        /// <param name="toBeCopied">if set to <c>true</c> [to be copied].</param>
        /// <param name="rest">The rest, the length of the data which hasn't been parsed.</param>
        /// <seealso cref="https://github.com/welly87/serveractor/blob/master/ServerActor/Libs/SuperSocket(1.5.3).Source/SocketBase/Protocol/TerminatorReceiveFilter.cs"/>
        /// <seealso cref="https://github.com/Snowin1994/USV_HEU/blob/f9e063366ba5abe89492a4e8a674f920c54067bc/USV_Server/TerminatorReceiveFilter.cs"/>
        public override PackageChat Filter(byte[] readBuffer, int offset, int length, bool toBeCopied, out int rest)
        {

            rest = 0;
            PackageChat Package = null;

            if ((BufferSegments != null) && (BufferSegments.Count > 0))
            {

                _parsedLengthInBuffer += length;

                AddArraySegment(readBuffer, offset, length, toBeCopied);

                byte[] Content = BufferSegments.ToArrayData(0, _parsedLengthInBuffer);

                Package = _ResolvePackageChat(Content, 0, Content.Length);

                int totalLength = (Package != null) ? headerSize + Package.HeaderContentLength : 0;

                rest = _parsedLengthInBuffer - totalLength;

            }
            else
            {

                Package = _ResolvePackageChat(readBuffer, offset, length);

                if (Package == null)
                {

                    _parsedLengthInBuffer += length;

                    AddArraySegment(readBuffer, offset, length, toBeCopied);

                    return null;

                }
                else
                {

                    int totalLength = headerSize + Package.HeaderContentLength;

                    rest = length - totalLength;

                }

            }

            base.Reset();

            return Package;

        }

        /// <summary>
        /// Resolves the chat package.
        /// </summary>
        /// <param name="data">The chat package.</param>
        /// <param name="offset">The offset.</param>
        /// <param name="length">The length.</param>
        private static PackageChat _ResolvePackageChat(byte[] data, int offset, int length)
        {

            using (MemoryStream Stream = new MemoryStream(data, offset, length))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    int HeaderUnk0 = Reader.ReadInt16();
                    int HeaderPacketLength = Reader.ReadInt16();
                    long HeaderXuid = Reader.ReadInt64();
                    PacketTypesChat HeaderPacketType = (PacketTypesChat)Reader.ReadByte();
                    byte[] Content = Reader.ReadBytes(HeaderPacketLength - headerSize);

                    if (Content.Length == HeaderPacketLength - headerSize)
                    {

                        return new PackageChat(HeaderUnk0, HeaderXuid, HeaderPacketType, Content);                        

                    }
                    else
                    {

                        return null;

                    }

                }

            }
            
        }

    }

}
