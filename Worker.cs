using System;
using System.Collections.Generic;
using System.Threading;

namespace Deanery {
	public class Worker {
		public enum EfficiencyTypes {
			slow = 3,
			average = 2,
			fast = 1
		}

		public Thread thread;

		public Worker(List<Document.DocTypes> docType, EfficiencyTypes efficiencyType) {
			DocType = docType;
			EfficiencyType = efficiencyType;
			thread = new Thread(Action);
			thread.Start();
		}

		public void Join() { thread.Join();}

		public EfficiencyTypes EfficiencyType;
		public List<Document.DocTypes> DocType;

		public void Action() {
			while (true) {
				foreach (var item in Storage.Instance.storage) {
					if (!item.Value.isDone && DocType.Contains(item.Value.DocType)) {
						Console.WriteLine(item.Key + " документ в обработке, ждите.");
						int wait = (int) EfficiencyType * 1000 * (int) item.Value.ComplicationType;
						Thread.Sleep(wait);
						SetDone(item.Key);
						Console.WriteLine(item.Key + " документ готов. Заберите. Время выполнения " + wait/1000 + " мин.");
					}
				}
			}
		}

		public void SetDone(int id) {
			Document document = new Document();
			Storage.Instance.storage.TryGetValue(id, out document);
			document.isDone = true;
		}
	}
}