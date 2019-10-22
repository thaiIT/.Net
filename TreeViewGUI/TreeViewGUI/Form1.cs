using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadTreeView();
        }

        void loadTreeView()
        {
            TreeNode root1 = new TreeNode();
            root1.Text = "new Root";

            TreeNode node1 = new TreeNode() { Text = "Nodes child" };
            root1.Nodes.Add(node1);

            TreeNode root2 = new TreeNode();
            root2.Text = "new Root 2";

            tvShow.Nodes.Add(root1);
            tvShow.Nodes.Add(root2);

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
