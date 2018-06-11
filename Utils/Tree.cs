using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Utils
{
    public class Tree
    {
        public int? Data { get; private set; }
        public Tree Left { get; set; }
        public Tree Right { get; set; }
        public Tree Parent { get; set; }
        public int x, y;
        public Bitmap bitmap;
        public Graphics g;
        public Pen MyPen = new Pen(Color.Black,2);
        public SolidBrush MyBrush;
        public Font MyFont = new Font("Arial",10);
        const int step = 10;
        const int dh = 3;



        public void Insert(int data, int NewX, int NewY)
        {
            if (Data == null || Data == data)
            {
                this.x = NewX;
                this.y = NewY;
                Data = data;
                return;
            }
            if (Data > data)
            {
                if (Left == null)
                    Left = new Tree();
                Insert(data, Left, this, this.x + step, this.y - dh * step);
            }
            if (Data < data)
            {
                if (this.Right == null)
                    this.Right = new Tree();
                Insert(data, Right, this, this.x - step, this.y - dh * step);
            }
        }
        private void Insert(int data, Tree node, Tree parent, int NewX, int NewY)
        {
            if (node.Data == null || node.Data == data)
            {
                node.Data = data;
                this.x = NewX;
                this.y = NewY;
                node.Parent = parent;
                return;
            }
            if (node.Data > data)
            {
                if (node.Left == null)
                    node.Left = new Tree();
                Insert(data, node.Left, node, this.x - step, this.y + dh * step);
            }
            if (node.Data < data)
            {
                if (node.Right == null)
                    node.Right = new Tree();
                Insert(data, node.Right, node, this.x - step, this.y + dh * step);
            }
        }
        public Tree Find(int data)
        {
            if (Data == data) return this;
            if (Data > data)
            {
                return Find(data, Left);
            }
            return Find(data, Right);
        }
        private Tree Find(int data, Tree node)
        {
            if (node == null) return null;
            if (node.Data == data) return node;
            if (Data > data)
            {
                return Find(data, node.Left);
            }
            return Find(data, node.Right);
        }
        public Bitmap DrawNode(Tree p, Bitmap pic)
        {
            
            using (g = Graphics.FromImage(pic))
            {
                int R = 12;
                MyPen.Color = Color.Black;
                if (p.Left != null)
                    g.DrawLine(MyPen, p.x, p.y, p.Left.x, p.Left.y);
                if (p.Right != null)
                    g.DrawLine(MyPen, p.x, p.y, p.Right.x, p.Right.y);
                // if (p.visit)
                if (true)
                    MyBrush = (SolidBrush)Brushes.Yellow;
                else
                    MyBrush = (SolidBrush)Brushes.LightYellow;
                g.FillEllipse(MyBrush, p.x - R, p.y - R, 2 * R, 2 * R);
                g.DrawEllipse(MyPen, p.x - R, p.y - R, 2 * R, 2 * R);
                string s = Convert.ToString(p.Data);
                SizeF size = g.MeasureString(s, MyFont);

                g.DrawString(s, MyFont, Brushes.Black,p.x - size.Width / 2, p.y - size.Height / 2);
                if (p.Left != null)
                    DrawNode(p.Left,pic);
                if (p.Right != null)
                    DrawNode(p.Right,pic);
            }
            return pic;
        }


    }
}
