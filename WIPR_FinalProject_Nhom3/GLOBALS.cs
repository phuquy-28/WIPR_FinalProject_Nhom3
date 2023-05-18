using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIPR_FinalProject_Nhom3
{
    public class GLOBALS
    {
        public static int GlobalUserId { get; private set; } = 1;
        public static void SetGlobalUserId(int userId) { GlobalUserId = userId; }
        public static int role = 0;
    }
}
