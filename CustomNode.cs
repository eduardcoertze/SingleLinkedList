using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    //CustomNode Object Class
   class CustomNode
    {
        public CustomNode Next;
        public string data;

        //deafult constructor
        public CustomNode()
        {

        }

        //parameterized constructor 
        public CustomNode(string data)
        {
            this.data = data;
        }
    }
}
