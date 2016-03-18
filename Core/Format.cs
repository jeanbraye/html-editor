using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mshtml;

namespace WPF_WYSIWYG_HTML_Editor
{
    public static class Format
    {
        public static HTMLDocument doc;

        public static void bold()
        {
            if (doc != null)
            {
                doc.execCommand("Bold", false, null);
            }
        }

        public static void Italic()
        {
            if (doc != null)
            {
                doc.execCommand("Italic", false, null);
            }
        }

        public static void Underline()
        {
            if (doc != null)
            {
                doc.execCommand("Underline", false, null);
            }
        }

        public static void JustifyLeft()
        {
            if (doc != null)
            {
                doc.execCommand("JustifyLeft", false, null);
            }
        }

        public static void JustifyCenter()
        {
            if (doc != null)
            {
                doc.execCommand("JustifyCenter", false, null);
            }
        }

        public static void JustifyRight()
        {
            if (doc != null)
            {
                doc.execCommand("JustifyRight", false, null);
            }
        }

        public static void JustifyFull()
        {
            if (doc != null)
            {
                doc.execCommand("JustifyFull", false, null);
            }
        }


        public static void InsertOrderedList()
        {
            if (doc != null)
            {
                doc.execCommand("InsertOrderedList", false, null);
            }
        }

        public static void InsertUnorderedList()
        {
            if (doc != null)
            {
                doc.execCommand("InsertUnorderedList", false, null);
            }
        }

        public static void Outdent()
        {
            if (doc != null)
            {
                doc.execCommand("Outdent", false, null);
            }
        }

        public static void Indent()
        {
            if (doc != null)
            {
                doc.execCommand("Indent", false, null);
            }
        }


    }
}
