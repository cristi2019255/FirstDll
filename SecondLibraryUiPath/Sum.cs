using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using System.ComponentModel;

namespace SecondLibraryUiPath
{
    public class Sum : CodeActivity
    {
        [Category("Input")]
        int a { get; set; }

        [Category("Input")]
        int b { get; set; }

        [Category("Output")]
        int c { get; set; }


        protected override void Execute(CodeActivityContext context)
        {
            c = a + b;       
        }
    }
}
