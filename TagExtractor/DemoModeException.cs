﻿using System;
using System.Runtime.Serialization;

namespace TagExtractor
{
	public class DemoModeException : Exception
	{
		public DemoModeException()
			: base() {
		}

		/// <summary>
		/// Create the exception with description
		/// </summary>
		/// <param name="message">Exception description</param>
		public DemoModeException(String message)
		 : base(message) {
		}

		/// <summary>
		/// Create the exception with description and inner cause
		/// </summary>
		/// <param name="message">Exception description</param>
		/// <param name="innerException">Exception inner cause</param>
		public DemoModeException(String message, Exception innerException)
		  : base(message, innerException) {
		}

		/// <summary>
		/// Create the exception from serialized data.
		/// Usual scenario is when exception is occured somewhere on the remote workstation
		/// and we have to re-create/re-throw the exception on the local machine
		/// </summary>
		/// <param name="info">Serialization info</param>
		/// <param name="context">Serialization context</param>
		protected DemoModeException(SerializationInfo info, StreamingContext context)
			: base(info, context) {
		}
	}
}
