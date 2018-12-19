using System;

namespace Deanery {
	public class Lecturer : IRealObject{
		public Guid Id { get; set; }
		public enum LecturerCondition {Teach, Answer, Rest}
		public LecturerCondition Condition { get; set; }
		public string Name { get; set; }
		public Lecturer(Guid id, LecturerCondition condition) {
			Id = id;
			Condition = condition;
		}
	}
}