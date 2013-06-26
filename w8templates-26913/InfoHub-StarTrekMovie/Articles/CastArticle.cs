using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoHub.Articles
{
    public class CastArticle : ArticleBase
    {
        public string Actor { get; set; }
        public string Character { get; set; }
        public string Image { get { return string.Format("ms-appx:///images/{0}.jpg", this.Actor.Replace(" ", string.Empty)); } }
    }
}
