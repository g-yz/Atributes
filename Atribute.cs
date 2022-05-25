namespace Marketplace
{
    using System;
    using System.Reflection;
    using System.Web;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property, AllowMultiple = true)]
    public class TabAttribute : Attribute
    {
        public string tab;
        public TabAttribute()
        {
            this.tab = "\t";
        }
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
    public class VersionAttribute : Attribute
    {
        public string name;
        public double version;

        public VersionAttribute(double version)
        {
            this.version = version;
        }
    }
}
