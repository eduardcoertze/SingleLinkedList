using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleLinkedList
{
    class SLinkedLists
    {
        //variable/object declarations
        CustomNode head;
        String data;
        int nodeCount = 0;
        CustomNode current;

        //method allowing users to append to the Singly LinkedList
        public void append(string data)
        {
            //if list is empty
            if (head == null)
            {
                head = new CustomNode(data);
                nodeCount++;
                return;
            }

            current = head;

            //when list is not empty
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = new CustomNode(data);
            nodeCount++;

        }

        //method allowing users to prepend to the singly LinkedList
        public void prepend(string data)
        {
            //when the list head is empty
            if (head == null)
            {
                head = new CustomNode(data);
                nodeCount++;
            }
            else
            {
                //setting the new head
                CustomNode newHead = new CustomNode(data);
                nodeCount++;
                newHead.Next = head;
                head = newHead;
            }
        }

        //method allowing users to delete a Node and it's data from a Singly LinkedList
        public void deteleWithData(string data)
        {
            //Check if the list is empty
            if (head == null)
            {
                MessageBox.Show("The list is empty, cannot delete data");
                return;
            }

            //deleting head data

            if (head.data.Equals(data))
            {
                head = head.Next;
            }

            //walking the list
            current = head;

            while (current.Next != null)
            {
                if (current.data.Equals(data))
                {
                    current.Next = current.Next.Next;
                    MessageBox.Show("Data Node" + data + " deleted");
                }

                current = current.Next;
            }

            //if the data isn't deleted
            MessageBox.Show("Could not delete data , data not present in list");
        }

        //method allowing users to find a perticular node with data,
        //and insert a new node directly after that node in a LinkedList 
        public void insertAfter(string nodeData, string searchData)
        {
            //cheching if the list is empty
            if (head == null)
            {
                MessageBox.Show("There is no list");
            }
            //if the list isn't null
            if (head.data.Equals(searchData))
            {
                CustomNode insertNode = new CustomNode(nodeData);
                insertNode.Next = head.Next;
                head.Next = insertNode;
            }

            current = head;

            while (current.Next != null)
            {
                current = current.Next;
                //if statment to insert the new data after the node
                if (current.data.Equals(searchData))
                {
                    CustomNode insertNode = new CustomNode(nodeData);
                    insertNode.Next = current.Next;
                    current.Next = insertNode;
                }


            }


        }

        public void replaceNode(string data, string replacement)
        {
            //if statement to check if head is empty
            if (head == null)
            {
                return;
            }

            //checking if head constains data
            if (head.data.Contains(data))
            {
                string replaceString = head.data.Replace(data, replacement);
                head.data = replaceString;


            }

            current = head;

            while (current.Next != null)
            {
                current = current.Next;
                if (current.data.Contains(data))
                {
                    string replaceString = current.data.Replace(data, replacement);
                    current.data = replaceString;
                }
            }

        }

        //method to show the the next node in the Singly linked list
        public List<string> showNext()
        {
            List<string> nextlist = new List<string>();
            current = head;

            nextlist.Add(current.data);

            while (current.Next != null)
            {
                nextlist.Add(current.Next.data);
                current = current.Next;
            }
            return nextlist;
        }
    }

}
