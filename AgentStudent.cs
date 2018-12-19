using System;

namespace Deanery {
	public class AgentStudent : IAgent{
		public bool isStarted { get; set; }
		public Guid Id { get; set; }
		public IRealObject RealObject { get; set; }

		public AgentStudent(Guid id, Student realObject) {
			Id = id;
			RealObject = realObject;
		}

		public void start() {
			isStarted = true;
		}

		public void stop() {
			isStarted = false;
		}

		public void onMessage() {
			if (isStarted) {
				switch ((RealObject as Student).Condition) {
					case Student.StudentCondition.Answer: {
//						new MAS.Behaviors.ChiefsBehavior.HeadhunterBehavior().OnMessage(RealObject);
						break;
					}
				}
			}
		}

		public void action() {
			if (isStarted) {
				switch ((RealObject as Student).Condition) {
					case Student.StudentCondition.Answer: {
//						new MAS.Behaviors.ChiefsBehavior.HeadhunterBehavior().Action(RealObject);
						break;
					}
				}
			}
		}
	}
}