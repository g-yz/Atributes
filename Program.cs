using System;
using System.Reflection;
using System.Text;

namespace Marketplace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My team");
            var account = new Baguette();

            Display(account);
        }

        public static void Display(object obj)
        {
            StringBuilder sb = new StringBuilder();
            Type type = obj.GetType();
            foreach (PropertyInfo propertyInfo in type.GetProperties())
            {
                foreach (object ob in propertyInfo.GetCustomAttributes())
                {
                    if (ob is TabAttribute)
                    {
                        var myFieldAndProperty = ob as TabAttribute;
                        sb.Append(myFieldAndProperty.tab);
                    }
                    if (ob is VersionAttribute)
                    {
                        var myFieldAndProperty = ob as VersionAttribute;
                        sb.Append("Version: " + myFieldAndProperty.version + " ");
                    }
                }
                sb.Append("Property Name: " + propertyInfo.Name + "\tValue: " + propertyInfo.GetValue(obj) + "\n");
            }
            Console.WriteLine(sb);
        }
    }
}
