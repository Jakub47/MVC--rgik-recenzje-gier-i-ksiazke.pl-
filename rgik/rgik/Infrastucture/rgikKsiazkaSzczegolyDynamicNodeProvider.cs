using MvcSiteMapProvider;
using rgik.DAL;
using rgik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rgik.Infrastucture
{
    public class rgikKsiazkaSzczegolyDynamicNodeProvider : DynamicNodeProviderBase
    {
        private rgikContext db = new rgikContext();

        public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode nodee)
        {
            var returnValue = new List<DynamicNode>();

            foreach (Ksiazka ksiazka in db.Ksiazka)
            {
                DynamicNode node = new DynamicNode();
                node.Title = ksiazka.NazwaKsiazki;
                node.Key = "Gra_" + ksiazka.KsiazkaId;
                node.ParentKey = "Gatunek_" + ksiazka.GatunekId;
                node.RouteValues.Add("id", ksiazka.KsiazkaId);
                returnValue.Add(node);
            }
            return returnValue;
        }
    }
}