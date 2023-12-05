using System;

public class AudioAction : CustomAction
{
   private AudioManager audioManager;
   private string clipName;

   public override bool ActionEnded()
   {
      Audio target = Array.Find(audioManager.audioClips, clip => clip.name == clipName);

     return !target.source.isPlaying;
   }

    public override void StartAction()
    {
      audioManager.Play(clipName);
    }

    public AudioAction(AudioManager audioManager, string clipName, bool waitForFinish)
   {
      this.audioManager = audioManager;
      this.clipName = clipName;
      this.waitForFinish = waitForFinish;
   }
}
