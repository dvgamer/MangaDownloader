using System;
using System.Net;
using System.Text;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Manga.DlPlugins
{
    public class FindImage
    {
        //private WebClient client = new WebClient();
        //private String mangaAddress;
        //public String folderName;

        public FindImage()
        {
            
        }

        public String GetValue(String text, String ltrim, String rtrim)
        {
            String[] tmpString = Regex.Split(text, ltrim);
            if (tmpString.Length > 1) tmpString = Regex.Split(tmpString[1], rtrim);
            return tmpString[0];
        }

        public List<String> GetUrl(String text)
        {
            List<String> getUrl = new List<String>();
            String[] tmpUrl = Regex.Split(text, "http://");
            for (int uloop = 1; uloop < tmpUrl.Length; uloop++)
            {
                String[] split = tmpUrl[uloop].Split(new Char[] { ' ', '\'', '"', '\n', '\r', '\t' });
                getUrl.Add("http://" + split[0].Trim().ToString());
            }
            return getUrl;
        }
        
        public List<String> GetImage(String text)
        {
            List<String> imageName = new List<String>();
            String[] tmpImgs = Regex.Split(text, "<img");
            for (int sloop = 1; sloop < tmpImgs.Length; sloop++)
            {                
                String[] tmpString = Regex.Split(tmpImgs[sloop], "src=");
                tmpString = tmpString[1].Split(' ');
                String tmpImg = tmpString[0].Replace("\"", String.Empty);
                tmpImg = tmpImg.Replace("\'", String.Empty);
                imageName.Add(tmpImg);
            }
            return imageName;
        }
    }
}
