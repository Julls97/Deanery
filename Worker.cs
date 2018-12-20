using System.Collections.Generic;
using System.Threading;

namespace Deanery {
	public class Worker {
		public enum EfficiencyTypes {
			slow = 3,
			average = 2,
			fast = 1
		}

		public Thread Thread;

		public Worker() {
			Thread = new Thread(Action);
		}

		public EfficiencyTypes EfficiencyType;
		public List<Document.DocTypes> DocType;

		public void Action() {
			while (!Storage.Instance.storage.IsEmpty) {
				foreach (var item in Storage.Instance.storage) {
					if (DocType.Contains(item.Value.DocType)) { // забирает подходящий по типу док
						Thread.Sleep((int) EfficiencyType * 1000 * (int) item.Value.ComplicationType);
						SetDone(item.Key);
					}
				}
			}
		}
		
		public void SetDone(int id) {
			Document document = new Document();
			Storage.Instance.storage.TryGetValue(id, out document);
			document.isDone = true;
			//storage.TryUpdate(id, document, newdocunment )
		}
	}
}