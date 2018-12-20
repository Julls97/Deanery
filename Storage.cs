using System.Collections.Concurrent;

namespace Deanery {
	public class Storage {
		#region

		private static Storage instance = null;

		private Storage() {
		}

		public static Storage Instance {
			get {
				if (instance == null) 
					instance = new Storage();
				return instance;
			}
		}

		#endregion

		public ConcurrentDictionary<int, Document> storage = new ConcurrentDictionary<int, Document>();
		public const int MaxStudentsCount = 5;
		public int curStudentsCount;

		public bool CanComeIn() {
			return curStudentsCount < MaxStudentsCount;
		}

		public void ComeIn() {
			curStudentsCount++;
		}

		public void ComeOut() {
			curStudentsCount--;
		}
	}
}