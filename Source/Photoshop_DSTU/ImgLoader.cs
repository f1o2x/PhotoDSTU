using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.ComponentModel;

namespace Photoshop_DSTU
{
    public struct ColorSpace
    {
        public byte a;
        public byte b;
        public byte c;
    }

    public class Philter_matrix
    {
        public double[,] matrix;
        public double mult;
        public int summ;
        public bool grey;

        public Philter_matrix(double[,] mx, double mult = 1, int summ = 0, bool is_grey = false)
        {
            matrix = (double[,])mx.Clone();
            this.mult = mult;
            this.summ = summ;
            grey = is_grey;
        }
    }

    public class ImgLoader
    {
        const int shift = 3;
        ColorSpace[] byte_picture;
        public ColorSpace[] get_byte { get { return byte_picture; } set { byte_picture = value; } }
        int width, height;

        //some help functions:

        private void Transp(ref double[,] matrix)
        {
            int size = (int)Math.Sqrt(matrix.Length);
            for (int i = 0; i < size / 2; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    double tmp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = tmp;
                }
            }
        }

        private ColorSpace[,] ConvertToArray()
        {
            ColorSpace[,] res = new ColorSpace[height, width];
            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                    res[i, j] = byte_picture[j + i * width];
            return res;
        }

        private void ConvertFromArray(ColorSpace[,] res)
        {
            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                    byte_picture[i + j * width] = res[i, j];
        }

        public void ClearByte()
        {
            get_byte = new ColorSpace[width * height];
        }

        public void Negative()
        {
            for(int i = 0; i < height * width; i++)
            {
                byte_picture[i].a = (byte)(255 - byte_picture[i].a);
                byte_picture[i].b = (byte)(255 - byte_picture[i].b);
                byte_picture[i].c = (byte)(255 - byte_picture[i].c);
            }
        }

        public static ColorSpace[] RGBtoYCbCr(ColorSpace[] arr)
        {
            ColorSpace[] ycbcr = new ColorSpace[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                double r = arr[i].a;
                double g = arr[i].b;
                double b = arr[i].c;

                ycbcr[i].a = (byte)Math.Round(0.183 * r + 0.614 * g + 0.062 * b + 16);
                ycbcr[i].b = (byte)Math.Round(-0.101 * r - 0.338 * g + 0.439 * b + 128);
                ycbcr[i].c = (byte)Math.Round(0.439 * r - 0.399 * g - 0.040 * b + 128);
            }
            return ycbcr;
        }

        public static ColorSpace[] YCbCrtoRGB(ColorSpace[] ycbcr)
        {
            ColorSpace[] rgb = new ColorSpace[ycbcr.Length];
            for (int i = 0; i < rgb.Length; i++)
            {
                double cb = ycbcr[i].b;
                double cr = ycbcr[i].c;
                double coef = 1.164 * (ycbcr[i].a - 16);

                double q = Math.Round(coef + 1.793 * (cr - 128));
                double w = Math.Round(coef - 0.534 * (cr - 128) - 0.213 * (cb - 128));
                double e = Math.Round(coef + 2.115 * (cb - 128));

                q = q > 255 ? 255 : q;
                w = w > 255 ? 255 : w;
                e = e > 255 ? 255 : e;

                q = q <= 0 ? 0 : q;
                w = w <= 0 ? 0 : w;
                e = e <= 0 ? 0 : e;

                rgb[i].a = (byte)q;
                rgb[i].b = (byte)w;
                rgb[i].c = (byte)e;
            }
            return rgb;
        }

        public byte PickBrightness(int val, byte channel)
        {
            return channel + val < 0 ? (byte)0 : (byte)255;
        }

        public Bitmap Razconvert(ColorSpace[] array)
        {
            return RgbToBitmapQ(array);
        }

        //main functions:
        public void OpenImage(string path)
        {
            Bitmap picture;
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
                picture = new Bitmap(fs);
            width = picture.Width;
            height = picture.Height;
            byte_picture = BitmapToByteRgbQ(picture);
        }

        public void SaveImage(string path)
        {
            Razconvert(byte_picture).Save(path);
        }


        public void Scale(int scale, char mode)
        {
            int new_width = 0, new_height = 0, size;
            ColorSpace[] new_pict = null;
            bool ok  = false;
            switch(mode)
            { 
                case 'i':
                    size = width * height * scale * scale;
                    if (size < 7000 * 4000)
                    {
                        new_width = width * scale; new_height = height * scale;
                        new_pict = new ColorSpace[size];
                        for (int j = 0, new_j = 0; j < height; j++, new_j += scale)
                            for (int i = 0, new_i = 0; i < width; i++, new_i += scale)
                                for (int k1 = 0; k1 < scale; k1++)
                                    for (int k2 = 0; k2 < scale; k2++)
                                        new_pict[new_i + 1 * k1 + (new_j + 1 * k2) * new_width] = byte_picture[i + j * width];
                        ok = true;
                    }
                    else
                        System.Windows.Forms.MessageBox.Show("Enough!", "Image is too big");
                    break;
                case 'd' :
                        size = (width * height) / (scale * scale);
                        if (size > 4)
                        {
                            new_width = (int)Math.Floor((double)(width / scale));
                            new_height = (int)Math.Floor((double)(height / scale));
                            new_pict = new ColorSpace[size];
                            for (int j = 0, new_j = 0; j <= height - scale; j += scale, new_j++)
                                for (int i = 0, new_i = 0; i < width; i += scale, new_i++)
                                {
                                    int count = 0;
                                    double a = 0.0, b = 0.0, c = 0.0;
                                    for (int k1 = 0; k1 < scale; k1++)
                                        for (int k2 = 0; k2 < scale; k2++)
                                        {
                                            int iter = i + 1 * k1 + (j + 1 * k2) * width;
                                            if (iter < width * height)
                                            {
                                                a += byte_picture[iter].a;
                                                b += byte_picture[iter].b;
                                                c += byte_picture[iter].c;
                                                count++;
                                            }
                                        }
                                    new_pict[new_i + new_j * new_width].a = (byte)Math.Round((a / count));
                                    new_pict[new_i + new_j * new_width].b = (byte)Math.Round((b / count));
                                    new_pict[new_i + new_j * new_width].c = (byte)Math.Round((c / count));
                                }
                            ok = true;
                        }
                        else
                            System.Windows.Forms.MessageBox.Show("Enough!", "Image is too small");
                        break;
            }
            if (ok)
            {
                width = new_width;
                height = new_height;
                byte_picture = new_pict;
            }
        }


        public void Aqua()
        {
            int matrix_size = 5;
            int d_m = 2;

            ColorSpace[] new_pict = new ColorSpace[width * height];
            for (int j = 0; j < height; j++)
                for (int i = 0; i < width; i++)
                {
                    double max_a = 0, max_b = 0, max_c = 0;
                    double min_a = 255, min_b = 255, min_c = 255;
                    double a = 0, b = 0, c = 0;
                    for (int k2 = -d_m; k2 < matrix_size - d_m; k2++)
                    {
                        for (int k1 = -d_m; k1 < matrix_size - d_m; k1++)
                        {
                            int iter = i + 1 * k2 + (j + 1 * k1) * width;
                            if (iter >= 0 && iter < width * height)
                            {
                                a = (double)byte_picture[iter].a;
                                b = (double)byte_picture[iter].b;
                                c = (double)byte_picture[iter].c;

                                if (a > max_a || b > max_b || c > max_c)
                                {
                                    max_a = a;
                                    max_b = b;
                                    max_c = c;
                                }

                                if (a < min_a || b < min_b || c < min_c)
                                {
                                    min_a = a;
                                    min_b = b;
                                    min_c = c;
                                }
                            }
                        }
                    }

                    a = (max_a + min_a) / 2;
                    b = (max_b + min_b) / 2;
                    c = (max_c + min_c) / 2;

                    a = a < 0 ? 0 : a;
                    b = b < 0 ? 0 : b;
                    c = c < 0 ? 0 : c;

                    a = a > 255 ? 255 : a;
                    b = b > 255 ? 255 : b;
                    c = c > 255 ? 255 : c;

                    new_pict[i + j * width].a = (byte)Math.Round(a);
                    new_pict[i + j * width].b = (byte)Math.Round(b);
                    new_pict[i + j * width].c = (byte)Math.Round(c);
                }
            byte_picture = new_pict;
        }

        public void Philter(Philter_matrix p_m)
        {
            Transp(ref p_m.matrix);
            int matrix_size = (int)Math.Sqrt(p_m.matrix.Length);
            int d_m = (int)Math.Floor((double)matrix_size / 2);
            ColorSpace[] new_pict = new ColorSpace[width * height];
            for (int j = 0; j < height; j++)
                for (int i = 0; i < width; i++)
                {
                    double a = 0, b = 0, c = 0;
                    for (int k2 = -d_m; k2 < matrix_size - d_m; k2++)
                    {
                        for (int k1 = -d_m; k1 < matrix_size - d_m; k1++)
                        {
                            int iter = i + 1 * k2 + (j + 1 * k1) * width;
                            if (iter >= 0 && iter < width * height)
                            {
                                a += (double)byte_picture[iter].a * p_m.matrix[k2 + d_m, k1 + d_m];
                                b += (double)byte_picture[iter].b * p_m.matrix[k2 + d_m, k1 + d_m];
                                c += (double)byte_picture[iter].c * p_m.matrix[k2 + d_m, k1 + d_m];
                            }
                        }
                    }

                    a = a * p_m.mult + p_m.summ;
                    b = b * p_m.mult + p_m.summ;
                    c = c * p_m.mult + p_m.summ;

                    a = a < 0 ? 0 : a;
                    b = b < 0 ? 0 : b;
                    c = c < 0 ? 0 : c;

                    a = a > 255 ? 255 : a;
                    b = b > 255 ? 255 : b;
                    c = c > 255 ? 255 : c;
                                                                                         
                    new_pict[i + j * width].a = (byte)Math.Round(a);
                    if (p_m.grey)
                        new_pict[i + j * width].b = new_pict[i + j * width].c = new_pict[i + j * width].a;
                    else
                    {
                        new_pict[i + j * width].b = (byte)Math.Round(b);
                        new_pict[i + j * width].c = (byte)Math.Round(c);
                    }
                }
            byte_picture = new_pict;
        }

        public void Mirror(char c)
        {
            ColorSpace tmp = new ColorSpace();
            switch(c)
            { 
                case 'h':
                    for(int i = 0; i < height; i++)
                        for (int j = width - 1, z = i * width; j > width / 2; j--)
                        {
                            tmp = byte_picture[z];
                            byte_picture[z++] = byte_picture[j + i * width];
                            byte_picture[j + i * width] = tmp;
                        }
                    break;
                case 'v':
                    for (int i = height - 1, z = 0; i > height / 2; i--)
                        for (int j = 0; j < width; j++)
                        {
                            tmp = byte_picture[z];
                            byte_picture[z++] = byte_picture[j + i * width];
                            byte_picture[j + i * width] = tmp;
                        }
                    break;
             }
        }

        public void Sepia()
        {
            byte tone = 0;
            for(int i = 0; i < height * width; i++)
            {
                tone = (byte)(0.299 * byte_picture[i].a + 0.587 * byte_picture[i].b + 0.114 * byte_picture[i].c);
                byte_picture[i].a = (byte)(tone > 206 ? 255 : tone + 49);
                byte_picture[i].b = (byte)(tone < 14 ? 0 : tone - 14);
                byte_picture[i].c = (byte)(tone < 56 ? 0 : tone - 56);
            }
        }

        public void RGBtoGBR()
        {
            if (byte_picture == null)
            {
                System.Windows.Forms.MessageBox.Show("RGBtoGBR before open file");
                return;
            }
            for (int i = 0; i < byte_picture.Length; i++)
            {
                byte tmp = byte_picture[i].a;
                byte_picture[i].a = byte_picture[i].b;
                byte_picture[i].b = byte_picture[i].c;
                byte_picture[i].c = tmp;
            }
        }

        public void RGBtoGrey()
        {
            if (byte_picture.Length <= 0) throw new Exception("ALARM PANIC");
            for (int i = 0; i < byte_picture.Length; i++)
                byte_picture[i].a = byte_picture[i].b = byte_picture[i].c = (byte)((77 * byte_picture[i].a +
                    150 * byte_picture[i].b + 29 * byte_picture[i].c + 128) / 256);
        }

        public void ChangeBrightness(int val)
        {
            for (int i = 0; i < byte_picture.Length; i++)
                byte_picture[i].a = (val + byte_picture[i].a) < 0 || val + byte_picture[i].a > 255 ? PickBrightness(val, byte_picture[i].a) : (byte)(val + byte_picture[i].a);
            byte_picture = YCbCrtoRGB(byte_picture);
        }

        public void RotationLeft()
        {
            ColorSpace[] Temp = new ColorSpace[height * width];
            int z = 0;
            for (int j = 0; j < height; j++)
                for (int i = width - 1; i >= 0; i--)
                    Temp[j + i * height] = byte_picture[z++];
            byte_picture = Temp;
            int tmp = width;
            width = height;
            height = tmp;
        }

        public void RotationRight()
        {
            ColorSpace[] Temp = new ColorSpace[height * width];
            int z = 0;
            for (int j = height - 1; j >= 0; j--)
                for (int i = 0; i < width; i++)
                    Temp[j + i * height] = byte_picture[z++];
            byte_picture = Temp;
            int tmp = width;
            width = height;
            height = tmp;
        }



        public void CorrectBrightness()
        {
            byte_picture = RGBtoYCbCr(byte_picture);
            double max = 0, min = 255;
            for (int i = 0; i < byte_picture.Length; i++)
            {
                if (byte_picture[i].a > max) max = byte_picture[i].a;
                if (byte_picture[i].a < min) min = byte_picture[i].a;
            }
            for (int i = 0; i < byte_picture.Length; i++)
            {
                double tmp = (255.0 * (double)(byte_picture[i].a - min) / (double)(max - min));
                byte_picture[i].a = (byte)Math.Round(tmp);
            } 
            byte_picture = YCbCrtoRGB(byte_picture);
        }



        //unsafe area
        private unsafe ColorSpace[] BitmapToByteRgbQ(Bitmap bmp)
        {
            int width = bmp.Width;
            int height = bmp.Height;
            ColorSpace[] res = new ColorSpace[width * height];
            BitmapData bd = bmp.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb);
            try
            {
                byte* curpos;
                fixed (ColorSpace* _res = res)
                {
                    byte* _r = &(_res->a), _g = &(_res->b), _b = &(_res->c);
                    for (int h = 0; h < height; h++)
                    {
                        curpos = ((byte*)bd.Scan0) + h * bd.Stride;
                        for (int w = 0; w < width; w++)
                        {
                            *_b = *(curpos++); _b += shift;
                            *_g = *(curpos++); _g += shift;
                            *_r = *(curpos++); _r += shift;
                        }
                    }
                }
            }
            finally
            {
                bmp.UnlockBits(bd);
            }
            return res;
        }
        private unsafe Bitmap RgbToBitmapQ(ColorSpace[] rgb)
        {
            Bitmap result = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            BitmapData bd = result.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly,
                PixelFormat.Format24bppRgb);
            try
            {
                byte* curpos;
                fixed (ColorSpace* _rgb = rgb)
                {
                    byte* _r = &(_rgb->a), _g = &(_rgb->b), _b = &(_rgb->c);
                    for (int h = 0; h < height; h++)
                    {
                        curpos = ((byte*)bd.Scan0) + h * bd.Stride;
                        for (int w = 0; w < width; w++)
                        {
                            *(curpos++) = *_b; _b += shift;
                            *(curpos++) = *_g; _g += shift;
                            *(curpos++) = *_r; _r += shift;
                        }
                    }
                }
            }
            finally
            {
                result.UnlockBits(bd);
            }
            return result;
        }

        //Lab2
        public void SaveAsEF(string path)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write("EPIC_FORMAT");
                writer.Write(width);
                writer.Write(height);

                byte[] buf = new byte[height * width * 3];
                int j = 0, i = 0;
                for (; j < height * width * 3; i++)
                {
                    buf[j++] = byte_picture[i].a;
                    buf[j++] = byte_picture[i].b;
                    buf[j++] = byte_picture[i].c;
                }
                writer.Write(buf);
            }

        }
        public void LoadAsEF(string path)
        {

            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                reader.ReadString();
                width = reader.ReadInt32();
                height = reader.ReadInt32();
                byte_picture = new ColorSpace[width * height];
                for (int i = 0; i < width * height; i++)
                {
                    byte_picture[i].a = reader.ReadByte();
                    byte_picture[i].b = reader.ReadByte();
                    byte_picture[i].c = reader.ReadByte();
                }
            }
        }
    }
}
