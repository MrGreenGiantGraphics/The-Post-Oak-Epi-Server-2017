using System;
using System.Web.Mvc;
using EPiServer.Web.Mvc;
using Landrys.ThePostOak_EpiServer.Models.Blocks;

namespace Landrys.ThePostOak_EpiServer.Controllers
{
    public class ImageBlockController : BlockController<ImageBlock>
    {
        public override ActionResult Index(ImageBlock currentBlock)
        {
            return PartialView(currentBlock);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
