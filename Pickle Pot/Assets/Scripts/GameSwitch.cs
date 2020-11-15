using System;
using UnityEngine;

[CreateAssetMenu]
public class GameSwitch : ScriptableObject
{
    public enum GameStates
    {
        Starting,
        Playing,
        Ending,
        InStore,
        Pausing
    }

    public GameStates currentGameState = GameStates.Starting;

    public void ChangeToPlaying()
    {
        currentGameState = GameStates.Playing;
    }

    public void RunCurrentState()
    
    {
        switch (currentGameState)
        {
            case GameStates.Starting:
                Debug.Log("Starting");
                break;
            case GameStates.Playing:
                Debug.Log("Playing");
                break;
            case GameStates.Ending:
                Debug.Log("Ending");
                break;
            case GameStates.InStore:
                Debug.Log("InStore");
                break;
            case GameStates.Pausing:
                Debug.Log("Pausing");
                break;
   
   
        }
    }
}
