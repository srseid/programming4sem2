using NodeCanvas.Framework;
using UnityEngine;

public class ToggleScoutingActionTask : ActionTask
{
   public BBParameter<bool> scoutingBBP;
   public AudioSource source;
   public AudioClip clip;

    protected override void OnExecute()
    {
        scoutingBBP.value = !scoutingBBP.value;
        //toggle value

        AudioManager.Instance.PlaySoundEffect(clip, source);
        
        //play the audio clip

        EndAction(true);
    }
}
