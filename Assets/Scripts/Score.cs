using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
   public Transform Player;
   public Text scoreText;
   
   void Update (){
       if(Player.position.z>0){
            scoreText.text = Player.position.z.ToString("0");
       }
       else
       {
           scoreText.text = "0";
       }
   }
}
