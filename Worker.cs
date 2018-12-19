using System.Threading;

namespace Deanery {
	public class Worker {
		public enum EfficiencyTypes {
			slow = 3,
			medium = 2,
			fast = 1
		}

		public enum DocTypes {
			// только на подпись и обработку
		}

		public Thread Thread;

		public Worker() {
			Thread = new Thread(Action);
		}

		public EfficiencyTypes EfficiencyType;
		public DocTypes DocType;

		public void Action() {
			// смотреть в хранилище подходящие документы
			Thread.Sleep((int) EfficiencyType * 1000);
			Documents.isDone = true;
		}
	}
}