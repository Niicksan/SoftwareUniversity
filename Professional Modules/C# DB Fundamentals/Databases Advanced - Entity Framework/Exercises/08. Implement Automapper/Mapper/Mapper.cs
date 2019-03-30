using System;
using System.Collections;
using System.Linq;
using System.Reflection;

namespace AutoMapper
{
    public class Mapper
    {
        private object MapObject(object source, object dest)
        {
            foreach (var destProp in dest.GetType()
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(p => p.CanWrite))
            {
                var sourceProp = source.GetType()
                    .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                    .Where(p => p.Name == destProp.Name)
                    .FirstOrDefault();

                if (sourceProp != null)
                {
                    var sourceVelue = sourceProp.GetMethod.Invoke(source, new object[0]);

                    if (sourceVelue == null)
                    {
                        throw new ArgumentException(ExceptionUtils.NullableSourceValueGetMethod);
                    }

                    if (ReflectionUtils.IsPrimitive(sourceVelue.GetType()))
                    {
                        destProp.SetValue(dest, sourceProp.GetValue(source));

                        continue;
                    }

                    if (ReflectionUtils.IsGenericCollection(sourceVelue.GetType()))
                    {
                        if (ReflectionUtils.IsPrimitive(sourceVelue.GetType().GetGenericArguments()[0]))
                        {
                            var destinationCollection = sourceVelue;
                            destProp.SetMethod.Invoke(dest, new[] { destinationCollection });
                        }
                        else
                        {
                            var destColl = destProp.GetMethod.Invoke(dest, new object[0]);
                            var destType = destColl.GetType().GetGenericArguments()[0];

                            foreach (var destP in (IEnumerable)sourceVelue)
                            {
                                ((IList)destColl).Add(this.CreateMappedObject(destP, destType));
                            }
                        }
                    }
                    else if (ReflectionUtils.IsNonGenericCollection(sourceVelue.GetType()))
                    {
                        var destColl = (IList)Activator.CreateInstance(destProp.PropertyType,
                            new object[] { ((object[])sourceVelue).Length });

                        for (int i = 0; i < ((object[])sourceVelue).Length; i++)
                        {
                            destColl[i] = this.CreateMappedObject(
                                ((object[])sourceVelue)[i], destProp.PropertyType.GetElementType());
                        }

                        destProp.SetValue(dest, destColl);
                    }
                    else
                    {
                        destProp.SetValue(dest, this.CreateMappedObject(sourceProp.GetValue(source), destProp.PropertyType));
                    }
                } 
            }

            return dest;
        }

        private object CreateMappedObject(object source, Type type)
        {
            if (source == null || type == null)
            {
                throw new ArgumentException(ExceptionUtils.NullSourceValueOrReturnType);
            }

            var dest = Activator.CreateInstance(type);

            return MapObject(source, dest);
        }

        public TDest CreateMappedObject<TDest>(object source)
        {
            if (source == null)
            {
                throw new ArgumentException(ExceptionUtils.NullSource);
            }

            var dest = Activator.CreateInstance(typeof(TDest));

            return (TDest)MapObject(source, dest);
        }
    }
}