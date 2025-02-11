using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    public class BarChart
    {
        /* ---------------- Fields ---------------- */
        private int[] years;
        private int[] revenues;
        private Brush rectangleHatchBrush;
        private HatchStyle hatchStyle;
        private Color rectangleColor;
        private List<Point> topLeftCornerRectanglePoints;
        private int rectangleWidth;

        /* ---------------- Constants ---------------- */
        private const int CHART_WIDTH = 1100;
        private const int CHART_HEIGHT = 650;
        private const int ORIGIN_X = 440;
        private const int ORIGIN_Y = 1000;
        private const int SPACING = 20;

        /* ---------------- Properties ---------------- */
        public Pen lineGraphPen { set; get; }

        /* ---------------- Constructor ---------------- */

        public BarChart(int[] years, int[] revenues)
        {
            this.years = years;
            this.revenues = revenues;
            lineGraphPen = new Pen(Brushes.Blue, 3);
            lineGraphPen.DashStyle = DashStyle.Solid;
            rectangleColor = Color.Red;
            hatchStyle = HatchStyle.BackwardDiagonal;
            rectangleHatchBrush = new HatchBrush(hatchStyle, rectangleColor, Color.LightGray);
            topLeftCornerRectanglePoints = new List<Point>();
        }

        /* ---------------- Methods ---------------- */

        public void Draw(Graphics g)
        {
            Font axisFont = new Font("Arial", 10);
            Font labelFont = new Font("Arial", 12, FontStyle.Bold);
            Pen axisPen = new Pen(Color.Black, 3);
            Brush textBrush = Brushes.Black;


            /* ---- Chart Variables ---- */

            // Chart width and height in pixels
            int numberOfYears = years.Length;
            int chartWidth = CHART_WIDTH;
            int chartHeight = CHART_HEIGHT;
            // Origin point, of X and Y axis
            // Total width of screen is 1920px
            // Total height of screen is 1200px
            Point origin = new Point(x: ORIGIN_X, y: ORIGIN_Y);

            /* ---------------------------- */


            /* ---- Drawing graph axis ---- */

            // Draw X Axis
            // X axis starts from the origin and takes the full width of the chart
            Point xAxisStartingPoint = origin;
            Point xAxisEndingPoint = new Point(x: origin.X + chartWidth, y: origin.Y);
            g.DrawLine(axisPen, pt1: xAxisStartingPoint, pt2: xAxisEndingPoint);

            // Draw Y Axis
            // Y axis starts from origin and takes the full height of the chart
            // X axis starts from the origin and takes the full width of the chart
            Point yAxisStartingPoint = origin;
            Point yAxisEndingPoint = new Point(x: origin.X, y: origin.Y - chartHeight);
            g.DrawLine(axisPen, pt1: yAxisStartingPoint, pt2: yAxisEndingPoint);

            /* ---------------------------- */


            /* ---- Drawing graph titles ---- */

            // Revenue is simply at y axis ending point but shifted a little bit above
            // we can use a magic number here, cause it is just a margin, it will not cause bad readability
            Point revenueTitlePoint = new Point(yAxisEndingPoint.X, yAxisEndingPoint.Y - 25);
            g.DrawString("Revenue", labelFont, Brushes.Black, point: revenueTitlePoint);

            // Years is also simple, it will sit at the x axis ending point with some margin too
            Point yearsTitlePoint = new Point(xAxisEndingPoint.X + 20, xAxisEndingPoint.Y);
            g.DrawString("Years", labelFont, Brushes.Black, point: yearsTitlePoint);

            /* ---------------------------- */


            /* ---- Drawing graph arrows ---- */

            // Notes
            // Arrows are something else, it is a line between two points
            // For y axis, the first point will be the y axis starting point and the second will be
            // the same one but with x value shifted to the left and y value shifted down slightly
            // the mirror is for the right arrow

            // For x axis, the starting point will be the x axis ending point, the ending point will be
            // the same but with a margin, x shifted a little to the left, and y a little to up

            // Y axis Arrows
            Point yLeftArrowStartingPoint = yAxisEndingPoint;
            Point yLeftArrowEndingPoint = new Point(x: yLeftArrowStartingPoint.X - 10, y: yLeftArrowStartingPoint.Y + 15);
            g.DrawLine(axisPen, pt1: yLeftArrowStartingPoint, pt2: yLeftArrowEndingPoint);

            Point yRightArrowStartingPoint = yAxisEndingPoint;
            Point yRightArrowEndingPoint = new Point(x: yRightArrowStartingPoint.X + 10, y: yRightArrowStartingPoint.Y + 15);
            g.DrawLine(axisPen, pt1: yRightArrowStartingPoint, pt2: yRightArrowEndingPoint);

            // X axis Arrows
            Point xLeftArrowStartingPoint = xAxisEndingPoint;
            Point xLeftArrowEndingPoint = new Point(x: xLeftArrowStartingPoint.X - 15, y: xLeftArrowStartingPoint.Y - 10);
            g.DrawLine(axisPen, pt1: xLeftArrowStartingPoint, pt2: xLeftArrowEndingPoint);

            Point xRightArrowStartingPoint = xAxisEndingPoint;
            Point xRightArrowEndingPoint = new Point(x: xRightArrowStartingPoint.X - 15, y: xRightArrowStartingPoint.Y + 10);
            g.DrawLine(axisPen, pt1: xRightArrowStartingPoint, pt2: xRightArrowEndingPoint);

            /* ---------------------------- */


            /* ---- Drawing rectangles ---- */

            // Notes
            // Inorder to draw a rectangle, we need it's top left point, this is easily optained as
            // we already have the origin point, but what is the width of the rectangle? what is the 
            // height too? hmm, these are needed too

            // For the width it is easily obtained from the graph width and years count
            // so it will be graph width in pixels / years count, but is that all?
            // no, you need to account for the spaces between the rectangles
            // suppose you have 10 years, and a graph width of 600px and a 10 px of space between each
            // rectangle, we wanna fill the 600 px with the years rectangles and the space too 
            // the space will take 10 * 9 = 90 pixels, easy, so the space left is 600px - 90px = 510px
            // so in better terms the equation is graphWidth - (spacing * (yearsCount - 1)) and this value
            // is then divided into yearsCount, this will give you the correct and accurate width of
            // each rectangle

            // Now that you have each rectangle width, you need to determine the rectangle height
            // but leave that now, the top left corner point of first rectangle will be
            // x: origin.X, y: origin.Y - 100
            // the second rectange -> x: origin.X + rectangleWidth + spacing
            // be careful, the space is only added after the first rectangle and also it is not added
            // for the last rectangle
            // so lets test that, I will make a list that contains all top left points of rectangles

            // I will remove a little but of space from the chartWidth, so that the last rectangle
            // do not overlap the arrows, this is the -25 px

            // Great, now we wanna obtain the height, this is a little bit tricky, as the height
            // of each rectangle depends on the revenue
            // what I am thinking of is that I already have the chart height, so make the full revenue
            // rectangle takes this whole height
            // so I need an equation, this equation output is the rectangle height
            // and its input is the rectangle revenue
            // what about rectHeight = (rectRevenue / maxRevenue) * chartHeight
            // looks good, for the max revenue rectangle it will give the full chartHeight


            int spacing = SPACING;
            rectangleWidth = (chartWidth - 25 - (spacing * (numberOfYears - 1))) / numberOfYears;
            int rectangleHeight; // This will be filled individually for each rectangle

            // For height calculations obtain the maximum revenue in O(n)
            int maxRev = revenues[0];
            for (int i = 0; i < numberOfYears; i++)
            {
                if (revenues[i] > maxRev)
                    maxRev = revenues[i];
            }

            // Get the top left corner point of each rectangle
            topLeftCornerRectanglePoints.Clear();
            for (int i = 0; i < numberOfYears; i++)
           {
                rectangleHeight = (int)(((double)revenues[i] / maxRev) * chartHeight); // Here it is mandatory to do a float divison first, because 1/2 will result in 0 if it was an integer divison

                Point currPoint = new Point(x: origin.X + i * (rectangleWidth + spacing), 
                                            y: origin.Y - rectangleHeight
                                            );
                topLeftCornerRectanglePoints.Add(currPoint);
            }

            // Now lets use these points to draw the rectangles
            int currIndex = 0;
            foreach (Point point in topLeftCornerRectanglePoints)
            {
                rectangleHeight = (int)(((double)revenues[currIndex] / maxRev) * chartHeight); // Here it is mandatory to do a float divison first, because 1/2 will result in 0 if it was an integer divison
                Size rectSize = new Size(rectangleWidth, rectangleHeight);
                Rectangle currRect = new Rectangle(point, rectSize);
                g.FillRectangle(rectangleHatchBrush, currRect);
                g.DrawRectangle(Pens.Black, currRect);
                currIndex++;
            }


            /* ---------------------------- */

            /* ---- Drawing chart labels ---- */

            // Notes
            // Remember, we already have the top left corner point of each rectangle, we can use those
            // to draw the labels
            // For each triangle, its x label can start at its top left point but with some adjustments
            // the X value will be the x of the rectangle button, Y value will be the y value of origin point
            for (int i = 0; i < numberOfYears; i++)
            {
                Point currPoint = new Point(x: topLeftCornerRectanglePoints.ElementAt(i).X + rectangleWidth / 4 , 
                                            y: origin.Y + 10);
                g.DrawString(years[i].ToString(), labelFont, Brushes.Black, point: currPoint);
            }

            // For the y values
            for (int i = 0; i < numberOfYears; i++)
            {
                Point currPoint = new Point(x: topLeftCornerRectanglePoints.ElementAt(i).X + rectangleWidth / 4, 
                                            y: topLeftCornerRectanglePoints.ElementAt(i).Y);
                g.DrawString(revenues[i].ToString(), labelFont, Brushes.Black, point: currPoint);
            }

            // We can draw values on the y axis too
            // for the chart height px we have max revenue so it is maxRevenue/chartheihgt = value per px
            // I need to draw each 50 value, so 50 takes 50 / (maxRevenue / chartHeight) pixels
            // starting point is origin with x value shifted a little to left
            // each time we decrease y value by 50 / (maxRevenue / chartHeight) pixels amount 
            //MessageBox.Show(maxRev.ToString());
            int fifteesInMaxRevenue = (int)((double)maxRev / 50);

            int pixelsPerFifty = (int)((double)50 / ((double)maxRev / chartHeight));
            int currValue = 50;
            for (int i = 1; i < fifteesInMaxRevenue + 1; i++)
            {
                Point currPoint = new Point(x: origin.X - 50,
                                            y: origin.Y - (i * pixelsPerFifty));
                g.DrawString(currValue.ToString(), labelFont, Brushes.Black, point: currPoint);
                currValue += 50;
            }


            /* ---------------------------- */

            /* ---- Drawing line chart ---- */

            for (int i = 0; i < numberOfYears - 1; i++)
            {
                Point startingPoint = new Point(x: topLeftCornerRectanglePoints[i].X + rectangleWidth / 2,
                                                y: topLeftCornerRectanglePoints[i].Y);
                Point endPoint = new Point(x: topLeftCornerRectanglePoints[i + 1].X + rectangleWidth / 2,
                                            y: topLeftCornerRectanglePoints[i + 1].Y);
                g.DrawLine(lineGraphPen, pt1: startingPoint, pt2: endPoint);
            }

            /* ---------------------------- */




        }

        public int isInChart(int x, int y)
        {
            if (topLeftCornerRectanglePoints == null)
            {
                return -1;
            }
            // You are in the chart if the mouse X is between origin.X and origin.X + chartWidth
            // and mouse Y is between origin.Y and origin.Y - chartHeight
            // the index of the rectangle can be determined by the rectangles left top corner points and rectangle width
            if (x >= ORIGIN_X && x <= ORIGIN_X + CHART_WIDTH && y <= ORIGIN_Y && y >= ORIGIN_Y - CHART_HEIGHT)
            {
                int index = 0;
                foreach (Point point in topLeftCornerRectanglePoints)
                {
                    if (x >= point.X && x <= point.X + rectangleWidth)
                    {
                        return index;
                    }
                    index++;
                }
            }
            return -1;
        }
        public void ChangeLineGraphPenStyle(DashStyle dashStyle)
        {
            lineGraphPen.DashStyle = dashStyle;
        }
        public void ChangeLineGraphPenColor(Brush brush)
        {
            lineGraphPen.Brush = brush;
        }

        public void ChangeRectangleColor(Color color)
        {
            rectangleColor = color;
            rectangleHatchBrush = new HatchBrush(hatchStyle, rectangleColor, Color.LightGray);
        }

        public void ChangeRectangleStyle(HatchStyle hatchStyle)
        {
            this.hatchStyle = hatchStyle;
            rectangleHatchBrush = new HatchBrush(this.hatchStyle, rectangleColor, Color.LightGray);
        }



    }
}


//public void Draw(Graphics g, Rectangle bounds)
//{
//    Font axisFont = new Font("Arial", 10);
//    Font labelFont = new Font("Arial", 12, FontStyle.Bold);
//    Pen axisPen = new Pen(Color.Black, 3);
//    Brush textBrush = Brushes.Black;


//    int width = 600;
//    int maxRevenue = 200; // Ensure reasonable scaling

//    // Calculate bar width and spacing
//    int barCount = years.Length;
//    int barWidth = width / (barCount);
//    int barSpacing = 15;

//    Point origin = new Point(580, 100);


//    // Draw X Axis
//    g.DrawLine(axisPen, x1: origin.X, y1: origin.Y + 1022,
//                        x2: origin.X + 600 + 15 * 9 + 30, y2: origin.Y + 1022);
//        // X Axis Arrow
//    g.DrawLine(axisPen, origin.X + 600 + 15 * 9 + 30 - 15, origin.Y + 1012,
//            origin.X + 600 + 15 * 9 + 30, origin.Y + 1022);
//    g.DrawLine(axisPen, origin.X + 600 + 15 * 9 + 30 - 15, origin.Y + 1032,
//                        origin.X + 600 + 15 * 9 + 30, origin.Y + 1022);

//    // Draw Y Axis
//    g.DrawLine(axisPen, origin.X, origin.Y + 1022,
//                        origin.X, origin.Y + 270);
//        // Y Axis Arrow
//    g.DrawLine(axisPen, origin.X - 10, origin.Y + 285, origin.X, origin.Y + 270); 
//    g.DrawLine(axisPen, origin.X + 10, origin.Y + 285, origin.X, origin.Y + 270); 



//    List<Point> points = new List<Point>();
//    // Draw bars
//    for (int i = 0; i < barCount; i++)
//    {
//        int x = i * (barWidth + barSpacing);
//        int barHeight = (int)((revenues[i] / (double)maxRevenue) * 400);
//        int y = bounds.Height - barHeight - 150;

//        g.FillRectangle(rectangleHatchBrush, origin.X + x, origin.Y + y, barWidth, barHeight);
//        g.DrawRectangle(Pens.Black, origin.X + x, origin.Y + y, barWidth, barHeight);
//        points.Add(new Point(origin.X + x + 30, origin.Y + y));
//        //Draw year labels(X -axis)
//        g.DrawString(years[i].ToString(), axisFont, textBrush, origin.X + x + 7, origin.Y + bounds.Height - 145);

//        // Draw revenue labels on top of bars
//        g.DrawString(revenues[i].ToString(), axisFont, textBrush, origin.X + x + 10, origin.Y + y - 20);
//    }
//    for (int i = 0; i < points.Count - 1; i++)
//    {
//        g.DrawLine(lineGraphPen, points[i], points[i + 1]);
//    }
//    // Draw labels
//    g.DrawString("Revenue", labelFont, Brushes.Black, new PointF(origin.X - 45, origin.Y + 240));
//    g.DrawString("Year", labelFont, Brushes.Black, new PointF(origin.X + 600 + 15 * 9 + 35, origin.Y +  1010));

//}