//Firebase was TO large to upload to github

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.Networking;
// using System.IO;
// using Firebase;
// using Firebase.Database;
// using Firebase.Extensions;


// // This is the struct for the highscore
// [System.Serializable]
// struct HighscoreStruct
// {
//     public string name;
//     public int score;
// }


// // This is the basic class for the highscore system
// public class Highscore
// {
//     public readonly string tempFoler = Application.dataPath + "/Savedata/";
//     public readonly string dataBaseURL = "";
    
//     //This references our database in firebase
//     DatabaseReference databaseReference;
     
//     // This is the constructor for the highscore class
//     public Highscore(){
//         databaseReference = FirebaseDatabase.DefaultInstance.RootReference;
//         HighscoreStruct test = new HighscoreStruct();
//         test.name = "Test";
//         test.score = 100;
//         string jsonString = JsonUtility.ToJson(test);

//         databaseReference.Child("Player").Child(test.name).SetRawJsonValueAsync(jsonString);
//         Debug.Log(databaseReference);
//     }

//     // This is the function to get the highscore
//     public IEnumerator GetHighscore()
//     {

//         // We would use this to get the highscore though unity webhandles but we want to be used Firebase.

               
//         // UnityWebRequest www = UnityWebRequest.Get(jsonURL);
        
//         // yield return www.SendWebRequest();

//         // if(www.isNetworkError || www.isHttpError)
//         // {
//         //     Debug.Log(www.error);
//         // }
//         // else
//         // {
//         //     HighscoreStruct highscore = JsonUtility.FromJson<HighscoreStruct>(www.downloadHandler.text);
//         //     Debug.Log("Highscore: " + highscore);
//         // }
        
//         // yield return www;
//         yield return null;

//     }


//     // This is the function to set the highscore
//     public IEnumerator HighscoreEntry(){
       
//         HighscoreStruct test = new HighscoreStruct();
//         test.name = "Test";
//         test.score = 100;


//         string jsonString = JsonUtility.ToJson(test);

//         databaseReference.Child("Player").Child(test.name).SetRawJsonValueAsync(jsonString);

//         Debug.Log(databaseReference);

//         // databaseReference.GetValueAsync().ContinueWith(task => {
//         //     if(task.IsFaulted){
//         //         Debug.Log("Error");
//         //     }else if(task.IsCompleted){
//         //         DataSnapshot snapshot = task.Result;
//         //         Debug.Log(snapshot);
//         //     }
//         // });

       

//         yield return null;

//         // .ContinueWith(task => {
            
//         //     if(task.IsFaulted){
//         //         Debug.Log(task.Exception);
//         //         Debug.LogError("Error");
            
//         //     }else if(task.IsCompleted){
//         //         Debug.Log("Success");
//         //     }
//         // });


//         // if(File.Exists(tempFoler +"Savedata.json")){
//         //     File.Delete(tempFoler +"Savedata.json");
//         // }else{
//         //     Directory.CreateDirectory(tempFoler);
//         // }

//         // Debug.Log(tempFoler + "Savedata.json");
        
//         // string jsonString =  JsonUtility.ToJson(test);
        
//         // //File.Create(tempFoler + "Savedata.json");
        
//         // File.WriteAllText(tempFoler + "Savedata.json", JsonUtility.ToJson(jsonString));

//         // var file = new UnityGoogleDrive.Data.File(){Name = "Savedata.json", Content = File.ReadAllBytes(tempFoler + "Savedata.json")};
        
//         // yield return request.Send();

//         // if(request.IsError){
//         //     Debug.LogError(request.Error);
//         //     yield break;
//         // }   

//         // Debug.Log("File created: " + request.ResponseData.Id);
        


//     }


    

    
// }
