using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    class Ask
    {
        static private String[] questions = { "Dya like dahgs?", "Periwinkle blue?", "Protection?", "From what? Ze Germans?" };
        static public int i = 0;

        static public string[] Questions
        {
            get { return questions; }
        }
    }
}
