using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class SicknessCheck : ActionTask {
        public BBParameter<float> sickness = 0;
        public BBParameter<float> speed = 2;
        public float sickCheck = 0f;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			EndAction(true);
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
            sickness.value += sickCheck * Time.deltaTime;
			if (sickness.value > 5f)
			{
				speed = 0;
			}

        }

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}