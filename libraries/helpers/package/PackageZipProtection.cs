using System;
using System.IO;

using Ionic.Zlib;

namespace Libraries.helpers.package
{

    /// <summary>
    /// Package protection
    /// </summary>
    /// <seealso cref="https://github.com/kisonik"/>
    public static class PackageZipProtection
    {

        /// <summary>
        /// Package compress
        /// <param name="input">The input.</param>
        /// <param name="isFile">Flag is file.</param>
        /// <param name="compressionLevel">The compression level.</param>
        /// </summary>
        public static byte[] Compress(byte[] input, bool isFile = false, CompressionLevel compressionLevel = CompressionLevel.BestCompression)
        {

            byte[] Result;

            using (MemoryStream Stream = new MemoryStream())
            {

                using (BinaryWriter Writer = new BinaryWriter(Stream))
                {

                    Writer.BaseStream.WriteByte(0x78);
                    Writer.BaseStream.WriteByte(0xDA);

                    using (DeflateStream Compressor = new DeflateStream(Stream, CompressionMode.Compress, compressionLevel))
                    {

                        Compressor.Write(input, 0, input.Length);

                    }

                }

                Result = Stream.ToArray();

            }

            using (MemoryStream Stream = new MemoryStream())
            {

                using (BinaryWriter Writer = new BinaryWriter(Stream))
                {

                    Writer.Write(Result);

                    byte[] Checksum = BitConverter.GetBytes(GetChecksum(input, Convert.ToUInt32(input.Length)));

                    Array.Reverse(Checksum);

                    Writer.Write(Checksum);

                }

                Result = Stream.ToArray();

            }

            return Result;

        }

        /// <summary>
        /// Package decompress
        /// </summary>
        /// <param name="input">The input.</param>
        public static byte[] Decompress(byte[] input)
        {

            using (MemoryStream Stream = new MemoryStream(input))
            {

                using (DeflateStream Compressor = new DeflateStream(Stream, CompressionMode.Decompress))
                {

                    using (MemoryStream Result = new MemoryStream())
                    {

                        Stream.Position = 2;
                        
                        int Read;
                        byte[] Buffer = new byte[1024 * 512];

                        while ((Read = Compressor.Read(Buffer, 0, Buffer.Length)) > 0)
                        {

                            Result.Write(Buffer, 0, Read);

                        }

                        return Result.ToArray();

                    }

                }

            }            

        }

        /// <summary>
        /// Package checksum
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="inputLength">The input length.</param>
        public static uint GetChecksum(byte[] input, uint inputLength)
        {

            uint result;

            uint i = 0;                       
            uint v1 = 1;
            uint v3 = inputLength;
            uint v4 = v1 >> 16; 
            uint v5 = v1;

            if (inputLength == 1)
            {

                uint v6 = input[0] + v1; 

                if (v6 >= 65521)
                {

                    v6 -= 65521;

                }

                uint v7 = v6 + v4;

                if (v7 >= 65521)
                {

                    v7 -= 65521;

                }
                    
                result = v6 | (v7 << 16);

            }
            else
            {

                if (inputLength >= 0x10)
                {

                    if (inputLength >= 0x15B0)
                    {

                        uint v10 = inputLength / 0x15B0;

                        do
                        {

                            v3 -= 5552;

                            int v11 = 347;

                            do
                            {

                                uint v12 = input[i] + v5; 
                                uint v13 = v12 + v4; 
                                uint v14 = input[i + 1] + v12; 
                                uint v15 = v14 + v13; 
                                uint v16 = input[i + 2] + v14; 
                                uint v17 = v16 + v15; 
                                uint v18 = input[i + 3] + v16; 
                                uint v19 = v18 + v17; 
                                uint v20 = input[i + 4] + v18;
                                uint v21 = v20 + v19;
                                uint v22 = input[i + 5] + v20; 
                                uint v23 = v22 + v21; 
                                uint v24 = input[i + 6] + v22; 
                                uint v25 = v24 + v23;
                                uint v26 = input[i + 7] + v24;
                                uint v27 = v26 + v25; 
                                uint v28 = input[i + 8] + v26;
                                uint v29 = v28 + v27; 
                                uint v30 = input[i + 9] + v28; 
                                uint v31 = v30 + v29; 
                                uint v32 = input[i + 10] + v30; 
                                uint v33 = v32 + v31; 
                                uint v34 = input[i + 11] + v32;
                                uint v35 = v34 + v33; 
                                uint v36 = input[i + 12] + v34; 
                                uint v37 = v36 + v35; 
                                uint v38 = input[i + 13] + v36;
                                uint v39 = v38 + v37;
                                uint v40 = input[i + 14] + v38; 
                                uint v41 = v40 + v39;

                                v5 = input[i + 15] + v40;
                                v4 = v5 + v41;

                                i += 16;

                                --v11;

                            }

                            while (v11 != 0);

                            v5 %= 0xFFF1u;
                            v4 %= 0xFFF1u;

                            --v10;

                        }

                        while (v10 != 0);

                    }

                    if (v3 != 0)
                    {

                        if (v3 >= 0x10)
                        {

                            uint v42 = v3 >> 4;

                            do
                            {

                                uint v43 = input[i] + v5;
                                uint v44 = v43 + v4;
                                uint v45 = input[i + 1] + v43; 
                                uint v46 = v45 + v44;
                                uint v47 = input[i + 2] + v45; 
                                uint v48 = v47 + v46; 
                                uint v49 = input[i + 3] + v47;
                                uint v50 = v49 + v48; 
                                uint v51 = input[i + 4] + v49; 
                                uint v52 = v51 + v50; 
                                uint v53 = input[i + 5] + v51; 
                                uint v54 = v53 + v52; 
                                uint v55 = input[i + 6] + v53; 
                                uint v56 = v55 + v54; 
                                uint v57 = input[i + 7] + v55; 
                                uint v58 = v57 + v56; 
                                uint v59 = input[i + 8] + v57;
                                uint v60 = v59 + v58; 
                                uint v61 = input[i + 9] + v59; 
                                uint v62 = v61 + v60; 
                                uint v63 = input[i + 10] + v61;
                                uint v64 = v63 + v62; 
                                uint v65 = input[i + 11] + v63;
                                uint v66 = v65 + v64; 
                                uint v67 = input[i + 12] + v65; 
                                uint v68 = v67 + v66;
                                uint v69 = input[i + 13] + v67; 
                                uint v70 = v69 + v68; 
                                uint v71 = input[i + 14] + v69; 
                                uint v72 = v71 + v70;

                                v5 = input[i + 15] + v71;
                                v3 -= 16;
                                v4 = v5 + v72;

                                i += 16;

                                --v42;

                            }

                            while (v42 != 0);

                        }

                        for (; v3 != 0; v4 += v5)
                        {

                            v5 += input[i];

                            --v3;

                            ++i;

                        }

                        v5 %= 0xFFF1u;
                        v4 %= 0xFFF1u;

                    }

                    result = v5 | (v4 << 16);

                }
                else
                {

                    if (inputLength != 0)

                        do
                        {

                            v5 += input[i];

                            --v3;

                            ++i;

                            v4 += v5;

                        }

                        while (v3 != 0);

                    if (v5 >= 65521)
                    {

                        v5 -= 65521;

                    }
                        
                    result = v5 | ((v4 + 15 * (v4 / 65521)) << 16);

                }

            }

            return result;

        }        

    }

}