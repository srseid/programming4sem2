using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class SicknessCheck : ActionTask {
        public BBParameter<float> sickness;
        public BBParameter<float> speed;
		public BBParameter<bool> poison;
       
		public MoldCheck moldScript;
		

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
            sickness.value += sickness.value + moldScript.mold.value;
			if (sickness.value >= 5f)
			{
				speed = 0.25f;
			}

            if (sickness.value >= 10f)
            {
                poison = true;
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