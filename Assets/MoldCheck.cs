using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class MoldCheck : ActionTask {
        public BBParameter<float> mold = 0f;
        public BBParameter<float> sickness = 0f;
        //public float speed = 2f;

        public float moldyTimer = -0.1f;
        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			//EndAction(true);
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
            mold.value += moldyTimer * Time.deltaTime;
			/*
			if(eaten)
			{
				sickness = sickness + mold.value;
			}	

			if(sickness > 6f)
			{
				speed = speed - (0.1 * Time.deltaTime);
			}
			*/
        }

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}