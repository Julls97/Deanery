namespace Deanery {
	public class Behavior : IBehavior{
		public void Action() {
			// вести лекцию
		}

		public void OnMessage() {
			// 
		}
	}
	
	public class RestBehavior : IBehavior{
		public void Action() {
			// уйти отдыхать
		}

		public void OnMessage() {
			// 
		}
	}

	public class AnswerBehavior : IBehavior{
		public void Action() {
			// отвечать на вопрос
		}

		public void OnMessage() {
			// 
		}
	}

}