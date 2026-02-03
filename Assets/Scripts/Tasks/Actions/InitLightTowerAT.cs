using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
    public class InitLightTowerAT : ActionTask
    {
        public BBParameter<Light> lightBBP;
        public BBParameter<Transform> workpadBBP;

        public string workPadName = "Work Pad";
        protected override string OnInit()
        {
            lightBBP.value = agent.GetComponentInChildren<Light>();
            workpadBBP.value = agent.transform.Find("Work Pad");

            if (lightBBP.value != null && workpadBBP.value) return null;
            else return $"InitLightTowerAT in {agent.name}: Unable to find all references!";
        }
    }
}
