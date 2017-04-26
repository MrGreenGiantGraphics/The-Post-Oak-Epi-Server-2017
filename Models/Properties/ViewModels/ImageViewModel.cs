using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Landrys.ThePostOak_EpiServer.Models.ViewModels
{
    public class ImageViewModel
    {
        public string Url { get; set; }
        public string Title { get; set; }
        public string Copyright { get; set; }
        public string AlternateText { get; set; }
        public string Description { get; set; }
    }
}