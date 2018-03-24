using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenMTRDemo.Filters;

namespace OpenMTRDemo.Models
{
    public class MeterImage
    {
        public string FileName { get; set; }
        public Mat SourceImage { get; set; }
        public Mat ModifiedImage
        {
            get
            {
                Mat output = SourceImage.Clone();
                GC.Collect();
                foreach (var filter in FilterList)
                {
                    filter.ApplyFilter(output);
                }
                return output;
            }
        }
        public List<BaseFilter> FilterList { get; set; }
        
        public MeterImage Clone()
        {
            string filename = "" + FileName;
            Mat source = SourceImage.Clone();
            List<BaseFilter> filters = new List<BaseFilter>();
            foreach (BaseFilter filter in FilterList)
            {
                filters.Add(filter.Clone());
            }
            return new MeterImage(filename, source, filters);
        }

        public MeterImage() { }
        public MeterImage(string fileName, Mat sourceImage, List<BaseFilter> filterList = null)
        {
            this.FileName = fileName;
            this.SourceImage = sourceImage;
            this.FilterList = (filterList == null) ? new List<BaseFilter>() : filterList;
        }

        public void Add(BaseFilter filter)
        {
            FilterList.Add(filter);
        }
        public void Remove(BaseFilter filter)
        {
            FilterList.Remove(filter);
        }
    }
}
