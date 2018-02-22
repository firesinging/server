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

            uint uChecksum = Checksum(1, input, (uint)input.Length);

            using (MemoryStream Stream = new MemoryStream())
            {

                using (BinaryWriter Writer = new BinaryWriter(Stream))
                {

                    Writer.Write(Result);

                    byte[] Addition = BitConverter.GetBytes(uChecksum);

                    Array.Reverse(Addition);

                    Writer.Write(Addition);

                }

                Result = Stream.ToArray();

            }

            return Result;

        }
       
        /// <summary>
        /// Package decompress
        /// </summary>
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
        public static uint Checksum(uint a1, byte[] a2, uint a3)
        {

            uint v3; // ebx@1
            uint v4; // edi@1
            uint v5; // ecx@1
            uint v6; // ecx@2
            uint v7; // edi@4
            uint result; // eax@6
            byte[] v9; // esi@7
            uint v10; // ebp@16
            int v11; // eax@17
            uint v12; // ecx@18
            uint v13; // edi@18
            uint v14; // ecx@18
            uint v15; // edi@18
            uint v16; // ecx@18
            uint v17; // edi@18
            uint v18; // ecx@18
            uint v19; // edi@18
            uint v20; // ecx@18
            uint v21; // edi@18
            uint v22; // ecx@18
            uint v23; // edi@18
            uint v24; // ecx@18
            uint v25; // edi@18
            uint v26; // ecx@18
            uint v27; // edi@18
            uint v28; // ecx@18
            uint v29; // edi@18
            uint v30; // ecx@18
            uint v31; // edi@18
            uint v32; // ecx@18
            uint v33; // edi@18
            uint v34; // ecx@18
            uint v35; // edi@18
            uint v36; // ecx@18
            uint v37; // edi@18
            uint v38; // ecx@18
            uint v39; // edi@18
            uint v40; // ecx@18
            uint v41; // edi@18
            uint v42; // eax@22
            uint v43; // ecx@23
            uint v44; // edi@23
            uint v45; // ecx@23
            uint v46; // edi@23
            uint v47; // ecx@23
            uint v48; // edi@23
            uint v49; // ecx@23
            uint v50; // edi@23
            uint v51; // ecx@23
            uint v52; // edi@23
            uint v53; // ecx@23
            uint v54; // edi@23
            uint v55; // ecx@23
            uint v56; // edi@23
            uint v57; // ecx@23
            uint v58; // edi@23
            uint v59; // ecx@23
            uint v60; // edi@23
            uint v61; // ecx@23
            uint v62; // edi@23
            uint v63; // ecx@23
            uint v64; // edi@23
            uint v65; // ecx@23
            uint v66; // edi@23
            uint v67; // ecx@23
            uint v68; // edi@23
            uint v69; // ecx@23
            uint v70; // edi@23
            uint v71; // ecx@23
            uint v72; // edi@23
            uint i = 0;

            v3 = a3;
            v4 = a1 >> 16;
            v5 = a1;

            if (a3 == 1)
            {

                v6 = a2[0] + a1;
                if (v6 >= 0xFFF1)
                    v6 -= 0xFFF1;
                v7 = v6 + v4;

                if (v7 >= 0xFFF1)
                    v7 -= 0xFFF1;

                result = v6 | (v7 << 16);

            }
            else
            {

                v9 = a2;

                if (a3 >= 0x10)
                {

                    if (a3 >= 0x15B0)
                    {

                        v10 = a3 / 0x15B0;

                        do
                        {

                            v3 -= 5552;
                            v11 = 347;

                            do
                            {

                                v12 = v9[i] + v5;
                                v13 = v12 + v4;
                                v14 = (uint)(v9[1] + v12);
                                v15 = (uint)(v14 + v13);
                                v16 = (uint)(v9[2] + v14);
                                v17 = v16 + v15;
                                v18 = v9[3] + v16;
                                v19 = v18 + v17;
                                v20 = v9[4] + v18;
                                v21 = v20 + v19;
                                v22 = v9[5] + v20;
                                v23 = v22 + v21;
                                v24 = v9[6] + v22;
                                v25 = v24 + v23;
                                v26 = v9[7] + v24;
                                v27 = v26 + v25;
                                v28 = v9[8] + v26;
                                v29 = v28 + v27;
                                v30 = v9[9] + v28;
                                v31 = v30 + v29;
                                v32 = v9[10] + v30;
                                v33 = v32 + v31;
                                v34 = v9[11] + v32;
                                v35 = v34 + v33;
                                v36 = v9[12] + v34;
                                v37 = v36 + v35;
                                v38 = v9[13] + v36;
                                v39 = v38 + v37;
                                v40 = v9[14] + v38;
                                v41 = v40 + v39;
                                v5 = v9[15] + v40;
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

                            v42 = v3 >> 4;

                            do
                            {

                                v43 = v9[i] + v5;
                                v44 = v43 + v4;
                                v45 = v9[i + 1] + v43;
                                v46 = v45 + v44;
                                v47 = v9[i + 2] + v45;
                                v48 = v47 + v46;
                                v49 = v9[i + 3] + v47;
                                v50 = v49 + v48;
                                v51 = v9[i + 4] + v49;
                                v52 = v51 + v50;
                                v53 = v9[i + 5] + v51;
                                v54 = v53 + v52;
                                v55 = v9[i + 6] + v53;
                                v56 = v55 + v54;
                                v57 = v9[i + 7] + v55;
                                v58 = v57 + v56;
                                v59 = v9[i + 8] + v57;
                                v60 = v59 + v58;
                                v61 = v9[i + 9] + v59;
                                v62 = v61 + v60;
                                v63 = v9[i + 10] + v61;
                                v64 = v63 + v62;
                                v65 = v9[i + 11] + v63;
                                v66 = v65 + v64;
                                v67 = v9[i + 12] + v65;
                                v68 = v67 + v66;
                                v69 = v9[i + 13] + v67;
                                v70 = v69 + v68;
                                v71 = v9[i + 14] + v69;
                                v72 = v71 + v70;
                                v5 = v9[i + 15] + v71;
                                v3 -= 16;
                                v4 = v5 + v72;
                                i += 16;
                                --v42;

                            }

                            while (v42 != 0);

                        }

                        for (; v3 != 0; v4 += v5)
                        {

                            v5 += v9[i];
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

                    if (a3 != 0)
                    {

                        do
                        {

                            v5 += v9[i];
                            --v3;
                            ++i;
                            v4 += v5;

                        }

                        while (v3 != 0);

                    }

                    if (v5 >= 0xFFF1)
                        v5 -= 65521;

                    result = v5 | ((v4 + 15 * (v4 / 0xFFF1)) << 16);

                }

            }

            return result;

        }

    }

}