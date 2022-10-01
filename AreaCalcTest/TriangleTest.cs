using System;
using AreaCalc;
using Xunit;

namespace AreaCalcTest
{
    public class TriangleTest
    {
		[Theory]
		[InlineData(-1, 1, 1)]
		[InlineData(1, -1, 1)]
		[InlineData(1, 1, -1)]
		[InlineData(0, 0, 0)]
		public void InitTriangleWithErrorTest(double a, double b, double c)
		{
			Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
		}

		[Fact]
		public void InitTriangleTest()
		{
			// Data.
			double a = 3d, b = 4d, c = 5d;

			// Act.
			var triangle = new Triangle(a, b, c);

			// Assert.
			Assert.NotNull(triangle);
			Assert.Equal(Math.Abs(triangle.A - a), 0);
			Assert.Equal(Math.Abs(triangle.B - b), 0);
			Assert.Equal(Math.Abs(triangle.C - c), 0);
		}

		[Fact]
		public void GetSquareTest()
		{
			// Data.
			double a = 3d, b = 4d, c = 5d;
			double result = 6d;
			var triangle = new Triangle(a, b, c);

			// Act.
			var square = triangle?.GetArea();

			// Assert.
			Assert.NotNull(square);
			Assert.Equal(Math.Abs(square.Value - result), 0);
		}

		[Fact]
		public void InitNotTriangleTest()
		{
			Assert.Throws<ArgumentException>(() => new Triangle(1, 0, 1));
		}

		[InlineData(3, 4, 3, false)]
        [InlineData(3,5)]
		[InlineData(3, 4, 5 + 2e-7, false)]
		[InlineData(3, 4, 5, true)]
		[InlineData(3, 4, 5.000000001, true)]
		public bool NotRightTriangle(double a, double b, double c)
		{
			// Data.
			var triangle = new Triangle(a, b, c);

			// Act.
			bool isRight = triangle.IsRightTriangle();

			// Assert. 
			return isRight;
		}
	}
}