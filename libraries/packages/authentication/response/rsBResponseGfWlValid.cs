using System.IO;


namespace Libraries.packages.authentication
{

    public class PacketBResponseGfWlValid
    {

        public byte Result { get; }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="r">Response result.</param>
        public PacketBResponseGfWlValid(byte r)
        {

            Result = r;

        }

        /// <summary>
        /// Write instance to byte array.
        /// </summary>
        /// <returns>Returns the instance as byte array.</returns>
        public byte[] ToByteArray()
        {

            using (var Stream = new MemoryStream())
            {

                using (var Writer = new BinaryWriter(Stream))
                {

                    byte[] Package;

                    Writer.Write(Result);

                    Package = Stream.ToArray();

                    return Package;

                }

            }            

        }

        /// <summary>
        /// Override ToString method.
        /// </summary>
        public sealed override string ToString()
        {

            return string.Format(
                "PacketBResponseGfWlValid\r\n" +
                "Result = {0}",
                Result
            );            

        }

    }

}
