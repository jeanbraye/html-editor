using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_WYSIWYG_HTML_Editor
{
    public class Items
    {
        public Items()
        { }

        public Items(string id, string value)
        {
            this.Value = value;
            this.Id = id;
        }
        public string Id { get; set; }
        public string Value { get; set; }
    }
}
