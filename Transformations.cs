using System;
using System.Collections.Generic;
using System.Text;

namespace ImageTransformationsApp
{
    public interface IImageTransformation
    {
        double[,] CreateTransformationMatrix();

        bool IsColorTransformation { get; }
    }

    public class RotationImageTransformation : IImageTransformation
    {
        public double AngleDegrees { get; set; }
        public double AngleRadians
        {
            get { return DegreesToRadians(AngleDegrees); }
            set { AngleDegrees = RadiansToDegrees(value); }
        }
        public bool IsColorTransformation { get { return false; } }

        public static double DegreesToRadians(double degree)
        { return degree * Math.PI / 180; }
        public static double RadiansToDegrees(double radians)
        { return radians / Math.PI * 180; }

        public double[,] CreateTransformationMatrix()
        {
            double[,] matrix = new double[2, 2];

            matrix[0, 0] = Math.Cos(AngleRadians);
            matrix[1, 0] = Math.Sin(AngleRadians);
            matrix[0, 1] = -1 * Math.Sin(AngleRadians);
            matrix[1, 1] = Math.Cos(AngleRadians);

            return matrix;
        }

        public RotationImageTransformation() { }
        public RotationImageTransformation(double angleDegree)
        {
            this.AngleDegrees = angleDegree;
        }
    }

    public class StretchImageTransformation : IImageTransformation
    {
        public double HorizontalStretch { get; set; }
        public double VerticalStretch { get; set; }

        public bool IsColorTransformation { get { return false; } }

        public double[,] CreateTransformationMatrix()
        {
            // создаем единичную матрицу 2х2
            double[,] matrix = Matrices.CreateIdentityMatrix(2);

            matrix[0, 0] += HorizontalStretch;
            matrix[1, 1] += VerticalStretch;

            return matrix;
        }

        public StretchImageTransformation() { }
        public StretchImageTransformation(double horizStretch, double vertStretch)
        {
            this.HorizontalStretch = horizStretch;
            this.VerticalStretch = vertStretch;
        }
    }

    public class FlipImageTransformation : IImageTransformation
    {
        public bool FlipHorizontally { get; set; }
        public bool FlipVertically { get; set; }
        public bool IsColorTransformation { get { return false; } }

        public double[,] CreateTransformationMatrix()
        {
            // создаем единичную матрицу 2х2
            double[,] matrix = Matrices.CreateIdentityMatrix(2);

            if (FlipHorizontally)
                matrix[0, 0] *= -1;
            if (FlipVertically)
                matrix[1, 1] *= -1;

            return matrix;
        }

        public FlipImageTransformation() { }
        public FlipImageTransformation(bool flipHoriz, bool flipVert)
        {
            this.FlipHorizontally = flipHoriz;
            this.FlipVertically = flipVert;
        }
    }

    public class DensityImageTransformation : IImageTransformation
    {
        public double AlphaDensity { get; set; }
        public double RedDensity { get; set; }
        public double GreenDensity { get; set; }
        public double BlueDensity { get; set; }
        public bool IsColorTransformation { get { return true; } }

        public double[,] CreateTransformationMatrix()
        {
            // identity matrix  
            double[,] matrix = new double[,]{
              { AlphaDensity, 0, 0, 0},
              { 0, RedDensity, 0, 0},
              { 0, 0, GreenDensity, 0},
              { 0, 0, 0, BlueDensity},
            };

            return matrix;
        }

        public DensityImageTransformation() { }
        public DensityImageTransformation(double alphaDensity,
          double redDensity,
          double greenDensity,
          double blueDensity)
        {
            this.AlphaDensity = alphaDensity;
            this.RedDensity = redDensity;
            this.GreenDensity = greenDensity;
            this.BlueDensity = blueDensity;
        }
    }
}

