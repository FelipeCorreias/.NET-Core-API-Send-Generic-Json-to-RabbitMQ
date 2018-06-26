using System;
using System.Collections.Generic;
using System.Text;

namespace Fila.Common.Serializations
{
   public interface ISerializationService
    {
        byte[] ToByteArray<T>(T t);
        object FromByteArray(byte[] data);
    }
}
