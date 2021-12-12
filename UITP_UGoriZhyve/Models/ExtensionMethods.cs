using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace UITP_UGoriZhyve.Models
{
    static class ExtensionMethods
    {
        public static T DeepCopy<T>(this T self)
        {
            var obj = self;
            using (MemoryStream tempStream = new MemoryStream())
            {
                BinaryFormatter binFormatter = new BinaryFormatter(null,
                    new StreamingContext(StreamingContextStates.Clone));

                binFormatter.Serialize(tempStream, obj);
                tempStream.Seek(0, SeekOrigin.Begin);

                obj = (T)binFormatter.Deserialize(tempStream);
            }
            return obj;
        }
    }
}