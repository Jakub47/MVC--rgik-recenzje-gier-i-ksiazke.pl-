using MvcSiteMapProvider;
using rgik.DAL;
using rgik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rgik.Infrastucture
{
    public class rgikGrySzczegolyDynamicNodeProvider : DynamicNodeProviderBase
    {
        private rgikContext db = new rgikContext();

        public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode nodee)
        {
            var returnValue = new List<DynamicNode>();

            foreach(Gra gra in db.Gra)
            {
                DynamicNode node = new DynamicNode();
                node.Title = gra.NazwaGry;
                node.Key = "Gra_" + gra.GraId;
                node.ParentKey = "Gatunek_" + gra.GatunekId;
                node.RouteValues.Add("id", gra.GraId);
                returnValue.Add(node);
            }
            return returnValue;
        }
    }
}