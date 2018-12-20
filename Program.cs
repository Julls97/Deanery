using System;
using System.Collections.Generic;
using System.Threading;

namespace Deanery {
	class Program {
		static void Main(string[] args) {
			Worker AN = new Worker(new List<Document.DocTypes>() {
				Document.DocTypes.signature,
				Document.DocTypes.expel,
				Document.DocTypes.print,
				Document.DocTypes.rehabilitation,
				Document.DocTypes.materialAssistance
			}, Worker.EfficiencyTypes.average);
			Worker BM = new Worker(new List<Document.DocTypes>() {
				Document.DocTypes.transfer,
				Document.DocTypes.retakeExam,
				Document.DocTypes.restorationStudent,
				Document.DocTypes.recoveryDocuments
			}, Worker.EfficiencyTypes.slow);

			Student Kate = new Student();
			Student Mikael = new Student();
			Student Sam = new Student();

			AN.Join();
			BM.Join();
		
			Kate.Join();
			Mikael.Join();
			Sam.Join();

			Console.WriteLine("Закончили упражнение");
		}
	}
}