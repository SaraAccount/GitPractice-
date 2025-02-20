using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TREE
{
    internal class BinNode<T>
    {
       
        private BinNode<T> left;
        private  T value;
        private BinNode<T> right;
        public BinNode(T value)
        {
            this.value = value;
            this.left = null;
            this.right = null;
        }
        public BinNode( BinNode<T> left,T value, BinNode<T> right)
        {
            this.value = value;
            this.left = left;
            this.right = right;
        }
        public T GetValue() { return value; }
        public BinNode<T> GetLeft (){ return left; }
        public BinNode<T> GetRight (){ return right; }
<<<<<<< HEAD
=======
        public void SetValue2(T value) { this.value = value;}
>>>>>>> 31fcae4e7e24e5af5a47797227564469504bd19e
        public void SetLeft(BinNode<T> left) { this.left = left;}
        public void SetRight(BinNode<T> right) { this.right = right;}

        
    }
}
