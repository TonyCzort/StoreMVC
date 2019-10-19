using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace StoreMVC.Infrastructure
{
    public class AppConfig
    {
        private static string categoryFolderTilde = ConfigurationManager.AppSettings["CategoryFolder"];

        public static string CategoryFolderTilde
        {
            get
            {
                return categoryFolderTilde;
            }
        }

        private static  string pictureFolderTilde = ConfigurationManager.AppSettings["PictureFolder"];

        public static string PictureFolderTilde
        {
            get
            {
                return pictureFolderTilde;
            }
        }
    }
}