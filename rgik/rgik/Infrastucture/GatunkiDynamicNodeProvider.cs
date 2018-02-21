using MvcSiteMapProvider;
using rgik.DAL;
using rgik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rgik.Infrastucture
{
    public class GatunkiDynamicNodeProvider : DynamicNodeProviderBase
    {
        private rgikContext db = new rgikContext();

        public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode nodee)
        {
            var returnValue = new List<DynamicNode>();

            foreach(Gatunek gatunek in db.Gatunek)
            {
                DynamicNode node = new DynamicNode();
                node.Title = gatunek.NazwaGatunku;
                node.Key = "Gatunek_" + gatunek.GatunekId;
                node.RouteValues.Add("nazwaGatunku", gatunek.NazwaGatunku);
                returnValue.Add(node);
            }
            return returnValue;
        }
    }
}