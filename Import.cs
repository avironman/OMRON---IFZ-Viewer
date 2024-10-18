using System;
using System.Runtime.InteropServices;

namespace OMRON_IFZ_Viewer
{
    static class Imports
    {
        public enum BayerMosaic : uint
        {
            GB_GR = 1,
            RG_GB = 13
        }
        public enum ImageKind : uint
        {
            mono8 = 17301505,
            mono10 = 17825795,
            mono10packed = 17563652,
            mono12 = 17825797,
            mono12packed = 17563654,
            RGB8 = 35127316,
            BGRa8= 35651607,
            bayerRG8 = 17301513,
            bayerRG10 = 17825805,
            bayerRG10packed=17563687,
            bayerRG12= 17825809,
            bayerRG12packed = 17563691
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct BITMAPFILEHEADER
        {
            public ushort bfType;
            public uint bfSize;
            public ushort bfReserved1;
            public ushort bfReserved2;

            public uint bfOffBits;
            public void Init()
            {
                bfSize = (uint)Marshal.SizeOf(this);
            }
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct BITMAPINFOHEADER
        {
            public uint biSize;
            public int biWidth;
            public int biHeight;
            public ushort biPlanes;
            public ushort biBitCount;
            public uint biCompression;
            public uint biSizeImage;
            public int biXPelsPerMeter;
            public int biYPelsPerMeter;
            public uint biClrUsed;
            public uint biClrImportant;

            public void Init()
            {
                biSize = (uint)Marshal.SizeOf(this);
            }
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct IFZFILEHEADER
        {
            public uint Signature;
            public uint CamAllotment;
        }
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct IFZINFOHEADER
        {
            public long Address;
            public uint Mosaic;
            public uint CamWidth;
            public uint CamHeight;
            public uint OffsetX;
            public uint OffsetY;
            public uint ImageWidth;
            public uint ImageHeight;
            public uint Size;
            public string Input;
            public string Cam;
            public byte[] RawData;
            public void Init()
            {
                if (ImageWidth != 0 & ImageHeight != 0)
                {
                    Size = (uint)Marshal.SizeOf(this) + ImageHeight * ImageWidth;
                }
            }
           
        }
        public struct STRAWINFOHEADER
        {
            public uint Signature;
            public uint ImageWidth;
            public uint ImageHeight;
            public uint Stride;
            public uint Size;
            public ImageKind ImageKind;
            public byte[] RawData;
            public void Init()
            {
                if (ImageWidth != 0 & ImageHeight != 0)
                {
                    Size = (uint)Marshal.SizeOf(this) + ImageHeight * ImageWidth;
                }
            }
        }
        public struct IFZContent
        {
            public IFZFILEHEADER FileHeader;
            public IFZINFOHEADER[] InfoHeader;
        }
    }

    class Functions
    {
        
    }
}