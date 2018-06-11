using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace Tree_s_and_Graphs
{
    public partial class MyTree : Form
    {
        public MyTree()
        {
            InitializeComponent();
        }

        Tree tree = new Tree();
        private void Create_btn_Click(object sender, EventArgs e)
        {
            InitNewElem();
            //рисует дерево
            Bitmap pic = new Bitmap(picture_tree.Width,picture_tree.Height);
            picture_tree.Image = tree.DrawNode(tree, pic);
        }

        private void InitNewElem()
        {
            int L = InsertData.Lines.Count();
            for (int i = 0; i < L; i++)
            {
                if (InsertData.Lines[i] != "")
                {
                    int k = Convert.ToInt32(InsertData.Lines[i]);
                    tree.Insert(Convert.ToInt32(InsertData.Lines[i]),picture_tree.Width/2,40);
                }
            }
        }
        private void Find_btn_Click(object sender, EventArgs e)
        {
            tree.Find(Convert.ToInt32(FindData.Text));
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {

        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void picture_tree_Click(object sender, EventArgs e)
        {

        }
    }
}
