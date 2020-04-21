using System;
using System.Drawing;
using System.Linq;

namespace ImageTransformationsApp
{
    struct PointColor
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Color Color { get; set; }

        public PointColor(int X, int Y, Color Color)
        {
            this.X = X;
            this.Y = Y;
            this.Color = Color;
        }
    }
    internal class ImageTransformer
    {
        ///   
        /// Применяет трансформации к файлу изображения
        ///   
        public static Bitmap Apply(string file, IImageTransformation[] transformations)
        {
            using (Bitmap bmp = (Bitmap)Bitmap.FromFile(file))
            {
                return Apply(bmp, transformations);
            }
        }

        ///   
        /// Применяет трансформации к bitmap-объекту  
        ///   
        public static Bitmap Apply(Bitmap bmp, IImageTransformation[] transformations)
        {
            // определение массива для хранения данных нового изображения  
            PointColor[] points = new PointColor[bmp.Width * bmp.Height];

            // разделение преобразований на пространственные и цветовые
            var pointTransformations =
              transformations.Where(s => s.IsColorTransformation == false).ToArray();
            var colorTransformations =
              transformations.Where(s => s.IsColorTransformation == true).ToArray();

            // создание матриц трансформации
            double[,] pointTransMatrix =
              CreateTransformationMatrix(pointTransformations, 2); // x, y  
            double[,] colorTransMatrix =
              CreateTransformationMatrix(colorTransformations, 4); // a, r, g, b  

            // сохранение координат для последующей настройки  
            int minX = 0, minY = 0;
            int maxX = 0, maxY = 0;

            // перебор точек и применение трансформаций  
            int idx = 0;
            for (int x = 0; x < bmp.Width; x++)
            { // ряд за рядом 
                for (int y = 0; y < bmp.Height; y++)
                { // колонка за колонкой  

                    // применение пространственных трансформаций 
                    var product =
                      Matrices.Multiply(pointTransMatrix, new double[,] { { x }, { y } });

                    var newX = (int)product[0, 0];
                    var newY = (int)product[1, 0];

                    // обновление координат
                    minX = Math.Min(minX, newX);
                    minY = Math.Min(minY, newY);
                    maxX = Math.Max(maxX, newX);
                    maxY = Math.Max(maxY, newY);

                    // применение трансформаций цвета 
                    Color clr = bmp.GetPixel(x, y); // текущий цвет  
                    var colorProduct = Matrices.Multiply(
                      colorTransMatrix,
                      new double[,] { { clr.A }, { clr.R }, { clr.G }, { clr.B } });
                    clr = Color.FromArgb(
                      GetValidColorComponent(colorProduct[0, 0]),
                      GetValidColorComponent(colorProduct[1, 0]),
                      GetValidColorComponent(colorProduct[2, 0]),
                      GetValidColorComponent(colorProduct[3, 0])
                      ); // новый цвет

                    // сохранение новых данных пикселя
                    points[idx] = new PointColor()
                    {
                        X = newX,
                        Y = newY,
                        Color = clr
                    };

                    idx++;
                }
            }

            // ширина и высота растра после трансформаций
            var width = maxX - minX + 1;
            var height = maxY - minY + 1;

            // новое изображение 
            var img = new Bitmap(width, height);
            foreach (var pnt in points)
                img.SetPixel(
                  pnt.X - minX,
                  pnt.Y - minY,
                  pnt.Color);

            return img;
        }

        ///   
        /// Возвращает цвет от 0 до 255  
        ///   
        private static byte GetValidColorComponent(double c)
        {
            c = Math.Max(byte.MinValue, c);
            c = Math.Min(byte.MaxValue, c);
            return (byte)c;
        }

        ///   
        /// Объединяет преобразования в единую матрицу трансформации  
        ///   
        private static double[,] CreateTransformationMatrix
          (IImageTransformation[] vectorTransformations, int dimensions)
        {
            double[,] vectorTransMatrix =
              Matrices.CreateIdentityMatrix(dimensions);

            // перемножает матрицы трансформации  
            foreach (var trans in vectorTransformations)
                vectorTransMatrix =
                  Matrices.Multiply(vectorTransMatrix, trans.CreateTransformationMatrix());

            return vectorTransMatrix;
        }
    }
}