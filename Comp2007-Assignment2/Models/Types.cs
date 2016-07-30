using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;

namespace Comp2007_Assignment2.Models
{
    public class Types
    {
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        public Types(){
            
            }

        /// <summary>
        /// This Constructor takes one parameter - Name
        /// </summary>
        /// <param name="Name"></param>
        public Types(string Name){
            this.Name = Name;       
            }
        public int TypeID { get; set; }
        public string Name { get; set; }
    }
}