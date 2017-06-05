/*
 * This code is provided "as is". Without any warranty.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Ponos
{
	public static class Utils
	{
        public static Pen BibPen = new Pen(Color.Lime, 4);
        public static Pen SelectedBibPen = new Pen(Color.Lime, 6);
        public static Brush BibBrush = Brushes.Lime;
        public static Font StdFont = new Font("Courier", 12, FontStyle.Bold);
        public static Font BigFont = new Font("Arial", 35, FontStyle.Bold);
        public static Pen SelectedFacePen = new Pen(Color.Cyan, 6);
        public static Pen FacePen = new Pen(Color.Cyan, 4);
        public static Brush FaceBrush = Brushes.Cyan;
        public static Pen RedPen = new Pen(Color.Magenta, 2);
        public static Pen GuidelinePen = new Pen(Color.White, 3);

        public static bool AtCapacity<T>(this List<T> me)
        {
            return me.Count == me.Capacity;
        }

        public static Point ToPixelPoint(this Point me, PictureBox picBx)
        {
            return ClickPointToPixelPoint(picBx, me);
        }

        public static bool IsPointInImage(this PictureBox me, Point pt)
        {
            pt = pt.ToPixelPoint(me);
            return pt.X <= me.Image.Width && pt.X >= 0 && pt.Y >= 0 && pt.Y <= me.Image.Height;
        }
        
        public static Color LabelForeColorForBackColor(Color c)
        {
            double val = Math.Sqrt(c.R * c.R * .241 + c.G * c.G * .691 + c.B * c.B * .068);
            return val > 130 ? Color.Black : Color.White;
        }

        public static Point ClickPointToPixelPoint(PictureBox pbx, Point clickPt)
        {
            int pbxHeight = pbx.ClientSize.Height;
            int pbxWidth = pbx.ClientSize.Width;
            int imgHeight = pbx.Image.Height;
            int imgWidth = pbx.Image.Width;

            int clickX = clickPt.X;
            int clickY = clickPt.Y;

            int pixelX = clickX;
            int pixelY = clickY;

            switch (pbx.SizeMode)
            {
                case PictureBoxSizeMode.AutoSize:
                case PictureBoxSizeMode.Normal:
                    // These are okay. Leave them alone.
                    break;
                case PictureBoxSizeMode.CenterImage:
                    pixelX = clickX - (pbxWidth - imgWidth) / 2;
                    pixelY = clickY - (pbxHeight - imgHeight) / 2;
                    break;
                case PictureBoxSizeMode.StretchImage:
                    pixelX = (int)(imgWidth * clickX / (float)pbxWidth);
                    pixelY = (int)(imgHeight * clickY / (float)pbxHeight);
                    break;
                case PictureBoxSizeMode.Zoom:
                    float pbxAspect = pbxWidth / (float)pbxHeight;
                    float imgAspect = imgWidth / (float)imgHeight;
                    if (pbxAspect > imgAspect)
                    {
                        // The PictureBox is wider/shorter than the image.
                        pixelY = (int)(imgHeight * clickY / (float)pbxHeight);

                        // The image fills the width of the PictureBox.
                        // Get its width.
                        float scaledWidth = imgWidth * pbxHeight / imgHeight;
                        float dx = (pbxWidth - scaledWidth) / 2;
                        pixelX = (int)((clickX - dx) * imgHeight / (float)pbxHeight);
                    }
                    else
                    {
                        // The PictureBox is taller/thinner than the image.
                        pixelX = (int)(imgWidth * clickX / (float)pbxWidth);

                        // The image fills the height of the PictureBox.
                        // Get its height.
                        float scaledHeight = imgHeight * pbxWidth / imgWidth;
                        float dy = (pbxHeight - scaledHeight) / 2;
                        pixelY = (int)((clickY - dy) * imgWidth / pbxWidth);
                    }
                    break;
            }
            return new Point(pixelX, pixelY);
        }

        public static Point PixelPointToClickPoint(PictureBox pbx, Point pixelPt)
        {
            int pbxHeight = pbx.ClientSize.Height;
            int pbxWidth = pbx.ClientSize.Width;
            int imgHeight = pbx.Image.Height;
            int imgWidth = pbx.Image.Width;

            int pixelX = pixelPt.X;
            int pixelY = pixelPt.Y;

            int clickX = pixelX;
            int clickY = pixelY;

            switch (pbx.SizeMode)
            {
                case PictureBoxSizeMode.AutoSize:
                case PictureBoxSizeMode.Normal:
                    // These are okay. Leave them alone.
                    break;
                case PictureBoxSizeMode.CenterImage:
                    clickX = pixelX - (pbxWidth - imgWidth) / 2;
                    clickY = pixelY - (pbxHeight - imgHeight) / 2;
                    break;
                case PictureBoxSizeMode.StretchImage:
                    clickX = (int)(imgWidth * pixelX / (float)pbxWidth);
                    clickY = (int)(imgHeight * pixelY / (float)pbxHeight);
                    break;
                case PictureBoxSizeMode.Zoom:
                    float pbxAspect = pbxWidth / (float)pbxHeight;
                    float imgAspect = imgWidth / (float)imgHeight;
                    if (pbxAspect > imgAspect)
                    {
                        // The PictureBox is wider/shorter than the image.
                        clickY = (int)(pbxHeight * pixelY / (float)imgHeight);

                        // The image fills the width of the PictureBox.
                        // Get its width.
                        float scaledWidth = pbxWidth * imgHeight / pbxHeight;
                        float dx = (imgWidth - scaledWidth) / 2;
                        clickX = (int)((pixelX - dx) * pbxHeight / (float)imgHeight);
                    }
                    else
                    {
                        // The PictureBox is taller/thinner than the image.
                        clickX = (int)(pbxWidth * pixelX / (float)imgWidth);

                        // The image fills the height of the PictureBox.
                        // Get its height.
                        float scaledHeight = pbxHeight * imgWidth / pbxWidth;
                        float dy = (imgHeight - scaledHeight) / 2;
                        clickY = (int)((pixelY - dy) * pbxWidth / imgWidth);
                    }
                    break;
            }
            return new Point(clickX, clickY);
        }

        private static ArrayList WebColors;
		/// <summary>
		/// Returns the "nearest" color from a given "color space"
		/// </summary>
		/// <param name="input_color">The color to be approximated</param>
		/// <returns>The nearest color</returns>
		public static Color GetNearestWebColor(Color input_color)
		{
			// get the colorspace as an ArrayList
			WebColors = GetWebColors();
			// initialize the RGB-Values of input_color
			double dbl_input_red = Convert.ToDouble(input_color.R);
			double dbl_input_green = Convert.ToDouble(input_color.G);
			double dbl_input_blue = Convert.ToDouble(input_color.B);
			// the Euclidean distance to be computed
			// set this to an arbitrary number
			// must be greater than the largest possible distance (appr. 441.7)
			double distance = 500.0;
			// store the interim result
			double temp;
			// RGB-Values of test colors
			double dbl_test_red;
			double dbl_test_green;
			double dbl_test_blue;
			// initialize the result
			Color nearest_color = Color.Empty;
			foreach (object o in WebColors)
			{
				// compute the Euclidean distance between the two colors
				// note, that the alpha-component is not used in this example
				dbl_test_red = Math.Pow(Convert.ToDouble(((Color)o).R) - dbl_input_red, 2.0);
				dbl_test_green = Math.Pow(Convert.ToDouble(((Color)o).G) - dbl_input_green, 2.0);
				dbl_test_blue = Math.Pow(Convert.ToDouble(((Color)o).B) - dbl_input_blue, 2.0);
				temp = Math.Sqrt(dbl_test_blue + dbl_test_green + dbl_test_red);
				// explore the result and store the nearest color
				if (temp < distance)
				{
					distance = temp;
					nearest_color = (Color)o;
				}
			}
			// done :-)
			return nearest_color;
		}
		/// <summary>
		/// Returns an ArrayList filled with "WebColors"
		/// </summary>
		/// <returns>WebColors</returns>
		/// <remarks>Many thanks to Julijan Sribar for his excellent article (http://www.codeproject.com/cs/miscctrl/MultiTabColorPicker.asp)</remarks>
		private static ArrayList GetWebColors()
		{
			Type color = (typeof(Color));
			PropertyInfo[] propertyInfos = color.GetProperties(BindingFlags.Public | BindingFlags.Static);
			ArrayList colors = new ArrayList();
			foreach (PropertyInfo pi in propertyInfos)
			{
				if (pi.PropertyType.Equals(typeof(Color)))
				{
					Color c = (Color)pi.GetValue((object)(typeof(Color)), null);
					colors.Add(c);
				}
			}
			return colors;
		}
	}
}
