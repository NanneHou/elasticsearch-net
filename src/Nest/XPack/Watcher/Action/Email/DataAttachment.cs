﻿using System.Runtime.Serialization;
using Elasticsearch.Net;
using Elasticsearch.Net.Utf8Json;

namespace Nest
{
	[InterfaceDataContract]
	[ReadAs(typeof(DataAttachment))]
	public interface IDataAttachment : IEmailAttachment
	{
		[DataMember(Name = "format")]
		DataAttachmentFormat? Format { get; set; }
	}

	public class DataAttachment : IDataAttachment
	{
		public DataAttachmentFormat? Format { get; set; }
	}

	public class DataAttachmentDescriptor : DescriptorBase<DataAttachmentDescriptor, IDataAttachment>, IDataAttachment
	{
		DataAttachmentFormat? IDataAttachment.Format { get; set; }

		public DataAttachmentDescriptor Format(DataAttachmentFormat? format) => Assign(format, (a, v) => a.Format = v);
	}

	[StringEnum]
	public enum DataAttachmentFormat
	{
		[EnumMember(Value = "json")]
		Json,

		[EnumMember(Value = "yaml")]
		Yaml
	}
}
