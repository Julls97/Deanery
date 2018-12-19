using System;
using System.Threading;

namespace Deanery {
	public class Student {
		public int Speed;

		public Thread Thread;

		public Student() {
			Thread = new Thread(Action);
		}

		public void Action() {
			while (!Documents.isDone) {
				Thread.Sleep(1000);
			}
			// уйти
		}
	}
}