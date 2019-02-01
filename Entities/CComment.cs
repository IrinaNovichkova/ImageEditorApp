using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    public class CComment
    {
        public CUser Owner { get; }
        public DateTime Date { get; }
        public String Text { get; }

        public CComment(CUser user, String text, DateTime date)
        {
            Owner = user;
            Text = text;
            Date = date;
        }
    }
}
