using UnityEngine;
using UnityEngine.UI;

public class Queen : BasePiece
{
    public override void Setup(Color newTeamColor, Color32 newSpriteColor, PieceManager newPieceManager)
    {
        // Base setup
        base.Setup(newTeamColor, newSpriteColor, newPieceManager);

        // Queen stuff
        mMovement = new Vector3Int(7, 7, 7);

        #region loading the original image
        //GetComponent<Image>().sprite = Resources.Load<Sprite>("T_Queen");
        #endregion

        #region loading custom image
        if (newTeamColor == Color.white)
        {
            GetComponent<Image>().sprite = Resources.Load<Sprite>("QueenWhite");
        }
        else if (newTeamColor == Color.black)
        {
            GetComponent<Image>().sprite = Resources.Load<Sprite>("QueenBlack");
        }
        #endregion
    }
}
