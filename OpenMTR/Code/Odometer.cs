using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMTR
{
    public class Odometer
    {
        public static void Read(Mat sourceImage)
        {
            ReadDigits(sourceImage, ExtractDigits(sourceImage));
        }

        private static List<Rect> ExtractDigits(Mat sourceImage)
        {
            ImageUtils.ColorToGray(sourceImage, sourceImage);
            ImageUtils.ApplyGaussianBlur(sourceImage, sourceImage);
            Cv2.AdaptiveThreshold(sourceImage, sourceImage, 250, AdaptiveThresholdTypes.MeanC, ThresholdTypes.Binary, 5, 0);
            //CannyFilter.ApplyCannyFilter(sourceImage, sourceImage, 200, 300);
            Cv2.FindContours(sourceImage, out Point[][] contours, out HierarchyIndex[] hierarchy, RetrievalModes.List, ContourApproximationModes.ApproxSimple);
            List<Rect> digits = new List<Rect>();

            foreach (Point[] point in contours)
            {
                double area = Cv2.ContourArea(point);

                if (area >= 300 && area <= 550)
                {
                    digits.Add(Cv2.BoundingRect(point));
                    //DebugUtils.Log($"{area}");
                    //Cv2.Rectangle(sourceImage, Cv2.BoundingRect(point), new Scalar(255, 0, 0), 2);
                }
            }

            return digits;
        }

        private static void ReadDigits(Mat sourceImage, List<Rect> digits)
        {
            foreach (Rect digit in digits)
            {
                Mat regionOfInterest = new Mat(sourceImage, digit);
                int[] segmentStates = new int[7];
                int w = digit.Width,
                    h = digit.Height,
                    roiH = regionOfInterest.Height,
                    roiW = regionOfInterest.Width,
                    digitW = (int)(roiW * 0.25),
                    digitH = (int)(roiH * 0.15),
                    digitHC = (int)(roiH * 0.05);

                List<List<int>> segments = new List<List<int>>
                {
                    new List<int> {0, 0, w, digitH },                                      // Top
                    new List<int> {0, 0, digitW, (h / 2) },                                // Top left
                    new List<int> {(w - digitW), 0, w, (h / 2) },                          // Top right
                    new List<int> {0, (h / 2) - digitHC, w, (h / 2) + digitHC },           // Center
                    new List<int> {0, (h / 2), digitW, h },                                // bottom left
                    new List<int> {w - digitW, h / 2, w, h },                              // Bottom right
                    new List<int> {0, h - digitH, w, h },                                  // bottom
                };

                for (int i = 0; i < segments.Count; i++)
                {
                    List<int> segment = segments[i];
                    int segmentX = segment[0],
                        segmentY = segment[1],
                        segmentWidth = segment[2],
                        segmentHeight = segment[3];

                    Mat segROI = new Mat(regionOfInterest, new Rect(segmentX, segmentY, segmentWidth, segmentHeight));
                    double total = Cv2.CountNonZero(segROI),
                        area = (segmentWidth - segmentX) * (segmentHeight - segmentY);

                    if (total / (double)area > 0.5)
                    {
                        segmentStates[i] = 1;
                    }
                }

                DebugUtils.Log("Segment Start");
                foreach (int state in segmentStates)
                {
                    DebugUtils.Log($"{state}");
                }

                DebugUtils.Log("Segment End");
            }
        }
    }
}
