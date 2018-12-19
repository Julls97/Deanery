namespace Deanery {
	public class Documents {
		public enum DocTypes {
			// на подпись, на обработку и тд
		}

		public enum ComplicationTypes {
			easy = 1,
			medium = 2,
			hard = 3
		}

		public DocTypes DocType;
		public ComplicationTypes ComplicationType;
		public static bool isDone;
	}
}