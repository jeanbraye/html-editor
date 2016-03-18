using mshtml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPF_WYSIWYG_HTML_Editor
{
    public static class Gui
    {
        public static WPFWebBrowser webBrowser;
        public static HtmlEditor htmlEditor;

        public static List<Items> RibbonComboboxFormatInitionalisation()
        {
            List<Items> list = new List<Items>();
            list.Add(new Items("<p>", "Paragraph"));
            list.Add(new Items("<h1>", "Heading 1"));
            list.Add(new Items("<h2>", "Heading 2"));
            list.Add(new Items("<h3>", "Heading 3"));
            list.Add(new Items("<h4>", "Heading 4"));
            list.Add(new Items("<h5>", "Heading 5"));
            list.Add(new Items("<h6>", "Heading 6"));
            list.Add(new Items("<address>", "Adress"));
            list.Add(new Items("<pre>", "Preformat"));
            return list;
        }

        public static List<string> RibbonComboboxFontSizeInitialisation()
        {
            List<string> items= new List<string>();

            for (int x = 1; x <= 7; x++)
            {
                items.Add(x.ToString());
            }
            return items;
        }

        public static void SettingsFontColor()
        {
            webBrowser.doc = webBrowser.webBrowser.Document as HTMLDocument;
            if (webBrowser.doc != null)
            {
                System.Windows.Media.Color col = DialogBox.Pick();
                string colorstr = string.Format("#{0:X2}{1:X2}{2:X2}", col.R, col.G, col.B);
                webBrowser.doc.execCommand("ForeColor", false, colorstr);
            }
        }

        public static void SettingsBackColor()
        {
            webBrowser.doc = webBrowser.webBrowser.Document as HTMLDocument;
            if (webBrowser.doc != null)
            {
                System.Windows.Media.Color col = DialogBox.Pick();
                string colorstr = string.Format("#{0:X2}{1:X2}{2:X2}", col.R, col.G, col.B);
                webBrowser.doc.body.style.background = colorstr;
            }
        }

        public static void SettingsAddLink()
        {
            using (Link link = new Link(webBrowser.doc))
            {
                link.ShowDialog();
            }
        }

        public static void SettingsAddImage()
        {
            using (Image image = new Image(webBrowser.doc))
            {
                image.ShowDialog();
            }

        }

        public static void RibbonButtonSave()
        {
            dynamic doc = webBrowser.doc;
            var htmlText = doc.documentElement.InnerHtml;
            string path = DialogBox.SaveFile();
            if (path != "")
                File.WriteAllText(DialogBox.SaveFile(), htmlText);
        }

        public static void RibbonComboboxFonts(ComboBox RibbonComboboxFonts)
        {
            var doc = webBrowser.webBrowser.Document as HTMLDocument;
            if (doc != null)
            {
                doc.execCommand("FontName", false, RibbonComboboxFonts.SelectedItem.ToString());
            }
        }

        public static void RibbonComboboxFontHeight(ComboBox RibbonComboboxFontHeight)
        {
            IHTMLDocument2 doc = webBrowser.webBrowser.Document as IHTMLDocument2;
            if (doc != null)
            {
                doc.execCommand("FontSize", false, RibbonComboboxFontHeight.SelectedItem);
            }
        }

        public static void RibbonComboboxFormat(ComboBox RibbonComboboxFormat)
        {
            string ID = ((Items)(RibbonComboboxFormat.SelectedItem)).Value;

            webBrowser.doc = webBrowser.webBrowser.Document as HTMLDocument;
            if (webBrowser.doc != null)
            {
                webBrowser.doc.execCommand("FormatBlock", false, ID);
            }
        }

        public static void EditWeb()
        {
            if (webBrowser.Visibility == Visibility.Visible) return;
            htmlEditor.Visibility = Visibility.Hidden;
            webBrowser.Visibility = Visibility.Visible;
            htmlEditor.Editor.SelectAll();

            webBrowser.doc.body.innerHTML = htmlEditor.Editor.Selection.Text;

        }

        public static void ViewHTML()
        {
            if (htmlEditor.Visibility == Visibility.Visible) return;
            htmlEditor.Visibility = Visibility.Visible;
            webBrowser.Visibility = Visibility.Hidden;

            htmlEditor.Editor.Selection.Text = webBrowser.doc.documentElement.innerHTML;
        }

        public static void newdocument()
        {
            webBrowser.newWb("");
        }

        public static void newdocumentFile()
        {
            webBrowser.newWb(DialogBox.SelectFile());    
        }


 

    }
}
