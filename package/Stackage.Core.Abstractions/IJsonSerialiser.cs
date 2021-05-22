using System.IO;
using System.Threading.Tasks;

namespace Stackage.Core.Abstractions
{
   public interface IJsonSerialiser
   {
      string Serialise<T>(T value);

      T Deserialise<T>(string json);

      Task<T> DeserialiseAsync<T>(Stream json);
   }
}
