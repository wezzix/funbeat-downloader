using System;
using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;

namespace MK.Funbeat.Utilities
{
    public static class HtmlNodeExtensions
    {
        public static IEnumerable<HtmlNode> WithClassEqualTo(this IEnumerable<HtmlNode> nodes, string className)
        {
            return nodes.Where(n => HasClassEqualTo(n, className));
        }

        public static HtmlNode FirstParent(this HtmlNode node, Func<HtmlNode, bool> predicate)
        {
            return node.ParentNode == null || predicate(node.ParentNode)
                ? node.ParentNode
                : node.ParentNode.FirstParent(predicate);
        }

        public static bool HasClassEqualTo(this HtmlNode o, string className)
        {
            return o.GetAttributeValue("class", "").Equals(className);
        }
    }
}