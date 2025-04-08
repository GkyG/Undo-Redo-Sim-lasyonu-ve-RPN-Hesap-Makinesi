using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPN_Hesap_Makinesi_ve_Undo_Redo_Simülasyonu
{
    public class Node
    {
        public string Data { get; set; }
        public Node Next { get; set; }
    }
    public class LinkedList
    {
        public Node head { get; private set; }

        public void Add(string data)
        {
            Node newNode = new Node() { Data = data };
            if (head == null)
                head = newNode;
            else
            {
                Node current = head;
                while (current.Next != null) 
                    current = current.Next;
                current.Next = newNode;
            }
        }
    }
}
