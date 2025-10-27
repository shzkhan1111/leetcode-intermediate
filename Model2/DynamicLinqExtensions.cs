using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Model2
{
    public static class DynamicLinqExtensions
    {
        public static IQueryable<T> OrderBy<T>(this IQueryable<T> source , string propertyName, bool ascending= true)
        {
            if (source == null) throw new ArgumentException(nameof(source));
            if (string.IsNullOrEmpty(propertyName)) throw new ArgumentException(nameof(propertyName));

            // 1️ Create a parameter "u"
            var parameter = Expression.Parameter(typeof(T), "u");
            //2 create a property on that param u.propertyname
            var property = Expression.Property(parameter, propertyName);
            //3 create a lamda expression
            var lamda = Expression.Lambda(property, parameter);
            //4 call order by 
            string methodName  = ascending ? "OrderBy" : "OrderByDescending";
            var result = typeof(Queryable).GetMethods()
          .First(m => m.Name == methodName
                   && m.GetParameters().Length == 2)
          .MakeGenericMethod(typeof(T), property.Type)
          .Invoke(null, new object[] { source, lamda });
            if (result is null) throw new Exception("Result is null");

            return (IQueryable<T>)result;


        }
    }
}
