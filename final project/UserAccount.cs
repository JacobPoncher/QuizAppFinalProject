using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
     public class UserAccount
    {
        

        public string?  UserName { get; set; }
        public string? Password { get; set; }
        public int LastScore { get; set; }

        public string?  Scores { get; set; }

        public int Id { get;set; }

        public override string ToString()
        {
            return $"{UserName}";
        }

    }
}
