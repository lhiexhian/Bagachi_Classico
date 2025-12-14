using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bagachi_Classico
{

    public static class sharedAppData
    {
        public static string conString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=datas;Integrated Security=True;Encrypt=False";
        public static bool guess { get; set; }
        public static bool keepChoice { get; set; }
        public static string winner { get; set; }
        public static int score { get; set; }
        public static int hscore { get; set; }

        public static int Id { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string Email { get; set; }
        public static string Bio { get; set; }
        public static bool IsActive { get; set; }
        public static int Wins { get; set; }
        public static int Loses { get; set; }
    }
}