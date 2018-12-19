using System;

namespace Deanery {
	public class Student : IRealObject{
		public Guid Id { get; set; }
		public enum StudentCondition {Answer}
		public StudentCondition Condition { get; set; }
		public string Name { get; set; }
		public Student (Guid id, StudentCondition condition) {
			Id = id;
			Condition = condition;
		}
	}
}