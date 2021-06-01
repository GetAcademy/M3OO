using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3OO
{
    class HtmlBuilder
    {
        public string Html { get; private set; } = "";


        public HtmlBuilder Add(string tag, string content)
        {
            Html += $"<{tag}>{content}</{tag}>\n";
            return this;
        }

    }
}
