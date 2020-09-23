using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Item
    {
        private int _cost = 1;
        private string _name = " ";

        public virtual string GetName
        {
            set
            {
                _name = value;
            }
            get
            {
                return _name;
            }
        }

        public virtual int GetCost
        {
            set
            {
                _cost = value;
            }
            get
            {
                return _cost;
            }
        }
    }
}
