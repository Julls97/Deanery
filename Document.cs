namespace Deanery {
	public class Document {
		public enum DocTypes {
			signature = 0,
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

		public const int DocTypeCount = 8;
		public const int ComplicationTypesCount = 3;
		public int Id;
		public DocTypes DocType;
		public ComplicationTypes ComplicationType;
		public bool isDone;
	}
}