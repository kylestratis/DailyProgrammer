using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _193E___Acronym_Expander
{
    class AcroDict
    {
        private Dictionary<string, string> _acronyms;
        public Dictionary<string, string> Acronyms
        {
            get { return _acronyms; }
        }


        public AcroDict()
        {
            _acronyms.Add("lol", "laugh out loud");
            _acronyms.Add("dw", "don't worry");
            _acronyms.Add("hf", "have fun");
            _acronyms.Add("gg", "good game");
            _acronyms.Add("brb", "be right back");
            _acronyms.Add("g2g", "got to go");
            _acronyms.Add("wtf", "what the fuck");
            _acronyms.Add("wp", "well played");
            _acronyms.Add("gl", "good luck");
            _acronyms.Add("imo", "in my opinion");
        }

        public AcroDict(string csvTitle)
        {
            //TODO: Call dptools to open a CSV, load it into _acronyms
        }
    }
}
