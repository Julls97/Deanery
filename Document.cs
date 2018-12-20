namespace Deanery {
	public class Document {
		public enum DocTypes {
			signature = 1,
			print,
			expel,
			transfer,
			retakeExam,
			recoveryDocuments,
			restorationStudent,
			rehabilitation,
			materialAssistance
		}

		public enum ComplicationTypes {
			easy = 1,
			medium = 2,
			hard = 3
		}

		public const int DocTypeCount = 10;
		public const int ComplicationTypesCount = 3;
		public int Id;
		public DocTypes DocType;
		public ComplicationTypes ComplicationType;
		public bool isDone = false;

		public override string ToString() {
			string s = "";
			s += "id is " + Id;
			s += " DocType is " + DocType;
			s += " ComplicationType is " + ComplicationType;
			return s;
		}
	}
}