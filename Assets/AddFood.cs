using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class AddFood : ActionTask {
		public GameObject spawn;
		public float minx = -5f;
		public float maxx = 5f;
		public float minz = -5f;
		public float maxz = 5f;
		public float ySpawn = 0;
		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit() {
           // float randX = Random.Range(minx, maxx);
            //float randZ = Random.Range(minz, maxz);
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
			//Vector3 SpawnPos = new Vector3(randx, ySpawn, randZ);
			//Instantiate(spawn, SpawnPos, Quaternion.identity);
		}

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}