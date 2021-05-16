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
            Id = id;
            Source = source;
        }

        public Campo() { }

        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != "")
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