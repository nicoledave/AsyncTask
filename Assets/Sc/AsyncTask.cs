using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading.Tasks;
using UnityEngine;

public class AsyncTask : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 1.
        Debug.Log("Mother Fox went hunting");
        FoxCubsSleepingAsync();
        Debug.Log("Mother Fox catch her prey and coming back home");
        
        // 2.
        Debug.Log("Mother Fox start to play with her fox cubs");
        AsyncTaskColling();
        Debug.Log("Mother fox lay down");
        
        // 5.
        AwaitTaskAllStart();
    }

    public async void AwaitTaskAllStart()
    {
        await FoxDayAllTask();
    }
    
    // 1. 
    public async void FoxCubsSleepingAsync()
    {
        Debug.Log("Fox cubs fall to sleep");
        await Task.Delay(2000);
        Debug.Log("Fox cubs wake up");
    }
    
    // 2.
    public async void AsyncTaskColling()
    {
        await FoxCubsPlayTime();
        await MotherFoxCleaningFoxCubs();
    }
    public async Task FoxCubsPlayTime()
    {
        Debug.Log("Fox cubs start to playing around");
        await Task.Delay(3000);
        Debug.Log("Fox cubs keep playing with etch other");
    }
    
    // 3.
    public async Task MotherFoxCleaningFoxCubs()
    {
        Debug.Log("Mother fox start to clean her fox cubs");
        await Task.Delay(1000);
        Debug.Log("Fox cubs now clean");
        
        // 4.
        FoxCubsSleepingAsync();
    }
    
    // 5. 
    public async Task FoxDayAllTask()
    {
        Debug.Log("*** Fox all the task started ***");
        await Task.WhenAll(FoxCubsPlayTime(), MotherFoxCleaningFoxCubs());
        Debug.Log("*** Fox all the task finished ***");
    }
    
    
}
