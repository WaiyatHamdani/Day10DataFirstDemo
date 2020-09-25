using Day10DatabaseFirstDemo.ASKING;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10DatabaseFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ASK a = new ASK();
            using(var context = new WaiyatEntities()){  //database name
                var user = new User()
                {
                    UserId = 1,
                    Username = "Waiyat",
                    Password = "Hamdani",
                    Email = "waiyat@gmail.com"

                };

                context.Users.Add(user);
                context.SaveChanges();
            }
        }
    }
}
