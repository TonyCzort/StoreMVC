using MvcSiteMapProvider;
using StoreMVC.DAL;
using StoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreMVC.Infrastructure
{
    public class EquipmentDetailsDynamicNodeProvider : DynamicNodeProviderBase
    {
        private EquipmentContext db = new EquipmentContext();

        public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode nodee)
        {
            var returnValue = new List<DynamicNode>();

            foreach (Equipment equipment in db.AllEquipment)
            {
                DynamicNode node = new DynamicNode();
                node.Title = equipment.Title;
                node.Key = "Equipment_" + equipment.EquipmentId;
                node.ParentKey = "Category_" + equipment.CategoryId;
                node.RouteValues.Add("id", equipment.EquipmentId);
                returnValue.Add(node);
            }

            return returnValue;
        }

    }
}