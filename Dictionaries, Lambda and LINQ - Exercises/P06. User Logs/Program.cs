using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06.User_Logs
{
    public class Program
    {
        public static void Main()
        {
            var users = new Dictionary<string, Dictionary<string, int>>(); //user -> ip -> count

            while (true)
            {
                String line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }
                string[] comandArgs = line.Split(' ');

                string name = comandArgs[2].Replace("user=", "");
                string ip = comandArgs[0].Replace("IP=", "");

                if (!users.ContainsKey(name))
                {
                    users.Add(name, new Dictionary<string, int>());
                }
                if (!users[name].ContainsKey(ip))
                {
                    users[name].Add(ip, 0);
                }
                users[name][ip] = users[name][ip] + 1;
            }
            foreach (var user in users.OrderBy(x => x.Key))
            {
                Console.WriteLine(user.Key + ": ");

                StringBuilder sb = new StringBuilder();
                foreach (var ipAndCount in user.Value)
                {
                    sb.Append(ipAndCount.Key).Append(" => ").Append(ipAndCount.Value + ", ");
                }
                sb.Remove(sb.Length - 2, 2);
                sb.Append(".");
                Console.WriteLine(sb.ToString());
            }
        }
    }
}