using System.Collections.Generic;
using System.Threading;

namespace Deanery {
	public class Worker {
		public enum EfficiencyTypes {
			slow = 3,
			medium = 2,
			fast = 1
		}

		public Thread Thread;

		public Worker() {
			Thread = new Thread(Action);
		}

		public EfficiencyTypes EfficiencyType;
		public List<Document.DocTypes> DocType;

		public void Action() {
//			while (true) {
//				
//			}
			
			foreach(var item in storage) {}
			
			Thread.Sleep((int) EfficiencyType * 1000);
			SetDone(id);
			
			

		}
		
		public void SetDone(int id) {
			Document document = new Document();
			Storage.Instance.storage.TryGetValue(id, out document);
			document.isDone = true;
			//storage.TryUpdate(id, document, newdocunment )
		}
	}
}