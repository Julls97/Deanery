using System;
using System.Collections.Generic;
using System.Threading;

namespace Deanery {
	public class Student {
		public int Speed;
		public List<Document> Documents;
		public Thread Thread;

		public Student() {
			Documents = DocumentGenerator.NextList();
			Thread = new Thread(Action);
			Thread.Start();
		}
		public void Join() {
			Thread.Join();
		}


		public void Action() {
			while (!Storage.Instance.CanComeIn());
			Storage.Instance.ComeIn();

			foreach (var item in Documents)
				AddDoc(item);


			while (Documents.Count != 0) {
				for (var i = 0; i < Documents.Count; i++) {
					var id = Documents[i].Id;
					if (CheckDone(id)) {
						Documents.Remove(Documents[i]);
						RemoveDoc(id);
						Console.WriteLine(id + " документ забрал.");
					}
				}
				//foreach (var item in Storage.Instance.storage) {
					//Console.WriteLine(item.Value);
				//}
				Console.WriteLine("Ждем-с.");
				Thread.Sleep(2000);
			}

			Storage.Instance.ComeOut();
		}

		public void AddDoc(Document document) {
			Storage.Instance.storage.TryAdd(document.Id, document);
//			return document.Id;
		}

		public void RemoveDoc(int id) {
			Document document = new Document();
			Storage.Instance.storage.TryRemove(id, out document);
//			return document;
		}

		public bool CheckDone(int id) {
			Document document = new Document();
			Storage.Instance.storage.TryGetValue(id, out document);
			return document.isDone;
		}
	}
}