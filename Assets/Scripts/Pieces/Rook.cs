using UnityEngine;
using UnityEngine.UI;

public class Rook : BasePiece
{
    [HideInInspector]
    public Cell mCastleTriggerCell = null;
    private Cell mCastleCell = null;

    public override void Setup(Color newTeamColor, Color32 newSpriteColor, PieceManager newPieceManager)
    {
        // Base setup
        base.Setup(newTeamColor, newSpriteColor, newPieceManager);

        // Rook stuff
        mMovement = new Vector3Int(7, 7, 0);

        #region loading the original image
        //GetComponent<Image>().sprite = Resources.Load<Sprite>("T_Rook");
        #endregion

        #region loading custom image
        if (newTeamColor == Color.white)
        {
            GetComponent<Image>().sprite = Resources.Load<Sprite>("RookWhite");
        }
        else if (newTeamColor == Color.black)
        {
            GetComponent<Image>().sprite = Resources.Load<Sprite>("RookBlack");
        }
        #endregion
    }

    public override void Place(Cell newCell)
    {
        base.Place(newCell);

        // Trigger cell
        int triggerOffset = mCurrentCell.mBoardPosition.x < 4 ? 2 : -1;
        mCastleTriggerCell = SetCell(triggerOffset);

        // Castle cell
        int castleOffset = mCurrentCell.mBoardPosition.x < 4 ? 3 : -2;
        mCastleCell = SetCell(castleOffset);
    }

    public void Castle()
    {
        // Set new target
        mTargetCell = mCastleCell;

        // Move
        Move();
    }

    private Cell SetCell(int offset)
    {
        // New position
        Vector2Int newPosition = mCurrentCell.mBoardPosition;
        newPosition.x += offset;

        // Return
        return mCurrentCell.mBoard.mAllCells[newPosition.x, newPosition.y];
    }
}
