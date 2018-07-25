using System;

namespace CSharpPracticeSolution.IEquatable
{
    public class Product : IEquatable<Product>
    {
        
        public Product(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public bool Equals(Product other)
        {
            if(other == null)
            {
                return false;
            }
           return StringComparer.Ordinal.Equals(Name, other.Name);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj as Product);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
