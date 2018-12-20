using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Deanery {
	public class Storage {
		#region
		private static Storage instance=null;

		private Storage()
		{
		}

		public static Storage Instance
		{
			get
			{
				if (instance==null)
				{
					instance = new Storage();
				}
				return instance;
			}
		}
		#endregion
		
		public ConcurrentDictionary<int, Document> storage;
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
		
//		public int AddDoc(Document document) {
//			storage.TryAdd(document.Id, document);
//			return document.Id;
//		}
//
//		public Document RemoveDoc(int id) {
//			Document document = new Document();
//			storage.TryRemove(id, out document);
//			return document;
//		}

//		public bool CheckDone(int id) {
//			Document document = new Document();
//			storage.TryGetValue(id, out document);
//			return document.isDone;
//		}

//		public void SetDone(int id) {
//			Document document = new Document();
//			storage.TryGetValue(id, out document);
//			document.isDone = true;
//			//storage.TryUpdate(id, document, newdocunment )
//		}
	}
}