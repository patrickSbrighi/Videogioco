using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Videogioco
{
    public class Campo
    {
        string _id;
        string _source;
        public Campo(string id, string source)
        {
            _id = id;
            _source = source;
        }

        public string Id
        {
            get
            {
                return Id;
            }
            set
            {
               if(value != "")
                {
                    _id = value;
                }
            }
        }

        public string Source
        {
            get
            {
                return _source;
            }
            set
            {
                if (value != "")
                {
                    _source = value;
                }
            }
        }
    }
}