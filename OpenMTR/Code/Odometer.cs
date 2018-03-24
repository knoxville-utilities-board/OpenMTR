using OpenCvSharp;
using System.Collections.Generic;
using System.Linq;

namespace OpenMTR
{
    public class Odometer
    {
        private static Dictionary<string, int[]> _numberLookup = new Dictionary<string, int[]>
        {
            { "0", new int[] {1,1,1,0,1,1,1 } },
            { "1", new int[] {0,1,0,0,1,0,0 } },
            { "2", new int[] {1,0,1,1,1,0,1 } },
            { "3", new int[] {1,1,1,0,0,1,1 } }, //{ 3, new int[] {1,0,1,1,0,1,1 } },
            { "4", new int[] {0,1,1,1,0,1,0 } },
            { "5", new int[] {1,1,0,1,0,1,1 } },
            { "6", new int[] {1,1,0,1,1,1,1 } },
            { "7", new int[] {1,1,1,0,0,1,0 } },
            { "8", new int[] {1,1,1,1,1,1,1 } },
            { "9", new int[] {1,1,1,1,0,1,1 } }
        };

        public static string Read(Mat sourceImage)
        {
            return ReadDigits(sourceImage, ExtractDigits(sourceImage));
        }

        private static List<Rect> ExtractDigits(Mat image)
        {
            List<Rect> digits = new List<Rect>();

            ImageUtils.ColorToGray(image, image);
            Cv2.GaussianBlur(image, image, new Size(5, 5), 0);
            Cv2.AdaptiveThreshold(image, image, 250, AdaptiveThresholdTypes.GaussianC, ThresholdTypes.Binary, 5, -1.2);
            Cv2.MorphologyEx(image, image, MorphTypes.Open, ImageUtils.GetKernel(new Size(3,3)));
            Cv2.FindContours(image, out Point[][] contours, out HierarchyIndex[] hierarchy, RetrievalModes.List, ContourApproximationModes.ApproxSimple);

            foreach (Point[] point in contours)
            {
                double area = Cv2.ContourArea(point);

                if (area >= 300 && area <= 550)
                {
                    digits.Add(Cv2.BoundingRect(point));                  
                }
            }

            return SortDigits(digits);
        }

        private static List<Rect> SortDigits(List<Rect> digits)
        {
            return digits.OrderBy(digit => digit.X).ToList();
        }

        private static int[] DetectSegmentStates(Mat regionOfInterest, List<List<int>> segments)
        {
            int[] segmentStates = new int[7];

            for (int i = 0; i < segments.Count; i++)
            {
                int segmentX = segments[i][0], segmentY = segments[i][1], segmentWidth = segments[i][2], segmentHeight = segments[i][3];
                Cv2.Rectangle(regionOfInterest, new Rect(segmentX, segmentY, segmentWidth, segmentHeight), new Scalar(255, 0, 0));
                Mat segROI = new Mat(regionOfInterest, new Rect(segmentX, segmentY, segmentWidth, segmentHeight));
                double total = Cv2.CountNonZero(segROI), area = segmentWidth * segmentHeight;

                if ((total / (double)area) > 0.65)
                {
                    segmentStates[i] = 1;
                }
            }

            return segmentStates;
        }

        private static string ReadDigitFromStates(int[] segmentStates)
        {
            foreach (KeyValuePair<string, int[]> number in _numberLookup)
            {
                if (segmentStates.SequenceEqual(number.Value))
                {
                    return number.Key;
                }
            }
            return "";
        }

        private static string ReadDigits(Mat image, List<Rect> digits)
        {
            string digitRead = "";
            foreach (Rect digit in digits)
            {
                Mat regionOfInterest = new Mat(image.Clone(), digit);
                
                int segW = (int)(regionOfInterest.Width * 0.25), segH = (int)(regionOfInterest.Height * 0.25);

                Cv2.MorphologyEx(regionOfInterest, regionOfInterest, MorphTypes.Close, ImageUtils.GetKernel(new Size(3, 3)));

                List<List<int>> segments = new List<List<int>>
                {
                    new List<int> {segW, 0, digit.Width - (2 * segW), segH },                                    // Top
                    new List<int> {0, 0, segW, digit.Height / 2 },                                               // Top left
                    new List<int> { digit.Width - segW, 0, segW, digit.Height / 2 },                             // Top right
                    new List<int> {segW, digit.Height / 2 - (segH / 2), digit.Width - (2 * segW), segH },        // Center
                    new List<int> {0, digit.Height / 2, segW, digit.Height / 2 },                                // bottom left
                    new List<int> {digit.Width - segW, digit.Height / 2, segW, digit.Height / 2 },               // Bottom right
                    new List<int> {segW, digit.Height - segH, digit.Width - (2 * segW), segH },                  // bottom
                };

                digitRead += ReadDigitFromStates(DetectSegmentStates(regionOfInterest, segments));
            }

            return digitRead;
        }
    }
}
