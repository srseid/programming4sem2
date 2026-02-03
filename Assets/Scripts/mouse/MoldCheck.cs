using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class MoldCheck : ActionTask {
        public BBParameter<float> mold;
        //public BBParameter<float> sickness;
        //public BBParameter<float> speed;

        public float moldyTimer = -0.1f;
		public BBParameter<float> moldDuration;
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
            mold.value +=  Time.deltaTime;
			//if (mold.value > moldDuration.value)
			{
				//mold.value = mold.value;
			}

			
			//if(eaten)
			{
				//sickness.value = sickness.value + mold.value;
			}	

			//if(sickness.value >= 6f)
			{
				//speed.value == (0.1 * Time.deltaTime);
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