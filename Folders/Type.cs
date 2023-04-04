using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansApp.Folders
{
   public class Typep
    {
        public string ProductType { get; set; }

        public override string ToString()
        {
            return String.Format("type: {0}", ProductType);
        }
    }
}
