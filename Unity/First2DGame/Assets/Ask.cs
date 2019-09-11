using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    class Ask
    {

        private String[] questions = { "Dya like dahgs?", "Periwinkle blue?", "Protection?", "From what? Ze Germans?" };


        public string Questions
        {
            get { return questions[4]; }
        }

        public void Asking()
        {
            Random query = new Random();
            int asker = query.Next(questions.Length);
        }

    }
}
