using UnityEngine;
using UnityEngine.UI;

public class Bishop : BasePiece
{
    public override void Setup(Color newTeamColor, Color32 newSpriteColor, PieceManager newPieceManager)
    {
        // Base setup
        base.Setup(newTeamColor, newSpriteColor, newPieceManager);

        // Bishop stuff
        mMovement = new Vector3Int(0, 0, 7);

        #region loading the original image
        //GetComponent<Image>().sprite = Resources.Load<Sprite>("T_Bishop");
        #endregion

        #region loading custom image
        if (newTeamColor == Color.white)
        {
            GetComponent<Image>().sprite = Resources.Load<Sprite>("BishopWhite");
        }
        else if (newTeamColor == Color.black)
        {
            GetComponent<Image>().sprite = Resources.Load<Sprite>("BishopBlack");
        }
        #endregion
    }
}
