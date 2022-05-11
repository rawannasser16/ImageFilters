using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace ImageFilters
{
    public class ImageOperations
    {
       


        /// <summary>
        /// Open an image, convert it to gray scale and load it into 2D array of size (Height x Width)
        /// </summary>
        /// <param name="ImagePath">Image file path</param>
        /// <returns>2D array of gray values</returns>
        public static byte[,] OpenImage(string ImagePath)
        {
            Bitmap original_bm = new Bitmap(ImagePath);
            int Height = original_bm.Height;
            int Width = original_bm.Width;

            byte[,] Buffer = new byte[Height, Width];

            unsafe
            {
                BitmapData bmd = original_bm.LockBits(new Rectangle(0, 0, Width, Height), ImageLockMode.ReadWrite, original_bm.PixelFormat);
                int x, y;
                int nWidth = 0;
                bool Format32 = false;
                bool Format24 = false;
                bool Format8 = false;

                if (original_bm.PixelFormat == PixelFormat.Format24bppRgb)
                {
                    Format24 = true;
                    nWidth = Width * 3;
                }
                else if (original_bm.PixelFormat == PixelFormat.Format32bppArgb || original_bm.PixelFormat == PixelFormat.Format32bppRgb || original_bm.PixelFormat == PixelFormat.Format32bppPArgb)
                {
                    Format32 = true;
                    nWidth = Width * 4;
                }
                else if (original_bm.PixelFormat == PixelFormat.Format8bppIndexed)
                {
                    Format8 = true;
                    nWidth = Width;
                }
                int nOffset = bmd.Stride - nWidth;
                byte* p = (byte*)bmd.Scan0;
                for (y = 0; y < Height; y++)
                {
                    for (x = 0; x < Width; x++)
                    {
                        if (Format8)
                        {
                            Buffer[y, x] = p[0];
                            p++;
                        }
                        else
                        {
                            Buffer[y, x] = (byte)((int)(p[0] + p[1] + p[2]) / 3);
                            if (Format24) p += 3;
                            else if (Format32) p += 4;
                        }
                    }
                    p += nOffset;
                }
                original_bm.UnlockBits(bmd);
            }

            return Buffer;
        }
        public static int GetHeight(byte[,] ImageMatrix)
        {
            return ImageMatrix.GetLength(0);
        }

        /// <summary>
        /// Get the width of the image 
        /// </summary>
        /// <param name="ImageMatrix">2D array that contains the image</param>
        /// <returns>Image Width</returns>
        public static int GetWidth(byte[,] ImageMatrix)
        {
            return ImageMatrix.GetLength(1);
        }
        /// <summary>
        /// Get the height of the image 
        /// </summary>
        /// <param name="ImageMatrix">2D array that contains the image</param>
        /// <returns>Image Height</returns>
        /// 
        public static int left(int i)
        {
            return 2 * i + 1;
        }
        public static int right(int i)
        {
            return 2 * i + 2;
        }
        public static void max_heap(byte[] Array, int ArrayLength, int i)
        {
            int Left = left(i);
            int Right = right(i);
            int Largest;
            if (Left < ArrayLength && Array[Left] > Array[i])
                Largest = Left;
            else
                Largest = i;
            if (Right < ArrayLength && Array[Right] > Array[Largest])
                Largest = Right;
            if (Largest != i)
            {
                byte Temp = Array[i];
                Array[i] = Array[Largest];
                Array[Largest] = Temp;
                max_heap(Array, ArrayLength, Largest);
            }
        }
        public static void build_max_heap(byte[] Array, int ArrayLength)
        {
            for (int i = ArrayLength / 2 - 1; i >= 0; i--)
                max_heap(Array, ArrayLength, i);    
        }
        public static byte[] heap_sort(byte[] Array, int ArrayLength)
        {
            int HeapSize = ArrayLength;
            build_max_heap(Array, ArrayLength);
            for (int i = ArrayLength - 1; i > 0; i--)
            {
                byte Temp = Array[0];
                Array[0] = Array[i];
                Array[i] = Temp;
                HeapSize--;
                max_heap(Array, HeapSize, 0);
            }
            return Array;
        }

        /////////////////////////////////////
     /*public static byte[]  select_k(byte[] Array , int Trim)
        {
            byte[] min=0;
            byte[] max=0;
            for( int i=0 ; i<Trim ; i++)
            {
              for( int j=0 ; j<Array.Length j++)
                {
                    if(Array[j]<min)
                    { 
                        min=Array[j];

                       Array=Array
                        }
                    if(Array[j]>max)
                    {
                        max=Array[j];
                                 }
                }

            }


        }*/


        


       /////////////////////////////////////
        public static byte[] countSort(byte[] Array, int ArrayLength, byte Max, byte Min)
        {
            byte[] countArray = new byte[Max - Min + 1];
            int index = 0;

            for (int i = 0; i < countArray.Length; i++) { countArray[i] = 0; }
            for (int i = 0; i < ArrayLength; i++) { countArray[Array[i] - Min]++; }

            for (int i = Min; i <= Max; i++)
            {
                while (countArray[i - Min]-- > 0)
                {
                    Array[index] = (byte)i;
                    index++;
                }
            }
            return Array;
        }

        public static byte[] quickSort(byte[] arr, int left, int right)
        {
            int pivot;
            if (left < right)
            {
                pivot = Partition(arr, left, right);
                if (pivot > 1)
                {
                    quickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    quickSort(arr, pivot + 1, right);
                }
            }
            return arr;
        }
        public static int Partition(byte[] Array, int right, int left)
        {
            byte x = Array[left];
            byte Temp;
            int i = right;
           for (int j = right; j < left; j++)
           {
                if (Array[j] <= x)
               {
                    Temp = Array[j];
                    Array[j] = Array[i];
                    Array[i++] = Temp;
                }
            }
            Temp = Array[i];
            Array[i] = Array[left];
           Array[left] = Temp;
            return i;
        }
        //public static int Partition(byte[] arr, int left, int right)
        //{
        //    byte pivot = arr[left];
        //    while (true)
        //    {
        //        while (arr[left] < pivot)
        //        {
        //            left++;
        //        }
        //        while (arr[right] > pivot)
        //        {
        //            right--;
        //        }
        //        if (left < right)
        //        {
        //            byte temp = arr[right];
        //            arr[right] = arr[left];
        //            arr[left] = temp;
        //        }
        //        else
        //        {
        //            return right;
        //        }
        //    }
        //}
        public static byte AdaptiveFilter(byte[,] ImageMatrix, int x, int y, int W, int Wmax, int sort)
        {

            byte[] Array = new byte[W * W];
            int[] Dx = new int[W * W];
            int[] Dy = new int[W * W];
            int Index = 0;
            for (int i = -(W / 2); i <= (W / 2); i++)
            {
                for (int j = -(W / 2); j <= (W / 2); j++)
                {
                    Dx[Index] = j;
                    Dy[Index] = i;
                    Index++;
                }
            }
            byte Zmax, Zmin, Zmed, Zxy;
            int A1, A2, B1, B2, ArrayLength, NewY, NewX;
            Zmax = 0;
            Zmin = 255;
            ArrayLength = 0;
            Zxy = ImageMatrix[y, x];
            for (int i = 0; i < W * W; i++)
            {
   
                NewY = y + Dy[i];
                NewX = x + Dx[i];
                if (NewX >= 0 && NewX < GetWidth(ImageMatrix) && NewY >= 0 && NewY < GetHeight(ImageMatrix))
                {
                    Array[ArrayLength] = ImageMatrix[NewY, NewX];
                    if (Array[ArrayLength] > Zmax)
                        Zmax = Array[ArrayLength];
                    if (Array[ArrayLength] < Zmin)
                        Zmin = Array[ArrayLength];
                    ArrayLength++;
                }
            }
            if (sort == 1)
            {
                Array = quickSort(Array, 0, ArrayLength - 1);
            }
            else if (sort == 2)
            {
                Array = countSort(Array, ArrayLength, Zmax, Zmin);
            }
             else if (sort == 3)
            {
                Array = heap_sort(Array, ArrayLength);
            }
            Zmin = Array[0];
            Zmed = Array[ArrayLength / 2];
            A1 = Zmed - Zmin;
            A2 = Zmax - Zmed;
            if (A1 > 0 && A2 > 0)
            {
                B1 = Zxy - Zmin;
                B2 = Zmax - Zxy;
                if (B1 > 0 && B2 > 0)
                    return Zxy;
                else
                {
                    if (W + 2 < Wmax)
                        return AdaptiveFilter(ImageMatrix, x, y, W + 2, Wmax,sort);
                    else
                        return Zmed;
                }
            }
            else
            {
                return Zmed;
            }

        }
        public static byte AlphaTrim(byte[,] ImageMatrix, int x, int y, int Wmax, int sort)
        {
            byte[] Array;
            int[] Dx, Dy;
            if (Wmax % 2 != 0)
            {
                Array = new byte[Wmax * Wmax];
                Dx = new int[Wmax * Wmax];
                Dy = new int[Wmax * Wmax];
            }
            else
            {
                Array = new byte[(Wmax + 1) * (Wmax + 1)];
                Dx = new int[(Wmax + 1) * (Wmax + 1)];
                Dy = new int[(Wmax + 1) * (Wmax + 1)];
            }
            int Index = 0;
            for (int _y = -(Wmax / 2); _y <= (Wmax / 2); _y++)
            {
                for (int _x = -(Wmax / 2); _x <= (Wmax / 2); _x++)
                {
                    Dx[Index] = _x;
                    Dy[Index] = _y;
                    Index++;
                }
            }
            byte Zmax, Zmin, Z;
            int ArrayLength, Sum, NewY, NewX, Avg;
            Sum = 0;
            Zmax = 0;
            Zmin = 255;
            ArrayLength = 0;
            Z = ImageMatrix[y, x];
            for (int i = 0; i < Wmax * Wmax; i++)
            {
                NewY = y + Dy[i];
                NewX = x + Dx[i];
                if (NewX >= 0 && NewX < GetWidth(ImageMatrix) && NewY >= 0 && NewY < GetHeight(ImageMatrix))
                {
                    Array[ArrayLength] = ImageMatrix[NewY, NewX];
                    if (Array[ArrayLength] > Zmax)
                        Zmax = Array[ArrayLength];
                    if (Array[ArrayLength] < Zmin)
                        Zmin = Array[ArrayLength];
                    Sum += Array[ArrayLength];
                    ArrayLength++;
                }
            }
             if (sort == 1)
            {
                Array = quickSort(Array, 0, ArrayLength - 1);
            }
             else if (sort == 3)
            {
                Array = heap_sort(Array, ArrayLength);
            }
            Sum -= Zmax;
            Sum -= Zmin;
            ArrayLength -= 2;
            Avg = Sum / ArrayLength;
            return (byte)Avg;
        }
        

        /// <summary>
        /// Display the given image on the given PictureBox object
        /// </summary>
        /// <param name="ImageMatrix">2D array that contains the image</param>
        /// <param name="PicBox">PictureBox object to display the image on it</param>
        /// 
      
    
    public static void DisplayImage(byte[,] ImageMatrix, PictureBox PicBox)
        {
            // Create Image:
            //==============
            int Height = ImageMatrix.GetLength(0);
            int Width = ImageMatrix.GetLength(1);

            Bitmap ImageBMP = new Bitmap(Width, Height, PixelFormat.Format24bppRgb);

            unsafe
            {
                BitmapData bmd = ImageBMP.LockBits(new Rectangle(0, 0, Width, Height), ImageLockMode.ReadWrite, ImageBMP.PixelFormat);
                int nWidth = 0;
                nWidth = Width * 3;
                int nOffset = bmd.Stride - nWidth;
                byte* p = (byte*)bmd.Scan0;
                for (int i = 0; i < Height; i++)
                {
                    for (int j = 0; j < Width; j++)
                    {
                        p[0] = p[1] = p[2] = ImageMatrix[i, j];
                        p += 3;
                    }

                    p += nOffset;
                }
                ImageBMP.UnlockBits(bmd);
            }
            PicBox.Image = ImageBMP;
        }
        public static byte[,] ImageFilter(byte[,] ImageMatrix, int Max_Size, int Sort, int filter)
        {
            byte[,] ImageMatrix2 = ImageMatrix;
            for (int y = 0; y < GetHeight(ImageMatrix); y++)
            {
                for (int x = 0; x < GetWidth(ImageMatrix); x++)
                {
                    if (filter == 1)
                    {
                        ImageMatrix2[y, x] = AdaptiveFilter(ImageMatrix, x, y, 3, Max_Size, Sort);
                    } else
                    {
                        ImageMatrix2[y, x] = AlphaTrim(ImageMatrix, x, y, Max_Size, Sort);

                    }

                }
            }

            return ImageMatrix2;
        }
    }
  
}
