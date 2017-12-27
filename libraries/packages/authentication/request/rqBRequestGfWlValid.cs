using System.IO;
using System.Text;

using Libraries.helpers.general;


namespace Libraries.packages.authentication
{

    /// <summary>
    /// Reads content packet PacketBRequestGfWlValid.
    /// </summary>
    public class PacketBRequestGfWlValid
    {

        public byte[] Unk0 { get; }
        
        /// <summary>
        /// Resolves the package content.
        /// </summary>
        /// <param name="request">The request content.</param>
        public PacketBRequestGfWlValid(byte[] request)
        {

            Unk0 = request;

        }

        /// <summary>
        /// Override ToString method.
        /// </summary>
        public sealed override string ToString()
        {

            return string.Format(
                "PacketBRequestGfWlValid" 
            );

        }

    }

}
