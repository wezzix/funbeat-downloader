using System;
using System.Linq.Expressions;
using System.Reflection;

namespace MK.Funbeat.Utilities
{
    public static class ExpressionExtensions
    {
        /// <summary>
        /// Converts an expression into a <see cref="MemberInfo" />.
        /// </summary>
        /// <param name="expression">The expression to convert.</param>
        /// <returns>The member info.</returns>
        public static MemberInfo GetMemberInfo(this Expression expression)
        {
            var lambda = (LambdaExpression)expression;

            MemberExpression memberExpression;
            if (lambda.Body is UnaryExpression)
            {
                var unaryExpression = (UnaryExpression)lambda.Body;
                memberExpression = (MemberExpression)unaryExpression.Operand;
            }
            else
                memberExpression = (MemberExpression)lambda.Body;

            return memberExpression.Member;
        }

        public static string GetMemberName(this Expression expression)
        {
            return expression.GetMemberInfo().Name;
        }

        /// <summary>
        /// Gets PropertyInfo for the specified property on defined on the source type.
        /// </summary>
        /// <param name="source">The source where the property is defined.</param>
        /// <param name="propertyLambda">Lambda defining the property, like so: o =&gt; o.MyProperty</param>
        public static PropertyInfo GetPropertyInfo<TSource, TProperty>(
            this TSource source,
            Expression<Func<TSource, TProperty>> propertyLambda)
        {
            return GetPropertyInfo(propertyLambda);
        }

        public static string PropertyNameOf<TSource, TProperty>(
            this TSource source,
            Expression<Func<TSource, TProperty>> propertyLambda)
        {
            return source.GetPropertyInfo(propertyLambda).Name;
        }

        public static PropertyInfo GetPropertyInfo<TSource, TProperty>(
            Expression<Func<TSource, TProperty>> propertyLambda)
        {
            var type = typeof(TSource);

            var member = propertyLambda.Body as MemberExpression;
            if (member == null)
            {
                throw new ArgumentException(
                    string.Format(
                        "Expression '{0}' refers to a method, not a property.",
                        propertyLambda));
            }

            var propInfo = member.Member as PropertyInfo;
            if (propInfo == null)
            {
                throw new ArgumentException(
                    string.Format(
                        "Expression '{0}' refers to a field, not a property.",
                        propertyLambda));
            }

            if (type != propInfo.ReflectedType &&
                !type.IsSubclassOf(propInfo.ReflectedType))
            {
                throw new ArgumentException(
                    string.Format(
                        "Expresion '{0}' refers to a property that is not from type {1}.",
                        propertyLambda, type));
            }
            return propInfo;
        }

        /// <summary>
        /// Executes a method if the object is not it's default value (null for reference types).
        /// It's the same as doing: o == null ? null : o.SomeProperty
        /// </summary>
        public static TResult IfNotNull<T, TResult>(this T o, Func<T, TResult> method)
        {
            if (o == null || o.Equals(default(T)))
                return default(TResult);
            return method(o);
        }
    }
}