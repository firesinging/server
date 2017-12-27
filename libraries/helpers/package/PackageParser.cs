using System;
using System.IO;

using SuperSocket.Facility.Protocol;

using Libraries.enums;


namespace Libraries.helpers.package
{

    /// <summary>
    /// Receive filter base for the protocol which define fixed length header and the header contains the request body length.
    /// Package headers always have same length, so used FixedHeaderReceiveFilter.
    /// </summary>
    /// <typeparam name="Package">The package.</typeparam>
    /// <seealso cref="http://docs.supersocket.net/v1-6/en-US/The-Built-in-Common-Format-Protocol-Implementation-Templates"/>
    public class PackageParser : FixedHeaderReceiveFilter<Package>
    {

        /// <value>
        /// The size of the header.
        /// </value>
        public const int headerSize = 17;

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public PackageParser() : base(headerSize)
        {

        }

        /// <summary>
        /// Gets the content length from the package header at index [11].
        /// </summary>
        /// <param name="headerData">The header data.</param>
        /// <param name="offset">The offset to use.</param>
        /// <param name="length">The length of the header. Equals [headerSize]</param>
        /// <returns>Returns the content length from the package header as integer.</returns>
        protected override int GetBodyLengthFromHeader(byte[] headerData, int offset, int length)
        {

            using (MemoryStream Stream = new MemoryStream(headerData, offset, length))
            {

               Stream.Seek(11, SeekOrigin.Begin);

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    int i = Reader.ReadInt32();

                    return (i > 0) ? i : 0;

                }

            }            

        }

        /// <summary>
        /// Resolves the package.
        /// </summary>
        /// <param name="headerBuffer">The header buffer.</param>
        /// <param name="contentBuffer">The content buffer.</param>
        /// <param name="offset">The offset.</param>
        /// <param name="length">The length.</param>
        /// <returns>Returns [Package].</returns>
        protected override Package ResolveRequestInfo(ArraySegment<byte> headerBuffer, byte[] contentBuffer, int offset, int length)
        {

            var Header = _parseHeader(headerBuffer);

            byte[] Content = _parseContent(contentBuffer, offset, length, Header.Item5);

            return new Package(Header.Item1, Header.Item2, Header.Item3, Header.Item4, Header.Item6, Header.Item7, Content);

        }

        /// <summary>
        /// Resolves the package header.
        /// </summary>
        /// <param name="headerBuffer">The header buffer.</param>
        /// <returns>Returns package header elements.</returns>
        private Tuple<long, byte, byte, byte, int, PacketTypes, byte> _parseHeader(ArraySegment<byte> headerBuffer)
        {

            long HeaderXuid;
            byte HeaderField20;
            byte HeaderServiceId;
            byte HeaderField22;
            int HeaderContentLength;
            PacketTypes HeaderPacketType;
            byte HeaderRequestId;

            using (MemoryStream Stream = new MemoryStream(headerBuffer.Array))
            {

                using (BinaryReader Reader = new BinaryReader(Stream))
                {

                    HeaderXuid = Reader.ReadInt64();
                    HeaderField20 = Reader.ReadByte();
                    HeaderServiceId = Reader.ReadByte();
                    HeaderField22 = Reader.ReadByte();
                    HeaderContentLength = Reader.ReadInt32();
                    HeaderPacketType = (PacketTypes) Reader.ReadByte();
                    HeaderRequestId = Reader.ReadByte();

                }

            }

            var Parsed = new Tuple<long, byte, byte, byte, int, PacketTypes, byte>(HeaderXuid, HeaderField20, HeaderServiceId, HeaderField22, HeaderContentLength, HeaderPacketType, HeaderRequestId);

            return Parsed;

        }

        /// <summary>
        /// Resolves the package content.
        /// </summary>
        /// <param name="contentBuffer">The content buffer.</param>
        /// <param name="offset">The offset.</param>
        /// <param name="length">The length.</param>
        /// <param name="contentLength">The content length as defined in the header.</param>
        /// <returns>Returns the package content as byte[].</returns>
        private byte[] _parseContent(byte[] contentBuffer, int offset, int length, int contentLength)
        {

            byte[] Parsed;

            // Allow Session.HandleUnknownRequest
            if (contentLength > 0)
            {

                using (MemoryStream Stream = new MemoryStream(contentBuffer, offset, length))
                {

                    using (BinaryReader Reader = new BinaryReader(Stream))
                    {

                        Parsed = Reader.ReadBytes(contentLength);

                    }

                }

            }
            else
            {

                Parsed = new byte[0];

            }

            return Parsed;

        }

    }

}
