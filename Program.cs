using System;
using System.Collections.Generic;
using System.Threading;

namespace Deanery {
	class Program {
		static void Main(string[] args) {
			Worker A1 = new Worker(new List<Document.DocTypes>() {
				Document.DocTypes.signature,
				Document.DocTypes.expel,
				Document.DocTypes.print
			}, Worker.EfficiencyTypes.average);
			Worker A2 = new Worker(new List<Document.DocTypes>() {
				Document.DocTypes.transfer,
				Document.DocTypes.retakeExam,
				Document.DocTypes.restorationStudent
			}, Worker.EfficiencyTypes.slow);
			
			Worker A3 = new Worker(new List<Document.DocTypes>() {
				Document.DocTypes.recoveryDocuments,
				Document.DocTypes.rehabilitation,
				Document.DocTypes.materialAssistance
			}, Worker.EfficiencyTypes.fast);

			while (true) {
				var sleep = new Random().Next(2, 5);
				Thread.Sleep(1000 * sleep);
				Student student = new Student();
			}
		}
	}
}