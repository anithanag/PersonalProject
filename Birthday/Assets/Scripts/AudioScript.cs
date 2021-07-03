using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using Vuforia;



public class AudioScript : MonoBehaviour, ITrackableEventHandler
{
    public static AudioScript instance;
    private TrackableBehaviour mTrackableBehaviour;
   public AudioSource audio;
    public ParticleSystem spark;
   // public PlayableDirector germanTimeline;
    public PlayableDirector englishTimeline;
    bool resumeCount;
    public GameObject panel;
    TimelineAsset tlAsset;

    [Header("Animation Controller")]
    //public Animator model;
     RuntimeAnimatorController germanController;
     RuntimeAnimatorController englishController;

    void Start()
    {
        
        instance = this;
       // audio = GetComponent<AudioSource>();
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
        
    }
    void Update()
    {
        //if (germanTimeline.gameObject.activeInHierarchy == true)
        //{
        //    model.runtimeAnimatorController = germanController;
        //}
        //if (englishTimeline.gameObject.activeInHierarchy == true)
        //{
        //    model.runtimeAnimatorController = englishController;
        //}
    }
    
    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            
            
            englishTimeline.Play();
            audio.Play();

            spark.Play();
            panel.SetActive(true);
            
            if (resumeCount)
            {
               
                
                englishTimeline.Resume();
                    
                resumeCount = false;
                Debug.Log(resumeCount);
                panel.SetActive(true);
                
            }
        }
        else
        {
            Debug.Log("else");
            
                englishTimeline.Pause();
               // model.runtimeAnimatorController = germanController;
            
            panel.SetActive(false);
            resumeCount = true;
            Debug.Log(resumeCount);
            audio.Pause();

        }


    }
    
}
