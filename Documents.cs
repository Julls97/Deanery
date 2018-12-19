namespace Deanery {
	public class Documents {
		public enum DocTypes {
			// на подпись, на обработку и тд
		}
		public enum ComplicationTypes {
			easy, medium, hard
		}

		public DocTypes DocType;
		public ComplicationTypes ComplicationType;
	}
}