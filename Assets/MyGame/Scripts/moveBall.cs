
using UnityEngine;

public class moveBall : MonoBehaviour
{
  [SerializeField]  private GameObject[] ballPositions;


  public GameObject Ball;
  int  PosRandom;
  int PosBefore;

  void SetBallRandom () {
      PosRandom = 0;
      PosBefore = 4;
  }


    void SetPosition () {
        Ball.transform.position = ballPositions[PosRandom].transform.position;

    }

    
public void getPosBefore(){
PosRandom = Random.Range(0,4);
    if (PosRandom != PosBefore)
{
PosBefore = PosRandom;
SetPosition();
}
else {
    getPosBefore();
}

}
   

}










