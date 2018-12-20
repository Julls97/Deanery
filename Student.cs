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
		}

		public void Action() {
			while (!Storage.Instance.CanComeIn()) ;
			Storage.Instance.ComeIn();
			List<int> ids = new List<int>();
			foreach (var item in Documents) {
				ids.Add(AddDoc(item));
			}

			while (ids.Count != 0) {
				Thread.Sleep(2000);
				for (var i = 0; i < ids.Count; i++) {
					var id = ids[i];
					if (CheckDone(id)) {
						ids.Remove(i);
						RemoveDoc(id);
					}
				}
			}
			Storage.Instance.ComeOut();
		}

		public int AddDoc(Document document) {
			Storage.Instance.storage.TryAdd(document.Id, document);
			return document.Id;
		}

		public Document RemoveDoc(int id) {
			Document document = new Document();
			Storage.Instance.storage.TryRemove(id, out document);
			return document;
		}
		
		public bool CheckDone(int id) {
			Document document = new Document();
			Storage.Instance.storage.TryGetValue(id, out document);
			return document.isDone;
		}
	}
}