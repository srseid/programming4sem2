using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class MoveAndRotateTowards : ActionTask {
		public Transform target;
		public BBParameter<float> moveSpeed = 5f;
		public BBParameter<float> turnSpeed = 180f;
		public BBParameter<float> stoppingDistance = 0.1f;

		//private Blackboard agentBlackboard;

		//public float timeRemaining = 40f;
		//private bool timerIsRunning = false;

		protected override string OnInit() {
			//agentBlackboard = agent.GetComponent<Blackboard>();
			////timerIsRunning = true;

			//if (agentBlackboard != null) return null;
			//else return $"MoveAndRotateTowards - {agent.name}: Unable to get Blackboard reference!";

			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			//moveSpeed = agentBlackboard.GetVariableValue<float>("moveSpeed");
			//turnSpeed = agentBlackboard.GetVariableValue<float>("turnSpeed");
			//stoppingDistance = agentBlackboard.GetVariableValue<float>("stoppingDistance");
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
			Vector3 direction = target.position - agent.transform.position;
			Quaternion rotation = Quaternion.LookRotation(direction);

            agent.transform.SetPositionAndRotation(
                agent.transform.position + moveSpeed.value * Time.deltaTime * agent.transform.forward,
                Quaternion.RotateTowards(agent.transform.rotation, rotation, turnSpeed.value * Time.deltaTime)
                );

            if (Vector3.Distance(agent.transform.position, target.position) < stoppingDistance.value)
            {
                EndAction(true);
            }

   //         if (timerIsRunning)
			//{
			//	if(timeRemaining > 0)
			//	{
			//		timeRemaining -= Time.deltaTime;
			//		Debug.Log($"timeRemaining");
			//	}
			//}

			//if(timeRemaining == 5f)
			//{
                
   //         }
		}
	}
}