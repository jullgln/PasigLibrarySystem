using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasigLibrarySystem.DATABASES
{
    public class book_data
    {
        public static string currentbookid { get; set; }
        public static string currentbookname { get; set; }
        public static string currentbookauthor { get; set; }
        public static string currentgenre { get; set; }
        public static string currentpublishdate { get; set; }
        public static string currentpublisher { get; set; }
        public static string currentpagecount { get; set; }
        public static string currentISBN { get; set; }
        public static string currentstatus { get; set; }
        public static string currentshelfnumber { get; set; }
        public static string currentabstract { get; set; }
    }
    public class status_data
    {
        public static string statusID { get; set; }
    }
}
