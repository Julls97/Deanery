using System;

namespace Deanery {
	public interface IAgent {
		bool isStarted { get; set; }
		Guid Id { get; set; }
		IRealObject RealObject{get;set;}
		void start();
		void stop();
		void onMessage();
		void action();
	}
}