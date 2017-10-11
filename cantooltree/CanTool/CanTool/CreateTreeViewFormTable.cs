﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data; 
namespace CanTool
{
    public class CreateTreeViewFormTable 
    {
        private static Dictionary<int, List<TreeNode>> dic;

        public static void BuildTree(DataTable dt, TreeView treeView, Boolean expandAll,
            string displayName, string nodeId, string parentId)
        {
            // Clear the TreeView if there are another datas in this TreeView
            treeView.Nodes.Clear();

            dic = new Dictionary<int, List<TreeNode>>();

            TreeNode node = null;

            foreach (DataRow row in dt.Rows)
            {
                // Restore each record into a TreeNode
                node = new TreeNode(row[displayName].ToString());
                node.Tag = row[nodeId];

                // The parentId of the TreeView's root is DBNull.Value in the DataTable
                // So if the parentId is a DBNull.Value, then it is the root
                // Otherwise it is only a common TreeNode 
                if (row[parentId] != DBNull.Value)
                {
                    int _parentId = Convert.ToInt32(row[parentId]);

                    // If there's exists a List<TreeNode> was identified by this _parentId
                    // Then we need put this node into this identified List<TreeNode>
                    if (dic.ContainsKey(_parentId))
                    {
                        dic[_parentId].Add(node);
                    }
                    else
                    {
                        // Otherwise
                        // We will Add a new record into the Dictionary<int, List<TreeNode>>
                        dic.Add(_parentId, new List<TreeNode>());

                        // Then put this node into the new List<TreeNode>
                        dic[_parentId].Add(node);
                    }
                }
                else
                {
                    // Take this node into the place of the TreeView's root
                    treeView.Nodes.Add(node);
                }
            }

            // After collect and identify each collection with their parentId
            // We will go on building this tree with the founded root node
            SearchChildNodes(treeView.Nodes[0]);

            if (expandAll)
            {
                // Expand the TreeView
                treeView.ExpandAll();
            }
        }
        private static void SearchChildNodes(TreeNode parentNode)
        {
            if (!dic.ContainsKey(Convert.ToInt32(parentNode.Tag)))
            {
                // If there's no a identified collection by this parentId
                // We will do nothing and return directly
                return;
            }

            // Put the identified collection by this parentId into the tree as this node's children
            parentNode.Nodes.AddRange(dic[Convert.ToInt32(parentNode.Tag)].ToArray());

            // See these children nodes as parent nodes
            foreach (TreeNode _parentNode in dic[Convert.ToInt32(parentNode.Tag)].ToArray())
            {
                // Then go to find the identified collection by these id
                SearchChildNodes(_parentNode);
            }
        }
    }
}
