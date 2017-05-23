/*
 * This code is provided "as is". Without any warranty.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace HermesDataTagger
{
	public static class Utils
	{
        public static Pen BibPen = new Pen(Color.Lime, 4);
        public static Pen SelectedBibPen = new Pen(Color.Lime, 6);
        public static Brush BibBrush = Brushes.Lime;
        public static Font StdFont = new Font("Courier", 12, FontStyle.Bold);
        public static Pen SelectedFacePen = new Pen(Color.Aqua, 6);
        public static Pen FacePen = new Pen(Color.Aqua, 4);
        public static Brush FaceBrush = Brushes.Aqua;
        public static Pen RedPen = new Pen(Color.Red, 2);
        public static Pen GuidelinePen = new Pen(Color.Cyan, 2);

        public static bool AtCapacity<T>(this List<T> me)
        {
            return me.Count == me.Capacity;
        }

        public static Point ToPixelPoint(this Point me, PictureBox picBx)
        {
            return MousePointToPixelPoint(picBx, me);
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

        public static Point MousePointToPixelPoint(PictureBox picBx, Point pt)
        {
            int picHeight = picBx.ClientSize.Height;
            int picWidth = picBx.ClientSize.Width;
            int imgHeight = picBx.Image.Height;
            int imgWidth = picBx.Image.Width;

            int x = pt.X;
            int y = pt.Y;

            int retX = x;
            int retY = y;

            switch (picBx.SizeMode)
            {
                case PictureBoxSizeMode.AutoSize:
                case PictureBoxSizeMode.Normal:
                    // These are okay. Leave them alone.
                    break;
                case PictureBoxSizeMode.CenterImage:
                    retX = x - (picWidth - imgWidth) / 2;
                    retY = y - (picHeight - imgHeight) / 2;
                    break;
                case PictureBoxSizeMode.StretchImage:
                    retX = (int)(imgWidth * x / (float)picWidth);
                    retY = (int)(imgHeight * y / (float)picHeight);
                    break;
                case PictureBoxSizeMode.Zoom:
                    float pic_aspect = picWidth / (float)picHeight;
                    float img_aspect = imgWidth / (float)imgHeight;
                    if (pic_aspect > img_aspect)
                    {
                        // The PictureBox is wider/shorter than the image.
                        retY = (int)(imgHeight * y / (float)picHeight);

                        // The image fills the height of the PictureBox.
                        // Get its width.
                        float scaled_width = imgWidth * picHeight / imgHeight;
                        float dx = (picWidth - scaled_width) / 2;
                        retX = (int)((x - dx) * imgHeight / (float)picHeight);
                    }
                    else
                    {
                        // The PictureBox is taller/thinner than the image.
                        retX = (int)(imgWidth * x / (float)picWidth);

                        // The image fills the height of the PictureBox.
                        // Get its height.
                        float scaled_height = imgHeight * picWidth / imgWidth;
                        float dy = (picHeight - scaled_height) / 2;
                        retY = (int)((y - dy) * imgWidth / picWidth);
                    }
                    break;
            }
            return new Point(retX, retY);
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
