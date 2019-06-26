using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net;
using Elasticsearch.Net.Utf8Json;

namespace Nest
{
	/// <summary>The built in internal serializer that the high level client NEST uses.</summary>
	internal class DefaultHighLevelSerializer : IElasticsearchSerializer, IInternalSerializerWithFormatter
	{

		public DefaultHighLevelSerializer(IJsonFormatterResolver formatterResolver) => FormatterResolver = formatterResolver;

		public IJsonFormatterResolver FormatterResolver { get; }

		public T Deserialize<T>(Stream stream)
		{
			if (stream == null || stream.CanSeek && stream.Length == 0) return default;
			return JsonSerializer.Deserialize<T>(stream, FormatterResolver);
		}

		public object Deserialize(Type type, Stream stream)
		{
			if (stream == null || stream.CanSeek && stream.Length == 0) return type.DefaultValue();

			return JsonSerializer.NonGeneric.Deserialize(type, stream, FormatterResolver);
		}

		public Task<T> DeserializeAsync<T>(Stream stream, CancellationToken cancellationToken = default)
		{
			if (stream == null || stream.CanSeek && stream.Length == 0) return Task.FromResult(default(T));
			return JsonSerializer.DeserializeAsync<T>(stream, FormatterResolver);
		}

		public Task<object> DeserializeAsync(Type type, Stream stream, CancellationToken cancellationToken = default)
		{
			if (stream == null || stream.CanSeek && stream.Length == 0) return Task.FromResult(type.DefaultValue());
			return JsonSerializer.NonGeneric.DeserializeAsync(type, stream, FormatterResolver);
		}

		public void Serialize<T>(T data, Stream stream, SerializationFormatting formatting = SerializationFormatting.None) =>
			JsonSerializer.Serialize(stream, data, FormatterResolver);

		public Task SerializeAsync<T>(T data, Stream stream, SerializationFormatting formatting = SerializationFormatting.None,
			CancellationToken cancellationToken = default
		) => JsonSerializer.SerializeAsync(stream, data, FormatterResolver);
	}
}