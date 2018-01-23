using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Systems_Tester
{
    /// <summary>
    ///  Parent class for all life
    /// </summary>
    class life_form
    {
        public int age { get; set; }
        public bool is_female { get; set; }
        public List<char[]> genes_list { get; set; }
        public bool is_pregnant { get; set; }


        
    }
}
