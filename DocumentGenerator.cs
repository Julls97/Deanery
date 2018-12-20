using System;
using System.Collections.Generic;

namespace Deanery {
	public static class DocumentGenerator {
		private static int id = 0;
		private static Random random = new Random();
		private const int MaxCount = 3;

		public static Document Next() {
			Document doc = new Document();
			doc.Id = id++;
			doc.DocType = (Document.DocTypes) random.Next(1, Document.DocTypeCount);
			doc.ComplicationType = (Document.ComplicationTypes) random.Next(1, Document.ComplicationTypesCount);
			return doc;
		}

		public static List<Document> NextList() {
			List<Document> documents = new List<Document>();
			int count = random.Next(1, MaxCount);
			for (int i = 0; i < count; i++)
				documents.Add(Next());

			return documents;
		}
	}
}