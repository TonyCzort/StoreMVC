using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreMVC.Infrastructure
{
    public static class UrlHelpers
    {
        public static string CategoryPicturePath(this UrlHelper helper, string PictureCategoryName)
        {
            var CategoryPictureFolder = AppConfig.CategoryFolderTilde;
            var CategoryPictureLocation = Path.Combine(CategoryPictureFolder, PictureCategoryName);
            var categoryPictureTilde = helper.Content(CategoryPictureLocation);

            return categoryPictureTilde;
        }

        public static string PicturePath(this UrlHelper helper, string pictureName)
        {
            var PictureFolder = AppConfig.PictureFolderTilde;
            var PictureLocation = Path.Combine(PictureFolder, pictureName);
            var categoryPictureTilde = helper.Content(PictureLocation);

            return categoryPictureTilde;
        }

    }
}