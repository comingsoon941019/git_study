using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Data_Struct
{
    public class BinaryTreeNode<T>
    {
        public T tData { get; set; }
        public BinaryTreeNode<T> btnLeft { get; set; }
        public BinaryTreeNode<T> btnRight { get; set; }
        public BinaryTreeNode(T tdata)
        {
            this.tData = tdata;
        }
    }

    public class Tree_Soon<T> 
    {
        private BinaryTreeNode<T> root = null;
        private Comparer<T> comparer = Comparer<T>.Default;
        private int result;

        public void Insert(T data)
        {
            if (root == null)
            {
                root = new BinaryTreeNode<T>(data);
                return;
            }
            else
            {
                BinaryTreeNode<T> node = new BinaryTreeNode<T>(data);

                //result > 0  : X가 y 보다 큼
                //result < 0  : x가 y 보다 작음
                // 0 : x,y 같음

                result = comparer.Compare(root.tData, data);

                if (result > 0)
                {
                    if (node.btnLeft == null)
                    {
                        root.btnLeft = new BinaryTreeNode<T>(data);
                        return;
                    }
                    node = node.btnLeft;
                }
                else
                {
                    if (node.btnRight == null)
                    {
                        node.btnRight = new BinaryTreeNode<T>(data);
                        return;
                    }
                    node = node.btnRight;
                }
            }
        }





    }

    public class Node
    {
        public int m_data { get; set; }
        public Node ParentNode { get; set; }
        public List<Node> ChildrenContainer { get; set; }

        public Node(int data)
        {
            m_data = data;
        }
    }

    // Height, depth
    public class Tress_P<T>
    {
        
        public int GetDepth(Node depthNode)
        {
            int depth = 0;

            while (depthNode.ParentNode != null)
            {
                depth++;

                depthNode = depthNode.ParentNode;
            }

            return depth;
        }

        public int GetHeight(Node HNode)
        {
            int Height = 0;

            Height = GetDepth(HNode);


            while()
            {
                foreach (Node item in HNode.ChildrenContainer)
                {
                                
                }

            }

            return Height;
        }

    }

}