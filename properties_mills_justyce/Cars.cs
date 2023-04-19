using System;
using System.Collections.Generic;
using System.Text;

namespace properties_mills_justyce
{
    class Cars
    {
        private string model;//field for model
        public string Model//creates Model properties for model field
        {
            get { return model; }//get method
            set { model = value; }//set method
        }

        public string Make//automatic properties for Make
        { get; set; }//get and set method
    }
}
