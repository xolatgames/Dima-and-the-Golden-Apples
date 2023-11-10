using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent (typeof (ChangeTheScene))]
public class Point : MonoBehaviour
{
    enum Event {ChangeScene, PlayStory, PickUpTheSword};

    [SerializeField]
    private Event currentEvent;
    [SerializeField]
    private string changeToTheScene;
    [SerializeField]
    private Animator playStory;

    private void Start() {
        if (currentEvent == Event.PickUpTheSword && GameStats.instance.sword)
        {
            Destroy(gameObject);
        }
    }

    public void callTheEvent()
    {
        switch (currentEvent)
        {
            case Event.ChangeScene:
                GetComponent<ChangeTheScene>().ChangeToTheScene(changeToTheScene);
                break;
            case Event.PlayStory:
                playStory.Play("Entry");
                Destroy(gameObject);
                break;
            case Event.PickUpTheSword:
                GameStats.instance.sword = true;
                Destroy(gameObject);
                break;
        }
    }
}
