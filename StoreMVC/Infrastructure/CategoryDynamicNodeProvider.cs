using MvcSiteMapProvider;
using StoreMVC.DAL;
using StoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreMVC.Infrastructure
{
    public class CategoryDynamicNodeProvider : DynamicNodeProviderBase
    {
        private EquipmentContext db = new EquipmentContext();

        public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode nodee)
        {
            var returnValue = new List<DynamicNode>();
            foreach (Category category in db.Category)
            {
                DynamicNode node = new DynamicNode();
                node.Title = category.CategoryName;
                node.Key = "Category_" + category.CategoryId;               
                node.RouteValues.Add("categoryName", category.CategoryName);
                returnValue.Add(node);
            }

            return returnValue;
        }

    }
}